Imports System.Data.SQLite
Imports DevExpress.XtraEditors
Public Class frmLogin
    Dim runSQL As New Query
    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Environment.Exit(1)
    End Sub


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim result As Boolean
        result = runSQL.login("Select *FROM Account Where Username='" & txtUser.Text & "' AND Password='" & txtPass.Text & "'")
        If result Then
            Dim value As String = runSQL.getSpeRecord("Select Nama FROM Account Where Username='" & txtUser.Text & "'")
            frmMain.txtBendahara.Caption = value
            frmMain.Timer1.Start()
            frmMain.Show()
            frmMain.Enabled = True
            Me.Hide()
        Else
            XtraMessageBox.Show("LOGIN FAILED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
End Class