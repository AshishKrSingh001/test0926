Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common

Public Class rptTotalEmp
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub rptTotalEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,EmpTable.DptNo,DptName,Date_Oj from EmpTable,DeptTable where EmpTable.DptNo = DeptTable.DptNo", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")
        Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
        con.Open()
        lblCount.Text = "No of Employee : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub

End Class