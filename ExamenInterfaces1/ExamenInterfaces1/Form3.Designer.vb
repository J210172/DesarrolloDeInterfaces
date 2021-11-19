<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HorizontalMi = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeMi = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseAllWindowsMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWindowMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TimerLbl = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'HorizontalMi
        '
        Me.HorizontalMi.Name = "HorizontalMi"
        Me.HorizontalMi.Size = New System.Drawing.Size(180, 22)
        Me.HorizontalMi.Text = "Horizontal"
        '
        'VerticalMI
        '
        Me.VerticalMI.Name = "VerticalMI"
        Me.VerticalMI.Size = New System.Drawing.Size(180, 22)
        Me.VerticalMI.Text = "Vertical"
        '
        'CascadeMi
        '
        Me.CascadeMi.Name = "CascadeMi"
        Me.CascadeMi.Size = New System.Drawing.Size(180, 22)
        Me.CascadeMi.Text = "Cascada"
        '
        'VentanasMI
        '
        Me.VentanasMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeMi, Me.VerticalMI, Me.HorizontalMi, Me.ToolStripSeparator2})
        Me.VentanasMI.Name = "VentanasMI"
        Me.VentanasMI.Size = New System.Drawing.Size(66, 20)
        Me.VentanasMI.Text = "Ventanas"
        '
        'ExitMI
        '
        Me.ExitMI.Name = "ExitMI"
        Me.ExitMI.Size = New System.Drawing.Size(180, 22)
        Me.ExitMI.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'CloseAllWindowsMI
        '
        Me.CloseAllWindowsMI.Name = "CloseAllWindowsMI"
        Me.CloseAllWindowsMI.Size = New System.Drawing.Size(180, 22)
        Me.CloseAllWindowsMI.Text = "Cerrar Todas"
        '
        'HelpMI
        '
        Me.HelpMI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpMI.Name = "HelpMI"
        Me.HelpMI.Size = New System.Drawing.Size(53, 20)
        Me.HelpMI.Text = "Ayuda"
        '
        'CloseWindowMI
        '
        Me.CloseWindowMI.Name = "CloseWindowMI"
        Me.CloseWindowMI.Size = New System.Drawing.Size(180, 22)
        Me.CloseWindowMI.Text = "Cerrar Pizarra Activa"
        '
        'PriToolStripMenuItem
        '
        Me.PriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageMI, Me.TextMI, Me.ToolStripSeparator3, Me.CloseWindowMI, Me.CloseAllWindowsMI, Me.ToolStripSeparator1, Me.ExitMI})
        Me.PriToolStripMenuItem.Name = "PriToolStripMenuItem"
        Me.PriToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PriToolStripMenuItem.Text = "Pizarras"
        '
        'ImageMI
        '
        Me.ImageMI.Name = "ImageMI"
        Me.ImageMI.Size = New System.Drawing.Size(180, 22)
        Me.ImageMI.Text = "Imagen"
        '
        'TextMI
        '
        Me.TextMI.Name = "TextMI"
        Me.TextMI.Size = New System.Drawing.Size(180, 22)
        Me.TextMI.Text = "Texto"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PriToolStripMenuItem, Me.VentanasMI, Me.HelpMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanasMI
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerLbl})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TimerLbl
        '
        Me.TimerLbl.Name = "TimerLbl"
        Me.TimerLbl.Size = New System.Drawing.Size(87, 22)
        Me.TimerLbl.Text = "ToolStripLabel1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HorizontalMi As ToolStripMenuItem
    Friend WithEvents VerticalMI As ToolStripMenuItem
    Friend WithEvents CascadeMi As ToolStripMenuItem
    Friend WithEvents VentanasMI As ToolStripMenuItem
    Friend WithEvents ExitMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseAllWindowsMI As ToolStripMenuItem
    Friend WithEvents HelpMI As ToolStripMenuItem
    Friend WithEvents CloseWindowMI As ToolStripMenuItem
    Friend WithEvents PriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImageMI As ToolStripMenuItem
    Friend WithEvents TextMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TimerLbl As ToolStripLabel
End Class
