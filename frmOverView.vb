Imports System.Data.OleDb

Public Class frmOverView

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim name1 As String

    Public Sub New(Optional empName As String = "")

        InitializeComponent()
        name1 = empName

    End Sub

    Private Sub frmOverView_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Management System.accdb"
        showdata()

    End Sub

    Sub showdata()
        Try

            conn.Open()
            lblUnm.Text = name1
            Dim query As String = "SELECT SUM(Amount) FROM Sales WHERE [Date] >= Date() - 30"
            cmd = New OleDbCommand(query, conn)
            lblSales.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C")
            lblProfit.Text = (Convert.ToDecimal(cmd.ExecuteScalar()) * 0.4).ToString("C")
            query = "SELECT SUM(Amount) FROM PurchaseLog WHERE [Date] >= Date() - 30"
            cmd = New OleDbCommand(query, conn)
            lblPurchase1.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C")
            query = "SELECT Stock, Price FROM Products"
            cmd = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim totalValue As Decimal = 0
            While reader.Read()
                Dim stock As Integer = Convert.ToInt32(reader("Stock"))
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                totalValue += stock * price
            End While
            lblStock.Text = totalValue.ToString("C")
            query = "SELECT SUM(Salary) FROM Employee"
            cmd = New OleDbCommand(query, conn)
            lblSalary.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C")

        Catch ex As Exception

            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

        Finally

            conn.Close()

        End Try

    End Sub

End Class