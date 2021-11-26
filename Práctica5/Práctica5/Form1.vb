Public Class Form1

    Dim origList As ListBox
    Dim destList As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitControls()

    End Sub

    Private Sub InitControls()

        LeftText.Tag = LeftList
        LeftClearListButton.Tag = LeftList

        MidText.Tag = MidList
        MidClearListButton.Tag = MidList

        RightText.Tag = RightList
        RightClearListButton.Tag = RightList

    End Sub

    Private Sub Text_keyPress(sender As Object, e As KeyPressEventArgs) Handles LeftText.KeyPress, MidText.KeyPress, RightText.KeyPress

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

    Private Sub ClearList_buttonCLick(sender As Object, e As EventArgs) Handles LeftClearListButton.Click, MidClearListButton.Click, RightClearListButton.Click

        Dim Mibtn As Button = sender
        Dim Milista As ListBox = Mibtn.Tag
        Milista.Items.Clear()

    End Sub

    Private Sub MoveElement()

        Do While origList.SelectedItems.Count

            destList.Items.Add(origList.SelectedItems(0))
            origList.Items.Remove(origList.SelectedItems(0))

        Loop

    End Sub

    'Private Sub List_doubleClick(sender As Object, e As EventArgs) Handles ListaIzq.DoubleClick, ListaCen.DoubleClick, ListaDer.DoubleClick

    '    Dim myList As ListBox = sender
    '    If myList.SelectedItems.Count >= 0 Then
    '    Select Case myList.Name
    '        Case "ListLeft"
    '            origList = ListaLeft
    '            destList = ListaMId

    '        Case "ListMid"
    '            origList = ListaMid
    '            destList = ListaRight

    '    End Select

    '    PasarElemento()
    '    End If
    'End Sub

    Private Sub MoveListsButton(sender As Object, e As EventArgs) _
        Handles BtnPasarIzqCen.Click, BtnPasarCenIzq.Click, BtnPasarDerCen.Click, BtnPasarCenDer.Click

        Dim MiBoton As Button = sender
        Select Case MiBoton.Name

            Case "BtnPasarIzqCen"
                origList = LeftList
                destList = MidList

            Case "BtnPasarCenIzq"
                origList = MidList
                destList = LeftList

            Case "BtnPasarCenDer"
                origList = MidList
                destList = RightList

            Case "BtnPasarDerCen"
                origList = RightList
                destList = MidList

        End Select

        If origList.SelectedItems.Count = 0 Then

            For i As Integer = 0 To origList.Items.Count - 1

                origList.SetSelected(i, True)

            Next

        End If

        MoveElement()

    End Sub

    Private Sub List_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftList.MouseDown, MidList.MouseDown, RightList.MouseDown

        origList = sender
        Try
            origList.DoDragDrop(origList.Text, DragDropEffects.Move)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DragOverAll(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles LeftList.DragOver, MidList.DragOver, RightList.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub DragNDropElements(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles LeftList.DragDrop, MidList.DragDrop, RightList.DragDrop
        destList = sender
        MoveElement()

    End Sub

    Private Sub LeftList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LeftList.SelectedIndexChanged

    End Sub
End Class
