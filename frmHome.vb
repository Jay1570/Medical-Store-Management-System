Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmHome

    Dim empName As String
    Dim empType As String
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet

    Public Sub New(Optional ByVal empNM As String = "", Optional ByVal empTIPE As String = "")

        InitializeComponent()
        empName = empNM
        empType = empTIPE

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub frmHome_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        'MessageBox.Show("Login Sucessfull!", "Successfull")
    End Sub

    Private Sub btnOverView_MouseEnter(sender As Object, e As EventArgs) Handles btnOverView.MouseEnter, btnEmployee.MouseEnter, btnProducts.MouseEnter, btnReports.MouseEnter, btnSales.MouseEnter, btnSupplier.MouseEnter, btnClose.MouseEnter

        sender.BackColor = Color.FromArgb(67, 83, 98)

    End Sub

    Private Sub btnOverView_MouseLeave(sender As Object, e As EventArgs) Handles btnOverView.MouseLeave, btnEmployee.MouseLeave, btnProducts.MouseLeave, btnSales.MouseLeave, btnReports.MouseLeave, btnSupplier.MouseLeave, btnClose.MouseLeave

        sender.BackColor = Color.Transparent

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

    End Sub

    Private Sub btnOverView_Click(sender As Object, e As EventArgs) Handles btnOverView.Click

        With frmOverView

            .TopLevel = False
            Panel3.Controls.Add(frmOverView)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub frmHome_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        frmOverView.Close()
        frmEmployee.Close()

    End Sub
End Class