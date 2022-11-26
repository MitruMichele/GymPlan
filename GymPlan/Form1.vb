Public Class Form1


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String
        Dim Password As String
        Dim f4 As New Form4
        Username = "admin"
        Password = "admin"
        If (Username = txUserACC.Text And Password = txPassword.Text) Then
            Me.Hide()
            f4.Show()
        Else
            MessageBox.Show("username or password is incorrect")
        End If

    End Sub

    Private Sub lkAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkAccount.LinkClicked
        Dim registration As New registration
        registration.txUserReg.Text = "admin"
        registration.txUserReg.Clear()
        registration.txCreaPRE.Text = "admin"
        registration.txCreaPRE.Clear()
        registration.txEmail.Text = "admin@gmail.com"
        registration.txEmail.Clear()
        Me.Hide()
        registration.Show()
    End Sub

    Private Sub cbshowP_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowP.CheckedChanged
        If cbshowP.Checked = True Then
            txPassword.UseSystemPasswordChar = False
        Else
            txPassword.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub txPassword_TextChanged(sender As Object, e As EventArgs) Handles txPassword.TextChanged
        If cbshowP.Checked = True Then
            txPassword.UseSystemPasswordChar = False
        Else
            txPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub lkPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkPass.LinkClicked
        Dim forgotpass As New ForgotPass
        forgotpass.txNewPass.Text = "admin"
        forgotpass.txNewPass.Clear()
        forgotpass.txConfirm.Text = "admin"
        forgotpass.txConfirm.Clear()

        Me.Hide()
        forgotpass.Show()
    End Sub
End Class
