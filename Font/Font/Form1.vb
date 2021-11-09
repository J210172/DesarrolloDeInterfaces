Public Class Form1
    Dim Style As FontStyle
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fontLoad()
    End Sub

    'Cargar las fuentes del sistema
    Private Sub fontLoad()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families
            ComboBox1.Items.Add(MiFuente.Name)
        Next
        ComboBox1.Text = ComboBox1.Items(0)
    End Sub


    'Cambio de Family Font
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Update_Font()
    End Sub

    'Cambio de Tamaño de fuente
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Update_Font()
    End Sub

    'Actualizar la fuente
    Private Sub Update_Font()
        HolaLabel.Font = New Drawing.Font(ComboBox1.Text, TrackBar1.Value, Style)
    End Sub

    'Cambiar el estilo de la fuente
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RegularChBx.CheckedChanged
        Dim Micheck As CheckBox = sender
        If Style = FontStyle.Regular Then
            Micheck.Checked = True
            Exit Sub
        End If
        If Micheck.Checked Then
            For Each CheckEstilo As CheckBox In StylesPnl.Controls
                CheckEstilo.Checked = False
            Next
            Style = FontStyle.Regular
            Micheck.Checked = True
            Update_Font()
        End If
    End Sub

    'Cambiar el estilo de la fuente
    Private Sub Chk_negrita_CheckedChanged(sender As Object, e As EventArgs) Handles BoldChBx.CheckedChanged, ItalicChBx.CheckedChanged, StrikeoutChBx.CheckedChanged,
                UnderlineChBx.CheckedChanged
        Dim Micheck As CheckBox
        Style = FontStyle.Regular
        For Each Micheck In StylesPnl.Controls
            If Micheck.Checked Then
                Style += Micheck.Font.Style
                RegularChBx.Checked = False
            End If
        Next
        If Style = FontStyle.Regular Then RegularChBx.Checked = True
        Update_Font()
    End Sub

End Class