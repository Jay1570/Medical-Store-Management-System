﻿Imports System.Data.OleDb

Public Class frmBills

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmBills_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        fields.Add("Date")
        fields.Add("Amount")

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT Id AS [Sale Id],Date,Amount AS [Total Amount] FROM Sales", conn)
        adp.Fill(ds)
        dgvSales.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertSaleItems()
        If insert.ShowDialog() = DialogResult.OK Then

            showdata()

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim j As Integer = 0
        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            selectedFields = search.SelectedFields
            values = search.SearchValues
            Dim f As String = ""

            Dim comparativeOperator() As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT Id As [Sale Id],[Date],Amount WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Amount") Then
                        query &= selectedFields(i) & " " & comparativeOperator(j) & " " & values(i) & " "
                        j += 1
                    ElseIf selectedFields(i).Contains("Date") Then
                        Dim dateParts As String() = values(i).Split("-"c)
                        f = $"{dateParts(0)}/{dateParts(1)}/{dateParts(2)}"
                        Dim d As DateTime = DateTime.Parse(f)
                        query &= selectedFields(i) & " = #" & d & "# "
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
                MessageBox.Show("Error :- " & ex.Message)

            End Try

        End If

    End Sub

End Class