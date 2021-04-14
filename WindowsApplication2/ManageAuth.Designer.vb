<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAuth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAuth))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_LNAUTH = New System.Windows.Forms.TextBox()
        Me.TB_FNAUTH = New System.Windows.Forms.TextBox()
        Me.TB_AUTHID = New System.Windows.Forms.TextBox()
        Me.TB_SEARCHAUTH = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BTN_CANCELAUTH = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DGV_ASSIGNED = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BTN_DELETEAUTH = New System.Windows.Forms.Button()
        Me.DGV_UNASSIGNED = New System.Windows.Forms.DataGridView()
        Me.BTN_EDITAUTH = New System.Windows.Forms.Button()
        Me.BTN_ADDAUTH = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_ASSIGNED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_UNASSIGNED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.TB_LNAUTH)
        Me.Panel4.Controls.Add(Me.TB_FNAUTH)
        Me.Panel4.Controls.Add(Me.TB_AUTHID)
        Me.Panel4.Controls.Add(Me.Button36)
        Me.Panel4.Controls.Add(Me.Button34)
        Me.Panel4.Controls.Add(Me.TB_SEARCHAUTH)
        Me.Panel4.Controls.Add(Me.BTN_CANCELAUTH)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.DGV_ASSIGNED)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.BTN_DELETEAUTH)
        Me.Panel4.Controls.Add(Me.DGV_UNASSIGNED)
        Me.Panel4.Controls.Add(Me.BTN_EDITAUTH)
        Me.Panel4.Controls.Add(Me.BTN_ADDAUTH)
        Me.Panel4.Location = New System.Drawing.Point(1, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 516)
        Me.Panel4.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(468, 451)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 17)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Unassign"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(471, 329)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 21)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Assign"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(51, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Author Last Name:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Location = New System.Drawing.Point(51, 101)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(148, 21)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "Author Firstname:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Location = New System.Drawing.Point(51, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(90, 21)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "Author ID:"
        '
        'TB_LNAUTH
        '
        Me.TB_LNAUTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_LNAUTH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LNAUTH.Location = New System.Drawing.Point(55, 183)
        Me.TB_LNAUTH.Multiline = True
        Me.TB_LNAUTH.Name = "TB_LNAUTH"
        Me.TB_LNAUTH.ReadOnly = True
        Me.TB_LNAUTH.Size = New System.Drawing.Size(173, 33)
        Me.TB_LNAUTH.TabIndex = 39
        '
        'TB_FNAUTH
        '
        Me.TB_FNAUTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_FNAUTH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FNAUTH.Location = New System.Drawing.Point(55, 125)
        Me.TB_FNAUTH.Multiline = True
        Me.TB_FNAUTH.Name = "TB_FNAUTH"
        Me.TB_FNAUTH.ReadOnly = True
        Me.TB_FNAUTH.Size = New System.Drawing.Size(173, 33)
        Me.TB_FNAUTH.TabIndex = 38
        '
        'TB_AUTHID
        '
        Me.TB_AUTHID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_AUTHID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AUTHID.Location = New System.Drawing.Point(55, 66)
        Me.TB_AUTHID.Multiline = True
        Me.TB_AUTHID.Name = "TB_AUTHID"
        Me.TB_AUTHID.ReadOnly = True
        Me.TB_AUTHID.Size = New System.Drawing.Size(173, 33)
        Me.TB_AUTHID.TabIndex = 37
        '
        'TB_SEARCHAUTH
        '
        Me.TB_SEARCHAUTH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_SEARCHAUTH.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TB_SEARCHAUTH.ForeColor = System.Drawing.Color.White
        Me.TB_SEARCHAUTH.HintForeColor = System.Drawing.Color.White
        Me.TB_SEARCHAUTH.HintText = "SEARCH HERE"
        Me.TB_SEARCHAUTH.isPassword = False
        Me.TB_SEARCHAUTH.LineFocusedColor = System.Drawing.Color.Black
        Me.TB_SEARCHAUTH.LineIdleColor = System.Drawing.Color.Black
        Me.TB_SEARCHAUTH.LineMouseHoverColor = System.Drawing.Color.Black
        Me.TB_SEARCHAUTH.LineThickness = 3
        Me.TB_SEARCHAUTH.Location = New System.Drawing.Point(255, 225)
        Me.TB_SEARCHAUTH.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_SEARCHAUTH.Name = "TB_SEARCHAUTH"
        Me.TB_SEARCHAUTH.Size = New System.Drawing.Size(209, 33)
        Me.TB_SEARCHAUTH.TabIndex = 29
        Me.TB_SEARCHAUTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTN_CANCELAUTH
        '
        Me.BTN_CANCELAUTH.BackColor = System.Drawing.Color.Black
        Me.BTN_CANCELAUTH.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_CANCELAUTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CANCELAUTH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCELAUTH.ForeColor = System.Drawing.Color.White
        Me.BTN_CANCELAUTH.Location = New System.Drawing.Point(750, 121)
        Me.BTN_CANCELAUTH.Name = "BTN_CANCELAUTH"
        Me.BTN_CANCELAUTH.Size = New System.Drawing.Size(170, 47)
        Me.BTN_CANCELAUTH.TabIndex = 28
        Me.BTN_CANCELAUTH.Text = "CANCEL"
        Me.BTN_CANCELAUTH.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(528, 233)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(201, 25)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Assigned Authors:"
        '
        'DGV_ASSIGNED
        '
        Me.DGV_ASSIGNED.AllowUserToAddRows = False
        Me.DGV_ASSIGNED.AllowUserToDeleteRows = False
        Me.DGV_ASSIGNED.AllowUserToResizeColumns = False
        Me.DGV_ASSIGNED.AllowUserToResizeRows = False
        Me.DGV_ASSIGNED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ASSIGNED.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ASSIGNED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ASSIGNED.Location = New System.Drawing.Point(533, 261)
        Me.DGV_ASSIGNED.Name = "DGV_ASSIGNED"
        Me.DGV_ASSIGNED.ReadOnly = True
        Me.DGV_ASSIGNED.RowHeadersVisible = False
        Me.DGV_ASSIGNED.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_ASSIGNED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ASSIGNED.Size = New System.Drawing.Size(461, 239)
        Me.DGV_ASSIGNED.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(-2, 233)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 25)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Authors:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(386, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(250, 32)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "MANAGE AUTHOR"
        '
        'BTN_DELETEAUTH
        '
        Me.BTN_DELETEAUTH.BackColor = System.Drawing.Color.Black
        Me.BTN_DELETEAUTH.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_DELETEAUTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DELETEAUTH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETEAUTH.ForeColor = System.Drawing.Color.Red
        Me.BTN_DELETEAUTH.Location = New System.Drawing.Point(564, 121)
        Me.BTN_DELETEAUTH.Name = "BTN_DELETEAUTH"
        Me.BTN_DELETEAUTH.Size = New System.Drawing.Size(170, 47)
        Me.BTN_DELETEAUTH.TabIndex = 18
        Me.BTN_DELETEAUTH.Text = "DELETE"
        Me.BTN_DELETEAUTH.UseVisualStyleBackColor = False
        '
        'DGV_UNASSIGNED
        '
        Me.DGV_UNASSIGNED.AllowUserToAddRows = False
        Me.DGV_UNASSIGNED.AllowUserToDeleteRows = False
        Me.DGV_UNASSIGNED.AllowUserToResizeColumns = False
        Me.DGV_UNASSIGNED.AllowUserToResizeRows = False
        Me.DGV_UNASSIGNED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_UNASSIGNED.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_UNASSIGNED.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_UNASSIGNED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_UNASSIGNED.Location = New System.Drawing.Point(3, 261)
        Me.DGV_UNASSIGNED.Name = "DGV_UNASSIGNED"
        Me.DGV_UNASSIGNED.ReadOnly = True
        Me.DGV_UNASSIGNED.RowHeadersVisible = False
        Me.DGV_UNASSIGNED.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_UNASSIGNED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_UNASSIGNED.Size = New System.Drawing.Size(461, 239)
        Me.DGV_UNASSIGNED.TabIndex = 14
        '
        'BTN_EDITAUTH
        '
        Me.BTN_EDITAUTH.BackColor = System.Drawing.Color.Black
        Me.BTN_EDITAUTH.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_EDITAUTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EDITAUTH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDITAUTH.ForeColor = System.Drawing.Color.White
        Me.BTN_EDITAUTH.Location = New System.Drawing.Point(750, 66)
        Me.BTN_EDITAUTH.Name = "BTN_EDITAUTH"
        Me.BTN_EDITAUTH.Size = New System.Drawing.Size(170, 47)
        Me.BTN_EDITAUTH.TabIndex = 13
        Me.BTN_EDITAUTH.Text = "EDIT"
        Me.BTN_EDITAUTH.UseVisualStyleBackColor = False
        '
        'BTN_ADDAUTH
        '
        Me.BTN_ADDAUTH.BackColor = System.Drawing.Color.Black
        Me.BTN_ADDAUTH.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_ADDAUTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADDAUTH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADDAUTH.ForeColor = System.Drawing.Color.White
        Me.BTN_ADDAUTH.Location = New System.Drawing.Point(564, 64)
        Me.BTN_ADDAUTH.Name = "BTN_ADDAUTH"
        Me.BTN_ADDAUTH.Size = New System.Drawing.Size(170, 51)
        Me.BTN_ADDAUTH.TabIndex = 12
        Me.BTN_ADDAUTH.Text = "ADD"
        Me.BTN_ADDAUTH.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Transparent
        Me.Button36.BackgroundImage = Global.LIBRARYSJ.My.Resources.Resources.left_512px
        Me.Button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button36.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Location = New System.Drawing.Point(466, 396)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(64, 52)
        Me.Button36.TabIndex = 31
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.Transparent
        Me.Button34.BackgroundImage = Global.LIBRARYSJ.My.Resources.Resources.right_512px
        Me.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button34.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Location = New System.Drawing.Point(466, 273)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(64, 53)
        Me.Button34.TabIndex = 30
        Me.Button34.UseVisualStyleBackColor = False
        '
        'ManageAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 519)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANAGE AUTHOR"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_ASSIGNED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_UNASSIGNED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TB_LNAUTH As System.Windows.Forms.TextBox
    Friend WithEvents TB_FNAUTH As System.Windows.Forms.TextBox
    Friend WithEvents TB_AUTHID As System.Windows.Forms.TextBox
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents TB_SEARCHAUTH As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BTN_CANCELAUTH As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DGV_ASSIGNED As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BTN_DELETEAUTH As System.Windows.Forms.Button
    Friend WithEvents DGV_UNASSIGNED As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_EDITAUTH As System.Windows.Forms.Button
    Friend WithEvents BTN_ADDAUTH As System.Windows.Forms.Button
End Class
