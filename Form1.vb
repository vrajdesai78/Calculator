Public Class Calculator

    Dim v As Double = Nothing
    Dim v1 As Double = Nothing
    Dim plus As Boolean = False
    Dim minus As Boolean = False
    Dim mul As Boolean = False
    Dim div As Boolean = False
    Dim ans As Double

    Public Function Display_op()
        If v1 = Nothing Then
            If plus Then
                display.Text = $"{v} +"
            ElseIf minus Then
                display.Text = $"{v} -"
            ElseIf mul Then
                display.Text = $"{v} x"
            ElseIf div Then
                display.Text = $"{v} /"
            Else
                display.Text = v
            End If

        ElseIf Not v1 = 0 Then
            If plus Then
                display.Text = $"{v} + {v1}"
            ElseIf minus Then
                display.Text = $"{v} - {v1}"
            ElseIf mul Then
                display.Text = $"{v} x {v1}"
            ElseIf div Then
                display.Text = $"{v} / {v1}"
            End If
        Else
            display.Text = $"{v} + {v1} = {ans}"
        End If

    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 4
            Display_op()
        Else
            v = v * 10 + 4
            Display_op()
        End If

    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 7
            Display_op()
        Else
            v = v * 10 + 7
            Display_op()
        End If
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 8
            Display_op()
        Else
            v = v * 10 + 8
            Display_op()
        End If
    End Sub

    Private Sub Btn_eq_Click(sender As Object, e As EventArgs) Handles Btn_eq.Click
        If plus Then
            plus = False
            ans = v + v1
            display.Text = $"{v} + {v1} = {ans}"
        ElseIf minus Then
            minus = False
            ans = v - v1
            display.Text = $"{v} - {v1} = {ans}"
        ElseIf mul Then
            mul = False
            ans = v * v1
            display.Text = $"{v} x {v1} = {ans}"
        ElseIf div Then
            div = False
            ans = v / v1
            display.Text = $"{v} / {v1} = {ans}"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 5
            Display_op()
        Else
            v = v * 10 + 5
            Display_op()
        End If
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 1
            Display_op()
        Else
            v = v * 10 + 1
            Display_op()
        End If
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 2
            Display_op()
        Else
            v = v * 10 + 2
            Display_op()
        End If
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 3
            Display_op()
        Else
            v = v * 10 + 3
            Display_op()
        End If
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 6
            Display_op()
        Else
            v = v * 10 + 6
            Display_op()
        End If
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 9
            Display_op()
        Else
            v = v * 10 + 9
            Display_op()
        End If
    End Sub

    Private Sub Btn_mn_Click(sender As Object, e As EventArgs) Handles Btn_mn.Click
        minus = True
        Display_op()
    End Sub

    Private Sub Btn_pl_Click(sender As Object, e As EventArgs) Handles Btn_pl.Click
        plus = True
        Display_op()
    End Sub

    Private Sub Btn_mul_Click(sender As Object, e As EventArgs) Handles Btn_mul.Click
        mul = True
        Display_op()
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        div = True
        Display_op()
    End Sub

    Private Sub Btn_clr_Click(sender As Object, e As EventArgs) Handles Btn_clr.Click
        display.Text = ""
        plus = False
        minus = False
        mul = False
        div = False
        v = Nothing
        v1 = Nothing
        ans = Nothing
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 * 10 + 0
            Display_op()
        Else
            v = v * 10 + 0
            Display_op()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NAP.Click
        If plus Or minus Or mul Or div Then
            If v1 < 0 Then
                v1 = v1 - (v1 * 2)
                Display_op()
            ElseIf v1 > 0 Then
                v1 = v1 - (v1 * 2)
                Display_op()
            End If
        Else
            If v < 0 Then
                v = v - (v * 2)
                Display_op()
            ElseIf v > 0 Then
                v = v - (v * 2)
                Display_op()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_ce.Click
        If plus Or minus Or mul Or div Then
            v1 = v1 \ 10
            Display_op()
        Else
            v = v \ 10
            Display_op()
        End If
    End Sub

    Private Sub display_KeyPress(sender As Object, e As KeyPressEventArgs) Handles display.KeyPress
        If e.KeyChar = "0" Then
            Btn_0_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "1" Then
            Btn_1_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "2" Then
            Btn_2_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "3" Then
            Btn_3_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "4" Then
            Button4_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "5" Then
            Button5_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "6" Then
            Btn_6_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "7" Then
            Btn_7_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "8" Then
            Btn_8_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "9" Then
            Btn_9_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Calculator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "0" Then
            Btn_0_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "1" Then
            Btn_1_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "2" Then
            Btn_2_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "3" Then
            Btn_3_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "4" Then
            Button4_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "5" Then
            Button5_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "6" Then
            Btn_6_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "7" Then
            Btn_7_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "8" Then
            Btn_8_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "9" Then
            Btn_9_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click

    End Sub
End Class
