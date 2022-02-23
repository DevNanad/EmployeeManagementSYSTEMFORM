<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.closeX = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.CreateEmployee = New System.Windows.Forms.TabPage()
        Me.comboDep = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCreateNEW = New System.Windows.Forms.Button()
        Me.comboAdm = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbUsername = New System.Windows.Forms.TextBox()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.EditEmployee = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txbNewPassword = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txbNewUsername = New System.Windows.Forms.TextBox()
        Me.txbidEdit = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SearchEmployee = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fetchemail = New System.Windows.Forms.Label()
        Me.fetchstatus = New System.Windows.Forms.Label()
        Me.fetchphone = New System.Windows.Forms.Label()
        Me.fetchage = New System.Windows.Forms.Label()
        Me.fetchaddress = New System.Windows.Forms.Label()
        Me.fetchfullname = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DeleteEmployee = New System.Windows.Forms.TabPage()
        Me.btnDeleteAdmin = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txbDelete = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblprofile = New System.Windows.Forms.Label()
        Me.currentName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.currentAdmin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.currentSalary = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreateEmployee.SuspendLayout()
        Me.EditEmployee.SuspendLayout()
        Me.SearchEmployee.SuspendLayout()
        Me.DeleteEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeX
        '
        Me.closeX.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.closeX.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeX.ForeColor = System.Drawing.SystemColors.Window
        Me.closeX.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.mmmm
        Me.closeX.Location = New System.Drawing.Point(59, 55)
        Me.closeX.Name = "closeX"
        Me.closeX.Size = New System.Drawing.Size(71, 52)
        Me.closeX.TabIndex = 7
        Me.closeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.CreateEmployee)
        Me.TabControl1.Controls.Add(Me.EditEmployee)
        Me.TabControl1.Controls.Add(Me.SearchEmployee)
        Me.TabControl1.Controls.Add(Me.DeleteEmployee)
        Me.TabControl1.Location = New System.Drawing.Point(224, 186)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 511)
        Me.TabControl1.TabIndex = 8
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Transparent
        Me.Home.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Home.Controls.Add(Me.lblHome)
        Me.Home.Controls.Add(Me.dgv)
        Me.Home.Location = New System.Drawing.Point(4, 22)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(593, 485)
        Me.Home.TabIndex = 0
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(141, 15)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(299, 55)
        Me.lblHome.TabIndex = 14
        Me.lblHome.Text = "HOME"
        Me.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(9, 76)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(571, 394)
        Me.dgv.TabIndex = 0
        '
        'CreateEmployee
        '
        Me.CreateEmployee.BackColor = System.Drawing.Color.Transparent
        Me.CreateEmployee.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.CreateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateEmployee.Controls.Add(Me.comboDep)
        Me.CreateEmployee.Controls.Add(Me.Panel3)
        Me.CreateEmployee.Controls.Add(Me.Label7)
        Me.CreateEmployee.Controls.Add(Me.btnCreateNEW)
        Me.CreateEmployee.Controls.Add(Me.comboAdm)
        Me.CreateEmployee.Controls.Add(Me.Panel2)
        Me.CreateEmployee.Controls.Add(Me.txbPassword)
        Me.CreateEmployee.Controls.Add(Me.Panel1)
        Me.CreateEmployee.Controls.Add(Me.txbUsername)
        Me.CreateEmployee.Controls.Add(Me.txbID)
        Me.CreateEmployee.Controls.Add(Me.Label6)
        Me.CreateEmployee.Controls.Add(Me.Label5)
        Me.CreateEmployee.Controls.Add(Me.Label4)
        Me.CreateEmployee.Controls.Add(Me.Label3)
        Me.CreateEmployee.Controls.Add(Me.lblID)
        Me.CreateEmployee.Location = New System.Drawing.Point(4, 22)
        Me.CreateEmployee.Name = "CreateEmployee"
        Me.CreateEmployee.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateEmployee.Size = New System.Drawing.Size(593, 485)
        Me.CreateEmployee.TabIndex = 1
        Me.CreateEmployee.Text = "TabPage2"
        '
        'comboDep
        '
        Me.comboDep.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.comboDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboDep.ForeColor = System.Drawing.SystemColors.Info
        Me.comboDep.FormattingEnabled = True
        Me.comboDep.Items.AddRange(New Object() {"IT", "RD", "HR"})
        Me.comboDep.Location = New System.Drawing.Point(209, 159)
        Me.comboDep.Name = "comboDep"
        Me.comboDep.Size = New System.Drawing.Size(89, 23)
        Me.comboDep.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(18, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 223)
        Me.Panel3.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(151, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 55)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CREATE EMPLOYEE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreateNEW
        '
        Me.btnCreateNEW.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateNEW.FlatAppearance.BorderSize = 0
        Me.btnCreateNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNEW.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNEW.ForeColor = System.Drawing.Color.White
        Me.btnCreateNEW.Location = New System.Drawing.Point(240, 392)
        Me.btnCreateNEW.Name = "btnCreateNEW"
        Me.btnCreateNEW.Size = New System.Drawing.Size(124, 45)
        Me.btnCreateNEW.TabIndex = 12
        Me.btnCreateNEW.Text = "CREATE"
        Me.btnCreateNEW.UseVisualStyleBackColor = False
        '
        'comboAdm
        '
        Me.comboAdm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.comboAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAdm.ForeColor = System.Drawing.SystemColors.Info
        Me.comboAdm.FormattingEnabled = True
        Me.comboAdm.Items.AddRange(New Object() {"True", "False"})
        Me.comboAdm.Location = New System.Drawing.Point(206, 303)
        Me.comboAdm.Name = "comboAdm"
        Me.comboAdm.Size = New System.Drawing.Size(89, 23)
        Me.comboAdm.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Location = New System.Drawing.Point(207, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 3)
        Me.Panel2.TabIndex = 10
        '
        'txbPassword
        '
        Me.txbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPassword.ForeColor = System.Drawing.SystemColors.Info
        Me.txbPassword.Location = New System.Drawing.Point(208, 249)
        Me.txbPassword.Multiline = True
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.Size = New System.Drawing.Size(176, 33)
        Me.txbPassword.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Location = New System.Drawing.Point(208, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 3)
        Me.Panel1.TabIndex = 8
        '
        'txbUsername
        '
        Me.txbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsername.ForeColor = System.Drawing.SystemColors.Info
        Me.txbUsername.Location = New System.Drawing.Point(209, 211)
        Me.txbUsername.Multiline = True
        Me.txbUsername.Name = "txbUsername"
        Me.txbUsername.Size = New System.Drawing.Size(176, 27)
        Me.txbUsername.TabIndex = 7
        '
        'txbID
        '
        Me.txbID.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbID.ForeColor = System.Drawing.SystemColors.Info
        Me.txbID.Location = New System.Drawing.Point(209, 112)
        Me.txbID.Multiline = True
        Me.txbID.Name = "txbID"
        Me.txbID.Size = New System.Drawing.Size(123, 21)
        Me.txbID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 37)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ADMIN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PASSWORD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "USERNAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DEPARTMENT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(43, 106)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(49, 37)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditEmployee
        '
        Me.EditEmployee.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.EditEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EditEmployee.Controls.Add(Me.Panel6)
        Me.EditEmployee.Controls.Add(Me.Button2)
        Me.EditEmployee.Controls.Add(Me.txbNewPassword)
        Me.EditEmployee.Controls.Add(Me.Panel5)
        Me.EditEmployee.Controls.Add(Me.Button1)
        Me.EditEmployee.Controls.Add(Me.Panel4)
        Me.EditEmployee.Controls.Add(Me.txbNewUsername)
        Me.EditEmployee.Controls.Add(Me.txbidEdit)
        Me.EditEmployee.Controls.Add(Me.Label14)
        Me.EditEmployee.Controls.Add(Me.Label15)
        Me.EditEmployee.Controls.Add(Me.Label16)
        Me.EditEmployee.Controls.Add(Me.Label13)
        Me.EditEmployee.Location = New System.Drawing.Point(4, 22)
        Me.EditEmployee.Name = "EditEmployee"
        Me.EditEmployee.Size = New System.Drawing.Size(593, 485)
        Me.EditEmployee.TabIndex = 2
        Me.EditEmployee.Text = "TabPage1"
        Me.EditEmployee.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Location = New System.Drawing.Point(267, 170)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(139, 3)
        Me.Panel6.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightYellow
        Me.Button2.Location = New System.Drawing.Point(446, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 30)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txbNewPassword
        '
        Me.txbNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNewPassword.ForeColor = System.Drawing.SystemColors.Info
        Me.txbNewPassword.Location = New System.Drawing.Point(264, 287)
        Me.txbNewPassword.Multiline = True
        Me.txbNewPassword.Name = "txbNewPassword"
        Me.txbNewPassword.Size = New System.Drawing.Size(176, 27)
        Me.txbNewPassword.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Location = New System.Drawing.Point(266, 315)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 3)
        Me.Panel5.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button1.Location = New System.Drawing.Point(237, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 45)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Location = New System.Drawing.Point(266, 253)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 3)
        Me.Panel4.TabIndex = 20
        '
        'txbNewUsername
        '
        Me.txbNewUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbNewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNewUsername.ForeColor = System.Drawing.SystemColors.Info
        Me.txbNewUsername.Location = New System.Drawing.Point(264, 226)
        Me.txbNewUsername.Multiline = True
        Me.txbNewUsername.Name = "txbNewUsername"
        Me.txbNewUsername.Size = New System.Drawing.Size(176, 27)
        Me.txbNewUsername.TabIndex = 19
        '
        'txbidEdit
        '
        Me.txbidEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbidEdit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbidEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbidEdit.ForeColor = System.Drawing.SystemColors.Info
        Me.txbidEdit.Location = New System.Drawing.Point(266, 141)
        Me.txbidEdit.Multiline = True
        Me.txbidEdit.Name = "txbidEdit"
        Me.txbidEdit.Size = New System.Drawing.Size(135, 28)
        Me.txbidEdit.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(58, 294)
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
        Me.Label15.Location = New System.Drawing.Point(58, 222)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 37)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "NEW USERNAME"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(58, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 37)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "ID"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(148, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(299, 55)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "EDIT EMPLOYEE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchEmployee
        '
        Me.SearchEmployee.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.SearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchEmployee.Controls.Add(Me.Button3)
        Me.SearchEmployee.Controls.Add(Me.fetchemail)
        Me.SearchEmployee.Controls.Add(Me.fetchstatus)
        Me.SearchEmployee.Controls.Add(Me.fetchphone)
        Me.SearchEmployee.Controls.Add(Me.fetchage)
        Me.SearchEmployee.Controls.Add(Me.fetchaddress)
        Me.SearchEmployee.Controls.Add(Me.fetchfullname)
        Me.SearchEmployee.Controls.Add(Me.Label24)
        Me.SearchEmployee.Controls.Add(Me.Label23)
        Me.SearchEmployee.Controls.Add(Me.Label22)
        Me.SearchEmployee.Controls.Add(Me.Label21)
        Me.SearchEmployee.Controls.Add(Me.Label20)
        Me.SearchEmployee.Controls.Add(Me.Label19)
        Me.SearchEmployee.Controls.Add(Me.Panel7)
        Me.SearchEmployee.Controls.Add(Me.txbSearch)
        Me.SearchEmployee.Controls.Add(Me.Label18)
        Me.SearchEmployee.Controls.Add(Me.Label17)
        Me.SearchEmployee.Location = New System.Drawing.Point(4, 22)
        Me.SearchEmployee.Name = "SearchEmployee"
        Me.SearchEmployee.Size = New System.Drawing.Size(593, 485)
        Me.SearchEmployee.TabIndex = 3
        Me.SearchEmployee.Text = "TabPage1"
        Me.SearchEmployee.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(247, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 33)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'fetchemail
        '
        Me.fetchemail.BackColor = System.Drawing.Color.Transparent
        Me.fetchemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchemail.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchemail.ForeColor = System.Drawing.Color.White
        Me.fetchemail.Location = New System.Drawing.Point(402, 371)
        Me.fetchemail.Name = "fetchemail"
        Me.fetchemail.Size = New System.Drawing.Size(160, 37)
        Me.fetchemail.TabIndex = 37
        Me.fetchemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fetchstatus
        '
        Me.fetchstatus.BackColor = System.Drawing.Color.Transparent
        Me.fetchstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchstatus.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchstatus.ForeColor = System.Drawing.Color.White
        Me.fetchstatus.Location = New System.Drawing.Point(402, 304)
        Me.fetchstatus.Name = "fetchstatus"
        Me.fetchstatus.Size = New System.Drawing.Size(160, 37)
        Me.fetchstatus.TabIndex = 36
        Me.fetchstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fetchphone
        '
        Me.fetchphone.BackColor = System.Drawing.Color.Transparent
        Me.fetchphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchphone.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchphone.ForeColor = System.Drawing.Color.White
        Me.fetchphone.Location = New System.Drawing.Point(146, 374)
        Me.fetchphone.Name = "fetchphone"
        Me.fetchphone.Size = New System.Drawing.Size(130, 37)
        Me.fetchphone.TabIndex = 35
        Me.fetchphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fetchage
        '
        Me.fetchage.BackColor = System.Drawing.Color.Transparent
        Me.fetchage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchage.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchage.ForeColor = System.Drawing.Color.White
        Me.fetchage.Location = New System.Drawing.Point(148, 304)
        Me.fetchage.Name = "fetchage"
        Me.fetchage.Size = New System.Drawing.Size(65, 37)
        Me.fetchage.TabIndex = 34
        Me.fetchage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fetchaddress
        '
        Me.fetchaddress.BackColor = System.Drawing.Color.Transparent
        Me.fetchaddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchaddress.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchaddress.ForeColor = System.Drawing.Color.White
        Me.fetchaddress.Location = New System.Drawing.Point(148, 243)
        Me.fetchaddress.Name = "fetchaddress"
        Me.fetchaddress.Size = New System.Drawing.Size(439, 37)
        Me.fetchaddress.TabIndex = 33
        Me.fetchaddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fetchfullname
        '
        Me.fetchfullname.BackColor = System.Drawing.Color.Transparent
        Me.fetchfullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchfullname.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchfullname.ForeColor = System.Drawing.Color.White
        Me.fetchfullname.Location = New System.Drawing.Point(148, 188)
        Me.fetchfullname.Name = "fetchfullname"
        Me.fetchfullname.Size = New System.Drawing.Size(439, 37)
        Me.fetchfullname.TabIndex = 32
        Me.fetchfullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(282, 374)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 37)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "EMAIL ADDRESS"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(30, 374)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 37)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "PHONE NUMBER"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(278, 304)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 37)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "MARITAL STATUS"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(30, 304)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 37)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "AGE"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(34, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 37)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "ADDRESS"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(37, 188)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 37)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "FULLNAME"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel7.Location = New System.Drawing.Point(102, 101)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 3)
        Me.Panel7.TabIndex = 25
        '
        'txbSearch
        '
        Me.txbSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSearch.ForeColor = System.Drawing.SystemColors.Info
        Me.txbSearch.Location = New System.Drawing.Point(106, 76)
        Me.txbSearch.Multiline = True
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(135, 28)
        Me.txbSearch.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(37, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 37)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "ID"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label17.Text = "SEARCH PEOPLE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteEmployee
        '
        Me.DeleteEmployee.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.rec
        Me.DeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DeleteEmployee.Controls.Add(Me.btnDeleteAdmin)
        Me.DeleteEmployee.Controls.Add(Me.Panel8)
        Me.DeleteEmployee.Controls.Add(Me.txbDelete)
        Me.DeleteEmployee.Controls.Add(Me.Label25)
        Me.DeleteEmployee.Controls.Add(Me.Label26)
        Me.DeleteEmployee.Location = New System.Drawing.Point(4, 22)
        Me.DeleteEmployee.Name = "DeleteEmployee"
        Me.DeleteEmployee.Size = New System.Drawing.Size(593, 485)
        Me.DeleteEmployee.TabIndex = 4
        Me.DeleteEmployee.Text = "TabPage1"
        Me.DeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnDeleteAdmin
        '
        Me.btnDeleteAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAdmin.FlatAppearance.BorderSize = 2
        Me.btnDeleteAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAdmin.ForeColor = System.Drawing.Color.IndianRed
        Me.btnDeleteAdmin.Location = New System.Drawing.Point(386, 252)
        Me.btnDeleteAdmin.Name = "btnDeleteAdmin"
        Me.btnDeleteAdmin.Size = New System.Drawing.Size(69, 33)
        Me.btnDeleteAdmin.TabIndex = 43
        Me.btnDeleteAdmin.Text = "DELETE"
        Me.btnDeleteAdmin.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel8.Location = New System.Drawing.Point(202, 276)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(139, 3)
        Me.Panel8.TabIndex = 42
        '
        'txbDelete
        '
        Me.txbDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbDelete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDelete.ForeColor = System.Drawing.SystemColors.Info
        Me.txbDelete.Location = New System.Drawing.Point(202, 249)
        Me.txbDelete.Multiline = True
        Me.txbDelete.Name = "txbDelete"
        Me.txbDelete.Size = New System.Drawing.Size(139, 28)
        Me.txbDelete.TabIndex = 41
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(60, 249)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 37)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Supply ID"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label26.Text = "DELETE ACCOUNT"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.welcam
        Me.Label1.Location = New System.Drawing.Point(225, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(593, 94)
        Me.Label1.TabIndex = 9
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.home_24
        Me.btnDashboard.Location = New System.Drawing.Point(0, 196)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(205, 52)
        Me.btnDashboard.TabIndex = 10
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.edit_12_24
        Me.btnEdit.Location = New System.Drawing.Point(0, 308)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(204, 42)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = " EDIT EMPLOYEE"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.add_user_3_24
        Me.btnCreate.Location = New System.Drawing.Point(1, 254)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(204, 47)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = " CREATE EMPLOYEE"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.search_9_24
        Me.btnSearch.Location = New System.Drawing.Point(2, 365)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(204, 39)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = " SEARCH PEOPLE"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Cascadia Mono PL", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.delete_24
        Me.btnDelete.Location = New System.Drawing.Point(1, 418)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(206, 39)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = " DELETE EMPLOYEE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.team
        Me.Label2.Location = New System.Drawing.Point(7, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 146)
        Me.Label2.TabIndex = 15
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.Logout
        Me.Button5.Location = New System.Drawing.Point(837, 57)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(277, 39)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Logout"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lblprofile
        '
        Me.lblprofile.BackColor = System.Drawing.Color.Transparent
        Me.lblprofile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprofile.ForeColor = System.Drawing.SystemColors.Window
        Me.lblprofile.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.profile_1
        Me.lblprofile.Location = New System.Drawing.Point(876, 104)
        Me.lblprofile.Name = "lblprofile"
        Me.lblprofile.Size = New System.Drawing.Size(195, 207)
        Me.lblprofile.TabIndex = 17
        Me.lblprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'currentName
        '
        Me.currentName.BackColor = System.Drawing.Color.Transparent
        Me.currentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.currentName.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentName.Location = New System.Drawing.Point(837, 304)
        Me.currentName.Name = "currentName"
        Me.currentName.Size = New System.Drawing.Size(277, 31)
        Me.currentName.TabIndex = 18
        Me.currentName.Text = "Admin Name"
        Me.currentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDate.Location = New System.Drawing.Point(629, 133)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(189, 37)
        Me.lblDate.TabIndex = 14
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_xbox_x_30
        Me.Label8.Location = New System.Drawing.Point(1072, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 37)
        Me.Label8.TabIndex = 19
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'currentAdmin
        '
        Me.currentAdmin.BackColor = System.Drawing.Color.Transparent
        Me.currentAdmin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentAdmin.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.currentAdmin.Location = New System.Drawing.Point(234, 118)
        Me.currentAdmin.Name = "currentAdmin"
        Me.currentAdmin.Size = New System.Drawing.Size(274, 52)
        Me.currentAdmin.TabIndex = 20
        Me.currentAdmin.Text = "Id"
        Me.currentAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.icons8_minus_30
        Me.Label10.Location = New System.Drawing.Point(1025, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 37)
        Me.Label10.TabIndex = 21
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'currentSalary
        '
        Me.currentSalary.BackColor = System.Drawing.Color.Transparent
        Me.currentSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.currentSalary.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentSalary.Location = New System.Drawing.Point(831, 376)
        Me.currentSalary.Name = "currentSalary"
        Me.currentSalary.Size = New System.Drawing.Size(283, 26)
        Me.currentSalary.TabIndex = 22
        Me.currentSalary.Text = "Admin Salary"
        Me.currentSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.facebook_7_32
        Me.Label9.Location = New System.Drawing.Point(876, 616)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 39)
        Me.Label9.TabIndex = 23
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.linkedin_4_32
        Me.Label11.Location = New System.Drawing.Point(953, 616)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 39)
        Me.Label11.TabIndex = 24
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Image = Global.EmployeeManagementSYSTEM.My.Resources.Resources.twitter_4_32
        Me.Label12.Location = New System.Drawing.Point(1025, 616)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 39)
        Me.Label12.TabIndex = 25
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.EmployeeManagementSYSTEM.My.Resources.Resources.dashy
        Me.ClientSize = New System.Drawing.Size(1116, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.currentSalary)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.currentAdmin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.currentName)
        Me.Controls.Add(Me.lblprofile)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.closeX)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN DASHBOARD"
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.TabControl1.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreateEmployee.ResumeLayout(False)
        Me.CreateEmployee.PerformLayout()
        Me.EditEmployee.ResumeLayout(False)
        Me.EditEmployee.PerformLayout()
        Me.SearchEmployee.ResumeLayout(False)
        Me.SearchEmployee.PerformLayout()
        Me.DeleteEmployee.ResumeLayout(False)
        Me.DeleteEmployee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeX As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents CreateEmployee As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents EditEmployee As TabPage
    Friend WithEvents SearchEmployee As TabPage
    Friend WithEvents DeleteEmployee As TabPage
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents lblprofile As Label
    Friend WithEvents currentName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCreateNEW As Button
    Friend WithEvents comboAdm As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbUsername As TextBox
    Friend WithEvents txbID As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents currentAdmin As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents currentSalary As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblHome As Label
    Friend WithEvents comboDep As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txbNewUsername As TextBox
    Friend WithEvents txbidEdit As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txbNewPassword As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents fetchemail As Label
    Friend WithEvents fetchstatus As Label
    Friend WithEvents fetchphone As Label
    Friend WithEvents fetchage As Label
    Friend WithEvents fetchaddress As Label
    Friend WithEvents fetchfullname As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDeleteAdmin As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txbDelete As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
