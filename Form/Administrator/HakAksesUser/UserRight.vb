Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class UserRight
    Dim mRow As Integer
    Dim mRowBefore As Integer

    Private Sub UserRight_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub UserRight_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub UserRight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        view_data()
        view_privilege()
        panel.Visible = False
        LoadComboBox_Employee()
        With DataGridView1
            .ReadOnly = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = False
        End With
    End Sub

    Private Sub view_data()
        open_conn()
        On Error Resume Next

        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_date_filter As Integer

        DT = select_user()
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("username")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("nama")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("position")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("departement")
            Next
        End If
    End Sub

    Private Sub view_privilege_user()
        open_conn()
        On Error Resume Next
        Dim ambilUser As String
        Dim a As Integer
        ambilUser = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value

        If ambilUser <> "" Then
            For Each childkey1 As TreeNode In TreeUser.Nodes
                If getChildKey_FromUser(ambilUser, childkey1.Name) > 0 Then
                    TreeUser.Nodes.Item(TreeUser.Nodes.IndexOfKey(childkey1.Name)).Checked = True
                End If
                For Each childkey2 As TreeNode In childkey1.Nodes
                    If getChildKey_FromUser(ambilUser, childkey2.Name) > 0 Then
                        childkey1.Nodes.Item(childkey1.Nodes.IndexOfKey(childkey2.Name)).Checked = True
                    Else
                        childkey1.Nodes.Item(childkey1.Nodes.IndexOfKey(childkey2.Name)).Checked = False
                    End If
                    For Each childkey3 As TreeNode In childkey2.Nodes
                        If getChildKey_FromUser(ambilUser, childkey3.Name) > 0 Then
                            childkey2.Nodes.Item(childkey2.Nodes.IndexOfKey(childkey3.Name)).Checked = True
                        Else
                            childkey2.Nodes.Item(childkey2.Nodes.IndexOfKey(childkey3.Name)).Checked = False
                        End If
                        For Each childkey4 As TreeNode In childkey3.Nodes
                            If getChildKey_FromUser(ambilUser, childkey4.Name) > 0 Then
                                childkey3.Nodes.Item(childkey3.Nodes.IndexOfKey(childkey4.Name)).Checked = True
                            Else
                                childkey3.Nodes.Item(childkey3.Nodes.IndexOfKey(childkey4.Name)).Checked = False
                            End If
                        Next
                    Next
                Next
            Next
        End If

    End Sub

    Private Sub view_privilege()
        open_conn()
        Dim DT, DTChild, DTChild2, DTChild3 As DataTable
        Dim a, b, c, d As Integer
        Dim RootNode, ChildNode, ChildNode2, ChildNode3 As TreeNode
        DT = getParentKey()
        TreeUser.CheckBoxes = True
        With TreeUser
            a = 0
            Do While a <= DT.Rows.Count - 1
                RootNode = .Nodes.Add(DT.Rows(a).Item("childkey"), DT.Rows(a).Item("notes"))
                DTChild = getChildKey(DT.Rows(a).Item("childkey"))
                If DTChild.Rows.Count > 0 Then
                    b = 0
                    Do While b <= DTChild.Rows.Count - 1
                        ChildNode = RootNode.Nodes.Add(DTChild.Rows(b).Item("childkey"), DTChild.Rows(b).Item("notes"))
                        DTChild2 = getChildKey(DTChild.Rows(b).Item("childkey"))
                        If DTChild2.Rows.Count > 0 Then
                            c = 0
                            Do While c <= DTChild2.Rows.Count - 1
                                ChildNode2 = ChildNode.Nodes.Add(DTChild2.Rows(c).Item("childkey"), DTChild2.Rows(c).Item("notes"))
                                DTChild3 = getChildKey(DTChild2.Rows(c).Item("childkey"))
                                If DTChild3.Rows.Count > 0 Then
                                    d = 0
                                    'Do While d <= DTChild3.Rows.Count - 1
                                    '    ChildNode3 = ChildNode2.Nodes.Add(DTChild3.Rows(d).Item("childkey"), DTChild3.Rows(d).Item("notes"))
                                    '    d = d + 1
                                    'Loop
                                End If
                                c = c + 1
                            Loop
                        End If
                        b = b + 1
                    Loop
                End If
                a = a + 1
            Loop
        End With
    End Sub


    Private Sub TreeUser_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeUser.AfterCheck
        open_conn()
        'RemoveHandler TreeUser.AfterCheck, AddressOf TreeUser_AfterCheck
        'For Each node As TreeNode In e.Node.Nodes
        '    If node.Checked = False Then
        '        node.Checked = e.Node.Checked
        '    End If
        'Next
        If e.Node.Parent Is Nothing = False Then
            Dim allChecked As Integer = 0

            For Each node As TreeNode In e.Node.Parent.Nodes
                If node.Checked = True Then
                    allChecked = allChecked + 1
                End If
            Next

            If allChecked = 0 Then
                e.Node.Parent.Checked = False
            Else
                e.Node.Parent.Checked = True
            End If
        End If

        'AddHandler TreeUser.AfterCheck, AddressOf TreeUser_AfterCheck
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        panel.Visible = True
    End Sub

    Private Sub simplebutton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        open_conn()
        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1

        For a = 0 To row
            If DataGridView1.Item(4, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Pilih Username")
            alertControl_warning.Show(Me, info)
            Exit Sub
        ElseIf a > 0 Then
            insert_hakakses()
        End If
    End Sub

    Private Sub LoadComboBox_Employee()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_employee()

        cbo_noakun.SelectedIndex = -1
        cbo_noakun.Items.Clear()
        cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_noakun.SourceDataString = New String(1) {"id_employee", "employee_nm"}
        cbo_noakun.SourceDataTable = dtLoading
        cbo_noakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    End Sub

    Private Sub cbo_noakun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_noakun.SelectedIndexChanged
        open_conn()
        txtposition.Text = get_position_employee(cbo_noakun.Text)
        txtdepartment.Text = get_depart_employee(cbo_noakun.Text)

    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        open_conn()
        panel.Visible = False
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If Trim(txtpassword.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan memasukkan password")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txtuser.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan memasukkan username")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading . . .")
            insert_data()
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub insert_data()
        open_conn()
        ' Call notification()
        Call insert_user(Trim(txtuser.Text), Trim(txtpassword.Text), Trim(cbo_noakun.Text), username, server_datetime(), username, server_datetime(), 1)
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
            panel.Visible = False
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub insert_hakakses()
        open_conn()
        Dim parentkey As String
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading . . .")
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(4, i).Value = True Then
                    Call delete_akses(DataGridView1.Item(0, i).Value)
                    For Each childkey1 As TreeNode In TreeUser.Nodes
                        parentkey = getParentKey_FromCK(childkey1.Name)
                        If TreeUser.Nodes.Item(TreeUser.Nodes.IndexOfKey(childkey1.Name)).Checked = True Then
                            Call insert_akses(DataGridView1.Item(0, i).Value, parentkey, childkey1.Name)
                        End If
                        For Each childkey2 As TreeNode In childkey1.Nodes
                            parentkey = getParentKey_FromCK(childkey2.Name)
                            If childkey1.Nodes.Item(childkey1.Nodes.IndexOfKey(childkey2.Name)).Checked = True Then
                                Call insert_akses(DataGridView1.Item(0, i).Value, parentkey, childkey2.Name)
                            End If
                            For Each childkey3 As TreeNode In childkey2.Nodes
                                parentkey = getParentKey_FromCK(childkey3.Name)
                                If childkey2.Nodes.Item(childkey2.Nodes.IndexOfKey(childkey3.Name)).Checked = True Then
                                    Call insert_akses(DataGridView1.Item(0, i).Value, parentkey, childkey3.Name)
                                End If
                                'For Each childkey4 As TreeNode In childkey3.Nodes
                                '    parentkey = getParentKey_FromCK(childkey4.Name)
                                '    If childkey3.Nodes.Item(childkey3.Nodes.IndexOfKey(childkey4.Name)).Checked = True Then
                                '        Call insert_akses(DataGridView1.Item(0, i).Value, parentkey, childkey4.Name)
                                '    End If
                                'Next
                            Next
                        Next
                    Next
                End If
            Next
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            For i = 0 To DataGridView1.Rows.Count - 1
                If i <> mRow Then
                    DataGridView1.Item(4, i).Value = False
                End If
            Next
            For Each childkey1 As TreeNode In TreeUser.Nodes
                TreeUser.Nodes.Item(TreeUser.Nodes.IndexOfKey(childkey1.Name)).Checked = False
                For Each childkey2 As TreeNode In childkey1.Nodes
                    childkey1.Nodes.Item(childkey1.Nodes.IndexOfKey(childkey2.Name)).Checked = False
                    For Each childkey3 As TreeNode In childkey2.Nodes
                        childkey2.Nodes.Item(childkey2.Nodes.IndexOfKey(childkey3.Name)).Checked = False
                        For Each childkey4 As TreeNode In childkey3.Nodes
                            childkey3.Nodes.Item(childkey3.Nodes.IndexOfKey(childkey4.Name)).Checked = False
                        Next
                    Next
                Next
            Next
            view_privilege_user()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub UserRight_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'open_conn()
        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column
        '    .Columns(1).Width = .Columns(1).Width + selisih_col
        'End With

    End Sub

    Private Sub GroupControl1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles panel.Paint

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class