Public Class Frm_Transaction
    Dim Product_1_value As Single
    Dim Product_2_value As Single
    Dim Product_3_value As Single
    Dim Product_4_value As Single
    Dim Product_5_value As Single
    Dim Product_6_value As Single
    Dim Product_7_value As Single
    Dim Product_8_value As Single
    Dim Product_9_value As Single
    Dim Product_10_value As Single
    Dim Total_amount As Single

    Private Sub Frm_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Product_1_value = 20.5
        Product_2_value = 23.23
        Product_3_value = 19.98
        Product_4_value = 24.99
        Product_5_value = 16.77
        Product_6_value = 34.56
        Product_7_value = 40.32
        Product_8_value = 21.4
        Product_9_value = 22.82
        Product_10_value = 25.43

        Lbl_Ord_Pr_Count.Text = 0
        Total_amount = 0
    End Sub

    Private Sub CB_Product_1_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_1.CheckedChanged
        If CB_Product_1.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_1_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_1_value
        End If
    End Sub

    Private Sub CB_Product_2_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_2.CheckedChanged
        If CB_Product_2.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_2_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_2_value
        End If
    End Sub

    Private Sub CB_Product_3_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_3.CheckedChanged
        If CB_Product_3.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_3_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_3_value
        End If
    End Sub

    Private Sub CB_Product_4_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_4.CheckedChanged
        If CB_Product_4.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_4_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_4_value
        End If
    End Sub

    Private Sub CB_Product_5_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_5.CheckedChanged
        If CB_Product_5.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_5_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_5_value
        End If
    End Sub

    Private Sub CB_Product_6_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_6.CheckedChanged
        If CB_Product_6.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_6_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_6_value
        End If
    End Sub

    Private Sub CB_Product_7_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_7.CheckedChanged
        If CB_Product_7.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_7_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_7_value
        End If
    End Sub

    Private Sub CB_Product_8_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_8.CheckedChanged
        If CB_Product_8.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_8_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_8_value
        End If
    End Sub

    Private Sub CB_Product_9_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_9.CheckedChanged
        If CB_Product_9.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_9_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_9_value
        End If
    End Sub

    Private Sub CB_Product_10_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Product_10.CheckedChanged
        If CB_Product_10.Checked = True Then
            Lbl_Ord_Pr_Count.Text += 1
            Total_amount += Product_10_value
        Else
            Lbl_Ord_Pr_Count.Text -= 1
            Total_amount -= Product_10_value
        End If
    End Sub

    Private Sub Btn_Finish_Click(sender As Object, e As EventArgs) Handles Btn_Finish.Click
        Dim next_procedure As MsgBoxResult
        Dim points As Integer
        Dim redeem As MsgBoxResult
        Dim points_left As Integer
        next_procedure = MsgBox("We'll save your preferences in order to show you the total amount", MsgBoxStyle.OkCancel)
        If next_procedure = MsgBoxResult.Ok Then
            If Total_amount >= 25 Then
                points = Math.Floor(Total_amount / 25)
                If points = 10 Then
                    redeem = MsgBox("Congratulations! You have earned a giftcard worth 5 euros. Would you like to redeem it now?", MsgBoxStyle.YesNo)
                    If redeem = MsgBoxResult.Yes Then
                        Total_amount -= 5
                        MsgBox("The total amount is " & Total_amount & " euros")
                        Application.Exit()
                    Else
                        MsgBox("The total amount is " & Total_amount & " euros")
                        Application.Exit()
                    End If
                Else
                    points_left = 10 - points
                    Select Case points_left
                        Case 1
                            MsgBox("You have " & points & " points. There is " & points_left & " point left to win a giftcard worth 5 euros. The total amount is " & Total_amount & " euros")
                            Application.Exit()
                        Case 9
                            MsgBox("You have " & points & " point. There are " & points_left & " points left to win a giftcard worth 5 euros. The total amount is " & Total_amount & " euros")
                            Application.Exit()
                        Case Else
                            MsgBox("You have " & points & " points. There are " & points_left & " points left to win a giftcard worth 5 euros. The total amount is " & Total_amount & " euros")
                            Application.Exit()
                    End Select
                End If
            Else
                MsgBox("The total amount is " & Total_amount & " euros")
                Application.Exit()
            End If
        End If
    End Sub
End Class

