<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSplash))
        labelApp = New Label()
        ProgressBarLoad = New ProgressBar()
        timerLoad = New Timer(components)
        SuspendLayout()
        ' 
        ' labelApp
        ' 
        labelApp.AutoSize = True
        labelApp.BackColor = Color.Transparent
        labelApp.Font = New Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelApp.ForeColor = SystemColors.ButtonFace
        labelApp.Location = New Point(30, 200)
        labelApp.Name = "labelApp"
        labelApp.Size = New Size(742, 47)
        labelApp.TabIndex = 0
        labelApp.Text = "Medical Store Management Software"
        labelApp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProgressBarLoad
        ' 
        ProgressBarLoad.BackColor = Color.Cyan
        ProgressBarLoad.Location = New Point(100, 400)
        ProgressBarLoad.Name = "ProgressBarLoad"
        ProgressBarLoad.Size = New Size(500, 25)
        ProgressBarLoad.Style = ProgressBarStyle.Continuous
        ProgressBarLoad.TabIndex = 1
        ' 
        ' timerLoad
        ' 
        ' 
        ' formSplash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tomato
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 800)
        Controls.Add(ProgressBarLoad)
        Controls.Add(labelApp)
        FormBorderStyle = FormBorderStyle.None
        Name = "formSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents labelApp As Label
    Friend WithEvents ProgressBarLoad As ProgressBar
    Friend WithEvents timerLoad As Timer

End Class
