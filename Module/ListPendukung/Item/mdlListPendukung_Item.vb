Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlListPendukung_Item
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_material(ByVal field As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        If field = "ID" Then
            field = "id_item"
        ElseIf field = "Name" Then
            field = "item_name"
        End If

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_list_material where " & field & " like '%" & criteria & "%'"
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

    Public Function select_category(ByVal field As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        If field = "Category ID" Then
            field = "mst_itemcat_id"
        ElseIf field = "Category Name" Then
            field = "mst_itemcat_nm"
        End If
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from mst_itemcat where " & field & " like '%" & criteria & "%'"
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

    Public Function select_brand(ByVal field As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        If field = "ID Brand" Then
            field = "id_brand"
        ElseIf field = "Brand Name" Then
            field = "name_brand"
        End If
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from mst_brand where " & field & " like '%" & criteria & "%'"
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

    Public Function select_unit_sales(ByVal field As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        If field = "Unit ID" Then
            field = "id_unit"
        ElseIf field = "Unit" Then
            field = "unit"
        End If
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from mst_unit where " & field & " like '%" & criteria & "%'"
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

    Public Function get_disc_brand(ByVal var_criteria As String) As Double
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select case when disc is null then 0 else disc end as disc from mst_itembrand where mst_itembrand_id = '" & var_criteria & "'"
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


    Public Function get_item_brand(ByVal var_criteria As String) As String
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select id_brand from mst_item where id_item = '" & var_criteria & "'"
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

    Public Function get_disc_type(ByVal var_criteria As String) As Double
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select case when discount is null then 0 else discount end as disc from mst_itemjenis where mst_itemjenis_id = '" & var_criteria & "'"
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


    Public Function get_disc_cat(ByVal var_criteria As String) As Double
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select case when discount is null then 0 else discount end as disc from mst_itemcat where mst_itemcat_id = '" & var_criteria & "'"
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

    Public Function get_disc_otheritem(ByVal var_criteria As String) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_item_disc where id_item = '" & var_criteria & "'"
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

End Module
