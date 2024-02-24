Imports System.Data.OleDb

Public Class frmOverView

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmOverView_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()

    End Sub

    Sub showdata()

        ds.Clear()
        Dim query As String = "SELECT TOP 4 p.[Name],p.price FROM (Products As p INNER JOIN SaleItems As s ON p.Id=s.pid) INNER JOIN Sales As sa ON sa.Id = s.sid WHERE sa.[Date] >= Date() - 30 GROUP BY p.[Name],p.price ORDER BY SUM(s.Quantity) DESC"
        adp = New OleDbDataAdapter(query, conn)
        adp.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            ' Display data for the first product
            labelTopName1.Text = ds.Tables(0).Rows(0)("Name").ToString()
            labelTopPrice1.Text = ds.Tables(0).Rows(0)("price").ToString()

            ' Display data for the second product
            labelTopName2.Text = ds.Tables(0).Rows(1)("Name").ToString()
            labelTopPrice2.Text = ds.Tables(0).Rows(1)("price").ToString()

            ' Display data for the third product
            labelTopName3.Text = ds.Tables(0).Rows(2)("Name").ToString()
            labelTopPrice3.Text = ds.Tables(0).Rows(2)("price").ToString()

            ' Display data for the fourth product
            labelTopName4.Text = ds.Tables(0).Rows(3)("Name").ToString()
            labelTopPrice4.Text = ds.Tables(0).Rows(3)("price").ToString()

        End If

    End Sub


End Class