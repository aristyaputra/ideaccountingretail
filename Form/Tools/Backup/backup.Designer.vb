<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup))
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnProsess = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProsess2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBackup2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Lavender
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(32741, 117)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(156, 37)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Pilih Direktori Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.UseVisualStyleBackColor = False
        Me.btnBackup.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, -55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(406, 23)
        Me.TextBox1.TabIndex = 1
        '
        'btnProsess
        '
        Me.btnProsess.BackColor = System.Drawing.Color.Lavender
        Me.btnProsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsess.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btnProsess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProsess.Location = New System.Drawing.Point(9344, 117)
        Me.btnProsess.Name = "btnProsess"
        Me.btnProsess.Size = New System.Drawing.Size(74, 37)
        Me.btnProsess.TabIndex = 2
        Me.btnProsess.Text = "Proses"
        Me.btnProsess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProsess.UseVisualStyleBackColor = False
        Me.btnProsess.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, -38)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(406, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pastikan user tidak ada yang memakai sistem agar backup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "berjalan dengan sempurna" & _
    ""
        '
        'btnProsess2
        '
        Me.btnProsess2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProsess2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsess2.Appearance.Options.UseFont = True
        Me.btnProsess2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btnProsess2.Location = New System.Drawing.Point(336, 83)
        Me.btnProsess2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnProsess2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnProsess2.Name = "btnProsess2"
        Me.btnProsess2.Size = New System.Drawing.Size(82, 36)
        Me.btnProsess2.TabIndex = 285
        Me.btnProsess2.Text = "PROSES"
        '
        'btnBackup2
        '
        Me.btnBackup2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup2.Appearance.Options.UseFont = True
        Me.btnBackup2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btnBackup2.Location = New System.Drawing.Point(12, 83)
        Me.btnBackup2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnBackup2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBackup2.Name = "btnBackup2"
        Me.btnBackup2.Size = New System.Drawing.Size(198, 36)
        Me.btnBackup2.TabIndex = 286
        Me.btnBackup2.Text = "PILIH DIREKTORI BACKUP"
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(430, 130)
        Me.Controls.Add(Me.btnBackup2)
        Me.Controls.Add(Me.btnProsess2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnProsess)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnProsess As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProsess2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBackup2 As DevExpress.XtraEditors.SimpleButton
End Class
