Public Class P2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fuentes()
        control()


    End Sub

    Private Sub control()

        For Each panel As Panel In Panel1.Controls

            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)
            AddHandler panel.Click, AddressOf Me.cambiarColor

        Next
    End Sub

    Private Sub fuentes()

        Dim fuente As FontFamily

        For Each fuente In FontFamily.Families

            fuentesCB.Items.Add(fuente.Name)

        Next

        fuentesCB.Text = fuentesCB.Items(0)
    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        Label1.Font = New Font(fuentesCB.Text, TrackBar1.Value)

    End Sub

    Private Sub fuentesCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fuentesCB.SelectedIndexChanged

        Label1.Font = New Font(fuentesCB.Text, TrackBar1.Value)
    End Sub

    Private Sub Btn_colores_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each panel As Panel In Panel1.Controls

            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)

        Next
    End Sub

    Private Sub cambiarColor(sender As Object, e As EventArgs)

        Dim panel As Panel = sender
        Label1.ForeColor = panel.BackColor


        'For Each radios As RadioButton In Panel1.Controls
        'If radios.Checked Then
        'Select Case radios.Name
        '
        'Case "Rbt'n_fuente"
        'Label1.ForeColor = panel.BackColor
        '
        'Case "Rbt'n_fondo"
        'Label1.BackColor = panel.BackColor
        'End Select
        'End If
        'Next
    End Sub

End Class