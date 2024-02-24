Imports System.Data.OleDb
Public Class frmPurchase

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmEmployee_Show(sender As Object, e As EventArgs) Handles MyBase.Shown

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        fields.Add("Product Name")
        fields.Add("Supplier Name")
        fields.Add("Date")
        fields.Add("Quantity")
        fields.Add("Amount")

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT p.Name AS [Product Name], s.Name AS [Supplier Name], c.Date, c.Quantity, c.Amount 
                                    FROM (Products AS p 
                                    INNER JOIN PurchaseLog AS c ON p.Id = c.pid)
                                    INNER JOIN Supplier AS s ON c.sid = s.ID", conn)
        adp.Fill(ds)
        dgvPurchase.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertDialog(fields)
        If insert.ShowDialog() = DialogResult.OK Then
            values.Clear()
            values = insert.InsertValues
            Dim pid, stock, sid, price As Integer
            Try

                conn.Open()
                cmd = New OleDbCommand("SELECT Id,Stock,price FROM Products WHERE [Name] = @name", conn)
                cmd.Parameters.AddWithValue("@name", values(0))
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If (reader.Read()) Then
                    pid = Val(reader("Id").ToString())
                    stock = Val(reader("Stock").ToString())
                    price = Val(reader("Price").ToString())
                End If
                price = price - (price * 0.4)
                cmd = New OleDbCommand("SELECT Id FROM Supplier WHERE [Name] = @sname", conn)
                cmd.Parameters.AddWithValue("@sname", values(1))
                sid = Val(cmd.ExecuteScalar().ToString())
                stock += values(2)
                cmd = New OleDbCommand("UPDATE Products SET Stock = " & stock & " WHERE Id = " & pid, conn)
                cmd.ExecuteNonQuery()
                Dim query = "INSERT INTO PurchaseLog(pid,sid,[Date],Quantity,Amount) VALUES(@pid,@sid,@date,@quantity,@amount)"
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@pid", pid)
                cmd.Parameters.AddWithValue("@sid", sid)
                cmd.Parameters.AddWithValue("@date", DateTime.Today)
                cmd.Parameters.AddWithValue("@quantity", values(2))
                cmd.Parameters.AddWithValue("@amount", values(2) * price)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Inserted Successfully")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error :- " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            selectedFields = search.SelectedFields
            values = search.SearchValues
            Dim f As String

            Dim comparativeOperator() As String = search.ComparativeOperators

            Try

                Dim j As Integer = 0
                Dim query As String = "SELECT p.Name AS [Product Name], s.Name AS [Supplier Name], c.Date, c.Quantity, c.Amount FROM (Products AS p INNER JOIN PurchaseLog AS c ON p.Id = c.pid)INNER JOIN Supplier AS s ON c.sid = s.ID WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Quantity") Or selectedFields(i).Contains("Amount") Then
                        query &= selectedFields(i) & " " & comparativeOperator(j) & " " & values(i) & " "
                        j += 1
                    ElseIf selectedFields(i).Contains("Product Name") Then
                        conn.Open()
                        Dim p = New OleDbCommand("SELECT Id FROM Products WHERE [Name] = '" & values(i) & "'", conn)
                        Dim pid As Integer = Val(p.ExecuteScalar())
                        conn.Close()
                        query &= "pid = " & pid.ToString() & " "
                    ElseIf selectedFields(i).Contains("Supplier Name") Then
                        conn.Open()
                        Dim s = New OleDbCommand("SELECT Id FROM Supplier WHERE [Name] = '" & values(i) & "'", conn)
                        Dim sid As Integer = Val(s.ExecuteScalar())
                        conn.Close()
                        query &= "sid = " & sid.ToString() & " "
                    ElseIf selectedFields(i).Contains("Date") Then
                        Dim dateParts As String() = values(i).Split("-"c)
                        f = $"{dateParts(0)}/{dateParts(1)}/{dateParts(2)}"
                        Dim d As DateTime = DateTime.Parse(f)
                        query &= selectedFields(i) & " = #" & d & "# "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If

                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                ds.Clear()
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(ds)
                dgvPurchase.DataSource = ds.Tables(0)
            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error :- " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub

End Class