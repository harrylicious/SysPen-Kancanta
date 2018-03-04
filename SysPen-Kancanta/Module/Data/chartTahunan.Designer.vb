<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chartTahunan
    Inherits DevExpress.XtraEditors.XtraUserControl

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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2012", New Object() {CType(300000000.0R, Object)})
        Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2013", New Object() {CType(330000000.0R, Object)})
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2014", New Object() {CType(450000000.0R, Object)})
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2015", New Object() {CType(630000000.0R, Object)})
        Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2016", New Object() {CType(687000000.0R, Object)})
        Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2017", New Object() {CType(833000000.0R, Object)})
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisX.VisualRange.Auto = False
        XyDiagram1.AxisX.VisualRange.AutoSideMargins = False
        XyDiagram1.AxisX.VisualRange.MaxValueSerializable = "2017"
        XyDiagram1.AxisX.VisualRange.MinValueSerializable = "2012"
        XyDiagram1.AxisX.VisualRange.SideMarginsValue = 1.0R
        XyDiagram1.AxisX.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisX.WholeRange.SideMarginsValue = 1.0R
        XyDiagram1.AxisY.Label.TextPattern = "{V:c}"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisualRange.Auto = False
        XyDiagram1.AxisY.VisualRange.AutoSideMargins = False
        XyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1"
        XyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
        XyDiagram1.AxisY.VisualRange.SideMarginsValue = 100000000.0R
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        SideBySideBarSeriesLabel1.TextPattern = "{V:c}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "INCOME"
        Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5, SeriesPoint6})
        SideBySideBarSeriesView1.Shadow.Visible = True
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(729, 263)
        Me.ChartControl1.TabIndex = 1
        ChartTitle1.Text = "ANNUAL INCOME"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'chartTahunan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "chartTahunan"
        Me.Size = New System.Drawing.Size(729, 263)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl

End Class
