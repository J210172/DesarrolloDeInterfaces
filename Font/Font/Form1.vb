Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fontLoad()
    End Sub
    Private Sub fontLoad()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families
            ComboBox1.Items.Add(MiFuente.Name)
        Next
        ComboBox1.Text = ComboBox1.Items(0)
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        HolaLabel.Font = New Drawing.Font(ComboBox1.Text, TrackBar1.Value)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        HolaLabel.Font = New Drawing.Font(ComboBox1.Text, TrackBar1.Value)
    End Sub
End Class
'ComboBox1.Items.AddRange(FontFamily.Families)
'ComboBox1.Text = ComboBox1.Items(0)  
'HolaLabel.Font = HolaLabel.Font.FontFamily.Name = CType(ComboBox1.SelectedItem, FontFamily)