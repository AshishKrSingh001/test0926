﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeesJoinAfterDate
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EmployeesJoinAfterDate))
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Date form You want to search : "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(455, 31)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(711, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 40)
        Button1.TabIndex = 2
        Button1.Text = "Show"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(899, 292)
        DataGridView1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Bottom
        Label2.Location = New Point(0, 386)
        Label2.Name = "Label2"
        Label2.Size = New Size(923, 25)
        Label2.TabIndex = 4
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmployeesJoinAfterDate
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 411)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EmployeesJoinAfterDate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employees Joins After Given Date"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
End Class
