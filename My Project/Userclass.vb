Imports System.Data.OleDb
Public Class Userclass
    Public MyConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb")
    Public MySQL As String
    Public MyCommand As New OleDbCommand
    Public sdr As OleDbDataReader

    'Login Function
    Public Sub Logins(ByRef uname, ByRef upass, ByRef stato, ByRef userid)

        Try
            MyConnection.Open()
            MySQL = "SELECT UserID, Uname, [Upassword], isAdmin,Fname,Lname FROM [emp] WHERE Uname like @N AND [Upassword] like @P"
            MyCommand = New OleDbCommand(MySQL, MyConnection)
            MyCommand.CommandType = CommandType.Text
            MyCommand.Parameters.AddWithValue("@N", Trim(uname))
            MyCommand.Parameters.AddWithValue("@P", Trim(upass))
            sdr = MyCommand.ExecuteReader




            If sdr.Read Then
                Dim realU As String = sdr("Uname")
                Dim realP As String = CStr(sdr("Upassword"))

                If realU Like Trim(uname) And realP Like Trim(upass).ToString Then
                    If sdr("IsAdmin") Then

                        stato = "admin"
                        userid = sdr("UserID")

                    Else


                        userid = sdr("UserID")
                        stato = "employee"


                    End If
                Else
                    MsgBox("Invalid Username or Password!")
                End If



            Else
                MsgBox("Invalid Username or Password!")

            End If

        Catch ex As Exception
            MsgBox("Login Error " & ex.Message)

        End Try


    End Sub
End Class
