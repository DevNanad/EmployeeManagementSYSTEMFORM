<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents usernamef As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.usernamef = New System.Windows.Forms.TextBox()
        Me.closeX = New System.Windows.Forms.Label()
        Me.minimized = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.passwordf = New System.Windows.Forms.TextBox()
        Me.loginfunc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.UsernameLabel.Location = New System.Drawing.Point(608, 216)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 33)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.PasswordLabel.Location = New System.Drawing.Point(605, 297)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 30)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'usernamef
        '
        Me.usernamef.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.usernamef.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernamef.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamef.ForeColor = System.Drawing.Color.White
        Me.usernamef.Location = New System.Drawing.Point(614, 252)
        Me.usernamef.Name = "usernamef"
        Me.usernamef.Size = New System.Drawing.Size(220, 24)
        Me.usernamef.TabIndex = 1
        '
        'closeX
        '
        Me.closeX.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.closeX.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeX.ForeColor = System.Drawing.SystemColors.Window
        Me.closeX.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_xbox_x_30
        Me.closeX.Location = New System.Drawing.Point(871, 8)
        Me.closeX.Name = "closeX"
        Me.closeX.Size = New System.Drawing.Size(48, 48)
        Me.closeX.TabIndex = 6
        Me.closeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'minimized
        '
        Me.minimized.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.minimized.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimized.ForeColor = System.Drawing.SystemColors.Window
        Me.minimized.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_minus_30
        Me.minimized.Location = New System.Drawing.Point(834, 9)
        Me.minimized.Name = "minimized"
        Me.minimized.Size = New System.Drawing.Size(38, 48)
        Me.minimized.TabIndex = 7
        Me.minimized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CheckBox1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.CheckBox1.Location = New System.Drawing.Point(609, 380)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(612, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 1)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Location = New System.Drawing.Point(609, 356)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 1)
        Me.Panel2.TabIndex = 11
        '
        'passwordf
        '
        Me.passwordf.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.passwordf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordf.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordf.ForeColor = System.Drawing.Color.White
        Me.passwordf.Location = New System.Drawing.Point(611, 330)
        Me.passwordf.Name = "passwordf"
        Me.passwordf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordf.Size = New System.Drawing.Size(220, 24)
        Me.passwordf.TabIndex = 10
        '
        'loginfunc
        '
        Me.loginfunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginfunc.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginfunc.ForeColor = System.Drawing.SystemColors.Window
        Me.loginfunc.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.logg
        Me.loginfunc.Location = New System.Drawing.Point(654, 427)
        Me.loginfunc.Name = "loginfunc"
        Me.loginfunc.Size = New System.Drawing.Size(140, 48)
        Me.loginfunc.TabIndex = 12
        Me.loginfunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.loginpage
        Me.ClientSize = New System.Drawing.Size(938, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.loginfunc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.passwordf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.minimized)
        Me.Controls.Add(Me.closeX)
        Me.Controls.Add(Me.usernamef)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeX As Label
    Friend WithEvents minimized As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents passwordf As TextBox
    Friend WithEvents loginfunc As Label
End Class
