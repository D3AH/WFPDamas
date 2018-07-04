Public Class About
    Dim i As Integer = 0
    Dim charArray() As Char = "Author: Diego Auyon; Juego: Damas; Codigo: PE5AM;".ToCharArray
    Dim charCarrita() As Char =
"

         .::::--::::-         
      .::`          `::-      
    `/.                ./.    
   -/    /h-      .h+    /-   
  `+     sy`      `yy     /.  
  o                        o  
  o                        o  
  o  .:.              .:.  o  
  ./..o                o-./-  
   :: `+.            .+` ::   
    -/` -::`      .::- `/-    
      ::-  .::--::.  -::      
        `::::---:::::`        
                              
".ToCharArray

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Hide()
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Label1.Text & charArray(i)
        Refresh()
        i = i + 1

        If i = 20 Or i = 34 Then
            Label1.Text = ""
        End If

        If i = charArray.Length - 1 Then
            Timer2.Enabled = False
            Timer3.Enabled = True
            Label2.Text = ""
            Label2.Show()
            Label1.Hide()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label2.Text = Label2.Text & charCarrita(i)
        Refresh()
        i = i + 1
        If i = charCarrita.Length - 1 Then
            Timer3.Enabled = False
        End If
    End Sub

End Class