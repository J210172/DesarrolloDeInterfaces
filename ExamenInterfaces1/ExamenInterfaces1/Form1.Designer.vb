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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NoneRButton = New System.Windows.Forms.RadioButton()
        Me.SO3Button = New System.Windows.Forms.RadioButton()
        Me.SO2Button = New System.Windows.Forms.RadioButton()
        Me.SO1Button = New System.Windows.Forms.RadioButton()
        Me.PanelSOs = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.App4 = New System.Windows.Forms.CheckBox()
        Me.App3 = New System.Windows.Forms.CheckBox()
        Me.App2 = New System.Windows.Forms.CheckBox()
        Me.App1 = New System.Windows.Forms.CheckBox()
        Me.AppBox = New System.Windows.Forms.Panel()
        Me.OtherPanel = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelSOs.SuspendLayout()
        Me.AppBox.SuspendLayout()
        Me.OtherPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total €:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 354)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(15, 331)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(268, 329)
        Me.ListBox1.TabIndex = 8
        '
        'NoneRButton
        '
        Me.NoneRButton.AutoSize = True
        Me.NoneRButton.Location = New System.Drawing.Point(11, 92)
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
        Me.SO2Button.Size = New System.Drawing.Size(87, 17)
        Me.SO2Button.TabIndex = 1
        Me.SO2Button.TabStop = True
        Me.SO2Button.Text = "Ubuntu (20€)"
        Me.SO2Button.UseVisualStyleBackColor = True
        '
        'SO1Button
        '
        Me.SO1Button.AutoSize = True
        Me.SO1Button.Location = New System.Drawing.Point(12, 3)
        Me.SO1Button.Name = "SO1Button"
        Me.SO1Button.Size = New System.Drawing.Size(97, 17)
        Me.SO1Button.TabIndex = 0
        Me.SO1Button.TabStop = True
        Me.SO1Button.Text = "Window (100€)"
        Me.SO1Button.UseVisualStyleBackColor = True
        '
        'PanelSOs
        '
        Me.PanelSOs.Controls.Add(Me.RadioButton1)
        Me.PanelSOs.Controls.Add(Me.NoneRButton)
        Me.PanelSOs.Controls.Add(Me.SO3Button)
        Me.PanelSOs.Controls.Add(Me.SO2Button)
        Me.PanelSOs.Controls.Add(Me.SO1Button)
        Me.PanelSOs.Location = New System.Drawing.Point(6, 43)
        Me.PanelSOs.Name = "PanelSOs"
        Me.PanelSOs.Size = New System.Drawing.Size(169, 112)
        Me.PanelSOs.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(11, 72)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mac"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'App4
        '
        Me.App4.AutoSize = True
        Me.App4.Location = New System.Drawing.Point(12, 77)
        Me.App4.Name = "App4"
        Me.App4.Size = New System.Drawing.Size(125, 17)
        Me.App4.TabIndex = 3
        Me.App4.Text = "Dreamweaver (200€)"
        Me.App4.UseVisualStyleBackColor = True
        '
        'App3
        '
        Me.App3.AutoSize = True
        Me.App3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.App3.Location = New System.Drawing.Point(12, 54)
        Me.App3.Name = "App3"
        Me.App3.Size = New System.Drawing.Size(122, 17)
        Me.App3.TabIndex = 2
        Me.App3.Text = "Android Studio (20€)"
        Me.App3.UseVisualStyleBackColor = True
        '
        'App2
        '
        Me.App2.AutoSize = True
        Me.App2.Location = New System.Drawing.Point(12, 31)
        Me.App2.Name = "App2"
        Me.App2.Size = New System.Drawing.Size(117, 17)
        Me.App2.TabIndex = 1
        Me.App2.Text = "Visual Studio(400€)"
        Me.App2.UseVisualStyleBackColor = True
        '
        'App1
        '
        Me.App1.AutoSize = True
        Me.App1.Location = New System.Drawing.Point(12, 8)
        Me.App1.Name = "App1"
        Me.App1.Size = New System.Drawing.Size(87, 17)
        Me.App1.TabIndex = 0
        Me.App1.Text = "Eclipse (20€)"
        Me.App1.UseVisualStyleBackColor = True
        '
        'AppBox
        '
        Me.AppBox.Controls.Add(Me.CheckBox1)
        Me.AppBox.Controls.Add(Me.App4)
        Me.AppBox.Controls.Add(Me.App3)
        Me.AppBox.Controls.Add(Me.App2)
        Me.AppBox.Controls.Add(Me.App1)
        Me.AppBox.Location = New System.Drawing.Point(6, 181)
        Me.AppBox.Name = "AppBox"
        Me.AppBox.Size = New System.Drawing.Size(169, 126)
        Me.AppBox.TabIndex = 1
        '
        'OtherPanel
        '
        Me.OtherPanel.Controls.Add(Me.TextBox4)
        Me.OtherPanel.Controls.Add(Me.AddButton)
        Me.OtherPanel.Controls.Add(Me.Label4)
        Me.OtherPanel.Controls.Add(Me.Label1)
        Me.OtherPanel.Controls.Add(Me.TextBox3)
        Me.OtherPanel.Controls.Add(Me.Label2)
        Me.OtherPanel.Controls.Add(Me.TextBox2)
        Me.OtherPanel.Controls.Add(Me.TextBox1)
        Me.OtherPanel.Controls.Add(Me.Button1)
        Me.OtherPanel.Controls.Add(Me.ListBox1)
        Me.OtherPanel.Location = New System.Drawing.Point(202, 37)
        Me.OtherPanel.Name = "OtherPanel"
        Me.OtherPanel.Size = New System.Drawing.Size(584, 409)
        Me.OtherPanel.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(310, 19)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(271, 329)
        Me.TextBox4.TabIndex = 19
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(43, 380)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(215, 26)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Button2"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(307, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Resumen de servicios de instalacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Aplicaciones de usuario"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(407, 354)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(95, 20)
        Me.TextBox3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.AppBox)
        Me.GroupBox1.Controls.Add(Me.PanelSOs)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 307)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Software Basico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(124, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(538, 31)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Configuracion Del Software Del Dispositivo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 100)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "NetBeans (10€)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(45, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sistema Operativos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(45, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Sw de desarrollo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OtherPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelSOs.ResumeLayout(False)
        Me.PanelSOs.PerformLayout()
        Me.AppBox.ResumeLayout(False)
        Me.AppBox.PerformLayout()
        Me.OtherPanel.ResumeLayout(False)
        Me.OtherPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NoneRButton As RadioButton
    Friend WithEvents SO3Button As RadioButton
    Friend WithEvents SO2Button As RadioButton
    Friend WithEvents SO1Button As RadioButton
    Friend WithEvents PanelSOs As Panel
    Friend WithEvents App4 As CheckBox
    Friend WithEvents App3 As CheckBox
    Friend WithEvents App2 As CheckBox
    Friend WithEvents App1 As CheckBox
    Friend WithEvents AppBox As Panel
    Friend WithEvents OtherPanel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
