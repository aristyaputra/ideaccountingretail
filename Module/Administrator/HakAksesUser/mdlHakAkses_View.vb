Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlHakAkses_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_user() As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_user"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT

        End Try

    End Function


    Public Function get_user_position(ByVal userkey As String) As String
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select position from view_user where username = '" & userkey & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)

        End Try

    End Function

    Public Function get_hak_akses(ByVal user As String, ByVal key As String) As Boolean
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select username from i_hakakses where username = '" & user & "' and childkey = '" & key & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            If DT.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return False

        End Try
    End Function

    Public Function getTemplateAkses(ByVal user As String, ByVal childkey As String) As Boolean
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "SELECT childkey FROM i_hakakses WHERE lcase(username) = '" & LCase(user) & "' AND childkey ='" & childkey & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            If DT.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return False
        End Try

    End Function

    Public Function getChildKey(ByVal parentkey As String) As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "Select childkey,notes from i_templatehakakses where parentkey = '" & parentkey & "' order by nourut"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Function cek_templateakses(ByVal var_parentkey As String, ByVal var_childkey As String) As Integer
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select count(childkey) from i_templatehakakses where parentkey = '" & var_parentkey & "' and childkey = '" & var_childkey & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return 0
        End Try

    End Function



    Public Function getTreeMenu() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "Select childkey,parentkey,notes from i_templatehakakses order by nourut"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function


    Public Function getTemplateHakAksesDef() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "Select childkey,parentkey,notes from i_templatehakakses_def order by nourut"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Function getTemplateHakAksesDef_Parent() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "Select childkey, notes from i_templatehakakses_def where ismenu <> 2  order by nourut"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Function get_position_employee(ByVal employee_id As String) As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select b.position_name from mst_employee a inner join mst_position b on b.position_id = a.position_id where a.id_employee = '" & employee_id & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function


    Public Function get_depart_employee(ByVal employee_id As String) As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select b.department_name from mst_employee a inner join mst_department b on b.department_id = a.department_id where a.id_employee = '" & employee_id & "'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

End Module
