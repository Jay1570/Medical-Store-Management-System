Imports System.Data.OleDb

Public Class frmSales

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Management System.accdb"
        showdata()
        fields.Add("Sale Id")
        fields.Add("Product Name")
        fields.Add("Quantity")
        fields.Add("Amount")
        Show()

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT s.Id As [Sales Id],p.[Name] As [Product Name],p.Price,c.Quantity,c.Price As [Total Amount] FROM
                                    (Sales As s INNER JOIN SaleItems As c ON s.Id = c.sid) INNER JOIN
                                    Products As p ON p.Id = c.pid", conn)
        adp.Fill(ds)
        dgvSales.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            selectedFields = search.SelectedFields
            values = search.SearchValues

            Dim comparativeOperator() As String = search.ComparativeOperators

            Try
                Dim j As Integer = 0
                Dim query As String = "SELECT s.Id As [Sales Id],p.[Name] As [Product Name],p.Price,c.Quantity,c.Price As [Total Amount] FROM
                                    (Sales As s INNER JOIN SaleItems As c ON s.Id = c.sid) INNER JOIN
                                    Products As p ON p.Id = c.pid WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Amount") Or selectedFields(i).Contains("Quantity") Then
                        query &= selectedFields(i) & " " & comparativeOperator(j) & " " & values(i) & " "
                        j += 1
                    ElseIf selectedFields(i).Contains("Product Name") Then
                        conn.Open()
                        Dim p = New OleDbCommand("SELECT Id FROM Products WHERE [Name] = '" & values(i) & "'", conn)
                        Dim pid As Integer = Val(p.ExecuteScalar())
                        conn.Close()
                        query &= "pid = " & pid.ToString() & " "
                    ElseIf selectedFields(i).Contains("Sale Id") Then
                        query &= "sid = " & values(i) & " "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                ds.Clear()
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(ds)
                dgvSales.DataSource = ds.Tables(0)
            Catch ex As Exception

                conn.Close()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

            End Try

        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub
End Class