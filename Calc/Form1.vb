' Code by Charlie McMahon - 2021
Public Class Form1

    Function Calculator(number1 As Double, number2 As Double, method As Integer) As Double
        If method = 1 Then
            ' Addition
            Return (number1 + number2)
        ElseIf method = 2 Then
            ' Subtraction
            Return (number1 - number2)
        ElseIf method = 3 Then
            ' Multipication
            Return (number1 * number2)
        ElseIf method = 4 Then
            ' Division
            Return (number1 / number2)
        End If
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add Button
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iAns As Integer

        ' Input path
        iNumber1 = txtValueOne.Text
        iNumber2 = txtValue2.Text

        ' Processing Path
        iAns = Calculator(iNumber1, iNumber2, 1)

        ' Output
        txtAnswer.Text = iAns

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
