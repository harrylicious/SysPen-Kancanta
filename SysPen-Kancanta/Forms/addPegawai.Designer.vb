<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPegawai
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addPegawai))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClear = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.grupContainer = New DevExpress.XtraEditors.GroupControl()
        Me.checkFreelancer = New DevExpress.XtraEditors.CheckEdit()
        Me.checkKadiv = New DevExpress.XtraEditors.CheckEdit()
        Me.txtJabatan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelp = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtTglLahir = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtJenisKelamin = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNIP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHapusPoto = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.checkAktif = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupContainer.SuspendLayout()
        CType(Me.checkFreelancer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkKadiv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTglLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTglLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAdd, Me.btnSave, Me.btnEdit, Me.btnSaveClose, Me.btnClear, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(548, 120)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "ADD"
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 1
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSave
        '
        Me.btnSave.Caption = "SAVE"
        Me.btnSave.Enabled = False
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 2
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "EDIT"
        Me.btnEdit.Enabled = False
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.Glyph"), System.Drawing.Image)
        Me.btnEdit.Id = 3
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Caption = "SAVE && CLOSE"
        Me.btnSaveClose.Enabled = False
        Me.btnSaveClose.Glyph = CType(resources.GetObject("btnSaveClose.Glyph"), System.Drawing.Image)
        Me.btnSaveClose.Id = 4
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnClear
        '
        Me.btnClear.Caption = "CLEAR"
        Me.btnClear.Glyph = CType(resources.GetObject("btnClear.Glyph"), System.Drawing.Image)
        Me.btnClear.Id = 5
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnClose
        '
        Me.btnClose.Caption = "TUTUP"
        Me.btnClose.Glyph = CType(resources.GetObject("btnClose.Glyph"), System.Drawing.Image)
        Me.btnClose.Id = 6
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAdd)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEdit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClear)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "ADD"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = " "
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 128)
        Me.PictureEdit1.MenuManager = Me.RibbonControl1
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(152, 169)
        Me.PictureEdit1.TabIndex = 1
        '
        'grupContainer
        '
        Me.grupContainer.Controls.Add(Me.checkFreelancer)
        Me.grupContainer.Controls.Add(Me.checkKadiv)
        Me.grupContainer.Controls.Add(Me.txtJabatan)
        Me.grupContainer.Controls.Add(Me.LabelControl7)
        Me.grupContainer.Controls.Add(Me.LabelControl6)
        Me.grupContainer.Controls.Add(Me.txtTelp)
        Me.grupContainer.Controls.Add(Me.txtTglLahir)
        Me.grupContainer.Controls.Add(Me.LabelControl5)
        Me.grupContainer.Controls.Add(Me.txtAlamat)
        Me.grupContainer.Controls.Add(Me.LabelControl4)
        Me.grupContainer.Controls.Add(Me.txtJenisKelamin)
        Me.grupContainer.Controls.Add(Me.LabelControl3)
        Me.grupContainer.Controls.Add(Me.txtNama)
        Me.grupContainer.Controls.Add(Me.LabelControl2)
        Me.grupContainer.Controls.Add(Me.txtNIP)
        Me.grupContainer.Controls.Add(Me.LabelControl1)
        Me.grupContainer.Location = New System.Drawing.Point(173, 128)
        Me.grupContainer.Name = "grupContainer"
        Me.grupContainer.Size = New System.Drawing.Size(361, 299)
        Me.grupContainer.TabIndex = 2
        Me.grupContainer.Text = "JANGAN KOSONGKAN FIELD DENGAN TANDA (*)"
        '
        'checkFreelancer
        '
        Me.checkFreelancer.Location = New System.Drawing.Point(186, 241)
        Me.checkFreelancer.MenuManager = Me.RibbonControl1
        Me.checkFreelancer.Name = "checkFreelancer"
        Me.checkFreelancer.Properties.Caption = "FREELANCE"
        Me.checkFreelancer.Size = New System.Drawing.Size(90, 19)
        Me.checkFreelancer.TabIndex = 15
        '
        'checkKadiv
        '
        Me.checkKadiv.Location = New System.Drawing.Point(186, 269)
        Me.checkKadiv.MenuManager = Me.RibbonControl1
        Me.checkKadiv.Name = "checkKadiv"
        Me.checkKadiv.Properties.Caption = "KEPALA DIVISI"
        Me.checkKadiv.Size = New System.Drawing.Size(90, 19)
        Me.checkKadiv.TabIndex = 14
        '
        'txtJabatan
        '
        Me.txtJabatan.Location = New System.Drawing.Point(11, 240)
        Me.txtJabatan.MenuManager = Me.RibbonControl1
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Properties.AutoHeight = False
        Me.txtJabatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJabatan.Size = New System.Drawing.Size(167, 23)
        Me.txtJabatan.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(11, 223)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "JABATAN:*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(184, 173)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "NO. TELP:"
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(184, 189)
        Me.txtTelp.MenuManager = Me.RibbonControl1
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Properties.AutoHeight = False
        Me.txtTelp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtTelp.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtTelp.Properties.Mask.BeepOnError = True
        Me.txtTelp.Properties.Mask.EditMask = "08\d\d-\d\d\d\d-\d\d\d\d"
        Me.txtTelp.Properties.Mask.IgnoreMaskBlank = False
        Me.txtTelp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtTelp.Size = New System.Drawing.Size(169, 24)
        Me.txtTelp.TabIndex = 10
        '
        'txtTglLahir
        '
        Me.txtTglLahir.EditValue = Nothing
        Me.txtTglLahir.Location = New System.Drawing.Point(11, 190)
        Me.txtTglLahir.MenuManager = Me.RibbonControl1
        Me.txtTglLahir.Name = "txtTglLahir"
        Me.txtTglLahir.Properties.AutoHeight = False
        Me.txtTglLahir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTglLahir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTglLahir.Properties.Mask.BeepOnError = True
        Me.txtTglLahir.Size = New System.Drawing.Size(167, 23)
        Me.txtTglLahir.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 173)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "TGL LAHIR:*"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(11, 110)
        Me.txtAlamat.MenuManager = Me.RibbonControl1
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(342, 57)
        Me.txtAlamat.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 92)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "ALAMAT:*"
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.Location = New System.Drawing.Point(101, 57)
        Me.txtJenisKelamin.MenuManager = Me.RibbonControl1
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Properties.AutoHeight = False
        Me.txtJenisKelamin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJenisKelamin.Properties.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.txtJenisKelamin.Size = New System.Drawing.Size(252, 23)
        Me.txtJenisKelamin.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "JENIS KELAMIN:*"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(188, 26)
        Me.txtNama.MenuManager = Me.RibbonControl1
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.AutoHeight = False
        Me.txtNama.Properties.Mask.BeepOnError = True
        Me.txtNama.Properties.Mask.EditMask = "\p{L}+.+"
        Me.txtNama.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNama.Properties.Mask.ShowPlaceHolders = False
        Me.txtNama.Size = New System.Drawing.Size(165, 23)
        Me.txtNama.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(146, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "NAMA:*"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(41, 26)
        Me.txtNIP.MenuManager = Me.RibbonControl1
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Properties.AutoHeight = False
        Me.txtNIP.Properties.Mask.BeepOnError = True
        Me.txtNIP.Properties.Mask.EditMask = "\d+"
        Me.txtNIP.Properties.Mask.IgnoreMaskBlank = False
        Me.txtNIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNIP.Properties.Mask.ShowPlaceHolders = False
        Me.txtNIP.Size = New System.Drawing.Size(100, 23)
        Me.txtNIP.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "NIP:*"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(548, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 446)
        Me.barDockControlBottom.Size = New System.Drawing.Size(548, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 446)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(548, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 446)
        '
        'btnBrowse
        '
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.Location = New System.Drawing.Point(10, 303)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(154, 35)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "BROWSE"
        '
        'btnHapusPoto
        '
        Me.btnHapusPoto.Image = CType(resources.GetObject("btnHapusPoto.Image"), System.Drawing.Image)
        Me.btnHapusPoto.Location = New System.Drawing.Point(10, 344)
        Me.btnHapusPoto.Name = "btnHapusPoto"
        Me.btnHapusPoto.Size = New System.Drawing.Size(154, 35)
        Me.btnHapusPoto.TabIndex = 8
        Me.btnHapusPoto.Text = "HAPUS POTO"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'checkAktif
        '
        Me.checkAktif.Location = New System.Drawing.Point(12, 397)
        Me.checkAktif.MenuManager = Me.RibbonControl1
        Me.checkAktif.Name = "checkAktif"
        Me.checkAktif.Properties.Caption = "SET AKTIF"
        Me.checkAktif.Size = New System.Drawing.Size(90, 19)
        Me.checkAktif.TabIndex = 16
        '
        'addPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 468)
        Me.Controls.Add(Me.checkAktif)
        Me.Controls.Add(Me.btnHapusPoto)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.grupContainer)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "addPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TAMBAH PEGAWAI"
        Me.TopMost = True
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupContainer.ResumeLayout(False)
        Me.grupContainer.PerformLayout()
        CType(Me.checkFreelancer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkKadiv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTglLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTglLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grupContainer As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNIP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtJenisKelamin As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTglLahir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelp As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtJabatan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents checkKadiv As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnHapusPoto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkFreelancer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents checkAktif As DevExpress.XtraEditors.CheckEdit
End Class
