Public Class NO
    Private Sub NO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' My.Computer.Network.UploadFile("C:\1.txt", "D:\1.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog With {.Filter = "Все файлы|*.*", .Multiselect = True, .Title = "Выберите файл"}
        OFD.InitialDirectory = "C:\"
        If OFD.ShowDialog() = DialogResult.OK Then
            For Each x As String In OFD.FileNames
                ListBox1.Items.Add(x)
            Next
        End If
    End Sub
End Class