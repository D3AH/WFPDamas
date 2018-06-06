Public Class Pieza
    Private colorValue As String
    Private imageValue As PictureBox
    Private rangeValue As Integer

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

    Public Sub New(ByVal colorValue As String)
        ' Set the property value.
        Me.colorValue = colorValue
        Me.rangeValue = 1
        Dim image As New PictureBox
        If colorValue = "B" Then
            image.Image = System.Drawing.Image.FromFile("..\..\recursos\peon-blanco.png")
        Else
            image.Image = System.Drawing.Image.FromFile("..\..\recursos\peon-negro.png")
        End If
        image.SizeMode = image.SizeMode.StretchImage
        image.Size = New Size(68, 68)
        image.BackColor = Drawing.Color.Black
        AddHandler image.DragDrop, AddressOf Mover
        Me.imageValue = image
    End Sub
    Public Sub Mover()
        MsgBox("hola")
    End Sub


End Class
