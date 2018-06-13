<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonJugar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonJugar
        '
        Me.ButtonJugar.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJugar.Font = New System.Drawing.Font("GodOfWar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJugar.Location = New System.Drawing.Point(670, 394)
        Me.ButtonJugar.Name = "ButtonJugar"
        Me.ButtonJugar.Size = New System.Drawing.Size(150, 46)
        Me.ButtonJugar.TabIndex = 0
        Me.ButtonJugar.Text = "Jugar"
        Me.ButtonJugar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Damas.My.Resources.Resources.portrait
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 689)
        Me.Controls.Add(Me.ButtonJugar)
        Me.Name = "Inicio"
        Me.Text = "Damas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonJugar As Button
End Class
