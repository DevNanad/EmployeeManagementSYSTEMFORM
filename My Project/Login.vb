Public Class Login

    'Login Form Load
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        usernamef.Padding = New Padding(0, 10, 0, 0)
    End Sub

    'close btn
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles closeX.Click
        Me.Close()
    End Sub

    'minimized btn
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles minimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Show password 
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            passwordf.PasswordChar = ""
        Else
            passwordf.PasswordChar = "*"
        End If
    End Sub

    'Login redirect
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles loginfunc.Click

        Dim userclass As New Userclass
        Dim state As String = Nothing
        Dim userid As Integer

        If usernamef.Text = "" Or passwordf.Text = "" Then
            MsgBox("Fields should not be empty! ", MsgBoxStyle.OkOnly, "Check Input")
        Else
            userclass.Logins(usernamef.Text, passwordf.Text, state, userid)

            If state = "admin" Then

                AdminForm.realID = userid
                AdminForm.Show()
                Console.Beep()
                Me.Close()



            ElseIf state = "employee" Then
                EmployeeForm.realID = userid
                EmployeeForm.Show()
                Console.Beep()
                Me.Close()
            End If


        End If



    End Sub
End Class
