Imports DevExpress.XtraNavBar
Imports System.Globalization.CultureInfo
Public Class ucArsip

    Sub populateData()
        Dim monthName() As String = CurrentCulture.DateTimeFormat.MonthNames
        Dim len As Byte = monthName.Length - 2
        sideBar.Groups.Clear()
        Dim pos As Byte = 0
        For i As Integer = 2015 To 2017 Step 1
            Dim grup As New NavBarGroup
            grup.SmallImage = Image.FromFile(Application.StartupPath & "\Image\MonthView_16x16.png")
            grup.Caption = i.ToString
            sideBar.Groups.Add(grup)
            For j As Integer = 0 To len Step 1
                Dim item As New NavBarItem
                Dim separator As New NavBarSeparatorItem
                item.SmallImage = Image.FromFile(Application.StartupPath & "\Image\Today_16x16.png")

                item.Caption = monthName(j)
                sideBar.Groups(pos).ItemLinks.Add(item)
                sideBar.Groups(pos).ItemLinks.Add(separator)
            Next
            pos = pos + 1
        Next
        sideBar.Groups(pos - 1).Expanded = True
    End Sub

    Private Sub ucArsip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populateData()
    End Sub
End Class
