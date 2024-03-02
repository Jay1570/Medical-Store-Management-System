<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverView
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
        panelQuantity = New Panel()
        Label2 = New Label()
        lblSales = New Label()
        Label1 = New Label()
        panelSale = New Panel()
        Label6 = New Label()
        lblPurchase1 = New Label()
        Label3 = New Label()
        panelPurchase = New Panel()
        Label8 = New Label()
        lblStock = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label9 = New Label()
        lblProfit = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Label10 = New Label()
        lblSalary = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        lblUnm = New Label()
        Label13 = New Label()
        panelQuantity.SuspendLayout()
        panelSale.SuspendLayout()
        panelPurchase.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelQuantity
        ' 
        panelQuantity.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelQuantity.Controls.Add(Label2)
        panelQuantity.Controls.Add(lblSales)
        panelQuantity.Controls.Add(Label1)
        panelQuantity.Location = New Point(696, 162)
        panelQuantity.Name = "panelQuantity"
        panelQuantity.Padding = New Padding(30)
        panelQuantity.Size = New Size(300, 200)
        panelQuantity.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(10, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 28)
        Label2.TabIndex = 7
        Label2.Text = "(Last 30 Days)"
        ' 
        ' lblSales
        ' 
        lblSales.Font = New Font("Segoe UI", 14.0F)
        lblSales.ForeColor = Color.White
        lblSales.Location = New Point(50, 100)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(200, 38)
        lblSales.TabIndex = 1
        lblSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 45)
        Label1.TabIndex = 0
        Label1.Text = "Sales"
        ' 
        ' panelSale
        ' 
        panelSale.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelSale.Controls.Add(Label6)
        panelSale.Controls.Add(lblPurchase1)
        panelSale.Controls.Add(Label3)
        panelSale.Location = New Point(376, 162)
        panelSale.Name = "panelSale"
        panelSale.Padding = New Padding(30)
        panelSale.Size = New Size(300, 200)
        panelSale.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(10, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 28)
        Label6.TabIndex = 8
        Label6.Text = "(Last 30 Days)"
        ' 
        ' lblPurchase1
        ' 
        lblPurchase1.Font = New Font("Segoe UI", 14.0F)
        lblPurchase1.ForeColor = Color.White
        lblPurchase1.Location = New Point(50, 100)
        lblPurchase1.Name = "lblPurchase1"
        lblPurchase1.Size = New Size(200, 38)
        lblPurchase1.TabIndex = 2
        lblPurchase1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.0F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(10, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 45)
        Label3.TabIndex = 1
        Label3.Text = "Purchase"
        ' 
        ' panelPurchase
        ' 
        panelPurchase.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelPurchase.Controls.Add(Label8)
        panelPurchase.Controls.Add(lblStock)
        panelPurchase.Controls.Add(Label5)
        panelPurchase.Location = New Point(54, 389)
        panelPurchase.Name = "panelPurchase"
        panelPurchase.Padding = New Padding(30)
        panelPurchase.Size = New Size(300, 200)
        panelPurchase.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.0F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(10, 55)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 28)
        Label8.TabIndex = 8
        Label8.Text = "(In Rupees)"
        ' 
        ' lblStock
        ' 
        lblStock.Font = New Font("Segoe UI", 14.0F)
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(50, 100)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(200, 38)
        lblStock.TabIndex = 3
        lblStock.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.0F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(10, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 45)
        Label5.TabIndex = 2
        Label5.Text = "Stock Available"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblProfit)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(376, 389)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(30)
        Panel1.Size = New Size(300, 200)
        Panel1.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.0F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(10, 55)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 28)
        Label9.TabIndex = 8
        Label9.Text = "(Last 30 Days)"
        ' 
        ' lblProfit
        ' 
        lblProfit.Font = New Font("Segoe UI", 14.0F)
        lblProfit.ForeColor = Color.White
        lblProfit.Location = New Point(50, 100)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(200, 38)
        lblProfit.TabIndex = 1
        lblProfit.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.0F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(10, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 45)
        Label7.TabIndex = 0
        Label7.Text = "Profit On Sales"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(lblSalary)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(696, 389)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(30)
        Panel2.Size = New Size(300, 200)
        Panel2.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.0F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(10, 55)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 28)
        Label10.TabIndex = 8
        Label10.Text = "Of Employees"
        ' 
        ' lblSalary
        ' 
        lblSalary.Font = New Font("Segoe UI", 14.0F)
        lblSalary.ForeColor = Color.White
        lblSalary.Location = New Point(50, 100)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(200, 38)
        lblSalary.TabIndex = 1
        lblSalary.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.0F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(10, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 45)
        Label4.TabIndex = 0
        Label4.Text = "Salaries"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel3.Controls.Add(lblUnm)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(54, 162)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(30)
        Panel3.Size = New Size(300, 200)
        Panel3.TabIndex = 7
        ' 
        ' lblUnm
        ' 
        lblUnm.Font = New Font("Segoe UI", 14.0F)
        lblUnm.ForeColor = Color.White
        lblUnm.Location = New Point(50, 100)
        lblUnm.Name = "lblUnm"
        lblUnm.Size = New Size(200, 38)
        lblUnm.TabIndex = 1
        lblUnm.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 16.0F)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(10, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(160, 45)
        Label13.TabIndex = 0
        Label13.Text = "Welcome,"
        ' 
        ' frmOverView
        ' 
        AutoScaleDimensions = New SizeF(144.0F, 144.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1050, 750)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(panelPurchase)
        Controls.Add(panelSale)
        Controls.Add(panelQuantity)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmOverView"
        Text = "frmOverView"
        WindowState = FormWindowState.Maximized
        panelQuantity.ResumeLayout(False)
        panelQuantity.PerformLayout()
        panelSale.ResumeLayout(False)
        panelSale.PerformLayout()
        panelPurchase.ResumeLayout(False)
        panelPurchase.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelQuantity As Panel
    Friend WithEvents panelSale As Panel
    Friend WithEvents panelPurchase As Panel
    Friend WithEvents labelTopPrice1 As Label
    Friend WithEvents panelTop1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents labelTopPrice2 As Label
    Friend WithEvents labelTopPrice3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labelTopPrice4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents labelTopName1 As Label
    Friend WithEvents labelTopName2 As Label
    Friend WithEvents labelTopName3 As Label
    Friend WithEvents labelTopName4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProfit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblUnm As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPurchase1 As Label
End Class
