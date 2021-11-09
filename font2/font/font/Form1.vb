
Public Class Form1
    Dim Estilo As FontStyle

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each tipo As FontFamily In FontFamily.Families
            ComboBox1.Items.Add(tipo.Name)
        Next
        ComboBox1.Text = ComboBox1.Items(0)
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        LblTexto.Font = New Font(ComboBox1.Text, LblTexto.Font.Size)
        CambiarEstilos()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        LblTexto.Font = New Font(ComboBox1.Text, TrackBar1.Value)
        CambiarEstilos()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_normal.CheckedChanged
        Dim Micheck As CheckBox = sender
        If Estilo = FontStyle.Regular Then
            Micheck.Checked = True
            Exit Sub
        End If
        If Micheck.Checked Then
            For Each CheckEstilo As CheckBox In Pnl_estilos.Controls
                CheckEstilo.Checked = False
            Next
            Estilo = FontStyle.Regular
            Micheck.Checked = True
            CambiarEstilos()
        End If
    End Sub

    Private Sub Chk_negrita_CheckedChanged(sender As Object, e As EventArgs) _
        Handles Chk_negrita.CheckedChanged, Chk_inclinada.CheckedChanged, Chk_subrayada.CheckedChanged,
                Chk_tachada.CheckedChanged
        Dim Micheck As CheckBox
        Estilo = FontStyle.Regular
        For Each Micheck In Pnl_estilos.Controls
            If Micheck.Checked Then
                Estilo += Micheck.Font.Style
                Chk_normal.Checked = False
            End If
        Next
        If Estilo = FontStyle.Regular Then Chk_normal.Checked = True
        CambiarEstilos()
    End Sub

    Private Sub CambiarEstilos()
        LblTexto.Font = New Font(LblTexto.Font, Estilo)
    End Sub

End Class
