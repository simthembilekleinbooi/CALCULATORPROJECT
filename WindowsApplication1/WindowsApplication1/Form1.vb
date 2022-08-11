Public Class Form1

    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    //here we have a button click section for integers 

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"
        End If
    End Sub

    //here we have a button click section for cancel

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDisplay.Text = "0"

    End Sub

    //here we have button click section for decimal

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    //here we button click section for adding substract multiply division

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Firstnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 1 '= +
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Firstnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 2 '= -
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Firstnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 3 '= *
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Firstnum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 4 '= /
    End Sub


    //here we have button click section for equal button

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If Operator_Selector = True Then
            secondnum = txtDisplay.Text
            If Operations = 1 Then
                txtDisplay.Text = Firstnum + secondnum
            ElseIf Operations = 2 Then
                txtDisplay.Text = Firstnum - secondnum
            ElseIf Operations = 3 Then
                txtDisplay.Text = Firstnum * secondnum
            Else
                If secondnum = 0 Then
                    txtDisplay.Text = "ERROR!"
                Else
                    txtDisplay.Text = Firstnum / secondnum
                End If
            End If
            Operator_Selector = False
        End If
    End Sub
End Class
