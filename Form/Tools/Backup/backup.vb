Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO
Imports DevExpress.XtraBars.Alerter

Public Class backup
    Dim sfd As New SaveFileDialog
    Dim sender As Object
    Dim e As System.EventArgs
    Dim file As String

    Private Sub btnProsess2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProsess2.Click
        open_conn()

        If Trim(TextBox1.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Backup Option", "Pilih direktory backup")
            alertControl_warning.Show(Me, info)
            Exit Sub
        Else
            file = Trim(TextBox1.Text)
        End If

        Try
            SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Processing Backup . . .")
            'Me.Enabled = False
            '' MainMenu.Enabled = False
            backup_run()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            SplashScreenManager.CloseForm(False)
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, "Backup data selesai")
            alertControl_success.Show(Me, info)
            Me.Enabled = True
            MainMenu.Enabled = True
        End Try

        ' backup_run()


    End Sub

    Private Sub backup_run()
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
        myStreamWriter.WriteLine("mysqldump --opt --routines -u " & userdb_config & " --password=" & passdb_config & " -h " & server_config & " --port=" & port_config & " " & db_config & " > """ + file + """ ")
        myStreamWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub btnBackup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup2.Click
        open_conn()
        sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = sfd.FileName
        End If
    End Sub

    Private Sub backup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    
    
    Private Sub backup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
    End Sub
End Class