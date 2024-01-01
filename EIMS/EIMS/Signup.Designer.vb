<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        txtPassword = New TextBox()
        Label5 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtcPassword = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        txtNo = New TextBox()
        txtName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtcPassword)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtNo)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(469, 359)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Register"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(50, 291)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 43)
        Button3.TabIndex = 11
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(185, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 43)
        Button2.TabIndex = 12
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(135, 169)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(310, 34)
        txtPassword.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 28)
        Label5.TabIndex = 14
        Label5.Text = "Password :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(135, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(310, 34)
        txtEmail.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 28)
        Label2.TabIndex = 12
        Label2.Text = "Email :"
        ' 
        ' txtcPassword
        ' 
        txtcPassword.Location = New Point(135, 235)
        txtcPassword.Name = "txtcPassword"
        txtcPassword.Size = New Size(310, 34)
        txtcPassword.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(17, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 57)
        Label1.TabIndex = 10
        Label1.Text = "Confirm Password : "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(320, 291)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 43)
        Button1.TabIndex = 13
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(134, 197)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(180, 32)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(135, 88)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(310, 34)
        txtNo.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(135, 48)
        txtName.Name = "txtName"
        txtName.Size = New Size(310, 34)
        txtName.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 28)
        Label4.TabIndex = 4
        Label4.Text = "Id :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 28)
        Label3.TabIndex = 3
        Label3.Text = "Name :"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 359)
        ControlBox = False
        Controls.Add(GroupBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
