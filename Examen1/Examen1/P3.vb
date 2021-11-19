Public Class P3
    Private Sub P3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim miForm As New Form
        Dim miRTB As New RichTextBox
        miForm.Controls.Add(miRTB)
        miRTB.Dock = DockStyle.Fill
        miForm.MdiParent = Me
        miForm.Show()
    End Sub
End Class

