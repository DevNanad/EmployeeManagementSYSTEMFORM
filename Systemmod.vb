Imports System.Data.OleDb
Module Systemmod
    Public connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=empDB.mdb"
    Public MyConnection As New OleDbConnection(connstring)

    Function connect()
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        Return True
    End Function



End Module
