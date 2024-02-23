<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertDialog
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnCancel = New Button()
        btnInsert = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(581, 323)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(295, 9)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 40)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(161, 9)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(112, 40)
        btnInsert.TabIndex = 11
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnInsert)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 390)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(581, 52)
        Panel1.TabIndex = 13
        ' 
        ' frmInsertDialog
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(581, 442)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmInsertDialog"
        Text = "Insert Dialog"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Panel1 As Panel
End Class
