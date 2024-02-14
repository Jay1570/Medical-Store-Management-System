<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDialog
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
        chkName = New CheckBox()
        chkUsername = New CheckBox()
        chkSalary = New CheckBox()
        chkType = New CheckBox()
        txtName = New TextBox()
        txtUsername = New TextBox()
        txtSalary = New TextBox()
        txtType = New TextBox()
        ComboBox1 = New ComboBox()
        btnSearch = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' chkName
        ' 
        chkName.Location = New Point(52, 56)
        chkName.Name = "chkName"
        chkName.Size = New Size(163, 30)
        chkName.TabIndex = 0
        chkName.Tag = "txtName"
        chkName.Text = "Emp_Name"
        chkName.UseVisualStyleBackColor = True
        ' 
        ' chkUsername
        ' 
        chkUsername.Location = New Point(52, 123)
        chkUsername.Name = "chkUsername"
        chkUsername.Size = New Size(163, 30)
        chkUsername.TabIndex = 1
        chkUsername.Tag = "txtUsername"
        chkUsername.Text = "Emp_UserName"
        chkUsername.UseVisualStyleBackColor = True
        ' 
        ' chkSalary
        ' 
        chkSalary.Location = New Point(52, 188)
        chkSalary.Name = "chkSalary"
        chkSalary.Size = New Size(163, 30)
        chkSalary.TabIndex = 2
        chkSalary.Tag = "txtSalary"
        chkSalary.Text = "Emp_Salary"
        chkSalary.UseVisualStyleBackColor = True
        ' 
        ' chkType
        ' 
        chkType.Location = New Point(52, 249)
        chkType.Name = "chkType"
        chkType.Size = New Size(163, 30)
        chkType.TabIndex = 3
        chkType.Tag = "txtType"
        chkType.Text = "Emp_Type"
        chkType.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Enabled = False
        txtName.Location = New Point(286, 55)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Enabled = False
        txtUsername.Location = New Point(286, 122)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 5
        ' 
        ' txtSalary
        ' 
        txtSalary.Enabled = False
        txtSalary.Location = New Point(286, 187)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(150, 31)
        txtSalary.TabIndex = 6
        ' 
        ' txtType
        ' 
        txtType.Enabled = False
        txtType.Location = New Point(286, 248)
        txtType.Name = "txtType"
        txtType.Size = New Size(150, 31)
        txtType.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"=", "<=", ">=", "<", ">"})
        ComboBox1.Location = New Point(470, 185)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(69, 33)
        ComboBox1.TabIndex = 8
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(161, 371)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(324, 371)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmSearchDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(612, 438)
        Controls.Add(btnCancel)
        Controls.Add(btnSearch)
        Controls.Add(ComboBox1)
        Controls.Add(txtType)
        Controls.Add(txtSalary)
        Controls.Add(txtUsername)
        Controls.Add(txtName)
        Controls.Add(chkType)
        Controls.Add(chkSalary)
        Controls.Add(chkUsername)
        Controls.Add(chkName)
        Name = "frmSearchDialog"
        Text = "frmSearchDialog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkName As CheckBox
    Friend WithEvents chkUsername As CheckBox
    Friend WithEvents chkSalary As CheckBox
    Friend WithEvents chkType As CheckBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button
End Class
