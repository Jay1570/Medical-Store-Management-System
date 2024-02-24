Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmHome

    Private Sub frmHome_Show(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.Activate()
        Me.CenterToScreen()
        With frmOverView
            .TopLevel = False
            Panel3.Controls.Add(frmOverView)
            .BringToFront()
            .Show()
        End With

    End Sub

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