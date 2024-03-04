
Public Class frmHome

    Dim empName As String
    Dim empType As String
    Dim overview As New frmOverView(empName)

    Public Sub New(Optional name As String = "", Optional type As String = "")

        InitializeComponent()
        empName = name
        empType = type

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Activate()
        Me.CenterToScreen()
        overview = New frmOverView(empName)
        With overview

            .TopLevel = False
            Panel3.Controls.Add(overview)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        overview.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()
        Close()

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        If empType.Equals("Admin") Then

            With frmEmployee

                .TopLevel = False
                Panel3.Controls.Add(frmEmployee)
                .BringToFront()
                .Show()

            End With

            overview.Close()
            frmProducts.Close()
            frmSupplier.Close()
            frmPurchase.Close()
            frmBills.Close()
            frmSales.Close()
        Else
            MsgBox("Only Admins can access this section", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub btnOverView_Click(sender As Object, e As EventArgs) Handles btnOverView.Click

        overview = New frmOverView(empName)
        With overview

            .TopLevel = False
            Panel3.Controls.Add(overview)
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

        overview.Close()
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

        overview.Close()
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

        overview.Close()
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
        overview.Close()
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
        overview.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmBills.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        overview.Close()
        frmEmployee.Close()
        frmProducts.Close()
        frmSupplier.Close()
        frmPurchase.Close()
        frmBills.Close()
        frmSales.Close()
        frmLogin.Show()
        Close()

    End Sub

End Class