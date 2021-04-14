<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentmenu))
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.COM_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_LRN = New System.Windows.Forms.TextBox()
        Me.TB_LN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TB_MN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.COM_SEX = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.COM_SECTION = New System.Windows.Forms.ComboBox()
        Me.COM_GRADE = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TB_FN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pnlStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.Navy
        Me.pnlStudent.Controls.Add(Me.Label8)
        Me.pnlStudent.Controls.Add(Me.COM_TYPE)
        Me.pnlStudent.Controls.Add(Me.Label7)
        Me.pnlStudent.Controls.Add(Me.Label6)
        Me.pnlStudent.Controls.Add(Me.Label1)
        Me.pnlStudent.Controls.Add(Me.Label5)
        Me.pnlStudent.Controls.Add(Me.Label4)
        Me.pnlStudent.Controls.Add(Me.Label3)
        Me.pnlStudent.Controls.Add(Me.Label2)
        Me.pnlStudent.Controls.Add(Me.TB_LRN)
        Me.pnlStudent.Controls.Add(Me.TB_LN)
        Me.pnlStudent.Controls.Add(Me.TB_MN)
        Me.pnlStudent.Controls.Add(Me.COM_SEX)
        Me.pnlStudent.Controls.Add(Me.Label10)
        Me.pnlStudent.Controls.Add(Me.COM_SECTION)
        Me.pnlStudent.Controls.Add(Me.COM_GRADE)
        Me.pnlStudent.Controls.Add(Me.Button11)
        Me.pnlStudent.Controls.Add(Me.Button10)
        Me.pnlStudent.Controls.Add(Me.TB_FN)
        Me.pnlStudent.Location = New System.Drawing.Point(-1, -4)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(440, 397)
        Me.pnlStudent.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(267, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Type:"
        '
        'COM_TYPE
        '
        Me.COM_TYPE.BackColor = System.Drawing.Color.White
        Me.COM_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COM_TYPE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_TYPE.ForeColor = System.Drawing.Color.Black
        Me.COM_TYPE.FormattingEnabled = True
        Me.COM_TYPE.Items.AddRange(New Object() {"Student", "Employee"})
        Me.COM_TYPE.Location = New System.Drawing.Point(265, 200)
        Me.COM_TYPE.Name = "COM_TYPE"
        Me.COM_TYPE.Size = New System.Drawing.Size(121, 28)
        Me.COM_TYPE.TabIndex = 34
        Me.COM_TYPE.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Lastname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Middlename:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Firstname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(267, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(267, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Section:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(267, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Grade Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LRN:"
        '
        'TB_LRN
        '
        Me.TB_LRN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LRN.Location = New System.Drawing.Point(27, 98)
        Me.TB_LRN.Multiline = True
        Me.TB_LRN.Name = "TB_LRN"
        Me.TB_LRN.Size = New System.Drawing.Size(173, 33)
        Me.TB_LRN.TabIndex = 25
        '
        'TB_LN
        '
        Me.TB_LN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_LN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_LN.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TB_LN.ForeColor = System.Drawing.Color.White
        Me.TB_LN.HintForeColor = System.Drawing.Color.White
        Me.TB_LN.HintText = "Type Last Name here"
        Me.TB_LN.isPassword = False
        Me.TB_LN.LineFocusedColor = System.Drawing.Color.White
        Me.TB_LN.LineIdleColor = System.Drawing.Color.White
        Me.TB_LN.LineMouseHoverColor = System.Drawing.Color.Black
        Me.TB_LN.LineThickness = 3
        Me.TB_LN.Location = New System.Drawing.Point(27, 253)
        Me.TB_LN.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_LN.Name = "TB_LN"
        Me.TB_LN.Size = New System.Drawing.Size(173, 33)
        Me.TB_LN.TabIndex = 24
        Me.TB_LN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TB_MN
        '
        Me.TB_MN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_MN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_MN.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TB_MN.ForeColor = System.Drawing.Color.White
        Me.TB_MN.HintForeColor = System.Drawing.Color.White
        Me.TB_MN.HintText = "Type Middle Name"
        Me.TB_MN.isPassword = False
        Me.TB_MN.LineFocusedColor = System.Drawing.Color.White
        Me.TB_MN.LineIdleColor = System.Drawing.Color.White
        Me.TB_MN.LineMouseHoverColor = System.Drawing.Color.Black
        Me.TB_MN.LineThickness = 3
        Me.TB_MN.Location = New System.Drawing.Point(27, 200)
        Me.TB_MN.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_MN.Name = "TB_MN"
        Me.TB_MN.Size = New System.Drawing.Size(173, 33)
        Me.TB_MN.TabIndex = 23
        Me.TB_MN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'COM_SEX
        '
        Me.COM_SEX.BackColor = System.Drawing.Color.White
        Me.COM_SEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COM_SEX.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_SEX.ForeColor = System.Drawing.Color.Black
        Me.COM_SEX.FormattingEnabled = True
        Me.COM_SEX.Items.AddRange(New Object() {"Male", "Female"})
        Me.COM_SEX.Location = New System.Drawing.Point(265, 252)
        Me.COM_SEX.Name = "COM_SEX"
        Me.COM_SEX.Size = New System.Drawing.Size(121, 28)
        Me.COM_SEX.TabIndex = 22
        Me.COM_SEX.Text = "Sex"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(131, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 32)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ADD READER"
        '
        'COM_SECTION
        '
        Me.COM_SECTION.BackColor = System.Drawing.Color.White
        Me.COM_SECTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COM_SECTION.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_SECTION.ForeColor = System.Drawing.Color.Black
        Me.COM_SECTION.FormattingEnabled = True
        Me.COM_SECTION.Items.AddRange(New Object() {"ST.PETER"})
        Me.COM_SECTION.Location = New System.Drawing.Point(265, 150)
        Me.COM_SECTION.Name = "COM_SECTION"
        Me.COM_SECTION.Size = New System.Drawing.Size(121, 28)
        Me.COM_SECTION.TabIndex = 20
        Me.COM_SECTION.Text = "Section"
        '
        'COM_GRADE
        '
        Me.COM_GRADE.BackColor = System.Drawing.Color.White
        Me.COM_GRADE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.COM_GRADE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COM_GRADE.ForeColor = System.Drawing.Color.Black
        Me.COM_GRADE.FormattingEnabled = True
        Me.COM_GRADE.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.COM_GRADE.Location = New System.Drawing.Point(265, 97)
        Me.COM_GRADE.Name = "COM_GRADE"
        Me.COM_GRADE.Size = New System.Drawing.Size(121, 28)
        Me.COM_GRADE.TabIndex = 19
        Me.COM_GRADE.Text = "Grade Level"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Black
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(230, 329)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(170, 47)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "CANCEL"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Black
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(32, 329)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(170, 47)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "SAVE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'TB_FN
        '
        Me.TB_FN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_FN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_FN.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TB_FN.ForeColor = System.Drawing.Color.White
        Me.TB_FN.HintForeColor = System.Drawing.Color.White
        Me.TB_FN.HintText = "Type First Name"
        Me.TB_FN.isPassword = False
        Me.TB_FN.LineFocusedColor = System.Drawing.Color.White
        Me.TB_FN.LineIdleColor = System.Drawing.Color.White
        Me.TB_FN.LineMouseHoverColor = System.Drawing.Color.Black
        Me.TB_FN.LineThickness = 3
        Me.TB_FN.Location = New System.Drawing.Point(27, 150)
        Me.TB_FN.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_FN.Name = "TB_FN"
        Me.TB_FN.Size = New System.Drawing.Size(173, 33)
        Me.TB_FN.TabIndex = 11
        Me.TB_FN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'studentmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 394)
        Me.Controls.Add(Me.pnlStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT"
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
    Friend WithEvents TB_LN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TB_MN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents COM_SEX As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents COM_SECTION As System.Windows.Forms.ComboBox
    Friend WithEvents COM_GRADE As System.Windows.Forms.ComboBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TB_FN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_LRN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents COM_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
