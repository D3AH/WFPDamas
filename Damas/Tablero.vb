Public Class Tablero
    Private Sub Tablero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ColocarCuadrantes()
        Dim MatrixTablero(7, 7) As PictureBox
        For y = 0 To 7
            For x = 0 To 7
                Dim cuadrante As New PictureBox
                If (x + y) Mod 2 = 1 Then
                    cuadrante.Image = My.Resources.negro
                Else
                    cuadrante.Image = My.Resources.blanco
                End If
                cuadrante.Tag = "C" & x & y
                cuadrante.Size = New Size(75, 75)
                cuadrante.Location = New Point(x * 75, y * 75)
                MatrixTablero(x, y) = cuadrante
                Controls.Add(MatrixTablero(x, y))
            Next
        Next
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
        ColocarCuadrantes()
    End Sub
End Class