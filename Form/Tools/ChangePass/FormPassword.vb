Public Class FormPassword

    Private Sub FormPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Text = Trim(username)

    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If EnkripsiID(txtpassword.Text) <> getOldPassword(username) Then
            MsgBox("Wrong Old Password!", MsgBoxStyle.Information, "Warning")
            Exit Sub
        Else
            Call update_password(Trim(txtuser.Text), EnkripsiID(Trim(txtnew.Text)))
            If param_sukses = True Then
                MsgBox("Data Saved, You Must Restart Program", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Successfully")
                close_conn()
                End
            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class