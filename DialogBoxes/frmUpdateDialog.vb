Public Class frmUpdateDialog

    Public Property SelectedFields As New List(Of String)
    Public Property UpdateValues As New List(Of String)
    Public Property whereValue As String
    Dim whereToUpdate As String

    Public Sub New(ByVal fieldsList As List(Of String), ByVal where As String)

        InitializeComponent()

        whereToUpdate = where

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown


        For Each field As String In fieldsList

            If field = "Stock" Then
                Continue For
            End If

            Dim fieldPanel As New FlowLayoutPanel()
            fieldPanel.AutoSize = True
            fieldPanel.FlowDirection = FlowDirection.LeftToRight

            Dim chkBox As New CheckBox()
            chkBox.Text = field
            chkBox.Size = New Size(150, 30)
            AddHandler chkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged
            fieldPanel.Controls.Add(chkBox)

            Dim txtBox As New TextBox()
            txtBox.Name = "txt" & field
            txtBox.Enabled = False
            txtBox.Visible = True
            txtBox.Size = New Size(100, 30)
            fieldPanel.Controls.Add(txtBox)

            FlowLayoutPanel1.Controls.Add(fieldPanel)

        Next

        Dim fieldUpdate As New FlowLayoutPanel()
        fieldUpdate.AutoSize = True
        fieldUpdate.FlowDirection = FlowDirection.LeftToRight

        Dim label As New Label()
        label.Text = "Old " & where
        label.Size = New Size(150, 30)
        label.TextAlign = ContentAlignment.MiddleCenter
        fieldUpdate.Controls.Add(label)

        Dim txtBox1 As New TextBox()
        txtBox1.Name = "txtOld" & whereToUpdate
        txtBox1.Enabled = True
        txtBox1.Visible = True
        txtBox1.Size = New Size(100, 30)
        fieldUpdate.Controls.Add(txtBox1)

        FlowLayoutPanel1.Controls.Add(fieldUpdate)

    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)

        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)
        Dim relatedTextBox As String = "txt" & checkbox.Text

        For Each fieldPanel As Control In FlowLayoutPanel1.Controls

            If TypeOf fieldPanel Is FlowLayoutPanel Then

                For Each ctrl As Control In fieldPanel.Controls

                    If TypeOf ctrl Is TextBox AndAlso ctrl.Name = relatedTextBox Then
                        ctrl.Enabled = checkbox.Checked
                    End If

                Next

            End If

        Next

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        SelectedFields.Clear()
        UpdateValues.Clear()
        For Each fieldPanel As Control In FlowLayoutPanel1.Controls

            If TypeOf fieldPanel Is FlowLayoutPanel Then

                For Each ctrl As Control In fieldPanel.Controls

                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                        SelectedFields.Add(DirectCast(ctrl, CheckBox).Text)
                        Dim relatedTextBox As String = "txt" & DirectCast(ctrl, CheckBox).Text.ToString()

                        For Each txt As Control In fieldPanel.Controls

                            If TypeOf txt Is TextBox AndAlso txt.Name = relatedTextBox Then
                                UpdateValues.Add(txt.Text)
                            End If

                        Next

                    End If
                    If TypeOf ctrl Is TextBox AndAlso ctrl.Name = "txtOld" & whereToUpdate Then
                        whereValue = ctrl.Text
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