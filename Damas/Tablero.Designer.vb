<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tablero
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
        Me.LayoutTablero = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'LayoutTablero
        '
        Me.LayoutTablero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LayoutTablero.BackgroundImage = Global.Damas.My.Resources.Resources.tablero_classic
        Me.LayoutTablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LayoutTablero.ColumnCount = 8
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.Location = New System.Drawing.Point(0, 0)
        Me.LayoutTablero.Name = "LayoutTablero"
        Me.LayoutTablero.RowCount = 8
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.LayoutTablero.Size = New System.Drawing.Size(440, 440)
        Me.LayoutTablero.TabIndex = 1
        '
        'Tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.LayoutTablero)
        Me.DoubleBuffered = True
        Me.Name = "Tablero"
        Me.Text = "Tablero"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutTablero As TableLayoutPanel
End Class
