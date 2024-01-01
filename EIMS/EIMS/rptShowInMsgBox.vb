Imports System.Data.SqlClient
Imports System.Data
Public Class rptShowInMsgBox
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet

    Private Sub rptShowInMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select * from EmpTable", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Department No"
                .Columns(4).HeaderCell.Value = "Date of Joining"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName from EmpTable", con)
            Dim dr As SqlDataReader
            con.Open()
            dr = cmd.ExecuteReader()
            Dim c As Integer
            While dr.Read
                c = MessageBox.Show(dr.GetInt32(0) & " " & dr.GetString(1), "Employee Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If c = 0 Then
                    Application.Exit()
                End If
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class