<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.updateEMP = New System.Windows.Forms.TabPage()
        Me.txbLnameEMP = New System.Windows.Forms.TextBox()
        Me.txbMnameEMP = New System.Windows.Forms.TextBox()
        Me.btnUpdateFuncEMP = New System.Windows.Forms.Button()
        Me.txbEmailEMP = New System.Windows.Forms.TextBox()
        Me.txbStatusEMP = New System.Windows.Forms.TextBox()
        Me.txbNumberEMP = New System.Windows.Forms.TextBox()
        Me.txbAgeEMP = New System.Windows.Forms.TextBox()
        Me.txbAddressEMP = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbFnameEMP = New System.Windows.Forms.TextBox()
        Me.ChangeEMP = New System.Windows.Forms.TabPage()
        Me.txbNewPasswordemp = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txbOldPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ApplyEMP = New System.Windows.Forms.TabPage()
        Me.txbReasonLeave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbPlanLeave = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txbDaysLeave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ViewEMP = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeX = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EMPcurrentSalary = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EMPcurrentName = New System.Windows.Forms.Label()
        Me.lblprofile = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewemp = New System.Windows.Forms.Button()
        Me.btnApplyemp = New System.Windows.Forms.Button()
        Me.btnUpdateemp = New System.Windows.Forms.Button()
        Me.btnChangeemp = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateemp = New System.Windows.Forms.Label()
        Me.emptimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.lblPhilhealth = New System.Windows.Forms.Label()
        Me.lblPagibig = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.updateEMP.SuspendLayout()
        Me.ChangeEMP.SuspendLayout()
        Me.ApplyEMP.SuspendLayout()
        Me.ViewEMP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.updateEMP)
        Me.TabControl1.Controls.Add(Me.ChangeEMP)
        Me.TabControl1.Controls.Add(Me.ApplyEMP)
        Me.TabControl1.Controls.Add(Me.ViewEMP)
        Me.TabControl1.Location = New System.Drawing.Point(219, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 511)
        Me.TabControl1.TabIndex = 9
        '
        'updateEMP
        '
        Me.updateEMP.BackColor = System.Drawing.Color.Transparent
        Me.updateEMP.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.updateEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.updateEMP.Controls.Add(Me.txbLnameEMP)
        Me.updateEMP.Controls.Add(Me.txbMnameEMP)
        Me.updateEMP.Controls.Add(Me.btnUpdateFuncEMP)
        Me.updateEMP.Controls.Add(Me.txbEmailEMP)
        Me.updateEMP.Controls.Add(Me.txbStatusEMP)
        Me.updateEMP.Controls.Add(Me.txbNumberEMP)
        Me.updateEMP.Controls.Add(Me.txbAgeEMP)
        Me.updateEMP.Controls.Add(Me.txbAddressEMP)
        Me.updateEMP.Controls.Add(Me.Label29)
        Me.updateEMP.Controls.Add(Me.Label30)
        Me.updateEMP.Controls.Add(Me.Label31)
        Me.updateEMP.Controls.Add(Me.Label32)
        Me.updateEMP.Controls.Add(Me.Label33)
        Me.updateEMP.Controls.Add(Me.Label34)
        Me.updateEMP.Controls.Add(Me.Label7)
        Me.updateEMP.Controls.Add(Me.txbFnameEMP)
        Me.updateEMP.Location = New System.Drawing.Point(4, 22)
        Me.updateEMP.Name = "updateEMP"
        Me.updateEMP.Padding = New System.Windows.Forms.Padding(3)
        Me.updateEMP.Size = New System.Drawing.Size(593, 485)
        Me.updateEMP.TabIndex = 1
        Me.updateEMP.Text = "TabPage2"
        '
        'txbLnameEMP
        '
        Me.txbLnameEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbLnameEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbLnameEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLnameEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbLnameEMP.Location = New System.Drawing.Point(391, 163)
        Me.txbLnameEMP.Multiline = True
        Me.txbLnameEMP.Name = "txbLnameEMP"
        Me.txbLnameEMP.Size = New System.Drawing.Size(110, 29)
        Me.txbLnameEMP.TabIndex = 51
        '
        'txbMnameEMP
        '
        Me.txbMnameEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbMnameEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbMnameEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMnameEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbMnameEMP.Location = New System.Drawing.Point(249, 163)
        Me.txbMnameEMP.Multiline = True
        Me.txbMnameEMP.Name = "txbMnameEMP"
        Me.txbMnameEMP.Size = New System.Drawing.Size(110, 29)
        Me.txbMnameEMP.TabIndex = 50
        '
        'btnUpdateFuncEMP
        '
        Me.btnUpdateFuncEMP.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateFuncEMP.FlatAppearance.BorderSize = 2
        Me.btnUpdateFuncEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateFuncEMP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFuncEMP.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnUpdateFuncEMP.Location = New System.Drawing.Point(249, 409)
        Me.btnUpdateFuncEMP.Name = "btnUpdateFuncEMP"
        Me.btnUpdateFuncEMP.Size = New System.Drawing.Size(124, 45)
        Me.btnUpdateFuncEMP.TabIndex = 49
        Me.btnUpdateFuncEMP.Text = "UPDATE"
        Me.btnUpdateFuncEMP.UseVisualStyleBackColor = False
        '
        'txbEmailEMP
        '
        Me.txbEmailEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbEmailEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbEmailEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbEmailEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbEmailEMP.Location = New System.Drawing.Point(379, 343)
        Me.txbEmailEMP.Multiline = True
        Me.txbEmailEMP.Name = "txbEmailEMP"
        Me.txbEmailEMP.Size = New System.Drawing.Size(208, 29)
        Me.txbEmailEMP.TabIndex = 48
        '
        'txbStatusEMP
        '
        Me.txbStatusEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbStatusEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbStatusEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbStatusEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbStatusEMP.Location = New System.Drawing.Point(379, 274)
        Me.txbStatusEMP.Multiline = True
        Me.txbStatusEMP.Name = "txbStatusEMP"
        Me.txbStatusEMP.Size = New System.Drawing.Size(208, 29)
        Me.txbStatusEMP.TabIndex = 47
        '
        'txbNumberEMP
        '
        Me.txbNumberEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbNumberEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbNumberEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNumberEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbNumberEMP.Location = New System.Drawing.Point(132, 343)
        Me.txbNumberEMP.Multiline = True
        Me.txbNumberEMP.Name = "txbNumberEMP"
        Me.txbNumberEMP.Size = New System.Drawing.Size(125, 29)
        Me.txbNumberEMP.TabIndex = 46
        '
        'txbAgeEMP
        '
        Me.txbAgeEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAgeEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbAgeEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAgeEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbAgeEMP.Location = New System.Drawing.Point(132, 279)
        Me.txbAgeEMP.Multiline = True
        Me.txbAgeEMP.Name = "txbAgeEMP"
        Me.txbAgeEMP.Size = New System.Drawing.Size(45, 29)
        Me.txbAgeEMP.TabIndex = 45
        '
        'txbAddressEMP
        '
        Me.txbAddressEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAddressEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbAddressEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAddressEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbAddressEMP.Location = New System.Drawing.Point(132, 208)
        Me.txbAddressEMP.Multiline = True
        Me.txbAddressEMP.Name = "txbAddressEMP"
        Me.txbAddressEMP.Size = New System.Drawing.Size(440, 29)
        Me.txbAddressEMP.TabIndex = 44
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label29.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(263, 341)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 37)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "EMAIL ADDRESS"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label30.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(11, 341)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 37)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "PHONE NUMBER"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label31.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(259, 271)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 37)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "MARITAL STATUS"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(11, 271)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 37)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "AGE"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(15, 210)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 37)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "ADDRESS"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(18, 155)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 37)
        Me.Label34.TabIndex = 38
        Me.Label34.Text = "FULLNAME"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(126, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(334, 55)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "UPDATE INFORMATION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbFnameEMP
        '
        Me.txbFnameEMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbFnameEMP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbFnameEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFnameEMP.ForeColor = System.Drawing.SystemColors.Info
        Me.txbFnameEMP.Location = New System.Drawing.Point(132, 163)
        Me.txbFnameEMP.Multiline = True
        Me.txbFnameEMP.Name = "txbFnameEMP"
        Me.txbFnameEMP.Size = New System.Drawing.Size(111, 29)
        Me.txbFnameEMP.TabIndex = 6
        '
        'ChangeEMP
        '
        Me.ChangeEMP.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.ChangeEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChangeEMP.Controls.Add(Me.txbNewPasswordemp)
        Me.ChangeEMP.Controls.Add(Me.Panel5)
        Me.ChangeEMP.Controls.Add(Me.btnChangePass)
        Me.ChangeEMP.Controls.Add(Me.Panel4)
        Me.ChangeEMP.Controls.Add(Me.txbOldPassword)
        Me.ChangeEMP.Controls.Add(Me.Label14)
        Me.ChangeEMP.Controls.Add(Me.Label15)
        Me.ChangeEMP.Controls.Add(Me.Label13)
        Me.ChangeEMP.Location = New System.Drawing.Point(4, 22)
        Me.ChangeEMP.Name = "ChangeEMP"
        Me.ChangeEMP.Size = New System.Drawing.Size(593, 485)
        Me.ChangeEMP.TabIndex = 2
        Me.ChangeEMP.Text = "TabPage1"
        Me.ChangeEMP.UseVisualStyleBackColor = True
        '
        'txbNewPasswordemp
        '
        Me.txbNewPasswordemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbNewPasswordemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbNewPasswordemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNewPasswordemp.ForeColor = System.Drawing.SystemColors.Info
        Me.txbNewPasswordemp.Location = New System.Drawing.Point(237, 241)
        Me.txbNewPasswordemp.Multiline = True
        Me.txbNewPasswordemp.Name = "txbNewPasswordemp"
        Me.txbNewPasswordemp.Size = New System.Drawing.Size(176, 27)
        Me.txbNewPasswordemp.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Location = New System.Drawing.Point(239, 269)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 3)
        Me.Panel5.TabIndex = 21
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.FlatAppearance.BorderSize = 2
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnChangePass.Location = New System.Drawing.Point(237, 382)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(124, 45)
        Me.btnChangePass.TabIndex = 21
        Me.btnChangePass.Text = "CHANGE"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Location = New System.Drawing.Point(239, 207)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 3)
        Me.Panel4.TabIndex = 20
        '
        'txbOldPassword
        '
        Me.txbOldPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbOldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOldPassword.ForeColor = System.Drawing.SystemColors.Info
        Me.txbOldPassword.Location = New System.Drawing.Point(237, 180)
        Me.txbOldPassword.Multiline = True
        Me.txbOldPassword.Name = "txbOldPassword"
        Me.txbOldPassword.Size = New System.Drawing.Size(176, 27)
        Me.txbOldPassword.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(31, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 37)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "NEW PASSWORD"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(31, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 37)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "OLD PASSWORD"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(128, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(344, 55)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "CHANGE PASSWORD"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ApplyEMP
        '
        Me.ApplyEMP.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.ApplyEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ApplyEMP.Controls.Add(Me.txbReasonLeave)
        Me.ApplyEMP.Controls.Add(Me.Label5)
        Me.ApplyEMP.Controls.Add(Me.txbPlanLeave)
        Me.ApplyEMP.Controls.Add(Me.btnApply)
        Me.ApplyEMP.Controls.Add(Me.Panel2)
        Me.ApplyEMP.Controls.Add(Me.txbDaysLeave)
        Me.ApplyEMP.Controls.Add(Me.Label3)
        Me.ApplyEMP.Controls.Add(Me.Label4)
        Me.ApplyEMP.Controls.Add(Me.Label17)
        Me.ApplyEMP.Location = New System.Drawing.Point(4, 22)
        Me.ApplyEMP.Name = "ApplyEMP"
        Me.ApplyEMP.Size = New System.Drawing.Size(593, 485)
        Me.ApplyEMP.TabIndex = 3
        Me.ApplyEMP.Text = "TabPage1"
        Me.ApplyEMP.UseVisualStyleBackColor = True
        '
        'txbReasonLeave
        '
        Me.txbReasonLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbReasonLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbReasonLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbReasonLeave.ForeColor = System.Drawing.SystemColors.Info
        Me.txbReasonLeave.Location = New System.Drawing.Point(257, 146)
        Me.txbReasonLeave.Multiline = True
        Me.txbReasonLeave.Name = "txbReasonLeave"
        Me.txbReasonLeave.Size = New System.Drawing.Size(230, 62)
        Me.txbReasonLeave.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 37)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Reason for leave"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbPlanLeave
        '
        Me.txbPlanLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPlanLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbPlanLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPlanLeave.ForeColor = System.Drawing.SystemColors.Info
        Me.txbPlanLeave.Location = New System.Drawing.Point(257, 289)
        Me.txbPlanLeave.Multiline = True
        Me.txbPlanLeave.Name = "txbPlanLeave"
        Me.txbPlanLeave.Size = New System.Drawing.Size(230, 73)
        Me.txbPlanLeave.TabIndex = 29
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Transparent
        Me.btnApply.FlatAppearance.BorderSize = 2
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnApply.Location = New System.Drawing.Point(237, 404)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(124, 45)
        Me.btnApply.TabIndex = 28
        Me.btnApply.Text = "APPLY"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Location = New System.Drawing.Point(259, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(123, 3)
        Me.Panel2.TabIndex = 26
        '
        'txbDaysLeave
        '
        Me.txbDaysLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbDaysLeave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbDaysLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDaysLeave.ForeColor = System.Drawing.SystemColors.Info
        Me.txbDaysLeave.Location = New System.Drawing.Point(257, 228)
        Me.txbDaysLeave.Multiline = True
        Me.txbDaysLeave.Name = "txbDaysLeave"
        Me.txbDaysLeave.Size = New System.Drawing.Size(123, 27)
        Me.txbDaysLeave.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Current work plan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 37)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "How many days"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(145, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(299, 55)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "APPLY LEAVE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewEMP
        '
        Me.ViewEMP.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.ViewEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ViewEMP.Controls.Add(Me.Label23)
        Me.ViewEMP.Controls.Add(Me.lblTotal)
        Me.ViewEMP.Controls.Add(Me.lblTax)
        Me.ViewEMP.Controls.Add(Me.lblPagibig)
        Me.ViewEMP.Controls.Add(Me.lblPhilhealth)
        Me.ViewEMP.Controls.Add(Me.lblSSS)
        Me.ViewEMP.Controls.Add(Me.lblDeduction)
        Me.ViewEMP.Controls.Add(Me.lblBasicSalary)
        Me.ViewEMP.Controls.Add(Me.Label22)
        Me.ViewEMP.Controls.Add(Me.Label21)
        Me.ViewEMP.Controls.Add(Me.Label20)
        Me.ViewEMP.Controls.Add(Me.Label19)
        Me.ViewEMP.Controls.Add(Me.Label18)
        Me.ViewEMP.Controls.Add(Me.Label16)
        Me.ViewEMP.Controls.Add(Me.Label6)
        Me.ViewEMP.Controls.Add(Me.Panel8)
        Me.ViewEMP.Controls.Add(Me.Label26)
        Me.ViewEMP.Location = New System.Drawing.Point(4, 22)
        Me.ViewEMP.Name = "ViewEMP"
        Me.ViewEMP.Size = New System.Drawing.Size(593, 485)
        Me.ViewEMP.TabIndex = 4
        Me.ViewEMP.Text = "TabPage1"
        Me.ViewEMP.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(31, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 37)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "DEDUCTION"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 37)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Basic Salary"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel8.Location = New System.Drawing.Point(34, 410)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(510, 3)
        Me.Panel8.TabIndex = 42
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(146, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(299, 55)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "PAYSLIP"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.team
        Me.Label2.Location = New System.Drawing.Point(12, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 146)
        Me.Label2.TabIndex = 16
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'closeX
        '
        Me.closeX.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.closeX.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeX.ForeColor = System.Drawing.SystemColors.Window
        Me.closeX.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.mmmm
        Me.closeX.Location = New System.Drawing.Point(62, 41)
        Me.closeX.Name = "closeX"
        Me.closeX.Size = New System.Drawing.Size(71, 52)
        Me.closeX.TabIndex = 17
        Me.closeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.twitter_4_32
        Me.Label12.Location = New System.Drawing.Point(1023, 620)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 39)
        Me.Label12.TabIndex = 34
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.linkedin_4_32
        Me.Label11.Location = New System.Drawing.Point(951, 620)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 39)
        Me.Label11.TabIndex = 33
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.facebook_7_32
        Me.Label9.Location = New System.Drawing.Point(874, 620)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 39)
        Me.Label9.TabIndex = 32
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EMPcurrentSalary
        '
        Me.EMPcurrentSalary.BackColor = System.Drawing.Color.Transparent
        Me.EMPcurrentSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EMPcurrentSalary.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPcurrentSalary.Location = New System.Drawing.Point(829, 380)
        Me.EMPcurrentSalary.Name = "EMPcurrentSalary"
        Me.EMPcurrentSalary.Size = New System.Drawing.Size(283, 26)
        Me.EMPcurrentSalary.TabIndex = 31
        Me.EMPcurrentSalary.Text = "Employee Salary"
        Me.EMPcurrentSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_minus_30
        Me.Label10.Location = New System.Drawing.Point(1023, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 37)
        Me.Label10.TabIndex = 30
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_xbox_x_30
        Me.Label8.Location = New System.Drawing.Point(1070, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 37)
        Me.Label8.TabIndex = 29
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EMPcurrentName
        '
        Me.EMPcurrentName.BackColor = System.Drawing.Color.Transparent
        Me.EMPcurrentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EMPcurrentName.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPcurrentName.Location = New System.Drawing.Point(835, 308)
        Me.EMPcurrentName.Name = "EMPcurrentName"
        Me.EMPcurrentName.Size = New System.Drawing.Size(277, 31)
        Me.EMPcurrentName.TabIndex = 28
        Me.EMPcurrentName.Text = "Employee Name"
        Me.EMPcurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprofile
        '
        Me.lblprofile.BackColor = System.Drawing.Color.Transparent
        Me.lblprofile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprofile.ForeColor = System.Drawing.SystemColors.Window
        Me.lblprofile.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.profile_1
        Me.lblprofile.Location = New System.Drawing.Point(874, 108)
        Me.lblprofile.Name = "lblprofile"
        Me.lblprofile.Size = New System.Drawing.Size(195, 207)
        Me.lblprofile.TabIndex = 27
        Me.lblprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogout.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.Logout
        Me.btnLogout.Location = New System.Drawing.Point(835, 61)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(277, 39)
        Me.btnLogout.TabIndex = 26
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnViewemp
        '
        Me.btnViewemp.BackColor = System.Drawing.Color.Transparent
        Me.btnViewemp.FlatAppearance.BorderSize = 0
        Me.btnViewemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewemp.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewemp.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.banknotes_24
        Me.btnViewemp.Location = New System.Drawing.Point(-1, 416)
        Me.btnViewemp.Name = "btnViewemp"
        Me.btnViewemp.Size = New System.Drawing.Size(206, 39)
        Me.btnViewemp.TabIndex = 39
        Me.btnViewemp.Text = " VIEW PAYSLIP"
        Me.btnViewemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewemp.UseVisualStyleBackColor = False
        '
        'btnApplyemp
        '
        Me.btnApplyemp.BackColor = System.Drawing.Color.Transparent
        Me.btnApplyemp.FlatAppearance.BorderSize = 0
        Me.btnApplyemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyemp.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyemp.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.surgical_mask_2_24
        Me.btnApplyemp.Location = New System.Drawing.Point(-1, 363)
        Me.btnApplyemp.Name = "btnApplyemp"
        Me.btnApplyemp.Size = New System.Drawing.Size(201, 39)
        Me.btnApplyemp.TabIndex = 38
        Me.btnApplyemp.Text = " APPLY LEAVE"
        Me.btnApplyemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplyemp.UseVisualStyleBackColor = False
        '
        'btnUpdateemp
        '
        Me.btnUpdateemp.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateemp.FlatAppearance.BorderSize = 0
        Me.btnUpdateemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateemp.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateemp.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.change_user_24
        Me.btnUpdateemp.Location = New System.Drawing.Point(1, 252)
        Me.btnUpdateemp.Name = "btnUpdateemp"
        Me.btnUpdateemp.Size = New System.Drawing.Size(204, 47)
        Me.btnUpdateemp.TabIndex = 37
        Me.btnUpdateemp.Text = " UPDATE INFO..."
        Me.btnUpdateemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateemp.UseVisualStyleBackColor = False
        '
        'btnChangeemp
        '
        Me.btnChangeemp.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeemp.FlatAppearance.BorderSize = 0
        Me.btnChangeemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeemp.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeemp.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.key_4_24
        Me.btnChangeemp.Location = New System.Drawing.Point(4, 306)
        Me.btnChangeemp.Name = "btnChangeemp"
        Me.btnChangeemp.Size = New System.Drawing.Size(204, 42)
        Me.btnChangeemp.TabIndex = 36
        Me.btnChangeemp.Text = " CHANGE PASSWORD"
        Me.btnChangeemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangeemp.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.home_24
        Me.btnDashboard.Location = New System.Drawing.Point(0, 194)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(205, 52)
        Me.btnDashboard.TabIndex = 35
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.helloemp
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(593, 94)
        Me.Label1.TabIndex = 40
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateemp
        '
        Me.lblDateemp.BackColor = System.Drawing.Color.Transparent
        Me.lblDateemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDateemp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateemp.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDateemp.Location = New System.Drawing.Point(623, 129)
        Me.lblDateemp.Name = "lblDateemp"
        Me.lblDateemp.Size = New System.Drawing.Size(189, 37)
        Me.lblDateemp.TabIndex = 41
        Me.lblDateemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'emptimer
        '
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(31, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 37)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "SSS"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(31, 283)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 37)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "PhilHealth"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(31, 327)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 37)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Pag-Ibig"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(31, 374)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 37)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Tax"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(31, 417)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 37)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Total Salary"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.BackColor = System.Drawing.Color.Transparent
        Me.lblBasicSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBasicSalary.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasicSalary.ForeColor = System.Drawing.Color.White
        Me.lblBasicSalary.Location = New System.Drawing.Point(455, 143)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(89, 37)
        Me.lblBasicSalary.TabIndex = 50
        Me.lblBasicSalary.Text = "Basic Salary"
        Me.lblBasicSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeduction
        '
        Me.lblDeduction.BackColor = System.Drawing.Color.Transparent
        Me.lblDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDeduction.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduction.ForeColor = System.Drawing.Color.Red
        Me.lblDeduction.Location = New System.Drawing.Point(455, 188)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(89, 37)
        Me.lblDeduction.TabIndex = 51
        Me.lblDeduction.Text = "Deduction"
        Me.lblDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSSS
        '
        Me.lblSSS.BackColor = System.Drawing.Color.Transparent
        Me.lblSSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSSS.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSS.ForeColor = System.Drawing.Color.White
        Me.lblSSS.Location = New System.Drawing.Point(455, 236)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(89, 37)
        Me.lblSSS.TabIndex = 52
        Me.lblSSS.Text = "SSS"
        Me.lblSSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhilhealth
        '
        Me.lblPhilhealth.BackColor = System.Drawing.Color.Transparent
        Me.lblPhilhealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPhilhealth.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilhealth.ForeColor = System.Drawing.Color.White
        Me.lblPhilhealth.Location = New System.Drawing.Point(455, 283)
        Me.lblPhilhealth.Name = "lblPhilhealth"
        Me.lblPhilhealth.Size = New System.Drawing.Size(89, 37)
        Me.lblPhilhealth.TabIndex = 53
        Me.lblPhilhealth.Text = "Phil Health"
        Me.lblPhilhealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPagibig
        '
        Me.lblPagibig.BackColor = System.Drawing.Color.Transparent
        Me.lblPagibig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPagibig.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagibig.ForeColor = System.Drawing.Color.White
        Me.lblPagibig.Location = New System.Drawing.Point(455, 327)
        Me.lblPagibig.Name = "lblPagibig"
        Me.lblPagibig.Size = New System.Drawing.Size(89, 37)
        Me.lblPagibig.TabIndex = 54
        Me.lblPagibig.Text = "Pagibig"
        Me.lblPagibig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTax.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.White
        Me.lblTax.Location = New System.Drawing.Point(455, 374)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(89, 37)
        Me.lblTax.TabIndex = 55
        Me.lblTax.Text = "Tax"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblTotal.Location = New System.Drawing.Point(455, 417)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 37)
        Me.lblTotal.TabIndex = 56
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.IndianRed
        Me.Label23.Location = New System.Drawing.Point(404, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(140, 37)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "1 Month Salary Period"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.dashy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1116, 681)
        Me.Controls.Add(Me.lblDateemp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewemp)
        Me.Controls.Add(Me.btnApplyemp)
        Me.Controls.Add(Me.btnUpdateemp)
        Me.Controls.Add(Me.btnChangeemp)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.EMPcurrentSalary)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EMPcurrentName)
        Me.Controls.Add(Me.lblprofile)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.closeX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE DASHBOARD"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.ResumeLayout(False)
        Me.updateEMP.ResumeLayout(False)
        Me.updateEMP.PerformLayout()
        Me.ChangeEMP.ResumeLayout(False)
        Me.ChangeEMP.PerformLayout()
        Me.ApplyEMP.ResumeLayout(False)
        Me.ApplyEMP.PerformLayout()
        Me.ViewEMP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents updateEMP As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txbFnameEMP As TextBox
    Friend WithEvents ChangeEMP As TabPage
    Friend WithEvents txbNewPasswordemp As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnChangePass As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txbOldPassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ApplyEMP As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents ViewEMP As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents closeX As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents EMPcurrentSalary As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EMPcurrentName As Label
    Friend WithEvents lblprofile As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewemp As Button
    Friend WithEvents btnApplyemp As Button
    Friend WithEvents btnUpdateemp As Button
    Friend WithEvents btnChangeemp As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateemp As Label
    Friend WithEvents emptimer As Timer
    Friend WithEvents txbEmailEMP As TextBox
    Friend WithEvents txbStatusEMP As TextBox
    Friend WithEvents txbNumberEMP As TextBox
    Friend WithEvents txbAgeEMP As TextBox
    Friend WithEvents txbAddressEMP As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents btnUpdateFuncEMP As Button
    Friend WithEvents txbLnameEMP As TextBox
    Friend WithEvents txbMnameEMP As TextBox
    Friend WithEvents txbReasonLeave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbPlanLeave As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txbDaysLeave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPagibig As Label
    Friend WithEvents lblPhilhealth As Label
    Friend WithEvents lblSSS As Label
    Friend WithEvents lblDeduction As Label
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
End Class
