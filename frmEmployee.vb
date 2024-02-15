Imports System.Buffers
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmEmployee

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        fields.Add("Emp_Name")
        fields.Add("Emp_UserName")
        fields.Add("Emp_Password")
        fields.Add("Emp_Salary")
        fields.Add("Emp_Type")

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT Emp_UserName,Emp_Name,Emp_Salary,Emp_Type FROM Employee", conn)
        adp.Fill(ds, "Employee")
        dgvEmployee.DataSource = ds.Tables("Employee")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertDialog()
        If insert.ShowDialog() = DialogResult.OK Then
            Dim query As String = insert.query
            Try
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee data inserted successfully!")
                conn.Close()
                showdata()

            Catch ex As Exception

                MessageBox.Show("Error inserting employee data: " & ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            conn.Open()
            Dim query As String = "UPDATE Employee SET Emp_Name='" & txtName.Text & "', Emp_UserName='" & txtUsername.Text & "', Emp_password='" & txtPassword.Text & "', Emp_Salary=" & txtSalary.Text & ", Emp_Type='" & txtType.Text & "' WHERE Emp_Id=" & txtId.Text & ""
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data Updated successfully!")
            conn.Close()
            showdata()

        Catch ex As Exception

            MessageBox.Show("Error Updating employee data: " & ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            conn.Open()
            Dim query As String = "DELETE FROM Employee  WHERE Emp_Id=" & txtId.Text & ""
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data Deleted successfully!")
            conn.Close()
            showdata()

        Catch ex As Exception

            MessageBox.Show("Error Deleting employee data: " & ex.Message)

        End Try


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            Dim selectedFields As List(Of String) = search.SelectedFields
            Dim searchValues As List(Of String) = search.SearchValues
            Dim comparativeOperator As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT Emp_UserName,Emp_Name,Emp_Salary,Emp_Type FROM Employee WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Emp_Salary") Then
                        query &= selectedFields(i) & " " & comparativeOperator & " " & searchValues(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & searchValues(i) & "' "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                ds.Clear()
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(ds, "Employee")
                dgvEmployee.DataSource = ds.Tables("Employee")

            Catch ex As Exception

                MessageBox.Show("Error Displaying employee data: " & ex.Message)

            End Try
        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub

End Class