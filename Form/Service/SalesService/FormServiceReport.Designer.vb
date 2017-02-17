<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServiceReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lap. Service Per Tanggal")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lap. Service (Teraphyst Group)")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Laporan Komisi Teraphysts Per Bulan")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormServiceReport))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.From = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(3, 33)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(237, 324)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Laporan Reparasi"
        '
        'From
        '
        Me.From.AutoSize = True
        Me.From.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From.Location = New System.Drawing.Point(246, 42)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(30, 15)
        Me.From.TabIndex = 2
        Me.From.Text = "Dari"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(246, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sampai"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(246, 101)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(305, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 35)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormServiceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(405, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.From)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormServiceReport"
        Me.Text = "Laporan Reparasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents From As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
