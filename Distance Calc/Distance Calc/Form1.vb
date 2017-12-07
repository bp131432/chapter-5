
Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDistanceTraveled As Integer
        Dim dblX As Integer
        Dim dblTime As Integer

        Do While dblX <= CDbl(txtTime.Text)
            dblX = dblX + 1
            dblDistanceTraveled = (txtSpeed.Text) * dblX
            listResult.Items.Add(dblX & "            " & dblDistanceTraveled)
        Loop
        listResult.Items.Add("Total:" + dblDistanceTraveled.ToString)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
