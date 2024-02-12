<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Panel1 = New Panel()
        btnClose = New Button()
        btnReports = New Button()
        btnSales = New Button()
        btnSupplier = New Button()
        btnProducts = New Button()
        btnEmployee = New Button()
        btnOverView = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnSales)
        Panel1.Controls.Add(btnSupplier)
        Panel1.Controls.Add(btnProducts)
        Panel1.Controls.Add(btnEmployee)
        Panel1.Controls.Add(btnOverView)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 750)
        Panel1.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = SystemColors.MenuHighlight
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(0, 544)
        btnClose.Name = "btnClose"
        btnClose.Padding = New Padding(10, 0, 0, 0)
        btnClose.Size = New Size(250, 60)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.TextAlign = ContentAlignment.MiddleLeft
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = SystemColors.MenuHighlight
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 12F)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(0, 484)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(10, 0, 0, 0)
        btnReports.Size = New Size(250, 60)
        btnReports.TabIndex = 8
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnSales
        ' 
        btnSales.BackColor = SystemColors.MenuHighlight
        btnSales.Cursor = Cursors.Hand
        btnSales.FlatAppearance.BorderSize = 0
        btnSales.FlatStyle = FlatStyle.Flat
        btnSales.Font = New Font("Segoe UI", 12F)
        btnSales.ForeColor = Color.White
        btnSales.Location = New Point(0, 424)
        btnSales.Name = "btnSales"
        btnSales.Padding = New Padding(10, 0, 0, 0)
        btnSales.Size = New Size(250, 60)
        btnSales.TabIndex = 7
        btnSales.Text = "Sales"
        btnSales.TextAlign = ContentAlignment.MiddleLeft
        btnSales.UseVisualStyleBackColor = False
        ' 
        ' btnSupplier
        ' 
        btnSupplier.BackColor = SystemColors.MenuHighlight
        btnSupplier.Cursor = Cursors.Hand
        btnSupplier.FlatAppearance.BorderSize = 0
        btnSupplier.FlatStyle = FlatStyle.Flat
        btnSupplier.Font = New Font("Segoe UI", 12F)
        btnSupplier.ForeColor = Color.White
        btnSupplier.Location = New Point(0, 364)
        btnSupplier.Name = "btnSupplier"
        btnSupplier.Padding = New Padding(10, 0, 0, 0)
        btnSupplier.Size = New Size(250, 60)
        btnSupplier.TabIndex = 6
        btnSupplier.Text = "Supplier"
        btnSupplier.TextAlign = ContentAlignment.MiddleLeft
        btnSupplier.UseVisualStyleBackColor = False
        ' 
        ' btnProducts
        ' 
        btnProducts.BackColor = SystemColors.MenuHighlight
        btnProducts.Cursor = Cursors.Hand
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.Font = New Font("Segoe UI", 12F)
        btnProducts.ForeColor = Color.White
        btnProducts.Location = New Point(0, 304)
        btnProducts.Name = "btnProducts"
        btnProducts.Padding = New Padding(10, 0, 0, 0)
        btnProducts.Size = New Size(250, 60)
        btnProducts.TabIndex = 5
        btnProducts.Text = "Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.UseVisualStyleBackColor = False
        ' 
        ' btnEmployee
        ' 
        btnEmployee.BackColor = SystemColors.MenuHighlight
        btnEmployee.Cursor = Cursors.Hand
        btnEmployee.FlatAppearance.BorderSize = 0
        btnEmployee.FlatStyle = FlatStyle.Flat
        btnEmployee.Font = New Font("Segoe UI", 12F)
        btnEmployee.ForeColor = Color.White
        btnEmployee.Location = New Point(0, 244)
        btnEmployee.Name = "btnEmployee"
        btnEmployee.Padding = New Padding(10, 0, 0, 0)
        btnEmployee.Size = New Size(250, 60)
        btnEmployee.TabIndex = 4
        btnEmployee.Text = "Employee"
        btnEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnOverView
        ' 
        btnOverView.BackColor = SystemColors.MenuHighlight
        btnOverView.Cursor = Cursors.Hand
        btnOverView.FlatAppearance.BorderSize = 0
        btnOverView.FlatStyle = FlatStyle.Flat
        btnOverView.Font = New Font("Segoe UI", 12F)
        btnOverView.ForeColor = Color.White
        btnOverView.Location = New Point(0, 184)
        btnOverView.Name = "btnOverView"
        btnOverView.Padding = New Padding(10, 0, 0, 0)
        btnOverView.Size = New Size(250, 60)
        btnOverView.TabIndex = 3
        btnOverView.Text = "Overview"
        btnOverView.TextAlign = ContentAlignment.MiddleLeft
        btnOverView.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.MenuHighlight
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(94, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 38)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(10, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 70)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 2)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(250, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(1050, 750)
        Panel3.TabIndex = 1
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1300, 750)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmHome"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOverView As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnClose As Button
End Class
