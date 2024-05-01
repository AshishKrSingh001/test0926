﻿Imports System.Data
Imports System.Data.SqlClient
Public Class a12_rptStartCharName
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub rptStartCharName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim choose As Char = CChar(InputBox("Enter Starting character of Employees Name : "))
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,DptName,Date_OJ from EmpTable,DeptTable where DeptTable.Dptno = EmpTable.Dptno AND EmpName like '" & choose & "%'", con)
            cmd.Parameters.Add("@a", SqlDbType.Char).Value = choose
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            If choose <> "" Then
                da.Fill(ds, "Emp")
            Else
                ds.Clear()
            End If
            DataGridView1.DataSource = ds.Tables("Emp")
            With DataGridView1.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End With
            DataGridView1.EnableHeadersVisualStyles = False
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Department Name"
                .Columns(4).HeaderCell.Value = "Date of Joining"
            End With


            Dim cmd1 As New SqlCommand("Select count(*) from EmpTable where EmpName like '" & choose & "%'", con)
            cmd.Parameters.Add("@a", SqlDbType.Char).Value = choose
            con.Open()
            Label1.Text = "No of Employees : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class