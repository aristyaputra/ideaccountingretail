Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports System.Net.Mail

Module mdlEmail

    Dim mail As New MailMessage
    Dim smtp As New SmtpClient("smtp.gmail.com")


    Public Function kirim_email(ByVal mailSubject As String, ByVal mailReceiver As String, ByVal mailTo As String, ByVal mailBody As String) As Boolean
        Try
            mail.Subject = mailSubject
            ' For i As Integer = 0 To list_penerima.Items.Count - 1
            mail.To.Add(mailTo)
            ' Next
            mail.From = New MailAddress(mailReceiver)
            mail.Body = mailBody & vbCrLf & authorized_sign()
            'For i As Integer = 0 To list_attachment.Items.Count - 1
            '    Dim attachment As New Attachment(list_attachment.Items(i))
            '    mail.Attachments.Add(attachment)
            'Next

            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("indonesia.erp.software", "apaya?lupa")
            smtp.Port = "587"
            smtp.Send(mail)
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    Private Function authorized_sign() As String
        Return "" & vbCrLf & vbCrLf & "Piaccounting Software" & vbCrLf & "Send Email Feature" & vbCrLf & "www.software-akutansi.com"
    End Function

   

End Module