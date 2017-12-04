Public Class Form1
    Sub tails()
        picTails.Visible = True
        picHeads.Visible = False
        tailTotal = 1 + tailTotal
    End Sub
    Sub heads()
        picHeads.Visible = True
        picTails.Visible = False
        headTotal = 1 + headTotal
    End Sub

    Dim tailTotal As Integer = 0
    Dim headTotal As Integer = 0
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim Score As Integer = 0
        Dim rand As New Random

        intSideUp = rand.Next(2)
        If intSideUp = 0 Then
            tails()
        Else
            heads()

            lblNumberOfHeads.Text = headTotal.ToString("n")
            lblNumberOfTails.Text = tailTotal.ToString("n")

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
