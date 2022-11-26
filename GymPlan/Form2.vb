Public Class registration
    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim UserName As String
        Dim Email As String
        Dim CreatePassword As String
        UserName = "admin"
        Email = "admin@gmail.com"
        CreatePassword = "admin"
        If (UserName = txUserReg.Text And Email = txEmail.Text And CreatePassword = txCreaPRE.Text) Then
            MessageBox.Show("welcome to Gymplan")
        Else
            MessageBox.Show("you have already an account")
        End If
    End Sub

    Private Sub lkAccRE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkAccRE.LinkClicked
        Dim Account As New Form1
        Account.txUserACC.Text = "admin"
        Account.txUserACC.Clear()
        Account.txPassword.Text = "admin"
        Account.txPassword.Clear()
        Me.Hide()
        Account.Show()

    End Sub
End Class
