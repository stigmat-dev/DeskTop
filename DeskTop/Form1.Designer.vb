<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РадиоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MyPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Message = New System.Windows.Forms.Label()
        Me.SearchDateBtn = New System.Windows.Forms.Button()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.StatusCombo = New System.Windows.Forms.ComboBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ExecutorCombo = New System.Windows.Forms.ComboBox()
        Me.UnitCombo = New System.Windows.Forms.ComboBox()
        Me.MyDate = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Today = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RecordsCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Export = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.MainDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВЫКЛЮЧИТЬToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MyPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.РадиоToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem, Me.ПечатьToolStripMenuItem, Me.НастройкиToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'РадиоToolStripMenuItem
        '
        Me.РадиоToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ВЫКЛЮЧИТЬToolStripMenuItem})
        Me.РадиоToolStripMenuItem.Name = "РадиоToolStripMenuItem"
        Me.РадиоToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.РадиоToolStripMenuItem.Text = "Радио"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПомощьToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(854, 690)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.GhostWhite
        Me.TabPage1.Controls.Add(Me.MyPlayer)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Message)
        Me.TabPage1.Controls.Add(Me.SearchDateBtn)
        Me.TabPage1.Controls.Add(Me.EndDate)
        Me.TabPage1.Controls.Add(Me.StartDate)
        Me.TabPage1.Controls.Add(Me.StatusCombo)
        Me.TabPage1.Controls.Add(Me.SearchBtn)
        Me.TabPage1.Controls.Add(Me.LoadBtn)
        Me.TabPage1.Controls.Add(Me.DeleteBtn)
        Me.TabPage1.Controls.Add(Me.SearchText)
        Me.TabPage1.Controls.Add(Me.SaveBtn)
        Me.TabPage1.Controls.Add(Me.AddBtn)
        Me.TabPage1.Controls.Add(Me.ExecutorCombo)
        Me.TabPage1.Controls.Add(Me.UnitCombo)
        Me.TabPage1.Controls.Add(Me.MyDate)
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.MainDataGridView)
        Me.TabPage1.Controls.Add(Me.NameText)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(846, 664)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "База данных"
        '
        'MyPlayer
        '
        Me.MyPlayer.Enabled = True
        Me.MyPlayer.Location = New System.Drawing.Point(370, 19)
        Me.MyPlayer.Name = "MyPlayer"
        Me.MyPlayer.OcxState = CType(resources.GetObject("MyPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MyPlayer.Size = New System.Drawing.Size(283, 126)
        Me.MyPlayer.TabIndex = 38
        Me.MyPlayer.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(659, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Конечная дата:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Начальная дата:"
        '
        'Message
        '
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Message.ForeColor = System.Drawing.Color.Black
        Me.Message.Location = New System.Drawing.Point(331, 640)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(45, 15)
        Me.Message.TabIndex = 35
        Me.Message.Text = "Label1"
        Me.Message.Visible = False
        '
        'SearchDateBtn
        '
        Me.SearchDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchDateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SearchDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SearchDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchDateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchDateBtn.Location = New System.Drawing.Point(662, 111)
        Me.SearchDateBtn.Name = "SearchDateBtn"
        Me.SearchDateBtn.Size = New System.Drawing.Size(85, 34)
        Me.SearchDateBtn.TabIndex = 34
        Me.SearchDateBtn.Text = "По датам"
        Me.SearchDateBtn.UseVisualStyleBackColor = True
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(662, 59)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(176, 20)
        Me.EndDate.TabIndex = 33
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(662, 19)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(176, 20)
        Me.StartDate.TabIndex = 33
        '
        'StatusCombo
        '
        Me.StatusCombo.FormattingEnabled = True
        Me.StatusCombo.Items.AddRange(New Object() {"Выберите статус...", "В работе", "Выполнено"})
        Me.StatusCombo.Location = New System.Drawing.Point(6, 98)
        Me.StatusCombo.Name = "StatusCombo"
        Me.StatusCombo.Size = New System.Drawing.Size(176, 21)
        Me.StatusCombo.TabIndex = 32
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.Black
        Me.SearchBtn.Location = New System.Drawing.Point(753, 111)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(85, 34)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Найти"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.GhostWhite
        Me.LoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LoadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
        Me.LoadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LoadBtn.ForeColor = System.Drawing.Color.Black
        Me.LoadBtn.Location = New System.Drawing.Point(188, 85)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(176, 60)
        Me.LoadBtn.TabIndex = 3
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
        Me.DeleteBtn.Location = New System.Drawing.Point(745, 628)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(95, 32)
        Me.DeleteBtn.TabIndex = 25
        Me.DeleteBtn.Text = "Удалить"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'SearchText
        '
        Me.SearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SearchText.Location = New System.Drawing.Point(662, 85)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(176, 20)
        Me.SearchText.TabIndex = 1
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
        Me.SaveBtn.Location = New System.Drawing.Point(644, 628)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(95, 32)
        Me.SaveBtn.TabIndex = 24
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
        Me.AddBtn.Location = New System.Drawing.Point(543, 628)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(95, 32)
        Me.AddBtn.TabIndex = 23
        Me.AddBtn.Text = "Добавить"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'ExecutorCombo
        '
        Me.ExecutorCombo.FormattingEnabled = True
        Me.ExecutorCombo.Items.AddRange(New Object() {"Выберите исполнителя...", "Хрипливцев И.", "Шелудько В."})
        Me.ExecutorCombo.Location = New System.Drawing.Point(188, 58)
        Me.ExecutorCombo.Name = "ExecutorCombo"
        Me.ExecutorCombo.Size = New System.Drawing.Size(176, 21)
        Me.ExecutorCombo.TabIndex = 29
        '
        'UnitCombo
        '
        Me.UnitCombo.FormattingEnabled = True
        Me.UnitCombo.Items.AddRange(New Object() {"Выберите подразделение...", "Главный врач", "Приемная", "Зам. по медицинской части", "Зам. по реабилитации", "Зам. по экономике", "Зам. по АХП", "Главный бухгалтер", "Орг. метод. отдел", "Экономический отдел", "Бухгалтерия", "Отдел кадров", "Юрист", "Статистический отдел", "Нейрохирургия 1", "Нейрохирургия 2", "Травматология 1", "Травматология 2", "Неврология", "Интенсивная терапия", "ФТО", "Госпиталь", "Лаборатория", "Санпропускник", "Аптека", "АХП"})
        Me.UnitCombo.Location = New System.Drawing.Point(6, 58)
        Me.UnitCombo.Name = "UnitCombo"
        Me.UnitCombo.Size = New System.Drawing.Size(176, 21)
        Me.UnitCombo.TabIndex = 28
        '
        'MyDate
        '
        Me.MyDate.Location = New System.Drawing.Point(188, 19)
        Me.MyDate.Name = "MyDate"
        Me.MyDate.Size = New System.Drawing.Size(176, 20)
        Me.MyDate.TabIndex = 31
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Today, Me.RecordsCount, Me.Export, Me.Progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(840, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 27
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
        'MainDataGridView
        '
        Me.MainDataGridView.AllowUserToAddRows = False
        Me.MainDataGridView.AllowUserToDeleteRows = False
        Me.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.MainDataGridView.Location = New System.Drawing.Point(6, 151)
        Me.MainDataGridView.Name = "MainDataGridView"
        Me.MainDataGridView.ReadOnly = True
        Me.MainDataGridView.Size = New System.Drawing.Size(834, 471)
        Me.MainDataGridView.TabIndex = 26
        '
        'NameText
        '
        Me.NameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameText.Location = New System.Drawing.Point(6, 19)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(176, 20)
        Me.NameText.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.GhostWhite
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(185, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Дата подачи:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.GhostWhite
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(3, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Статус:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.GhostWhite
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(185, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Исполнитель:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.GhostWhite
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(3, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Подразделение:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Наименование:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.excel_theapplication_3130
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.print_118761
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ПечатьToolStripMenuItem.Text = "Печать"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.settings_cogwheel_button_icon_icons_com_72559
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.НастройкиToolStripMenuItem.Text = "Настройка IP"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.DeskTop.My.Resources.Resources.logo_russkoe_radio
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem2.Text = "Русское Радио"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.DeskTop.My.Resources.Resources.radiomarusya
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem3.Text = "Маруся FM"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.DeskTop.My.Resources.Resources.Novoe_Radio_98_4FM_Logo_350x350
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem4.Text = "Новое Радио"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.DeskTop.My.Resources.Resources.EuropaPlus
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem5.Text = "Европа Плюс"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = Global.DeskTop.My.Resources.Resources.Dfm_logo
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem6.Text = "DFM"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = Global.DeskTop.My.Resources.Resources.logo_radio_nrj
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem7.Text = "Радио ENERGY"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = Global.DeskTop.My.Resources.Resources.radio_vanya
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem8.Text = "Радио Ваня"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = Global.DeskTop.My.Resources.Resources.record
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem9.Text = "Радио Рекорд"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = Global.DeskTop.My.Resources.Resources.spdeep
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem10.Text = "SOUNDPARK DEEP"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = Global.DeskTop.My.Resources.Resources.hit_fm
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripMenuItem11.Text = "Хит FM"
        '
        'ВЫКЛЮЧИТЬToolStripMenuItem
        '
        Me.ВЫКЛЮЧИТЬToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.disable_remove_delete_exit_close_11881
        Me.ВЫКЛЮЧИТЬToolStripMenuItem.Name = "ВЫКЛЮЧИТЬToolStripMenuItem"
        Me.ВЫКЛЮЧИТЬToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ВЫКЛЮЧИТЬToolStripMenuItem.Text = "ВЫКЛЮЧИТЬ РАДИО"
        '
        'ПомощьToolStripMenuItem
        '
        Me.ПомощьToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.question
        Me.ПомощьToolStripMenuItem.Name = "ПомощьToolStripMenuItem"
        Me.ПомощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ПомощьToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ПомощьToolStripMenuItem.Text = "Помощь"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Image = Global.DeskTop.My.Resources.Resources.information
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 714)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "База заявок АХП | Республиканский Реабилитационный Центр МЗ ДНР"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MyPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПечатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПомощьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ExecutorCombo As ComboBox
    Friend WithEvents UnitCombo As ComboBox
    Friend WithEvents MyDate As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Today As ToolStripStatusLabel
    Friend WithEvents MainDataGridView As DataGridView
    Friend WithEvents NameText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SearchText As TextBox
    Friend WithEvents StatusCombo As ComboBox
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents SearchDateBtn As Button
    Friend WithEvents RecordsCount As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Message As Label
    Friend WithEvents Export As ToolStripStatusLabel
    Friend WithEvents Progress As ToolStripProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РадиоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ВЫКЛЮЧИТЬToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
