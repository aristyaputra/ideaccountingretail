<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        Dim StyleManager1 As DevComponents.DotNetBar.StyleManager
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_server = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.logo2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.WhiteSmoke, System.Drawing.Color.CornflowerBlue)
        '
        'txt_user
        '
        Me.txt_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_user.BackColor = System.Drawing.Color.Silver
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Font = New System.Drawing.Font("Trebuchet MS", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txt_user.Location = New System.Drawing.Point(10, 122)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(379, 33)
        Me.txt_user.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_password.BackColor = System.Drawing.Color.Silver
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Trebuchet MS", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txt_password.Location = New System.Drawing.Point(10, 194)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(379, 33)
        Me.txt_password.TabIndex = 1
        '
        'txt_server
        '
        Me.txt_server.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_server.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server.ForeColor = System.Drawing.Color.Black
        Me.txt_server.FormattingEnabled = True
        Me.txt_server.Location = New System.Drawing.Point(553, 48)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(228, 35)
        Me.txt_server.TabIndex = 3
        Me.txt_server.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.Button1.Location = New System.Drawing.Point(787, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(7, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Esc - Keluar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(305, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Enter - Login"
        '
        'logo2
        '
        Me.logo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.logo2.BackColor = System.Drawing.Color.Transparent
        Me.logo2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.logo_and_text_xsmall_fixed
        Me.logo2.Location = New System.Drawing.Point(4, 4)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(278, 48)
        Me.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo2.TabIndex = 46
        Me.logo2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(6, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(6, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(56, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Retail Version"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 282)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDEA ACCOUNTING - Login"
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_server As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pb_login As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
