Imports System.Data.SQLite
Imports System.ComponentModel.DesignerSerializationVisibility
Imports DevExpress.XtraEditors
Imports System.Globalization.CultureInfo

Public Class ucRincianGaji

    Sub terms()
        con.Open()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        populateYearMonth()
    End Sub

    Sub populateYearMonth()
        Dim monthNam() As String = CurrentCulture.DateTimeFormat.MonthNames
        Dim len As Byte = monthNam.Length - 2
        txtBulan.Properties.Items.Clear()
        For i As Integer = 0 To len Step 1
            txtBulan.Properties.Items.Add(monthNam(i))
        Next
        txtBulan.Text = MonthName(Month(Now), False)
        Me.txtTahun.Properties.MinValue = Year(Now)
        Me.txtTahun.Properties.MaxValue = 2025
    End Sub

    Private Sub txtNamaPegawai_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaPegawai.TextChanged
        getConnection()
        Try
            con.Open()
            Using cmd As New SQLiteCommand("Select *FROM Pegawai Where Nama='" & txtNamaPegawai.Text & "'", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    If rd.Read Then
                        Dim path As String = Trim(rd.Item(10))
                        If path = "-" Or path = "" Or String.IsNullOrEmpty(path) Then
                            Me.pictPenyiar.Image = Nothing
                        Else
                            Me.pictPenyiar.Image = Image.FromFile(path)
                        End If

                    End If
                End Using
            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

End Class
