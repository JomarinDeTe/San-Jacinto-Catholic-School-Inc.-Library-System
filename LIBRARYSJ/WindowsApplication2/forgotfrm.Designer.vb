<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotfrm
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
        Me.BTN_ADDCOPY = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_code = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_ADDCOPY
        '
        Me.BTN_ADDCOPY.BackColor = System.Drawing.Color.Black
        Me.BTN_ADDCOPY.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_ADDCOPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADDCOPY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADDCOPY.ForeColor = System.Drawing.Color.GhostWhite
        Me.BTN_ADDCOPY.Location = New System.Drawing.Point(148, 179)
        Me.BTN_ADDCOPY.Name = "BTN_ADDCOPY"
        Me.BTN_ADDCOPY.Size = New System.Drawing.Size(152, 43)
        Me.BTN_ADDCOPY.TabIndex = 49
        Me.BTN_ADDCOPY.Text = "ENTER"
        Me.BTN_ADDCOPY.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(91, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(277, 32)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "FORGOT PASSWORD"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(109, 83)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(227, 21)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "Administrator Access Code:"
        '
        'TB_code
        '
        Me.TB_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_code.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_code.Location = New System.Drawing.Point(139, 118)
        Me.TB_code.Multiline = True
        Me.TB_code.Name = "TB_code"
        Me.TB_code.Size = New System.Drawing.Size(173, 33)
        Me.TB_code.TabIndex = 46
        '
        'forgotfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(453, 252)
        Me.Controls.Add(Me.BTN_ADDCOPY)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TB_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "forgotfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORGOT PASSWORD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_ADDCOPY As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TB_code As System.Windows.Forms.TextBox
End Class
