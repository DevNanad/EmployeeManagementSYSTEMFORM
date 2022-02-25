Imports System.Data.OleDb
Public Class AdminForm

    Public MyConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
    Public MySQL As String
    Public MyCommand As New OleDbCommand
    Public sdr As OleDbDataReader

    Public da As New OleDbDataAdapter
    Public dataset As New DataSet

    Public Property realID As Integer


    'FORM LOAD
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adminclass As New Adminclass
        Dim fullname As String = Nothing
        Dim adminsalary As Integer

        currentAdmin.Text = "ADMIN ID: " & realID
        adminclass.Fetch(realID, fullname, adminsalary)
        currentSalary.Text = adminsalary.ToString("Php ###,###,###.00")
        currentName.Text = fullname
        Timer1.Enabled = True
        Me.CenterToScreen()
        Try
            TabControl1.Appearance = TabAppearance.FlatButtons
            TabControl1.ItemSize = New Size(0, 1)
            TabControl1.SizeMode = TabSizeMode.Fixed
        Catch ex As Exception

        End Try

        'fire fetch dgv fetch function
        adminclass.DgvFetch(dgv)




    End Sub


    'BTN ACTIONS
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnCreate.Click, btnEdit.Click, btnSearch.Click, btnDelete.Click
        Dim adminclass As New Adminclass
        adminclass.DgvFetch(dgv)
        Try
            Dim mybtn = DirectCast(sender, Button)

            Select Case mybtn.Name
                Case "btnDashboard"
                    TabControl1.SelectedTab = Home
                Case "btnCreate"
                    TabControl1.SelectedTab = CreateEmployee
                Case "btnEdit"
                    TabControl1.SelectedTab = EditEmployee
                Case "btnSearch"
                    TabControl1.SelectedTab = SearchEmployee
                Case "btnDelete"
                    TabControl1.SelectedTab = DeleteEmployee

            End Select

        Catch ex As Exception

        End Try
    End Sub


    'TIMER FUNCTION
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dddd,d MMM yyyy")
    End Sub


    'CREATE BUTTTON FUNCTION
    Private Sub btnCreateNEW_Click(sender As Object, e As EventArgs) Handles btnCreateNEW.Click
        Dim adminclass As New Adminclass
        Dim createid As Integer



        If txbUsername.Text = "" Or txbPassword.Text = "" Or txbID.Text = "" Then
            MsgBox("Fields should not be empty! ")
        Else
            If Not String.IsNullOrEmpty(txbID.Text) Then
                createid = Integer.Parse(txbID.Text)
            End If

            Try
                MyConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
                MyConnection.Open()
                MySQL = "SELECT [UserID],[Uname] FROM [emp] WHERE [UserID] =@I OR [Uname] =@U"
                MyCommand = New OleDbCommand(MySQL, MyConnection)
                MyCommand.CommandType = CommandType.Text
                MyCommand.Parameters.AddWithValue("@I", createid)
                MyCommand.Parameters.AddWithValue("@U", txbUsername.Text.ToString)
                sdr = MyCommand.ExecuteReader

                If sdr.Read Then
                    MsgBox("Username or Id already Exist :(")
                Else
                    Try
                        Dim hireddate As Date = Format(Now, "ddd,d MMM yyyy")
                        MySQL = "INSERT INTO [emp] ([UserID],[Department_ID],[Uname],[Upassword],[isAdmin],[HiredDate]) " &
                    "VALUES (?,?,?,?,?,?)"
                        MyConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
                        MyCommand = New OleDbCommand(MySQL, MyConnection)
                        MyConnection.Open()
                        MyCommand.Parameters.AddWithValue("?", CInt(txbID.Text))
                        MyCommand.Parameters.AddWithValue("?", comboDep.SelectedItem.ToString)
                        MyCommand.Parameters.AddWithValue("?", txbUsername.Text.ToString)
                        MyCommand.Parameters.AddWithValue("?", txbPassword.Text.ToString)
                        MyCommand.Parameters.AddWithValue("?", CBool(comboAdm.SelectedItem.ToString))
                        MyCommand.Parameters.AddWithValue("?", hireddate)
                        MyCommand.ExecuteNonQuery()

                        MyConnection.Close()

                        MsgBox("EMPLOYEE CREATED :)")

                        txbID.Clear()
                        txbPassword.Clear()
                        txbUsername.Clear()




                    Catch ex As Exception
                        MsgBox("Error" & ex.Message)

                    End Try
                End If

            Catch ex As Exception
                MsgBox(" Failed check" & ex.Message)
            End Try

        End If

    End Sub


    'VALIDATINg SUB METHOD
    Private Sub txbID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbID.Validating, txbidEdit.Validating, txbSearch.Validating, txbDelete.Validating
        If Not String.IsNullOrWhiteSpace(txbID.Text) AndAlso Not IsNumeric(txbID.Text) Then
            e.Cancel = True
            MsgBox("Provide Integer", MsgBoxStyle.OkOnly, "Invalid Input")
        End If

        If Not String.IsNullOrWhiteSpace(txbidEdit.Text) AndAlso Not IsNumeric(txbidEdit.Text) Then
            e.Cancel = True
            MsgBox("Provide Integer", MsgBoxStyle.OkOnly, "Invalid Input")
        End If

        If Not String.IsNullOrWhiteSpace(txbSearch.Text) AndAlso Not IsNumeric(txbSearch.Text) Then
            e.Cancel = True
            MsgBox("Provide Integer", MsgBoxStyle.OkOnly, "Invalid Input")
        End If

        If Not String.IsNullOrWhiteSpace(txbDelete.Text) AndAlso Not IsNumeric(txbDelete.Text) Then
            e.Cancel = True
            MsgBox("Provide Integer", MsgBoxStyle.OkOnly, "Invalid Input")
        End If

    End Sub


    'LOGOUT BUTTON
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.Show()
        Console.Beep()
        Me.Close()
    End Sub


    'EDIT CHECK ID BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkid As Integer

        If Trim(txbidEdit.Text) = "" Then
            MsgBox("ID should not be empty! ")
        Else
            Try
                If Not String.IsNullOrEmpty(txbidEdit.Text) Then
                    checkid = Integer.Parse(txbidEdit.Text)
                End If


                MyConnection.Open()
                MySQL = "SELECT * FROM [emp] WHERE UserID = @N"
                MyCommand = New OleDbCommand(MySQL, MyConnection)
                MyCommand.CommandType = CommandType.Text
                MyCommand.Parameters.AddWithValue("@N", checkid)
                sdr = MyCommand.ExecuteReader

                If sdr.Read Then
                    MsgBox("Valid ID :)")
                Else
                    MsgBox("Invalid ID :(")
                End If

                MyConnection.Close()

            Catch ex As Exception
                MsgBox("Error in checking id: " & ex.Message)
            End Try

        End If



    End Sub


    'EDIT BUTTION FUNCTION
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkid As Integer
        Try
            If txbNewUsername.Text = "" Or txbNewPassword.Text = "" Then
                MsgBox("Fields should not be empty! ")
            Else
                Try
                    If Not String.IsNullOrEmpty(txbidEdit.Text) Then
                        checkid = Integer.Parse(txbidEdit.Text)
                    End If
                    MySQL = "UPDATE [emp] SET [Uname]=?, [Upassword]=? where UserID=?"
                    MyConnection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=empdb.mdb")
                    MyCommand = New OleDbCommand(MySQL, MyConnection)
                    MyConnection.Open()
                    MyCommand.Parameters.AddWithValue("?", txbNewUsername.Text.ToString)
                    MyCommand.Parameters.AddWithValue("?", txbNewPassword.Text.ToString)
                    MyCommand.Parameters.AddWithValue("?", checkid)
                    MyCommand.ExecuteNonQuery()

                    MsgBox("User Account Updated :)")


                    MyConnection.Close()



                Catch ex As Exception
                    MsgBox("Error in update second try : " & ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error in update first try : " & ex.Message)
        End Try
    End Sub


    'SEARCH BUTTON FUNCTION
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim checkid As Integer

        If Trim(txbSearch.Text) = "" Then
            MsgBox("ID should not be empty! ")
        Else
            Try
                If Not String.IsNullOrEmpty(txbSearch.Text) Then
                    checkid = Integer.Parse(txbSearch.Text)
                End If

                Try
                    MyConnection.Open()
                    MySQL = "SELECT * FROM [emp] WHERE [UserID] =@N"
                    MyCommand = New OleDbCommand(MySQL, MyConnection)
                    MyCommand.CommandType = CommandType.Text
                    MyCommand.Parameters.AddWithValue("@N", checkid)
                    sdr = MyCommand.ExecuteReader

                    If sdr.HasRows Then
                        While sdr.Read
                            fetchfullname.Text = sdr("Fname").ToString & sdr("Mname").ToString & sdr("Lname").ToString
                            fetchaddress.Text = sdr("address").ToString
                            fetchage.Text = sdr("U_age").ToString
                            fetchstatus.Text = sdr("status").ToString
                            fetchphone.Text = "+639" & sdr("pnumber").ToString
                            fetchemail.Text = sdr("email").ToString
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

            Catch ex As Exception
                MsgBox("Error in checking id: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnDeleteAdmin_Click(sender As Object, e As EventArgs) Handles btnDeleteAdmin.Click


        Dim checkid As Integer

        If Trim(txbDelete.Text) = "" Then
            MsgBox("ID should not be empty! ")
        Else
            Try
                If Not String.IsNullOrEmpty(txbDelete.Text) Then
                    checkid = Integer.Parse(txbDelete.Text)
                End If

                MyConnection.Open()
                MySQL = "SELECT * FROM [emp] WHERE UserID = @N"
                MyCommand = New OleDbCommand(MySQL, MyConnection)
                MyCommand.CommandType = CommandType.Text
                MyCommand.Parameters.AddWithValue("@N", checkid)
                sdr = MyCommand.ExecuteReader

                If sdr.Read Then
                    Try
                        MySQL = "DELETE FROM [emp] WHERE [UserID] =?"
                        MyCommand = New OleDbCommand(MySQL, MyConnection)
                        MyCommand.Parameters.AddWithValue("?", checkid)
                        MyCommand.ExecuteNonQuery()

                        'fire fetch dgv fetch function
                        Dim adminclass As New Adminclass
                        adminclass.DgvFetch(dgv)
                        MsgBox("Account DELETED :)")
                        MyConnection.Close()
                    Catch ex As Exception
                        MsgBox("Erron while deleting account: " & ex.Message)
                    End Try
                Else
                    MsgBox("Invalid ID :(")
                    MyConnection.Close()
                End If

                MyConnection.Close()



            Catch ex As Exception
                MsgBox("Error in checking id: " & ex.Message)
            End Try

        End If

    End Sub

End Class




Public Class Adminclass
    Inherits AdminForm


    'FETCH ADMIN INFORMATION
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
            Else

            End If

        Catch ex As Exception
            MsgBox("Login Error " & ex.Message)

        End Try
    End Sub



    Public Function DgvFetch(ByVal dgv)
        Try
            da = New OleDbDataAdapter("Select * from emp", MyConnection)
            dataset = New DataSet
            da.Fill(dataset, "emp")
            dgv.DataSource = dataset.Tables("emp").DefaultView


        Catch ex As Exception
            MsgBox("Dgv error" & ex.Message)
        End Try
        Return True
    End Function
End Class
