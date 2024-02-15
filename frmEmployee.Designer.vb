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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvEmployee = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        btnShowAll = New Button()
        Panel1 = New Panel()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvEmployee.DefaultCellStyle = DataGridViewCellStyle2
        dgvEmployee.Dock = DockStyle.Top
        dgvEmployee.Location = New Point(0, 0)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.RowHeadersWidth = 62
        dgvEmployee.Size = New Size(1050, 700)
        dgvEmployee.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(190, 8)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Insert"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(320, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(461, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(601, 8)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnShowAll
        ' 
        btnShowAll.Location = New Point(749, 8)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(112, 34)
        btnShowAll.TabIndex = 12
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnShowAll)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(btnDelete)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 700)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1050, 50)
        Panel1.TabIndex = 13
        ' 
        ' frmEmployee
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1050, 750)
        Controls.Add(Panel1)
        Controls.Add(dgvEmployee)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEmployee"
        Text = "frmEmployee"
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents Panel1 As Panel
End Class
