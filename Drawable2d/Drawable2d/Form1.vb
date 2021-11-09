Public Class Form1
    Dim g As System.Drawing.Graphics
    Dim pen1 As New System.Drawing.Pen(Color.Red, 3)

    Public Function GetMP() As Point
        Return Me.PointToClient(MousePosition)
    End Function

    Public Sub DrawAPoint(point1)
        g = PictureBox1.CreateGraphics
        Dim point2 As System.Drawing.Point

        point2.X = point1.X + 5
        point2.Y = point1.Y + 5
        g.DrawLine(pen1, point1, point2)
    End Sub

    Public Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown, Me.KeyDown

        If e.KeyCode = Keys.K Then

        ElseIf e.KeyCode = Keys.L Then
            DrawAPoint(GetMP())
        End If
    End Sub

    Public Sub PictureBox1_MouseEvent(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseMove
        DrawAPoint(GetMP())
    End Sub

    Private Sub ColorChooseButton_Click(sender As Object, e As EventArgs) Handles ColorChooseButton.Click
        Dim colorDialog As New ColorDialog
        colorDialog.ShowDialog()
        pen1.Color = colorDialog.Color
    End Sub

End Class
