Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub Form1_Enter(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            FolderBrowserDialog1.ShowDialog()
            'WebBrowser1.Url = New Uri(FolderBrowserDialog1.SelectedPath)
            WebBrowser1.Navigate(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
End Class
