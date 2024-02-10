Public Class frmHome
    Private empName As String
    Private empType As String

    Public Sub New(Optional ByVal empNM As String = "", Optional ByVal empTIPE As String = "")

        InitializeComponent()
        empName = empNM
        empType = empTIPE

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Activate()
        Me.Size = New Size(900, 435)
        Me.CenterToScreen()
    End Sub

    Private Sub frmHome_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        'MessageBox.Show("Login Sucessfull!", "Successfull")
    End Sub

    Private Sub btnOverView_MouseEnter(sender As Object, e As EventArgs) Handles btnOverView.MouseEnter, btnEmployee.MouseEnter, btnProducts.MouseEnter, btnReports.MouseEnter, btnSales.MouseEnter, btnSupplier.MouseEnter

        sender.BackColor = Color.FromArgb(67, 83, 98)

    End Sub

    Private Sub btnOverView_MouseLeave(sender As Object, e As EventArgs) Handles btnOverView.MouseLeave, btnEmployee.MouseLeave, btnProducts.MouseLeave, btnSales.MouseLeave, btnReports.MouseLeave, btnSupplier.MouseLeave

        sender.BackColor = Color.Transparent

    End Sub

End Class