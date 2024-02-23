<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDialog
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
        btnSearch = New Button()
        btnCancel = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(175, 540)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 40)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(326, 540)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 40)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(-1, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(612, 529)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' frmSearchDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(612, 592)
        Controls.Add(btnCancel)
        Controls.Add(btnSearch)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmSearchDialog"
        Text = "frmSearchDialog"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
