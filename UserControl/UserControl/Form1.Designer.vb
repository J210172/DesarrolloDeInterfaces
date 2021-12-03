<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.UC3 = New UserControl.UserControl1()
        Me.UC2 = New UserControl.UserControl1()
        Me.UC1 = New UserControl.UserControl1()
        Me.SuspendLayout()
        '
        'UC3
        '
        Me.UC3.Location = New System.Drawing.Point(494, 12)
        Me.UC3.Name = "UC3"
        Me.UC3.Size = New System.Drawing.Size(196, 366)
        Me.UC3.TabIndex = 15
        '
        'UC2
        '
        Me.UC2.Location = New System.Drawing.Point(253, 12)
        Me.UC2.Name = "UC2"
        Me.UC2.Size = New System.Drawing.Size(196, 366)
        Me.UC2.TabIndex = 14
        '
        'UC1
        '
        Me.UC1.AllowDrop = True
        Me.UC1.Location = New System.Drawing.Point(12, 12)
        Me.UC1.Name = "UC1"
        Me.UC1.Size = New System.Drawing.Size(196, 366)
        Me.UC1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 391)
        Me.Controls.Add(Me.UC3)
        Me.Controls.Add(Me.UC2)
        Me.Controls.Add(Me.UC1)
        Me.Name = "Form1"
        Me.Text = "Practica 5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UC1 As UserControl1
    Friend WithEvents UC2 As UserControl1
    Friend WithEvents UC3 As UserControl1
End Class
