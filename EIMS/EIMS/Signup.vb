Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Signup
    Dim con As New SqlConnection(Form1.conString)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtName.Text = ""
        txtNo.Text = ""
        txtPassword.Text = ""
        txtcPassword.Text = ""
        txtEmail.Text = ""
        CheckBox1.Checked = False

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearControls()
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Password Doesn't Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim cmd As New SqlCommand("Select count(*) from EmpTable Where EmpNo = @eno and EmpName = @ename and Email = @email", con)
                cmd.Parameters.Add("@eno", SqlDbType.Int).Value = CInt(txtNo.Text)
                cmd.Parameters.Add("@ename", SqlDbType.VarChar).Value = txtName.Text
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
                con.Open()
                Dim Count As Integer = 0
                Count = cmd.ExecuteScalar()
                con.Close()
                If Count = 0 Then
                    MessageBox.Show("Employee Doesn't found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim cmd1 As New SqlCommand("Insert into Login(Username,Password) values(@uname,@pass)", con)
                    cmd1.Parameters.Add("@uname", SqlDbType.VarChar).Value = txtEmail.Text
                    cmd1.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtcPassword.Text
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Inserted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearControls()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub txtcPassword_TextChanged(sender As Object, e As EventArgs) Handles txtcPassword.TextChanged
        If txtcPassword.Text <> txtPassword.Text Then
            ErrorProvider1.SetError(txtcPassword, "Password Doesn't Matched")
        End If
    End Sub
End Class