﻿Imports System.Data.OleDb

Public Class frmSupplier

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmSupplier_Show(sender As Object, e As EventArgs) Handles MyBase.Shown

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        fields.Add("Name")
        fields.Add("Contact")
        fields.Add("City")

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT [Name],Contact,City FROM Supplier", conn)
        adp.Fill(ds, "Supplier")
        dgvSupplier.DataSource = ds.Tables("Supplier")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertDialog(fields)
        If insert.ShowDialog() = DialogResult.OK Then
            Dim query As String = "INSERT INTO Supplier([Name],Contact,City) VALUES ("
            values.Clear()
            values = insert.InsertValues
            Try
                For i As Integer = 0 To values.Count - 1
                    query &= "'" & values(i) & "'"
                    If i < values.Count - 1 Then
                        query &= ","
                    End If
                Next
                query &= ")"
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier data inserted successfully!")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error inserting Supplier data: " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim update As New frmUpdateDialog(fields, "Name")
        If update.ShowDialog() = DialogResult.OK Then
            Dim query As String = "UPDATE Supplier SET "
            values.Clear()
            selectedFields.Clear()
            selectedFields = update.SelectedFields
            values = update.UpdateValues
            Dim where As String = update.whereValue
            Try
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Contact") Then
                        query &= selectedFields(i) & " = " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If

                    If i < selectedFields.Count - 1 Then
                        query &= ","
                    End If

                Next
                query &= " WHERE Name = @name"
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", where)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                conn.Close()
                If rowsAffected > 0 Then
                    MessageBox.Show("Supplier data updated successfully!")
                    showdata()
                Else
                    MessageBox.Show("No records were updated.")
                End If

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Updating Supplier data: " & ex.Message)

            End Try

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim delete As New frmDeleteDialog(fields)
        If delete.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            Dim query As String = "DELETE FROM Supplier WHERE "
            selectedFields = delete.SelectedFields
            values = delete.DeleteValues
            Try
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Contact") Then
                        query &= selectedFields(i) & " = " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier data Deleted successfully!")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Deleting Supplier data: " & ex.Message)

            End Try

        End If


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As New frmSearchDialog(fields)
        If search.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            selectedFields = search.SelectedFields
            values = search.SearchValues

            Dim comparativeOperator As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT [Name],Contact,City FROM Supplier WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Contact") Then
                        query &= selectedFields(i) & " " & comparativeOperator & " " & values(i) & " "
                    Else
                        query &= selectedFields(i) & " = " & "'" & values(i) & "' "
                    End If
                    If i < selectedFields.Count - 1 Then
                        query &= " AND "
                    End If
                Next
                ds.Clear()
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(ds, "Products")
                dgvSupplier.DataSource = ds.Tables("Products")

            Catch ex As Exception

                conn.Close()
                MessageBox.Show("Error Displaying Supplier data: " & ex.Message)

            End Try
        End If

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        showdata()

    End Sub

End Class