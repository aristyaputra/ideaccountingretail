Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports System.Net.Mail

Public Class SendEmail

    Dim mail As New MailMessage
    Dim smtp As New SmtpClient("smtp.gmail.com")


    Private Sub kirim_email()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Sending Email . . .")
            mail.Subject = txt_subject.Text
            ' For i As Integer = 0 To list_penerima.Items.Count - 1
            mail.To.Add("indonesia.erp.software@gmail.com")
            ' Next
            mail.From = New MailAddress("indonesia.erp.software@gmail.com")
            mail.Body = txt_email.Text & vbCrLf & authorized_sign()
            For i As Integer = 0 To list_attachment.Items.Count - 1
                Dim attachment As New Attachment(list_attachment.Items(i))
                mail.Attachments.Add(attachment)
            Next

            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("indonesia.erp.software", "apaya?lupa")
            smtp.Port = "587"
            smtp.Send(mail)
            Dim info2 As AlertInfo = New AlertInfo("Email Terkirim", "Email Terkirim")
            alertControl_success.Show(Me, info2)
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error Send Email", ex.Message)
            alertControl_error.Show(Me, info)
            Exit Sub
        Finally
            SplashScreenManager.CloseForm(False)
        End Try


    End Sub

    Private Function authorized_sign() As String
        Return "" & vbCrLf & vbCrLf & "Piaccounting Software" & vbCrLf & "Send Email Feature" & vbCrLf & "www.software-akutansi.com"
    End Function

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click
        kirim_email()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        list_penerima.Items.Add(Trim(txt_penerima.Text))
    End Sub

    Private Sub btn_browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            list_attachment.Items.Add(pb.FileName)
        End If
    End Sub

    Private Sub LabelControl4_Click(sender As System.Object, e As System.EventArgs) Handles LabelControl4.Click

    End Sub

    Private Sub SendEmail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NavBarControl1_Click(sender As System.Object, e As System.EventArgs) Handles NavBarControl1.Click

    End Sub

    Private Sub NavBarControl1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarControl1.LinkClicked
        If e.Link.Item.Name = "navSendEmail" Then

        End If
    End Sub
End Class