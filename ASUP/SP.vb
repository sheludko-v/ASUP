
Imports MySql.Data.MySqlClient

Public Class SP

    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim desktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

    Private ID As String = ""
    Private intRow As Integer = 0
    Private rc As Object
    Public Property Preview As Object

    Private Sub SP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim file = My.Application.Info.DirectoryPath & ".\host.ini"
        If IO.File.Exists(file) = True Then
            LoadData()
            ResetMe()
        Else
            ROOT.Show()
            Close()
        End If

        AcceptButton = SearchBtn
        UNIT.DropDownStyle = ComboBoxStyle.DropDownList
        VKK.DropDownStyle = ComboBoxStyle.DropDownList

        Today.Text = "Сегодня: " & Now.ToLongDateString

        If intRow = 0 Then
            RecordsCount.Text = "База данных пустая :("
        End If
    End Sub


    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()

        Cmd.Parameters.AddWithValue("Full_name", FIO.Text.Trim())
        Cmd.Parameters.AddWithValue("Dob", DOB.Value.ToShortDateString.Trim())
        Cmd.Parameters.AddWithValue("Adress", ADRESS.Text.Trim())
        Cmd.Parameters.AddWithValue("Diag", DIAG.Text.Trim())
        Cmd.Parameters.AddWithValue("Work", WORK.Text.Trim())
        Cmd.Parameters.AddWithValue("Date_enter", D_ENTER.Value.ToShortDateString.Trim())
        Cmd.Parameters.AddWithValue("Unit", UNIT.SelectedItem.ToString())
        Cmd.Parameters.AddWithValue("Vkk", VKK.SelectedItem.ToString())

        If str = "Save" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("ID", Me.ID)
        End If
    End Sub

    Private Sub LoadData(Optional keyword As String = "")

        SQL = "SELECT id, full_name, dob, adress, diag, work, date_enter, date_exit, unit, vkk FROM patients WHERE id LIKE @keyword1 OR 
               full_name LIKE @keyword1 OR dob LIKE @keyword1 OR adress LIKE @keyword1 OR diag LIKE @keyword1 OR 
               work LIKE @keyword1 OR date_enter LIKE @keyword1 OR date_exit LIKE @keyword1 OR unit LIKE @keyword1 OR 
               vkk LIKE @keyword1 ORDER BY id DESC;"

        Dim strKeyword As String = String.Format("%{0}%", keyword)

        Cmd = New MySqlCommand(SQL, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword1", strKeyword)
        Cmd.Parameters.AddWithValue("keyword2", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)

        If dt.Rows.Count > 0 Then
            intRow = Convert.ToInt32(dt.Rows.Count.ToString())
        Else
            intRow = 0
        End If

        If intRow = 0 Then
            RecordsCount.Text = "База данных пустая :("
        Else
            RecordsCount.Text = "Количество записей в базе: " & intRow.ToString() & "."
        End If


        With SPData
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "№"
            .Columns(1).HeaderText = "ФИО"
            .Columns(2).HeaderText = "Дата рождения"
            .Columns(3).HeaderText = "Адрес"
            .Columns(4).HeaderText = "Диагноз"
            .Columns(5).HeaderText = "Место работы"
            .Columns(6).HeaderText = "Дата поступления"
            .Columns(7).HeaderText = "Дата выписки"
            .Columns(8).HeaderText = "Отделение"
            .Columns(9).HeaderText = "ВКК"

            .Columns(0).Width = 50
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 250
            .Columns(4).Width = 300
            .Columns(5).Width = 200
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 50

        End With

    End Sub

    Private Sub ResetMe()

        SPData.ClearSelection()

        ID = ""

        FIO.Text = ""
        ADRESS.Text = ""
        DIAG.Text = ""
        WORK.Text = ""

        If UNIT.Items.Count > 0 Then
            UNIT.SelectedIndex = 5
        End If
        If VKK.Items.Count > 0 Then
            VKK.SelectedIndex = 2
        End If

        SearchText.Clear()
        SearchText.Select()

        DOB.ResetText()
        D_ENTER.ResetText()
        EnterDate.ResetText()
        ExitDate.ResetText()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadData()
        ResetMe()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If String.IsNullOrEmpty(FIO.Text.Trim()) Then
            MsgBox("Введите ФИО", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(ADRESS.Text.Trim()) Then
            MsgBox("Введите адрес", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DIAG.Text.Trim()) Then
            MsgBox("Введите диагноз", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(WORK.Text.Trim()) Then
            MsgBox("Введите место работы", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If UNIT.SelectedIndex = 5 Then
            MsgBox("Выберите отделение", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If VKK.SelectedIndex = 2 Then
            MsgBox("Выберите наличие ВКК", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If
        If DOB.Value.ToShortDateString.Trim() = Now.ToShortDateString Then
            MsgBox("Выберите дату рождения", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            Exit Sub
        End If



        SQL = "INSERT INTO patients(full_name, dob, adress, diag, work, date_enter, unit, vkk) 
               VALUES(@Full_name, @Dob, @Adress, @Diag, @Work, @Date_enter, @Unit, @Vkk)"

        Execute(SQL, "Insert")

        LoadData()

        ResetMe()

        Timer1.Stop()

        Message.Visible = True
        Message.Text = "Данные успешно добавлены"

        Timer1.Start()
    End Sub

    Private Sub SPData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SPData.CellClick

        Try

            Dim dgv As DataGridView = SPData

            If e.RowIndex <> -1 Then

                ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()

                FIO.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
                DOB.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim()
                ADRESS.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim()
                DIAG.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim()
                WORK.Text = Convert.ToString(dgv.CurrentRow.Cells(5).Value).Trim()
                D_ENTER.Text = Convert.ToString(dgv.CurrentRow.Cells(6).Value).Trim()
                UNIT.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(8).Value).Trim()
                VKK.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(9).Value).Trim()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub DeleteRecord()
        If AdminPass.Pass.Text = "555" Then
            If SPData.Rows.Count = 0 Then
                ResetMe()
                Exit Sub
            End If

            If String.IsNullOrEmpty(Me.ID) Then
                MsgBox("Выделите нужную позицию для удаления")
                ResetMe()
                Exit Sub
            End If



            If MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) = vbYes Then
                SQL = "DELETE FROM patients WHERE id = @ID"

                Execute(SQL, "Delete")

                LoadData()

                ResetMe()

                Timer1.Stop()

                Message.Visible = True
                Message.Text = "Данные успешно удалены"

                Timer1.Start()
            Else
                LoadData()

                ResetMe()
            End If
            AdminPass.Close()
        Else
            MsgBox("У вас нет прав для выполнения этой операции")
        End If

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        AdminPass.Show()

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If SPData.Rows.Count = 0 Then
            ResetMe()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Выделите нужную позицию для обновления")
            ResetMe()
            Exit Sub
        End If

        If String.IsNullOrEmpty(FIO.Text.Trim()) Then
            MsgBox("Введите ФИО", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(ADRESS.Text.Trim()) Then
            MsgBox("Введите адрес", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DIAG.Text.Trim()) Then
            MsgBox("Введите диагноз", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If String.IsNullOrEmpty(WORK.Text.Trim()) Then
            MsgBox("Введите место работы", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If UNIT.SelectedIndex = 5 Then
            MsgBox("Выберите отделение", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If VKK.SelectedIndex = 2 Then
            MsgBox("Выберите наличие ВКК", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If
        If DOB.Value.ToShortDateString.Trim() = Now.ToShortDateString Then
            MsgBox("Выберите дату рождения", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Обновить данные")
            Exit Sub
        End If

        SQL = "UPDATE patients SET full_name = @Full_name, dob = @Dob, adress = @Adress, diag = @Diag, work = @Work, 
               date_enter = @Date_enter, unit = @Unit, vkk = @Vkk WHERE id = @ID;"

        Execute(SQL, "Save")

        LoadData()

        ResetMe()

        Timer1.Stop()

        Message.Visible = True
        Message.Text = "Данные успешно обновлены"

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Message.Visible = False
    End Sub

    Private Sub SearchEnterDateBtn_Click(sender As Object, e As EventArgs) Handles SearchEnterDateBtn.Click

        Dim data_enter = CDate(EnterDate.Text)


        SQL = "SELECT * FROM patients WHERE date_enter = '" & data_enter & "'"

        Cmd = New MySqlCommand(SQL, Con)

        Dim dt As DataTable = PerformCRUD(Cmd)


        With SPData
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "№"
            .Columns(1).HeaderText = "ФИО"
            .Columns(2).HeaderText = "Дата рождения"
            .Columns(3).HeaderText = "Адрес"
            .Columns(4).HeaderText = "Диагноз"
            .Columns(5).HeaderText = "Место работы"
            .Columns(6).HeaderText = "Дата поступления"
            .Columns(7).HeaderText = "Дата выписки"
            .Columns(8).HeaderText = "Отделение"
            .Columns(9).HeaderText = "ВКК"

            .Columns(0).Width = 50
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 250
            .Columns(4).Width = 300
            .Columns(5).Width = 200
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 50

        End With
    End Sub

    Private Sub SearchExitDateBtn_Click(sender As Object, e As EventArgs) Handles SearchExitDateBtn.Click

        Dim data_exit = CDate(ExitDate.Text)


        SQL = "SELECT * FROM patients WHERE date_exit = '" & data_exit & "'"

        Cmd = New MySqlCommand(SQL, Con)

        Dim dt As DataTable = PerformCRUD(Cmd)


        With SPData
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "№"
            .Columns(1).HeaderText = "ФИО"
            .Columns(2).HeaderText = "Дата рождения"
            .Columns(3).HeaderText = "Адрес"
            .Columns(4).HeaderText = "Диагноз"
            .Columns(5).HeaderText = "Место работы"
            .Columns(6).HeaderText = "Дата поступления"
            .Columns(7).HeaderText = "Дата выписки"
            .Columns(8).HeaderText = "Отделение"
            .Columns(9).HeaderText = "ВКК"

            .Columns(0).Width = 50
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 250
            .Columns(4).Width = 300
            .Columns(5).Width = 200
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 50

        End With
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If Not String.IsNullOrEmpty(SearchText.Text.Trim()) Then
            LoadData(SearchText.Text.Trim())
        End If
    End Sub

    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        Dim header = "Выборка данных из базы пациентов от " & Now.ToLongDateString
        Dim company = "РРЦ МЗ ДНР " & Now.Year
        StartPrint(SPData, False, True, header, company)
    End Sub

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click

        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application With {
                .Visible = False
            }

        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")


        For i = 0 To SPData.RowCount - 1
            Progress.Visible = True
            Export.Visible = True

            Progress.Value = Int(i * (Progress.Maximum / SPData.RowCount))
            My.Application.DoEvents()


            Label4.Text = "Экспорт данных в Excel: "

            For j = 0 To SPData.ColumnCount - 1

                For k As Integer = 1 To SPData.Columns.Count

                    xlWorkSheet.Cells(1, k) = SPData.Columns(k - 1).HeaderText

                    xlWorkSheet.Cells(i + 2, j + 1) = SPData(j, i).Value
                    xlWorkSheet.Columns.AutoFit()
                Next
            Next

        Next

        Progress.Visible = False
        Export.Visible = False

        xlWorkSheet.SaveAs(desktop + "\Выгрузка данных " & Now.ToShortDateString & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        Label4.Text = "Количество записей в базе: " & SPData.Rows.Count - 1.ToString

        MsgBox("Файл сохранен на Рабочий Стол под именем" & vbCrLf & vbCrLf & "                 Выгрузка данных " & Now.ToShortDateString)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        'процедура выгрузки объектов из памяти
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Исключение при освобождении объекта " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ЗавершитьСеансToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗавершитьСеансToolStripMenuItem.Click
        FormPass.Show()
        Me.Close()
    End Sub

    Private Sub ВыйтиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыйтиToolStripMenuItem.Click
        If MsgBox("Вы уверены, что хотите выйти?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        ABOUT.Show()
    End Sub
End Class