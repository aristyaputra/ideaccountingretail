Imports Microsoft.Win32

Module mdlODBC

    Public Function checkMySQLDriver(ByRef DriverODBC As String) As Boolean
        Dim regHandle As RegistryKey            ' Stores the Handle to Registry in which values need to be set
        Dim reg As RegistryKey = Registry.LocalMachine
        Dim conRegKey1 As String = "SOFTWARE\ODBC\ODBCINST.INI\MySQL ODBC 5.1 Driver"
        Try
            regHandle = reg.OpenSubKey(conRegKey1)
            If regHandle.ValueCount > 0 Then
                DriverODBC = regHandle.GetValue("Driver")
                checkMySQLDriver = True
            Else
                checkMySQLDriver = False
            End If
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Function

    Public Function MakeMySQLDSN(ByVal DB_Name As String, _
                               ByVal DSN As String, _
                               ByVal Description As String, _
                               ByVal Driver_Name As String, _
                               ByVal userid As String, _
                               ByVal password As String, _
                               ByVal Server_Name As String, _
                               ByVal port As String, _
                               ByVal stroption As String, _
                               ByVal stmt As String _
                               ) As Boolean

        Dim lResult As Long
        Dim hKeyHandle As Long
        Dim msg1 As String

        Dim regHandle As RegistryKey ' Stores the Handle to Registry in which values need to be set

        Dim reg As RegistryKey = Registry.CurrentUser
        Dim conRegKey1 As String = "SOFTWARE\ODBC\ODBC.INI\" & DSN
        Dim conRegKey2 As String = "SOFTWARE\ODBC\ODBC.INI\ODBC Data Sources"

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            regHandle = reg.CreateSubKey(conRegKey1)
            regHandle.SetValue("Database", DB_Name)
            regHandle.SetValue("Description", Description)
            regHandle.SetValue("Driver", Driver_Name)
            regHandle.SetValue("Option", stroption)
            regHandle.SetValue("Password", password)
            regHandle.SetValue("Port", port)
            regHandle.SetValue("Server", Server_Name)
            regHandle.SetValue("Stmt", stmt)
            regHandle.SetValue("User", userid)
            regHandle.Close()
            reg.Close()

            regHandle = reg.CreateSubKey(conRegKey2)
            regHandle.SetValue(DSN, "MySQL ODBC 5.1 Driver")
            regHandle.Close()
            reg.Close()

        Catch err As Exception
            MsgBox("ODBC Register Failed", MsgBoxStyle.Exclamation, "Error")
        End Try

       
    End Function


    Public Function MySQLDSNWanted(ByVal strdsnName As String) As Boolean
        Dim reghandle As RegistryKey
        Dim reg As RegistryKey = Registry.LocalMachine
        Dim conRegKey1 As String = "SOFTWARE\ODBC\ODBC.INI\ODBC Data Sources\"
        Dim tmpdsnvalue As String
        Try
            reghandle = reg.OpenSubKey(conRegKey1)
            If reghandle.ValueCount > 0 Then
                tmpdsnvalue = reghandle.GetValue(strdsnName)
                If tmpdsnvalue = "" Then
                    MySQLDSNWanted = False
                Else
                    MySQLDSNWanted = True
                End If
            Else
                MySQLDSNWanted = False
            End If
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Function


End Module
