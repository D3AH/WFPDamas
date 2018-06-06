Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim peon1 As New Pieza("Blanca")
        MsgBox("Rango de pieza1: " & peon1.Range)
        LayoutTablero.Controls.Add(peon1.Image, 1, 0)
        LayoutTablero.Controls.Add(peon1.Image, 3, 0)
        LayoutTablero.Controls.Add(peon1.Image, 5, 0)
        LayoutTablero.Controls.Add(peon1.Image, 7, 0)
    End Sub
End Class
