<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Label1 = New Label()
        dgvPurchase = New DataGridView()
        Panel1 = New Panel()
        btnAdd = New Button()
        btnShowAll = New Button()
        btnSearch = New Button()
        CType(dgvPurchase, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Size = New Size(318, 45)
        Label1.TabIndex = 15
        Label1.Text = "Purchase History"
        ' 
        ' dgvPurchase
        ' 
        dgvPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPurchase.BackgroundColor = Color.White
        dgvPurchase.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPurchase.DefaultCellStyle = DataGridViewCellStyle2
        dgvPurchase.Location = New Point(10, 60)
        dgvPurchase.Name = "dgvPurchase"
        dgvPurchase.RowHeadersVisible = False
        dgvPurchase.RowHeadersWidth = 62
        dgvPurchase.Size = New Size(1030, 630)
        dgvPurchase.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnShowAll)
        Panel1.Controls.Add(btnSearch)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(10, 690)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1030, 50)
        Panel1.TabIndex = 17
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(311, 8)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Insert"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnShowAll
        ' 
        btnShowAll.Location = New Point(607, 8)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(112, 34)
        btnShowAll.TabIndex = 12
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(459, 8)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' frmPurchase
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(1050, 750)
        Controls.Add(Panel1)
        Controls.Add(dgvPurchase)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPurchase"
        Padding = New Padding(10)
        Text = "frmPurchase"
        CType(dgvPurchase, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPurchase As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnSearch As Button
End Class
