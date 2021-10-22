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
        Me.ListaIzq = New System.Windows.Forms.ListBox()
        Me.BtnBorrarListaIzq = New System.Windows.Forms.Button()
        Me.TextoIzq = New System.Windows.Forms.TextBox()
        Me.BtnBorrarListaCen = New System.Windows.Forms.Button()
        Me.ListaCen = New System.Windows.Forms.ListBox()
        Me.TextoCen = New System.Windows.Forms.TextBox()
        Me.BtnPasarIzqCen = New System.Windows.Forms.Button()
        Me.BtnPasarCenIzq = New System.Windows.Forms.Button()
        Me.BtnPasarDerCen = New System.Windows.Forms.Button()
        Me.BtnPasarCenDer = New System.Windows.Forms.Button()
        Me.TextoDer = New System.Windows.Forms.TextBox()
        Me.ListaDer = New System.Windows.Forms.ListBox()
        Me.BtnBorrarListaDer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListaIzq
        '
        Me.ListaIzq.AllowDrop = True
        Me.ListaIzq.FormattingEnabled = True
        Me.ListaIzq.ItemHeight = 15
        Me.ListaIzq.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.ListaIzq.Location = New System.Drawing.Point(43, 93)
        Me.ListaIzq.Name = "ListaIzq"
        Me.ListaIzq.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListaIzq.Size = New System.Drawing.Size(138, 184)
        Me.ListaIzq.TabIndex = 0
        '
        'BtnBorrarListaIzq
        '
        Me.BtnBorrarListaIzq.Location = New System.Drawing.Point(43, 64)
        Me.BtnBorrarListaIzq.Name = "BtnBorrarListaIzq"
        Me.BtnBorrarListaIzq.Size = New System.Drawing.Size(138, 23)
        Me.BtnBorrarListaIzq.TabIndex = 1
        Me.BtnBorrarListaIzq.Text = "Borrar Lista"
        Me.BtnBorrarListaIzq.UseVisualStyleBackColor = True
        '
        'TextoIzq
        '
        Me.TextoIzq.Location = New System.Drawing.Point(43, 283)
        Me.TextoIzq.Name = "TextoIzq"
        Me.TextoIzq.Size = New System.Drawing.Size(138, 23)
        Me.TextoIzq.TabIndex = 2
        '
        'BtnBorrarListaCen
        '
        Me.BtnBorrarListaCen.Location = New System.Drawing.Point(283, 64)
        Me.BtnBorrarListaCen.Name = "BtnBorrarListaCen"
        Me.BtnBorrarListaCen.Size = New System.Drawing.Size(140, 23)
        Me.BtnBorrarListaCen.TabIndex = 3
        Me.BtnBorrarListaCen.Text = "Borrar Lista"
        Me.BtnBorrarListaCen.UseVisualStyleBackColor = True
        '
        'ListaCen
        '
        Me.ListaCen.AllowDrop = True
        Me.ListaCen.FormattingEnabled = True
        Me.ListaCen.ItemHeight = 15
        Me.ListaCen.Items.AddRange(New Object() {"Peugeot", "Lamborghini", "Nissan", "Toyota", "Subaru", "Honda"})
        Me.ListaCen.Location = New System.Drawing.Point(283, 93)
        Me.ListaCen.Name = "ListaCen"
        Me.ListaCen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListaCen.Size = New System.Drawing.Size(140, 184)
        Me.ListaCen.TabIndex = 4
        '
        'TextoCen
        '
        Me.TextoCen.Location = New System.Drawing.Point(283, 283)
        Me.TextoCen.Name = "TextoCen"
        Me.TextoCen.Size = New System.Drawing.Size(140, 23)
        Me.TextoCen.TabIndex = 5
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
        'TextoDer
        '
        Me.TextoDer.Location = New System.Drawing.Point(527, 283)
        Me.TextoDer.Name = "TextoDer"
        Me.TextoDer.Size = New System.Drawing.Size(140, 23)
        Me.TextoDer.TabIndex = 10
        '
        'ListaDer
        '
        Me.ListaDer.AllowDrop = True
        Me.ListaDer.FormattingEnabled = True
        Me.ListaDer.ItemHeight = 15
        Me.ListaDer.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.ListaDer.Location = New System.Drawing.Point(527, 93)
        Me.ListaDer.Name = "ListaDer"
        Me.ListaDer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListaDer.Size = New System.Drawing.Size(140, 184)
        Me.ListaDer.TabIndex = 9
        '
        'BtnBorrarListaDer
        '
        Me.BtnBorrarListaDer.Location = New System.Drawing.Point(527, 64)
        Me.BtnBorrarListaDer.Name = "BtnBorrarListaDer"
        Me.BtnBorrarListaDer.Size = New System.Drawing.Size(140, 23)
        Me.BtnBorrarListaDer.TabIndex = 8
        Me.BtnBorrarListaDer.Text = "Borrar Lista"
        Me.BtnBorrarListaDer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPasarDerCen)
        Me.Controls.Add(Me.BtnPasarCenDer)
        Me.Controls.Add(Me.TextoDer)
        Me.Controls.Add(Me.ListaDer)
        Me.Controls.Add(Me.BtnBorrarListaDer)
        Me.Controls.Add(Me.BtnPasarCenIzq)
        Me.Controls.Add(Me.BtnPasarIzqCen)
        Me.Controls.Add(Me.TextoCen)
        Me.Controls.Add(Me.ListaCen)
        Me.Controls.Add(Me.BtnBorrarListaCen)
        Me.Controls.Add(Me.TextoIzq)
        Me.Controls.Add(Me.BtnBorrarListaIzq)
        Me.Controls.Add(Me.ListaIzq)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaIzq As ListBox
    Friend WithEvents BtnBorrarListaIzq As Button
    Friend WithEvents TextoIzq As TextBox
    Friend WithEvents BtnBorrarListaCen As Button
    Friend WithEvents ListaCen As ListBox
    Friend WithEvents TextoCen As TextBox
    Friend WithEvents BtnPasarIzqCen As Button
    Friend WithEvents BtnPasarCenIzq As Button
    Friend WithEvents BtnPasarDerCen As Button
    Friend WithEvents BtnPasarCenDer As Button
    Friend WithEvents TextoDer As TextBox
    Friend WithEvents ListaDer As ListBox
    Friend WithEvents BtnBorrarListaDer As Button
End Class
