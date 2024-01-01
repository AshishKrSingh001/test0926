﻿Imports System.Data.SqlClient

Public Class signin
    Dim con As New SqlConnection(Form1.conString)
    Private Sub signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPasswd.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPasswd.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("Select count(*) from Login Where Username = @uname and Password = @passwd", con)
            cmd.Parameters.Add("@uname", SqlDbType.VarChar).Value = txtUname.Text.ToString.Trim
            cmd.Parameters.Add("@passwd", SqlDbType.VarChar).Value = txtPasswd.Text.ToString.Trim
            con.Open()
            Dim Count As Integer = 0
            Count = cmd.ExecuteScalar()
            If Count = 0 Then
                MessageBox.Show("Employee Doesn't found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtUname.Text = ""
        txtPasswd.Text = ""
        CheckBox1.Checked = False
    End Sub
End Class