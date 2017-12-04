Public Class RPS
    Dim winCount As Integer = 0
    Dim compCount As Integer = 0
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Randomize()

        Dim num As Integer ' variable to hold random number (computer choice)
        Const ROCK = 1
        Const PAPER = 2
        Const SCISSORS = 3

        num = CInt((3 * Rnd())) ' generate random numbers 1-3

        If rockRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose rock too. Tie!"
        ElseIf rockRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper. You Lose!"
            compCount += 1
        ElseIf rockRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors. You Win!"
            winCount += 1
        ElseIf paperRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose rock. You Win!"
            winCount += 1
        ElseIf paperRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper too. Tie!"
        ElseIf paperRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors. You Lose!"
            compCount += 1

        ElseIf scissorsRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose rock. You Lose!"
            compCount += 1
        ElseIf scissorsRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper. You Win!"
            winCount += 1
        ElseIf scissorsRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors too. Tie!"
        End If

        lblScore.Text = winCount
        lblComputer.Text = compCount
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
