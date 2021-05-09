Public Class FormPass
    Private Sub FormPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If login.Text = "admin" And password.Text = "111" Then
            ADMIN.Show()
            Me.Close()
        ElseIf login.Text = "sp" And password.Text = "111" Then
            SP.Show()
            Me.Close()
        ElseIf login.Text = "stat" And password.Text = "111" Then
            STAT.Show()
            Me.Close()
        ElseIf login.Text = "nh1" And password.Text = "111" Then
            NH1.Show()
            Me.Close()
        ElseIf login.Text = "nh2" And password.Text = "111" Then
            NH2.Show()
            Me.Close()
        ElseIf login.Text = "no" And password.Text = "111" Then
            NO.Show()
            Me.Close()
        ElseIf login.Text = "zp" And password.Text = "111" Then
            ZP.Show()
            Me.Close()
        ElseIf login.Text = "oda" And password.Text = "111" Then
            ODA.Show()
            Me.Close()
        Else
            MessageBox.Show("Неверный логин или пароль!!!")
        End If
    End Sub

End Class