<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeEdit2 = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeEdit3 = New DevExpress.XtraEditors.TimeEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(2017, 7, 31, 0, 0, 0, 0)
        Me.TimeEdit1.Location = New System.Drawing.Point(102, 120)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEdit1.Size = New System.Drawing.Size(223, 20)
        Me.TimeEdit1.TabIndex = 0
        '
        'TimeEdit2
        '
        Me.TimeEdit2.EditValue = New Date(2017, 7, 31, 0, 0, 0, 0)
        Me.TimeEdit2.Location = New System.Drawing.Point(102, 162)
        Me.TimeEdit2.Name = "TimeEdit2"
        Me.TimeEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEdit2.Size = New System.Drawing.Size(223, 20)
        Me.TimeEdit2.TabIndex = 1
        '
        'TimeEdit3
        '
        Me.TimeEdit3.EditValue = New Date(2017, 7, 31, 0, 0, 0, 0)
        Me.TimeEdit3.Location = New System.Drawing.Point(102, 214)
        Me.TimeEdit3.Name = "TimeEdit3"
        Me.TimeEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEdit3.Size = New System.Drawing.Size(223, 20)
        Me.TimeEdit3.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(102, 335)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(223, 27)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 485)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TimeEdit3)
        Me.Controls.Add(Me.TimeEdit2)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeEdit2 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeEdit3 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
