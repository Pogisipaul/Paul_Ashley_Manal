Public Class SUPERCAL
    Dim firstval As Double
    Dim secondval As Double
    Dim [Operator] As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text

    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub equal_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        secondval = Val(total_txtbox.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + secondval
                total_txtbox.Text = Result.ToString()
            Case = "-"
                Result = firstval - secondval
                total_txtbox.Text = Result.ToString()
            Case = "*"
                Result = firstval * secondval
                total_txtbox.Text = Result.ToString()
            Case = "/"
                Result = firstval / secondval
                total_txtbox.Text = Result.ToString()




        End Select




    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub times_btn_Click(sender As Object, e As EventArgs) Handles times_btn.Click
        firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [Operator] = "*"
        total_txtbox.Text = total_txtbox.Text & sender.Text

    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        total_txtbox.Text = ""


    End Sub

    Private Sub plus_btn_Click(sender As Object, e As EventArgs) Handles plus_btn.Click
        firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [Operator] = "+"
        total_txtbox.Text = ""

    End Sub

    Private Sub minus_btn_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [Operator] = "-"
        total_txtbox.Text = total_txtbox.Text & sender.Text
    End Sub

    Private Sub DIVIDE_BTN_Click(sender As Object, e As EventArgs) Handles DIVIDE_BTN.Click
        firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [Operator] = "/"
        total_txtbox.Text = ""

    End Sub
End Class
