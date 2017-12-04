Public Class Form1
    Dim chickScore As Integer
    Dim puppyScore As Integer
    Dim goatScore As Integer
    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim rand As New Random
        Dim intCount1 As Integer
        Dim intCount2 As Integer
        Dim intCount3 As Integer

        For intCount1 = 16 To rand.Next(200) + 400
            picChick.Left = intCount1
        Next
        For intCount2 = 16 To rand.Next(200) + 400
            picPuppy.Left = intCount2
        Next
        For intCount3 = 16 To rand.Next(200) + 0
            picGoat.Left = intCount3
        Next

        If intCount1 > intCount2 And intCount3 Then
            chickScore = 1 + chickScore
        ElseIf intCount2 > intCount1 And intCount3 Then
            puppyScore = 1 + puppyScore
        ElseIf intCount3 > intCount2 And intCount1 Then
            goatScore = 1 + goatScore
        End If

        lblChick.Text = chickScore
        lblGoat.Text = goatScore
        lblPuppy.Text = puppyScore
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picChick.Left = 16
        picGoat.Left = 16
        picPuppy.Left = 16

        lblChick.Text = ""
        lblGoat.Text = ""
        lblPuppy.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
