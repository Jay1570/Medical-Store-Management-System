Imports System.ComponentModel

Public Class frmHome

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Activate()
        Me.CenterToScreen()
        With frmOverView

            AddHandler frmOverView.Load, AddressOf FormToShow_Load
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

            AddHandler frmEmployee.Load, AddressOf FormToShow_Load
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

        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()
        If frmOverView.IsHandleCreated Then
            ' If the form is already loaded, just show it in Panel3
            Panel3.Visible = False ' Hide other panels
            frmOverView.TopLevel = False
            Panel3.Controls.Add(frmOverView)
            frmOverView.BringToFront()
            frmOverView.Show()
            Panel3.Visible = True
        Else
            Panel3.Visible = False
            frmOverView.TopLevel = False
            Panel3.Controls.Add(frmOverView)
            frmOverView.BringToFront()
            frmOverView.Show()
            Panel3.Visible = True
        End If

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        With frmProducts

            AddHandler frmProducts.Load, AddressOf FormToShow_Load
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

            AddHandler frmSupplier.Load, AddressOf FormToShow_Load
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

            AddHandler frmPurchase.Load, AddressOf FormToShow_Load
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

        AddHandler frmBills.Load, AddressOf FormToShow_Load
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

            AddHandler frmSales.Load, AddressOf FormToShow_Load
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

    Private Sub FormToShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = True
    End Sub

End Class