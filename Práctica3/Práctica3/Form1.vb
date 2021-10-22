Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListBox1.SelectedIndexChanged

        Dim miLista As ListBox = sender
        If miLista.SelectedIndex = -1 Then Exit Sub
        TBColor.Text = ""

        For Each Texto As String In miLista.SelectedItems

            TBColor.Text &= Texto & " " & vbCrLf

        Next

    End Sub

End Class
