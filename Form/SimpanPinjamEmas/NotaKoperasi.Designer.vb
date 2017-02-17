<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaKoperasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaKoperasi))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.CRviewer.Location = New System.Drawing.Point(0, 34)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(999, 665)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://E:\Desktop Project\VB.NET\POS System - New 2010\POS_Enterperise1.0\bin\D" & _
    "ebug\Report\NotaPO.rpt"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Cancel_24x24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(964, -1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 32)
        Me.Button1.TabIndex = 263
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label_Title.Location = New System.Drawing.Point(4, 2)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(56, 27)
        Me.Label_Title.TabIndex = 264
        Me.Label_Title.Text = "Nota"
        '
        'FormFakturBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CRviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFakturBeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bukti Faktur Pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label_Title As System.Windows.Forms.Label
End Class
