<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advancesearch
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
        Me.DGV_ADVANCESEARCH = New System.Windows.Forms.DataGridView()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TB_ADVSEARCH = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.DGV_ADVANCESEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_ADVANCESEARCH
        '
        Me.DGV_ADVANCESEARCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ADVANCESEARCH.BackgroundColor = System.Drawing.Color.White
        Me.DGV_ADVANCESEARCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ADVANCESEARCH.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGV_ADVANCESEARCH.Location = New System.Drawing.Point(11, 120)
        Me.DGV_ADVANCESEARCH.Name = "DGV_ADVANCESEARCH"
        Me.DGV_ADVANCESEARCH.RowHeadersVisible = False
        Me.DGV_ADVANCESEARCH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_ADVANCESEARCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ADVANCESEARCH.Size = New System.Drawing.Size(691, 257)
        Me.DGV_ADVANCESEARCH.TabIndex = 0
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Black
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(522, 67)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(170, 47)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "SELECT"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'TB_ADVSEARCH
        '
        Me.TB_ADVSEARCH.BackColor = System.Drawing.Color.White
        Me.TB_ADVSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_ADVSEARCH.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ADVSEARCH.ForeColor = System.Drawing.Color.White
        Me.TB_ADVSEARCH.HintForeColor = System.Drawing.Color.Black
        Me.TB_ADVSEARCH.HintText = "SEARCH"
        Me.TB_ADVSEARCH.isPassword = False
        Me.TB_ADVSEARCH.LineFocusedColor = System.Drawing.Color.Black
        Me.TB_ADVSEARCH.LineIdleColor = System.Drawing.Color.Black
        Me.TB_ADVSEARCH.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TB_ADVSEARCH.LineThickness = 3
        Me.TB_ADVSEARCH.Location = New System.Drawing.Point(11, 67)
        Me.TB_ADVSEARCH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TB_ADVSEARCH.Name = "TB_ADVSEARCH"
        Me.TB_ADVSEARCH.Size = New System.Drawing.Size(229, 40)
        Me.TB_ADVSEARCH.TabIndex = 20
        Me.TB_ADVSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(260, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(259, 32)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "ADVANCE SEARCH"
        '
        'advancesearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(714, 389)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TB_ADVSEARCH)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.DGV_ADVANCESEARCH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "advancesearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADVANCE SEARCH"
        CType(Me.DGV_ADVANCESEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_ADVANCESEARCH As System.Windows.Forms.DataGridView
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TB_ADVSEARCH As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
