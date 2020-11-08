Public Class about

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Left < -400 Then
            Label1.Left = 400
        Else
            Label1.Left -= 2

        End If
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

End Class