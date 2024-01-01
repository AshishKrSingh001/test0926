<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormEmployee))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        dgvEmp = New DataGridView()
        txtEmpNo = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        txtEmpName = New TextBox()
        txtSalary = New TextBox()
        cmbDeptName = New ComboBox()
        dtpDate = New DateTimePicker()
        gbOperations = New GroupBox()
        btnShow = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnFilter = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        gbSorting = New GroupBox()
        btnDes = New Button()
        btnAsc = New Button()
        gbNavigation = New GroupBox()
        btnNav3 = New Button()
        btnNav2 = New Button()
        btnNav4 = New Button()
        btnNav1 = New Button()
        CType(dgvEmp, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        gbOperations.SuspendLayout()
        gbSorting.SuspendLayout()
        gbNavigation.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 29)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 0
        Label1.Text = "Employee No : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 87)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 1
        Label2.Text = "Salary : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 57)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 2
        Label3.Text = "Employee Name : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 126)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 3
        Label4.Text = "Department Name : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 156)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 4
        Label5.Text = "Date of Joining : "
        ' 
        ' dgvEmp
        ' 
        dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmp.Location = New Point(462, 29)
        dgvEmp.Margin = New Padding(2)
        dgvEmp.Name = "dgvEmp"
        dgvEmp.RowHeadersWidth = 51
        dgvEmp.RowTemplate.Height = 29
        dgvEmp.Size = New Size(1040, 487)
        dgvEmp.TabIndex = 5
        ' 
        ' txtEmpNo
        ' 
        txtEmpNo.Location = New Point(202, 29)
        txtEmpNo.Margin = New Padding(2)
        txtEmpNo.Name = "txtEmpNo"
        txtEmpNo.Size = New Size(245, 27)
        txtEmpNo.TabIndex = 6
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtEmpName
        ' 
        txtEmpName.Location = New Point(202, 58)
        txtEmpName.Margin = New Padding(2)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(245, 27)
        txtEmpName.TabIndex = 7
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(202, 85)
        txtSalary.Margin = New Padding(2)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(245, 27)
        txtSalary.TabIndex = 8
        ' 
        ' cmbDeptName
        ' 
        cmbDeptName.FormattingEnabled = True
        cmbDeptName.Location = New Point(202, 119)
        cmbDeptName.Margin = New Padding(2)
        cmbDeptName.Name = "cmbDeptName"
        cmbDeptName.Size = New Size(245, 28)
        cmbDeptName.TabIndex = 9
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(202, 152)
        dtpDate.Margin = New Padding(2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(245, 27)
        dtpDate.TabIndex = 10
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(47, 194)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(399, 156)
        gbOperations.TabIndex = 14
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(272, 41)
        btnShow.Margin = New Padding(2)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(106, 36)
        btnShow.TabIndex = 5
        btnShow.Text = "Reset"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(272, 89)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(52, 89)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 36)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(162, 89)
        btnFilter.Margin = New Padding(2)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(106, 36)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(162, 41)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(106, 36)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(52, 41)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(106, 36)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(47, 354)
        gbSorting.Margin = New Padding(2)
        gbSorting.Name = "gbSorting"
        gbSorting.Padding = New Padding(2)
        gbSorting.Size = New Size(399, 74)
        gbSorting.TabIndex = 16
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.Location = New Point(250, 27)
        btnDes.Margin = New Padding(2)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(131, 36)
        btnDes.TabIndex = 3
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = True
        ' 
        ' btnAsc
        ' 
        btnAsc.Location = New Point(70, 27)
        btnAsc.Margin = New Padding(2)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(131, 36)
        btnAsc.TabIndex = 1
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = True
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(47, 432)
        gbNavigation.Margin = New Padding(2)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Padding = New Padding(2)
        gbNavigation.Size = New Size(400, 84)
        gbNavigation.TabIndex = 17
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav3
        ' 
        btnNav3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav3.Location = New Point(2, 36)
        btnNav3.Margin = New Padding(2)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(100, 36)
        btnNav3.TabIndex = 4
        btnNav3.Text = "First"
        btnNav3.UseVisualStyleBackColor = True
        ' 
        ' btnNav2
        ' 
        btnNav2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav2.Location = New Point(200, 36)
        btnNav2.Margin = New Padding(2)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(100, 36)
        btnNav2.TabIndex = 3
        btnNav2.Text = "Next"
        btnNav2.UseVisualStyleBackColor = True
        ' 
        ' btnNav4
        ' 
        btnNav4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav4.Location = New Point(299, 36)
        btnNav4.Margin = New Padding(2)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(100, 36)
        btnNav4.TabIndex = 2
        btnNav4.Text = "Last"
        btnNav4.UseVisualStyleBackColor = True
        ' 
        ' btnNav1
        ' 
        btnNav1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav1.Location = New Point(101, 36)
        btnNav1.Margin = New Padding(2)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(100, 36)
        btnNav1.TabIndex = 1
        btnNav1.Text = "Prev"
        btnNav1.UseVisualStyleBackColor = True
        ' 
        ' FormEmployee
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1509, 524)
        Controls.Add(gbNavigation)
        Controls.Add(gbSorting)
        Controls.Add(gbOperations)
        Controls.Add(dtpDate)
        Controls.Add(cmbDeptName)
        Controls.Add(txtSalary)
        Controls.Add(txtEmpName)
        Controls.Add(txtEmpNo)
        Controls.Add(dgvEmp)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Information"
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        gbOperations.ResumeLayout(False)
        gbSorting.ResumeLayout(False)
        gbNavigation.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbDeptName As ComboBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents gbOperations As GroupBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents gbSorting As GroupBox
    Friend WithEvents btnDes As Button
    Friend WithEvents btnAsc As Button
    Friend WithEvents gbNavigation As GroupBox
    Friend WithEvents btnNav3 As Button
    Friend WithEvents btnNav2 As Button
    Friend WithEvents btnNav4 As Button
    Friend WithEvents btnNav1 As Button
End Class
