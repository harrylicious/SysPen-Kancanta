Imports System.Data.SQLite
Public Class ucPenggajian

    Dim perForm As New Methods

    Sub showData()
        getConnection()
        con.Open()
        Using da As New SQLiteDataAdapter("Select *FROM Penggajian", con)
            Using ds As New DataSet
                da.Fill(ds, 0)
                gridData.DataSource = ds.Tables(0)
            End Using
        End Using
        con.Close()
    End Sub



    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        If e.Column.Name = "ColNoRow" Then
            e.DisplayText = e.ListSourceRowIndex + 1
        End If
    End Sub

    Private Sub ucPenggajian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.RiwayatGaji' table. You can move, or remove it, as needed.
        Me.RiwayatGajiTableAdapter.Fill(Me.DataSet1.RiwayatGaji)
        'TODO: This line of code loads data into the 'DataSet1.SummaryGaji' table. You can move, or remove it, as needed.
        Me.SummaryGajiTableAdapter.Fill(Me.DataSet1.SummaryGaji)

    End Sub

    Private Sub toExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles toExcel.ItemClick
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Dim path As String = "C:\Users\acer\Pictures\Export"
            perForm.exportFile(gridData, path, toExcel)
        Else
            Dim path As String = "C:\Users\acer\Pictures\Export"
            perForm.exportFile(GridControl1, path, toExcel)
        End If
    End Sub

    Private Sub toWord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles toWord.ItemClick

    End Sub

    Private Sub toPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles toPDF.ItemClick

    End Sub

    Private Sub toHTML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles toHTML.ItemClick

    End Sub

    Private Sub toCSV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles toCSV.ItemClick
        Dim path As String = "C:\Users\acer\Pictures\Export"
        perForm.exportFile(GridControl1, path, toCSV)
    End Sub

    Private Sub GridView2_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView2.CustomColumnDisplayText
        If e.Column.Name = "RowNo" Then
            e.DisplayText = e.ListSourceRowIndex + 1
        End If
    End Sub

    Private Sub GridView1_CustomColumnDisplayText_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.Name = "ColNoRow" Then
            e.DisplayText = e.ListSourceRowIndex + 1
        End If
    End Sub
End Class
