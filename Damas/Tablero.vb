Public Class Tablero

    Public MatrixTablero(7, 7) As Cuadrante
    Public turno = "B"
    Public piezasBlancas(11) As Pieza
    Public piezasNegras(11) As Pieza
    Public reinasBlancas(11) As Reina
    Public reinasNegras(11) As Reina
    Public comidasxN As Integer = 0
    Public comidasxB As Integer = 0

    Private Sub Tablero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ColocarCuadrantes()
        For y = 0 To 7
            For x = 0 To 7
                Dim cuadrante As New Cuadrante
                If (x + y) Mod 2 = 1 Then
                    cuadrante.imagen.Image = My.Resources.negro
                Else
                    cuadrante.imagen.Image = My.Resources.blanco
                End If
                cuadrante.imagen.Size = New Size(75, 75)
                cuadrante.imagen.Location = New Point(x * 75, y * 75)
                MatrixTablero(x, y) = cuadrante
                Controls.Add(MatrixTablero(x, y).imagen)
                Threading.Thread.Sleep(5)
                Refresh()
            Next
        Next
    End Sub

    Private Sub ColocarPiezas()
        For index = 0 To 11
            piezasBlancas(index) = New Pieza("B")
            piezasNegras(index) = New Pieza("N")
        Next
        'Posiciones iniciales de piezas negras
        Dim matrixNegra = New Integer(11, 1) {{1, 0}, {3, 0}, {5, 0}, {7, 0},
                                               {0, 1}, {2, 1}, {4, 1}, {6, 1},
                                               {1, 2}, {3, 2}, {5, 2}, {7, 2}}
        'Posiciones iniciales de piezas blancas
        Dim matrixBlanca = New Integer(11, 1) {{0, 5}, {2, 5}, {4, 5}, {6, 5},
                                               {1, 6}, {3, 6}, {5, 6}, {7, 6},
                                               {0, 7}, {2, 7}, {4, 7}, {6, 7}}
        For index = 0 To 11
            piezasNegras(index).Image.Location = New Point(matrixNegra(index, 0) * 75, matrixNegra(index, 1) * 75)
            MatrixTablero(matrixNegra(index, 0), matrixNegra(index, 1)).vacio = False
            MatrixTablero(matrixNegra(index, 0), matrixNegra(index, 1)).pieza = index
            MatrixTablero(matrixNegra(index, 0), matrixNegra(index, 1)).color = "N"
            Controls.Add(piezasNegras(index).Image)
            piezasNegras(index).Image.BringToFront()
            Threading.Thread.Sleep(10)
            Refresh()
        Next

        For index = 0 To 11
            piezasBlancas(index).Image.Location = New Point(matrixBlanca(index, 0) * 75, matrixBlanca(index, 1) * 75)
            MatrixTablero(matrixBlanca(index, 0), matrixBlanca(index, 1)).vacio = False
            MatrixTablero(matrixBlanca(index, 0), matrixBlanca(index, 1)).pieza = index
            MatrixTablero(matrixBlanca(index, 0), matrixBlanca(index, 1)).color = "B"
            Controls.Add(piezasBlancas(index).Image)
            piezasBlancas(index).Image.BringToFront()
            Threading.Thread.Sleep(10)
            Refresh()
        Next
    End Sub

    Private Sub Tablero_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ColocarCuadrantes()
        Me.BackgroundImage = My.Resources.tablero_classic
        ColocarPiezas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
    End Sub

End Class
