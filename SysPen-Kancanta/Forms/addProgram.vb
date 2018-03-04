Imports System.Data.SQLite
Imports DevExpress.XtraEditors

Public Class addProgram
    Dim perForm As New Query


#Region "VALIDATION"
    Sub validateControls()
       
        DxErrorProvider1.ClearErrors()
        Dim msg As String = "This field is required!"
        If txtProgram.Text = Nothing Then
            DxErrorProvider1.SetError(txtProgram, msg)
        End If
    End Sub
#End Region

#Region "SAVE"
    Sub saveData()
        con.Open()
        Try
            Using cmd As New SQLiteCommand("Insert INTO Program(NamaProgram, Durasi) Values (?,?)", con)
                With cmd
                    .Parameters.Add("param1", DbType.String).Value = txtProgram.Text
                    .Parameters.Add("param2", DbType.String).Value = txtDurasi.Text
                    .ExecuteNonQuery()
                End With
                con.Close()
                ucProgram.showData()
                XtraMessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub
#End Region

#Region "UPDATE"
    Sub updateData()
      
        Try
            Using cmd As New SQLiteCommand("Update Program Set NamaProgram=?, Durasi=? Where KodeProgram=?", con)
                With cmd
                    .Parameters.Add("param1", DbType.String).Value = txtProgram.Text
                    .Parameters.Add("param2", DbType.String).Value = txtDurasi.Text
                    .ExecuteNonQuery()
                End With
                con.Close()
                ucProgram.showData()
                XtraMessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub
#End Region

    Sub setEmptyClear(ByVal container As GroupControl)
        For Each ctl As Control In container.Controls
            If TypeOf ctl Is TextEdit Then
                ctl.Text = ""
            ElseIf TypeOf ctl Is ButtonEdit Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        validateControls()
        If DxErrorProvider1.HasErrors Then
            validateControls()
        Else
            saveData()
        End If
    End Sub

    Private Sub btnSaveClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveClose.ItemClick
        validateControls()
        If DxErrorProvider1.HasErrors Then
            validateControls()
        Else
            saveData()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnEdit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        validateControls()
        If DxErrorProvider1.HasErrors Then
            validateControls()
        Else
            updateData()
        End If
    End Sub

    Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        setEmptyClear(grupContainer)
    End Sub


    Private Sub btnClear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClear.ItemClick
        setEmptyClear(grupContainer)
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Dispose()
    End Sub
End Class