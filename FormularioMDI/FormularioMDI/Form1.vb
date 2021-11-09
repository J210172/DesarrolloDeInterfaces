Public Class Form1
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim textFormCount As Integer
    Dim pictureFormCount As Integer
    Private Sub SalirDeLaApToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAppicacionToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textFormCount = 0
        pictureFormCount = 0
    End Sub

    Private Sub NewTextWindow_Click(sender As Object, e As EventArgs) Handles NewTextWindow.Click
        Dim MyTextForm As New TextForm
        MyTextForm.MdiParent = Me
        textFormCount += 1
        MyTextForm.Text = "Formulario Hijo Texto nº" & textFormCount
        MyTextForm.Show()
    End Sub

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        Dim MyTextForm As New TextForm
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            MyTextForm.MdiParent = Me
            MyTextForm.RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            textFormCount += 1
            MyTextForm.Text = "Formulario Hijo Texto nº" & textFormCount
            MyTextForm.Show()
        End If
    End Sub

    Private Sub NewPictureWindow_Click(sender As Object, e As EventArgs) Handles NewPictureWindow.Click
        Dim MyPictureForm As New PictureForm
        MyPictureForm.MdiParent = Me
        pictureFormCount += 1
        MyPictureForm.Text = "Formulario Hijo Imagen nº" & pictureFormCount
        MyPictureForm.Show()
    End Sub

    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MyPictureForm As New PictureForm
        Dim MiImagen As Image = Nothing
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            MiImagen = Image.FromFile(OpenFileDialog1.FileName)
            MyPictureForm.MdiParent = Me
            MyPictureForm.PictureBox1.Image = MiImagen
            pictureFormCount += 1
            MyPictureForm.Text = "Formulario Hijo Imagen nº" & pictureFormCount
            MyPictureForm.Show()
        End If
    End Sub

    Private Sub CloseAllWindows_Click(sender As Object, e As EventArgs) Handles CloseAllWindows.Click, CerrarTodasLasVentanasToolStripMenuItem.Click
        For Each form1 In Me.MdiChildren
            form1.Close()
        Next
        textFormCount = 0
        pictureFormCount = 0
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CerrarVentanaActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActualToolStripMenuItem.Click
        If Me.ActiveMdiChild Is TextForm Then
            textFormCount -= 1
        Else
            pictureFormCount -= 1
        End If
        Me.ActiveMdiChild.Close()
    End Sub
End Class
