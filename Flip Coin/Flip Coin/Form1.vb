Public Class Form1

    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim tailTotal As Integer = 0
        Dim headTotal As Integer = 0

        Dim rand As New Random

            intSideUp = rand.Next(2)
            If intSideUp = 0 Then
                picTails.Visible = True
                picHeads.Visible = False
                tailTotal = 1 + tailTotal
            Else
                picHeads.Visible = True
                picTails.Visible = False
                headTotal = 1 + headTotal

                lblNumberOfHeads.Text = headTotal.ToString("n")
                lblNumberOfTails.Text = tailTotal.ToString("n")

            End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
