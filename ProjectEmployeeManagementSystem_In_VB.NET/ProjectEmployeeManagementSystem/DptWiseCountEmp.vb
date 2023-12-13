Imports System.Data.SqlClient
Imports System.Data
Public Class DptWiseCountEmp
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Private Sub DptWiseCountEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select DptName,Count(EmpNo) as count from DeptTable,EmpTable Where DeptTable.DptNo = EmpTable.DptNo group by DptName", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")
    End Sub
End Class