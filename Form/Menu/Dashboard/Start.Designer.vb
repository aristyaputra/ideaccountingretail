<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DimGray
        Me.Label32.Location = New System.Drawing.Point(45, 406)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(172, 23)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "SMART ACCOUNTING"
        '
        'logo2
        '
        Me.logo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.logo2.BackColor = System.Drawing.Color.Transparent
        Me.logo2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.calculator_icon
        Me.logo2.Location = New System.Drawing.Point(7, 401)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(32, 32)
        Me.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo2.TabIndex = 46
        Me.logo2.TabStop = False
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DimGray
        Me.Label30.Location = New System.Drawing.Point(362, 405)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 24)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Tanggal :"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_date.Location = New System.Drawing.Point(455, 405)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(81, 24)
        Me.lbl_date.TabIndex = 49
        Me.lbl_date.Text = "Label30"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_time.Location = New System.Drawing.Point(566, 405)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(81, 24)
        Me.lbl_time.TabIndex = 48
        Me.lbl_time.Text = "Label30"
        '
        'timer
        '
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SMARTACCOUNTING.My.Resources.Resources.accounting_cycle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.logo2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer
End Class
