<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summaryProgram
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
        Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.ProgramBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SysPen_Kancanta.DataSet1()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.grupProgram = New DevExpress.XtraNavBar.NavBarGroup()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ProgramTableAdapter = New SysPen_Kancanta.DataSet1TableAdapters.ProgramTableAdapter()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        CType(Me.ProgramBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.grupProgram
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.grupProgram})
        Me.NavBarControl1.Location = New System.Drawing.Point(592, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 154
        Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.NavBarControl1.Size = New System.Drawing.Size(154, 479)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'grupProgram
        '
        Me.grupProgram.Caption = "PROGRAM"
        Me.grupProgram.Expanded = True
        Me.grupProgram.Name = "grupProgram"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(592, 479)
        Me.SplitContainerControl1.SplitterPosition = 349
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.ChartControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(592, 349)
        Me.SplitContainerControl2.SplitterPosition = 292
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'ChartControl2
        '
        Me.ChartControl2.BackColor = System.Drawing.Color.Transparent
        SimpleDiagram1.Dimension = 6
        SimpleDiagram1.EqualPieSize = False
        Me.ChartControl2.Diagram = SimpleDiagram1
        Me.ChartControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl2.Legend.Visible = False
        Me.ChartControl2.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Series1.ArgumentDataMember = "NamaProgram"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.DataSource = Me.ProgramBindingSource
        PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
        PieSeriesLabel1.TextPattern = "{A}" & Global.Microsoft.VisualBasic.ChrW(10) & "({V} Point)"
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.LegendTextPattern = "{A}"
        Series1.Name = "PROGRAM"
        Series1.ValueDataMembersSerializable = "Rate"
        PieSeriesView1.ExplodedDistancePercentage = 5.0R
        PieSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.MinValue
        PieSeriesView1.RuntimeExploding = False
        PieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
        Series1.View = PieSeriesView1
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PieSeriesView2.RuntimeExploding = False
        PieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
        Me.ChartControl2.SeriesTemplate.View = PieSeriesView2
        Me.ChartControl2.Size = New System.Drawing.Size(292, 349)
        Me.ChartControl2.TabIndex = 0
        ChartTitle1.Text = "ATTRACTIVENESS"
        Me.ChartControl2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'ChartControl1
        '
        Me.ChartControl1.BackColor = System.Drawing.Color.Transparent
        Me.ChartControl1.DataAdapter = Me.ProgramTableAdapter
        Me.ChartControl1.DataSource = Me.ProgramBindingSource
        XyDiagram1.AxisX.Visible = False
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Visible = False
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisualRange.Auto = False
        XyDiagram1.AxisY.VisualRange.AutoSideMargins = False
        XyDiagram1.AxisY.VisualRange.MaxValueSerializable = "5"
        XyDiagram1.AxisY.VisualRange.MinValueSerializable = "1"
        XyDiagram1.AxisY.VisualRange.SideMarginsValue = 1.0R
        XyDiagram1.AxisY.WholeRange.Auto = False
        XyDiagram1.AxisY.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisY.WholeRange.MaxValueSerializable = "5"
        XyDiagram1.AxisY.WholeRange.MinValueSerializable = "1"
        XyDiagram1.AxisY.WholeRange.SideMarginsValue = 0.4R
        XyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "NamaProgram"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "NamaProgram"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        SideBySideBarSeriesLabel1.TextPattern = "{A}"
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Rate"
        Me.ChartControl1.Size = New System.Drawing.Size(592, 126)
        Me.ChartControl1.TabIndex = 0
        ChartTitle2.Text = "PROGRAM RATE"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'ProgramTableAdapter
        '
        Me.ProgramTableAdapter.ClearBeforeFill = True
        '
        'summaryProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 479)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.NavBarControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "summaryProgram"
        CType(Me.ProgramBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents grupProgram As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ProgramTableAdapter As SysPen_Kancanta.DataSet1TableAdapters.ProgramTableAdapter
    Friend WithEvents ProgramBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As SysPen_Kancanta.DataSet1
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl

End Class
