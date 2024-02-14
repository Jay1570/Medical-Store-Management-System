Public Class frmSearchDialog

    Public Property SelectedFields As New List(Of String)
    Public Property SearchValues As New List(Of String)
    Public Property ComparativeOperators As String

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkName.CheckedChanged, chkSalary.CheckedChanged, chkType.CheckedChanged, chkUsername.CheckedChanged

        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)
        Dim relatedTextBox As String = checkbox.Tag.ToString()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name = relatedTextBox Then
                ctrl.Enabled = checkbox.Checked
            End If
        Next


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SelectedFields.Clear()
        SearchValues.Clear()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                SelectedFields.Add(DirectCast(ctrl, CheckBox).Text)
                Dim relatedTextBox As String = DirectCast(ctrl, CheckBox).Tag.ToString()
                For Each txt As Control In Me.Controls
                    If TypeOf txt Is TextBox AndAlso txt.Name = relatedTextBox Then
                        SearchValues.Add(txt.Text)
                    End If
                Next
            End If
        Next
        If chkSalary.Checked Then
            ComparativeOperators = ComboBox1.SelectedItem.ToString()
        End If
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel
        Close()

    End Sub
End Class