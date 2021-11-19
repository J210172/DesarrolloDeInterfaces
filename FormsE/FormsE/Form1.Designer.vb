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
        Me.ResetColor = New System.Windows.Forms.Button()
        Me.Texto = New System.Windows.Forms.Label()
        Me.OpcionesAplColor = New System.Windows.Forms.GroupBox()
        Me.PanelGroup = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboFuentes = New System.Windows.Forms.ComboBox()
        Me.BarraTamano = New System.Windows.Forms.TrackBar()
        Me.RadioFuente = New System.Windows.Forms.RadioButton()
        Me.RadioFondo = New System.Windows.Forms.RadioButton()
        Me.OpcionesAplColor.SuspendLayout()
        Me.PanelGroup.SuspendLayout()
        CType(Me.BarraTamano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetColor
        '
        Me.ResetColor.Location = New System.Drawing.Point(454, 41)
        Me.ResetColor.Name = "ResetColor"
        Me.ResetColor.Size = New System.Drawing.Size(75, 23)
        Me.ResetColor.TabIndex = 0
        Me.ResetColor.Text = "Button1"
        Me.ResetColor.UseVisualStyleBackColor = True
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Location = New System.Drawing.Point(88, 91)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(39, 13)
        Me.Texto.TabIndex = 1
        Me.Texto.Text = "Label1"
        '
        'OpcionesAplColor
        '
        Me.OpcionesAplColor.Controls.Add(Me.RadioFondo)
        Me.OpcionesAplColor.Controls.Add(Me.RadioFuente)
        Me.OpcionesAplColor.Location = New System.Drawing.Point(570, 12)
        Me.OpcionesAplColor.Name = "OpcionesAplColor"
        Me.OpcionesAplColor.Size = New System.Drawing.Size(200, 68)
        Me.OpcionesAplColor.TabIndex = 2
        Me.OpcionesAplColor.TabStop = False
        Me.OpcionesAplColor.Text = "GroupBox1"
        '
        'PanelGroup
        '
        Me.PanelGroup.Controls.Add(Me.Panel4)
        Me.PanelGroup.Controls.Add(Me.Panel3)
        Me.PanelGroup.Controls.Add(Me.Panel2)
        Me.PanelGroup.Controls.Add(Me.Panel1)
        Me.PanelGroup.Location = New System.Drawing.Point(423, 121)
        Me.PanelGroup.Name = "PanelGroup"
        Me.PanelGroup.Size = New System.Drawing.Size(347, 292)
        Me.PanelGroup.TabIndex = 3
        Me.PanelGroup.TabStop = False
        Me.PanelGroup.Text = "GroupBox2"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(196, 172)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(124, 85)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(40, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 85)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(196, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 85)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(40, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 85)
        Me.Panel1.TabIndex = 0
        '
        'ComboFuentes
        '
        Me.ComboFuentes.FormattingEnabled = True
        Me.ComboFuentes.Location = New System.Drawing.Point(123, 357)
        Me.ComboFuentes.Name = "ComboFuentes"
        Me.ComboFuentes.Size = New System.Drawing.Size(149, 21)
        Me.ComboFuentes.TabIndex = 4
        '
        'BarraTamano
        '
        Me.BarraTamano.Location = New System.Drawing.Point(26, 21)
        Me.BarraTamano.Maximum = 50
        Me.BarraTamano.Minimum = 8
        Me.BarraTamano.Name = "BarraTamano"
        Me.BarraTamano.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.BarraTamano.Size = New System.Drawing.Size(45, 392)
        Me.BarraTamano.TabIndex = 5
        Me.BarraTamano.Value = 8
        '
        'RadioFuente
        '
        Me.RadioFuente.AutoSize = True
        Me.RadioFuente.Checked = True
        Me.RadioFuente.Location = New System.Drawing.Point(16, 19)
        Me.RadioFuente.Name = "RadioFuente"
        Me.RadioFuente.Size = New System.Drawing.Size(58, 17)
        Me.RadioFuente.TabIndex = 0
        Me.RadioFuente.TabStop = True
        Me.RadioFuente.Text = "Fuente"
        Me.RadioFuente.UseVisualStyleBackColor = True
        '
        'RadioFondo
        '
        Me.RadioFondo.AutoSize = True
        Me.RadioFondo.Location = New System.Drawing.Point(16, 42)
        Me.RadioFondo.Name = "RadioFondo"
        Me.RadioFondo.Size = New System.Drawing.Size(55, 17)
        Me.RadioFondo.TabIndex = 1
        Me.RadioFondo.TabStop = True
        Me.RadioFondo.Text = "Fondo"
        Me.RadioFondo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BarraTamano)
        Me.Controls.Add(Me.ComboFuentes)
        Me.Controls.Add(Me.PanelGroup)
        Me.Controls.Add(Me.OpcionesAplColor)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.ResetColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.OpcionesAplColor.ResumeLayout(False)
        Me.OpcionesAplColor.PerformLayout()
        Me.PanelGroup.ResumeLayout(False)
        CType(Me.BarraTamano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResetColor As Button
    Friend WithEvents Texto As Label
    Friend WithEvents OpcionesAplColor As GroupBox
    Friend WithEvents PanelGroup As GroupBox
    Friend WithEvents ComboFuentes As ComboBox
    Friend WithEvents BarraTamano As TrackBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioFondo As RadioButton
    Friend WithEvents RadioFuente As RadioButton
End Class
