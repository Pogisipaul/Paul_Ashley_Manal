Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Varname As String = "HELLO"
        Dim Age As Integer = 20

        Const Maxsize As Integer = 999

        Dim Stringvar As Integer
        Dim Intvar As Integer
        Dim Booleanvar As Integer
        Dim DecimalVar As Decimal

        Stringvar = "this is string"
        Intvar = 345353
        Booleanvar = False
        DecimalVar = 34.565656
        'COMPARISON OPERATORS
        '  =
        If (1 = 1) Then
            MsgBox("TRUE")
        End If
        ' <> not equal
        If (45 <> 78) Then
            MsgBox("TRUE")
        End If
        ' greaterthan
        If (100 > 85) Then
            MsgBox("TRUE")
        End If
        ' lessthan
        If (35 < 65) Then
            MsgBox("TRUE")
        End If

        ' greaterthan equal
        If (100 >= 99) Then
        End If

        'lessthan equal
        If (100 <= 101) Then
            MsgBox("TRUE")
        End If


        ' logical operator
        ' AND
        Dim price As Integer = 25
        If price > 20 And price > 0 Then
            MsgBox("true")
        End If

        'OR
        If price < 10 Or price < 0 Then
            MsgBox(price < 10 Or price > 0)
        End If

        Age = 10
        If Age = 10 Then
            'TRUE
            MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")

        End If

        Age = 10
        If Age = 10 Then
            If Age > 9 Then
                'TRUE
                MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10 & greaterthan 9")
            End If
        End If

        If Age > 0 Then
            'TRUE
            MessageBox.Show("ITS TRUE age is greater than 0")
        End If

        If Age > 11 Then
            'FALSE
            MessageBox.Show("ITS FALSE, AGE IS NOT greater than TO 11")
        End If


        Dim grade As Char
        grade = "B"
        Select Case grade
            Case "A"
                MessageBox.Show("Excellent")

            Case "B", "C"
                MessageBox.Show("Well done")
            Case "D"
                MessageBox.Show("You passed")
            Case "F"
                MessageBox.Show("Better try again")
            Case Else
                MessageBox.Show("Invalid grade")
        End Select


        Age = 10
        If Age = 11 Then
            'TRUE
            MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")
        Else
            'FALSE
            MessageBox.Show("ITS FALSE, AGE 15 IS NOT EQUAL TO 10")

        End If

        If Age >= 100 Then
            MsgBox("DINOSAUR AGE")
        ElseIf Age >= 90 Then
            MsgBox("Century Age")
        ElseIf Age >= 80 Then
            MsgBox("Grandfather Age")

        End If

























    End Sub

    Private Sub Evaluate_btn_Click(sender As Object, e As EventArgs) Handles Evaluate_btn.Click
        Dim Age As Integer = Convert.ToDecimal(age_textbox.Text)


        If Age >= 100 Then
            MsgBox("DINOSAUR AGE")
        ElseIf Age >= 90 Then
            MsgBox("Century Age")
        ElseIf Age >= 80 Then
            MsgBox("Grandfather Age")
        ElseIf Age >= 60 Then
            MsgBox("Senior Citizen Age")
        ElseIf Age >= 45 Then
            MsgBox("Middle Age")
        ElseIf Age <= 30 Then
            MsgBox(" Young")
        Else
            MsgBox("Unknown Age")

        End If
    End Sub
End Class
