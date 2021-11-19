<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Form3Button = New System.Windows.Forms.Button()
        Me.Form1Button = New System.Windows.Forms.Button()
        Me.Form2Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Form3Button
        '
        Me.Form3Button.AutoSize = True
        Me.Form3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Form3Button.Location = New System.Drawing.Point(25, 278)
        Me.Form3Button.Name = "Form3Button"
        Me.Form3Button.Size = New System.Drawing.Size(170, 47)
        Me.Form3Button.TabIndex = 5
        Me.Form3Button.Text = "Practica 3"
        Me.Form3Button.UseVisualStyleBackColor = True
        '
        'Form1Button
        '
        Me.Form1Button.AutoSize = True
        Me.Form1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Form1Button.Location = New System.Drawing.Point(25, 44)
        Me.Form1Button.Name = "Form1Button"
        Me.Form1Button.Size = New System.Drawing.Size(168, 47)
        Me.Form1Button.TabIndex = 3
        Me.Form1Button.Text = "Practica 1"
        Me.Form1Button.UseVisualStyleBackColor = True
        '
        'Form2Button
        '
        Me.Form2Button.AutoSize = True
        Me.Form2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Form2Button.Location = New System.Drawing.Point(25, 155)
        Me.Form2Button.Name = "Form2Button"
        Me.Form2Button.Size = New System.Drawing.Size(170, 47)
        Me.Form2Button.TabIndex = 4
        Me.Form2Button.Text = "Practica 2"
        Me.Form2Button.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 373)
        Me.Controls.Add(Me.Form3Button)
        Me.Controls.Add(Me.Form2Button)
        Me.Controls.Add(Me.Form1Button)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Form3Button As Button
    Friend WithEvents Form1Button As Button
    Friend WithEvents Form2Button As Button
End Class
