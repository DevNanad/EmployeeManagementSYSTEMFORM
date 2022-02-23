Imports System.Data.OleDb
Public Class EmployeeForm
    Public MyConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
    Public MySQL As String
    Public MyCommand As New OleDbCommand
    Public sdr As OleDbDataReader
    Public Property realID As Integer
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Console.Beep()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnChangeemp.Click, btnUpdateemp.Click, btnApplyemp.Click, btnViewemp.Click
        Try
            Dim mybtn = DirectCast(sender, Button)

            Select Case mybtn.Name
                Case "btnDashboard"
                    TabControl1.SelectedTab = HomeEMP
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles emptimer.Tick
        lblDateemp.Text = Date.Now.ToString("dddd,d MMM yyyy")
    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emptimer.Enabled = True
        Try
            TabControl1.Appearance = TabAppearance.FlatButtons
            TabControl1.ItemSize = New Size(0, 1)
            TabControl1.SizeMode = TabSizeMode.Fixed
        Catch ex As Exception

        End Try


        Updatefetch()




    End Sub

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
End Class
