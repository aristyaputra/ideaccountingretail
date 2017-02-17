<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.labelControl2.Location = New System.Drawing.Point(23, 202)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(50, 13)
        Me.labelControl2.TabIndex = 12
        Me.labelControl2.Text = "Starting..."
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelControl1.Location = New System.Drawing.Point(23, 282)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(115, 13)
        Me.labelControl1.TabIndex = 11
        Me.labelControl1.Text = "Copyright © 2014-2015"
        '
        'marqueeProgressBarControl1
        '
        Me.marqueeProgressBarControl1.EditValue = 0
        Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(23, 227)
        Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
        Me.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(404, 12)
        Me.marqueeProgressBarControl1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.background1
        Me.PictureBox2.Location = New System.Drawing.Point(23, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 171)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.piaccountingsmall
        Me.PictureBox1.Location = New System.Drawing.Point(239, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.marqueeProgressBarControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.labelControl1)
        Me.Panel1.Controls.Add(Me.labelControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 320)
        Me.Panel1.TabIndex = 17
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SplashScreen"
        Me.Text = "Form1"
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
