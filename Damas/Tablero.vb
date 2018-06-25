Public Class Tablero
    Private Sub Tablero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ColocarPiezas()
        Dim piezasBlancas(7) As Pieza
        Dim piezasNegras(7) As Pieza
        For index = 0 To 7
            piezasBlancas(index) = New Pieza("B")
            piezasNegras(index) = New Pieza("N")
        Next
        Dim matrixBlanca = New Integer(7, 1) {{0, 1}, {0, 3}, {0, 5}, {0, 7}, {1, 0}, {1, 2}, {1, 4}, {1, 6}}
        Dim matrixNegras = New Integer(7, 1) {{6, 1}, {6, 3}, {6, 5}, {6, 7}, {7, 0}, {7, 2}, {7, 4}, {7, 6}}
        For index = 0 To 7
            piezasBlancas(index).Image.Location = New Point(matrixBlanca(index, 1) * 75, matrixBlanca(index, 0) * 75)
            piezasNegras(index).Image.Location = New Point(matrixNegras(index, 1) * 75, matrixNegras(index, 0) * 75)
            Controls.Add(piezasBlancas(index).Image)
            Controls.Add(piezasNegras(index).Image)
        Next
    End Sub

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColocarPiezas()
    End Sub
End Class