Imports System.Data.SQLite
Imports System.Data
Module modConnection
    Public nameEm As String = ""

    Public con As New SQLiteConnection("Data Source=D:\Programming\Project\SysPen-Kancanta\SysPen-Kancanta\bin\Debug\dbKancanta.db")

    Public Sub getConnection()
        If ConnectionState.Closed Then
            con.Open()
        Else
            con.Close()
        End If
    End Sub

End Module
