Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Module mdlnotif
    Public msgbox_save_success As String
    Public msgbox_update_success As String
    Public msgbox_delete_success As String
    Public msgbox_save_failed As String
    Public msgbox_update_failed As String
    Public msgbox_delete_failed As String
    Public msgtitle_save_success As String
    Public msgtitle_update_success As String
    Public msgtitle_delete_success As String
    Public msgtitle_save_failed As String
    Public msgtitle_update_failed As String
    Public msgtitle_delete_failed As String
    Public alertControl_success As AlertControl = New AlertControl
    Public alertControl_error As AlertControl = New AlertControl
    Public alertControl_warning As AlertControl = New AlertControl
    Public msgbox_confirm As DialogResult = New DialogResult
    Public txt_confirm_simpan, txt_confirm_hapus As String
    'Public confirm_style As UserLookAndFeel

    Public Sub notification()
        txt_confirm_simpan = "Simpan Data?"
        txt_confirm_hapus = "Hapus Data?"

        msgbox_save_success = "Data Berhasil di Simpan"
        msgbox_update_success = "Data Berhasil di Ubah"
        msgbox_delete_success = "Data Berhasil di Hapus"
        msgbox_save_failed = "Data Gagal di Simpan"
        msgbox_update_failed = "Data Gagal di Ubah"
        msgbox_delete_failed = "Data Gagal di Hapus"
        msgtitle_save_success = "Simpan Berhasil"
        msgtitle_update_success = "Ubah Berhasil"
        msgtitle_delete_success = "Hapus Berhasil"
        msgtitle_save_failed = "Simpan Gagal"
        msgtitle_update_failed = "Ubah Gagal"
        msgtitle_delete_failed = "Hapus Gagal"

        alertControl_success.FormShowingEffect = AlertFormShowingEffect.FadeIn
        alertControl_success.FormDisplaySpeed = AlertFormDisplaySpeed.Moderate
        alertControl_success.FormLocation = AlertFormLocation.TopRight
        alertControl_success.AutoHeight = True
        alertControl_success.AllowHtmlText = True
        alertControl_success.ShowPinButton = False
        alertControl_success.AppearanceText.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_success.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_success.AppearanceCaption.ForeColor = Color.LawnGreen
        alertControl_success.AppearanceText.ForeColor = Color.White
        alertControl_success.LookAndFeel.UseDefaultLookAndFeel = False
        alertControl_success.LookAndFeel.SkinName = "DevExpress Dark Style"
        alertControl_success.Images = Image.FromFile(Application.StartupPath & "\icon\img-notif-success.png")

        alertControl_warning.FormShowingEffect = AlertFormShowingEffect.FadeIn
        alertControl_warning.FormDisplaySpeed = AlertFormDisplaySpeed.Moderate
        alertControl_warning.FormLocation = AlertFormLocation.TopRight
        alertControl_warning.AutoHeight = True
        alertControl_warning.AllowHtmlText = True
        alertControl_warning.ShowPinButton = False
        alertControl_warning.AppearanceText.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_warning.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_warning.AppearanceCaption.ForeColor = Color.Gold
        alertControl_warning.AppearanceText.ForeColor = Color.White
        alertControl_warning.LookAndFeel.UseDefaultLookAndFeel = False
        alertControl_warning.LookAndFeel.SkinName = "DevExpress Dark Style"
        alertControl_warning.Images = Image.FromFile(Application.StartupPath & "\icon\img-notif-warning.png")

        alertControl_error.FormShowingEffect = AlertFormShowingEffect.FadeIn
        alertControl_error.FormDisplaySpeed = AlertFormDisplaySpeed.Moderate
        alertControl_error.FormLocation = AlertFormLocation.TopRight
        alertControl_error.AutoHeight = True
        alertControl_error.AllowHtmlText = True
        alertControl_error.ShowPinButton = False
        alertControl_error.AppearanceText.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_error.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alertControl_error.AppearanceCaption.ForeColor = Color.Salmon
        alertControl_error.AppearanceText.ForeColor = Color.White
        alertControl_error.LookAndFeel.UseDefaultLookAndFeel = False
        alertControl_error.LookAndFeel.SkinName = "DevExpress Dark Style"
        alertControl_warning.Images = Image.FromFile(Application.StartupPath & "\icon\img-notif-error.png")

        'confirm_style.UseDefaultLookAndFeel = False
        'confirm_style.SkinName = "DevExpress Dark Style"

    End Sub

End Module
