<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteDialog
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
        Panel1 = New Panel()
        btnCancel = New Button()
        btnDelete = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(517, 371)
        FlowLayoutPanel1.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnDelete)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 377)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(517, 57)
        Panel1.TabIndex = 15
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
        ' btnDelete
        ' 
        btnDelete.Location = New Point(161, 9)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 40)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' frmDeleteDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 434)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmDeleteDialog"
        Text = "frmDeleteDialog"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
End Class
