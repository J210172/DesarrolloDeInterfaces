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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DeleteButton1 = New System.Windows.Forms.Button()
        Me.InputBox1 = New System.Windows.Forms.TextBox()
        Me.InputBox2 = New System.Windows.Forms.TextBox()
        Me.DeleteButton2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(32, 80)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox1.Size = New System.Drawing.Size(241, 400)
        Me.ListBox1.TabIndex = 0
        '
        'DeleteButton1
        '
        Me.DeleteButton1.AutoSize = True
        Me.DeleteButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton1.Location = New System.Drawing.Point(32, 30)
        Me.DeleteButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton1.Name = "DeleteButton1"
        Me.DeleteButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DeleteButton1.Size = New System.Drawing.Size(243, 43)
        Me.DeleteButton1.TabIndex = 1
        Me.DeleteButton1.Text = "Button1"
        Me.DeleteButton1.UseVisualStyleBackColor = True
        '
        'InputBox1
        '
        Me.InputBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox1.Location = New System.Drawing.Point(32, 488)
        Me.InputBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.InputBox1.Name = "InputBox1"
        Me.InputBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InputBox1.Size = New System.Drawing.Size(241, 24)
        Me.InputBox1.TabIndex = 2
        '
        'InputBox2
        '
        Me.InputBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox2.Location = New System.Drawing.Point(537, 488)
        Me.InputBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.InputBox2.Name = "InputBox2"
        Me.InputBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InputBox2.Size = New System.Drawing.Size(241, 24)
        Me.InputBox2.TabIndex = 5
        '
        'DeleteButton2
        '
        Me.DeleteButton2.AutoSize = True
        Me.DeleteButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton2.Location = New System.Drawing.Point(537, 30)
        Me.DeleteButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton2.Name = "DeleteButton2"
        Me.DeleteButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DeleteButton2.Size = New System.Drawing.Size(243, 43)
        Me.DeleteButton2.TabIndex = 4
        Me.DeleteButton2.Text = "Button1"
        Me.DeleteButton2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(537, 80)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox2.Size = New System.Drawing.Size(241, 400)
        Me.ListBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(345, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 61)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "<< <<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(345, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 61)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = ">> >>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InputBox2)
        Me.Controls.Add(Me.DeleteButton2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.InputBox1)
        Me.Controls.Add(Me.DeleteButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DeleteButton1 As Button
    Friend WithEvents InputBox1 As TextBox
    Friend WithEvents InputBox2 As TextBox
    Friend WithEvents DeleteButton2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
