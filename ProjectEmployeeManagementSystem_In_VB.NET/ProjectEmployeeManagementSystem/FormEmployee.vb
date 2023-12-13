﻿Imports System.Data.SqlClient
Imports System.Data

Public Class FormEmployee
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0
    Sub displayRecords()
        Dim cmd As New SqlCommand("Select * from EmpTable", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        dgvEmp.DataSource = ds.Tables("Emp")
        inc = 0
        maxRow = ds.Tables("Emp").Rows.Count
        With ds.Tables("Emp").Rows(maxRow - 1)
            txtEmpNo.Text = (CInt(.Item(0)) + 1)
        End With
    End Sub
    Sub ClearControls()
        txtEmpNo.Text = ""
        txtEmpName.Clear()
        txtSalary.Text = ""
        dtpDate.Value = DateTime.Now.Date
        dtpDate.MaxDate = DateTime.Now.Date

    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged
        If IsNumeric(txtEmpNo.Text) = False Then
            ErrorProvider1.SetError(txtEmpNo, "EmpNo Should be Integer")
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs)
        If IsDate(dtpDate.Text) = False Then
            ErrorProvider1.SetError(dtpDate, "Not in specified form")
        End If
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs)
        If IsNumeric(txtSalary.Text) = False Then
            ErrorProvider1.SetError(txtSalary, "Salary Should be Numeric")
        End If
    End Sub

    Sub ComboBox_Value()
        Dim cmd As New SqlCommand("Select DptNo,DptName from DeptTable", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Dep")
        cmbDeptName.DataSource = ds.Tables("Dep")
        cmbDeptName.DisplayMember = "DptName"
        cmbDeptName.ValueMember = "DptNo"
    End Sub

    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Value()
        displayRecords()
    End Sub



    Private Function isEmpty() As Boolean
        If txtEmpNo.Text = "" And txtEmpName.Text = "" And txtSalary.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnDes_Click(sender As Object, e As EventArgs) Handles btnDes.Click
        Dim dv As New DataView(ds.Tables("Emp"))
        dv.Sort = "EmpName Desc"
        dgvEmp.DataSource = dv
    End Sub

    Private Sub btnAsc_Click_1(sender As Object, e As EventArgs) Handles btnAsc.Click
        Dim dv As New DataView(ds.Tables("Emp"))
        dv.Sort = "EmpName Asc"
        dgvEmp.DataSource = dv
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Insert into EmpTable(EmpNo,EmpName,Salary,DptNo,Date_Oj) values(@Empno,@Empname,@salary,@DptNo,@doj)", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not instered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Delete from EmpTable Where EmpNo = @Empno", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Update EmpTable set EmpNo=@Empno,EmpName=@Empname,Salary=@salary,DptNo=@DptNo,Date_Oj=@doj where EmpNo = @Empno", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearControls()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ComboBox_Value()
        ClearControls()
        displayRecords()
    End Sub

    Private Sub dgvEmp_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellContentClick
        txtEmpNo.Text = dgvEmp.CurrentRow.Cells(0).Value
        txtEmpName.Text = dgvEmp.CurrentRow.Cells(1).Value
        txtSalary.Text = dgvEmp.CurrentRow.Cells(2).Value
        cmbDeptName.SelectedValue = dgvEmp.CurrentRow.Cells(3).Value
        dtpDate.Value = dgvEmp.CurrentRow.Cells(4).Value
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim str As String = InputBox("Enter Employee Name")
        Dim dv As New DataView(ds.Tables("Emp"))
        dv.Sort = "EmpName Asc"
        dv.RowFilter = "EmpName like '%" & str & "%'"
        dgvEmp.DataSource = dv
    End Sub
    Sub navigate()
        If ds.Tables("Emp").Rows.Count > 0 Then
            With ds.Tables("Emp").Rows(inc)
                txtEmpNo.Text = .Item(0)
                txtEmpName.Text = .Item(1)
                txtSalary.Text = .Item(2)
                cmbDeptName.SelectedValue = .Item(3)
                dtpDate.Value = .Item(4)
            End With
        Else
            ClearControls()
        End If
    End Sub

    Private Sub btnNav3_Click(sender As Object, e As EventArgs) Handles btnNav3.Click
        If inc < 0 Then
            MessageBox.Show("Empty Data set", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            inc = 0
            navigate()
        End If
    End Sub

    Private Sub btnNav4_Click(sender As Object, e As EventArgs) Handles btnNav4.Click
        If inc < 0 Then
            MessageBox.Show("Empty Data set", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            inc = maxRow - 1
            navigate()
        End If
    End Sub

    Private Sub btnNav1_Click(sender As Object, e As EventArgs) Handles btnNav1.Click
        If inc <= 0 Then
            MessageBox.Show("First Record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            inc -= 1
            navigate()
        End If
    End Sub

    Private Sub btnNav2_Click(sender As Object, e As EventArgs) Handles btnNav2.Click
        If inc >= maxRow - 1 Then
            MessageBox.Show("Last Record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            inc += 1
            navigate()
        End If
    End Sub
End Class