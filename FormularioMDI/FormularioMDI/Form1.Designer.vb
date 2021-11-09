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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewTextWindow = New System.Windows.Forms.ToolStripButton()
        Me.NewPictureWindow = New System.Windows.Forms.ToolStripButton()
        Me.CloseAllWindows = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasLasVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirDeLaAppicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasHijasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTextWindow, Me.NewPictureWindow, Me.CloseAllWindows})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewTextWindow
        '
        Me.NewTextWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewTextWindow.Image = CType(resources.GetObject("NewTextWindow.Image"), System.Drawing.Image)
        Me.NewTextWindow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewTextWindow.Name = "NewTextWindow"
        Me.NewTextWindow.Size = New System.Drawing.Size(23, 22)
        Me.NewTextWindow.Text = "ToolStripButton1"
        '
        'NewPictureWindow
        '
        Me.NewPictureWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewPictureWindow.Image = CType(resources.GetObject("NewPictureWindow.Image"), System.Drawing.Image)
        Me.NewPictureWindow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewPictureWindow.Name = "NewPictureWindow"
        Me.NewPictureWindow.Size = New System.Drawing.Size(23, 22)
        Me.NewPictureWindow.Text = "ToolStripButton1"
        '
        'CloseAllWindows
        '
        Me.CloseAllWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseAllWindows.Image = CType(resources.GetObject("CloseAllWindows.Image"), System.Drawing.Image)
        Me.CloseAllWindows.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseAllWindows.Name = "CloseAllWindows"
        Me.CloseAllWindows.Size = New System.Drawing.Size(23, 22)
        Me.CloseAllWindows.Text = "ToolStripButton1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PriToolStripMenuItem, Me.VentanasHijasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PriToolStripMenuItem
        '
        Me.PriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarHijosToolStripMenuItem, Me.CerrarVentanaActualToolStripMenuItem, Me.CerrarTodasLasVentanasToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirDeLaAppicacionToolStripMenuItem})
        Me.PriToolStripMenuItem.Name = "PriToolStripMenuItem"
        Me.PriToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PriToolStripMenuItem.Text = "Principal"
        '
        'CargarHijosToolStripMenuItem
        '
        Me.CargarHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextoToolStripMenuItem, Me.ImagenToolStripMenuItem})
        Me.CargarHijosToolStripMenuItem.Name = "CargarHijosToolStripMenuItem"
        Me.CargarHijosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CargarHijosToolStripMenuItem.Text = "Cargar Hijos"
        '
        'CerrarVentanaActualToolStripMenuItem
        '
        Me.CerrarVentanaActualToolStripMenuItem.Name = "CerrarVentanaActualToolStripMenuItem"
        Me.CerrarVentanaActualToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CerrarVentanaActualToolStripMenuItem.Text = "Cerrar Ventana Actual"
        '
        'CerrarTodasLasVentanasToolStripMenuItem
        '
        Me.CerrarTodasLasVentanasToolStripMenuItem.Name = "CerrarTodasLasVentanasToolStripMenuItem"
        Me.CerrarTodasLasVentanasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar Todas Las Ventanas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'SalirDeLaAppicacionToolStripMenuItem
        '
        Me.SalirDeLaAppicacionToolStripMenuItem.Name = "SalirDeLaAppicacionToolStripMenuItem"
        Me.SalirDeLaAppicacionToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SalirDeLaAppicacionToolStripMenuItem.Text = "Salir de la Appicacion"
        '
        'VentanasHijasToolStripMenuItem
        '
        Me.VentanasHijasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasHijasToolStripMenuItem.Name = "VentanasHijasToolStripMenuItem"
        Me.VentanasHijasToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.VentanasHijasToolStripMenuItem.Text = "Ventanas Hijas"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanasHijasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarVentanaActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasLasVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirDeLaAppicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTextWindow As ToolStripButton
    Friend WithEvents NewPictureWindow As ToolStripButton
    Friend WithEvents CloseAllWindows As ToolStripButton
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
End Class
