Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempTB As TextBox = New TextBox
        If Panel1.Controls.Count < 10 Then
            tempTB.Top = Panel1.Controls.Count * (tempTB.Height + 10)
            AddHandler tempTB.DoubleClick, AddressOf Mitexto
            Panel1.Controls.Add(tempTB)
            tempTB.Name = "TextBox_" & Panel1.Controls.Count
            Label1.Text = "Nº de TextBox " & Panel1.Controls.Count
        End If
    End Sub

    Private Sub Mitexto(Objeto As Object, Evento As EventArgs)
        Dim Mitexto As TextBox = Objeto
        MessageBox.Show("contenido de: " & Mitexto.Name & "-->" & Mitexto.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel1.Controls.Count > 0 Then
            Panel1.Controls.RemoveAt(Panel1.Controls.Count - 1)
            Label1.Text = "Nº de TextBox " & Panel1.Controls.Count
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
