﻿Imports System.Data.SqlClient
Imports System.Data
Public Class rptDeptNoWiseEmployee
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectEmployeeManagementSystem\ProjectEmployeeManagementSystem\Database1.mdf;Integrated Security=True")
    Dim ds As DataSet
    Private Sub rptEmpAndDeptUsingDataRelationClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,Date_Oj,EmpTable.DptNo,DptName,Location from EmpTable,DeptTable where EmpTable.DptNo = DeptTable.DptNo order by DptNo Asc", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables("Emp")
    End Sub
End Class