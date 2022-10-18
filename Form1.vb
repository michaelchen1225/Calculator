Public Class Form1

    Dim num1 As Double '數字1
    Dim num2 As Double '數字2
    Dim resault As Double '結果
    Dim stOpetaor As String '算符
    Dim haveDot As Integer '有無小數點

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text & btn0.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text & btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text & btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text & btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text & btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text & btn9.Text
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        haveDot = haveDot + 1

        If haveDot = 1 Then
            txtDisplay.Text = txtDisplay.Text & btnDot.Text
        Else
            MsgBox("不能有兩個小數點, 請按Clear重新輸入數字!!!")
            haveDot = 0
        End If

    End Sub
    Private Sub btnEql_Click(sender As Object, e As EventArgs) Handles btnEql.Click

        Select Case stOpetaor
            Case "+"
                resault = num1 + Val(txtDisplay.Text)
                txtDisplay.Text = resault
            Case "-"
                resault = num1 - Val(txtDisplay.Text)
                txtDisplay.Text = resault
            Case "*"
                resault = num1 * Val(txtDisplay.Text)
                txtDisplay.Text = resault
            Case "/"
                resault = num1 / Val(txtDisplay.Text)
                txtDisplay.Text = resault
        End Select

        num1 = 0
        num2 = 0
        stOpetaor = ""
        resault = 0
        haveDot = 0

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        num2 = Val(txtDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
            Case "-"
                num1 = num1 - num2
            Case "*"
                num1 = num1 * num2
            Case "/"
                num1 = num1 / num2
        End Select
        txtDisplay.Clear()
        stOpetaor = "+"
        num2 = 0
    End Sub
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        num2 = Val(txtDisplay.Text)
        num2 = Val(txtDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
            Case "-"
                num1 = num1 - num2
            Case "*"
                num1 = num1 * num2
            Case "/"
                num1 = num1 / num2
        End Select
        txtDisplay.Clear()
        stOpetaor = "-"
        num2 = 0
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        num2 = Val(txtDisplay.Text)
        num2 = Val(txtDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
            Case "-"
                num1 = num1 - num2
            Case "*"
                num1 = num1 * num2
            Case "/"
                num1 = num1 / num2
        End Select
        txtDisplay.Clear()
        stOpetaor = "*"
        num2 = 0
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        num2 = Val(txtDisplay.Text)
        Select Case stOpetaor
            Case ""
                num1 = num2
            Case "+"
                num1 = num1 + num2
            Case "-"
                num1 = num1 - num2
            Case "*"
                num1 = num1 * num2
            Case "/"
                num1 = num1 / num2
        End Select
        txtDisplay.Clear()
        stOpetaor = "/"
        num2 = 0
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        txtDisplay.Clear()
        num1 = 0
        num2 = 0
        stOpetaor = ""
        resault = 0
        haveDot = 0
    End Sub
End Class
