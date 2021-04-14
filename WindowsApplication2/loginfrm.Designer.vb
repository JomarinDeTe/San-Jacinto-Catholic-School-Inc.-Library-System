<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginfrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginfrm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtbpass = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtbuser = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(254, 286)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(6, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Forgot Password?"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(2, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(2, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Username"
        '
        'txtbPassword
        '
        Me.txtbPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPassword.ForeColor = System.Drawing.Color.White
        Me.txtbPassword.HintForeColor = System.Drawing.Color.White
        Me.txtbPassword.HintText = "Type your Password"
        Me.txtbPassword.isPassword = False
        Me.txtbPassword.LineFocusedColor = System.Drawing.Color.White
        Me.txtbPassword.LineIdleColor = System.Drawing.Color.White
        Me.txtbPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbPassword.LineThickness = 1
        Me.txtbPassword.Location = New System.Drawing.Point(15, 280)
        Me.txtbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(274, 38)
        Me.txtbPassword.TabIndex = 14
        Me.txtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbUsername
        '
        Me.txtbUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUsername.ForeColor = System.Drawing.Color.White
        Me.txtbUsername.HintForeColor = System.Drawing.Color.White
        Me.txtbUsername.HintText = "Type your Username"
        Me.txtbUsername.isPassword = False
        Me.txtbUsername.LineFocusedColor = System.Drawing.Color.White
        Me.txtbUsername.LineIdleColor = System.Drawing.Color.White
        Me.txtbUsername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbUsername.LineThickness = 1
        Me.txtbUsername.Location = New System.Drawing.Point(15, 212)
        Me.txtbUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbUsername.Name = "txtbUsername"
        Me.txtbUsername.Size = New System.Drawing.Size(274, 40)
        Me.txtbUsername.TabIndex = 13
        Me.txtbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(254, 326)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txtbpass)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtbuser)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtbPassword)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtbUsername)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label8)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox4)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox5)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(303, 528)
        Me.BunifuGradientPanel1.TabIndex = 25
        '
        'txtbpass
        '
        Me.txtbpass.ActiveBorderThickness = 1
        Me.txtbpass.ActiveCornerRadius = 15
        Me.txtbpass.ActiveFillColor = System.Drawing.Color.Goldenrod
        Me.txtbpass.ActiveForecolor = System.Drawing.Color.Black
        Me.txtbpass.ActiveLineColor = System.Drawing.Color.Goldenrod
        Me.txtbpass.BackColor = System.Drawing.Color.Transparent
        Me.txtbpass.BackgroundImage = CType(resources.GetObject("txtbpass.BackgroundImage"), System.Drawing.Image)
        Me.txtbpass.ButtonText = "Exit"
        Me.txtbpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbpass.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbpass.ForeColor = System.Drawing.Color.Black
        Me.txtbpass.IdleBorderThickness = 1
        Me.txtbpass.IdleCornerRadius = 15
        Me.txtbpass.IdleFillColor = System.Drawing.Color.Yellow
        Me.txtbpass.IdleForecolor = System.Drawing.Color.Black
        Me.txtbpass.IdleLineColor = System.Drawing.Color.Yellow
        Me.txtbpass.Location = New System.Drawing.Point(20, 441)
        Me.txtbpass.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtbpass.Name = "txtbpass"
        Me.txtbpass.Size = New System.Drawing.Size(262, 53)
        Me.txtbpass.TabIndex = 30
        Me.txtbpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.LIBRARYSJ.My.Resources.Resources.Logo_sjcs
        Me.PictureBox3.Location = New System.Drawing.Point(68, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(171, 165)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'txtbuser
        '
        Me.txtbuser.ActiveBorderThickness = 1
        Me.txtbuser.ActiveCornerRadius = 15
        Me.txtbuser.ActiveFillColor = System.Drawing.Color.Goldenrod
        Me.txtbuser.ActiveForecolor = System.Drawing.Color.Black
        Me.txtbuser.ActiveLineColor = System.Drawing.Color.Goldenrod
        Me.txtbuser.BackColor = System.Drawing.Color.Transparent
        Me.txtbuser.BackgroundImage = CType(resources.GetObject("txtbuser.BackgroundImage"), System.Drawing.Image)
        Me.txtbuser.ButtonText = "Login"
        Me.txtbuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuser.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuser.ForeColor = System.Drawing.Color.Black
        Me.txtbuser.IdleBorderThickness = 1
        Me.txtbuser.IdleCornerRadius = 15
        Me.txtbuser.IdleFillColor = System.Drawing.Color.Yellow
        Me.txtbuser.IdleForecolor = System.Drawing.Color.Black
        Me.txtbuser.IdleLineColor = System.Drawing.Color.Yellow
        Me.txtbuser.Location = New System.Drawing.Point(20, 378)
        Me.txtbuser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbuser.Name = "txtbuser"
        Me.txtbuser.Size = New System.Drawing.Size(262, 53)
        Me.txtbuser.TabIndex = 29
        Me.txtbuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.LIBRARYSJ.My.Resources.Resources.uokpl_rs_password_icon_png_4811542
        Me.PictureBox5.Location = New System.Drawing.Point(254, 326)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 40
        Me.BunifuElipse2.TargetControl = Me.txtbUsername
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 40
        Me.BunifuElipse3.TargetControl = Me.txtbPassword
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(713, 49)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "SAN JACINTO CATHOLIC SCHOOL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(628, 43)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(637, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "‘Knowledge is free at the library. Just bring your own container.'"
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 25
        Me.BunifuElipse4.TargetControl = Me.BunifuGradientPanel1
        '
        'loginfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LIBRARYSJ.My.Resources.Resources.thomas_kelley_hHL08lF7Ikc_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1015, 528)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtbUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtbpass As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtbuser As Bunifu.Framework.UI.BunifuThinButton2

End Class
