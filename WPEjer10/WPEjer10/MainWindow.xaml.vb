Class MainWindow

    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox

    Private Sub CargaForm(sender As Object, e As EventArgs) Handles MyBase.Loaded

        InicializarControles()

    End Sub

    Private Sub InicializarControles()

        Txt_box1.Tag = ListBox1
        Btn_limpiar1.Tag = ListBox1

        Txt_box2.Tag = ListBox2
        Btn_limpiar2.Tag = ListBox2

        ListBox1.Tag = ListBox2
        ListBox2.Tag = ListBox1

    End Sub

    Private Sub AgregarDatos(sender As Object, e As KeyEventArgs) Handles Txt_box1.KeyDown, Txt_box2.KeyDown

        Dim MiTexto As TextBox = sender
        Dim MiLista As ListBox = MiTexto.Tag

        If e.Key = Key.Enter Then

            e.Handled = True
            If (MiTexto.Text.Trim = "") Or Not (MiLista.Items.IndexOf(MiTexto.Text.Trim) = -1) Then Exit Sub
            MiLista.Items.Add(MiTexto.Text.Trim)
            MiTexto.Clear()
            MiTexto.Focus()

        End If

    End Sub

    Private Sub LimpiarLista(sender As Object, e As EventArgs) Handles Btn_limpiar1.Click, Btn_limpiar2.Click

        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag

        MiLista.Items.Clear()

    End Sub

    Private Sub IntercambioListas()
        Do While MiListaOrigen.SelectedItems.Count

            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))

        Loop
    End Sub

    Private Sub Desplazar(sender As Object, e As EventArgs) Handles Btn_mover1.Click, Btn_mover2.Click

        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "Btn_mover1"
                MiListaOrigen = ListBox1
                MiListaDestino = ListBox2

            Case "Btn_mover2"
                MiListaOrigen = ListBox2
                MiListaDestino = ListBox1

        End Select

        If MiListaOrigen.SelectedItems.Count = 0 Then

            MiListaOrigen.SelectAll()

        End If

        IntercambioListas()

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles ListBox1.MouseDoubleClick, ListBox2.MouseDoubleClick
        Dim MiList As ListBox = sender
        Select Case MiList.Name
            Case "ListBox1"
                MiListaOrigen = ListBox1
                MiListaDestino = ListBox2

            Case "ListBox2"
                MiListaOrigen = ListBox2
                MiListaDestino = ListBox1
        End Select
        IntercambioListas()
    End Sub

    Private Sub Listas_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListBox1.MouseMove, ListBox2.MouseMove
        Dim list As ListBox = sender
        If e.LeftButton = MouseButtonState.Pressed Then
            DragDrop.DoDragDrop(list, list.Tag, DragDropEffects.Move)
        End If
    End Sub

    Private Sub Listas_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles ListBox1.DragOver, ListBox2.DragOver
        e.Effects = DragDropEffects.Move
    End Sub

    Private Sub Listas_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles ListBox1.Drop, ListBox2.Drop
        Dim deslist As ListBox = sender
        Dim list As ListBox = deslist.Tag
        Do While list.SelectedItems.Count
            deslist.Items.Add(list.SelectedItem)
            list.Items.Remove(list.SelectedItem)
        Loop
    End Sub

    Private Sub ListBox1_DragLeave(sender As Object, e As DragEventArgs) Handles ListBox1.DragLeave

    End Sub
End Class