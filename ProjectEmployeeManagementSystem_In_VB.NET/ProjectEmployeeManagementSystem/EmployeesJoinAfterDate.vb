Imports System.Data.SqlClient
Imports System.Data

Public Class EmployeesJoinAfterDate
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub EmployeesJoinAfterDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select * from EmpTable", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
        con.Open()
        Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
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