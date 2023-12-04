Public Class Form1
    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeptMenuStrip.Click
        Dim f1 As New FormDept
        f1.Owner = Me
        f1.ShowInTaskbar = False
        f1.ShowDialog()
    End Sub

    Private Sub EmployeeMenuStrip_Click(sender As Object, e As EventArgs) Handles EmployeeMenuStrip.Click
        Dim f2 As New FormEmployee
        f2.Owner = Me
        f2.ShowInTaskbar = False
        f2.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class