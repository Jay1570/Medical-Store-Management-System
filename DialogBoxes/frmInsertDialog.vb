Imports System.Data.OleDb

Public Class frmInsertDialog

    Public Property InsertValues As New List(Of String)
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim lstProduct As New ComboBox
    Dim lstSupplier As New ComboBox

    Public Sub New(ByVal fieldsList As List(Of String))



        InitializeComponent()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Management System.accdb"

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown

        For Each field As String In fieldsList

            If field = "Stock" Or field = "Date" Or field = "Amount" Then
                Continue For
            End If

            Dim fieldPanel As New FlowLayoutPanel()
            fieldPanel.AutoSize = True
            fieldPanel.FlowDirection = FlowDirection.LeftToRight

            Dim label As New Label()
            label.Text = field
            label.Size = New Size(150, 30)
            fieldPanel.Controls.Add(label)

            If field = "Product Name" Or field = "Supplier Name" Then

                If field = "Product Name" Then
                    lstProduct.Name = "cmbProduct"
                    adp = New OleDbDataAdapter("SELECT [Name] From Products", conn)
                    adp.Fill(ds)
                    For Each row As DataRow In ds.Tables(0).Rows
                        lstProduct.Items.Add(row("Name").ToString())
                    Next
                    fieldPanel.Controls.Add(lstProduct)
                Else
                    ds.Clear()
                    lstSupplier.Name = "cmbSupplier"
                    adp = New OleDbDataAdapter("SELECT [Name] From Supplier", conn)
                    adp.Fill(ds)
                    For Each row As DataRow In ds.Tables(0).Rows
                        lstSupplier.Items.Add(row("Name").ToString())
                    Next
                    fieldPanel.Controls.Add(lstSupplier)
                End If
                FlowLayoutPanel1.Controls.Add(fieldPanel)
                Continue For
            End If

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
                        If ctrl.Text.Equals("") Then
                            MsgBox("Please Enter Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")
                            Return
                        End If
                        InsertValues.Add(ctrl.Text.ToString())
                    End If
                    If TypeOf ctrl Is ComboBox Then
                        If DirectCast(ctrl, ComboBox).SelectedIndex.Equals(-1) Then
                            MsgBox("Please Select Values From dropdown list", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")
                            Return
                        End If
                        InsertValues.Add(DirectCast(ctrl, ComboBox).SelectedItem.ToString())
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