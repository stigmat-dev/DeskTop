Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ur = My.Application.Info.DirectoryPath & "\help.html"
        WebBrowser1.Navigate(ur)

        Label1.Text = "Республиканский Реабилитационный Центр " & Now.Year
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class