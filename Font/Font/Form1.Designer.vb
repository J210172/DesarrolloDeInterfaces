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
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HolaLabel
        '
        Me.HolaLabel.AutoSize = True
        Me.HolaLabel.Location = New System.Drawing.Point(219, 81)
        Me.HolaLabel.Name = "HolaLabel"
        Me.HolaLabel.Size = New System.Drawing.Size(29, 13)
        Me.HolaLabel.TabIndex = 0
        Me.HolaLabel.Text = "Hola"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(222, 197)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 8
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(566, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.Value = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.HolaLabel)
        Me.Name = "Form1"
        Me.Text = "Font"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HolaLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
