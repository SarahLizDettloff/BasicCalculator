Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim firstNumber As Double
    Dim secondNumber As Double
    Dim Operation As Integer
    Dim Operator_Selector As Boolean = False


    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "1"
        Else
            lblCalc.Text = "1"
        End If
    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "2"
        Else
            lblCalc.Text = "2"
        End If
    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "3"
        Else
            lblCalc.Text = "3"
        End If
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        firstNumber = lblCalc.Text
        lblCalc.Text = "0"
        Operator_Selector = True
        Operation = 2
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        lblCalc.Text = "0"
    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "4"
        Else
            lblCalc.Text = "4"
        End If
    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "5"
        Else
            lblCalc.Text = "5"
        End If
    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "6"
        Else
            lblCalc.Text = "6"
        End If
    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "7"
        Else
            lblCalc.Text = "7"
        End If
    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "8"
        Else
            lblCalc.Text = "8"
        End If
    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "9"
        Else
            lblCalc.Text = "9"
        End If
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        firstNumber = lblCalc.Text
        lblCalc.Text = "0"
        Operator_Selector = True
        Operation = 1
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        firstNumber = lblCalc.Text
        lblCalc.Text = "0"
        Operator_Selector = True
        Operation = 4
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        firstNumber = lblCalc.Text
        lblCalc.Text = "0"
        Operator_Selector = True
        Operation = 3
    End Sub

    Private Sub ButtonDecimal_Click(sender As Object, e As EventArgs) Handles ButtonDecimal.Click
        If Not (lblCalc.Text.Contains(".")) Then
            lblCalc.Text += "."
        End If
    End Sub

    Private Sub ButtonZero_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click
        If lblCalc.Text <> "0" Then
            lblCalc.Text += "0"
        End If
    End Sub

    Sub Calculate()
        If Operator_Selector = True Then
            secondNumber = lblCalc.Text
            If Operation = 1 Then
                lblCalc.Text = firstNumber + secondNumber
            ElseIf Operation = 2 Then
                lblCalc.Text = firstNumber - secondNumber
            ElseIf Operation = 3 Then
                lblCalc.Text = firstNumber / secondNumber
            ElseIf Operation = 4 Then
                lblCalc.Text = firstNumber * secondNumber
            End If

        End If
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Calculate()
    End Sub

End Class
