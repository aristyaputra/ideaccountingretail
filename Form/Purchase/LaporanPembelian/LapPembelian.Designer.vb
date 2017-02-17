<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LapPembelian))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.DisplayGroupTree = False
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(883, 476)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'reportDocument1
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(727, 457)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(154, 17)
        Me.ProgressBar2.TabIndex = 2
        Me.ProgressBar2.Visible = False
        '
        'LapPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.CRviewer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Pembelian"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
End Class
