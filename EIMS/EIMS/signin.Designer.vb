<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(signin))
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        txtPasswd = New TextBox()
        txtUname = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonShadow
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtPasswd)
        GroupBox1.Controls.Add(txtUname)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(509, 215)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login"
        GroupBox1.UseCompatibleTextRendering = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(233, 172)
        Button4.Name = "Button4"
        Button4.Size = New Size(129, 43)
        Button4.TabIndex = 12
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(98, 172)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 43)
        Button3.TabIndex = 11
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(368, 172)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 43)
        Button1.TabIndex = 9
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(181, 125)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(180, 32)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtPasswd
        ' 
        txtPasswd.Location = New Point(181, 85)
        txtPasswd.Name = "txtPasswd"
        txtPasswd.Size = New Size(310, 34)
        txtPasswd.TabIndex = 6
        ' 
        ' txtUname
        ' 
        txtUname.Location = New Point(181, 38)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(310, 34)
        txtUname.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 28)
        Label4.TabIndex = 4
        Label4.Text = "Password : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 28)
        Label3.TabIndex = 3
        Label3.Text = "Username :"
        ' 
        ' signin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(509, 215)
        ControlBox = False
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "signin"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
