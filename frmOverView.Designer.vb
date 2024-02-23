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
        panelSale = New Panel()
        panelPurchase = New Panel()
        Panel7 = New Panel()
        Label2 = New Label()
        labelTopPrice1 = New Label()
        panelTop1 = New Panel()
        Panel9 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
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
        panelQuantity.Location = New Point(30, 30)
        panelQuantity.Name = "panelQuantity"
        panelQuantity.Padding = New Padding(30)
        panelQuantity.Size = New Size(300, 200)
        panelQuantity.TabIndex = 1
        ' 
        ' panelSale
        ' 
        panelSale.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelSale.Location = New Point(350, 30)
        panelSale.Name = "panelSale"
        panelSale.Padding = New Padding(30)
        panelSale.Size = New Size(300, 200)
        panelSale.TabIndex = 2
        ' 
        ' panelPurchase
        ' 
        panelPurchase.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        panelPurchase.Location = New Point(670, 30)
        panelPurchase.Name = "panelPurchase"
        panelPurchase.Padding = New Padding(30)
        panelPurchase.Size = New Size(300, 200)
        panelPurchase.TabIndex = 3
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
        panelTop1.Controls.Add(labelTopPrice1)
        panelTop1.Location = New Point(0, 85)
        panelTop1.Name = "panelTop1"
        panelTop1.Size = New Size(200, 207)
        panelTop1.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel9.Controls.Add(panelTop1)
        Panel9.Location = New Point(63, 320)
        Panel9.Margin = New Padding(10)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(30)
        Panel9.Size = New Size(200, 375)
        Panel9.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(110, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 36)
        Label1.TabIndex = 0
        Label1.Text = "Price1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 207)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(288, 320)
        Panel2.Margin = New Padding(10)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(30)
        Panel2.Size = New Size(200, 375)
        Panel2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label3.Location = New Point(110, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 36)
        Label3.TabIndex = 0
        Label3.Text = "Price1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Tan
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(0, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 207)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(513, 320)
        Panel4.Margin = New Padding(10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(30)
        Panel4.Size = New Size(200, 375)
        Panel4.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label4.Location = New Point(110, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 36)
        Label4.TabIndex = 0
        Label4.Text = "Price1"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Tan
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(0, 85)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 207)
        Panel5.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel6.Controls.Add(Panel5)
        Panel6.Location = New Point(738, 320)
        Panel6.Margin = New Padding(10)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(30)
        Panel6.Size = New Size(200, 375)
        Panel6.TabIndex = 8
        ' 
        ' frmOverView
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1050, 750)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
