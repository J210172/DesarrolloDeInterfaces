<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppBox = New System.Windows.Forms.Panel()
        Me.App4 = New System.Windows.Forms.CheckBox()
        Me.App3 = New System.Windows.Forms.CheckBox()
        Me.App2 = New System.Windows.Forms.CheckBox()
        Me.App1 = New System.Windows.Forms.CheckBox()
        Me.PanelSOs = New System.Windows.Forms.Panel()
        Me.NoneRButton = New System.Windows.Forms.RadioButton()
        Me.SO3Button = New System.Windows.Forms.RadioButton()
        Me.SO2Button = New System.Windows.Forms.RadioButton()
        Me.SO1Button = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OtherPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.AppBox.SuspendLayout()
        Me.PanelSOs.SuspendLayout()
        Me.OtherPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AppBox)
        Me.GroupBox1.Controls.Add(Me.PanelSOs)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 429)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AppBox
        '
        Me.AppBox.Controls.Add(Me.App4)
        Me.AppBox.Controls.Add(Me.App3)
        Me.AppBox.Controls.Add(Me.App2)
        Me.AppBox.Controls.Add(Me.App1)
        Me.AppBox.Location = New System.Drawing.Point(6, 123)
        Me.AppBox.Name = "AppBox"
        Me.AppBox.Size = New System.Drawing.Size(169, 300)
        Me.AppBox.TabIndex = 1
        '
        'App4
        '
        Me.App4.AutoSize = True
        Me.App4.Location = New System.Drawing.Point(12, 77)
        Me.App4.Name = "App4"
        Me.App4.Size = New System.Drawing.Size(81, 17)
        Me.App4.TabIndex = 3
        Me.App4.Text = "CheckBox4"
        Me.App4.UseVisualStyleBackColor = True
        '
        'App3
        '
        Me.App3.AutoSize = True
        Me.App3.Location = New System.Drawing.Point(12, 54)
        Me.App3.Name = "App3"
        Me.App3.Size = New System.Drawing.Size(81, 17)
        Me.App3.TabIndex = 2
        Me.App3.Text = "CheckBox3"
        Me.App3.UseVisualStyleBackColor = True
        '
        'App2
        '
        Me.App2.AutoSize = True
        Me.App2.Location = New System.Drawing.Point(12, 31)
        Me.App2.Name = "App2"
        Me.App2.Size = New System.Drawing.Size(81, 17)
        Me.App2.TabIndex = 1
        Me.App2.Text = "CheckBox2"
        Me.App2.UseVisualStyleBackColor = True
        '
        'App1
        '
        Me.App1.AutoSize = True
        Me.App1.Location = New System.Drawing.Point(12, 8)
        Me.App1.Name = "App1"
        Me.App1.Size = New System.Drawing.Size(81, 17)
        Me.App1.TabIndex = 0
        Me.App1.Text = "CheckBox1"
        Me.App1.UseVisualStyleBackColor = True
        '
        'PanelSOs
        '
        Me.PanelSOs.Controls.Add(Me.NoneRButton)
        Me.PanelSOs.Controls.Add(Me.SO3Button)
        Me.PanelSOs.Controls.Add(Me.SO2Button)
        Me.PanelSOs.Controls.Add(Me.SO1Button)
        Me.PanelSOs.Location = New System.Drawing.Point(6, 19)
        Me.PanelSOs.Name = "PanelSOs"
        Me.PanelSOs.Size = New System.Drawing.Size(169, 98)
        Me.PanelSOs.TabIndex = 0
        '
        'NoneRButton
        '
        Me.NoneRButton.AutoSize = True
        Me.NoneRButton.Location = New System.Drawing.Point(12, 72)
        Me.NoneRButton.Name = "NoneRButton"
        Me.NoneRButton.Size = New System.Drawing.Size(65, 17)
        Me.NoneRButton.TabIndex = 3
        Me.NoneRButton.TabStop = True
        Me.NoneRButton.Text = "Ninguno"
        Me.NoneRButton.UseVisualStyleBackColor = True
        '
        'SO3Button
        '
        Me.SO3Button.AutoSize = True
        Me.SO3Button.Location = New System.Drawing.Point(12, 49)
        Me.SO3Button.Name = "SO3Button"
        Me.SO3Button.Size = New System.Drawing.Size(46, 17)
        Me.SO3Button.TabIndex = 2
        Me.SO3Button.TabStop = True
        Me.SO3Button.Text = "Mac"
        Me.SO3Button.UseVisualStyleBackColor = True
        '
        'SO2Button
        '
        Me.SO2Button.AutoSize = True
        Me.SO2Button.Location = New System.Drawing.Point(12, 26)
        Me.SO2Button.Name = "SO2Button"
        Me.SO2Button.Size = New System.Drawing.Size(50, 17)
        Me.SO2Button.TabIndex = 1
        Me.SO2Button.TabStop = True
        Me.SO2Button.Text = "Linux"
        Me.SO2Button.UseVisualStyleBackColor = True
        '
        'SO1Button
        '
        Me.SO1Button.AutoSize = True
        Me.SO1Button.Location = New System.Drawing.Point(12, 3)
        Me.SO1Button.Name = "SO1Button"
        Me.SO1Button.Size = New System.Drawing.Size(64, 17)
        Me.SO1Button.TabIndex = 0
        Me.SO1Button.TabStop = True
        Me.SO1Button.Text = "Window"
        Me.SO1Button.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 338)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 338)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(423, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(15, 331)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(305, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(271, 329)
        Me.ListBox2.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(268, 329)
        Me.ListBox1.TabIndex = 8
        '
        'OtherPanel
        '
        Me.OtherPanel.Controls.Add(Me.Label2)
        Me.OtherPanel.Controls.Add(Me.TextBox2)
        Me.OtherPanel.Controls.Add(Me.TextBox1)
        Me.OtherPanel.Controls.Add(Me.Label1)
        Me.OtherPanel.Controls.Add(Me.Button1)
        Me.OtherPanel.Controls.Add(Me.ListBox2)
        Me.OtherPanel.Controls.Add(Me.ListBox1)
        Me.OtherPanel.Location = New System.Drawing.Point(204, 10)
        Me.OtherPanel.Name = "OtherPanel"
        Me.OtherPanel.Size = New System.Drawing.Size(584, 424)
        Me.OtherPanel.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Precio Total:"
        '
        'P1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OtherPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "P1"
        Me.Text = "P1"
        Me.GroupBox1.ResumeLayout(False)
        Me.AppBox.ResumeLayout(False)
        Me.AppBox.PerformLayout()
        Me.PanelSOs.ResumeLayout(False)
        Me.PanelSOs.PerformLayout()
        Me.OtherPanel.ResumeLayout(False)
        Me.OtherPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AppBox As Panel
    Friend WithEvents PanelSOs As Panel
    Friend WithEvents NoneRButton As RadioButton
    Friend WithEvents SO3Button As RadioButton
    Friend WithEvents SO2Button As RadioButton
    Friend WithEvents SO1Button As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents App4 As CheckBox
    Friend WithEvents App3 As CheckBox
    Friend WithEvents App2 As CheckBox
    Friend WithEvents App1 As CheckBox
    Friend WithEvents OtherPanel As Panel
    Protected WithEvents Label2 As Label
End Class
