Imports MySql.Data.MySqlClient


Public Class Form1

    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim desktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop


    Private ID As String = ""
    Private intRow As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim file = My.Application.Info.DirectoryPath & ".\host.ini"
        If IO.File.Exists(file) = True Then
            LoadData()
            ResetMe()
        Else
            Form4.Show()
            Close()
        End If

        Today.Text = "Сегодня: " & Now.ToLongDateString

        If intRow = 0 Then
            RecordsCount.Text = "База данных пустая :("
        End If

    End Sub


    Private Sub ResetMe()

        MainDataGridView.ClearSelection()

        ID = ""

        NameText.Text = ""

        If UnitCombo.Items.Count > 0 Then
            UnitCombo.SelectedIndex = 0
        End If
        If ExecutorCombo.Items.Count > 0 Then
            ExecutorCombo.SelectedIndex = 0
        End If
        If StatusCombo.Items.Count > 0 Then
            StatusCombo.SelectedIndex = 0
        End If

        SearchText.Clear()
        SearchText.Select()

        MyDate.ResetText()
        StartDate.ResetText()
        EndDate.ResetText()



    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")
        Cmd = New MySqlCommand(MySQL, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)
    End Sub

    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("Date", MyDate.Value.ToShortDateString.Trim())
        Cmd.Parameters.AddWithValue("Name", NameText.Text.Trim())
        Cmd.Parameters.AddWithValue("Unit", UnitCombo.SelectedItem.ToString())
        Cmd.Parameters.AddWithValue("Executor", ExecutorCombo.SelectedItem.ToString())
        Cmd.Parameters.AddWithValue("Status", StatusCombo.SelectedItem.ToString())

        If str = "Save" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("ID", Me.ID)
        End If
    End Sub


    Private Sub LoadData(Optional keyword As String = "")

        SQL = "SELECT id, date, name, unit, executor, status FROM main WHERE id LIKE @keyword1 OR date LIKE @keyword1 OR name LIKE @keyword1 " &
                "OR unit LIKE @keyword1 OR executor LIKE @keyword1 OR status LIKE @keyword1 ORDER BY id ASC"

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
            RecordsCount.Text = "Количество записей: " & intRow.ToString() & "."
        End If


        With MainDataGridView
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "№"
            .Columns(1).HeaderText = "Дата"
            .Columns(2).HeaderText = "Наименование"
            .Columns(3).HeaderText = "Подразделение"
            .Columns(4).HeaderText = "Исполнитель"
            .Columns(5).HeaderText = "Статус"

            .Columns(0).Width = 50
            .Columns(1).Width = 70
            .Columns(2).Width = 250
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(5).Width = 80
        End With

    End Sub

    Private Sub SelectDataByDate()

        Dim data = CDate(StartDate.Text)
        Dim data2 = CDate(EndDate.Text)

        SQL = "SELECT * FROM main WHERE date > '" & data & "' and date < '" & data2 & "'"

        Cmd = New MySqlCommand(SQL, Con)

        Dim dt As DataTable = PerformCRUD(Cmd)


        With MainDataGridView
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "№"
            .Columns(1).HeaderText = "Дата"
            .Columns(2).HeaderText = "Наименование"
            .Columns(3).HeaderText = "Подразделение"
            .Columns(4).HeaderText = "Исполнитель"
            .Columns(5).HeaderText = "Статус"

            .Columns(0).Width = 50
            .Columns(1).Width = 70
            .Columns(2).Width = 250
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(5).Width = 80
        End With

    End Sub

    Private Sub MainDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MainDataGridView.CellClick

        Try

            Dim dgv As DataGridView = MainDataGridView

            If e.RowIndex <> -1 Then

                ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()

                MyDate.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
                NameText.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim()
                UnitCombo.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim()
                ExecutorCombo.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim()
                StatusCombo.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(5).Value).Trim()


            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        If String.IsNullOrEmpty(NameText.Text.Trim()) Then
            MsgBox("Введите наименование задачи", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Добавить данные")
            ResetMe()
            Exit Sub
        End If

        SQL = "INSERT INTO main(date, name, unit, executor, status) VALUES(@Date, @Name, @Unit, @Executor, @Status)"

        Execute(SQL, "Insert")

        LoadData()

        ResetMe()

        Timer1.Stop()

        Message.Visible = True
        Message.Text = "Данные успешно добавлены."

        Timer1.Start()

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If MainDataGridView.Rows.Count = 0 Then
            ResetMe()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Выделите нужную позицию для обновления")
            ResetMe()
            Exit Sub
        End If

        If String.IsNullOrEmpty(NameText.Text.Trim()) Then
            MsgBox("Введите наименование задачи", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Сохранить данные")
            Exit Sub
        End If

        SQL = "UPDATE main SET date = @Date, name = @Name, unit = @Unit, executor = @Executor, status = @Status WHERE id = @ID"

        Execute(SQL, "Save")

        LoadData()

        ResetMe()

        Timer1.Stop()

        Message.Visible = True
        Message.Text = "Данные успешно обновлены."

        Timer1.Start()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        If MainDataGridView.Rows.Count = 0 Then
            ResetMe()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox("Выделите нужную позицию для удаления")
            ResetMe()
            Exit Sub
        End If



        If MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) = vbYes Then
            SQL = "DELETE FROM main WHERE id = @ID"

            Execute(SQL, "Delete")

            LoadData()

            ResetMe()

            Timer1.Stop()

            Message.Visible = True
            Message.Text = "Данные успешно удалены."

            Timer1.Start()
        Else
            LoadData()

            ResetMe()
        End If



    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

        If Not String.IsNullOrEmpty(SearchText.Text.Trim()) Then
            LoadData(SearchText.Text.Trim())
        End If

        ResetMe()

    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadData()
        ResetMe()
    End Sub

    Private Sub SearchDateBtn_Click(sender As Object, e As EventArgs) Handles SearchDateBtn.Click
        SelectDataByDate()
        ResetMe()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Message.Visible = False
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

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click

        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application With {
                .Visible = False
            }

        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")


        For i = 0 To MainDataGridView.RowCount - 1
            Progress.Visible = True
            Export.Visible = True

            Progress.Value = Int(i * (Progress.Maximum / MainDataGridView.RowCount))
            My.Application.DoEvents()


            Label4.Text = "Экспорт данных в Excel: "

            For j = 0 To MainDataGridView.ColumnCount - 1

                For k As Integer = 1 To MainDataGridView.Columns.Count

                    xlWorkSheet.Cells(1, k) = MainDataGridView.Columns(k - 1).HeaderText

                    xlWorkSheet.Cells(i + 2, j + 1) = MainDataGridView(j, i).Value
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

        Label4.Text = "Количество записей в базе: " & MainDataGridView.Rows.Count - 1.ToString



        MsgBox("Файл сохранен на Рабочий Стол под именем" & vbCrLf & vbCrLf & "                 Выгрузка данных " & Now.ToShortDateString)

    End Sub


    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        Dim header = "Выборка данных из базы заявок АХП от " & Now.ToLongDateString
        Dim company = "РРЦ МЗ ДНР " & Now.Year
        DataGridViewPrinter.StartPrint(MainDataGridView, False, True, header, company)
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ПомощьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПомощьToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub НастройкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub MainDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles MainDataGridView.MouseDown
        MainDataGridView.ClearSelection()

        ID = ""

        NameText.Text = ""

        If UnitCombo.Items.Count > 0 Then
            UnitCombo.SelectedIndex = 0
        End If
        If ExecutorCombo.Items.Count > 0 Then
            ExecutorCombo.SelectedIndex = 0
        End If
        If StatusCombo.Items.Count > 0 Then
            StatusCombo.SelectedIndex = 0
        End If

        SearchText.Clear()
        SearchText.Select()

        StartDate.ResetText()
        EndDate.ResetText()
    End Sub

End Class
