Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If tb1.Text = "raphael" And tb2.Text = "cruz" Then
            MsgBox("LOGIN SUCCESS!", , "STATUS:")
        ElseIf tb1.Text = "" And tb2.Text = "" Then
            MsgBox("PLEASE ENTER YOUR USERNAME AND PASSWORD!", , "STATUS:")
        ElseIf tb1.Text = "raphael" And tb2.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD!", , "STATUS:")
        ElseIf tb1.Text = "" And tb2.Text = "cruz" Then
            MsgBox("PLEASE ENTER YOUR USERNAME!", , "STATUS:")
        Else
            MsgBox("WRONG USERNAME AND PASSWORD!", , "STATUS:")
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        tb1.Clear()
        tb2.Clear()
    End Sub
End Class
