Public Class Number1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const intNUMBER As Integer = 5
        Dim intCount As Integer = 1
        Dim decnumbers As Integer = 0
        Dim decSum As Integer = 0
        Dim strInput As String

            Do While intCount <= intNUMBER
                strInput = InputBox("Enter a positive integer value." & intCount.ToString())
                If Decimal.TryParse(strInput, decnumbers) Then
                    decSum = decSum + decnumbers
                    intCount = intCount + 1
                Else
                    MessageBox.Show("Enter a numeric value")
                End If
            Loop
        lblSum.Text = decSum

       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class