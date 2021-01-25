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
        Dim iNumber1 As Double
        Dim iNumber2 As Double
        Dim iAns As Double

        Dim iMethod As Integer

        ' Input path
        iNumber1 = txtValueOne.Text
        iNumber2 = txtValue2.Text

        ' Radio Buttons
        If rbtnAdd.Checked = True Then
            iMethod = 1
        ElseIf rbtnSubtract.Checked = True Then
            iMethod = 2
        ElseIf rbtnMultiply.Checked = True Then
            iMethod = 3
        ElseIf rbtnDivide.Checked = True Then
            iMethod = 4
        End If

        ' Processing Path
        iAns = Calculator(iNumber1, iNumber2, iMethod)

        ' Output
        txtAnswer.Text = iAns

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
