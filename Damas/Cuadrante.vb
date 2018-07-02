Public Class Cuadrante
    Public vacio As Boolean
    Public color As String
    Public pieza As Integer
    Public imagen As PictureBox

    Public Sub New()
        vacio = True
        pieza = New Integer
        imagen = New PictureBox
        color = "X"

        AddHandler imagen.MouseDown, AddressOf imageMouseDown
    End Sub

    Public Sub imageMouseDown(ByVal sender As Object, e As System.Windows.Forms.MouseEventArgs)
        MsgBox(
            "Vacio: " & vacio &
            "Color: " & color &
            "Pieza: " & pieza
        )
    End Sub

End Class
