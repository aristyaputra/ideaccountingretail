Imports MySql.Data.MySqlClient
Imports System.IO

Module mdldbconn
    Public server_config, port_config, passdb_config, userdb_config, db_config As String
    Public conn As New MySqlConnection

    Public Function connec_open() As Boolean
        Try
            get_config_database()
            conn.ConnectionString = "server='" & server_config & "';User Id='" & userdb_config & "';password='" & passdb_config & "';Persist Security Info=False;database='" & db_config & "';port='" & port_config & "'"
            conn.Open()
            Return True
        Catch ex As MySqlException
            MsgBox("Gagal Koneksi Ke server")
            Process.Start(Application.StartupPath & "\config.exe")
            End
            Return False
        End Try
    End Function

    Public Sub get_config_database()
        Try
            Using sr As New StreamReader(Application.StartupPath & "\config.ini")
                Dim line As String
                For i As Integer = 1 To 5
                    line = sr.ReadLine
                    If i = 1 Then
                        server_config = DekripsiID(line)
                    ElseIf i = 2 Then
                        port_config = DekripsiID(line)
                    ElseIf i = 3 Then
                        userdb_config = DekripsiID(line)
                    ElseIf i = 4 Then
                        passdb_config = DekripsiID(line)
                    ElseIf i = 5 Then
                        db_config = DekripsiID(line)
                    End If
                Next

            End Using
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

  
End Module
