﻿Public Class Inicio
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Tablero.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        About.Show()
    End Sub
End Class
