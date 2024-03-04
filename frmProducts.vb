Imports System.Data.OleDb

Public Class frmProducts

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Management System.accdb"
        showdata()
        fields.Add("Name")
        fields.Add("Category")
        fields.Add("Price")
        fields.Add("Stock")
        Show()

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT [Name],Category,Price,Stock FROM Products", conn)
        adp.Fill(ds, "Products")
        dgvProducts.DataSource = ds.Tables("Products")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertDialog(fields)
        If insert.ShowDialog() = DialogResult.OK Then
            Dim query As String = "INSERT INTO Products([Name],Category,Price) VALUES ("
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
                MsgBox("Employee data inserted successfully!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

            End Try

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim update As New frmUpdateDialog(fields, "Name")
        If update.ShowDialog() = DialogResult.OK Then
            Dim query As String = "UPDATE Products SET "
            values.Clear()
            selectedFields.Clear()
            selectedFields = update.SelectedFields
            values = update.UpdateValues
            Dim where As String = update.whereValue
            Try
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Price") Or selectedFields(i).Contains("Stock") Then
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
                    MsgBox("Employee data updated successfully!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
                    showdata()
                Else
                    MsgBox("No Record was updated", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
                End If

            Catch ex As Exception

                conn.Close()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

            End Try

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim delete As New frmDeleteDialog(fields)
        If delete.ShowDialog() = DialogResult.OK Then
            values.Clear()
            selectedFields.Clear()
            Dim query As String = "DELETE FROM Products WHERE [Name] = "
            selectedFields = delete.SelectedFields
            values = delete.DeleteValues
            Try
                query &= "'" & values(0) & "'"
                conn.Open()
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted successfully!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
                conn.Close()
                showdata()

            Catch ex As Exception

                conn.Close()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

            End Try

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

            Dim comparativeOperator() As String = search.ComparativeOperators

            Try

                Dim query As String = "SELECT [Name],Category,Price,Stock FROM Products WHERE "
                For i As Integer = 0 To selectedFields.Count - 1
                    If selectedFields(i).Contains("Price") Or selectedFields(i).Contains("Stock") Then
                        query &= selectedFields(i) & " " & comparativeOperator(j) & " " & values(i) & " "
                        j += 1
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
                dgvProducts.DataSource = ds.Tables("Products")

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