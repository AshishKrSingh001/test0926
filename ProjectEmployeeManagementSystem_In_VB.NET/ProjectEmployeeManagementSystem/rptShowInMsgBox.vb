Imports System.Data.SqlClient
Imports System.Data
Public Class rptShowInMsgBox
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet

    Private Sub rptShowInMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select EmpNo,EmpName from EmpTable", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("Select EmpNo,EmpName from EmpTable", con)
        Dim dr As SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader()
        While dr.Read
            MessageBox.Show(dr.GetInt32(0) & " " & dr.GetString(1), "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End While
        dr.Close()
        con.Close()

    End Sub
End Class