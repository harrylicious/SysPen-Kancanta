Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraBars
Imports DevExpress.XtraExport

Public Class Methods
    Function getINFO_DataGrid(ByVal gridControl As GridControl, ByVal gridData As GridView) As String
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(gridControl.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim pt As Point = gridControl.PointToClient(Control.MousePosition)
        Dim info = gridData.CalcHitInfo(pt)
        'Dim col = info.InGroupColumn.ToString
        'Dim cellval = GridView1.GetRowCellValue(1, "")

        Dim value As Object = view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn)
        If info.InRow And info.InRowCell Then
            Return value
        End If
        Return value
    End Function

    Sub exportFile(ByVal grid As GridControl, ByVal path As String, barButton As BarButtonItem)
       If barButton.Caption = "EXCEL" Then
            grid.ExportToXlsx(path)
        ElseIf barButton.Caption = "WORD" Then
            grid.ExportToRtf(path)
        ElseIf barButton.Caption = "PDF" Then
            grid.ExportToPdf(path)
        ElseIf barButton.Caption = "HTML" Then
            grid.ExportToHtml(path)
        ElseIf barButton.Caption = "CSV" Then
            grid.ExportToCsv(path)
        End If
    End Sub

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {" ", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " Belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " Puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " Seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " Ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " Seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function


End Class
