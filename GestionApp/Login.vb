Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (Usr.Text = "admin") And (Pass.Text = "admin") Then
            Me.Hide()
            Gestion.Show()

        Else
            MsgBox("Usuario incorrecto")




        End If
    End Sub
End Class