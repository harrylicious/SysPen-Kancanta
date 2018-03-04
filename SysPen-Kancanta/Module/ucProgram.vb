Imports System.Data.SQLite
Public Class ucProgram

    Sub showData()
        On Error Resume Next
        con.Open()
        Using da As New SQLiteDataAdapter("Select *FROM Program", con)
            Using ds As New DataSet
                da.Fill(ds, 0)
                gridData.DataSource = ds.Tables(0)
            End Using
        End Using
        con.Close()
    End Sub

   

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        addProgram.Show()
    End Sub

    Private Sub ucProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
    End Sub
End Class
