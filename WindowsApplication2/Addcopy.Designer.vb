<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addcopy
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TB_AN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_ADDCOPY = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(103, 73)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(159, 21)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "Accession Number:"
        '
        'TB_AN
        '
        Me.TB_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_AN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AN.Location = New System.Drawing.Point(107, 97)
        Me.TB_AN.Multiline = True
        Me.TB_AN.Name = "TB_AN"
        Me.TB_AN.Size = New System.Drawing.Size(173, 33)
        Me.TB_AN.TabIndex = 41
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(129, -3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(151, 32)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Add Copy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = ".........."
        '
        'BTN_ADDCOPY
        '
        Me.BTN_ADDCOPY.BackColor = System.Drawing.Color.Black
        Me.BTN_ADDCOPY.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_ADDCOPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADDCOPY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADDCOPY.ForeColor = System.Drawing.Color.White
        Me.BTN_ADDCOPY.Location = New System.Drawing.Point(112, 158)
        Me.BTN_ADDCOPY.Name = "BTN_ADDCOPY"
        Me.BTN_ADDCOPY.Size = New System.Drawing.Size(152, 43)
        Me.BTN_ADDCOPY.TabIndex = 45
        Me.BTN_ADDCOPY.Text = "ADD"
        Me.BTN_ADDCOPY.UseVisualStyleBackColor = False
        '
        'Addcopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(399, 221)
        Me.Controls.Add(Me.BTN_ADDCOPY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TB_AN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Addcopy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD COPY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TB_AN As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_ADDCOPY As System.Windows.Forms.Button
End Class
