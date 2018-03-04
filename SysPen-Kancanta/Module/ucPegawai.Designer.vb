<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPegawai
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPegawai))
        Dim Transition1 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
        Dim CoverTransition1 As DevExpress.Utils.Animation.CoverTransition = New DevExpress.Utils.Animation.CoverTransition()
        Me.colKadiv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.checkKadiv = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.listPegawai = New DevExpress.XtraTab.XtraTabPage()
        Me.gridData = New DevExpress.XtraGrid.GridControl()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SysPen_Kancanta.DataSet1()
        Me.grid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNoRow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenisKelamin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTglLahir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJabatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtJabatan = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colStatusKepegawaian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStatusKepegawain = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txtID = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtAlamat = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.panAbsensi = New DevExpress.XtraTab.XtraTabPage()
        Me.panContainer = New DevExpress.XtraTab.XtraTabPage()
        Me.PegawaiTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.PegawaiTableAdapter()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.TransitionManager1 = New DevExpress.Utils.Animation.TransitionManager()
        CType(Me.checkKadiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.listPegawai.SuspendLayout()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatusKepegawain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colKadiv
        '
        Me.colKadiv.Caption = "KADIV"
        Me.colKadiv.ColumnEdit = Me.checkKadiv
        Me.colKadiv.FieldName = "Kadiv"
        Me.colKadiv.Name = "colKadiv"
        Me.colKadiv.Visible = True
        Me.colKadiv.VisibleIndex = 8
        Me.colKadiv.Width = 39
        '
        'checkKadiv
        '
        Me.checkKadiv.AutoHeight = False
        Me.checkKadiv.Caption = "YA"
        Me.checkKadiv.Name = "checkKadiv"
        '
        'tabControl1
        '
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedTabPage = Me.listPegawai
        Me.tabControl1.Size = New System.Drawing.Size(728, 524)
        Me.tabControl1.TabIndex = 23
        Me.tabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.listPegawai, Me.panAbsensi, Me.panContainer})
        '
        'listPegawai
        '
        Me.listPegawai.Controls.Add(Me.gridData)
        Me.listPegawai.Controls.Add(Me.Panel2)
        Me.listPegawai.Image = CType(resources.GetObject("listPegawai.Image"), System.Drawing.Image)
        Me.listPegawai.Name = "listPegawai"
        Me.listPegawai.Size = New System.Drawing.Size(723, 496)
        Me.listPegawai.Text = "List Pegawai"
        '
        'gridData
        '
        Me.gridData.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridData.DataSource = Me.PegawaiBindingSource
        Me.gridData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridData.Location = New System.Drawing.Point(0, 31)
        Me.gridData.MainView = Me.grid
        Me.gridData.MenuManager = Me.BarManager1
        Me.gridData.Name = "gridData"
        Me.gridData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.checkKadiv, Me.txtAlamat, Me.txtJabatan, Me.txtStatusKepegawain})
        Me.gridData.Size = New System.Drawing.Size(723, 465)
        Me.gridData.TabIndex = 20
        Me.gridData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid})
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "Pegawai"
        Me.PegawaiBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grid
        '
        Me.grid.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grid.Appearance.OddRow.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grid.Appearance.OddRow.Options.UseBackColor = True
        Me.grid.ColumnPanelRowHeight = 30
        Me.grid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNoRow, Me.colNIP, Me.colNama, Me.colJenisKelamin, Me.colAlamat, Me.colTelp, Me.colTglLahir, Me.colJabatan, Me.colStatusKepegawaian, Me.colKadiv})
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colKadiv
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Expression = "[Kadiv] ==  'Ya'"
        StyleFormatCondition1.Value1 = True
        Me.grid.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grid.GridControl = Me.gridData
        Me.grid.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nama", Me.colNama, "Jml:{0}")})
        Me.grid.Name = "grid"
        Me.grid.OptionsView.EnableAppearanceEvenRow = True
        Me.grid.OptionsView.RowAutoHeight = True
        Me.grid.OptionsView.ShowFooter = True
        Me.grid.RowHeight = 25
        Me.grid.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNIP, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColNoRow
        '
        Me.ColNoRow.Caption = "NO"
        Me.ColNoRow.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.ColNoRow.Name = "ColNoRow"
        Me.ColNoRow.OptionsColumn.ReadOnly = True
        Me.ColNoRow.Visible = True
        Me.ColNoRow.VisibleIndex = 0
        Me.ColNoRow.Width = 32
        '
        'colNIP
        '
        Me.colNIP.FieldName = "NIP"
        Me.colNIP.Name = "colNIP"
        Me.colNIP.OptionsColumn.ReadOnly = True
        Me.colNIP.Visible = True
        Me.colNIP.VisibleIndex = 1
        Me.colNIP.Width = 46
        '
        'colNama
        '
        Me.colNama.Caption = "NAMA"
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nama", "JML:{0}")})
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 2
        Me.colNama.Width = 117
        '
        'colJenisKelamin
        '
        Me.colJenisKelamin.Caption = "JK"
        Me.colJenisKelamin.FieldName = "JenisKelamin"
        Me.colJenisKelamin.Name = "colJenisKelamin"
        Me.colJenisKelamin.Visible = True
        Me.colJenisKelamin.VisibleIndex = 3
        Me.colJenisKelamin.Width = 58
        '
        'colAlamat
        '
        Me.colAlamat.Caption = "ALAMAT"
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Image = CType(resources.GetObject("colAlamat.Image"), System.Drawing.Image)
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 4
        Me.colAlamat.Width = 107
        '
        'colTelp
        '
        Me.colTelp.Caption = "TELP."
        Me.colTelp.FieldName = "Telp"
        Me.colTelp.Name = "colTelp"
        Me.colTelp.Visible = True
        Me.colTelp.VisibleIndex = 5
        Me.colTelp.Width = 87
        '
        'colTglLahir
        '
        Me.colTglLahir.Caption = "TGL. LAHIR"
        Me.colTglLahir.FieldName = "TglLahir"
        Me.colTglLahir.Name = "colTglLahir"
        Me.colTglLahir.Visible = True
        Me.colTglLahir.VisibleIndex = 6
        Me.colTglLahir.Width = 76
        '
        'colJabatan
        '
        Me.colJabatan.Caption = "JABATAN"
        Me.colJabatan.ColumnEdit = Me.txtJabatan
        Me.colJabatan.FieldName = "Jabatan"
        Me.colJabatan.Name = "colJabatan"
        Me.colJabatan.Visible = True
        Me.colJabatan.VisibleIndex = 7
        Me.colJabatan.Width = 54
        '
        'txtJabatan
        '
        Me.txtJabatan.AutoHeight = False
        Me.txtJabatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJabatan.Name = "txtJabatan"
        '
        'colStatusKepegawaian
        '
        Me.colStatusKepegawaian.Caption = "STATUS"
        Me.colStatusKepegawaian.ColumnEdit = Me.txtStatusKepegawain
        Me.colStatusKepegawaian.FieldName = "StatusKepegawaian"
        Me.colStatusKepegawaian.Name = "colStatusKepegawaian"
        Me.colStatusKepegawaian.Visible = True
        Me.colStatusKepegawaian.VisibleIndex = 9
        Me.colStatusKepegawaian.Width = 117
        '
        'txtStatusKepegawain
        '
        Me.txtStatusKepegawain.AutoHeight = False
        Me.txtStatusKepegawain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatusKepegawain.Name = "txtStatusKepegawain"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.txtID, Me.btnDelete, Me.btnRefresh, Me.BarEditItem1})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1, Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.FloatLocation = New System.Drawing.Point(232, 132)
        Me.Bar1.HideWhenMerging = DevExpress.Utils.DefaultBoolean.[True]
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.txtID), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1)})
        Me.Bar1.Offset = 1
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar1.Text = "Tools"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Record(s):"
        Me.BarStaticItem1.Glyph = CType(resources.GetObject("BarStaticItem1.Glyph"), System.Drawing.Image)
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.LargeGlyph = CType(resources.GetObject("BarStaticItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txtID
        '
        Me.txtID.Caption = "BarEditItem1"
        Me.txtID.Edit = Me.RepositoryItemSearchControl1
        Me.txtID.Id = 1
        Me.txtID.Name = "txtID"
        Me.txtID.Width = 143
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete this record"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 2
        Me.btnDelete.LargeGlyph = CType(resources.GetObject("btnDelete.LargeGlyph"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 4
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 5
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(723, 31)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(728, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 524)
        Me.barDockControlBottom.Size = New System.Drawing.Size(728, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 524)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(728, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 524)
        '
        'txtAlamat
        '
        Me.txtAlamat.Name = "txtAlamat"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.StandaloneBarDockControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 31)
        Me.Panel2.TabIndex = 12
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(611, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(104, 27)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "TAMBAH DATA"
        '
        'panAbsensi
        '
        Me.panAbsensi.Image = CType(resources.GetObject("panAbsensi.Image"), System.Drawing.Image)
        Me.panAbsensi.Name = "panAbsensi"
        Me.panAbsensi.Size = New System.Drawing.Size(723, 496)
        Me.panAbsensi.Text = "Absensi"
        '
        'panContainer
        '
        Me.panContainer.Image = CType(resources.GetObject("panContainer.Image"), System.Drawing.Image)
        Me.panContainer.Name = "panContainer"
        Me.panContainer.Size = New System.Drawing.Size(723, 496)
        Me.panContainer.Text = "Rincian Gaji"
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'TransitionManager1
        '
        Me.TransitionManager1.ShowWaitingIndicator = False
        Transition1.Control = Me.tabControl1
        CoverTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.CoverEffectOptions.FromLeft
        CoverTransition1.Parameters.FramesCount = Nothing
        Transition1.TransitionType = CoverTransition1
        Me.TransitionManager1.Transitions.Add(Transition1)
        '
        'ucPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 524)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ucPegawai"
        CType(Me.checkKadiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.listPegawai.ResumeLayout(False)
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJabatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatusKepegawain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txtID As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents panContainer As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents listPegawai As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridData As DevExpress.XtraGrid.GridControl
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As SysPen_Kancanta.DataSet1
    Friend WithEvents colNIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenisKelamin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTglLahir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJabatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKadiv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PegawaiTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.PegawaiTableAdapter
    Friend WithEvents txtJabatan As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colStatusKepegawaian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtStatusKepegawain As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents checkKadiv As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents panAbsensi As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents TransitionManager1 As DevExpress.Utils.Animation.TransitionManager
    Friend WithEvents ColNoRow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
