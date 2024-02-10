<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        OK = New Button()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        txtUNM = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.ForeColor = SystemColors.ButtonFace
        UsernameLabel.Location = New Point(140, 200)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.ForeColor = SystemColors.ButtonFace
        PasswordLabel.Location = New Point(140, 280)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' OK
        ' 
        OK.FlatAppearance.BorderColor = SystemColors.MenuHighlight
        OK.FlatAppearance.BorderSize = 0
        OK.FlatStyle = FlatStyle.Flat
        OK.ForeColor = SystemColors.ButtonFace
        OK.Location = New Point(200, 398)
        OK.Name = "OK"
        OK.Size = New Size(100, 40)
        OK.TabIndex = 3
        OK.Text = "Login"
        ' 
        ' txtPassword
        ' 
        txtPassword.CustomizableEdges = CustomizableEdges1
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.ForeColor = Color.Black
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), Image)
        txtPassword.Location = New Point(140, 310)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PlaceholderText = ""
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtPassword.Size = New Size(220, 40)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 10
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' txtUNM
        ' 
        txtUNM.CustomizableEdges = CustomizableEdges3
        txtUNM.DefaultText = ""
        txtUNM.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUNM.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUNM.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUNM.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUNM.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUNM.Font = New Font("Segoe UI", 9F)
        txtUNM.ForeColor = Color.Black
        txtUNM.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUNM.IconLeft = CType(resources.GetObject("txtUNM.IconLeft"), Image)
        txtUNM.Location = New Point(140, 230)
        txtUNM.Margin = New Padding(4, 5, 4, 5)
        txtUNM.Name = "txtUNM"
        txtUNM.PasswordChar = ChrW(0)
        txtUNM.PlaceholderText = ""
        txtUNM.SelectedText = ""
        txtUNM.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtUNM.Size = New Size(220, 40)
        txtUNM.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(140, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 60)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.AccessibleDescription = "btnClose"
        btnClose.BackColor = Color.Transparent
        btnClose.DialogResult = DialogResult.Cancel
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = SystemColors.ButtonFace
        btnClose.Location = New Point(448, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 5
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(500, 500)
        Controls.Add(btnClose)
        Controls.Add(Label1)
        Controls.Add(txtUNM)
        Controls.Add(OK)
        Controls.Add(txtPassword)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)

    End Sub

    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUNM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClose As Button

End Class
