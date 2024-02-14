<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtSalary = New TextBox()
        txtType = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnInsert = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(270, 53)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(270, 125)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(270, 198)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 4
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(270, 280)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(150, 31)
        txtSalary.TabIndex = 5
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(270, 365)
        txtType.Name = "txtType"
        txtType.Size = New Size(150, 31)
        txtType.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(106, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 28)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(106, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 30)
        Label4.TabIndex = 8
        Label4.Text = "Salary"
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(106, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 30)
        Label5.TabIndex = 9
        Label5.Text = "Type"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(106, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 30)
        Label6.TabIndex = 1
        Label6.Text = "Name"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(106, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 30)
        Label7.TabIndex = 2
        Label7.Text = "Username"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(106, 480)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(112, 34)
        btnInsert.TabIndex = 10
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(308, 480)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmInsertDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 573)
        Controls.Add(btnCancel)
        Controls.Add(Label7)
        Controls.Add(btnInsert)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtType)
        Controls.Add(txtSalary)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label6)
        Controls.Add(txtName)
        Name = "frmInsertDialog"
        Text = "frmInsertDialog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnCancel As Button
End Class
