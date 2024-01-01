Imports System.Data.SqlClient
Imports System.Data

Public Class EmployeesJoinAfterDate
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub EmployeesJoinAfterDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Columns(4).HeaderCell.Value = "Date of Join"
        End With

        Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
        con.Open()
        Label2.Text = "No of Employees : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("Select * from EmpTable where Date_OJ > @doj", con)
        cmd.Parameters.Add("@doj", SqlDbType.Date).Value = DateTimePicker1.Value
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable where Date_OJ > @doj", con)
        cmd.Parameters.Add("@doj", SqlDbType.Date).Value = DateTimePicker1.Value
        con.Open()
        Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub
End Class