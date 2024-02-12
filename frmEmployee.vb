Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmEmployee

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        conn.Open()
        showdata()

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT * FROM Employee", conn)
        adp.Fill(ds, "Employee")
        dgvEmployee.DataSource = ds.Tables("Employee")

    End Sub

    Private Sub frmEmployee_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        conn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            Dim query As String = "INSERT INTO Employee(Emp_Name,Emp_UserName,Emp_password,Emp_Salary,Emp_Type) VALUES('" & txtName.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "'," & txtSalary.Text & ",'" & txtType.Text & "')"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data inserted successfully!")
            showdata()

        Catch ex As Exception

            MessageBox.Show("Error inserting employee data: " & ex.Message)

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim query As String = "UPDATE Employee SET Emp_Name='" & txtName.Text & "', Emp_UserName='" & txtUsername.Text & "', Emp_password='" & txtPassword.Text & "', Emp_Salary=" & txtSalary.Text & ", Emp_Type='" & txtType.Text & "' WHERE Emp_Id=" & txtId.Text & ""
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data Updated successfully!")
            showdata()

        Catch ex As Exception

            MessageBox.Show("Error Updating employee data: " & ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            Dim query As String = "DELETE FROM Employee  WHERE Emp_Id=" & txtId.Text & ""
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data Deleted successfully!")
            showdata()

        Catch ex As Exception

            MessageBox.Show("Error Deleting employee data: " & ex.Message)

        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try

            Dim query As String = "SELECT * FROM Employee WHERE Emp_Id=" & txtId.Text & ""
            ds.Clear()
            adp = New OleDbDataAdapter(query, conn)
            adp.Fill(ds, "Employee")
            dgvEmployee.DataSource = ds.Tables("Employee")

        Catch ex As Exception

            MessageBox.Show("Error Displaying employee data: " & ex.Message)

        End Try

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub
End Class