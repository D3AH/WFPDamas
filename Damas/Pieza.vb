Public Class Pieza
    Private ReadOnly colorValue As String
    Private coordenadas As Point
    Private coordenadasInicial As Point
    Public Image As PictureBox

    'Constructor
    Public Sub New(ByVal colorValue As String)
        ' Set the property value.
        Me.colorValue = colorValue

        Dim image As New PictureBox
        If colorValue = "B" Then
            image.Image = My.Resources.peon_blanco
        Else
            image.Image = My.Resources.peon_negro
        End If

        image.SizeMode = 1
        image.Size = New Size(75, 75)

        Me.Image = image
        Me.Image.BringToFront()
        Me.Image.BackColor = Color.Transparent

        'Eventos
        AddHandler image.MouseDown, AddressOf imageMouseDown
        AddHandler image.MouseMove, AddressOf imageMouseMove
        AddHandler image.MouseUp, AddressOf imageMouseUp

    End Sub

    'Propiedades computadas
    Public ReadOnly Property Index() As Integer
        Get
            If colorValue = "N" Then
                Return Array.IndexOf(Tablero.piezasNegras, Me)
            Else
                Return Array.IndexOf(Tablero.piezasBlancas, Me)
            End If
        End Get
    End Property

    Public Sub Lista(ByVal index As Integer)
        If colorValue = "N" Then
            Tablero.Controls.Remove(Tablero.piezasBlancas(index).Image)
        Else
            Tablero.Controls.Remove(Tablero.piezasNegras(index).Image)
        End If
    End Sub

    'Movimientos
    Public Function moverme(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim z1, z2 As Integer
        If Me.colorValue = "N" And y < 7 Then
            y = y + 1
        ElseIf y > 0 Then
            y = y - 1
        Else
            Return False
        End If
        If x = 0 Then
            z1 = x + 1
            z2 = x + 1
        ElseIf x = 7 Then
            z2 = x - 1
            z1 = x - 1
        Else
            z1 = x - 1
            z2 = x + 1
        End If

        If Tablero.MatrixTablero(z1, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(z1, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(z1, y).vacio Then
            Return True
        End If
        If Tablero.MatrixTablero(z2, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(z2, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(z2, y).vacio Then
            Return True
        End If
    End Function

    Public Function comer(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim z1, z2, z3, z4, y2 As Integer
        If Me.colorValue = "N" And y < 7 Then
            y = y + 1
        ElseIf y > 0 Then
            y = y - 1
        Else
            MsgBox("Ups1")
            Return False
        End If
        If x = 0 Then
            z1 = x + 1
            z2 = x + 1
        ElseIf x = 7 Then
            z2 = x - 1
            z1 = x - 1
        Else
            z1 = x - 1
            z2 = x + 1
        End If

        If Me.colorValue = "N" And y <= 6 Then
            y2 = y + 1
        ElseIf y >= 1 Then
            y2 = y - 1
        Else
            MsgBox("Ups")
            Return False
        End If
        If x = 1 Then
            z3 = z1 + 1
            z4 = z2 + 1
        ElseIf x = 6 Then
            z3 = z1 - 1
            z4 = z2 - 1
        Else
            z3 = z1 - 1
            z4 = z2 + 1
        End If

        If Tablero.MatrixTablero(z3, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(z3, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(z3, y2).vacio And Tablero.MatrixTablero(z1, y).color IsNot colorValue Then
            Return True
        End If
        If Tablero.MatrixTablero(z4, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(z4, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(z4, y2).vacio And Tablero.MatrixTablero(z2, y).color IsNot colorValue Then
            Return True
        End If
    End Function

    Public Sub mover(ByVal sender As Object, ByVal posicion As Object, ByVal x As Integer, ByVal y As Integer)
        sender.top = posicion.imagen.Location.Y
        sender.left = posicion.imagen.Location.X
        Tablero.turno = colorValue
        posicion.vacio = False
        posicion.pieza = Me.Index
        posicion.color = colorValue
        Tablero.MatrixTablero(x, y).vacio = True
        Tablero.MatrixTablero(x, y).pieza = Nothing
        Tablero.MatrixTablero(x, y).color = "X"
    End Sub

    Public Sub come(ByVal sender As Object, ByVal posicion As Object, ByVal x As Integer, ByVal y As Integer)
        If x > posicion.imagen.Location.X / 75 Then
            'Izquierda
            x = x - 1
        Else
            'Derecha
            x = x + 1
        End If

        If colorValue Is "N" Then
            y = y + 1
            Tablero.comidasxN = Tablero.comidasxN + 1
            Tablero.comidasBlancas.Text = Tablero.comidasxN
        Else
            y = y - 1
            Tablero.comidasxB = Tablero.comidasxB + 1
            Tablero.comidasNegras.Text = Tablero.comidasxB
        End If
        Me.Lista(Tablero.MatrixTablero(x, y).pieza)
        Tablero.MatrixTablero(x, y).vacio = True
        Tablero.MatrixTablero(x, y).pieza = Nothing
        Tablero.MatrixTablero(x, y).color = "X"
    End Sub

    'Drag And drop
    Public Sub imageMouseDown(ByVal sender As Object, e As System.Windows.Forms.MouseEventArgs)
        coordenadas.Y = Control.MousePosition.Y - sender.top
        coordenadas.X = Control.MousePosition.X - sender.left

        coordenadasInicial.Y = sender.top
        coordenadasInicial.X = sender.left
    End Sub

    Public Sub imageMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            sender.top = Control.MousePosition.Y - coordenadas.Y
            sender.left = Control.MousePosition.X - coordenadas.X
        End If
        sender.bringtofront()
    End Sub

    Public Sub imageMouseUp(ByVal sender As Object, ByVal __ As System.Windows.Forms.MouseEventArgs)
        Dim x As Integer = coordenadasInicial.X / 75
        Dim y As Integer = coordenadasInicial.Y / 75
        Dim posicion = Tablero.MatrixTablero((Tablero.MousePosition.X - Tablero.Left) \ 75, (Tablero.MousePosition.Y - Tablero.Top) \ 75)
        'Determina el turno
        If colorValue Is Tablero.turno Then
            sender.top = coordenadasInicial.Y
            sender.left = coordenadasInicial.X
            'Determina si se puede mover
        ElseIf moverme(x, y) Then
            mover(sender, posicion, x, y)
        ElseIf comer(x, y) Then
            mover(sender, posicion, x, y)
            come(sender, posicion, x, y)
            'En el caso contrario devuelva a la posicion inicial
        Else
            sender.top = coordenadasInicial.Y
            sender.left = coordenadasInicial.X
        End If

        If posicion.imagen.Location.Y = 0 Or posicion.imagen.Location.Y = 525 Then
            If colorValue = "N" Then
                Dim reina = New Reina("N")
                reina.Image.Location = New Point(posicion.imagen.Location)
                Tablero.reinasNegras(posicion.pieza) = reina
                Tablero.Controls.Add(Tablero.reinasNegras(posicion.pieza).Image)
                Tablero.reinasNegras(posicion.pieza).Image.BringToFront()
                Tablero.Controls.Remove(Me.Image)
            Else
                Dim reina = New Reina("B")
                reina.Image.Location = New Point(posicion.imagen.Location)
                Tablero.reinasBlancas(posicion.pieza) = reina
                Tablero.Controls.Add(Tablero.reinasBlancas(posicion.pieza).Image)
                Tablero.reinasBlancas(posicion.pieza).Image.BringToFront()
                Tablero.Controls.Remove(Me.Image)
            End If
        End If

        If Tablero.comidasxB = 12 Then
            MsgBox("Blancas ganaron!")
            Application.Restart()
        ElseIf Tablero.comidasxN = 12 Then
            MsgBox("Negras ganaron!")
            Application.Restart()
        End If

        Tablero.LabelTurno.Text = Tablero.turno
    End Sub

End Class