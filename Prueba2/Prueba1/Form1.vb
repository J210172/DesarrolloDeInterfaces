Public Class Form1
    Dim g As System.Drawing.Graphics
    Dim pen1 As New System.Drawing.Pen(Color.Red, 3)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Refresh()
        g = PictureBox1.CreateGraphics
        Dim point1 As System.Drawing.Point
        Dim point2 As System.Drawing.Point
        point1.X = 10
        point1.Y = 20
        point2.X = 11
        point2.Y = 21
        g.DrawLine(pen1, point1, point2)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        g = PictureBox1.CreateGraphics
        g.DrawLine(pen1, 20, 20, 160, 160)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        g = PictureBox1.CreateGraphics
        g.DrawEllipse(pen1, 50, 50, 100, 150)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        g = PictureBox1.CreateGraphics
        g.DrawArc(pen1, 90, 50, 100, 150, 150, 160)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        g = PictureBox1.CreateGraphics
        g.DrawPie(pen1, 50, 50, 150, 150, 0, 170)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        g = PictureBox1.CreateGraphics
        g.DrawRectangle(pen1, 30, 30, 50, 60)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim p(3) As System.Drawing.Point
        p(0).X = 0
        p(0).Y = 0
        p(1).X = 40
        p(1).Y = 120
        p(2).X = 110
        p(2).Y = 70
        g = PictureBox1.CreateGraphics
        g.DrawPolygon(pen1, p)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim p(5) As System.Drawing.Point
        p(0).X = 0
        p(0).Y = 0
        p(1).X = 40
        p(1).Y = 120
        p(2).X = 110
        p(2).Y = 70
        p(3).X = 30
        p(3).Y = 30
        p(4).X = 170
        p(4).Y = 10
        g = PictureBox1.CreateGraphics
        g.DrawPolygon(pen1, p)
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        g = PictureBox1.CreateGraphics
        g.DrawBezier(pen1, 10, 20, 140, 150, 100, 30, 150, 200)
    End Sub
End Class
