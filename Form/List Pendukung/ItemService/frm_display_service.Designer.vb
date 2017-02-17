<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_service
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_service))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colaccno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl2.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(0, 0)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(427, 23)
        Me.txt_search.TabIndex = 19
        '
        'cbo_search
        '
        Me.cbo_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Service ID" & Global.Microsoft.VisualBasic.ChrW(9), "Service Name"})
        Me.cbo_search.Location = New System.Drawing.Point(0, 0)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(159, 26)
        Me.cbo_search.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colaccno, Me.colaccnm, Me.colprice})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(1, 58)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(626, 386)
        Me.DataGridView1.TabIndex = 20
        '
        'colaccno
        '
        Me.colaccno.HeaderText = "Service Code"
        Me.colaccno.Name = "colaccno"
        Me.colaccno.ReadOnly = True
        Me.colaccno.Width = 135
        '
        'colaccnm
        '
        Me.colaccnm.HeaderText = "Service Name"
        Me.colaccnm.Name = "colaccnm"
        Me.colaccnm.ReadOnly = True
        Me.colaccnm.Width = 280
        '
        'colprice
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle2
        Me.colprice.HeaderText = "Price"
        Me.colprice.Name = "colprice"
        Me.colprice.ReadOnly = True
        Me.colprice.Width = 140
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Appearance.GroupBackground.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl1.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Lavender
        Me.NavBarControl1.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl1.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl1.Appearance.GroupHeader.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl1.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.Orange
        Me.NavBarControl1.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl1.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Location = New System.Drawing.Point(2, 1)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 183
        Me.NavBarControl1.Size = New System.Drawing.Size(183, 54)
        Me.NavBarControl1.TabIndex = 278
        Me.NavBarControl1.Text = "No Kas Umum / Bank"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Filter By"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 24
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cbo_search)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(159, 23)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup2
        Me.NavBarControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavBarControl2.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl2.Appearance.GroupBackground.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl2.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Lavender
        Me.NavBarControl2.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl2.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl2.Appearance.GroupHeader.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl2.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.Orange
        Me.NavBarControl2.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl2.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2})
        Me.NavBarControl2.Location = New System.Drawing.Point(176, 1)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 451
        Me.NavBarControl2.Size = New System.Drawing.Size(451, 54)
        Me.NavBarControl2.TabIndex = 279
        Me.NavBarControl2.Text = "No Kas Umum / Bank"
        Me.NavBarControl2.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Filter Key"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 24
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.txt_search)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(427, 23)
        Me.NavBarGroupControlContainer2.TabIndex = 0
        '
        'frm_display_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(628, 447)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_display_service"
        Me.Text = "List Service"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents colaccno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
