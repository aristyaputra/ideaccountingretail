Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO
Imports DevExpress.XtraBars.Alerter

Public Class autoBackup
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

        If Trim(cbo_type.Text) = "Mingguan" And Trim(cbo_days.Text = "") Then
            Dim info As AlertInfo = New AlertInfo("Backup Option", "Pilih Hari Backup")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Try
            SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            'Me.Enabled = False
            '' MainMenu.Enabled = False
            backup_run()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            SplashScreenManager.CloseForm(False)
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
            Me.Enabled = True
            MainMenu.Enabled = True
        End Try

        ' backup_run()


    End Sub

    Private Sub backup_run()
        Try
            delete_set_autobackup()
            insert_set_autobackup(Trim(cbo_type.Text), Replace(Trim(TextBox1.Text), "\", "/"), Format(cbo_time.Value, "hh:mm:ss"), cbo_days.Text, Format(cbo_tanggal.Value, "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"))
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
            alertControl_success.Show(Me, info)
        End Try

        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub btnBackup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup2.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Auto Backup Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub backup_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub



    Private Sub backup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
    End Sub

    Private Sub cbo_type_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_type.SelectedIndexChanged
        If cbo_type.SelectedItem = "Harian" Then
            Label5.Visible = False
            cbo_tanggal.Visible = False
            Label3.Visible = False
            cbo_days.Visible = False
        ElseIf cbo_type.SelectedItem = "Mingguan" Then
            Label5.Visible = False
            cbo_tanggal.Visible = False
            Label3.Visible = True
            cbo_days.Visible = True
        ElseIf cbo_type.SelectedItem = "Bulanan" Then
            Label5.Visible = True
            cbo_tanggal.Visible = True
            Label3.Visible = False
            cbo_days.Visible = False
        End If
    End Sub
End Class