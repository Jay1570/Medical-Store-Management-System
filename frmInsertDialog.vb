Imports System.Management

Public Class frmInsertDialog

    Public Property query As String
    Public Property InsertValues As New List(Of String)
    Public Sub New(ByVal fieldsList As List(Of String))

        InitializeComponent()

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown

        For Each field As String In fieldsList

            Dim fieldPanel As New FlowLayoutPanel()
            fieldPanel.AutoSize = True
            fieldPanel.FlowDirection = FlowDirection.LeftToRight

            Dim label As New Label()
            label.Text = field
            label.Size = New Size(150, 30)
            fieldPanel.Controls.Add(label)

            Dim txtBox As New TextBox()
            txtBox.Name = "txt" & field
            txtBox.Enabled = True
            txtBox.Visible = True
            txtBox.Size = New Size(100, 30)
            fieldPanel.Controls.Add(txtBox)

            FlowLayoutPanel1.Controls.Add(fieldPanel)

        Next

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        For Each fieldPanel As Control In FlowLayoutPanel1.Controls
            If TypeOf fieldPanel Is FlowLayoutPanel Then
                For Each ctrl As Control In fieldPanel.Controls
                    If TypeOf ctrl Is TextBox Then
                        InsertValues.Add(ctrl.Text)
                    End If
                Next
            End If
        Next
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class