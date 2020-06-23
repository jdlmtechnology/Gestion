Public Class Gestion
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then

        Else
            DataGridView1.Rows.Add(New String() {TextBox1.Text})
        End If
        If TextBox2.Text = "" Then

        Else
            DataGridView1.Rows.Add(New String() {"", TextBox2.Text})
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.SelectedRows(0).Cells(0).Value = TextBox3.Text




    End Sub
End Class