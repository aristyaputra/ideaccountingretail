Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO

Public Class Start

    Private Sub Start_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim timer As New Timer
        timer.Interval = 1000
        timer.Start()
        AddHandler timer.Tick, AddressOf Timer1_Tick
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        open_conn()
        Dim var_date As Date
        var_date = Now
        lbl_date.Text = Format(var_date, "dd-MM-yyyy")
        lbl_time.Text = Format(var_date, "hh:mm:ss")
       
        Dim DT As DataTable
        DT = getAutoBackup()
        If DT.Rows.Count > 0 And username = "admin" Then
            If DT.Rows(0).Item("Type") = "Harian" Then
                Dim Jam As TimeSpan
                Dim Path As String
                Jam = DT.Rows(0).Item("time")
                Path = Replace(DT.Rows(0).Item("filepath"), "/", "\")
                If Format(var_date, "hh:mm:ss") = Jam.ToString Then
                    Try
                        SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
                        SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                        SplashScreenManager.Default.SetWaitFormDescription("Processing Auto Backup . . .")
                        backup_run(Path & "\baksmart" & Format(var_date, "ddMMyyyy") & ".sql")
                    Catch ex As Exception
                        Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                        alertControl_error.Show(Me, info)
                    Finally
                        SplashScreenManager.CloseForm(False)
                        Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, "Auto Backup Selesai")
                        alertControl_success.Show(Me, info)
                        Me.Enabled = True
                        MainMenu.Enabled = True
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub backup_run(ByVal path As String)
        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        If (Not System.IO.Directory.Exists("C:\PROGRAM Files (x86)\MySQL Server Yolk\bin\")) Then
            myProcess.StartInfo.WorkingDirectory = "C:\PROGRAM Files\MySQL Server Yolk\bin\"
        Else
            myProcess.StartInfo.WorkingDirectory = "C:\PROGRAM Files (x86)\MySQL Server Yolk\bin\"
        End If
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        Me.Activate()
        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        myStreamWriter.WriteLine("mysqldump --opt --routines -u " & userdb_config & " --password=" & passdb_config & " -h " & server_config & " --port=" & port_config & " " & db_config & " > """ + path + """ ")
        myStreamWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub
End Class