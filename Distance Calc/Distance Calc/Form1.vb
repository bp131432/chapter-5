Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intSpeed As Integer
        Dim intTime As Integer
        Dim decTotalDistance As Decimal = 0
        Dim decMPH As Decimal
        Dim strInput As String
        Try
            For intTime As Integer = 1 To intTime
                decMPH = intTime * intSpeed
                Do While intTime > 1
                    intTime = intTime - 1
                Loop
            Next
        Catch ex As Exception
            intTime = txtTime.Text
            intSpeed = txtSpeed.Text
        End Try
        listResult.Items.Add(intTime)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
