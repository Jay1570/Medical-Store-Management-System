Public Class frmSearchDialog

    Public Property SelectedFields As New List(Of String)
    Public Property SearchValues As New List(Of String)
    Public Property ComparativeOperators As String

    Public Sub New(ByVal fieldsList As List(Of String))

        InitializeComponent()

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown


        For Each field As String In fieldsList

            If field = "Password" Then
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

            If field = "Salary" Or field = "Price" Or field = "Stock" Or field = "Quantity" Or field = "Amount" Then

                Dim comboBox As New ComboBox()
                comboBox.Name = "cmb" & field
                comboBox.Items.AddRange({"=", ">", "<", ">=", "<=", "<>"})
                comboBox.Enabled = False
                comboBox.SelectedValue = "="
                fieldPanel.Controls.Add(comboBox)

            End If
            FlowLayoutPanel1.Controls.Add(fieldPanel)

        Next
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)

        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)
        Dim relatedTextBox As String = "txt" & checkbox.Text
        Dim relatedCombo As String = "cmb" & checkbox.Text

        For Each fieldPanel As Control In FlowLayoutPanel1.Controls

            If TypeOf fieldPanel Is FlowLayoutPanel Then

                For Each ctrl As Control In fieldPanel.Controls

                    If TypeOf ctrl Is TextBox AndAlso ctrl.Name = relatedTextBox Then
                        ctrl.Enabled = checkbox.Checked
                    End If

                    If TypeOf ctrl Is ComboBox AndAlso ctrl.Name = relatedCombo Then
                        ctrl.Enabled = checkbox.Checked
                        DirectCast(ctrl, ComboBox).SelectedItem = "="
                    End If

                Next

            End If

        Next

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SelectedFields.Clear()
        SearchValues.Clear()
        For Each fieldPanel As Control In FlowLayoutPanel1.Controls

            If TypeOf fieldPanel Is FlowLayoutPanel Then

                For Each ctrl As Control In fieldPanel.Controls

                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                        SelectedFields.Add(DirectCast(ctrl, CheckBox).Text)
                        Dim relatedTextBox As String = "txt" & DirectCast(ctrl, CheckBox).Text.ToString()
                        Dim relatedCombo As String = "cmb" & DirectCast(ctrl, CheckBox).Text.ToString()

                        For Each txt As Control In fieldPanel.Controls

                            If TypeOf txt Is TextBox AndAlso txt.Name = relatedTextBox Then
                                SearchValues.Add(txt.Text)
                            End If

                            If TypeOf txt Is ComboBox AndAlso txt.Name = relatedCombo Then
                                ComparativeOperators = DirectCast(txt, ComboBox).SelectedItem
                            End If

                        Next

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