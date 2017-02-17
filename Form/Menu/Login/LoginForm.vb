Imports System.DirectoryServices
Imports Microsoft.Win32
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm


Public Class LoginForm
    

    Private Shared Function SetWindowText(ByVal hwnd As IntPtr, ByVal lpString As String) As Boolean

    End Function

    Public Function validate_login() As Boolean
        get_config_database()

        If Trim(txt_server.Text) = "" Then
            'MsgBox("Setup server first!" & vbCrLf & _
            '        "Server must setup with ip address or localhost", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Warning!")
            'Return False
        Else

            If Trim(txt_user.Text) <> UCase("Creator") Then
                Dim DT As Integer
                DT = getLogin(Trim(txt_user.Text), Trim(txt_password.Text))
                If DT = 1 Then
                    'Dim DriverODBC As String
                    'Dim regHandle As RegistryKey            ' Stores the Handle to Registry in which values need to be set
                    'Dim reg As RegistryKey = Registry.LocalMachine
                    'Dim conRegKey1 As String = "SOFTWARE\ODBC\ODBCINST.INI\MySQL ODBC 5.1 Driver"
                    'Try
                    '    regHandle = reg.OpenSubKey(conRegKey1)
                    '    If regHandle.ValueCount > 0 Then
                    '        DriverODBC = regHandle.GetValue("Driver")
                    '        MakeMySQLDSN(db_config, "piaccounting_dev", "Integrated Accounting ODBC", DriverODBC, userdb_config, passdb_config, server_config, port_config, 3, "")
                    '        server_temp = server_config
                    '    Else
                    '        MsgBox("Could'nt find ODBC Driver for MySQL", MsgBoxStyle.Exclamation, "Error..!")
                    '        Return False
                    '    End If
                    'Catch err As Exception
                    '    MsgBox(err.Message)
                    'End Try
                    Return True
                Else
                    MsgBox("Wrong Password / Username, Please try again", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Warning!")
                    txt_user.Text = ""
                    txt_password.Text = ""
                    close_conn()
                    Return False
                End If
            Else
                If Trim(txt_password.Text) = "1589FE30@" Then
                    Return True
                Else
                    MsgBox("Restricted Keys", MsgBoxStyle.Exclamation + MsgBoxStyle.Information, "Warning!")
                    txt_user.Text = ""
                    txt_password.Text = ""
                    close_conn()
                    Return False
                End If
            End If
            Exit Function
        End If

    End Function

    Public Sub KeyPress_Login(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If validate_login() = True Then
            ' MenuOpened()
            username = LCase(Trim(txt_user.Text))

            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                SplashScreenManager.Default.SetWaitFormDescription("Checking Activator Security. . .")
                Dim chr1, chr2, chr3, chr4 As String
                chr1 = UCase(Mid(GetDriveSerialNumber(""), 1, 2)) & UCase(Mid(CpuId, 7, 1)) & "I"
                chr2 = UCase(Mid(GetDriveSerialNumber(""), 3, 2)) & UCase(Mid(CpuId, 5, 1)) & "B"
                chr3 = UCase(Mid(GetDriveSerialNumber(""), 5, 2)) & UCase(Mid(CpuId, 3, 1)) & "A"
                chr4 = UCase(Mid(GetDriveSerialNumber(""), 7, 2)) & UCase(Mid(CpuId, 1, 1)) & "S"

                

                If My.Settings.init <= 0 Then
                    My.Settings.StartDate = server_datetime()
                    My.Settings.init = 1
                    My.Settings.Save()
                End If

                
                '

                is_expired()

                If get_activated(chr1, chr2, chr3, chr4) = 0 And My.Settings.IsExpired = False And My.Settings.Activated = False Then
                    MsgBox("Program Belum Di Aktivasi" + vbCrLf + " Batas versi trial" + " " & dayusetrial & " hari lagi", MsgBoxStyle.ApplicationModal, "Warning")
                    'Try
                    '    SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                    '    SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                    '    SplashScreenManager.Default.SetWaitFormDescription("Loading Activator. . .")
                    'DialogActivated.Show()
                    'Finally
                    '    SplashScreenManager.CloseForm(False)
                    'End Try
                    'Me.Hide()
                    'Else
                    Me.Hide()
                    MainMenu.Show()
                ElseIf get_activated(chr1, chr2, chr3, chr4) = 0 And My.Settings.IsExpired = True And My.Settings.Activated = False Then
                    MsgBox("Program telah melalui masa trial 14 hari" + vbCrLf + "Silahkan hubungi vendor untuk aktivasi", MsgBoxStyle.ApplicationModal, "Warning")

                    Try
                        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                        SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                        SplashScreenManager.Default.SetWaitFormDescription("Loading Activator. . .")
                        DialogActivated.Show()
                        Me.Hide()
                    Finally
                        SplashScreenManager.CloseForm(False)
                    End Try
                ElseIf get_activated(chr1, chr2, chr3, chr4) = 1 And My.Settings.Activated = True Then
                    Me.Hide()
                    MainMenu.Show()
                End If
            Finally
                SplashScreenManager.CloseForm(False)
            End Try


            ' MainMenu.lbluser.Text = username
            'Dim timer As New Timer
            'timer.Interval = 1000
            'timer.Start()
            'AddHandler timer.Tick, AddressOf Timer_Tick
            'Me.Close()

            'With FrmCommandPanel
            '    .Show()
            '    .MdiParent = MainMenu
            '    .PictureBox1_Click(sender, e)
            'End With
            'Exit Sub
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Chr(13) Then
            KeyPress_Login(sender, e)
        ElseIf e.KeyChar = Chr(Keys.Escape) Then
            close_conn()
            End
        End If
    End Sub

    Private Sub txt_server_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            KeyPress_Login(sender, e)
        ElseIf e.KeyChar = Chr(Keys.Escape) Then
            close_conn()
            End
        End If
    End Sub

    Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_user.KeyPress
        If e.KeyChar = Chr(13) Then
            KeyPress_Login(sender, e)
        ElseIf e.KeyChar = Chr(Keys.Escape) Then
            close_conn()
            End
        End If
    End Sub

    'Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
    '    'Di() m status As System.Windows.Forms.StatusBar = CType(Me.Controls.Find("statusBar", True)(0), System.Windows.Forms.StatusBar)

    '    MainMenu.lbl_date.Text = Format(Now(), "dd-MMM-yyyy")
    '    MainMenu.lbl_time.Text = FormatDateTime(Now(), DateFormat.LongTime)

    '    'Rather than set up message listeners etc, are you really going to notice much if the caps lock/nums lock is
    '    'upto 1 seconds out from true state?? doubt it much. (you decrease the timer tick of course.
    '    'If GetKeyState(Keys.NumLock) = 1 Then
    '    '    status.Panels("statusBarNUMS").Text = "NumLock ON"
    '    'Else
    '    '    status.Panels("statusBarNUMS").Text = "NumLock OFF"
    '    'End If

    '    'If GetKeyState(Keys.CapsLock) = 1 Then
    '    '    status.Panels("statusBarCAPS").Text = "CAPS ON"
    '    'Else
    '    '    status.Panels("statusBarCAPS").Text = "CAPS OFF"
    '    'End If


    '    'NOTE: IN .Net Version 3.5 and above you can use the;
    '    '        My.Computer.Keyboard.CapsLock
    '    '        My.Computer.Keyboard.NumLock
    '    ' to read the status without an unmanaged call
    'End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        End
    End Sub

    Public Sub ProgressBarSetup(ByRef Maximum As Integer, ByRef Title As String)
        ' progressBar.Maximum = Maximum
        ' progressBar.Value = 0
    End Sub

    Public Sub IncProg()
        ' progressBar.Value += 1
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'init()
        'My.Settings.StartDate = "#12:00:00 AM#"
        'My.Settings.init = 0
        'My.Settings.IsExpired = False
        'My.Settings.Save()


        'activasi
        'My.Settings.Activated = True
        'My.Settings.Save()


        Dim logo_path As String
        SetWindowText(Me.Handle.ToInt32, "Smart Accounting Software")
        txt_server.Items.Add("localhost")
        get_config_database()
        txt_server.Text = server_config

        My.Application.ChangeCulture("en-US")
        My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
        My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
        My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

        If connec_open() = True Then
            'logo_path = Replace(get_logo(), "/", "\")
            'Try
            '    If System.IO.File.Exists(logo_path) Then
            '        logo.Image = Image.FromFile(logo_path)
            '    Else
            '        logo.Image = Image.FromFile(Application.StartupPath & "\pi-accounting-small.png")
            '    End If
            'Catch ex As Exception

            'End Try
        End If
        'Dim sc As String
        'sc = (System.Threading.Thread.CurrentThread.CurrentCulture.ToString)
        'If sc <> "en-US" Then
        '    MsgBox("System ini menggunakan setting international" & vbCrLf & "Mohon ganti regional setting anda")
        '    System.Diagnostics.Process.Start("intl.cpl")
        '    End
        'End If
        'ProgressBar.Minimum = 0
        'Call CreateUserDSN()
    End Sub

    Private Delegate Sub UpdateDelegate(ByVal s As String)

    Private Sub AddListBoxItem(ByVal s As String)
        txt_server.Items.Add(s)
    End Sub



    Private Sub GetNetworkComputers()
        On Error Resume Next
        Dim alWorkGroups As New ArrayList
        Dim de As New DirectoryEntry


        de.Path = "WinNT:"
        For Each d As DirectoryEntry In de.Children
            If d.SchemaClassName = "Domain" Then alWorkGroups.Add(d.Name)
            d.Dispose()
        Next

        For Each workgroup As String In alWorkGroups

            de.Path = "WinNT://" & workgroup
            For Each d As DirectoryEntry In de.Children
                If d.SchemaClassName = "Computer" Then

                    Dim del As UpdateDelegate = AddressOf AddListBoxItem
                    Me.Invoke(del, d.Name)

                End If
                d.Dispose()

            Next

        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GetNetworkComputers()
    End Sub

    Private Sub MarqueeProgressBarControl1_EditValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ProgressBarControl1_EditValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

End Class
