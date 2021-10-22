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
        Me.Title = New System.Windows.Forms.Label()
        Me.ColorListBox = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorInputTextBox = New System.Windows.Forms.TextBox()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.CarButton = New System.Windows.Forms.Button()
        Me.CarInputTextBox = New System.Windows.Forms.TextBox()
        Me.CarListBox = New System.Windows.Forms.ListBox()
        Me.CarTitle = New System.Windows.Forms.Label()
        Me.MarcaButton = New System.Windows.Forms.Button()
        Me.MarcaInputTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaListBox = New System.Windows.Forms.ListBox()
        Me.MarcaTitle = New System.Windows.Forms.Label()
        Me.RemoveButton1 = New System.Windows.Forms.Button()
        Me.RemoveButton2 = New System.Windows.Forms.Button()
        Me.RemoveButton3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(37, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(203, 34)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Lista de Colores"
        '
        'ColorListBox
        '
        Me.ColorListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColorListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorListBox.FormattingEnabled = True
        Me.ColorListBox.ItemHeight = 16
        Me.ColorListBox.Location = New System.Drawing.Point(43, 62)
        Me.ColorListBox.Name = "ColorListBox"
        Me.ColorListBox.Size = New System.Drawing.Size(182, 208)
        Me.ColorListBox.Sorted = True
        Me.ColorListBox.TabIndex = 1
        '
        'ColorInputTextBox
        '
        Me.ColorInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorInputTextBox.ForeColor = System.Drawing.Color.Black
        Me.ColorInputTextBox.Location = New System.Drawing.Point(43, 342)
        Me.ColorInputTextBox.Name = "ColorInputTextBox"
        Me.ColorInputTextBox.Size = New System.Drawing.Size(159, 23)
        Me.ColorInputTextBox.TabIndex = 2
        '
        'ColorButton
        '
        Me.ColorButton.AutoSize = True
        Me.ColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.Location = New System.Drawing.Point(43, 313)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(75, 27)
        Me.ColorButton.TabIndex = 3
        Me.ColorButton.Text = "Agregar"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'CarButton
        '
        Me.CarButton.AutoSize = True
        Me.CarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarButton.Location = New System.Drawing.Point(536, 309)
        Me.CarButton.Name = "CarButton"
        Me.CarButton.Size = New System.Drawing.Size(75, 27)
        Me.CarButton.TabIndex = 7
        Me.CarButton.Text = "Agregar"
        Me.CarButton.UseVisualStyleBackColor = True
        '
        'CarInputTextBox
        '
        Me.CarInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarInputTextBox.ForeColor = System.Drawing.Color.Black
        Me.CarInputTextBox.Location = New System.Drawing.Point(536, 342)
        Me.CarInputTextBox.Name = "CarInputTextBox"
        Me.CarInputTextBox.Size = New System.Drawing.Size(159, 23)
        Me.CarInputTextBox.TabIndex = 6
        '
        'CarListBox
        '
        Me.CarListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CarListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarListBox.FormattingEnabled = True
        Me.CarListBox.ItemHeight = 16
        Me.CarListBox.Location = New System.Drawing.Point(536, 62)
        Me.CarListBox.Name = "CarListBox"
        Me.CarListBox.Size = New System.Drawing.Size(182, 208)
        Me.CarListBox.Sorted = True
        Me.CarListBox.TabIndex = 5
        '
        'CarTitle
        '
        Me.CarTitle.AutoSize = True
        Me.CarTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarTitle.Location = New System.Drawing.Point(530, 9)
        Me.CarTitle.Name = "CarTitle"
        Me.CarTitle.Size = New System.Drawing.Size(203, 34)
        Me.CarTitle.TabIndex = 4
        Me.CarTitle.Text = "Lista de Colores"
        '
        'MarcaButton
        '
        Me.MarcaButton.AutoSize = True
        Me.MarcaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaButton.Location = New System.Drawing.Point(295, 309)
        Me.MarcaButton.Name = "MarcaButton"
        Me.MarcaButton.Size = New System.Drawing.Size(75, 27)
        Me.MarcaButton.TabIndex = 11
        Me.MarcaButton.Text = "Agregar"
        Me.MarcaButton.UseVisualStyleBackColor = True
        '
        'MarcaInputTextBox
        '
        Me.MarcaInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaInputTextBox.ForeColor = System.Drawing.Color.Black
        Me.MarcaInputTextBox.Location = New System.Drawing.Point(295, 342)
        Me.MarcaInputTextBox.Name = "MarcaInputTextBox"
        Me.MarcaInputTextBox.Size = New System.Drawing.Size(159, 23)
        Me.MarcaInputTextBox.TabIndex = 10
        '
        'MarcaListBox
        '
        Me.MarcaListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MarcaListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaListBox.FormattingEnabled = True
        Me.MarcaListBox.ItemHeight = 16
        Me.MarcaListBox.Location = New System.Drawing.Point(295, 62)
        Me.MarcaListBox.Name = "MarcaListBox"
        Me.MarcaListBox.Size = New System.Drawing.Size(182, 208)
        Me.MarcaListBox.Sorted = True
        Me.MarcaListBox.TabIndex = 9
        '
        'MarcaTitle
        '
        Me.MarcaTitle.AutoSize = True
        Me.MarcaTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaTitle.Location = New System.Drawing.Point(289, 9)
        Me.MarcaTitle.Name = "MarcaTitle"
        Me.MarcaTitle.Size = New System.Drawing.Size(203, 34)
        Me.MarcaTitle.TabIndex = 8
        Me.MarcaTitle.Text = "Lista de Colores"
        '
        'RemoveButton1
        '
        Me.RemoveButton1.AutoSize = True
        Me.RemoveButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton1.Location = New System.Drawing.Point(150, 276)
        Me.RemoveButton1.Name = "RemoveButton1"
        Me.RemoveButton1.Size = New System.Drawing.Size(75, 27)
        Me.RemoveButton1.TabIndex = 12
        Me.RemoveButton1.Text = "Eliminar"
        Me.RemoveButton1.UseVisualStyleBackColor = True
        '
        'RemoveButton2
        '
        Me.RemoveButton2.AutoSize = True
        Me.RemoveButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton2.Location = New System.Drawing.Point(402, 276)
        Me.RemoveButton2.Name = "RemoveButton2"
        Me.RemoveButton2.Size = New System.Drawing.Size(75, 27)
        Me.RemoveButton2.TabIndex = 13
        Me.RemoveButton2.Text = "Eliminar"
        Me.RemoveButton2.UseVisualStyleBackColor = True
        '
        'RemoveButton3
        '
        Me.RemoveButton3.AutoSize = True
        Me.RemoveButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton3.Location = New System.Drawing.Point(643, 276)
        Me.RemoveButton3.Name = "RemoveButton3"
        Me.RemoveButton3.Size = New System.Drawing.Size(75, 27)
        Me.RemoveButton3.TabIndex = 14
        Me.RemoveButton3.Text = "Eliminar"
        Me.RemoveButton3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.RemoveButton3)
        Me.Controls.Add(Me.RemoveButton2)
        Me.Controls.Add(Me.RemoveButton1)
        Me.Controls.Add(Me.MarcaButton)
        Me.Controls.Add(Me.MarcaInputTextBox)
        Me.Controls.Add(Me.MarcaListBox)
        Me.Controls.Add(Me.MarcaTitle)
        Me.Controls.Add(Me.CarButton)
        Me.Controls.Add(Me.CarInputTextBox)
        Me.Controls.Add(Me.CarListBox)
        Me.Controls.Add(Me.CarTitle)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.ColorInputTextBox)
        Me.Controls.Add(Me.ColorListBox)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents ColorListBox As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorInputTextBox As TextBox
    Friend WithEvents ColorButton As Button
    Friend WithEvents CarButton As Button
    Friend WithEvents CarInputTextBox As TextBox
    Friend WithEvents CarListBox As ListBox
    Friend WithEvents CarTitle As Label
    Friend WithEvents MarcaButton As Button
    Friend WithEvents MarcaInputTextBox As TextBox
    Friend WithEvents MarcaListBox As ListBox
    Friend WithEvents MarcaTitle As Label
    Friend WithEvents RemoveButton1 As Button
    Friend WithEvents RemoveButton2 As Button
    Friend WithEvents RemoveButton3 As Button
End Class
