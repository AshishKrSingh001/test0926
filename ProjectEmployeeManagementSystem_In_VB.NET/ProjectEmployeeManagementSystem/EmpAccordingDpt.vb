Imports System.Data.SqlClient
Imports System.Data
Imports System.Reflection.Emit

Public Class EmpAccordingDpt
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub EmpAccordingDpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim choose As Integer = CInt(InputBox("Enter Department Number: "))
        Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,Date_OJ from EmpTable Where DptNo = @Dno", con)
        cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = choose
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("Select count(*) from EmpTable Where DptNo = @Dno", con)
        cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = choose
        con.Open()
        Label1.Text = "No of Employees : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub
End Class
