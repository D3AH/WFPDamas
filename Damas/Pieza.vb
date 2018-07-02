Public Class Pieza
    Private ReadOnly colorValue As String
    Private rangeValue As Integer
    Private coordenadas As Point
    Private coordenadasInicial As Point
    Public Image As PictureBox

    'Constructor
    Public Sub New(ByVal colorValue As String)
        ' Set the property value.
        Me.colorValue = colorValue
        Me.rangeValue = 1

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

    Public ReadOnly Property Index() As Integer
        Get
            If colorValue = "N" Then
                Return Array.IndexOf(Tablero.piezasNegras, Me)
            Else
                Return Array.IndexOf(Tablero.piezasBlancas, Me)
            End If
        End Get
    End Property

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
        'Determina el turno
        If colorValue Is Tablero.turno Then
            sender.top = coordenadasInicial.Y
            sender.left = coordenadasInicial.X
            'Determina si se puede mover
        ElseIf moverme(x, y) Then
            Dim posicion = Tablero.MatrixTablero((Tablero.MousePosition.X - Tablero.Left) \ 75, (Tablero.MousePosition.Y - Tablero.Top) \ 75)
            sender.top = posicion.imagen.Location.Y
            sender.left = posicion.imagen.Location.X
            Tablero.turno = colorValue
            posicion.vacio = False
            posicion.pieza = Me.Index
            Tablero.MatrixTablero(x, y).vacio = True
            Tablero.MatrixTablero(x, y).pieza = Nothing
            'En el caso contrario devuelva a la posicion inicial
        Else
            sender.top = coordenadasInicial.Y
            sender.left = coordenadasInicial.X
        End If
    End Sub

End Class