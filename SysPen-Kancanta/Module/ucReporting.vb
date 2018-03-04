Public Class ucReporting

    Private Sub ucReporting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplitContainerControl1.Panel1.Controls.Add(New chartTahunan)
        SplitContainerControl1.Panel1.Controls(0).Dock = DockStyle.Fill

        SplitContainerControl1.Panel2.Controls.Add(New chartDetail)
        SplitContainerControl1.Panel2.Controls(0).Dock = DockStyle.Fill
    End Sub
End Class
