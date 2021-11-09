Public Class Form1
    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click

    End Sub

    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MiFormImage As New FormImg
        Dim MiImagen As Image = Nothing
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            MiImagen = Image.FromFile(OpenFileDialog1.FileName)
            MiFormImage.MdiParent = Me
            MiFormImage.PictureBox1.Image = MiImagen
            MiFormImage.Show()
        End If
    End Sub

    Private Sub RTFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RTFToolStripMenuItem.Click
        Dim MiRTForm As New RTForm
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            MiRTForm.MdiParent = Me
            MiRTForm.RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            MiRTForm.Show()
        End If
    End Sub
End Class
