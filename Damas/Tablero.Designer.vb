<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tablero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablero))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.comidasBlancas = New System.Windows.Forms.Label()
        Me.comidasNegras = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 606)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nuevo Juego"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 606)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Location = New System.Drawing.Point(155, 612)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(35, 13)
        Me.LabelTurno.TabIndex = 5
        Me.LabelTurno.Text = "Turno"
        '
        'comidasBlancas
        '
        Me.comidasBlancas.AutoSize = True
        Me.comidasBlancas.Location = New System.Drawing.Point(218, 611)
        Me.comidasBlancas.Name = "comidasBlancas"
        Me.comidasBlancas.Size = New System.Drawing.Size(51, 13)
        Me.comidasBlancas.TabIndex = 7
        Me.comidasBlancas.Text = "Puntos N"
        '
        'comidasNegras
        '
        Me.comidasNegras.AutoSize = True
        Me.comidasNegras.Location = New System.Drawing.Point(275, 611)
        Me.comidasNegras.Name = "comidasNegras"
        Me.comidasNegras.Size = New System.Drawing.Size(50, 13)
        Me.comidasNegras.TabIndex = 8
        Me.comidasNegras.Text = "Puntos B"
        '
        'Tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(600, 637)
        Me.Controls.Add(Me.comidasNegras)
        Me.Controls.Add(Me.comidasBlancas)
        Me.Controls.Add(Me.LabelTurno)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LabelTurno As Label
    Friend WithEvents comidasBlancas As Label
    Friend WithEvents comidasNegras As Label
End Class
