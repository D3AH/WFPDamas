Public Class Tablero
    Public MatrixTablero(7, 7) As PictureBox

    Private Sub Tablero_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ColocarCuadrantes()
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
                Threading.Thread.Sleep(5)
                Refresh()
            Next
        Next
    End Sub

    Private Sub ColocarPiezas()
        Dim piezasBlancas(11) As Pieza
        Dim piezasNegras(11) As Pieza
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
            Controls.Add(piezasNegras(index).Image)
            piezasNegras(index).Image.BringToFront()
            Threading.Thread.Sleep(100)
            Refresh()
        Next

        For index = 0 To 11
            piezasBlancas(index).Image.Location = New Point(matrixBlanca(index, 0) * 75, matrixBlanca(index, 1) * 75)
            Controls.Add(piezasBlancas(index).Image)
            piezasBlancas(index).Image.BringToFront()
            Threading.Thread.Sleep(100)
            Refresh()
        Next
    End Sub

    Private Sub Tablero_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ColocarCuadrantes()
        Me.BackgroundImage = My.Resources.tablero_classic
        ColocarPiezas()
    End Sub
End Class