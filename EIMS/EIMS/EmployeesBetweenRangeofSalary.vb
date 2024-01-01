Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EmployeesBetweenRangeofSalary
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub EmployeesBetweenRangeofSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sal1 As Decimal = CDec(InputBox("Enter Salary from : "))
            Dim sal2 As Decimal = CDec(InputBox("Enter Salary to : "))
            Dim cmd As New SqlCommand("select EmpNo,EmpName,Salary,Date_OJ,Email from EmpTable where Salary > @sal1 and Salary < @sal2", con)
            cmd.Parameters.Add("@sal1", SqlDbType.Int).Value = sal1
            cmd.Parameters.Add("@sal2", SqlDbType.Int).Value = sal2
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

            Dim cmd1 As New SqlCommand("select count(*) from EmpTable where Salary > @sal1 and Salary < @sal2", con)
            cmd1.Parameters.Add("@sal1", SqlDbType.Int).Value = sal1
            cmd1.Parameters.Add("@sal2", SqlDbType.Int).Value = sal2
            con.Open()
            Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class