Public Class Form1

    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        InicializarControles()

    End Sub

    Private Sub InicializarControles()

        TextoIzq.Tag = ListaIzq
        BtnBorrarListaIzq.Tag = ListaIzq

        TextoCen.Tag = ListaCen
        BtnBorrarListaCen.Tag = ListaCen

        TextoDer.Tag = ListaDer
        BtnBorrarListaDer.Tag = ListaDer

    End Sub

    Private Sub TextoIzq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextoIzq.KeyPress, TextoCen.KeyPress, TextoDer.KeyPress

        Dim Mitext As TextBox = sender
        Dim MiListaEntrada As ListBox = Mitext.Tag
        If Asc(e.KeyChar) = Keys.Enter Then

            e.Handled = True
            If Mitext.Text.Trim = "" Or Not MiListaEntrada.Items.IndexOf(Mitext.Text) = -1 Then Exit Sub
            MiListaEntrada.Items.Add(Mitext.Text.Trim)
            Mitext.Clear()
            Mitext.Focus()

        End If

    End Sub

    Private Sub BtnBorrarListaIzq_Click(sender As Object, e As EventArgs) Handles BtnBorrarListaIzq.Click, BtnBorrarListaCen.Click, BtnBorrarListaDer.Click

        Dim Mibtn As Button = sender
        Dim Milista As ListBox = Mibtn.Tag
        Milista.Items.Clear()

    End Sub

    Private Sub PasarElemento()

        Do While MiListaOrigen.SelectedItems.Count

            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))

        Loop

    End Sub

    'Private Sub ListaIzq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaIzq.DoubleClick, ListaCen.DoubleClick, ListaDer.DoubleClick

    '    Dim MiLista As ListBox = sender
    '    If MiLista.SelectedItems.Count = 0 Then Exit Sub
    '    Select Case MiLista.Name
    '        Case "ListaIzq"
    '            MiListaOrigen = ListaIzq
    '            MiListaDestino = ListaCen

    '        Case "ListaCen"
    '            MiListaOrigen = ListaCen
    '            MiListaDestino = ListaIzq

    '    End Select

    '    PasarElemento()

    'End Sub

    Private Sub BtnPasarIzqCen_Click(sender As Object, e As EventArgs) _
        Handles BtnPasarIzqCen.Click, BtnPasarCenIzq.Click, BtnPasarDerCen.Click, BtnPasarCenDer.Click

        Dim MiBoton As Button = sender
        Select Case MiBoton.Name

            Case "BtnPasarIzqCen"
                MiListaOrigen = ListaIzq
                MiListaDestino = ListaCen

            Case "BtnPasarCenIzq"
                MiListaOrigen = ListaCen
                MiListaDestino = ListaIzq

            Case "BtnPasarCenDer"
                MiListaOrigen = ListaCen
                MiListaDestino = ListaDer

            Case "BtnPasarDerCen"
                MiListaOrigen = ListaDer
                MiListaDestino = ListaCen

        End Select

        If MiListaOrigen.SelectedItems.Count = 0 Then

            For i As Integer = 0 To MiListaOrigen.Items.Count - 1

                MiListaOrigen.SetSelected(i, True)

            Next

        End If

        PasarElemento()

    End Sub

    Private Sub Listas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListaIzq.MouseDown, ListaCen.MouseDown, ListaDer.MouseDown

        MiListaOrigen = sender
        MiListaOrigen.DoDragDrop(MiListaOrigen.Text, DragDropEffects.Move)

    End Sub

    Private Sub DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListaIzq.DragOver, ListaCen.DragOver, ListaDer.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListaIzq.DragDrop, ListaCen.DragDrop, ListaDer.DragDrop

        MiListaDestino = sender
        PasarElemento()

    End Sub

End Class
