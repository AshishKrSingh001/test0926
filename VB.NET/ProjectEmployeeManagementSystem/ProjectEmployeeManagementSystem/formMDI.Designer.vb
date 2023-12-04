<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        DataEntryToolStripMenuItem1 = New ToolStripMenuItem()
        DeptMenuStrip = New ToolStripMenuItem()
        EmployeeMenuStrip = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataEntryToolStripMenuItem1, ReportToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1582, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataEntryToolStripMenuItem1
        ' 
        DataEntryToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {DeptMenuStrip, EmployeeMenuStrip})
        DataEntryToolStripMenuItem1.Name = "DataEntryToolStripMenuItem1"
        DataEntryToolStripMenuItem1.Size = New Size(92, 24)
        DataEntryToolStripMenuItem1.Text = "Data Entry"
        ' 
        ' DeptMenuStrip
        ' 
        DeptMenuStrip.Name = "DeptMenuStrip"
        DeptMenuStrip.Size = New Size(172, 26)
        DeptMenuStrip.Text = "Department"
        ' 
        ' EmployeeMenuStrip
        ' 
        EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        EmployeeMenuStrip.Size = New Size(172, 26)
        EmployeeMenuStrip.Text = "Employee"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(68, 24)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1582, 853)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "Form1"
        Text = " Department & Employee Information Management"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeptMenuStrip As ToolStripMenuItem
    Friend WithEvents EmployeeMenuStrip As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
