Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frmlog
    Dim insert As Integer
    Dim edit As Integer
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Dim pesan As String
    Public NoBuktiKoreksi As String

    Private Sub frmlog_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmadjuststock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmadjuststock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        view_data()
    End Sub


    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim i As Integer
            'On Error Resume Next

            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_log(DateTimePicker1.Value, DateTimePicker2.Value)

            Rows = DT.Rows.Count - 1
            open_conn()
            DataGridView1.Rows.Clear()
            If DT.Rows().Count > 0 Then
                For i = 0 To Rows
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
                    DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
                    DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
                    DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                    DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
                    DataGridView1.Item(5, i).Value = Format(DT.Rows(i).Item(5), "dd/MM/yyyy")
                    DataGridView1.Item(6, i).Value = DT.Rows(i).Item(6)
                Next
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    Private Sub btnProsess2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProsess2.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class