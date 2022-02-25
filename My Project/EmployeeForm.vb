Imports System.Data.OleDb
Public Class EmployeeForm
    Public MyConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
    Public MySQL As String
    Public MyCommand As New OleDbCommand
    Public sdr As OleDbDataReader
    Public Property realID As Integer

    'Logout btn
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Console.Beep()
        Me.Close()
    End Sub

    'BTN Actions
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnChangeemp.Click, btnUpdateemp.Click, btnApplyemp.Click, btnViewemp.Click
        Try
            Dim mybtn = DirectCast(sender, Button)

            Select Case mybtn.Name
                Case "btnDashboard"
                    TabControl1.SelectedTab = updateEMP
                Case "btnUpdateemp"
                    TabControl1.SelectedTab = updateEMP
                Case "btnChangeemp"
                    TabControl1.SelectedTab = ChangeEMP
                Case "btnApplyemp"
                    TabControl1.SelectedTab = ApplyEMP
                Case "btnViewemp"
                    TabControl1.SelectedTab = ViewEMP

            End Select

        Catch ex As Exception

        End Try
    End Sub

    'timer sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles emptimer.Tick
        lblDateemp.Text = Date.Now.ToString("dddd,d MMM yyyy")
    End Sub


    'Form Load
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullname As String = Nothing
        Dim empsalary As Integer

        emptimer.Enabled = True
        Try
            TabControl1.Appearance = TabAppearance.FlatButtons
            TabControl1.ItemSize = New Size(0, 1)
            TabControl1.SizeMode = TabSizeMode.Fixed
        Catch ex As Exception

        End Try

        Fetch(realID, fullname, empsalary)
        EMPcurrentSalary.Text = empsalary.ToString("Php ###,###,###.00")
        EMPcurrentName.Text = fullname

        Updatefetch()
        Payslip()

    End Sub


    'Salary and Name 
    Public Sub Fetch(ByVal id, ByRef fullname, ByRef adminsalary)
        Try
            MyConnection.Open()
            MySQL = "SELECT * FROM [emp] WHERE UserID = @N"
            MyCommand = New OleDbCommand(MySQL, MyConnection)
            MyCommand.CommandType = CommandType.Text
            MyCommand.Parameters.AddWithValue("@N", CInt(id))
            sdr = MyCommand.ExecuteReader


            If sdr.Read Then
                fullname = sdr("Fname") & " " & sdr("Lname")
                adminsalary = sdr("salary")
                MyConnection.Close()
            Else

            End If
            MyConnection.Close()
        Catch ex As Exception
            MsgBox("Login Error " & ex.Message)
            MyConnection.Close()
        End Try
    End Sub

    'Total Function
    Private Function Takehome(ByRef a As Double,
                              ByRef b As Double,
                              ByRef c As Double,
                              ByRef d As Double,
                              ByRef salary As Double)

        Return (salary - (a + b + c + d)).ToString("Php ###,###,###.00")
    End Function


    'Payslip Fetch Sub
    Private Sub Payslip()
        Try
            MyConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
            MyConnection.Open()
            MySQL = "SELECT * FROM [emp] WHERE [UserID] =@N"
            MyCommand = New OleDbCommand(MySQL, MyConnection)
            MyCommand.CommandType = CommandType.Text
            MyCommand.Parameters.AddWithValue("@N", realID)
            sdr = MyCommand.ExecuteReader

            If sdr.Read Then

                lblBasicSalary.Text = sdr("salary").ToString
                lblDeduction.Text = sdr("deduction").ToString
                lblSSS.Text = sdr("sss").ToString
                lblPhilhealth.Text = sdr("phealth").ToString()
                lblPagibig.Text = sdr("pibig").ToString()
                lblTax.Text = sdr("tax").ToString()
                lblTotal.Text = Takehome(sdr("tax"), sdr("sss"), sdr("phealth"), sdr("pibig"), sdr("salary"))

            End If

            MyConnection.Close()

        Catch ex As Exception
            MsgBox("Error in name fetch: " & ex.Message)
        End Try
    End Sub

    'Fetch Sub
    Private Sub Updatefetch()
        Try
            MyConnection.Open()
            MySQL = "SELECT * FROM [emp] WHERE [UserID] =@N"
            MyCommand = New OleDbCommand(MySQL, MyConnection)
            MyCommand.CommandType = CommandType.Text
            MyCommand.Parameters.AddWithValue("@N", realID)
            sdr = MyCommand.ExecuteReader

            If sdr.HasRows Then
                While sdr.Read
                    txbFnameEMP.Text = sdr("Fname").ToString
                    txbMnameEMP.Text = sdr("Mname").ToString
                    txbLnameEMP.Text = sdr("Lname").ToString
                    txbAddressEMP.Text = sdr("address").ToString
                    txbAgeEMP.Text = sdr("U_age").ToString
                    txbStatusEMP.Text = sdr("status").ToString
                    txbNumberEMP.Text = "+639" & sdr("pnumber").ToString
                    txbEmailEMP.Text = sdr("email").ToString
                End While
                sdr.Close()
            Else
                MsgBox("Invalid ID :(")
            End If
            MyConnection.Close()




        Catch ex As Exception
            MsgBox("Error in fetch: " & ex.Message)
        End Try

        MyConnection.Close()
    End Sub

    'Update btn
    Private Sub btnUpdateFuncEMP_Click(sender As Object, e As EventArgs) Handles btnUpdateFuncEMP.Click
        Try
            MySQL = "UPDATE [emp] SET [Fname]=?, [Mname]=?, [Lname]=?, [address]=?, [status]=?, [email]=? where UserID=?"
            MyConnection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=empdb.mdb")
            MyCommand = New OleDbCommand(MySQL, MyConnection)
            MyConnection.Open()
            MyCommand.Parameters.AddWithValue("?", txbFnameEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", txbMnameEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", txbLnameEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", txbAddressEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", txbStatusEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", txbEmailEMP.Text.ToString)
            MyCommand.Parameters.AddWithValue("?", realID)
            MyCommand.ExecuteNonQuery()

            Updatefetch()


            MsgBox("Information Updated :)")

            MyConnection.Close()

        Catch ex As Exception
            MsgBox("Error in update second try : " & ex.Message)

        End Try
    End Sub

    'Change pass btn
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If txbOldPassword.Text = "" Then
            MsgBox("Old Password Should not be empty!")
        Else
            Try
                MyConnection.Open()
                MySQL = "SELECT * FROM [emp] WHERE [Upassword]=@P AND [UserID]=@N"
                MyCommand = New OleDbCommand(MySQL, MyConnection)
                MyCommand.CommandType = CommandType.Text
                MyCommand.Parameters.AddWithValue("@P", txbOldPassword.Text.ToString)
                MyCommand.Parameters.AddWithValue("@N", realID)
                sdr = MyCommand.ExecuteReader

                If sdr.Read Then
                    Try
                        MySQL = "UPDATE [emp] SET [Upassword]=? where UserID=?"
                        MyCommand = New OleDbCommand(MySQL, MyConnection)
                        'MyConnection.Open()
                        MyCommand.Parameters.AddWithValue("?", txbNewPasswordemp.Text.ToString)
                        MyCommand.Parameters.AddWithValue("?", realID)
                        MyCommand.ExecuteNonQuery()

                        MyConnection.Close()
                        MsgBox("Password UPDATED :)")

                        txbOldPassword.Text = ""
                        txbNewPasswordemp.Text = ""


                    Catch ex As Exception
                        MsgBox("Error in 2nd update password:" & ex.Message)
                        MyConnection.Close()
                    End Try
                Else
                    MsgBox("Password does not Match the record :)")
                    MyConnection.Close()
                End If

                MyConnection.Close()

            Catch ex As Exception
                MsgBox("Error in 1st update password:" & ex.Message)
                MyConnection.Close()
            End Try
        End If

    End Sub

    'Apply btn
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If txbPlanLeave.Text = "" OrElse txbDaysLeave.Text = "" OrElse txbPlanLeave.Text = "" Then
            MsgBox("Fields Should be empty! ")
        Else
            Try
                Dim leavedate As Date = Format(Now, "dddd,d MMM yyyy")
                MySQL = "INSERT INTO [leave] ([Leave_ID],[Reason],[Days],[Workplan],[Leave_date]) " &
                "VALUES (?,?,?,?,?)"
                MyConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
                MyCommand = New OleDbCommand(MySQL, MyConnection)
                MyConnection.Open()
                MyCommand.Parameters.AddWithValue("?", realID)
                MyCommand.Parameters.AddWithValue("?", txbReasonLeave.Text.ToString)
                MyCommand.Parameters.AddWithValue("?", txbDaysLeave.Text.ToString)
                MyCommand.Parameters.AddWithValue("?", txbPlanLeave.Text.ToString)
                MyCommand.Parameters.AddWithValue("?", leavedate)
                MyCommand.ExecuteNonQuery()

                MyConnection.Close()

                MsgBox("Succesful application")


            Catch ex As Exception
                MsgBox("Error in application : " & ex.Message)
            End Try
        End If
    End Sub

    'close btn
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub
    'minimized btn
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
