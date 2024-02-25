Imports System.Data.OleDb

Public Class frmOverView

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmOverView_Load(sender As Object, e As EventArgs) Handles Me.Load

        Panel4.Visible = False
        Panel6.Visible = False
        Panel2.Visible = False
        Panel9.Visible = False
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        Show()


    End Sub

    Sub showdata()

        ds.Clear()
        Dim query As String = "SELECT TOP 4 p.[Name],p.price FROM (Products As p INNER JOIN SaleItems As s ON p.Id=s.pid) INNER JOIN Sales As sa ON sa.Id = s.sid WHERE sa.[Date] >= Date() - 30 GROUP BY p.[Name],p.price ORDER BY SUM(s.Quantity) DESC"
        adp = New OleDbDataAdapter(query, conn)
        adp.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Panel9.Visible = True
            labelTopName1.Text = ds.Tables(0).Rows(0)("Name").ToString()
            labelTopPrice1.Text = Convert.ToDecimal(ds.Tables(0).Rows(0)("price")).ToString("C")

            If ds.Tables(0).Rows.Count >= 2 Then
                Panel2.Visible = True
                labelTopName2.Text = ds.Tables(0).Rows(1)("Name").ToString()
                labelTopPrice2.Text = Convert.ToDecimal(ds.Tables(0).Rows(1)("price")).ToString("C")
            End If
            If ds.Tables(0).Rows.Count >= 3 Then
                Panel4.Visible = True
                labelTopName3.Text = ds.Tables(0).Rows(2)("Name").ToString()
                labelTopPrice3.Text = Convert.ToDecimal(ds.Tables(0).Rows(2)("price")).ToString("C")
            End If
            If ds.Tables(0).Rows.Count >= 4 Then
                Panel6.Visible = True
                labelTopName4.Text = ds.Tables(0).Rows(3)("Name").ToString()
                labelTopPrice4.Text = Convert.ToDecimal(ds.Tables(0).Rows(3)("price")).ToString("C")
            End If
        End If
        conn.Open()
        query = "SELECT SUM(Amount) FROM Sales WHERE [Date] >= Date() - 30"
        cmd = New OleDbCommand(query, conn)
        lblSales.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C")
        query = "SELECT SUM(Amount) FROM PurchaseLog WHERE [Date] >= Date() - 30"
        cmd = New OleDbCommand(query, conn)
        Label4.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C")
        query = "SELECT Stock, Price FROM Products"
        cmd = New OleDbCommand(query, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim totalValue As Decimal = 0
        While reader.Read()
            Dim stock As Integer = Convert.ToInt32(reader("Stock"))
            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
            totalValue += stock * price
        End While
        Label6.Text = totalValue.ToString("C")
        conn.Close()

    End Sub

    Private Sub frmHome_Activated(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        showdata()
    End Sub

End Class