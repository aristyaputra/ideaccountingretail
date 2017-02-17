Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSimpanPinjam_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

   
    Public Function tgl_pinjam(ByVal var_criteria As String) As Date
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select date_trn from trn_pinjam where no_pinjam = '" & var_criteria & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return Now
        End Try
    End Function

    Public Function tgl_akhir_bayar(ByVal var_criteria As String) As Date
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select date_trn from trn_pinjam_bayar where no_pinjam = '" & var_criteria & "' order by date_trn desc"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return Now
        End Try
    End Function

    Public Function jml_terbayar_koperasi(ByVal var_criteria As String) As Double
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select count(no_bayar) from trn_pinjam_bayar where no_pinjam = '" & var_criteria & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return DT.Rows(0).Item(0)
        End Try
    End Function

    Public Function select_pinjam_bayar(ByVal var_criteria As String, ByVal detail As Integer) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_pinjam_bayar('" & var_criteria & "'," & detail & ")"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            MsgBox(ex.Message)
            Return DT
        End Try
    End Function

    Public Function select_pinjam(ByVal var_criteria As String, ByVal detail As Integer) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_pinjam('" & var_criteria & "'," & detail & ")"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            MsgBox(ex.Message)
            Return DT
        End Try
    End Function

    Public Function select_kode_bayar() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from kode_nominal"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Return DT
        End Try

    End Function


    Public Function select_akan_bayar(ByVal var_criteria As String) As Integer
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select get_jml_tunggak ('" & var_criteria & "')"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function


    Public Function get_saldo_pinjam(ByVal var_criteria As String) As Double
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select func_saldo_pinjaman('" & var_criteria & "')"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return DT.Rows(0).Item(0)
        End Try
    End Function




End Module
