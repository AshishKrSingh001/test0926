Imports System.Data.SqlClient
Imports System.Data
Public Class rptStartCharName
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub rptStartCharName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim choose As Char = CChar(InputBox("Enter Starting character of Employees Name : "))
        Dim cmd As New SqlCommand("Select * from EmpTable where EmpName like '" & choose & "%'", con)
        cmd.Parameters.Add("@a", SqlDbType.Char).Value = choose
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        If choose <> "" Then
            da.Fill(ds, "Emp")
        Else
            ds.Clear()
        End If
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("Select count(*) from EmpTable where EmpName like '" & choose & "%'", con)
        cmd.Parameters.Add("@a", SqlDbType.Char).Value = choose
        con.Open()
        Label1.Text = "No of Employees : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub
End Class