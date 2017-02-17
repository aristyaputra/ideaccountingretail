Imports DevExpress.XtraBars.Alerter
Public Class frmchangephoto

    Dim file_photo As String
    Dim def_path As String
    Dim current_photo As String
    Dim id_employee As String

    Private Sub frmchangephoto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Image = MainMenu.PictureBox2.Image
        If get_def_path("Employee") = "" Then
            def_path = "C:" & "\" & username & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            def_path = Replace(get_def_path("Employee"), "/", "\") & "\" & username & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
        Dim DT As New DataTable
        DT = select_path_userimg(username)
        id_employee = DT.Rows(0).Item("id_employee")
        current_photo = DT.Rows(0).Item("photo")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        open_conn()
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_photo = pb.FileName
            PictureBox2.Image = Image.FromFile(file_photo)
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan.Click
        Try
            If file_photo = "" Then
                file_photo = current_photo
            End If
            Call update_userphoto(id_employee, def_path)
            System.IO.File.Copy(file_photo, def_path)
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error. .", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
            MainMenu.PictureBox2.Image = PictureBox2.Image
            Me.Close()
        End Try
    End Sub
End Class