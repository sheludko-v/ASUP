Public Class AdminPass
    Private Sub AdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SP.DeleteRecord()
    End Sub
End Class