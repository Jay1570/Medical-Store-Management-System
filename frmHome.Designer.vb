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
        btnOverView = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel8 = New Panel()
        panelTop4 = New Panel()
        labelTopPrice4 = New Label()
        Panel11 = New Panel()
        panelTop3 = New Panel()
        labelTopPrice3 = New Label()
        Panel10 = New Panel()
        panelTop2 = New Panel()
        labelTopPrice2 = New Label()
        Panel9 = New Panel()
        panelTop1 = New Panel()
        labelTopPrice1 = New Label()
        Label2 = New Label()
        Panel7 = New Panel()
        panelPurchase = New Panel()
        panelSale = New Panel()
        panelQuantity = New Panel()
        btnEmployee = New Button()
        btnProducts = New Button()
        btnSupplier = New Button()
        btnSales = New Button()
        btnReports = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        panelTop4.SuspendLayout()
        Panel11.SuspendLayout()
        panelTop3.SuspendLayout()
        Panel10.SuspendLayout()
        panelTop2.SuspendLayout()
        Panel9.SuspendLayout()
        panelTop1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnSales)
        Panel1.Controls.Add(btnSupplier)
        Panel1.Controls.Add(btnProducts)
        Panel1.Controls.Add(btnEmployee)
        Panel1.Controls.Add(btnOverView)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 732)
        Panel1.TabIndex = 0
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
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel11)
        Panel3.Controls.Add(Panel10)
        Panel3.Controls.Add(Panel9)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(panelPurchase)
        Panel3.Controls.Add(panelSale)
        Panel3.Controls.Add(panelQuantity)
        Panel3.Location = New Point(260, 10)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10)
        Panel3.Size = New Size(1010, 722)
        Panel3.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel8.Controls.Add(panelTop4)
        Panel8.Location = New Point(750, 300)
        Panel8.Margin = New Padding(10)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(30)
        Panel8.Size = New Size(200, 400)
        Panel8.TabIndex = 9
        ' 
        ' panelTop4
        ' 
        panelTop4.BackColor = Color.Tan
        panelTop4.Controls.Add(labelTopPrice4)
        panelTop4.Location = New Point(0, 85)
        panelTop4.Name = "panelTop4"
        panelTop4.Size = New Size(200, 207)
        panelTop4.TabIndex = 1
        ' 
        ' labelTopPrice4
        ' 
        labelTopPrice4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice4.Location = New Point(110, 0)
        labelTopPrice4.Name = "labelTopPrice4"
        labelTopPrice4.Size = New Size(90, 36)
        labelTopPrice4.TabIndex = 1
        labelTopPrice4.Text = "Price4"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel11.Controls.Add(panelTop3)
        Panel11.Location = New Point(520, 300)
        Panel11.Margin = New Padding(10)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(30)
        Panel11.Size = New Size(200, 400)
        Panel11.TabIndex = 8
        ' 
        ' panelTop3
        ' 
        panelTop3.BackColor = Color.Tan
        panelTop3.Controls.Add(labelTopPrice3)
        panelTop3.Location = New Point(0, 85)
        panelTop3.Name = "panelTop3"
        panelTop3.Size = New Size(200, 207)
        panelTop3.TabIndex = 1
        ' 
        ' labelTopPrice3
        ' 
        labelTopPrice3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice3.Location = New Point(110, 0)
        labelTopPrice3.Name = "labelTopPrice3"
        labelTopPrice3.Size = New Size(90, 36)
        labelTopPrice3.TabIndex = 1
        labelTopPrice3.Text = "Price3"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel10.Controls.Add(panelTop2)
        Panel10.Location = New Point(290, 300)
        Panel10.Margin = New Padding(10)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(30)
        Panel10.Size = New Size(200, 400)
        Panel10.TabIndex = 7
        ' 
        ' panelTop2
        ' 
        panelTop2.BackColor = Color.Tan
        panelTop2.Controls.Add(labelTopPrice2)
        panelTop2.Location = New Point(0, 85)
        panelTop2.Name = "panelTop2"
        panelTop2.Size = New Size(200, 207)
        panelTop2.TabIndex = 10
        ' 
        ' labelTopPrice2
        ' 
        labelTopPrice2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice2.Location = New Point(110, 0)
        labelTopPrice2.Name = "labelTopPrice2"
        labelTopPrice2.Size = New Size(90, 36)
        labelTopPrice2.TabIndex = 1
        labelTopPrice2.Text = "Price2"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel9.Controls.Add(panelTop1)
        Panel9.Location = New Point(60, 300)
        Panel9.Margin = New Padding(10)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(30)
        Panel9.Size = New Size(200, 400)
        Panel9.TabIndex = 6
        ' 
        ' panelTop1
        ' 
        panelTop1.BackColor = Color.Tan
        panelTop1.Controls.Add(labelTopPrice1)
        panelTop1.Location = New Point(0, 85)
        panelTop1.Name = "panelTop1"
        panelTop1.Size = New Size(200, 207)
        panelTop1.TabIndex = 0
        ' 
        ' labelTopPrice1
        ' 
        labelTopPrice1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice1.Location = New Point(110, 0)
        labelTopPrice1.Name = "labelTopPrice1"
        labelTopPrice1.Size = New Size(90, 36)
        labelTopPrice1.TabIndex = 0
        labelTopPrice1.Text = "Price1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(10, 248)
        Label2.Margin = New Padding(10)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 38)
        Label2.TabIndex = 5
        Label2.Text = "Best Selling Products"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.MenuHighlight
        Panel7.Location = New Point(0, 230)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1010, 2)
        Panel7.TabIndex = 3
        ' 
        ' panelPurchase
        ' 
        panelPurchase.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelPurchase.Location = New Point(674, 13)
        panelPurchase.Name = "panelPurchase"
        panelPurchase.Padding = New Padding(30)
        panelPurchase.Size = New Size(300, 200)
        panelPurchase.TabIndex = 2
        ' 
        ' panelSale
        ' 
        panelSale.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelSale.Location = New Point(354, 13)
        panelSale.Name = "panelSale"
        panelSale.Padding = New Padding(30)
        panelSale.Size = New Size(300, 200)
        panelSale.TabIndex = 1
        ' 
        ' panelQuantity
        ' 
        panelQuantity.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelQuantity.Location = New Point(36, 13)
        panelQuantity.Name = "panelQuantity"
        panelQuantity.Padding = New Padding(30)
        panelQuantity.Size = New Size(300, 200)
        panelQuantity.TabIndex = 0
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
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1278, 744)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmHome"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        panelTop4.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        panelTop3.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        panelTop2.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        panelTop1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelPurchase As Panel
    Friend WithEvents panelSale As Panel
    Friend WithEvents panelQuantity As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents panelTop4 As Panel
    Friend WithEvents panelTop3 As Panel
    Friend WithEvents panelTop2 As Panel
    Friend WithEvents panelTop1 As Panel
    Friend WithEvents labelTopPrice1 As Label
    Friend WithEvents labelTopPrice4 As Label
    Friend WithEvents labelTopPrice3 As Label
    Friend WithEvents labelTopPrice2 As Label
    Friend WithEvents btnOverView As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnSupplier As Button
End Class
