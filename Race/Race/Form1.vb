Public Class Form1
    Dim chickScore As Integer = 0
    Dim puppyScore As Integer = 0
    Dim goatScore As Integer = 0
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
        For intCount3 = 16 To rand.Next(200) + 400
            picGoat.Left = intCount3
        Next

        If chickScore < puppyScore And goatScore Then
            lblChick.Text += 1
        ElseIf puppyScore < chickScore And goatScore Then
            lblPuppy.Text += 1
        ElseIf goatScore < puppyScore And chickScore Then
            lblGoat.Text += 1
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picChick.Left = 16
        picGoat.Left = 16
        picPuppy.Left = 16
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
