Public Class Form1
    Dim score As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add(score)
        Label1.Text = "your score is : " & score
    End Sub
    Public Sub add(ByRef x As Integer)
        x += 1
    End Sub
End Class
