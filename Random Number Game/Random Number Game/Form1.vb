Public Class Form1
   


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intNum As Integer
        Dim rand As Random
        intNum = rand.Next(100)



        If intNum > CInt(txtGuess.Text) Then
            lblResult.Text = "Your guess was too high"
        ElseIf intNum < CInt(txtGuess.Text) Then
            lblResult.Text = "Your guess was too low"
        ElseIf intNum = CInt(txtGuess.Text) Then
            lblResult.Text = "Congrats you guessed the number"
        End If

    End Sub
End Class
