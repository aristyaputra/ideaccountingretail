<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaLunasKoperasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaLunasKoperasi))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Location = New System.Drawing.Point(0, 32)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(883, 444)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://E:\Desktop Project\VB.NET\POS System - New 2010\POS_Enterperise1.0\bin\D" & _
    "ebug\Report\NotaPO.rpt"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.smartaccounting.My.Resources.Resources.Cancel_24x24
        Me.Button2.Location = New System.Drawing.Point(840, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 30)
        Me.Button2.TabIndex = 47
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label_Title.Location = New System.Drawing.Point(2, 2)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(76, 27)
        Me.Label_Title.TabIndex = 266
        Me.Label_Title.Text = "Report"
        '
        'LapMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CRviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LapMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Data Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label_Title As System.Windows.Forms.Label
End Class
