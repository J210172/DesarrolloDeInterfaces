Public Class Form2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForegroundRButton.Checked = True
        LoadFonts()
        Loadcontrols()
    End Sub

    Private Sub ChangeColor(sender As Object, e As EventArgs)
        Dim mypanel As Panel = sender
        If ForegroundRButton.Checked Then
            TextLbl.ForeColor = mypanel.BackColor
        ElseIf BackgroundRButton.Checked Then
            TextLbl.BackColor = mypanel.BackColor
        End If
    End Sub

    Private Sub Loadcontrols()
        For Each panel As Panel In ColorGB.Controls
            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)
            AddHandler panel.Click, AddressOf Me.ChangeColor
        Next
    End Sub

    Private Sub LoadFonts()
        Dim fuente As FontFamily
        For Each fuente In FontFamily.Families
            FontsCB.Items.Add(fuente.Name)
        Next
        FontsCB.Text = FontsCB.Items(0)
    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles SizeTB.Scroll
        TextLbl.Font = New Font(FontsCB.Text, SizeTB.Value)
    End Sub

    Private Sub fuentesCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontsCB.SelectedIndexChanged
        TextLbl.Font = New Font(FontsCB.Text, SizeTB.Value)
    End Sub

    Private Sub Btn_colores_Click(sender As Object, e As EventArgs) Handles ChColorButton.Click
        For Each panel As Panel In ColorGB.Controls
            panel.BackColor = Color.FromArgb(255, Rnd() * 255, Rnd() * 255, Rnd() * 255)
        Next
    End Sub

End Class