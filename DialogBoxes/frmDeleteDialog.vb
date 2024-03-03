Public Class frmDeleteDialog

    Public Property SelectedFields As New List(Of String)
    Public Property DeleteValues As New List(Of String)

    Public Sub New(ByVal fieldsList As List(Of String))

        InitializeComponent()

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown


        For Each field As String In fieldsList

            If field.Equals("Username") OrElse field.Equals("Name") Then

                Dim fieldPanel As New FlowLayoutPanel()
                fieldPanel.AutoSize = True
                fieldPanel.FlowDirection = FlowDirection.LeftToRight

                Dim chkBox As New Label()
                chkBox.Text = field
                fieldPanel.Controls.Add(chkBox)

                Dim txtBox As New TextBox()
                txtBox.Name = "txt" & field
                txtBox.Enabled = True
                txtBox.Visible = True
                txtBox.Size = New Size(100, 30)
                fieldPanel.Controls.Add(txtBox)

                FlowLayoutPanel1.Controls.Add(fieldPanel)
                Exit For
            End If
        Next

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        SelectedFields.Clear()
        DeleteValues.Clear()
        For Each fieldPanel As Control In FlowLayoutPanel1.Controls

            If TypeOf fieldPanel Is FlowLayoutPanel Then

                For Each ctrl As Control In fieldPanel.Controls

                    If TypeOf ctrl Is TextBox Then
                        If ctrl.Text.Equals("") Then
                            MsgBox("Please Enter Value...", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")
                            Return
                        End If
                        DeleteValues.Add(ctrl.Text.ToString())
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