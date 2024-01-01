Imports System.Data.SqlClient
Imports System.Data
Imports System.Reflection.Emit

Public Class EmpAccordingDpt
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub EmpAccordingDpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim choose As Integer = CInt(InputBox("Enter Department Number: "))
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,Date_OJ,Email from EmpTable Where DptNo = @Dno", con)
            cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = choose
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
                .Columns(3).HeaderCell.Value = "Date of Join"
                .Columns(5).HeaderCell.Value = "Email"
                .Columns(5).FillWeight = 155
            End With

            Dim cmd1 As New SqlCommand("Select count(*) from EmpTable Where DptNo = @Dno", con)
            cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = choose
            con.Open()
            Label1.Text = "No of Employees : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
