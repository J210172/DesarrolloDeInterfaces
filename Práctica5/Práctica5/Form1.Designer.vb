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
        Me.LeftList = New System.Windows.Forms.ListBox()
        Me.LeftClearListButton = New System.Windows.Forms.Button()
        Me.LeftText = New System.Windows.Forms.TextBox()
        Me.MidClearListButton = New System.Windows.Forms.Button()
        Me.MidList = New System.Windows.Forms.ListBox()
        Me.MidText = New System.Windows.Forms.TextBox()
        Me.BtnPasarIzqCen = New System.Windows.Forms.Button()
        Me.BtnPasarCenIzq = New System.Windows.Forms.Button()
        Me.BtnPasarDerCen = New System.Windows.Forms.Button()
        Me.BtnPasarCenDer = New System.Windows.Forms.Button()
        Me.RightText = New System.Windows.Forms.TextBox()
        Me.RightList = New System.Windows.Forms.ListBox()
        Me.RightClearListButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LeftList
        '
        Me.LeftList.AllowDrop = True
        Me.LeftList.FormattingEnabled = True
        Me.LeftList.ItemHeight = 15
        Me.LeftList.Items.AddRange(New Object() {"2", "3", "5", "7", "11", "13", "17", "19", "23"})
        Me.LeftList.Location = New System.Drawing.Point(43, 93)
        Me.LeftList.Name = "LeftList"
        Me.LeftList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LeftList.Size = New System.Drawing.Size(138, 184)
        Me.LeftList.TabIndex = 0
        '
        'LeftClearListButton
        '
        Me.LeftClearListButton.Location = New System.Drawing.Point(43, 64)
        Me.LeftClearListButton.Name = "LeftClearListButton"
        Me.LeftClearListButton.Size = New System.Drawing.Size(138, 23)
        Me.LeftClearListButton.TabIndex = 1
        Me.LeftClearListButton.Text = "Borrar Lista"
        Me.LeftClearListButton.UseVisualStyleBackColor = True
        '
        'LeftText
        '
        Me.LeftText.Location = New System.Drawing.Point(43, 283)
        Me.LeftText.Name = "LeftText"
        Me.LeftText.Size = New System.Drawing.Size(138, 23)
        Me.LeftText.TabIndex = 2
        '
        'MidClearListButton
        '
        Me.MidClearListButton.Location = New System.Drawing.Point(283, 64)
        Me.MidClearListButton.Name = "MidClearListButton"
        Me.MidClearListButton.Size = New System.Drawing.Size(140, 23)
        Me.MidClearListButton.TabIndex = 3
        Me.MidClearListButton.Text = "Borrar Lista"
        Me.MidClearListButton.UseVisualStyleBackColor = True
        '
        'MidList
        '
        Me.MidList.AllowDrop = True
        Me.MidList.FormattingEnabled = True
        Me.MidList.ItemHeight = 15
        Me.MidList.Items.AddRange(New Object() {"Yellow", "Green", "Blue", "Pink", "Lime", "Cyan", "Orange", "Red"})
        Me.MidList.Location = New System.Drawing.Point(283, 93)
        Me.MidList.Name = "MidList"
        Me.MidList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.MidList.Size = New System.Drawing.Size(140, 184)
        Me.MidList.TabIndex = 4
        '
        'MidText
        '
        Me.MidText.Location = New System.Drawing.Point(283, 283)
        Me.MidText.Name = "MidText"
        Me.MidText.Size = New System.Drawing.Size(140, 23)
        Me.MidText.TabIndex = 5
        '
        'BtnPasarIzqCen
        '
        Me.BtnPasarIzqCen.Location = New System.Drawing.Point(214, 116)
        Me.BtnPasarIzqCen.Name = "BtnPasarIzqCen"
        Me.BtnPasarIzqCen.Size = New System.Drawing.Size(38, 37)
        Me.BtnPasarIzqCen.TabIndex = 6
        Me.BtnPasarIzqCen.Text = "-->"
        Me.BtnPasarIzqCen.UseVisualStyleBackColor = True
        '
        'BtnPasarCenIzq
        '
        Me.BtnPasarCenIzq.Location = New System.Drawing.Point(214, 196)
        Me.BtnPasarCenIzq.Name = "BtnPasarCenIzq"
        Me.BtnPasarCenIzq.Size = New System.Drawing.Size(38, 37)
        Me.BtnPasarCenIzq.TabIndex = 7
        Me.BtnPasarCenIzq.Text = "<--"
        Me.BtnPasarCenIzq.UseVisualStyleBackColor = True
        '
        'BtnPasarDerCen
        '
        Me.BtnPasarDerCen.Location = New System.Drawing.Point(458, 196)
        Me.BtnPasarDerCen.Name = "BtnPasarDerCen"
        Me.BtnPasarDerCen.Size = New System.Drawing.Size(38, 37)
        Me.BtnPasarDerCen.TabIndex = 12
        Me.BtnPasarDerCen.Text = "<--"
        Me.BtnPasarDerCen.UseVisualStyleBackColor = True
        '
        'BtnPasarCenDer
        '
        Me.BtnPasarCenDer.Location = New System.Drawing.Point(458, 116)
        Me.BtnPasarCenDer.Name = "BtnPasarCenDer"
        Me.BtnPasarCenDer.Size = New System.Drawing.Size(38, 37)
        Me.BtnPasarCenDer.TabIndex = 11
        Me.BtnPasarCenDer.Text = "-->"
        Me.BtnPasarCenDer.UseVisualStyleBackColor = True
        '
        'RightText
        '
        Me.RightText.Location = New System.Drawing.Point(527, 283)
        Me.RightText.Name = "RightText"
        Me.RightText.Size = New System.Drawing.Size(140, 23)
        Me.RightText.TabIndex = 10
        '
        'RightList
        '
        Me.RightList.AllowDrop = True
        Me.RightList.FormattingEnabled = True
        Me.RightList.ItemHeight = 15
        Me.RightList.Items.AddRange(New Object() {"a", "e", "i", "o", "u"})
        Me.RightList.Location = New System.Drawing.Point(527, 93)
        Me.RightList.Name = "RightList"
        Me.RightList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.RightList.Size = New System.Drawing.Size(140, 184)
        Me.RightList.TabIndex = 9
        '
        'RightClearListButton
        '
        Me.RightClearListButton.Location = New System.Drawing.Point(527, 64)
        Me.RightClearListButton.Name = "RightClearListButton"
        Me.RightClearListButton.Size = New System.Drawing.Size(140, 23)
        Me.RightClearListButton.TabIndex = 8
        Me.RightClearListButton.Text = "Borrar Lista"
        Me.RightClearListButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPasarDerCen)
        Me.Controls.Add(Me.BtnPasarCenDer)
        Me.Controls.Add(Me.RightText)
        Me.Controls.Add(Me.RightList)
        Me.Controls.Add(Me.RightClearListButton)
        Me.Controls.Add(Me.BtnPasarCenIzq)
        Me.Controls.Add(Me.BtnPasarIzqCen)
        Me.Controls.Add(Me.MidText)
        Me.Controls.Add(Me.MidList)
        Me.Controls.Add(Me.MidClearListButton)
        Me.Controls.Add(Me.LeftText)
        Me.Controls.Add(Me.LeftClearListButton)
        Me.Controls.Add(Me.LeftList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LeftList As ListBox
    Friend WithEvents LeftClearListButton As Button
    Friend WithEvents LeftText As TextBox
    Friend WithEvents MidClearListButton As Button
    Friend WithEvents MidList As ListBox
    Friend WithEvents MidText As TextBox
    Friend WithEvents BtnPasarIzqCen As Button
    Friend WithEvents BtnPasarCenIzq As Button
    Friend WithEvents BtnPasarDerCen As Button
    Friend WithEvents BtnPasarCenDer As Button
    Friend WithEvents RightText As TextBox
    Friend WithEvents RightList As ListBox
    Friend WithEvents RightClearListButton As Button
End Class
