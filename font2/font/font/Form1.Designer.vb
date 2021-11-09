<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Grbx_estilos = New System.Windows.Forms.GroupBox()
        Me.Pnl_estilos = New System.Windows.Forms.Panel()
        Me.Chk_inclinada = New System.Windows.Forms.CheckBox()
        Me.Chk_subrayada = New System.Windows.Forms.CheckBox()
        Me.Chk_negrita = New System.Windows.Forms.CheckBox()
        Me.Chk_tachada = New System.Windows.Forms.CheckBox()
        Me.Chk_normal = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbx_estilos.SuspendLayout()
        Me.Pnl_estilos.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTexto
        '
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Location = New System.Drawing.Point(248, 61)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(37, 17)
        Me.LblTexto.TabIndex = 0
        Me.LblTexto.Text = "Hola"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(251, 265)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(313, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(251, 203)
        Me.TrackBar1.Maximum = 80
        Me.TrackBar1.Minimum = 8
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(313, 56)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 8
        '
        'Grbx_estilos
        '
        Me.Grbx_estilos.Controls.Add(Me.Pnl_estilos)
        Me.Grbx_estilos.Controls.Add(Me.Chk_normal)
        Me.Grbx_estilos.Location = New System.Drawing.Point(41, 92)
        Me.Grbx_estilos.Name = "Grbx_estilos"
        Me.Grbx_estilos.Size = New System.Drawing.Size(165, 167)
        Me.Grbx_estilos.TabIndex = 3
        Me.Grbx_estilos.TabStop = False
        Me.Grbx_estilos.Text = "Estilos"
        '
        'Pnl_estilos
        '
        Me.Pnl_estilos.Controls.Add(Me.Chk_inclinada)
        Me.Pnl_estilos.Controls.Add(Me.Chk_subrayada)
        Me.Pnl_estilos.Controls.Add(Me.Chk_negrita)
        Me.Pnl_estilos.Controls.Add(Me.Chk_tachada)
        Me.Pnl_estilos.Location = New System.Drawing.Point(13, 48)
        Me.Pnl_estilos.Name = "Pnl_estilos"
        Me.Pnl_estilos.Size = New System.Drawing.Size(116, 95)
        Me.Pnl_estilos.TabIndex = 4
        '
        'Chk_inclinada
        '
        Me.Chk_inclinada.AutoSize = True
        Me.Chk_inclinada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_inclinada.Location = New System.Drawing.Point(3, 24)
        Me.Chk_inclinada.Name = "Chk_inclinada"
        Me.Chk_inclinada.Size = New System.Drawing.Size(86, 21)
        Me.Chk_inclinada.TabIndex = 4
        Me.Chk_inclinada.Text = "Inclinada"
        Me.Chk_inclinada.UseVisualStyleBackColor = True
        '
        'Chk_subrayada
        '
        Me.Chk_subrayada.AutoSize = True
        Me.Chk_subrayada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_subrayada.Location = New System.Drawing.Point(3, 47)
        Me.Chk_subrayada.Name = "Chk_subrayada"
        Me.Chk_subrayada.Size = New System.Drawing.Size(99, 21)
        Me.Chk_subrayada.TabIndex = 4
        Me.Chk_subrayada.Text = "Subrayada"
        Me.Chk_subrayada.UseVisualStyleBackColor = True
        '
        'Chk_negrita
        '
        Me.Chk_negrita.AutoSize = True
        Me.Chk_negrita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_negrita.Location = New System.Drawing.Point(3, 2)
        Me.Chk_negrita.Name = "Chk_negrita"
        Me.Chk_negrita.Size = New System.Drawing.Size(83, 21)
        Me.Chk_negrita.TabIndex = 4
        Me.Chk_negrita.Text = "Negrita"
        Me.Chk_negrita.UseVisualStyleBackColor = True
        '
        'Chk_tachada
        '
        Me.Chk_tachada.AutoSize = True
        Me.Chk_tachada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_tachada.Location = New System.Drawing.Point(3, 72)
        Me.Chk_tachada.Name = "Chk_tachada"
        Me.Chk_tachada.Size = New System.Drawing.Size(86, 21)
        Me.Chk_tachada.TabIndex = 4
        Me.Chk_tachada.Text = "Tachada"
        Me.Chk_tachada.UseVisualStyleBackColor = True
        '
        'Chk_normal
        '
        Me.Chk_normal.AutoSize = True
        Me.Chk_normal.Checked = True
        Me.Chk_normal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_normal.Location = New System.Drawing.Point(16, 25)
        Me.Chk_normal.Name = "Chk_normal"
        Me.Chk_normal.Size = New System.Drawing.Size(75, 21)
        Me.Chk_normal.TabIndex = 4
        Me.Chk_normal.Text = "Normal"
        Me.Chk_normal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 346)
        Me.Controls.Add(Me.Grbx_estilos)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblTexto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbx_estilos.ResumeLayout(False)
        Me.Grbx_estilos.PerformLayout()
        Me.Pnl_estilos.ResumeLayout(False)
        Me.Pnl_estilos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTexto As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Grbx_estilos As GroupBox
    Friend WithEvents Pnl_estilos As Panel
    Friend WithEvents Chk_inclinada As CheckBox
    Friend WithEvents Chk_subrayada As CheckBox
    Friend WithEvents Chk_negrita As CheckBox
    Friend WithEvents Chk_tachada As CheckBox
    Friend WithEvents Chk_normal As CheckBox
End Class
