<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProgram
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProgram))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colDurasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDurasi = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.StandaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.gridData = New DevExpress.XtraGrid.GridControl()
        Me.ProgramBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SysPen_Kancanta.DataSet1()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodeProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ProgramTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.ProgramTableAdapter()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        CType(Me.txtDurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDurasi
        '
        Me.colDurasi.ColumnEdit = Me.txtDurasi
        Me.colDurasi.FieldName = "Durasi"
        Me.colDurasi.Image = CType(resources.GetObject("colDurasi.Image"), System.Drawing.Image)
        Me.colDurasi.Name = "colDurasi"
        Me.colDurasi.OptionsColumn.ReadOnly = True
        Me.colDurasi.Visible = True
        Me.colDurasi.VisibleIndex = 2
        Me.colDurasi.Width = 324
        '
        'txtDurasi
        '
        Me.txtDurasi.AutoHeight = False
        Me.txtDurasi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDurasi.Name = "txtDurasi"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.StandaloneBarDockControl2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.StandaloneBarDockControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 31)
        Me.Panel2.TabIndex = 13
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SimpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(636, 1)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(104, 27)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "TAMBAH DATA"
        '
        'StandaloneBarDockControl2
        '
        Me.StandaloneBarDockControl2.CausesValidation = False
        Me.StandaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandaloneBarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl2.Name = "StandaloneBarDockControl2"
        Me.StandaloneBarDockControl2.Size = New System.Drawing.Size(747, 31)
        Me.StandaloneBarDockControl2.Text = "StandaloneBarDockControl2"
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
        Me.SimpleButton1.Location = New System.Drawing.Point(635, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(104, 27)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "TAMBAH DATA"
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(747, 31)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'gridData
        '
        Me.gridData.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridData.DataSource = Me.ProgramBindingSource
        Me.gridData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridData.Location = New System.Drawing.Point(0, 31)
        Me.gridData.MainView = Me.GridView1
        Me.gridData.Name = "gridData"
        Me.gridData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDurasi})
        Me.gridData.Size = New System.Drawing.Size(747, 477)
        Me.gridData.TabIndex = 21
        Me.gridData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ProgramBindingSource
        '
        Me.ProgramBindingSource.DataMember = "Program"
        Me.ProgramBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 30
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeProgram, Me.colNamaProgram, Me.colDurasi})
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colDurasi
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[Durasi] == 0"
        StyleFormatCondition1.Name = "null"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.gridData
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.RowHeight = 25
        '
        'colKodeProgram
        '
        Me.colKodeProgram.Caption = "ID"
        Me.colKodeProgram.FieldName = "KodeProgram"
        Me.colKodeProgram.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colKodeProgram.Name = "colKodeProgram"
        Me.colKodeProgram.Visible = True
        Me.colKodeProgram.VisibleIndex = 0
        Me.colKodeProgram.Width = 83
        '
        'colNamaProgram
        '
        Me.colNamaProgram.FieldName = "NamaProgram"
        Me.colNamaProgram.Image = CType(resources.GetObject("colNamaProgram.Image"), System.Drawing.Image)
        Me.colNamaProgram.Name = "colNamaProgram"
        Me.colNamaProgram.Visible = True
        Me.colNamaProgram.VisibleIndex = 1
        Me.colNamaProgram.Width = 321
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl2)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarEditItem1, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        Me.BarManager1.StatusBar = Me.Bar3
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
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Offset = 1
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl2
        Me.Bar1.Text = "Tools"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Record(s):"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemSearchControl1
        Me.BarEditItem1.Id = 1
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 143
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Delete this record"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(747, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 508)
        Me.barDockControlBottom.Size = New System.Drawing.Size(747, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 508)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(747, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 508)
        '
        'ProgramTableAdapter
        '
        Me.ProgramTableAdapter.ClearBeforeFill = True
        '
        'ucProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 530)
        Me.Controls.Add(Me.gridData)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ucProgram"
        CType(Me.txtDurasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents gridData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StandaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ProgramBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As SysPen_Kancanta.DataSet1
    Friend WithEvents colKodeProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDurasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.ProgramTableAdapter
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDurasi As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant

End Class
