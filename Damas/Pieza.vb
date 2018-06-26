Public Class Pieza
    Private colorValue As String
    Private rangeValue As Integer
    Private coordenadas As Point
    Private coordenadasInicial As Point

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
        Me.Image.BackColor = Color.Black

        'Eventos
        AddHandler image.MouseDown, AddressOf imageMouseDown
        AddHandler image.MouseMove, AddressOf imageMouseMove
        AddHandler image.MouseUp, AddressOf imageMouseUp

    End Sub

    'GS Rango
    Public Property Range() As String
        Get
            ' Gets the property value.
            Return rangeValue
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            rangeValue = Value
        End Set
    End Property

    'GS Imagen
    Public Property Image() As PictureBox

    Public Function moverme(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim z1, z2 As Integer
        If Me.colorValue = "N" And y < 7 Then
            y = y + 1
        ElseIf y > 0 Then
            y = y - 1
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

        If Tablero.MatrixTablero(z1, y).ClientRectangle.Contains(Tablero.MatrixTablero(z1, y).PointToClient(Control.MousePosition)) Then
            Return True
        End If
        If Tablero.MatrixTablero(z2, y).ClientRectangle.Contains(Tablero.MatrixTablero(z2, y).PointToClient(Control.MousePosition)) Then
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

    Public Sub imageMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not moverme(coordenadasInicial.X / 75, coordenadasInicial.Y / 75) Then
            sender.top = coordenadasInicial.Y
            sender.left = coordenadasInicial.X
        Else
            sender.top = Tablero.MatrixTablero(sender.left / 75, sender.top / 75).Location.Y
            sender.left = Tablero.MatrixTablero(sender.left / 75, sender.top / 75).Location.X
        End If
    End Sub

End Class