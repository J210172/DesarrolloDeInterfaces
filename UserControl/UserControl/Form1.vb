Public Class Form1

    Dim origList As ListBox
    Dim destList As ListBox


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub MoveElement()
        Do While origList.SelectedItems.Count
            destList.Items.Add(origList.SelectedItems(0))
            origList.Items.Remove(origList.SelectedItems(0))
        Loop
    End Sub




End Class
