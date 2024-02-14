Imports System.Management

Public Class frmInsertDialog

    Public Property query As String

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        query = "INSERT INTO Employee(Emp_Name,Emp_UserName,Emp_password,Emp_Salary,Emp_Type) VALUES('" & txtName.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "'," & txtSalary.Text & ",'" & txtType.Text & "')"
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class