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
        fields.Add("Name")
        fields.Add("Username")
        fields.Add("Password")
        fields.Add("Salary")
        fields.Add("Designation")

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
            Try

                showdata()

            Catch ex As Exception

                MessageBox.Show("Error inserting employee data: " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim update As New frmUpdateDialog(fields, "Username")
        If update.ShowDialog() = DialogResult.OK Then
            Dim query As String = "UPDATE Employee SET "
            values.Clear()
            selectedFields.Clear()
            selectedFields = update.SelectedFields
            values = update.UpdateValues
            Dim where As String = update.whereValue
            Try
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Salary") Then
                        query &= selectedFields(i) & " = " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If

                    If i < selectedFields.Count - 1 Then
                        query &= ","
                    End If

                Next
                query &= " WHERE Username = @Username"
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", where)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                conn.Close()
                If rowsAffected > 0 Then
                    MessageBox.Show("Employee data updated successfully!")
                    showdata()
                Else
                    MessageBox.Show("No records were updated.")
                End If

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Updating employee data: " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim delete As New frmDeleteDialog(fields)
        If delete.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            Dim query As String = "DELETE FROM Employee WHERE "
            selectedFields = delete.SelectedFields
            values = delete.DeleteValues
            Try
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Salary") Then
                        query &= selectedFields(i) & " = " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee data Deleted successfully!")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Deleting employee data: " & ex.Message)

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

            Dim comparativeOperator As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT Username,[Name],Salary,Designation FROM Employee WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Salary") Then
                        query &= selectedFields(i) & " " & comparativeOperator & " " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                ds.Clear()
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(ds, "Employee")
                dgvPurchase.DataSource = ds.Tables("Employee")

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Displaying employee data: " & ex.Message)

            End Try
        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub

End Class