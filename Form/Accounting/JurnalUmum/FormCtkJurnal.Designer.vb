<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCtkJurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCtkJurnal))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.DisplayGroupTree = False
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.ForeColor = System.Drawing.Color.Black
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.ShowGroupTreeButton = False
        Me.CRviewer.Size = New System.Drawing.Size(883, 476)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'FormCtkJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.CRviewer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCtkJurnal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bukti Cetak Jurnal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
