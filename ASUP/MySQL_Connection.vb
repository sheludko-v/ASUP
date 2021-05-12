Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient

Module MySQL_Connection

    Public Function GetConnectionString() As String

        Dim file = My.Application.Info.DirectoryPath & ".\host.ini"
        Dim ip = IO.File.ReadAllText(file, Text.Encoding.Default)

        Dim host As String = "server=" & ip & ";"
        Dim port As String = "port=3306;"
        Dim db As String = "database=up;"
        Dim user As String = "user=rrc;"
        Dim pass As String = "password=0000;"

        Dim conString As String = String.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass)

        Return conString

    End Function

    Public Con As New MySqlConnection(GetConnectionString())
    Public Cmd As MySqlCommand
    Public SQL As String = ""

    Public Function PerformCRUD(Com As MySqlCommand) As DataTable

        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Try

            da = New MySqlDataAdapter()
            da.SelectCommand = Com
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MessageBox.Show("Ошибка: По данному IP адресу сервер не найден. Подробности: " & ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dt = Nothing
        End Try


        Return dt

    End Function


End Module
