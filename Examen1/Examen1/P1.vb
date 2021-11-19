Public Class P1
    Private Sub TextBox_productos_KeyPress(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown

        Dim texto As String = TextBox1.Text.Trim & " " & TextBox2.Text.Trim

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            If Not texto = "" Or Not ListBox1.Items.Contains(texto) Then
                ListBox1.Items.Add(texto)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NoneRButton.Checked = True
    End Sub

    Private Sub activarElementos(sender As Object, e As EventArgs) Handles SO1Button.CheckedChanged, SO3Button.CheckedChanged, SO2Button.CheckedChanged
        AppBox.Enabled = True
        OtherPanel.Enabled = True
    End Sub

    Private Sub Rbtn_ninguno_CheckedChanged(sender As Object, e As EventArgs) Handles NoneRButton.CheckedChanged

        If (NoneRButton.Checked) Then
            AppBox.Enabled = True
            OtherPanel.Enabled = True
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For Each check As CheckBox In AppBox.Controls
                check.Checked = False
            Next

        End If




    End Sub

    Private Sub anadirLista(sender As Object, e As EventArgs) Handles SO1Button.CheckedChanged

        If (SO1Button.Checked) Then

            ListBox1.Items.Clear()
            Dim lista As ListBox = ListBox1
            Dim listaProductos() As String = {"Avast", "Steam", "Discord", "Afterburner"}

            For Each producto As String In listaProductos

                ListBox1.Items.Add(producto)
            Next

        End If

    End Sub

    Private Sub anadirLista2(sender As Object, e As EventArgs) Handles SO3Button.CheckedChanged

        If (SO3Button.Checked) Then

            ListBox1.Items.Clear()
            Dim lista As ListBox = ListBox1
            Dim listaProductos() As String = {"Panda", "Origin", "Skype", "Angel es subnormal"}

            For Each producto As String In listaProductos

                ListBox1.Items.Add(producto)
            Next

        End If

    End Sub

    Private Sub IntercambioListas()

        Do While ListBox1.SelectedItems.Count

            ListBox2.Items.Add(ListBox1.SelectedItems(0))
            ListBox1.Items.Remove(ListBox1.SelectedItems(0))

        Loop

    End Sub

    Private Sub Btn_productos_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListBox1.SelectedItems.Count = 0 Then

            For i As Integer = 0 To ListBox1.Items.Count - 1

                ListBox1.SetSelected(i, True)
            Next

        End If

        IntercambioListas()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles App1.CheckedChanged, App2.CheckedChanged, App3.CheckedChanged, App4.CheckedChanged
        Dim checkBox As CheckBox = sender
        If checkBox.Checked Then
            ListBox1.Items.Add(checkBox.Text)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

