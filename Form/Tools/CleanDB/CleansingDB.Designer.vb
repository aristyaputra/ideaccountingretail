<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleansingDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CleansingDB))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Refresh_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-91, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 40)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Proses"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 120)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.btn_save2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 349)
        Me.Panel1.TabIndex = 30
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_save2.Location = New System.Drawing.Point(132, 210)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 31
        Me.btn_save2.Text = "PROSES"
        '
        'CleansingSIMRSHaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(353, 349)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CleansingSIMRSHaji"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cleansing Database"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
End Class
