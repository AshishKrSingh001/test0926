Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EmployeesBetweenRangeofSalary
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub EmployeesBetweenRangeofSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sal1 As Decimal = CDec(InputBox("Enter Salary from : "))
        Dim sal2 As Decimal = CDec(InputBox("Enter Salary to : "))
        Dim cmd As New SqlCommand("select EmpNo,EmpName,Salary,Date_OJ from EmpTable where Salary > @sal1 and Salary < @sal2", con)
        cmd.Parameters.Add("@sal1", SqlDbType.Int).Value = sal1
        cmd.Parameters.Add("@sal2", SqlDbType.Int).Value = sal2
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("select count(*) from EmpTable where Salary > @sal1 and Salary < @sal2", con)
        cmd1.Parameters.Add("@sal1", SqlDbType.Int).Value = sal1
        cmd1.Parameters.Add("@sal2", SqlDbType.Int).Value = sal2
        con.Open()
        Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub
End Class