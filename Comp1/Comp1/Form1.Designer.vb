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
        Me.UserControl12 = New Comp1.UserControl1()
        Me.UserControl11 = New Comp1.UserControl1()
        Me.UserControl13 = New Comp1.UserControl1()
        Me.SuspendLayout()
        '
        'UserControl12
        '
        Me.UserControl12.Location = New System.Drawing.Point(544, 12)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(244, 248)
        Me.UserControl12.TabIndex = 1
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(12, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(244, 248)
        Me.UserControl11.TabIndex = 0
        '
        'UserControl13
        '
        Me.UserControl13.Location = New System.Drawing.Point(277, 12)
        Me.UserControl13.Name = "UserControl13"
        Me.UserControl13.Size = New System.Drawing.Size(244, 248)
        Me.UserControl13.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserControl13)
        Me.Controls.Add(Me.UserControl12)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents UserControl12 As UserControl1
    Friend WithEvents UserControl13 As UserControl1
End Class
