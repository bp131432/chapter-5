Public Class Form1

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Const intTEST_SCORES As Integer = 5
        Dim intCount As Integer = 1
        Dim decScores As Decimal = 0
        Dim decAverage As Decimal = 0
        Dim strInput As String

        Do While intCount <= intTEST_SCORES
            strInput = InputBox("How many test scores do you want to average?")
            If Decimal.TryParse(strInput, decScores) Then
                decAverage += decScores
                intCount += 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
    End Sub
End Class
