
Public Class ROOT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text IsNot "" Then
            Dim file = My.Application.Info.DirectoryPath & ".\host.ini"
            Dim file2 = My.Application.Info.DirectoryPath & ".\АСУП РРЦ.exe"
            IO.File.WriteAllText(file, TextBox1.Text, System.Text.Encoding.Default)

            MsgBox("Для применения настроек программа перезагрузится.")
            Close()
            SP.Close()
            Process.Start(file2)
        Else
            MsgBox("Нечего сохранять. Вы ничего не ввели.")
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub


End Class