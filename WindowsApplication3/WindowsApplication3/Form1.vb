Public Class Form1
    Dim Fval As Double
    Dim Sval As Double
    Dim [operator] As String

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Fval = Val(txt_total.Text)
        txt_total.Text = ""
        txt_total.Focus()
        [operator] = "+"

    End Sub

    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        Dim total As Double

        Sval = Val(txt_total.Text)

        Select Case [operator]
            Case "+"
                total = Fval + Sval
                txt_total.Text = total.ToString()

            Case "-"
                total = Fval - Sval
                txt_total.Text = total.ToString()

            Case "*"
                total = Fval * Sval
                txt_total.Text = total.ToString()

            Case "/"
                total = Fval / Sval
                txt_total.Text = total.ToString()
        End Select
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        Fval = Val(txt_total.Text)
        txt_total.Text = ""
        txt_total.Focus()
        [operator] = "-"
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        Fval = Val(txt_total.Text)
        txt_total.Text = ""
        txt_total.Focus()
        [operator] = "*"
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        Fval = Val(txt_total.Text)
        txt_total.Text = ""
        txt_total.Focus()
        [operator] = "/"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_total.Text = ""
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub
End Class
