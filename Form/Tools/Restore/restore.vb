Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class restore
    Dim sfd As New OpenFileDialog
    Dim sender As Object
    Dim e As System.EventArgs
    Dim file As String

    Private Sub restore_run()

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
        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        '  db_config = "piaccounting_test"
        If CheckBox1.Checked = True Then
            myStreamWriter.WriteLine("mysql --host=" & server_config & " -u" & userdb_config & " -p" & passdb_config & " --port=" & port_config & " -f " & Trim(TextBox2.Text) & " < """ + file + """ ")
        Else
            myStreamWriter.WriteLine("mysql --host=" & server_config & " -u" & userdb_config & " -p" & passdb_config & " --port=" & port_config & " -f " & db_config & " < """ + file + """ ")
        End If

        myStreamWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub btnProsess2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProsess2.Click
        open_conn()

        If Trim(TextBox1.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Restore Option", "Pilih direktory data backup")
            alertControl_warning.Show(Me, info)
            Exit Sub
        Else
            file = Trim(TextBox1.Text)
        End If
        Try
            SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Processing Restore Database . . .")
            'Me.Enabled = False
            '' MainMenu.Enabled = False
            restore_run()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            'restore_run()
            SplashScreenManager.CloseForm(False)
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, "Restore data selesai")
            alertControl_success.Show(Me, info)
            Me.Enabled = True
            MainMenu.Enabled = True
        End Try
    End Sub

    Private Sub btnBackup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup2.Click
        open_conn()
        sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = sfd.FileName
        End If
    End Sub

    Private Sub restore_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub restore_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
    End Sub
End Class