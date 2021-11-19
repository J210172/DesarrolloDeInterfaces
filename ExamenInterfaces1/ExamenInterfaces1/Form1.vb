Public Class Form1
    Dim valores() As Integer
    Dim programas() As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NoneRButton.Checked = True
        load()
    End Sub

    Private Sub load()
        valores = {100, 50, 20, 80}
        programas = {"Office 365", "Adobe Reader", "Compresor RAR", "Avast antivirus"}

        For i As Integer = 0 To valores.Length - 1
            ListBox1.Items.Add(programas(i) & " (" & valores(i) & ")")
        Next
    End Sub

    Dim total As Integer

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim miTexto As String = TextBox1.Text.Trim
        Dim miItem As String = miTexto & " " & TextBox2.Text.Trim
        If Not miTexto = "" Or Not ListBox1.Items.Contains(miItem) Then
            ListBox1.Items.Add(miItem)
            ReDim Preserve valores(valores.Count)
            valores(valores.Length - 1) = CInt(TextBox2.Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub activarElementos(sender As Object, e As EventArgs) Handles SO1Button.CheckedChanged, SO3Button.CheckedChanged, SO2Button.CheckedChanged

        AppBox.Enabled = True
        OtherPanel.Enabled = True
    End Sub

    Private Sub Rbtn_ninguno_CheckedChanged(sender As Object, e As EventArgs) Handles NoneRButton.CheckedChanged
        If NoneRButton.Checked Then
            AppBox.Enabled = False
            OtherPanel.Enabled = False
            ListBox1.Items.Clear()
            For Each check As CheckBox In AppBox.Controls
                check.Checked = False
            Next
        End If
    End Sub

    Private Sub Btn_productos_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String = ""
        If ListBox1.SelectedItems.Count > 0 Then
            For Each str As String In ListBox1.SelectedItems
                texto &= str & vbCrLf
            Next
            For Each cb As CheckBox In AppBox.Controls
                If cb.Checked Then
                    texto &= cb.Text & vbCrLf
                End If
            Next
            For Each rb As RadioButton In AppBox.Controls
                If rb.Checked Then
                    texto &= rb.Text & vbCrLf
                End If
            Next
        End If
        TextBox4.Text = texto

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles App1.CheckedChanged, App2.CheckedChanged, App3.CheckedChanged, App4.CheckedChanged
        Dim checkBox As CheckBox = sender
        Dim texto As String = checkBox.Text.Trim
        If checkBox.Checked And Not ListBox1.Items.Contains(texto) Then
            ListBox1.Items.Add(texto)
        Else
            ListBox1.Items.Remove(texto)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class