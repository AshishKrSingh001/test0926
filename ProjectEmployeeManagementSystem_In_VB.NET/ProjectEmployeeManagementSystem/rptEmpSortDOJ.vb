Imports System.Data.SqlClient
Imports System.Data
Public Class rptEmpSortDOJ
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub rptEmpSortDOJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select * from EmpTable order by Date_OJ desc", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        Da.fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")
    End Sub
End Class