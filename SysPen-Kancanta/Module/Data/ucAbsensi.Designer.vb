<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAbsensi
    Inherits DevExpress.XtraEditors.XtraForm

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAbsensi))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colKet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditAbsensi = New DevExpress.XtraEditors.CheckButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamaPegawai = New DevExpress.XtraEditors.LabelControl()
        Me.sideBar = New DevExpress.XtraNavBar.NavBarControl()
        Me.grupRiwayat = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gridRiwayatAbsen = New DevExpress.XtraGrid.GridControl()
        Me.RiwayatGajiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SysPen_Kancanta.DataSet1()
        Me.grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodePenggajian1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBulan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamKerja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNominal2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBendahara1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJamDatang = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.txtJamPulang = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.txtJamKerja = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.txtKelebihan = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.txtKekurangan = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.btnSimpan = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtKet = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtProgram = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.jamKerjaTetap = New DevExpress.XtraEditors.TimeEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.KetentuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSimpanAbsensi = New DevExpress.XtraEditors.SimpleButton()
        Me.estimasi = New DevExpress.XtraEditors.ButtonEdit()
        Me.keterangan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.jamKurang = New DevExpress.XtraEditors.TimeEdit()
        Me.jamLebih = New DevExpress.XtraEditors.TimeEdit()
        Me.jamKerja = New DevExpress.XtraEditors.TimeEdit()
        Me.jamPulang = New DevExpress.XtraEditors.TimeEdit()
        Me.jamDatang = New DevExpress.XtraEditors.TimeEdit()
        Me.txtBulan = New DevExpress.XtraEditors.TextEdit()
        Me.txtHariTgl = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutProgram = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GajiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodePenggajian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerbilang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBendahara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTgl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamdatang1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamPulang1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamKerja1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKelebihan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKekurangan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNominal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.labelPegawai = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.grupEditAbsensi = New DevExpress.XtraNavBar.NavBarGroup()
        Me.KetentuanTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.KetentuanTableAdapter()
        Me.GajiTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.GajiTableAdapter()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.RiwayatGajiTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.RiwayatGajiTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.sideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sideBar.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.gridRiwayatAbsen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiwayatGajiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJamDatang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJamPulang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJamKerja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKelebihan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKekurangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamKerjaTetap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KetentuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estimasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamKurang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamLebih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamKerja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamPulang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jamDatang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHariTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHariTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colKet1
        '
        Me.colKet1.Caption = "KET."
        Me.colKet1.FieldName = "Ket"
        Me.colKet1.Name = "colKet1"
        Me.colKet1.Visible = True
        Me.colKet1.VisibleIndex = 4
        Me.colKet1.Width = 71
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEditAbsensi)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.LabelControl7)
        Me.Panel2.Controls.Add(Me.txtNamaPegawai)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 31)
        Me.Panel2.TabIndex = 14
        '
        'btnEditAbsensi
        '
        Me.btnEditAbsensi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditAbsensi.Location = New System.Drawing.Point(444, 3)
        Me.btnEditAbsensi.Name = "btnEditAbsensi"
        Me.btnEditAbsensi.Size = New System.Drawing.Size(101, 23)
        Me.btnEditAbsensi.TabIndex = 23
        Me.btnEditAbsensi.Text = "EDIT ABSENSI"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(551, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 22)
        Me.SimpleButton2.TabIndex = 22
        Me.SimpleButton2.Text = "CETAK"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(639, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(105, 22)
        Me.SimpleButton1.TabIndex = 21
        Me.SimpleButton1.Text = "SIMPAN"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(8, 6)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(127, 19)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "NAMA PEGAWAI:"
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPegawai.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNamaPegawai.Location = New System.Drawing.Point(144, 4)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.Size = New System.Drawing.Size(71, 23)
        Me.txtNamaPegawai.TabIndex = 4
        Me.txtNamaPegawai.Text = "Hasnaini"
        '
        'sideBar
        '
        Me.sideBar.ActiveGroup = Me.grupRiwayat
        Me.sideBar.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.sideBar.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.sideBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sideBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.grupRiwayat, Me.grupEditAbsensi})
        Me.sideBar.Location = New System.Drawing.Point(0, 31)
        Me.sideBar.Name = "sideBar"
        Me.sideBar.OptionsNavPane.ExpandedWidth = 753
        Me.sideBar.Size = New System.Drawing.Size(753, 541)
        Me.sideBar.TabIndex = 15
        Me.sideBar.Text = "NavBarControl1"
        '
        'grupRiwayat
        '
        Me.grupRiwayat.Caption = "Riwayat Absensi"
        Me.grupRiwayat.ControlContainer = Me.NavBarGroupControlContainer1
        Me.grupRiwayat.GroupClientHeight = 429
        Me.grupRiwayat.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.grupRiwayat.Name = "grupRiwayat"
        Me.grupRiwayat.SmallImage = CType(resources.GetObject("grupRiwayat.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.gridRiwayatAbsen)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(751, 428)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'gridRiwayatAbsen
        '
        Me.gridRiwayatAbsen.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridRiwayatAbsen.DataSource = Me.RiwayatGajiBindingSource
        Me.gridRiwayatAbsen.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.gridRiwayatAbsen.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gridRiwayatAbsen.Location = New System.Drawing.Point(0, 0)
        Me.gridRiwayatAbsen.MainView = Me.grid
        Me.gridRiwayatAbsen.Name = "gridRiwayatAbsen"
        Me.gridRiwayatAbsen.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtJamDatang, Me.txtJamPulang, Me.txtJamKerja, Me.txtKelebihan, Me.txtKekurangan, Me.btnSimpan, Me.txtKet})
        Me.gridRiwayatAbsen.Size = New System.Drawing.Size(751, 428)
        Me.gridRiwayatAbsen.TabIndex = 0
        Me.gridRiwayatAbsen.UseEmbeddedNavigator = True
        Me.gridRiwayatAbsen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid})
        '
        'RiwayatGajiBindingSource
        '
        Me.RiwayatGajiBindingSource.DataMember = "RiwayatGaji"
        Me.RiwayatGajiBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grid
        '
        Me.grid.ColumnPanelRowHeight = 30
        Me.grid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodePenggajian1, Me.colBulan1, Me.colTgl, Me.colNama, Me.colJamKerja, Me.colKet1, Me.colNominal2, Me.colBendahara1})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colKet1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[Ket]  == 'Malas'"
        StyleFormatCondition1.Name = "malas"
        Me.grid.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grid.GridControl = Me.gridRiwayatAbsen
        Me.grid.GroupCount = 1
        Me.grid.GroupRowHeight = 30
        Me.grid.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", Me.colBulan1, "{0:c}")})
        Me.grid.Name = "grid"
        Me.grid.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grid.OptionsNavigation.UseOfficePageNavigation = False
        Me.grid.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.grid.OptionsView.EnableAppearanceEvenRow = True
        Me.grid.OptionsView.RowAutoHeight = True
        Me.grid.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel
        Me.grid.RowHeight = 25
        Me.grid.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colKodePenggajian1
        '
        Me.colKodePenggajian1.Caption = "KODE"
        Me.colKodePenggajian1.FieldName = "KodePenggajian"
        Me.colKodePenggajian1.Name = "colKodePenggajian1"
        Me.colKodePenggajian1.Visible = True
        Me.colKodePenggajian1.VisibleIndex = 0
        Me.colKodePenggajian1.Width = 105
        '
        'colBulan1
        '
        Me.colBulan1.Caption = "BULAN"
        Me.colBulan1.FieldName = "Bulan"
        Me.colBulan1.GroupFormat.FormatString = "{0:c}"
        Me.colBulan1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBulan1.Name = "colBulan1"
        Me.colBulan1.Visible = True
        Me.colBulan1.VisibleIndex = 1
        '
        'colTgl
        '
        Me.colTgl.Caption = "TGL"
        Me.colTgl.FieldName = "Tgl"
        Me.colTgl.Image = CType(resources.GetObject("colTgl.Image"), System.Drawing.Image)
        Me.colTgl.Name = "colTgl"
        Me.colTgl.Visible = True
        Me.colTgl.VisibleIndex = 1
        Me.colTgl.Width = 105
        '
        'colNama
        '
        Me.colNama.Caption = "NAMA"
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 2
        Me.colNama.Width = 105
        '
        'colJamKerja
        '
        Me.colJamKerja.Caption = "JAM KERJA"
        Me.colJamKerja.DisplayFormat.FormatString = "t"
        Me.colJamKerja.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJamKerja.FieldName = "JamKerja"
        Me.colJamKerja.Name = "colJamKerja"
        Me.colJamKerja.Visible = True
        Me.colJamKerja.VisibleIndex = 3
        Me.colJamKerja.Width = 105
        '
        'colNominal2
        '
        Me.colNominal2.Caption = "NOMINAL"
        Me.colNominal2.DisplayFormat.FormatString = "c"
        Me.colNominal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNominal2.FieldName = "Nominal"
        Me.colNominal2.Name = "colNominal2"
        Me.colNominal2.Visible = True
        Me.colNominal2.VisibleIndex = 5
        Me.colNominal2.Width = 76
        '
        'colBendahara1
        '
        Me.colBendahara1.Caption = "BENDAHARA"
        Me.colBendahara1.FieldName = "Bendahara"
        Me.colBendahara1.Image = CType(resources.GetObject("colBendahara1.Image"), System.Drawing.Image)
        Me.colBendahara1.Name = "colBendahara1"
        Me.colBendahara1.Visible = True
        Me.colBendahara1.VisibleIndex = 6
        Me.colBendahara1.Width = 168
        '
        'txtJamDatang
        '
        Me.txtJamDatang.AutoHeight = False
        Me.txtJamDatang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJamDatang.Name = "txtJamDatang"
        '
        'txtJamPulang
        '
        Me.txtJamPulang.AutoHeight = False
        Me.txtJamPulang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJamPulang.Name = "txtJamPulang"
        '
        'txtJamKerja
        '
        Me.txtJamKerja.AutoHeight = False
        Me.txtJamKerja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJamKerja.Name = "txtJamKerja"
        '
        'txtKelebihan
        '
        Me.txtKelebihan.AutoHeight = False
        Me.txtKelebihan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKelebihan.Name = "txtKelebihan"
        '
        'txtKekurangan
        '
        Me.txtKekurangan.AutoHeight = False
        Me.txtKekurangan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKekurangan.Name = "txtKekurangan"
        '
        'btnSimpan
        '
        Me.btnSimpan.AutoHeight = False
        Me.btnSimpan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnSimpan.Name = "btnSimpan"
        '
        'txtKet
        '
        Me.txtKet.AutoHeight = False
        Me.txtKet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKet.Name = "txtKet"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.SplitContainerControl1)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(751, 485)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(751, 485)
        Me.SplitContainerControl1.SplitterPosition = 279
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.LayoutControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(279, 485)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "EDIT"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtProgram)
        Me.LayoutControl1.Controls.Add(Me.jamKerjaTetap)
        Me.LayoutControl1.Controls.Add(Me.GroupControl3)
        Me.LayoutControl1.Controls.Add(Me.btnBatal)
        Me.LayoutControl1.Controls.Add(Me.btnSimpanAbsensi)
        Me.LayoutControl1.Controls.Add(Me.estimasi)
        Me.LayoutControl1.Controls.Add(Me.keterangan)
        Me.LayoutControl1.Controls.Add(Me.jamKurang)
        Me.LayoutControl1.Controls.Add(Me.jamLebih)
        Me.LayoutControl1.Controls.Add(Me.jamKerja)
        Me.LayoutControl1.Controls.Add(Me.jamPulang)
        Me.LayoutControl1.Controls.Add(Me.jamDatang)
        Me.LayoutControl1.Controls.Add(Me.txtBulan)
        Me.LayoutControl1.Controls.Add(Me.txtHariTgl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(672, 220, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(275, 459)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(139, 68)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProgram.Size = New System.Drawing.Size(124, 20)
        Me.txtProgram.StyleController = Me.LayoutControl1
        Me.txtProgram.TabIndex = 17
        '
        'jamKerjaTetap
        '
        Me.jamKerjaTetap.EditValue = New Date(2017, 8, 1, 8, 0, 0, 0)
        Me.jamKerjaTetap.Location = New System.Drawing.Point(140, 28)
        Me.jamKerjaTetap.Name = "jamKerjaTetap"
        Me.jamKerjaTetap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamKerjaTetap.Properties.DisplayFormat.FormatString = "t"
        Me.jamKerjaTetap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.jamKerjaTetap.Properties.EditFormat.FormatString = "t"
        Me.jamKerjaTetap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.jamKerjaTetap.Properties.Mask.BeepOnError = True
        Me.jamKerjaTetap.Properties.Mask.EditMask = "t"
        Me.jamKerjaTetap.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamKerjaTetap.Properties.ReadOnly = True
        Me.jamKerjaTetap.Size = New System.Drawing.Size(123, 20)
        Me.jamKerjaTetap.StyleController = Me.LayoutControl1
        Me.jamKerjaTetap.TabIndex = 16
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Controls.Add(Me.TextEdit1)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 324)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(251, 123)
        Me.GroupControl3.TabIndex = 15
        Me.GroupControl3.Text = "KETERANGAN:"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KetentuanBindingSource, "Tiga", True))
        Me.TextEdit4.Location = New System.Drawing.Point(89, 94)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.Mask.EditMask = "c"
        Me.TextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(142, 18)
        Me.TextEdit4.TabIndex = 11
        '
        'KetentuanBindingSource
        '
        Me.KetentuanBindingSource.DataMember = "Ketentuan"
        Me.KetentuanBindingSource.DataSource = Me.DataSet1
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KetentuanBindingSource, "Dua", True))
        Me.TextEdit3.Location = New System.Drawing.Point(89, 73)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.Mask.EditMask = "c"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(142, 18)
        Me.TextEdit3.TabIndex = 10
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KetentuanBindingSource, "Satu", True))
        Me.TextEdit2.Location = New System.Drawing.Point(89, 52)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.Mask.EditMask = "c"
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(142, 18)
        Me.TextEdit2.TabIndex = 9
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KetentuanBindingSource, "SatuJam", True))
        Me.TextEdit1.Location = New System.Drawing.Point(89, 31)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.Mask.EditMask = "c"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(142, 18)
        Me.TextEdit1.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(79, 97)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(79, 76)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(79, 55)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl8.TabIndex = 5
        Me.LabelControl8.Text = ":"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(79, 34)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "> 50 Menit"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "30-50 Menit"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "10-30 Menit"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "1 Jam"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(140, 298)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(123, 22)
        Me.btnBatal.StyleController = Me.LayoutControl1
        Me.btnBatal.TabIndex = 14
        Me.btnBatal.Text = "BATAL"
        '
        'btnSimpanAbsensi
        '
        Me.btnSimpanAbsensi.Image = CType(resources.GetObject("btnSimpanAbsensi.Image"), System.Drawing.Image)
        Me.btnSimpanAbsensi.Location = New System.Drawing.Point(12, 298)
        Me.btnSimpanAbsensi.Name = "btnSimpanAbsensi"
        Me.btnSimpanAbsensi.Size = New System.Drawing.Size(124, 22)
        Me.btnSimpanAbsensi.StyleController = Me.LayoutControl1
        Me.btnSimpanAbsensi.TabIndex = 13
        Me.btnSimpanAbsensi.Text = "SIMPAN"
        '
        'estimasi
        '
        Me.estimasi.Location = New System.Drawing.Point(12, 270)
        Me.estimasi.Name = "estimasi"
        Me.estimasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("estimasi.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.estimasi.Properties.Mask.EditMask = "c"
        Me.estimasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.estimasi.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.estimasi.Properties.ReadOnly = True
        Me.estimasi.Size = New System.Drawing.Size(251, 22)
        Me.estimasi.StyleController = Me.LayoutControl1
        Me.estimasi.TabIndex = 12
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(12, 228)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("keterangan.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.keterangan.Properties.Items.AddRange(New Object() {"Masuk", "Izin", "Sakit", "Malas = Tanpa Keterangan"})
        Me.keterangan.Size = New System.Drawing.Size(251, 22)
        Me.keterangan.StyleController = Me.LayoutControl1
        Me.keterangan.TabIndex = 11
        '
        'jamKurang
        '
        Me.jamKurang.EditValue = New Date(2017, 8, 5, 0, 1, 0, 0)
        Me.jamKurang.Location = New System.Drawing.Point(140, 188)
        Me.jamKurang.Name = "jamKurang"
        Me.jamKurang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamKurang.Properties.Mask.BeepOnError = True
        Me.jamKurang.Properties.Mask.EditMask = "t"
        Me.jamKurang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamKurang.Size = New System.Drawing.Size(123, 20)
        Me.jamKurang.StyleController = Me.LayoutControl1
        Me.jamKurang.TabIndex = 10
        '
        'jamLebih
        '
        Me.jamLebih.EditValue = New Date(2017, 8, 5, 0, 1, 0, 0)
        Me.jamLebih.Location = New System.Drawing.Point(12, 188)
        Me.jamLebih.Name = "jamLebih"
        Me.jamLebih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamLebih.Properties.Mask.EditMask = "t"
        Me.jamLebih.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamLebih.Size = New System.Drawing.Size(124, 20)
        Me.jamLebih.StyleController = Me.LayoutControl1
        Me.jamLebih.TabIndex = 9
        '
        'jamKerja
        '
        Me.jamKerja.EditValue = New Date(2017, 7, 31, 0, 0, 0, 0)
        Me.jamKerja.Location = New System.Drawing.Point(12, 148)
        Me.jamKerja.Name = "jamKerja"
        Me.jamKerja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamKerja.Properties.Mask.BeepOnError = True
        Me.jamKerja.Properties.Mask.EditMask = "t"
        Me.jamKerja.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamKerja.Size = New System.Drawing.Size(251, 20)
        Me.jamKerja.StyleController = Me.LayoutControl1
        Me.jamKerja.TabIndex = 8
        '
        'jamPulang
        '
        Me.jamPulang.EditValue = New Date(2017, 7, 31, 15, 0, 0, 0)
        Me.jamPulang.Location = New System.Drawing.Point(140, 108)
        Me.jamPulang.Name = "jamPulang"
        Me.jamPulang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamPulang.Properties.Mask.EditMask = "t"
        Me.jamPulang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamPulang.Size = New System.Drawing.Size(123, 20)
        Me.jamPulang.StyleController = Me.LayoutControl1
        Me.jamPulang.TabIndex = 7
        '
        'jamDatang
        '
        Me.jamDatang.EditValue = New Date(2017, 7, 31, 8, 0, 0, 0)
        Me.jamDatang.Location = New System.Drawing.Point(12, 108)
        Me.jamDatang.Name = "jamDatang"
        Me.jamDatang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.jamDatang.Properties.Mask.EditMask = "t"
        Me.jamDatang.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jamDatang.Size = New System.Drawing.Size(124, 20)
        Me.jamDatang.StyleController = Me.LayoutControl1
        Me.jamDatang.TabIndex = 6
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(12, 28)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Properties.ReadOnly = True
        Me.txtBulan.Size = New System.Drawing.Size(124, 20)
        Me.txtBulan.StyleController = Me.LayoutControl1
        Me.txtBulan.TabIndex = 5
        '
        'txtHariTgl
        '
        Me.txtHariTgl.EditValue = Nothing
        Me.txtHariTgl.Location = New System.Drawing.Point(12, 68)
        Me.txtHariTgl.Name = "txtHariTgl"
        Me.txtHariTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHariTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHariTgl.Properties.Mask.EditMask = "dddd, dd-MM-yyyy"
        Me.txtHariTgl.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHariTgl.Size = New System.Drawing.Size(123, 20)
        Me.txtHariTgl.StyleController = Me.LayoutControl1
        Me.txtHariTgl.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.SimpleSeparator1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.layoutProgram})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(275, 459)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtHariTgl
        Me.LayoutControlItem1.CustomizationFormText = "HARI/TANGGAL:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(127, 40)
        Me.LayoutControlItem1.Text = "HARI/TANGGAL:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtBulan
        Me.LayoutControlItem2.CustomizationFormText = "BULAN:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(128, 40)
        Me.LayoutControlItem2.Text = "BULAN:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.jamDatang
        Me.LayoutControlItem3.CustomizationFormText = "JAM DATANG:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(128, 40)
        Me.LayoutControlItem3.Text = "JAM DATANG:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.jamKerja
        Me.LayoutControlItem5.CustomizationFormText = "JAM KERJA:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(255, 40)
        Me.LayoutControlItem5.Text = "JAM KERJA:"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.jamPulang
        Me.LayoutControlItem4.CustomizationFormText = "JAM PULANG:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(128, 80)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(127, 40)
        Me.LayoutControlItem4.Text = "JAM PULANG:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.jamLebih
        Me.LayoutControlItem6.CustomizationFormText = "KELEBIHAN:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(128, 40)
        Me.LayoutControlItem6.Text = "KELEBIHAN:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.jamKurang
        Me.LayoutControlItem7.CustomizationFormText = "KEKURANGAN:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(128, 160)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(127, 40)
        Me.LayoutControlItem7.Text = "KEKURANGAN:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.keterangan
        Me.LayoutControlItem8.CustomizationFormText = "KETERANGAN:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 200)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(255, 42)
        Me.LayoutControlItem8.Text = "KETERANGAN:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.estimasi
        Me.LayoutControlItem9.CustomizationFormText = "ESTIMASI:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 242)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(255, 42)
        Me.LayoutControlItem9.Text = "ESTIMASI:"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(92, 13)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 284)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(255, 2)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnSimpanAbsensi
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 286)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(128, 26)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnBatal
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(128, 286)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(127, 26)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.GroupControl3
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 312)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(255, 127)
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.jamKerjaTetap
        Me.LayoutControlItem13.CustomizationFormText = "JAM KERJA TETAP:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(128, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(127, 40)
        Me.LayoutControlItem13.Text = "JAM KERJA TETAP:"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(92, 13)
        '
        'layoutProgram
        '
        Me.layoutProgram.Control = Me.txtProgram
        Me.layoutProgram.CustomizationFormText = "PROGRAM:"
        Me.layoutProgram.Location = New System.Drawing.Point(127, 40)
        Me.layoutProgram.Name = "layoutProgram"
        Me.layoutProgram.Size = New System.Drawing.Size(128, 40)
        Me.layoutProgram.Text = "PROGRAM:"
        Me.layoutProgram.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutProgram.TextSize = New System.Drawing.Size(92, 13)
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImage = CType(resources.GetObject("GroupControl2.CaptionImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(468, 485)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "HASIL:"
        '
        'GridControl2
        '
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.GajiBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 56)
        Me.GridControl2.MainView = Me.GridView1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(464, 427)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GajiBindingSource
        '
        Me.GajiBindingSource.DataMember = "Gaji"
        Me.GajiBindingSource.DataSource = Me.DataSet1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodePenggajian, Me.colBulan, Me.colNIP, Me.colNominal, Me.colTerbilang, Me.colKet, Me.colBendahara, Me.colTgl1, Me.colJamdatang1, Me.colJamPulang1, Me.colJamKerja1, Me.colKelebihan1, Me.colKekurangan1, Me.colNominal1})
        Me.GridView1.GridControl = Me.GridControl2
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", Me.colTgl1, "Bulan : {0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colKodePenggajian
        '
        Me.colKodePenggajian.FieldName = "KodePenggajian"
        Me.colKodePenggajian.Name = "colKodePenggajian"
        '
        'colBulan
        '
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "{0}"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBulan.Name = "colBulan"
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 1
        '
        'colNIP
        '
        Me.colNIP.FieldName = "NIP"
        Me.colNIP.Name = "colNIP"
        '
        'colNominal
        '
        Me.colNominal.FieldName = "Nominal"
        Me.colNominal.Name = "colNominal"
        '
        'colTerbilang
        '
        Me.colTerbilang.FieldName = "Terbilang"
        Me.colTerbilang.Name = "colTerbilang"
        '
        'colKet
        '
        Me.colKet.Caption = "KET."
        Me.colKet.FieldName = "Ket"
        Me.colKet.Name = "colKet"
        Me.colKet.Visible = True
        Me.colKet.VisibleIndex = 7
        Me.colKet.Width = 99
        '
        'colBendahara
        '
        Me.colBendahara.FieldName = "Bendahara"
        Me.colBendahara.Name = "colBendahara"
        '
        'colTgl1
        '
        Me.colTgl1.FieldName = "Tgl"
        Me.colTgl1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colTgl1.Name = "colTgl1"
        Me.colTgl1.Visible = True
        Me.colTgl1.VisibleIndex = 0
        Me.colTgl1.Width = 120
        '
        'colJamdatang1
        '
        Me.colJamdatang1.Caption = "JAM DATANG"
        Me.colJamdatang1.DisplayFormat.FormatString = "d"
        Me.colJamdatang1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJamdatang1.FieldName = "Jamdatang"
        Me.colJamdatang1.Name = "colJamdatang1"
        Me.colJamdatang1.Visible = True
        Me.colJamdatang1.VisibleIndex = 1
        Me.colJamdatang1.Width = 86
        '
        'colJamPulang1
        '
        Me.colJamPulang1.Caption = "JAM PULANG"
        Me.colJamPulang1.DisplayFormat.FormatString = "d"
        Me.colJamPulang1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colJamPulang1.FieldName = "JamPulang"
        Me.colJamPulang1.Name = "colJamPulang1"
        Me.colJamPulang1.Visible = True
        Me.colJamPulang1.VisibleIndex = 2
        Me.colJamPulang1.Width = 86
        '
        'colJamKerja1
        '
        Me.colJamKerja1.Caption = "JAM KERJA"
        Me.colJamKerja1.FieldName = "JamKerja"
        Me.colJamKerja1.Name = "colJamKerja1"
        Me.colJamKerja1.Visible = True
        Me.colJamKerja1.VisibleIndex = 3
        Me.colJamKerja1.Width = 86
        '
        'colKelebihan1
        '
        Me.colKelebihan1.Caption = "LEBIH"
        Me.colKelebihan1.FieldName = "Kelebihan"
        Me.colKelebihan1.Name = "colKelebihan1"
        Me.colKelebihan1.Visible = True
        Me.colKelebihan1.VisibleIndex = 4
        Me.colKelebihan1.Width = 86
        '
        'colKekurangan1
        '
        Me.colKekurangan1.Caption = "KURANG"
        Me.colKekurangan1.FieldName = "Kekurangan"
        Me.colKekurangan1.Name = "colKekurangan1"
        Me.colKekurangan1.Visible = True
        Me.colKekurangan1.VisibleIndex = 5
        Me.colKekurangan1.Width = 86
        '
        'colNominal1
        '
        Me.colNominal1.Caption = "NOMINAL"
        Me.colNominal1.DisplayFormat.FormatString = "c"
        Me.colNominal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNominal1.FieldName = "Nominal"
        Me.colNominal1.Name = "colNominal1"
        Me.colNominal1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", "{0:c}")})
        Me.colNominal1.Visible = True
        Me.colNominal1.VisibleIndex = 6
        Me.colNominal1.Width = 86
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.labelPegawai)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 24)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(464, 32)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl12.Location = New System.Drawing.Point(432, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 15
        Me.LabelControl12.Text = "2017"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Location = New System.Drawing.Point(390, 9)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl13.TabIndex = 14
        Me.LabelControl13.Text = "TAHUN:"
        '
        'labelPegawai
        '
        Me.labelPegawai.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelPegawai.Location = New System.Drawing.Point(70, 9)
        Me.labelPegawai.Name = "labelPegawai"
        Me.labelPegawai.Size = New System.Drawing.Size(40, 13)
        Me.labelPegawai.TabIndex = 13
        Me.labelPegawai.Text = "Hasnaini"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(13, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl10.TabIndex = 12
        Me.LabelControl10.Text = "PEGAWAI:"
        '
        'grupEditAbsensi
        '
        Me.grupEditAbsensi.Caption = "Edit Absensi"
        Me.grupEditAbsensi.ControlContainer = Me.NavBarGroupControlContainer2
        Me.grupEditAbsensi.Expanded = True
        Me.grupEditAbsensi.GroupClientHeight = 486
        Me.grupEditAbsensi.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.grupEditAbsensi.Name = "grupEditAbsensi"
        Me.grupEditAbsensi.SmallImage = CType(resources.GetObject("grupEditAbsensi.SmallImage"), System.Drawing.Image)
        '
        'KetentuanTableAdapter
        '
        Me.KetentuanTableAdapter.ClearBeforeFill = True
        '
        'GajiTableAdapter
        '
        Me.GajiTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'RiwayatGajiTableAdapter
        '
        Me.RiwayatGajiTableAdapter.ClearBeforeFill = True
        '
        'ucAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 572)
        Me.Controls.Add(Me.sideBar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ucAbsensi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.sideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sideBar.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.gridRiwayatAbsen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiwayatGajiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJamDatang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJamPulang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJamKerja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKelebihan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKekurangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamKerjaTetap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KetentuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estimasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamKurang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamLebih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamKerja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamPulang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jamDatang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHariTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHariTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutProgram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamaPegawai As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sideBar As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents grupRiwayat As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents grupEditAbsensi As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents gridRiwayatAbsen As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtJamDatang As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtJamPulang As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtJamKerja As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtKelebihan As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtKekurangan As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtKet As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnEditAbsensi As DevExpress.XtraEditors.CheckButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtBulan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHariTgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents jamPulang As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents jamDatang As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents jamKerja As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents jamKurang As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents jamLebih As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents estimasi As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents keterangan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpanAbsensi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents KetentuanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As SysPen_Kancanta.DataSet1
    Friend WithEvents KetentuanTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.KetentuanTableAdapter
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelPegawai As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GajiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKodePenggajian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerbilang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBendahara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamdatang1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamPulang1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamKerja1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKelebihan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKekurangan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNominal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GajiTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.GajiTableAdapter
    Friend WithEvents jamKerjaTetap As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents RiwayatGajiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RiwayatGajiTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.RiwayatGajiTableAdapter
    Friend WithEvents colKodePenggajian1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBulan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamKerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNominal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBendahara1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtProgram As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents layoutProgram As DevExpress.XtraLayout.LayoutControlItem

End Class
