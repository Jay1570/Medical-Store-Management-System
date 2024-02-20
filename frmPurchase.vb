Imports System.Data.OleDb
Public Class frmPurchase

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

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

        Dim insert As New frmInsert()
        If insert.ShowDialog() = DialogResult.OK Then

            MessageBox.Show("Inserted Successfully")

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            selectedFields = search.SelectedFields
            values = search.SearchValues

            Dim comparativeOperator As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT p.Name AS [Product Name], s.Name AS [Supplier Name], c.Date, c.Quantity, c.Amount FROM (Products AS p INNER JOIN PurchaseLog AS c ON p.Id = c.pid)INNER JOIN Supplier AS s ON c.sid = s.ID WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Quantity") Or selectedFields(i).Contains("Amount") Then
                        query &= selectedFields(i) & " " & comparativeOperator & " " & values(i) & " "
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
                        Dim f As String = $"{dateParts(1)}/{dateParts(0)}/{dateParts(2)}"
                        query &= $"{selectedFields(i)} = '#{f}' "
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