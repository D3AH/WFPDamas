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
    End Sub

    Public Sub imageMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.top = coordenadasInicial.Y
        sender.left = coordenadasInicial.X
    End Sub

End Class