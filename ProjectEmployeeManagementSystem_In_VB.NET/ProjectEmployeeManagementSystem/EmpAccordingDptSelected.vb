Imports System.Data.SqlClient
Imports System.Data

Public Class EmpAccordingDptSelected
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Sub ComboBox_Value()
        Dim cmd As New SqlCommand("Select DptNo,DptName from DeptTable", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Dep")
        ComboBox1.DataSource = ds.Tables("Dep")
        ComboBox1.DisplayMember = "DptName"
        ComboBox1.ValueMember = "DptNo"
    End Sub
    Sub DisplayContents()
        Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,Date_OJ from EmpTable Where DptNo = @Dno", con)
        cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")

        Dim cmd1 As New SqlCommand("Select count(*) from EmpTable Where DptNo = @Dno", con)
        cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
        con.Open()
        Label2.Text = "No of Employees : " & cmd1.ExecuteScalar()
        con.Close()
    End Sub

    Private Sub EmpAccordingDptSelected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Value()
        DisplayContents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayContents()
    End Sub
End Class
