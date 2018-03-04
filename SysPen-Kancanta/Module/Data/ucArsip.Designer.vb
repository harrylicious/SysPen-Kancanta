<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucArsip
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
        Me.sideBar = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        CType(Me.sideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sideBar
        '
        Me.sideBar.ActiveGroup = Me.NavBarGroup1
        Me.sideBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sideBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.sideBar.Location = New System.Drawing.Point(0, 0)
        Me.sideBar.Name = "sideBar"
        Me.sideBar.OptionsNavPane.ExpandedWidth = 262
        Me.sideBar.Size = New System.Drawing.Size(262, 367)
        Me.sideBar.TabIndex = 0
        Me.sideBar.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "NavBarGroup1"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'ucArsip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sideBar)
        Me.Name = "ucArsip"
        Me.Size = New System.Drawing.Size(262, 367)
        CType(Me.sideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sideBar As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

End Class
