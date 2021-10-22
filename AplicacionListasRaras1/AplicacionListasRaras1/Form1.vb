Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Reference()
    End Sub

    Private Sub Reference()
        InputBox1.Tag = ListBox1
        DeleteButton1.Tag = ListBox1


        InputBox2.Tag = ListBox1
        DeleteButton2.Tag = ListBox1
    End Sub

    Private Sub DeleteAll(sender As Object, e As EventArgs) Handles DeleteButton1.Click, DeleteButton2.Click
        Dim button As Button = sender
        Dim list As ListBox = button.Tag
        list.Items.Clear()
    End Sub

    Private Sub AddItemByEnterKey(sender As Object, e As KeyEventArgs) Handles InputBox1.KeyDown, InputBox2.KeyDown
        Dim input As TextBox = sender
        Dim list As ListBox = input.Tag
        Dim text As String = input.Text.Trim.ToLower
        If e.KeyCode = Keys.Enter Then
            If Not list.Items.Contains(text) And Not text = "" Then
                list.Items.Add(text)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count > 0 Then
            MessageBox.Show(ListBox1.SelectedItem)

            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox2.Items.Count > 0 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
End Class
