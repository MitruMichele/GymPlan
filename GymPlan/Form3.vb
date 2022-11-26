Public Class ForgotPass
    Dim NewPass As String
    Dim Confirmation As String

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        NewPass = "admin"
        Confirmation = "admin"
        If (NewPass = txNewPass.Text And Confirmation = txConfirm.Text) Then
            MessageBox.Show(" your password has been successfully changed")
        Else
            MessageBox.Show("the values entered dont match")
        End If
        Me.Hide()
        Form1.Show()
    End Sub
End Class