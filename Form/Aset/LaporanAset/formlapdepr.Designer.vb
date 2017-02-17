<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLapDepr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLapDepr))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_period = New System.Windows.Forms.DateTimePicker()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.DisplayGroupTree = False
        Me.CRviewer.Location = New System.Drawing.Point(0, 47)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(883, 429)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periode:"
        '
        'txt_period
        '
        Me.txt_period.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_period.CustomFormat = "MMM-yyyy"
        Me.txt_period.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_period.ForeColor = System.Drawing.Color.Black
        Me.txt_period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_period.Location = New System.Drawing.Point(66, 5)
        Me.txt_period.Name = "txt_period"
        Me.txt_period.Size = New System.Drawing.Size(129, 23)
        Me.txt_period.TabIndex = 52
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(201, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(66, 29)
        Me.btn_simpan.TabIndex = 53
        Me.btn_simpan.Text = "Lihat"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'FormLapDepr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_period)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CRviewer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLapDepr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bukti Faktur Pembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_period As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
End Class
