Imports System.Data.SQLite
Imports DevExpress.XtraGrid.Views.Grid
Public Class ucPegawai
    Dim perForm As New formConfig
    Dim doEvent As New Methods
    Dim runSQL As New Query

    Sub showData()
        On Error Resume Next
        con.Open()
        Using da As New SQLiteDataAdapter("Select *FROM Pegawai", con)
            Using ds As New DataSet
                da.Fill(ds, 0)
                gridData.DataSource = ds.Tables(0)
            End Using
        End Using
        con.Close()
    End Sub

    Private Sub ucPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
        perForm.addFormToTabPage(ucRincianGaji, panContainer)

        perForm.addFormToTabPage(ucAbsensi, panAbsensi)

        tabControl1.SelectedTabPageIndex = 0
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        addPegawai.ShowDialog()
    End Sub

    Private Sub grid_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles grid.CustomDrawCell
        Dim col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If col.Name = "ColNoRow" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

   

    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid.RowCellClick
        Dim value As String = doEvent.getINFO_DataGrid(gridData, grid)
        txtID.Caption = value
        MsgBox(value)
    End Sub

   
    Private Sub btnRefresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        showData()
    End Sub

   
  
    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        runSQL.deleteData("NIP", "Pegawai", txtID.Caption)
    End Sub
End Class
