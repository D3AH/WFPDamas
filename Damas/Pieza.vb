Public Class Pieza
    Private colorValue As String
    Private rangeValue As Integer
    Private imageValue As PictureBox
    Private posicion(1) As Integer
    Private coordenadas As Point

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
        image.Size = New Size(68, 68)
        image.BackColor = Drawing.Color.Black

        'Eventos
        AddHandler image.MouseDown, AddressOf imageMouseDown
        AddHandler image.MouseMove, AddressOf imageMouseMove
        AddHandler image.MouseUp, AddressOf imageMouseUp


        Me.imageValue = image
    End Sub
    'GS Color
    Public Property Color() As String
        Get
            ' Gets the property value.
            Return colorValue
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            colorValue = Value
        End Set
    End Property
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
        Get
            ' Gets the property value.
            Return imageValue
        End Get
        Set(ByVal Value As PictureBox)
            ' Sets the property value.
            imageValue = Value
        End Set
    End Property

    Dim imagenTemporal As New PictureBox

    'Drag And drop
    Public Sub imageMouseDown(ByVal sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Me.posicion(0) = Tablero.LayoutTablero.GetColumn(Me.Image)
        Me.posicion(0) = Tablero.LayoutTablero.GetColumn(Me.Image)
        imagenTemporal.Image = My.Resources.reina_blanca
        coordenadas.Y = Control.MousePosition.Y - sender.top
        coordenadas.X = Control.MousePosition.X - sender.left
        MsgBox(coordenadas.X & " - " & coordenadas.Y)
        imagenTemporal.Location = coordenadas
        imagenTemporal.BringToFront()
        Tablero.Controls.Add(imagenTemporal)
        Me.imageValue.Image = My.Resources.move
    End Sub
    Public Sub imageMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub
    Public Sub imageMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Me.colorValue = "B" Then
            Me.imageValue.Image = My.Resources.peon_blanco
        Else
            Me.imageValue.Image = My.Resources.peon_negro
        End If
    End Sub
End Class