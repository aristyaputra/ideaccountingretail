Imports DevExpress.XtraBars.Alerter
Imports System
Imports System.IO
Imports System.Management

Public Class frm_path_setup


    Private Sub Button_Customer_Click(sender As System.Object, e As System.EventArgs) Handles Button_Customer.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_customer.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub Button_Supplier_Click(sender As System.Object, e As System.EventArgs) Handles Button_Supplier.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_supplier.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub Button_Employee_Click(sender As System.Object, e As System.EventArgs) Handles Button_Employee.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_employee.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub Button_Item_Click(sender As System.Object, e As System.EventArgs) Handles Button_Item.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_item.Text = dialog.SelectedPath
        End If
    End Sub


    Private Sub btnProsess2_Click(sender As System.Object, e As System.EventArgs) Handles btnProsess2.Click
        'Directory.CreateDirectory(Trim(txt_save_customer.Text))
        Dim managementClass As New ManagementClass("Win32_Share")
        Dim inParamsCustomer As ManagementBaseObject = managementClass.GetMethodParameters("Create")
        inParamsCustomer.Item("Description") = "Pi-Accounting Customer Photo Folder Share"
        inParamsCustomer.Item("Name") = "CustomerPhoto"
        inParamsCustomer.Item("Path") = Trim(txt_save_customer.Text)
        inParamsCustomer.Item("Type") = 0
        'If (DirectCast(managementClass.InvokeMethod("Create", inParamsCustomer, Nothing).Properties.Item("ReturnValue").Value, UInt32) <> 0) Then
        '    Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
        '    alertControl_error.Show(Me, info)
        'End If

        Dim inParamsSupplier As ManagementBaseObject = managementClass.GetMethodParameters("Create")
        inParamsSupplier.Item("Description") = "Pi-Accounting Supplier Photo Folder Share"
        inParamsSupplier.Item("Name") = "SupplierPhoto"
        inParamsSupplier.Item("Path") = Trim(txt_save_supplier.Text)
        inParamsSupplier.Item("Type") = 0
        'If (DirectCast(managementClass.InvokeMethod("Create", inParamsSupplier, Nothing).Properties.Item("ReturnValue").Value, UInt32) <> 0) Then
        '    Throw New Exception("Unable to share directory.")
        'End If

        Dim inParamsEmployee As ManagementBaseObject = managementClass.GetMethodParameters("Create")
        inParamsEmployee.Item("Description") = "Pi-Accounting Employee Photo Folder Share"
        inParamsEmployee.Item("Name") = "EmployeePhoto"
        inParamsEmployee.Item("Path") = Trim(txt_save_employee.Text)
        inParamsEmployee.Item("Type") = 0
        'If (DirectCast(managementClass.InvokeMethod("Create", inParamsEmployee, Nothing).Properties.Item("ReturnValue").Value, UInt32) <> 0) Then
        '    Throw New Exception("Unable to share directory.")
        'End If

        Dim inParamsItem As ManagementBaseObject = managementClass.GetMethodParameters("Create")
        inParamsItem.Item("Description") = "Pi-Accounting Item Photo Folder Share"
        inParamsItem.Item("Name") = "ItemPhoto"
        inParamsItem.Item("Path") = Trim(txt_save_item.Text)
        inParamsItem.Item("Type") = 0
        'If (DirectCast(managementClass.InvokeMethod("Create", inParamsItem, Nothing).Properties.Item("ReturnValue").Value, UInt32) <> 0) Then
        '    Throw New Exception("Unable to share directory.")
        'End If

        Dim inParamsLogo As ManagementBaseObject = managementClass.GetMethodParameters("Create")
        inParamsLogo.Item("Description") = "Pi-Accounting Logo Photo Folder Share"
        inParamsLogo.Item("Name") = "LogoPhoto"
        inParamsLogo.Item("Path") = Trim(txt_save_logo.Text)
        inParamsLogo.Item("Type") = 0
        'If (DirectCast(managementClass.InvokeMethod("Create", inParamsLogo, Nothing).Properties.Item("ReturnValue").Value, UInt32) <> 0) Then
        '    Throw New Exception("Unable to share directory.")
        'End If


        insert_path_setup("Customer", Trim(txt_save_customer.Text))
        insert_path_setup("Supplier", Trim(txt_save_supplier.Text))
        insert_path_setup("Employee", Trim(txt_save_employee.Text))
        insert_path_setup("Item", Trim(txt_save_item.Text))
        insert_path_setup("Logo", Trim(txt_save_logo.Text))
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub frm_path_setup_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainMenu.Activate()
    End Sub

    Private Sub frm_path_setup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txt_save_customer.Text = Replace(get_def_path("Customer"), "/", "\")
        txt_save_employee.Text = Replace(get_def_path("Employee"), "/", "\")
        txt_save_item.Text = Replace(get_def_path("Item"), "/", "\")
        txt_save_supplier.Text = Replace(get_def_path("Supplier"), "/", "\")
    End Sub

    Private Sub Button_logo_Click(sender As System.Object, e As System.EventArgs) Handles Button_logo.Click
        open_conn()
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_logo.Text = pb.FileName
        End If
    End Sub
End Class