Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraTab
Public Class formConfig

    Sub addForm(ByVal uc As Form, ByVal panContainer As PanelControl)
        On Error Resume Next

        uc.TopLevel = False
        uc.Dock = DockStyle.Fill
        panContainer.Controls.Add(uc)
        uc.Show()
    End Sub

    Sub addFormToTabPage(ByVal uc As Form, ByVal panContainer As XtraTabPage)
        uc.TopLevel = False
        uc.Dock = DockStyle.Fill
        panContainer.Controls.Add(uc)
        uc.Show()
    End Sub

    Sub addUC(ByVal uc As UserControl, ByVal panContainer As PanelControl)
        uc.Dock = DockStyle.Fill
        panContainer.Controls.Add(uc)
    End Sub

    Sub closeForms(ByVal panContainer As PanelControl)
        For Each uc As Form In panContainer.Controls
            uc.Close()
        Next
    End Sub

    Sub setTransition(ByVal transitionManager As TransitionManager, ByVal panContainer As PanelControl, ByVal uc As Form)


        transitionManager.StartTransition(panContainer)
        If panContainer.Controls.Contains(uc) Then
            closeForms(panContainer)
            addForm(uc, panContainer)
        Else
            closeForms(panContainer)
            addForm(uc, panContainer)
        End If
        transitionManager.EndTransition()
    End Sub

    Sub setTransitionTab(ByVal transitionManager As TransitionManager, ByVal tab As XtraTabControl, ByVal ind As Integer)
        transitionManager.StartTransition(tab)
        tab.SelectedTabPageIndex = ind
    End Sub
End Class
