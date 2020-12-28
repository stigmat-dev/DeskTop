
Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text IsNot "" Then
            Dim file = My.Application.Info.DirectoryPath & ".\host.ini"
            Dim file2 = My.Application.Info.DirectoryPath & ".\База заявок РРЦ.exe"
            IO.File.WriteAllText(file, TextBox1.Text, System.Text.Encoding.Default)

            MsgBox("Для применения настроек программа перезагрузится.")
            Close()
            Form1.Close()
            Process.Start(file2)
        Else
            MsgBox("Нечего сохранять. Вы ничего не ввели.")
            Close()
        End If

    End Sub

End Class