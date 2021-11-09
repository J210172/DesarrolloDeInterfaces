Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


Public Class DrawAllKindsOf
    Public Shared Sub Main()
        Application.Run(New Form1)
    End Sub
End Class
Partial Class Form1
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
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

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dot"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(240, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Line"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(240, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ellipse"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(240, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Arc"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(240, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 24)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Pie"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(240, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 24)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Rectangle"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(312, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 24)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Triangle"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(312, 48)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 24)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Polygon"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(312, 88)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 24)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Bezier Curve"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 246)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ResumeLayout(False)
    End Sub
End Class