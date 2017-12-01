Public Class RPS

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Randomize()

        Dim num As Integer ' variable to hold random number (computer choice)
        Const ROCK = 1
        Const PAPER = 2
        Const SCISSORS = 3

        num = CInt((3 * Rnd())) ' generate random numbers 1-3
        Dim winCount As Integer = 0
        Dim matchCount As Integer = 0
        Dim compCount As Integer = 0

        If rockRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose Rock too. Tie!"
        ElseIf rockRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper. You Lose!"
            compCount += 1
        ElseIf rockRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors. You Win!"
            winCount += 1
        ElseIf paperRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose Rock. You Win!"
            winCount += 1
        ElseIf paperRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper too. Tie!"
        ElseIf paperRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors. You Lose!"
            compCount += 1

        ElseIf scissorsRadioButton.Checked And num = ROCK Then
            resultLabel.Text = "Computer chose Rock. You Lose!"
            compCount += 1
        ElseIf scissorsRadioButton.Checked And num = PAPER Then
            resultLabel.Text = "Computer chose paper. You Win!"
            winCount += 1
        ElseIf scissorsRadioButton.Checked And num = SCISSORS Then
            resultLabel.Text = "Computer chose scissors too. Tie!"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
