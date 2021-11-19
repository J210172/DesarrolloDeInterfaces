Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each panel As Panel In PanelGroup.Controls

            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)

        Next
        Fuentes()
        ControlesPaneles()

    End Sub

    Private Sub Fuentes()

        For Each fuente As FontFamily In FontFamily.Families

            ComboFuentes.Items.Add(fuente.Name)

        Next

    End Sub

    Private Sub tamano()

        Texto.Font = New Font(ComboFuentes.Text, BarraTamano.Value)

    End Sub

    Private Sub BarraTamano_Scroll(sender As Object, e As EventArgs) Handles BarraTamano.Scroll

        tamano()

    End Sub

    Private Sub ResetColor_Click(sender As Object, e As EventArgs) Handles ResetColor.Click

        For Each panel As Panel In PanelGroup.Controls

            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)

        Next

    End Sub

    Private Sub ComboFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFuentes.SelectedIndexChanged

        tamano()

    End Sub

    Private Sub ControlesPaneles()

        For Each panel As Panel In PanelGroup.Controls

            AddHandler panel.Click, AddressOf Me.setColor

        Next

    End Sub

    Private Sub setColor(sender As Object, e As EventArgs)

        Dim MiPanel As Panel = sender

        If (RadioFuente.Checked) Then

            Texto.ForeColor = MiPanel.BackColor

        ElseIf (RadioFondo.Checked) Then

            Texto.BackColor = MiPanel.BackColor

        End If

    End Sub

End Class
