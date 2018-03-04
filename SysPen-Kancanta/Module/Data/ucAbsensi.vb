Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SQLite
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ucAbsensi
    Dim runSQL As New Query
    Dim perForm As New Methods
    Dim nom As Long

    Dim nip As String = ""
    Dim bendahara As String = frmMain.txtBendahara.Caption
    Dim kode As String = ""
    Dim terbilang As String = ""
    Dim jamkerjaFix As TimeSpan = New TimeSpan(8, 0, 0)

#Region "C R U D"
    Sub showData()
        Try
            Me.GajiTableAdapter.FillBy1(Me.DataSet1.Gaji, New System.Nullable(Of Integer)(CType(nip, String)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub showRiwayatGaji()
        runSQL.showData("SELECT g.KodePenggajian, g.Bulan, g.Tgl, g.NIP, p.Nama, g.Nominal, g.Ket, g.Bendahara, g.JamKerja FROM Gaji g INNER JOIN Pegawai p ON g.NIP = p.NIP", gridRiwayatAbsen)
    End Sub

    Sub updatedData()
        Using cmd As New SQLiteCommand("Select *FROM Gaji Where Tgl='" & txtHariTgl.Text & "'", con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    kode = rd.Item(0)
                    nip = rd.Item(3)
                    jamDatang.Text = rd.Item(5)
                    jamPulang.Text = rd.Item(6)
                    jamKerja.Text = rd.Item(7)
                    jamLebih.Text = rd.Item(8)
                    jamKurang.Text = rd.Item(9)
                    keterangan.Text = rd.Item(10)
                    estimasi.Text = rd.Item(11)
                    terbilang = rd.Item(12)
                    btnSimpanAbsensi.Text = "Update"
                End If
            End Using
        End Using
    End Sub
#End Region

#Region "VALIDATION"
    Sub validateControls()

        DxErrorProvider1.ClearErrors()
        Dim msg As String = "This field is required!"
        If jamDatang.Text = Nothing Then
            DxErrorProvider1.SetError(jamDatang, msg)
        End If
        If jamPulang.Text = Nothing Then
            DxErrorProvider1.SetError(jamPulang, msg)
        End If
        If jamKerja.Text = Nothing Then
            DxErrorProvider1.SetError(jamKerja, msg)
        End If
        If keterangan.Text = Nothing Then
            DxErrorProvider1.SetError(keterangan, msg)
        End If
        If estimasi.Text = Nothing Then
            DxErrorProvider1.SetError(estimasi, msg)
        End If

    End Sub
#End Region

#Region "SAVE"
    Sub saveData()
        If btnSimpanAbsensi.Text = "SIMPAN" Then
            Dim result As Boolean = runSQL.cekDuplicate("Select *FROM Gaji Where Tgl='" & txtHariTgl.Text & "'")
            If result Then
                If XtraMessageBox.Show("Anda sudah menginput data pada Tgl ini, Edit saja?", "Komfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    updatedData()
                Else
                    Exit Sub
                End If
            Else
                kode = runSQL.generateID("REG", "Select *FROM Gaji Limit 1 Offset (Select Count(*) From Gaji)  - 1")
                nom = CULng(estimasi.Text)
                terbilang = perForm.Terbilang(nom)
                estimasi.Properties.Mask.UseMaskAsDisplayFormat = False
                txtHariTgl.Properties.Mask.UseMaskAsDisplayFormat = False
                getConnection()
                con.Open()
                Using cmd As New SQLiteCommand("Insert INTO Gaji(KodePenggajian, Bulan, Tgl, NIP, Bendahara, JamDatang, JamPulang, JamKerja, Kelebihan, Kekurangan, Ket, Nominal, Terbilang) Values (@kode, @bulan, @tgl, @nip, @bendahara, @jamDatang, @jamPulang, @jamKerja, @kelebihan, @kekurangan, @ket, @nominal, @terbilang)", con)
                    With cmd
                        .Parameters.Add("@kode", DbType.String).Value = kode
                        .Parameters.Add("@bulan", DbType.String).Value = txtBulan.Text
                        .Parameters.Add("@tgl", DbType.String).Value = txtHariTgl.Text.ToString
                        .Parameters.Add("@nip", DbType.String).Value = nip
                        .Parameters.Add("@bendahara", DbType.String).Value = bendahara
                        .Parameters.Add("@jamDatang", DbType.String).Value = jamDatang.Text
                        .Parameters.Add("@jamPulang", DbType.String).Value = jamPulang.Text
                        .Parameters.Add("@jamKerja", DbType.String).Value = jamKerja.Text
                        .Parameters.Add("@kelebihan", DbType.String).Value = jamLebih.Text
                        .Parameters.Add("@kekurangan", DbType.String).Value = jamKurang.Text
                        .Parameters.Add("@ket", DbType.String).Value = keterangan.Text
                        .Parameters.Add("@nominal", DbType.String).Value = estimasi.Text
                        .Parameters.Add("@terbilang", DbType.String).Value = terbilang
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    loadData()
                    XtraMessageBox.Show("Data berhasil disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                con.Close()

                estimasi.Properties.Mask.UseMaskAsDisplayFormat = True
                txtHariTgl.Properties.Mask.UseMaskAsDisplayFormat = True
            End If
        Else

        End If
    End Sub
#End Region

#Region "METHODS"
    Sub generateCulture()
        Application.CurrentCulture = New Globalization.CultureInfo("id-ID")
        Application.CurrentCulture.NumberFormat.CurrencySymbol = "Rp. "
    End Sub

    Sub calculateKelebihanKekurangan()
        On Error Resume Next

        If Val(Strings.Left(jamDatang.Text, 2)) > Val(Strings.Left(jamPulang.Text, 2)) Then
            'Do Nothing
        Else
            Dim ti3 As TimeSpan = jamPulang.Time - jamDatang.Time

            jamKerja.Time = ti3.ToString

            Dim value As Integer = Val(jamLebih.Text)
        End If

    End Sub
#End Region

#Region "L O A D"
    Private Sub ucAbsensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.RiwayatGaji' table. You can move, or remove it, as needed.
        Me.RiwayatGajiTableAdapter.Fill(Me.DataSet1.RiwayatGaji)
        txtBulan.Text = MonthName(Month(Now), False)
        txtHariTgl.Text = DateString
        jamDatang.Text = "08:00"
        jamPulang.Text = "15:00"
        grupEditAbsensi.Expanded = True
        Me.KetentuanTableAdapter.Fill(Me.DataSet1.Ketentuan)
        getNIP()
        showData()
        runSQL.showData("Select *FROM RiwayatGaji Where Nama='" & txtNamaPegawai.Text & "'", gridRiwayatAbsen)
        fillDataProgram()
    End Sub
#End Region

#Region "ACTION"
    Private Sub sideBar_GroupExpanding(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupCancelEventArgs) Handles sideBar.GroupExpanding
        If grupRiwayat.Expanded Then
            grupEditAbsensi.Expanded = False
        ElseIf grupEditAbsensi.Expanded Then
            grupRiwayat.Expanded = False
        End If
    End Sub


    Private Sub btnEditAbsensi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAbsensi.CheckedChanged
        If btnEditAbsensi.Checked Then
            grupRiwayat.Expanded = False
            grupEditAbsensi.Expanded = True
        End If
    End Sub

    Private Sub jamPulang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jamPulang.EditValueChanged
        calculateKelebihanKekurangan()
    End Sub

    Private Sub jamKerja_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jamKerja.EditValueChanged
        Dim t1 As TimeSpan = New TimeSpan(0, 0, 0)
        Dim t2 As TimeSpan = jamKerjaTetap.Time - jamKerja.Time

        If Val(Strings.Left(jamKerja.Text, 2)) < 8 Then
            estimasi.Text = 0
        Else
            estimasi.Text = 10000
        End If

        t1 = jamKerja.Time - jamKerjaTetap.Time
        'Dim valLeft As Byte = Val(Strings.Left(jamKerja.Text, 2))
        'Dim valRight As Byte = Val(Strings.Left(jamkerjaFix.ToString, 2))

        'jamKurang.Time = jamKerja.Time - jamKerjaTetap.Time
        jamLebih.Text = t1.ToString
        keterangan.SelectedIndex = 0
    End Sub

    Private Sub jamLebih_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jamLebih.EditValueChanged
        Dim valLeft, valMid As String
        valLeft = Strings.Left(jamLebih.Text, 2)
        valMid = Strings.Mid(jamLebih.Text, 4, 2)

        Dim tempLeft, tempMid As Integer
        tempLeft = Val(valLeft) * 3000
        If Val(valMid) >= 10 And Val(valMid) <= 30 Then
            tempMid = 1000
        ElseIf Val(valMid) >= 31 And Val(valMid) <= 50 Then
            tempMid = 2000
        ElseIf Val(valMid) > 50 Then
            tempMid = 3000
        Else
            tempMid = 0
        End If

        estimasi.Text = (tempLeft + tempMid)
    End Sub

    Private Sub keterangan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keterangan.SelectedIndexChanged
        If keterangan.SelectedIndex <> 0 Then
            jamDatang.ResetText()
            jamPulang.ResetText()
            jamKerja.ResetText()
            jamLebih.ResetText()
            jamKurang.ResetText()
            estimasi.Text = 0
            keterangan.Properties.Buttons(1).Visible = False
        Else
            keterangan.Properties.Buttons(1).Visible = True
        End If
    End Sub

    Private Sub keterangan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles keterangan.TextChanged
        If keterangan.Text <> "" Then
            jamDatang.ResetText()
            jamPulang.ResetText()
            jamKerja.ResetText()
            jamLebih.ResetText()
            jamKurang.ResetText()
            estimasi.Text = 0
        End If
    End Sub
#End Region

    Sub fillDataProgram()
        getConnection()
        txtProgram.Properties.Items.Clear()
        con.Open()
        Using cmd As New SQLiteCommand("Select NamaProgram FROM Program", con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                Do While rd.Read
                    txtProgram.Properties.Items.Add(rd.Item(0))
                Loop
                rd.Close()
            End Using
        End Using
        con.Close()
    End Sub

    Sub getNIP()
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand("Select NIP FROM Pegawai Where Nama='" & Trim(labelPegawai.Text) & "'", con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                If rd.Read Then
                    nip = rd.Item(0)
                End If
                rd.Close()
            End Using
        End Using
        con.Close()
    End Sub

    Private Sub btnSimpanAbsensi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanAbsensi.Click
        validateControls()
        If DxErrorProvider1.HasErrors Then
            validateControls()
        Else
            saveData()
        End If
    End Sub

    Sub setEmptyClear(ByVal container As LayoutControl)
        For Each ctl As Control In container.Controls
            If TypeOf ctl Is TextEdit Then
                ctl.ResetText()
            ElseIf TypeOf ctl Is ButtonEdit Then
                ctl.ResetText()
            ElseIf TypeOf ctl Is TimeEdit Then
                ctl.ResetText()
            End If
        Next
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        setEmptyClear(LayoutControl1)
    End Sub


    Sub loadData()
        Try
            Me.GajiTableAdapter.FillBy2(Me.DataSet1.Gaji)
            If grid.GroupedColumns.Count >= 0 Then
                grid.ExpandGroupRow(0)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtNamaPegawai_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNamaPegawai.TextChanged
        runSQL.showData("Select *FROM RiwayatGaji Where Nama='" & txtNamaPegawai.Text & "'", gridRiwayatAbsen)
        If grid.GroupedColumns.Count >= 0 Then
            grid.ExpandGroupRow(0)
        End If
    End Sub
End Class
