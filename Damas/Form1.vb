Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim piezasBlancas(7) As Pieza
        Dim piezasNegras(7) As Pieza
        For index = 0 To 7
            piezasBlancas(index) = New Pieza("B")
            piezasNegras(index) = New Pieza("N")
        Next
        Dim matrixBlanca = New Integer(7, 1) {{0, 1}, {0, 3}, {0, 5}, {0, 7}, {1, 0}, {1, 2}, {1, 4}, {1, 6}}
        Dim matrixNegras = New Integer(7, 1) {{6, 1}, {6, 3}, {6, 5}, {6, 7}, {7, 0}, {7, 2}, {7, 4}, {7, 6}}
        For index = 0 To 7
            LayoutTablero.Controls.Add(piezasBlancas(index).Image, matrixBlanca(index, 1), matrixBlanca(index, 0))
            LayoutTablero.Controls.Add(piezasNegras(index).Image, matrixNegras(index, 1), matrixNegras(index, 0))
        Next
    End Sub
End Class
