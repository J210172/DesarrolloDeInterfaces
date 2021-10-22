Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Relaciona()
    End Sub

    Private Sub Relaciona()
        ColorButton.Tag = ColorInputTextBox
        ColorInputTextBox.Tag = ColorListBox
        RemoveButton1.Tag = ColorListBox

        MarcaButton.Tag = MarcaInputTextBox
        MarcaInputTextBox.Tag = MarcaListBox
        RemoveButton2.Tag = MarcaListBox

        CarButton.Tag = CarInputTextBox
        CarInputTextBox.Tag = CarListBox
        RemoveButton3.Tag = CarListBox
    End Sub

    Private Sub addItem(sender As Object, e As EventArgs) Handles ColorButton.Click, MarcaButton.Click, CarButton.Click
        Dim button As Button = sender
        Dim textBox As TextBox = button.Tag
        Dim listBox As ListBox = textBox.Tag
        Dim text As String = textBox.Text.Trim.ToLower
        If Not listBox.Items.Contains(text) And Not text = "" Then
            listBox.Items.Add(text)
        End If

    End Sub

    Private Sub deleteItem(sender As Object, e As EventArgs) Handles RemoveButton1.Click, RemoveButton2.Click, RemoveButton3.Click
        Dim button As Button = sender
        Dim listBox As ListBox = button.Tag

        listBox.Items.Remove(listBox.SelectedItem)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles ColorInputTextBox.KeyDown, MarcaInputTextBox.KeyDown, CarInputTextBox.KeyDown
        Dim textBox As TextBox = sender
        Dim listBox As ListBox = textBox.Tag
        Dim text As String = textBox.Text.Trim.ToLower
        If e.KeyCode = Keys.Enter Then
            If Not listBox.Items.Contains(text) And Not text = "" Then
                listBox.Items.Add(text)
            End If
        End If
    End Sub
End Class