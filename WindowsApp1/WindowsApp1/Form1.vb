Public Class Form1






    ' Dos cajas de texto cuyo contenido text se concatenan en el text del form cuando se pulse un Button asociado a dicha función.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine("clickMouse")
        Me.Text = TextBox1.Text & " " & TextBox2.Text
    End Sub

    ' Un Button que nos ejecute un proceso Sub asociado a su evento Click.
    ' Dicho proceso realizará un cambio en su propiedad Text, mostrando que ese botón ya ha sido pulsado.
    ' Si lo pulsamos de nuevo hará que emerja un mensaje diciendo que ya lo hemos pulsado.
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.Click
        Static bool As Boolean

        If bool Then
            MessageBox.Show(Me, "Ya has pùlsado el boton", "Aviso", MessageBoxButtons.OK)
        Else
            bool = True
            Button2.Text = "Boton Pulsado"
        End If
    End Sub

    ' Otro Button que indique un solo número como text con valor inicial a 0 y cada pulsación aumenta en +1
    Private Sub Button1_MouseClick(sender As Object, e As EventArgs) Handles Button4.Click
        Static i As Integer
        i += 1
        Button4.Text = i
    End Sub

    ' Un LabelTex que si le damos un doble Click haremos que su texto aumente con un carácter “P”.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text &= "P"
    End Sub

    ' Realiza un panel con 4 RadioButton que cada vez que se cambie de opción, muestre por mensaje
    ' emergente el texto del RadioButton seleccionado.
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        Dim button As RadioButton = sender 'no es necesario
        MessageBox.Show(Me, sender.Text, "Aviso", MessageBoxButtons.OK)
    End Sub
End Class
