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

    Private Sub TotalEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalEmployeesToolStripMenuItem.Click
        Dim f3 As New rptTotalEmp
        f3.Owner = Me
        f3.ShowInTaskbar = False
        f3.ShowDialog()
    End Sub

    Private Sub EmployeeDetailsWithDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsWithDepartmentToolStripMenuItem.Click
        Dim f4 As New rptEmpWithDept
        f4.Owner = Me
        f4.ShowInTaskbar = False
        f4.ShowDialog()
    End Sub


    Private Sub EmployeeSortedByDateOfJoinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSortedByDateOfJoinToolStripMenuItem.Click
        Dim f5 As New rptEmpSortDOJ
        f5.Owner = Me
        f5.ShowInTaskbar = False
        f5.ShowDialog()
    End Sub

    Private Sub DepartmentWiseEmployeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentWiseEmployeeCountToolStripMenuItem.Click
        Dim f6 As New DptWiseCountEmp
        f6.Owner = Me
        f6.ShowInTaskbar = False
        f6.ShowDialog()
    End Sub

    Private Sub EmployeeAccordingToDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccordingToDepartmentToolStripMenuItem.Click
        Dim f7 As New EmpAccordingDpt
        f7.Owner = Me
        f7.ShowInTaskbar = False
        f7.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Click
        Dim f8 As New EmpAccordingDptSelected
        f8.Owner = Me
        f8.ShowInTaskbar = False
        f8.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Click
        Dim f9 As New rptEmpSelectedDptSalaryLessThanValue
        f9.Owner = Me
        f9.ShowInTaskbar = False
        f9.ShowDialog()
    End Sub

    Private Sub EmployeesBetweenRangeOfSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesBetweenRangeOfSalaryToolStripMenuItem.Click
        Dim f10 As New EmployeesBetweenRangeofSalary
        f10.Owner = Me
        f10.ShowInTaskbar = False
        f10.ShowDialog()
    End Sub

    Private Sub ShowInMessageBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowInMessageBoxToolStripMenuItem.Click
        Dim f11 As New rptShowInMsgBox
        f11.Owner = Me
        f11.ShowInTaskbar = False
        f11.ShowDialog()
    End Sub

    Private Sub EmployeeJoinsAfterGivenDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeJoinsAfterGivenDateToolStripMenuItem.Click
        Dim f12 As New EmployeesJoinAfterDate
        f12.Owner = Me
        f12.ShowInTaskbar = False
        f12.ShowDialog()
    End Sub

    Private Sub StartingCharacterOfEmployeeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartingCharacterOfEmployeeNameToolStripMenuItem.Click
        Dim f13 As New rptStartCharName
        f13.Owner = Me
        f13.ShowInTaskbar = False
        f13.ShowDialog()
    End Sub

    Private Sub DepartmentAndEmployeeRelationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentAndEmployeeRelationToolStripMenuItem.Click
        Dim f14 As New rptDeptNoWiseEmployee
        f14.Owner = Me
        f14.ShowInTaskbar = False
        f14.ShowDialog()
    End Sub
End Class