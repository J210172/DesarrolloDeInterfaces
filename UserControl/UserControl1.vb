Public Class UserControl1

    Private Sub Text_keyPress(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim Texto As String = TextBox1.Text.Trim
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            If Texto.Length > 0 AndAlso Not ListBox1.Items.Contains(Texto) Then
                ListBox1.Items.Add(Texto)
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ClearList_buttonCLick(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyButton As Button = sender
        Dim MyList As ListBox = MyButton.Tag
        MyList.Items.Clear()
    End Sub

    Private Sub List_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListBox1.MouseDown

        Try
            ListBox1.DoDragDrop(ListBox1, DragDropEffects.Move)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DragOverAll(ByVal sender As Object, ByVal e As DragEventArgs) Handles ListBox1.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub DragNDropElements(ByVal sender As Object, ByVal e As DragEventArgs) Handles ListBox1.DragDrop
        Dim OrigLista As ListBox = e.Data.GetData(ListBox1.GetType)
        If Not ListBox1.Equals(OrigLista) Then
            For Each Item In OrigLista.SelectedItems
                ListBox1.Items.Add(Item)
            Next
            While OrigLista.SelectedItems.Count > 0
                OrigLista.Items.Remove(OrigLista.SelectedItems(0))
            End While
        End If
    End Sub

End Class
