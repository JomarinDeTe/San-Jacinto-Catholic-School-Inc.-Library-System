<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportfrm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_MAIN = New System.Windows.Forms.DataGridView()
        Me.DGV_PENALTY = New System.Windows.Forms.DataGridView()
        Me.TB_AUTHOR = New System.Windows.Forms.TextBox()
        Me.TB_BOOK = New System.Windows.Forms.TextBox()
        Me.DTP_MONTH = New System.Windows.Forms.DateTimePicker()
        Me.DTP_YEAR = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_PENALTY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_PENALTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(363, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPORT"
        '
        'DGV_MAIN
        '
        Me.DGV_MAIN.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MAIN.Location = New System.Drawing.Point(12, 250)
        Me.DGV_MAIN.Name = "DGV_MAIN"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_MAIN.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_MAIN.Size = New System.Drawing.Size(477, 237)
        Me.DGV_MAIN.TabIndex = 1
        '
        'DGV_PENALTY
        '
        Me.DGV_PENALTY.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_PENALTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PENALTY.Location = New System.Drawing.Point(495, 250)
        Me.DGV_PENALTY.Name = "DGV_PENALTY"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_PENALTY.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_PENALTY.Size = New System.Drawing.Size(485, 237)
        Me.DGV_PENALTY.TabIndex = 2
        '
        'TB_AUTHOR
        '
        Me.TB_AUTHOR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AUTHOR.Location = New System.Drawing.Point(211, 79)
        Me.TB_AUTHOR.Multiline = True
        Me.TB_AUTHOR.Name = "TB_AUTHOR"
        Me.TB_AUTHOR.Size = New System.Drawing.Size(152, 29)
        Me.TB_AUTHOR.TabIndex = 3
        '
        'TB_BOOK
        '
        Me.TB_BOOK.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_BOOK.Location = New System.Drawing.Point(24, 79)
        Me.TB_BOOK.Multiline = True
        Me.TB_BOOK.Name = "TB_BOOK"
        Me.TB_BOOK.Size = New System.Drawing.Size(152, 29)
        Me.TB_BOOK.TabIndex = 4
        '
        'DTP_MONTH
        '
        Me.DTP_MONTH.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_MONTH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_MONTH.Location = New System.Drawing.Point(433, 78)
        Me.DTP_MONTH.Name = "DTP_MONTH"
        Me.DTP_MONTH.Size = New System.Drawing.Size(200, 20)
        Me.DTP_MONTH.TabIndex = 5
        '
        'DTP_YEAR
        '
        Me.DTP_YEAR.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_YEAR.CustomFormat = "yyyy"
        Me.DTP_YEAR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_YEAR.Location = New System.Drawing.Point(433, 157)
        Me.DTP_YEAR.Name = "DTP_YEAR"
        Me.DTP_YEAR.Size = New System.Drawing.Size(79, 20)
        Me.DTP_YEAR.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(21, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search Book:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(207, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Search Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(21, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Penalty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(429, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Month:"
        '
        'TB_PENALTY
        '
        Me.TB_PENALTY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PENALTY.Location = New System.Drawing.Point(24, 158)
        Me.TB_PENALTY.Multiline = True
        Me.TB_PENALTY.Name = "TB_PENALTY"
        Me.TB_PENALTY.Size = New System.Drawing.Size(152, 29)
        Me.TB_PENALTY.TabIndex = 14
        Me.TB_PENALTY.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(429, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Year:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(21, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Book Report:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(502, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Income Report:"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Black
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(782, 78)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(170, 47)
        Me.Button10.TabIndex = 18
        Me.Button10.Text = "BACK"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Reportfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(992, 499)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_PENALTY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_YEAR)
        Me.Controls.Add(Me.DTP_MONTH)
        Me.Controls.Add(Me.TB_BOOK)
        Me.Controls.Add(Me.TB_AUTHOR)
        Me.Controls.Add(Me.DGV_PENALTY)
        Me.Controls.Add(Me.DGV_MAIN)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reportfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportfrm"
        CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_PENALTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_MAIN As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_PENALTY As System.Windows.Forms.DataGridView
    Friend WithEvents TB_AUTHOR As System.Windows.Forms.TextBox
    Friend WithEvents TB_BOOK As System.Windows.Forms.TextBox
    Friend WithEvents DTP_MONTH As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_YEAR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_PENALTY As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
