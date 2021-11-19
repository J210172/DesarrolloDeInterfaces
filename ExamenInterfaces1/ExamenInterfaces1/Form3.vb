Public Class Form3
    Dim miTForm As New Form
    Dim miPForm As New Form
    Private Sub SalirDeLaApToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMI.Click
        Me.Close()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub TextMI_Click(sender As Object, e As EventArgs) Handles TextMI.Click
        miTForm = New Form
        Dim miRTB As New RichTextBox
        miTForm.Controls.Add(miRTB)
        miRTB.Dock = DockStyle.Fill
        AddHandler miTForm.FormClosed, AddressOf Me.CloseEvent
        AddHandler miRTB.DoubleClick, AddressOf Me.PasteText
        miTForm.Text = "Texto"
        miTForm.MdiParent = Me
        miTForm.Show()
        TextMI.Enabled = False
    End Sub

    Private Sub PasteText(sender As Object, e As EventArgs)
        Dim miRTB As New RichTextBox
        miRTB.Text = Clipboard.GetText
    End Sub

    Private Sub ImageMI_Click(sender As Object, e As EventArgs) Handles ImageMI.Click
        miPForm = New Form
        Dim miPB As New PictureBox
        miPForm.Controls.Add(miPB)
        miPB.Dock = DockStyle.Fill
        AddHandler miPForm.FormClosed, AddressOf Me.CloseEvent
        AddHandler miPB.DoubleClick, AddressOf Me.PastePicture
        miPForm.Text = "Imagen"
        miPForm.MdiParent = Me
        miPForm.Show()
        ImageMI.Enabled = False
    End Sub

    Private Sub PastePicture(sender As Object, e As EventArgs)
        Dim miPB As PictureBox = sender
        miPB.Image = Clipboard.GetImage
    End Sub

    Private Sub CloseAllWindows_Click(sender As Object, e As EventArgs) Handles CloseAllWindowsMI.Click
        For Each form1 In Me.MdiChildren
            form1.Close()
        Next
        ImageMI.Enabled = True
        TextMI.Enabled = True
    End Sub

    Private Sub Cascade_Click(sender As Object, e As EventArgs) Handles CascadeMi.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub Horizontalk(sender As Object, e As EventArgs) Handles HorizontalMi.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub Vertical(sender As Object, e As EventArgs) Handles VerticalMI.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CW_click(sender As Object, e As EventArgs) Handles CloseWindowMI.Click
        If Me.ActiveMdiChild.GetHashCode = miTForm.GetHashCode Then
            TextMI.Enabled = True
        Else
            ImageMI.Enabled = True
        End If
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub CloseEvent(sender As Object, e As EventArgs)
        If Me.ActiveMdiChild.GetHashCode = miTForm.GetHashCode Then
            TextMI.Enabled = True
        Else
            ImageMI.Enabled = True
        End If
    End Sub

    Private Sub HelpMI_Click(sender As Object, e As EventArgs) Handles HelpMI.Click
        MessageBox.Show(
            "Ayuda sin instalar",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerLbl.Text = DateTime.Today
    End Sub
End Class