Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempTB As TextBox = New TextBox
        Dim tempL As Label = New Label
        Dim nElements As Integer = Panel1.Controls.Count / 2
        If nElements <= 10 Then

            tempL.Top = nElements * (tempTB.Height + 10) + 10
            tempL.Left = tempL.Left + 10
            tempL.Text = "TextBox num " & nElements
            tempL.AutoSize = True
            tempL.ForeColor = Color.Red
            tempL.Name = "Label_" & nElements
            Panel1.Controls.Add(tempL)

            tempTB.Top = tempL.Top
            tempTB.Left = tempL.Left + tempL.Width + 10
            tempTB.ForeColor = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
            AddHandler tempTB.DoubleClick, AddressOf Mitexto
            tempTB.Name = "TextBox_" & nElements
            Panel1.Controls.Add(tempTB)

            Label1.Text = "Nº de TextBox " & nElements
        End If
    End Sub

    Private Sub Mitexto(Objeto As Object, Evento As EventArgs)
        Dim Mitexto As TextBox = Objeto
        MessageBox.Show("contenido de: " & Mitexto.Name & "-->" & Mitexto.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel1.Controls.Count > 0 Then
            Panel1.Controls.RemoveAt(Panel1.Controls.Count - 1)
            Panel1.Controls.RemoveAt(Panel1.Controls.Count - 1)
            Label1.Text = "Nº de TextBox " & Panel1.Controls.Count / 2
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
