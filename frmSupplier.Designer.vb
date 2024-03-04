<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        dgvSupplier = New DataGridView()
        Panel1 = New Panel()
        btnAdd = New Button()
        btnShowAll = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        CType(dgvSupplier, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 45)
        Label1.TabIndex = 0
        Label1.Text = "Suppliers"
        ' 
        ' dgvSupplier
        ' 
        dgvSupplier.AllowUserToAddRows = False
        dgvSupplier.AllowUserToDeleteRows = False
        dgvSupplier.AllowUserToResizeColumns = False
        dgvSupplier.AllowUserToResizeRows = False
        dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSupplier.BackgroundColor = Color.White
        dgvSupplier.BorderStyle = BorderStyle.None
        dgvSupplier.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.MidnightBlue
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvSupplier.DefaultCellStyle = DataGridViewCellStyle5
        dgvSupplier.Location = New Point(10, 60)
        dgvSupplier.Name = "dgvSupplier"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvSupplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvSupplier.RowHeadersVisible = False
        dgvSupplier.RowHeadersWidth = 62
        dgvSupplier.Size = New Size(1030, 630)
        dgvSupplier.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnShowAll)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(btnDelete)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(10, 690)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1030, 50)
        Panel1.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(190, 8)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Insert"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnShowAll
        ' 
        btnShowAll.Location = New Point(749, 8)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(112, 34)
        btnShowAll.TabIndex = 5
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(320, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(601, 8)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(461, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' frmSupplier
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(1050, 750)
        Controls.Add(Panel1)
        Controls.Add(dgvSupplier)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSupplier"
        Padding = New Padding(10)
        Text = "frmSupplier"
        CType(dgvSupplier, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
End Class
