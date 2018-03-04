Imports System.Data.SQLite
Imports DevExpress.XtraEditors

Public Class addPegawai
    Dim perForm As New Query

    Dim kadiv, aktif, freelance As String
    Friend potoPath As String = "-"

#Region "VALIDATION"
    Sub validateControls()
        If checkAktif.Checked Then
            aktif = "Ya"
        Else
            aktif = "Tidak"
        End If

        If checkFreelancer.Checked Then
            freelance = "Freelancer"
        Else
            freelance = "Tetap"
        End If

        If checkKadiv.Checked Then
            kadiv = "Ya"
        Else
            kadiv = "Tidak"
        End If
        DxErrorProvider1.ClearErrors()
        Dim msg As String = "This field is required!"
        If txtNIP.Text = Nothing Then
            DxErrorProvider1.SetError(txtNIP, msg)
        End If
        If txtNama.Text = Nothing Then
            DxErrorProvider1.SetError(txtNama, msg)
        End If
        If txtJenisKelamin.Text = Nothing Then
            DxErrorProvider1.SetError(txtJenisKelamin, msg)
        End If
        If txtAlamat.Text = Nothing Then
            DxErrorProvider1.SetError(txtAlamat, msg)
        End If
        If txtTglLahir.Text = Nothing Then
            DxErrorProvider1.SetError(txtTglLahir, msg)
        End If
        If txtJabatan.Text = Nothing Then
            DxErrorProvider1.SetError(txtJabatan, msg)
        End If
        If freelance = Nothing Then
            DxErrorProvider1.SetError(checkFreelancer, msg)
        End If
        If aktif = Nothing Then
            DxErrorProvider1.SetError(checkAktif, msg)
        End If
    End Sub
#End Region

#Region "SAVE"
    Sub saveData()

        con.Open()

        If checkAktif.Checked Then
            aktif = "Aktif"
        Else
            aktif = "Tidak"
        End If

        If checkFreelancer.Checked Then
            freelance = "Freelancer"
        Else
            freelance = "Tetap"
        End If

        If checkKadiv.Checked Then
            kadiv = "Ya"
        Else
            kadiv = "Tidak"
        End If
        Try
            Using cmd As New SQLiteCommand("Insert INTO Pegawai(NIP, Tgl, Nama, JenisKelamin, Alamat, Telp, TglLahir, Jabatan, StatusKepegawaian, Kadiv, Poto, StatusAktiv) Values (?,?,?,?,?,?,?,?,?,?,?)", con)
                With cmd
                    .Parameters.Add("param1", DbType.String).Value = txtNIP.Text
                    .Parameters.Add("param2", DbType.String).Value = DateString
                    .Parameters.Add("param3", DbType.String).Value = txtNama.Text
                    .Parameters.Add("param4", DbType.String).Value = txtJenisKelamin.Text
                    .Parameters.Add("param5", DbType.String).Value = txtAlamat.Text
                    .Parameters.Add("param6", DbType.String).Value = txtTelp.Text
                    .Parameters.Add("param7", DbType.String).Value = txtTglLahir.Text
                    .Parameters.Add("param8", DbType.String).Value = txtJabatan.Text
                    .Parameters.Add("param9", DbType.String).Value = freelance
                    .Parameters.Add("param10", DbType.String).Value = kadiv
                    .Parameters.Add("param11", DbType.String).Value = potoPath
                    .Parameters.Add("param12", DbType.String).Value = aktif
                    .ExecuteNonQuery()
                End With
                con.Close()
                frmMain.addItemPegawai()
                ucPegawai.showData()
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

        con.Open()

        If checkAktif.Checked Then
            aktif = "Aktif"
        Else
            aktif = "Tidak"
        End If

        If checkFreelancer.Checked Then
            freelance = "Freelancer"
        Else
            freelance = "Tetap"
        End If

        If checkKadiv.Checked Then
            kadiv = "Ya"
        Else
            kadiv = "Tidak"
        End If
        Try
            Using cmd As New SQLiteCommand("Update Pegawai Set Nama=@nama, JenisKelamin=@jk, Alamat=@alamat, Telp=@telp, TglLahir=@tgl, Jabatan=@jab, StatusKepegawaian=@status, Kadiv=@kadiv, Poto=@poto, StatusAktiv=@aktif Where NIP=@nip", con)
                With cmd
                    .Parameters.Add("@nip", DbType.String).Value = txtNIP.Text
                    .Parameters.Add("@nama", DbType.String).Value = txtNama.Text
                    .Parameters.Add("@jk", DbType.String).Value = txtJenisKelamin.Text
                    .Parameters.Add("@alamat", DbType.String).Value = txtAlamat.Text
                    .Parameters.Add("@telp", DbType.String).Value = txtTelp.Text
                    .Parameters.Add("@tgl", DbType.String).Value = txtTglLahir.Text
                    .Parameters.Add("@jab", DbType.String).Value = txtJabatan.Text
                    .Parameters.Add("@status", DbType.String).Value = freelance
                    .Parameters.Add("@kadiv", DbType.String).Value = kadiv
                    .Parameters.Add("@poto", DbType.String).Value = potoPath
                    .Parameters.Add("@aktif", DbType.String).Value = aktif
                    .ExecuteNonQuery()
                End With
                con.Close()
                frmMain.addItemPegawai()
                ucPegawai.showData()
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
        checkAktif.Checked = False
        checkFreelancer.Checked = False
        checkKadiv.Checked = False
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
        btnSave.Enabled = False
        btnSaveClose.Enabled = False
        btnEdit.Enabled = False


    End Sub


    Private Sub btnClear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClear.ItemClick
        setEmptyClear(grupContainer)
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Dispose()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Cari Poto"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.Filter = ".Jpg|*.Jpg|.Jpeg|.Jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureEdit1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            potoPath = OpenFileDialog1.FileName
        Else
            potoPath = "-"
        End If
    End Sub

    Private Sub btnHapusPoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusPoto.Click
        potoPath = "-"
        PictureEdit1.Image = Nothing
    End Sub

    Private Sub txtNIP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIP.EditValueChanged
        If String.IsNullOrEmpty(txtNIP.Text) Then
            btnSave.Enabled = False
            btnSaveClose.Enabled = False
            btnEdit.Enabled = False
        Else
            btnSave.Enabled = True
            btnSaveClose.Enabled = True
            btnEdit.Enabled = True
        End If
       
    End Sub

    Private Sub addPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtNIP.Properties.ReadOnly Then
            btnSave.Enabled = False
            btnSaveClose.Enabled = False
        End If
    End Sub
End Class