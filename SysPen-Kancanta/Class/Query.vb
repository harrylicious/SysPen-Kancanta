Imports System.Data.SQLite
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Public Class Query

    Function getSpeRecord(ByVal str As String) As String
        Dim value As String = ""
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand(str, con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Return rd.Item(0)
                Else
                    '
                End If
            End Using
        End Using
        con.Close()
        Return value
    End Function

    Function login(ByVal str As String) As Boolean
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand(str, con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        con.Close()
    End Function

    Function cekDuplicate(ByVal str As String) As Boolean
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand(str, con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    Return True
                Else
                    Return False
                End If
                rd.Close()
            End Using
        End Using
        con.Close()
    End Function

    Function generateID(ByVal first As String, ByVal str As String) As String
        Dim mid, last As String
        mid = Microsoft.VisualBasic.Left(Date.Now, 10)
        mid = Microsoft.VisualBasic.Left(mid, 2) & Microsoft.VisualBasic.Mid(mid, 4, 2) & Microsoft.VisualBasic.Right(mid, 2)

        Dim value As String = "", kode As String = ""
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand(str, con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                If rd.Read Then
                    value = Microsoft.VisualBasic.Right(rd.Item(0), 3)
                    last = Val(value)
                    If last.Length = Nothing Then
                        value = "001"
                    ElseIf last.Length = 1 Then
                        value = "00" & (last + 1)
                    ElseIf last.Length = 2 Then
                        value = "0" & (last + 1)
                    ElseIf last.Length = 3 Then
                        value = last + 1
                    End If
                    kode = first & mid & value
                    Return kode
                End If
                rd.Close()
            End Using
        End Using
        con.Close()
        Return kode
    End Function

    Sub showData(ByVal str As String, ByVal grid As GridControl)
        getConnection()
        Try
            con.Open()
            Using da As New SQLiteDataAdapter(str, con)
                Using ds As New DataSet
                    da.Fill(ds, 0)
                    grid.DataSource = ds.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Sub deleteData(ByVal kode As String, ByVal tableName As String, ByVal idTable As String)
        getConnection()
        con.Open()
        Using cmd As New SQLiteCommand("Delete From [" & tableName & "] Where [" & idTable & "] = '" & kode & "'", con)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Data " & tableName & " berhasil terhapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Return
                End If
            End Using
        End Using
        con.Close()
    End Sub

    Function findData(ByVal str As String) As Boolean
        getConnection()
        Try
            con.Open()
            Using cmd As New SQLiteCommand(str, con)
                Using rd As SQLiteDataReader = cmd.ExecuteReader
                    If rd.Read Then
                        Return True
                    End If
                End Using
            End Using
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return False
    End Function

End Class
