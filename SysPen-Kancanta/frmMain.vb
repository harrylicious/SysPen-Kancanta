Imports DevExpress.XtraNavBar
Imports System.Data.SQLite
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils.Animation
Imports System.Globalization

Public Class frmMain

    Dim lamaKerja As Integer
    Dim tglMasuk As String
    Dim perForm As New formConfig()
    Dim arr() As String

    Dim value As String

    Public Sub New()
        InitializeComponent()
    End Sub


#Region "L O A D"

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       Try
            con.Open()
            Using cmd As New SQLiteCommand("Select Nama From Pegawai", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    
                        If Val(Strings.Right(Year(Now), 2)) - Strings.Right(Val(tglMasuk), 2) = 0 Then
                            lamaKerja = 0
                        Else
                            lamaKerja = Val(Strings.Right(Year(Now), 2)) - Val(Strings.Right(tglMasuk, 2))
                        End If
                        Using cmdUp As New SQLiteCommand("Update Pegawai Set LamaMengabdi='" & Val(lamaKerja) & "' Where Nama='" & rd.Item(0) & "'", con)
                            cmdUp.ExecuteNonQuery()
                        End Using
                    rd.Close()
                End Using
            End Using


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        containerArsipGaji.Controls.Clear()
        containerArsipGaji.Controls.Add(New ucArsip)
        containerArsipGaji.Controls(0).Dock = DockStyle.Fill

        getConnection()
        addItemPegawai()
        containerArsipGaji.Controls.Clear()
        containerArsipGaji.Controls.Add(New ucArsip)
        containerArsipGaji.Controls(0).Dock = DockStyle.Fill

        perForm.closeForms(panContainer)
        perForm.addForm(ucHome, panContainer)

        setVisiblityGruptoFalse()
        TransitionManager1.ShowWaitingIndicator = False

        grupHome.Expanded = True
        Me.Enabled = False
        frmLogin.Show()
    End Sub
#End Region

#Region "C R U D"

    Sub getRincianGaji()
        Try
            con.Open()
            Using cmd As New SQLiteCommand("Select *FROM Pegawai Where Nama='" & Trim(value) & "'", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    If rd.Read Then
                        Dim path As String = Trim(rd.Item(11))
                        If path = "-" Or path = "" Or String.IsNullOrEmpty(path) Then
                            ucRincianGaji.pictPenyiar.Image = Nothing
                        Else
                            ucRincianGaji.pictPenyiar.Image = Image.FromFile(path)
                        End If

                    End If
                End Using
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub addItemPegawai()

        Try
            con.Open()
            Using cmd As New SQLiteCommand("Select Nama From Pegawai", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    grupPegawai.ItemLinks.Clear()
                    While rd.Read
                        Dim item As New NavBarItem
                        Dim separator As New NavBarSeparatorItem
                        Using cek As New SQLiteCommand("Select JenisKelamin From Pegawai Where Nama='" & rd.Item(0) & "'", con)
                            Using rd1 As SQLiteDataReader = cek.ExecuteReader
                                tglMasuk = rd1.Item(0)
                                If rd1.Item(0) = "Laki-laki" Then
                                    item.SmallImage = Image.FromFile(Application.StartupPath & "\Image\Mr.png")
                                Else
                                    item.SmallImage = Image.FromFile(Application.StartupPath & "\Image\Miss.png")
                                End If
                            End Using
                        End Using
                        Dim kadiv As String
                        Using cek1 As New SQLiteCommand("Select Kadiv From Pegawai Where Nama='" & rd.Item(0) & "'", con)
                            Using rd2 As SQLiteDataReader = cek1.ExecuteReader
                                If rd2.Item(0) = "Ya" Then
                                    kadiv = " (KADIV)"
                                Else
                                    kadiv = ""
                                End If
                            End Using
                        End Using

                        item.Caption = rd.Item(0) & kadiv
                        Using cek2 As New SQLiteCommand("Select StatusAktiv From Pegawai Where Nama='" & rd.Item(0) & "'", con)
                            Using rd3 As SQLiteDataReader = cek2.ExecuteReader
                                If rd3.Item(0) = "Aktif" Then
                                    item.Appearance.FontStyleDelta = FontStyle.Strikeout
                                Else
                                    item.Caption = rd.Item(0) & kadiv
                                End If
                            End Using
                        End Using

                        grupPegawai.ItemLinks.Add(item)
                        grupPegawai.ItemLinks.Add(separator)
                        item.Appearance.FontStyleDelta = FontStyle.Strikeout

                        AddHandler item.LinkClicked, AddressOf HandleDinamic_LinkClicked
                    End While
                    rd.Close()
                End Using
            End Using
           

            getConnection()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "PROCEDURE"
    Sub setVisiblityGruptoFalse()
        panSwithPegawai.Visible = False
        Dim grup As New NavBarGroup
        For Each grup In sideBar.Groups
            If grup.Caption <> "MAIN MENU" Then
                grup.Visible = False
            End If
        Next
    End Sub


#End Region

#Region "ACTION"
    Private Sub btnTambahProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        addProgram.ShowDialog()
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ucPegawai.tabControl1.SelectedTabPageIndex = 0
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        ucPegawai.tabControl1.SelectedTabPageIndex = 1
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ucPegawai.tabControl1.SelectedTabPageIndex = 2
    End Sub

    Private Sub btnTambahProgram_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnListProgram.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucProgram)

        setVisiblityGruptoFalse()
        grupProgram.Visible = True
        grupProgram.Expanded = True
        txtBread.Text = "LIST PROGRAM"
    End Sub

    Private Sub btnSummary_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnSummary.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, summaryProgram)

        setVisiblityGruptoFalse()
        grupProgram.Visible = True
        grupProgram.Expanded = True
        txtBread.Text = "SUMMARY PROGRAM"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTime.Caption = TimeString
    End Sub

    Private Sub lapPegawai_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles lapPegawai.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucReportPegawai)

        setVisiblityGruptoFalse()
        grupReporting.Visible = True
        grupReporting.Expanded = True
        txtBread.Text = "LAP. PEGAWAI"
    End Sub

    Private Sub btnRincianGaji_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnRincianGaji.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucReportRincianGaji)

        setVisiblityGruptoFalse()
        grupReporting.Visible = True
        grupReporting.Expanded = True
        txtBread.Text = "LAP. RINCIAN GAJI"
    End Sub

    Private Sub btnPegawai_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnPegawai.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucPegawai)

        setVisiblityGruptoFalse()
        grupPegawai.Visible = True
        grupPegawai.Expanded = True
        txtBread.Text = "FORM PEGAWAI"

        panSwithPegawai.Visible = True
    End Sub

    Private Sub btnGaji_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnGaji.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucPenggajian)

        setVisiblityGruptoFalse()
        grupArsip.Visible = True
        grupArsip.Expanded = True
        txtBread.Text = "FORM PENGGAJIAN"
    End Sub

    Private Sub btnProgram_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnProgram.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucProgram)

        setVisiblityGruptoFalse()
        grupProgram.Visible = True
        grupProgram.Expanded = True
        txtBread.Text = "FORM PROGRAM"
    End Sub

    Private Sub btnReport_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles btnReport.LinkClicked
        perForm.setTransition(TransitionManager1, panContainer, ucReporting)

        setVisiblityGruptoFalse()
        grupReporting.Visible = True
        grupReporting.Expanded = True
        txtBread.Text = "FORM REPORT"
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        perForm.setTransition(TransitionManager1, panContainer, ucHome)
        setVisiblityGruptoFalse()
        txtBread.Text = "HOME"
    End Sub
#End Region

#Region "HANDLER"
    Private Sub HandleDinamic_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        Dim p As Point = New Point(MousePosition)

        If MouseButtons.Right = True Then
            PopupMenu1.ShowPopup(p)
        End If
        Dim item As NavBarItem = CType(sender, NavBarItem)
        value = sender.ToString
        ucRincianGaji.txtNamaPegawai.Text = value
        ucAbsensi.txtNamaPegawai.Text = value
        ucAbsensi.labelPegawai.Text = value
        Dim aktif, freelance, kadiv As String
        Try
            con.Open()
            Using cmd As New SQLiteCommand("Select *FROM Pegawai Where Nama='" & Trim(value) & "'", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    If rd.Read Then
                        addPegawai.txtNIP.Text = rd.Item(2)
                        addPegawai.txtNama.Text = rd.Item(3)
                        addPegawai.txtJenisKelamin.Text = rd.Item(4)
                        addPegawai.txtAlamat.Text = rd.Item(5)
                        addPegawai.txtTelp.Text = rd.Item(6)
                        addPegawai.txtTglLahir.Text = rd.Item(7)
                        addPegawai.txtJabatan.Text = rd.Item(8)
                        freelance = rd.Item(9)
                        If freelance <> "Tetap" Then
                            addPegawai.checkFreelancer.Checked = True
                            ucAbsensi.layoutProgram.AllowHide = True
                            ucAbsensi.layoutProgram.ContentVisible = True
                        Else
                            addPegawai.checkFreelancer.Checked = False
                            ucAbsensi.layoutProgram.AllowHide = False
                            ucAbsensi.layoutProgram.ContentVisible = False
                        End If
                        kadiv = rd.Item(10)
                        If kadiv = "Ya" Then
                            addPegawai.checkKadiv.Checked = True
                        End If
                        Dim path As String = Trim(rd.Item(11))
                        If path = "-" Or path = "" Or String.IsNullOrEmpty(path) Then
                            addPegawai.PictureEdit1.Image = Nothing
                        Else
                            addPegawai.PictureEdit1.Image = Image.FromFile(path)
                            addPegawai.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                        End If
                        addPegawai.potoPath = rd.Item(11)
                        aktif = rd.Item(12)
                        If aktif = "Aktif" Then
                            addPegawai.checkAktif.Checked = True
                        End If
                        addPegawai.txtNIP.Properties.ReadOnly = True
                        addPegawai.Show()
                    End If
                End Using
            End Using
            con.Close()
        Catch ex As Exception

        Finally
            con.Close()
        End Try
        getRincianGaji()
    End Sub
#End Region


  
    Private Sub btnKetentuan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKetentuan.ItemClick
        frmKetentuan.ShowDialog()
    End Sub
End Class
