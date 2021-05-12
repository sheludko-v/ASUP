<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SP
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SP))
        Me.SPData = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Today = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RecordsCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Export = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.ADRESS = New System.Windows.Forms.TextBox()
        Me.DIAG = New System.Windows.Forms.TextBox()
        Me.WORK = New System.Windows.Forms.TextBox()
        Me.D_ENTER = New System.Windows.Forms.DateTimePicker()
        Me.UNIT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchExitDateBtn = New System.Windows.Forms.Button()
        Me.ExitDate = New System.Windows.Forms.DateTimePicker()
        Me.EnterDate = New System.Windows.Forms.DateTimePicker()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.VKK = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Message = New System.Windows.Forms.Label()
        Me.SearchEnterDateBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗавершитьСеансToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыйтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SPData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPData
        '
        Me.SPData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SPData.BackgroundColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SPData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SPData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SPData.DefaultCellStyle = DataGridViewCellStyle2
        Me.SPData.Location = New System.Drawing.Point(12, 27)
        Me.SPData.Name = "SPData"
        Me.SPData.ReadOnly = True
        Me.SPData.Size = New System.Drawing.Size(582, 398)
        Me.SPData.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ToolStripMenuItem1, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(987, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem, Me.ПечатьToolStripMenuItem, Me.ЗавершитьСеансToolStripMenuItem, Me.ВыйтиToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОПрограммеToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Today, Me.RecordsCount, Me.Export, Me.Progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(987, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Today
        '
        Me.Today.Name = "Today"
        Me.Today.Size = New System.Drawing.Size(52, 17)
        Me.Today.Text = "Сегодня"
        '
        'RecordsCount
        '
        Me.RecordsCount.Name = "RecordsCount"
        Me.RecordsCount.Size = New System.Drawing.Size(122, 17)
        Me.RecordsCount.Text = "Количество записей:"
        '
        'Export
        '
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(102, 17)
        Me.Export.Text = "Экспорт данных: "
        Me.Export.Visible = False
        '
        'Progress
        '
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(130, 16)
        Me.Progress.Visible = False
        '
        'DOB
        '
        Me.DOB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DOB.Location = New System.Drawing.Point(638, 86)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(296, 20)
        Me.DOB.TabIndex = 30
        '
        'ADRESS
        '
        Me.ADRESS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ADRESS.Location = New System.Drawing.Point(638, 129)
        Me.ADRESS.Name = "ADRESS"
        Me.ADRESS.Size = New System.Drawing.Size(296, 22)
        Me.ADRESS.TabIndex = 29
        '
        'DIAG
        '
        Me.DIAG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DIAG.Location = New System.Drawing.Point(638, 173)
        Me.DIAG.Multiline = True
        Me.DIAG.Name = "DIAG"
        Me.DIAG.Size = New System.Drawing.Size(296, 100)
        Me.DIAG.TabIndex = 29
        '
        'WORK
        '
        Me.WORK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WORK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.WORK.Location = New System.Drawing.Point(638, 298)
        Me.WORK.Name = "WORK"
        Me.WORK.Size = New System.Drawing.Size(296, 22)
        Me.WORK.TabIndex = 29
        '
        'D_ENTER
        '
        Me.D_ENTER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D_ENTER.Location = New System.Drawing.Point(638, 346)
        Me.D_ENTER.Name = "D_ENTER"
        Me.D_ENTER.Size = New System.Drawing.Size(296, 20)
        Me.D_ENTER.TabIndex = 30
        '
        'UNIT
        '
        Me.UNIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UNIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UNIT.FormattingEnabled = True
        Me.UNIT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UNIT.Items.AddRange(New Object() {"Нейрохирургия 1", "Нейрохирургия 2", "Неврология", "Травмотология ЗП", "Травмотология ОДА", "Нажмите для выбора"})
        Me.UNIT.Location = New System.Drawing.Point(638, 398)
        Me.UNIT.Name = "UNIT"
        Me.UNIT.Size = New System.Drawing.Size(137, 21)
        Me.UNIT.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(635, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Дата рождения"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(635, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Адрес"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(635, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Диагноз"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Место работы"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(635, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Дата поступления"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(635, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Отделение"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(793, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Наличие ВКК"
        '
        'FIO
        '
        Me.FIO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FIO.Location = New System.Drawing.Point(638, 42)
        Me.FIO.Name = "FIO"
        Me.FIO.Size = New System.Drawing.Size(296, 20)
        Me.FIO.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(635, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Ф.И.О."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(453, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Дата выписки"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Дата поступления"
        '
        'SearchExitDateBtn
        '
        Me.SearchExitDateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchExitDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchExitDateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SearchExitDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SearchExitDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchExitDateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchExitDateBtn.Location = New System.Drawing.Point(456, 479)
        Me.SearchExitDateBtn.Name = "SearchExitDateBtn"
        Me.SearchExitDateBtn.Size = New System.Drawing.Size(122, 34)
        Me.SearchExitDateBtn.TabIndex = 46
        Me.SearchExitDateBtn.Text = "Найти"
        Me.SearchExitDateBtn.UseVisualStyleBackColor = True
        '
        'ExitDate
        '
        Me.ExitDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExitDate.Location = New System.Drawing.Point(456, 453)
        Me.ExitDate.Name = "ExitDate"
        Me.ExitDate.Size = New System.Drawing.Size(122, 20)
        Me.ExitDate.TabIndex = 44
        '
        'EnterDate
        '
        Me.EnterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EnterDate.Location = New System.Drawing.Point(328, 453)
        Me.EnterDate.Name = "EnterDate"
        Me.EnterDate.Size = New System.Drawing.Size(122, 20)
        Me.EnterDate.TabIndex = 45
        '
        'SearchBtn
        '
        Me.SearchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.Black
        Me.SearchBtn.Location = New System.Drawing.Point(256, 451)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(51, 22)
        Me.SearchBtn.TabIndex = 39
        Me.SearchBtn.Text = "Найти"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'LoadBtn
        '
        Me.LoadBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.LoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LoadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.LoadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LoadBtn.ForeColor = System.Drawing.Color.Black
        Me.LoadBtn.Location = New System.Drawing.Point(12, 480)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(295, 34)
        Me.LoadBtn.TabIndex = 40
        Me.LoadBtn.Text = "Загрузить базу"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Location = New System.Drawing.Point(840, 439)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(93, 32)
        Me.DeleteBtn.TabIndex = 43
        Me.DeleteBtn.Text = "Удалить"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'SearchText
        '
        Me.SearchText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchText.Location = New System.Drawing.Point(12, 451)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(238, 22)
        Me.SearchText.TabIndex = 38
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Location = New System.Drawing.Point(739, 439)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(95, 32)
        Me.SaveBtn.TabIndex = 42
        Me.SaveBtn.Text = "Обновить"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.Black
        Me.AddBtn.Location = New System.Drawing.Point(638, 439)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(95, 32)
        Me.AddBtn.TabIndex = 41
        Me.AddBtn.Text = "Добавить"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'VKK
        '
        Me.VKK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VKK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VKK.FormattingEnabled = True
        Me.VKK.Items.AddRange(New Object() {"Есть", "Нет", "Нажмите для выбора"})
        Me.VKK.Location = New System.Drawing.Point(796, 398)
        Me.VKK.Name = "VKK"
        Me.VKK.Size = New System.Drawing.Size(137, 21)
        Me.VKK.TabIndex = 49
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'Message
        '
        Me.Message.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Message.ForeColor = System.Drawing.Color.Black
        Me.Message.Location = New System.Drawing.Point(634, 494)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(57, 20)
        Me.Message.TabIndex = 50
        Me.Message.Text = "Label1"
        Me.Message.Visible = False
        '
        'SearchEnterDateBtn
        '
        Me.SearchEnterDateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchEnterDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchEnterDateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SearchEnterDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SearchEnterDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchEnterDateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchEnterDateBtn.Location = New System.Drawing.Point(328, 479)
        Me.SearchEnterDateBtn.Name = "SearchEnterDateBtn"
        Me.SearchEnterDateBtn.Size = New System.Drawing.Size(122, 34)
        Me.SearchEnterDateBtn.TabIndex = 46
        Me.SearchEnterDateBtn.Text = "Найти"
        Me.SearchEnterDateBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 435)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Поиск по базе"
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ЭкспортВExcelToolStripMenuItem.Image = Global.ASUP.My.Resources.Resources.excel_theapplication_3130
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Image = Global.ASUP.My.Resources.Resources.print_118761
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ПечатьToolStripMenuItem.Text = "Печать"
        '
        'ЗавершитьСеансToolStripMenuItem
        '
        Me.ЗавершитьСеансToolStripMenuItem.Image = Global.ASUP.My.Resources.Resources.logout_icon_138409
        Me.ЗавершитьСеансToolStripMenuItem.Name = "ЗавершитьСеансToolStripMenuItem"
        Me.ЗавершитьСеансToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ЗавершитьСеансToolStripMenuItem.Text = "Завершить сеанс"
        '
        'ВыйтиToolStripMenuItem
        '
        Me.ВыйтиToolStripMenuItem.Image = Global.ASUP.My.Resources.Resources._exit
        Me.ВыйтиToolStripMenuItem.Name = "ВыйтиToolStripMenuItem"
        Me.ВыйтиToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ВыйтиToolStripMenuItem.Text = "Выйти"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Image = Global.ASUP.My.Resources.Resources.info_3525
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(987, 621)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.VKK)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SearchEnterDateBtn)
        Me.Controls.Add(Me.SearchExitDateBtn)
        Me.Controls.Add(Me.ExitDate)
        Me.Controls.Add(Me.EnterDate)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SearchText)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.FIO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UNIT)
        Me.Controls.Add(Me.D_ENTER)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.WORK)
        Me.Controls.Add(Me.DIAG)
        Me.Controls.Add(Me.ADRESS)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SPData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "АСУП РРЦ | Санпропускник"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SPData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SPData As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Today As ToolStripStatusLabel
    Friend WithEvents RecordsCount As ToolStripStatusLabel
    Friend WithEvents Export As ToolStripStatusLabel
    Friend WithEvents Progress As ToolStripProgressBar
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПечатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗавершитьСеансToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыйтиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents ADRESS As TextBox
    Friend WithEvents DIAG As TextBox
    Friend WithEvents WORK As TextBox
    Friend WithEvents D_ENTER As DateTimePicker
    Friend WithEvents UNIT As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FIO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SearchExitDateBtn As Button
    Friend WithEvents ExitDate As DateTimePicker
    Friend WithEvents EnterDate As DateTimePicker
    Friend WithEvents SearchBtn As Button
    Friend WithEvents LoadBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SearchText As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents VKK As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Message As Label
    Friend WithEvents SearchEnterDateBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
