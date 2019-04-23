Public Class frmMain
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        'Use try method to prevent error's
        Try
            'Get the letter grade from Function
            txtLetterGrade.Text = GetLetterGradeFromPercentage(txtPercentage.Text)
        Catch ex As Exception
            'There was an data error!
            MsgBox("Data Error!")
        End Try
    End Sub


    'Function to calculate the percentage
    Public Function GetLetterGradeFromPercentage(ByVal percentage As Integer)

        'Define letter grade as nothing for the start
        Dim LetterGrade As String = ""

        'Check if the percentage falls in between the data range
        If percentage >= 90 Then
            'define the letter grade
            LetterGrade = "A"

            txtLetterGrade.BackColor = Color.Lime
        ElseIf percentage >= 80 Then
            'define the letter grade
            LetterGrade = "B"

            txtLetterGrade.BackColor = Color.Lime
        ElseIf percentage >= 70 Then
            'define the letter grade
            LetterGrade = "C"

            txtLetterGrade.BackColor = Color.Yellow
        ElseIf percentage >= 60 Then
            'define the letter grade
            LetterGrade = "D"

            txtLetterGrade.BackColor = Color.Orange
        ElseIf percentage >= 50 Then
            'define the letter grade
            LetterGrade = "E"

            txtLetterGrade.BackColor = Color.DarkOrange
        ElseIf percentage < 50 Then
            'define the letter grade
            LetterGrade = "N"

            txtLetterGrade.BackColor = Color.Red
        Else
            'display error due to number/char's outside the range
            LetterGrade = "ERR"

            txtLetterGrade.BackColor = Color.Purple
        End If

        'retrun the data to the OG entity
        Return LetterGrade
    End Function
End Class
