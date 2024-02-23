Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmHome

    Dim empName As String
    Dim empType As String
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub frmHome_Show(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.Activate()
        Me.CenterToScreen()
        With frmOverView
            .TopLevel = False
            Panel3.Controls.Add(frmOverView)
            .BringToFront()
            .Show()
        End With
        'conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System1\My Project\Medical Store Management System.accdb"
        'conn.Open()
        'showdata()

    End Sub

    'Sub showdata()
    'Dim query As String = "SELECT TOP 4 p.prod_nm,p.price,SUM(s.quantity_sold) AS total FROM Products AS p INNER JOIN Sales As s ON p.prod_id=s.prod_id GROUP BY p.prod_nm,p.price ORDER BY total DESC"
    'End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click

        With frmEmployee

            .TopLevel = False
            Panel3.Controls.Add(frmEmployee)
            .BringToFront()
            .Show()

        End With

        frmOverView.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

    Private Sub btnOverView_Click(sender As Object, e As EventArgs) Handles btnOverView.Click

        With frmOverView

            .TopLevel = False
            Panel3.Controls.Add(frmOverView)
            .BringToFront()
            .Show()

        End With

        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        With frmProducts

            .TopLevel = False
            Panel3.Controls.Add(frmProducts)
            .BringToFront()
            .Show()

        End With

        frmOverView.Close()
        frmEmployee.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click

        With frmSupplier

            .TopLevel = False
            Panel3.Controls.Add(frmSupplier)
            .BringToFront()
            .Show()

        End With

        frmOverView.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        With frmPurchase

            .TopLevel = False
            Panel3.Controls.Add(frmPurchase)
            .BringToFront()
            .Show()

        End With

        frmOverView.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

    Private Sub btnBills_Click(sender As Object, e As EventArgs) Handles btnBills.Click

        With frmBills

            .TopLevel = False
            Panel3.Controls.Add(frmBills)
            .BringToFront()
            .Show()

        End With

        frmPurchase.Close()
        frmOverView.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmSales.Close()

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        With frmSales

            .TopLevel = False
            Panel3.Controls.Add(frmSales)
            .BringToFront()
            .Show()

        End With

        frmPurchase.Close()
        frmOverView.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmBills.Close()

    End Sub

    Private Sub frmHome_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing

        frmOverView.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()

    End Sub

End Class