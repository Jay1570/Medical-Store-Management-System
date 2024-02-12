<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        dgvEmployee = New DataGridView()
        txtName = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtSalary = New TextBox()
        txtType = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        txtId = New TextBox()
        Label6 = New Label()
        btnShowAll = New Button()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Location = New Point(0, 250)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.RowHeadersWidth = 62
        dgvEmployee.Size = New Size(1050, 500)
        dgvEmployee.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(205, 54)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(494, 54)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(779, 54)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 3
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(205, 146)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(150, 31)
        txtSalary.TabIndex = 4
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(494, 146)
        txtType.Name = "txtType"
        txtType.Size = New Size(150, 31)
        txtType.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(379, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 0
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(668, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 0
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(122, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 25)
        Label4.TabIndex = 0
        Label4.Text = "Salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(379, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 25)
        Label5.TabIndex = 0
        Label5.Text = "Type"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(161, 204)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Insert"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(315, 204)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(469, 204)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(623, 204)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(779, 146)
        txtId.Name = "txtId"
        txtId.Size = New Size(150, 31)
        txtId.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(668, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 25)
        Label6.TabIndex = 11
        Label6.Text = "Id"
        ' 
        ' btnShowAll
        ' 
        btnShowAll.Location = New Point(777, 204)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(112, 34)
        btnShowAll.TabIndex = 12
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = True
        ' 
        ' frmEmployee
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1050, 750)
        Controls.Add(btnShowAll)
        Controls.Add(Label6)
        Controls.Add(txtId)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtType)
        Controls.Add(txtSalary)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtName)
        Controls.Add(dgvEmployee)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEmployee"
        Text = "frmEmployee"
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnShowAll As Button
End Class
