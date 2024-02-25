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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverView))
        panelQuantity = New Panel()
        lblSales = New Label()
        Label1 = New Label()
        panelSale = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        panelPurchase = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Panel7 = New Panel()
        Label2 = New Label()
        labelTopPrice1 = New Label()
        panelTop1 = New Panel()
        Panel9 = New Panel()
        labelTopName1 = New Label()
        labelTopPrice2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        labelTopName2 = New Label()
        labelTopPrice3 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        labelTopName3 = New Label()
        labelTopPrice4 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        labelTopName4 = New Label()
        panelQuantity.SuspendLayout()
        panelSale.SuspendLayout()
        panelPurchase.SuspendLayout()
        panelTop1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelQuantity
        ' 
        panelQuantity.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelQuantity.Controls.Add(lblSales)
        panelQuantity.Controls.Add(Label1)
        panelQuantity.Location = New Point(30, 30)
        panelQuantity.Name = "panelQuantity"
        panelQuantity.Padding = New Padding(30)
        panelQuantity.Size = New Size(300, 200)
        panelQuantity.TabIndex = 1
        ' 
        ' lblSales
        ' 
        lblSales.Font = New Font("Segoe UI", 14F)
        lblSales.ForeColor = Color.White
        lblSales.Location = New Point(50, 91)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(200, 38)
        lblSales.TabIndex = 1
        lblSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
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
        panelSale.Controls.Add(Label4)
        panelSale.Controls.Add(Label3)
        panelSale.Location = New Point(350, 30)
        panelSale.Name = "panelSale"
        panelSale.Padding = New Padding(30)
        panelSale.Size = New Size(300, 200)
        panelSale.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(50, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 38)
        Label4.TabIndex = 2
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
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
        panelPurchase.Controls.Add(Label6)
        panelPurchase.Controls.Add(Label5)
        panelPurchase.Location = New Point(670, 30)
        panelPurchase.Name = "panelPurchase"
        panelPurchase.Padding = New Padding(30)
        panelPurchase.Size = New Size(300, 200)
        panelPurchase.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(50, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 38)
        Label6.TabIndex = 3
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(10, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 45)
        Label5.TabIndex = 2
        Label5.Text = "Stock Available"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.MenuHighlight
        Panel7.Location = New Point(0, 250)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1050, 2)
        Panel7.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(10, 270)
        Label2.Margin = New Padding(10)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 38)
        Label2.TabIndex = 6
        Label2.Text = "Best Selling Products"
        Label2.TextAlign = ContentAlignment.MiddleLeft
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
        ' panelTop1
        ' 
        panelTop1.BackColor = Color.Tan
        panelTop1.BackgroundImage = CType(resources.GetObject("panelTop1.BackgroundImage"), Image)
        panelTop1.Controls.Add(labelTopPrice1)
        panelTop1.Location = New Point(63, 370)
        panelTop1.Name = "panelTop1"
        panelTop1.Size = New Size(200, 200)
        panelTop1.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel9.Controls.Add(labelTopName1)
        Panel9.Location = New Point(63, 320)
        Panel9.Margin = New Padding(10)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(30)
        Panel9.Size = New Size(200, 375)
        Panel9.TabIndex = 7
        ' 
        ' labelTopName1
        ' 
        labelTopName1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        labelTopName1.Location = New Point(22, 271)
        labelTopName1.Name = "labelTopName1"
        labelTopName1.Size = New Size(157, 45)
        labelTopName1.TabIndex = 1
        labelTopName1.Text = "Price1"
        ' 
        ' labelTopPrice2
        ' 
        labelTopPrice2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice2.Location = New Point(110, 0)
        labelTopPrice2.Name = "labelTopPrice2"
        labelTopPrice2.Size = New Size(90, 36)
        labelTopPrice2.TabIndex = 0
        labelTopPrice2.Text = "Price1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(labelTopPrice2)
        Panel1.Location = New Point(288, 370)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 200)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel2.Controls.Add(labelTopName2)
        Panel2.Location = New Point(288, 320)
        Panel2.Margin = New Padding(10)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(30)
        Panel2.Size = New Size(200, 375)
        Panel2.TabIndex = 8
        ' 
        ' labelTopName2
        ' 
        labelTopName2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        labelTopName2.Location = New Point(22, 271)
        labelTopName2.Name = "labelTopName2"
        labelTopName2.Size = New Size(157, 45)
        labelTopName2.TabIndex = 2
        labelTopName2.Text = "Price1"
        ' 
        ' labelTopPrice3
        ' 
        labelTopPrice3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice3.Location = New Point(110, 0)
        labelTopPrice3.Name = "labelTopPrice3"
        labelTopPrice3.Size = New Size(90, 36)
        labelTopPrice3.TabIndex = 0
        labelTopPrice3.Text = "Price1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.Controls.Add(labelTopPrice3)
        Panel3.Location = New Point(0, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 200)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel4.Controls.Add(labelTopName3)
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(513, 320)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(30)
        Panel4.Size = New Size(200, 375)
        Panel4.TabIndex = 9
        ' 
        ' labelTopName3
        ' 
        labelTopName3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        labelTopName3.Location = New Point(22, 271)
        labelTopName3.Name = "labelTopName3"
        labelTopName3.Size = New Size(157, 45)
        labelTopName3.TabIndex = 3
        labelTopName3.Text = "Price1"
        ' 
        ' labelTopPrice4
        ' 
        labelTopPrice4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        labelTopPrice4.Location = New Point(110, 0)
        labelTopPrice4.Name = "labelTopPrice4"
        labelTopPrice4.Size = New Size(90, 36)
        labelTopPrice4.TabIndex = 0
        labelTopPrice4.Text = "Price1"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Tan
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.Controls.Add(labelTopPrice4)
        Panel5.Location = New Point(0, 50)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 200)
        Panel5.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel6.Controls.Add(labelTopName4)
        Panel6.Controls.Add(Panel5)
        Panel6.Location = New Point(738, 320)
        Panel6.Margin = New Padding(10)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(30)
        Panel6.Size = New Size(200, 375)
        Panel6.TabIndex = 8
        ' 
        ' labelTopName4
        ' 
        labelTopName4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        labelTopName4.Location = New Point(22, 271)
        labelTopName4.Name = "labelTopName4"
        labelTopName4.Size = New Size(157, 45)
        labelTopName4.TabIndex = 4
        ' 
        ' frmOverView
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1050, 750)
        Controls.Add(Panel1)
        Controls.Add(panelTop1)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel9)
        Controls.Add(Label2)
        Controls.Add(Panel7)
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
        panelTop1.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelQuantity As Panel
    Friend WithEvents panelSale As Panel
    Friend WithEvents panelPurchase As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents labelTopPrice1 As Label
    Friend WithEvents panelTop1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents labelTopPrice2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelTopPrice3 As Label
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
