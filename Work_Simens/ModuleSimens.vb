Module ModuleSimens

    Public List_OpenedForms As New List(Of Form)
    Public List_AppsInTaskBar As New List(Of FormOpenTaskBarControl)

    Public Sub ShowForm(ByVal frm As Form)
        If Not List_OpenedForms.Contains(frm) Then 'se o form não consta na lista:
            'Adicionar Form na lista
            List_OpenedForms.Add(frm)

            'Exibir aplicativo na TaskBar
            Dim ApplicationTaskBar As New FormOpenTaskBarControl
            ApplicationTaskBar = New FormOpenTaskBarControl
            ApplicationTaskBar.AppVisible.Show()
            ApplicationTaskBar.ApplicationForm = frm
            WorkingAreaForm.FormsOpenedList_Panel.Controls.Add(ApplicationTaskBar)
            List_AppsInTaskBar.Add(ApplicationTaskBar)

            'Abrir Aplicativo
            With frm
                .Opacity = 0.0
                .TopMost = True
                .BringToFront()
                .Focus()
                .Select()
                .WindowState = FormWindowState.Normal
                .Show()
                .TopMost = False
            End With

            'Animação
            AnimationFormEntrace(frm)

        Else 'Se o form já consta na lista:
            RestaureForm(frm)
        End If
    End Sub

    Public Sub MinimizeForm(ByVal frm As Form)
        'Ocultar Painel Seletor
        List_AppsInTaskBar.Item(List_OpenedForms.IndexOf(frm)).AppVisible.Hide()

        'Minimizar Form como animação
        For fade = 1.1 To 0.0 Step -0.1 : frm.Opacity = fade : frm.Refresh() : Threading.Thread.Sleep(10) : Next
    End Sub

    Public Sub RestaureForm(ByVal frm As Form)
        'Exibir Painel Seletor
        List_AppsInTaskBar.Item(List_OpenedForms.IndexOf(frm)).AppVisible.show()

        'Restaurar Form
        With frm
            For fade = 0.0 To 1.1 Step 0.1 : frm.Opacity = fade : frm.Refresh() : Threading.Thread.Sleep(10) : Next
            .TopMost = True
            .Focus() : .Select()
            .Left = (Screen.PrimaryScreen.WorkingArea.Width - .Width) / 2
            .WindowState = FormWindowState.Normal
            .Left = (Screen.PrimaryScreen.WorkingArea.Width - .Width) / 2
            .Focus() : .Select()
            .TopMost = False
        End With
    End Sub

    Public Sub CloseForm(ByVal frm As Form)

    End Sub

    Public Sub AnimationFormEntrace(ByVal frm As Form)
        Dim CenterScreenWidth As Integer = (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2
        Dim CenterScreenHeight As Integer = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2

        'For DownForm = Val(CenterScreenHeight - 100) To CenterScreenHeight
        '    frm.Top = DownForm
        '    frm.Refresh()
        '    Threading.Thread.Sleep(10)
        'Next
        frm.Left = CenterScreenWidth
        For fade = 0.0 To 1.1 Step 0.1 : frm.Opacity = fade : frm.Refresh() : Threading.Thread.Sleep(10) : Next




        'frm.Left = 0 - frm.Width
        'For i = 0 To CenterScreen
        '    frm.Left = i
        'Next
    End Sub
End Module
