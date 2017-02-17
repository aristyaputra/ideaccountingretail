Imports System.Management
Imports System.Management.Instrumentation
Public Class DialogActivated
    Dim kode_cabang As String
    Dim Def_Kode As String
    Dim Kode1, Kode2, Kode3 As String

    Private Sub DialogActivated_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        End
    End Sub

    Private Sub DialogActivated_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim chr1, chr2, chr3, chr4 As String
        chr1 = UCase(Mid(GetDriveSerialNumber(""), 1, 2)) & UCase(Mid(CpuId, 7, 1)) & "I"
        chr2 = UCase(Mid(GetDriveSerialNumber(""), 3, 2)) & UCase(Mid(CpuId, 5, 1)) & "B"
        chr3 = UCase(Mid(GetDriveSerialNumber(""), 5, 2)) & UCase(Mid(CpuId, 3, 1)) & "A"
        chr4 = UCase(Mid(GetDriveSerialNumber(""), 7, 2)) & UCase(Mid(CpuId, 1, 1)) & "S"
        txt_serial1.Text = chr1
        txt_serial2.Text = chr2
        txt_serial3.Text = chr3
        txt_serial4.Text = chr4
        'My.Settings.SerialNumber = chr1 & chr2 & chr3 & chr4

        'Dim act1, act2, act3, act4 As String
        'act1 = EnkripsiID(LCase(chr1))
        'act2 = EnkripsiID(LCase(chr2))
        'act3 = EnkripsiID(LCase(chr3))
        'act4 = EnkripsiID(LCase(chr4))
        'txt_aktivasi1.Text = UCase(act1)
        'txt_aktivasi2.Text = UCase(act2)
        'txt_aktivasi3.Text = UCase(act3)
        'txt_aktivasi4.Text = UCase(act4)
        'My.Settings.ActivationCode = act1 & act2 & act3 & act4
        'My.Settings.Activated = True
        'My.Settings.Save()

        Dim DT As DataTable
        DT = select_company()
        If DT.Rows.Count > 0 Then
            txt_nama.Text = DT.Rows(0).Item("company_name")
            txt_kota.Text = DT.Rows(0).Item("city")
            txt_alamat.Text = DT.Rows(0).Item("address")
            txt_telepon.Text = DT.Rows(0).Item("phone")
            txt_email.Text = DT.Rows(0).Item("email")
            txt_website.Text = DT.Rows(0).Item("website")
            If DT.Rows(0).Item("flag_status") = 1 Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Else
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            End If
        End If
        cbo_cmp_type.Text = "PERUSAHAAN DAGANG"

        Exit Sub

    End Sub

    Private Sub btn_save_Click(sender As Object, e As System.EventArgs) Handles btn_save.Click
        open_conn()
        Dim var_status As Integer
        If RadioButton1.Checked = True Then
            var_status = 1
            kode_cabang = "HEAD"
        End If
        If RadioButton2.Checked = True Then
            var_status = 2
            kode_cabang = "BRANCH"
        End If
        If Trim(txt_aktivasi1.Text) <> UCase(EnkripsiID(LCase(txt_serial1.Text))) Then
            MsgBox("Activated Code doesn't match", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If
        If Trim(txt_aktivasi2.Text) <> UCase(EnkripsiID(LCase(txt_serial2.Text))) Then
            MsgBox("Activated Code doesn't match", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If
        If Trim(txt_aktivasi3.Text) <> UCase(EnkripsiID(LCase(txt_serial3.Text))) Then
            MsgBox("Activated Code doesn't match", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If
        If Trim(txt_aktivasi4.Text) <> UCase(EnkripsiID(LCase(txt_serial4.Text))) Then
            MsgBox("Activated Code doesn't match", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If

        If Trim(txt_nama.Text) = "" Then
            MsgBox("Please fill name", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If

        If Trim(txt_alamat.Text) = "" Then
            MsgBox("Please fill address", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If

        If Trim(txt_telepon.Text) = "" Then
            MsgBox("Please fill phone", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Please choose head/branch office", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If

        Dim var_type As Integer
        If Trim(cbo_cmp_type.Text) = "PERUSAHAAN JASA" Or Trim(cbo_cmp_type.Text) = "PERUSAHAAN DAGANG" Or Trim(cbo_cmp_type.Text) = "PERUSAHAAN MANUFAKTUR" Then
            If Trim(cbo_cmp_type.Text) = "PERUSAHAAN MANUFAKTUR" Then
                var_type = 2
            ElseIf Trim(cbo_cmp_type.Text) = "PERUSAHAAN JASA" Or Trim(cbo_cmp_type.Text) = "PERUSAHAAN DAGANG" Then
                var_type = 1
            End If
        Else
            MsgBox("Pilih Jenis Perusahaan", MsgBoxStyle.Critical, "Validation")
            Exit Sub
        End If


        Dim act1, act2, act3, act4 As String
        act1 = EnkripsiID(LCase(Trim(txt_serial1.Text)))
        act2 = EnkripsiID(LCase(Trim(txt_serial2.Text)))
        act3 = EnkripsiID(LCase(Trim(txt_serial3.Text)))
        act4 = EnkripsiID(LCase(Trim(txt_serial4.Text)))

        insert_company(kode_cabang + "-" + Trim(txt_kota.Text), txt_nama.Text, txt_alamat.Text, txt_kota.Text, txt_telepon.Text, txt_email.Text, txt_website.Text, var_status, var_type, Trim(txt_serial1.Text), Trim(txt_serial2.Text), Trim(txt_serial3.Text), Trim(txt_serial4.Text), getIPAddress())

        My.Settings.Activated = True
        My.Settings.SerialNumber = Trim(txt_serial1.Text) & Trim(txt_serial2.Text) & Trim(txt_serial3.Text) & Trim(txt_serial4.Text)
        My.Settings.ActivationCode = act1 & act2 & act3 & act4
        My.Settings.Save()
        'If param_sukses = True Then
        '    Me.Hide()
        '    MainMenu.Show()
        '    If get_period() = 0 Then
        '        ' MainMenu.Enabled = False
        '    Else
        '        MainMenu.Enabled = True
        '        MainMenu.Activate()
        '    End If
        'End If

    End Sub


    

    Private Sub default_code(ByVal criteria As String)
        Def_Kode = Nothing
        If RadioButton1.Checked = True Then
            kode_cabang = "HEAD"
        End If
        If RadioButton2.Checked = True Then
            kode_cabang = "BRANCH"
        End If
        If criteria.Length = 1 Then
            Kode1 = (Mid(criteria, 1, 1)).ToUpper
        ElseIf criteria.Length = 2 Then
            Kode2 = EnkripsiID(Mid(criteria, 2, 1))
        ElseIf criteria.Length = 5 Then
            Kode3 = EnkripsiID(Mid(criteria, 3, 1))
        End If
        If criteria.Length = 0 Then
            Def_Kode = ""
        Else
            Def_Kode = Trim(kode_cabang + Kode1 + Kode2 + Kode3)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Process.Start(Application.StartupPath & "\PointOfSales-Trial.exe")
        close_conn()
        End

        'Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("PointOfSales.exe")

        'For Each p As Process In pProcess
        '    p.Kill()
        'Next
    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As System.EventArgs) Handles txt_nama.TextChanged
        default_code(Trim(txt_nama.Text))
    End Sub


End Class