﻿Public Class Reina

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
            image.Image = My.Resources.reina_blanca
        Else
            image.Image = My.Resources.reina_negra
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
                Return Array.IndexOf(Tablero.reinasNegras, Me)
            Else
                Return Array.IndexOf(Tablero.reinasBlancas, Me)
            End If
        End Get
    End Property

    Public Sub Eliminar(ByVal index As Integer)
        If colorValue = "N" Then
            Tablero.Controls.Remove(Tablero.piezasBlancas(index).Image)
        Else
            Tablero.Controls.Remove(Tablero.piezasNegras(index).Image)
        End If
    End Sub

    'Movimientos
    Public Function moverme(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim x1, x2, y1, y2 As Integer

        If x = 0 Then
            x1 = x
        ElseIf x = 7 Then
            x2 = x
        Else
            x1 = x - 1
            x2 = x + 1
        End If

        If y = 0 Then
            y1 = y
            y2 = y + 1
        ElseIf y = 7 Then
            y2 = y
            y1 = y - 1
        Else
            y1 = y - 1
            y2 = y + 1
        End If

        If Tablero.MatrixTablero(x1, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x1, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y1).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y1).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x1, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y2).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y2).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x, y1).vacio Then
            Return True
        ElseIf Tablero.MatrixTablero(x, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x, y2).vacio Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function comer(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim x1, x2, y1, y2 As Integer

        If x = 0 Then
            x1 = x
            x2 = x + 1
        ElseIf x = 7 Then
            x2 = x
            x1 = x - 1
        Else
            x1 = x - 1
            x2 = x + 1
        End If

        If y = 0 Then
            y1 = y
            y2 = y + 1
        ElseIf y = 7 Then
            y2 = y
            y1 = y - 1
        Else
            y1 = y - 1
            y2 = y + 1
        End If

        If Tablero.MatrixTablero(x1, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x1, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y1).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y1).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x1, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x1, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x1, y2).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x2, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x2, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x2, y2).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x, y1).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x, y1).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x, y1).color IsNot colorValue Then
            Return True
        ElseIf Tablero.MatrixTablero(x, y2).imagen.ClientRectangle.Contains(Tablero.MatrixTablero(x, y2).imagen.PointToClient(Control.MousePosition)) And Tablero.MatrixTablero(x, y2).color IsNot colorValue Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub mover(ByVal sender As Object, ByVal posicion As Object, ByVal x As Integer, ByVal y As Integer)
        sender.top = posicion.imagen.Location.Y
        sender.left = posicion.imagen.Location.X
        Tablero.turno = colorValue
        posicion.vacio = False
        posicion.pieza = Index
        posicion.color = colorValue
        Tablero.MatrixTablero(x, y).vacio = True
        Tablero.MatrixTablero(x, y).pieza = Nothing
        Tablero.MatrixTablero(x, y).color = "X"
    End Sub

    Public Sub come(ByVal sender As Object, ByVal posicion As Object, ByVal x As Integer, ByVal y As Integer)
        If colorValue Is "N" Then
            Tablero.comidasxN = Tablero.comidasxN + 1
            Tablero.comidasBlancas.Text = Tablero.comidasxN
        Else
            Tablero.comidasxB = Tablero.comidasxN + 1
            Tablero.comidasNegras.Text = Tablero.comidasxB
        End If
        Eliminar(Tablero.MatrixTablero(posicion.imagen.location.X / 75, posicion.imagen.location.Y / 75).pieza)
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

        If Tablero.comidasxB = 12 Then
            MsgBox("Blancas ganaron!")
            Application.Restart()
        ElseIf Tablero.comidasxN = 12 Then
            MsgBox("Negras ganaron!")
            Application.Restart()
        End If
    End Sub

End Class
