﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDept
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
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtDeptNo = New TextBox()
        txtDeptName = New TextBox()
        txtLocation = New TextBox()
        gbOperations = New GroupBox()
        btnShow = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnFilter = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        gbNavigation = New GroupBox()
        btnNav3 = New Button()
        btnNav2 = New Button()
        btnNav4 = New Button()
        btnNav1 = New Button()
        gbSorting = New GroupBox()
        btnDes = New Button()
        btnAsc = New Button()
        DataGridView1 = New DataGridView()
        gbOperations.SuspendLayout()
        gbNavigation.SuspendLayout()
        gbSorting.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(53, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 33)
        Label1.TabIndex = 0
        Label1.Text = "Department No : "
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(78, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 0)
        Label8.TabIndex = 7
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(53, 96)
        Label9.Name = "Label9"
        Label9.Size = New Size(195, 33)
        Label9.TabIndex = 8
        Label9.Text = "Depatrment Name : "
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(53, 152)
        Label10.Name = "Label10"
        Label10.Size = New Size(115, 33)
        Label10.TabIndex = 9
        Label10.Text = "Location : "
        ' 
        ' txtDeptNo
        ' 
        txtDeptNo.Location = New Point(245, 40)
        txtDeptNo.Name = "txtDeptNo"
        txtDeptNo.Size = New Size(267, 34)
        txtDeptNo.TabIndex = 10
        ' 
        ' txtDeptName
        ' 
        txtDeptName.Location = New Point(245, 93)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.Size = New Size(267, 34)
        txtDeptName.TabIndex = 11
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(245, 149)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(267, 34)
        txtLocation.TabIndex = 12
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(53, 219)
        gbOperations.Name = "gbOperations"
        gbOperations.Size = New Size(459, 219)
        gbOperations.TabIndex = 13
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(301, 57)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(129, 50)
        btnShow.TabIndex = 5
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(301, 124)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(129, 50)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(31, 124)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(129, 50)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(166, 124)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(129, 50)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(166, 57)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(129, 50)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(31, 57)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(129, 50)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(53, 445)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Size = New Size(459, 157)
        gbNavigation.TabIndex = 14
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav3
        ' 
        btnNav3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav3.Location = New Point(112, 91)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(129, 50)
        btnNav3.TabIndex = 4
        btnNav3.Text = "|<"
        btnNav3.UseVisualStyleBackColor = True
        ' 
        ' btnNav2
        ' 
        btnNav2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav2.Location = New Point(259, 33)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(129, 50)
        btnNav2.TabIndex = 3
        btnNav2.Text = ">"
        btnNav2.UseVisualStyleBackColor = True
        ' 
        ' btnNav4
        ' 
        btnNav4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav4.Location = New Point(259, 91)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(129, 50)
        btnNav4.TabIndex = 2
        btnNav4.Text = ">|"
        btnNav4.UseVisualStyleBackColor = True
        ' 
        ' btnNav1
        ' 
        btnNav1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav1.Location = New Point(112, 33)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(129, 50)
        btnNav1.TabIndex = 1
        btnNav1.Text = "<"
        btnNav1.UseVisualStyleBackColor = True
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(547, 498)
        gbSorting.Name = "gbSorting"
        gbSorting.Size = New Size(353, 104)
        gbSorting.TabIndex = 15
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.Location = New Point(181, 38)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(160, 50)
        btnDes.TabIndex = 3
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = True
        ' 
        ' btnAsc
        ' 
        btnAsc.Location = New Point(15, 38)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(160, 50)
        btnAsc.TabIndex = 1
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(547, 40)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(353, 438)
        DataGridView1.TabIndex = 15
        ' 
        ' FormDept
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(940, 609)
        Controls.Add(gbSorting)
        Controls.Add(DataGridView1)
        Controls.Add(gbNavigation)
        Controls.Add(gbOperations)
        Controls.Add(txtLocation)
        Controls.Add(txtDeptName)
        Controls.Add(txtDeptNo)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "FormDept"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Department Information"
        gbOperations.ResumeLayout(False)
        gbNavigation.ResumeLayout(False)
        gbSorting.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDeptNo As TextBox
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents gbOperations As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents gbNavigation As GroupBox
    Friend WithEvents btnNav3 As Button
    Friend WithEvents btnNav2 As Button
    Friend WithEvents btnNav4 As Button
    Friend WithEvents btnNav1 As Button
    Friend WithEvents gbSorting As GroupBox
    Friend WithEvents btnDes As Button
    Friend WithEvents btnAsc As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
