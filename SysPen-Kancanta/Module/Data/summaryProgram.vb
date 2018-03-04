Imports System.Data.SQLite
Imports DevExpress.XtraNavBar

Public Class summaryProgram
#Region "C R U D"
    Sub addItemProgram()

        Try
            con.Open()
            Using cmd As New SQLiteCommand("Select NamaProgram From Program", con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    grupProgram.ItemLinks.Clear()
                    While rd.Read
                        Dim item As New NavBarItem
                        Dim separator As New NavBarSeparatorItem
                        item.Caption = rd.Item(0)
                        item.SmallImage = Image.FromFile(Application.StartupPath & "\Image\Notes_16x16.png")

                        grupProgram.ItemLinks.Add(item)
                        grupProgram.ItemLinks.Add(separator)

                        'AddHandler item.LinkClicked, AddressOf HandleDinamic_LinkClicked
                    End While
                    rd.Close()
                End Using
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub summaryProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProgramTableAdapter.Fill(DataSet1.Program)
        addItemProgram()
    End Sub
End Class
