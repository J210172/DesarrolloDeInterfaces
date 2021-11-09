<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.HolaLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.StylesGrBx = New System.Windows.Forms.GroupBox()
        Me.RegularChBx = New System.Windows.Forms.CheckBox()
        Me.StylesPnl = New System.Windows.Forms.Panel()
        Me.UnderlineChBx = New System.Windows.Forms.CheckBox()
        Me.ItalicChBx = New System.Windows.Forms.CheckBox()
        Me.StrikeoutChBx = New System.Windows.Forms.CheckBox()
        Me.BoldChBx = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StylesGrBx.SuspendLayout()
        Me.StylesPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'HolaLabel
        '
        Me.HolaLabel.AutoSize = True
        Me.HolaLabel.Location = New System.Drawing.Point(219, 9)
        Me.HolaLabel.Name = "HolaLabel"
        Me.HolaLabel.Size = New System.Drawing.Size(29, 13)
        Me.HolaLabel.TabIndex = 0
        Me.HolaLabel.Text = "Hola"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 353)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(140, 393)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 8
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(648, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.Value = 8
        '
        'StylesGrBx
        '
        Me.StylesGrBx.Controls.Add(Me.StylesPnl)
        Me.StylesGrBx.Controls.Add(Me.RegularChBx)
        Me.StylesGrBx.Location = New System.Drawing.Point(11, 312)
        Me.StylesGrBx.Margin = New System.Windows.Forms.Padding(2)
        Me.StylesGrBx.Name = "StylesGrBx"
        Me.StylesGrBx.Padding = New System.Windows.Forms.Padding(2)
        Me.StylesGrBx.Size = New System.Drawing.Size(124, 127)
        Me.StylesGrBx.TabIndex = 4
        Me.StylesGrBx.TabStop = False
        Me.StylesGrBx.Text = "Estilos"
        '
        'RegularChBx
        '
        Me.RegularChBx.AutoSize = True
        Me.RegularChBx.Checked = True
        Me.RegularChBx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegularChBx.Location = New System.Drawing.Point(9, 20)
        Me.RegularChBx.Margin = New System.Windows.Forms.Padding(2)
        Me.RegularChBx.Name = "RegularChBx"
        Me.RegularChBx.Size = New System.Drawing.Size(59, 17)
        Me.RegularChBx.TabIndex = 4
        Me.RegularChBx.Text = "Normal"
        Me.RegularChBx.UseVisualStyleBackColor = True
        '
        'StylesPnl
        '
        Me.StylesPnl.Controls.Add(Me.UnderlineChBx)
        Me.StylesPnl.Controls.Add(Me.ItalicChBx)
        Me.StylesPnl.Controls.Add(Me.StrikeoutChBx)
        Me.StylesPnl.Controls.Add(Me.BoldChBx)
        Me.StylesPnl.Location = New System.Drawing.Point(4, 39)
        Me.StylesPnl.Margin = New System.Windows.Forms.Padding(2)
        Me.StylesPnl.Name = "StylesPnl"
        Me.StylesPnl.Size = New System.Drawing.Size(87, 84)
        Me.StylesPnl.TabIndex = 9
        '
        'UnderlineChBx
        '
        Me.UnderlineChBx.AutoSize = True
        Me.UnderlineChBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnderlineChBx.Location = New System.Drawing.Point(5, 63)
        Me.UnderlineChBx.Margin = New System.Windows.Forms.Padding(2)
        Me.UnderlineChBx.Name = "UnderlineChBx"
        Me.UnderlineChBx.Size = New System.Drawing.Size(77, 17)
        Me.UnderlineChBx.TabIndex = 9
        Me.UnderlineChBx.Text = "Subrayada"
        Me.UnderlineChBx.UseVisualStyleBackColor = True
        '
        'ItalicChBx
        '
        Me.ItalicChBx.AutoSize = True
        Me.ItalicChBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalicChBx.Location = New System.Drawing.Point(5, 23)
        Me.ItalicChBx.Margin = New System.Windows.Forms.Padding(2)
        Me.ItalicChBx.Name = "ItalicChBx"
        Me.ItalicChBx.Size = New System.Drawing.Size(69, 17)
        Me.ItalicChBx.TabIndex = 10
        Me.ItalicChBx.Text = "Inclinada"
        Me.ItalicChBx.UseVisualStyleBackColor = True
        '
        'StrikeoutChBx
        '
        Me.StrikeoutChBx.AutoSize = True
        Me.StrikeoutChBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrikeoutChBx.Location = New System.Drawing.Point(5, 42)
        Me.StrikeoutChBx.Margin = New System.Windows.Forms.Padding(2)
        Me.StrikeoutChBx.Name = "StrikeoutChBx"
        Me.StrikeoutChBx.Size = New System.Drawing.Size(69, 17)
        Me.StrikeoutChBx.TabIndex = 11
        Me.StrikeoutChBx.Text = "Tachada"
        Me.StrikeoutChBx.UseVisualStyleBackColor = True
        '
        'BoldChBx
        '
        Me.BoldChBx.AutoSize = True
        Me.BoldChBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoldChBx.Location = New System.Drawing.Point(5, 6)
        Me.BoldChBx.Margin = New System.Windows.Forms.Padding(2)
        Me.BoldChBx.Name = "BoldChBx"
        Me.BoldChBx.Size = New System.Drawing.Size(67, 17)
        Me.BoldChBx.TabIndex = 12
        Me.BoldChBx.Text = "Negrita"
        Me.BoldChBx.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StylesGrBx)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.HolaLabel)
        Me.Name = "Form1"
        Me.Text = "Font"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StylesGrBx.ResumeLayout(False)
        Me.StylesGrBx.PerformLayout()
        Me.StylesPnl.ResumeLayout(False)
        Me.StylesPnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HolaLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents StylesGrBx As GroupBox
    Friend WithEvents RegularChBx As CheckBox
    Friend WithEvents StylesPnl As Panel
    Friend WithEvents UnderlineChBx As CheckBox
    Friend WithEvents ItalicChBx As CheckBox
    Friend WithEvents StrikeoutChBx As CheckBox
    Friend WithEvents BoldChBx As CheckBox
End Class
