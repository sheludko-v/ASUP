Public Class ABOUT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label5.Text = "© Республиканский Реабилитационный Центр " & Now.Year & "."

    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        System.Diagnostics.Process.Start("http://www.rrcdnr.ru")
    End Sub
End Class