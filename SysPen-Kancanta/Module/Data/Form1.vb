Public Class Form1

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim ti1 As TimeSpan = TimeEdit1.Time - TimeEdit2.Time
        TimeEdit3.Time = ti1.ToString
    End Sub
End Class