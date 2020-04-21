Public Class FormLayoutTest
#Region "========== FORM =========="

#Region "Movimentação da Janela do Form"
    Dim BordersColor_Actived As Color = Color.FromArgb(120, 127, 255)
    Dim BordersColor_Desactived As Color = Color.FromArgb(147, 152, 255)

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim movef As MoveForm
    Private Sub Window_MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleWindow.MouseDown, TitleBarHead.MouseDown
        If FormMaximized = False Then
            If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
            movef.X = Me.Left - MousePosition.X
            movef.y = Me.Top - MousePosition.Y
        End If
    End Sub

    Private Sub Window_MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleWindow.MouseMove, TitleBarHead.MouseMove
        If FormMaximized = False Then
            If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
            Me.Left = movef.X + MousePosition.X
            Me.Top = movef.y + MousePosition.Y
        End If
    End Sub

    Private Sub Window_MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleWindow.MouseUp, TitleBarHead.MouseUp
        'VERIFICAR ONDE O URUÁRIO VAI SOLTAR O FORM PARA CORRIGIR SUA POSIÇÃO.

        'Vericar posição vertical
        If Me.Top < WorkingAreaForm.StatusBarBackgroudPanel.Height Then
            Me.Top = WorkingAreaForm.StatusBarBackgroudPanel.Height
        End If

        'Verificar posição horizontal 
        If Me.Left < 0 Then
            Me.Left = 0
        End If

        If Me.Left > Screen.PrimaryScreen.Bounds.Width - Me.Width Then
            Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
        End If
    End Sub

  
#End Region

#Region "Redimencionamento da Janela"
    Private Sub Windows_ResizeForm_MouseDown(sender As Object, e As MouseEventArgs) Handles ResizeForm.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        movef.X = Me.Width - MousePosition.X
        movef.y = Me.Height - MousePosition.Y
    End Sub

    Private Sub Window_ResizeForm_MouseMove(sender As Object, e As MouseEventArgs) Handles ResizeForm.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Width = movef.X + MousePosition.X
        Me.Height = movef.y + MousePosition.Y
    End Sub
#End Region

#Region "Default Form Events"
    Private Sub Window_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TitleBarHead.BackColor = BordersColor_Actived
        Border1.BackColor = BordersColor_Actived
        Border2.BackColor = BordersColor_Actived
        Border3.BackColor = BordersColor_Actived
    End Sub

    Private Sub Window_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        TitleBarHead.BackColor = BordersColor_Desactived
        Border1.BackColor = BordersColor_Desactived
        Border2.BackColor = BordersColor_Desactived
        Border3.BackColor = BordersColor_Desactived
        '  If FormMaximized = False Then MinimizeForm(Me)
    End Sub

    Private Sub Window_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Window_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub Window_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub Window_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TaskBar = WorkingAreaForm.FormsOpenedListBackground_Panel
    End Sub

    Private Sub Window_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        TitleWindow.Text = Me.Text
    End Sub
#End Region

#Region "Maximize & Minimize"
    Dim FormMaximized As Boolean = False
    Dim FormSize As Size
    Dim FormLocation As Point
    Dim WithEvents TaskBar As Panel

    Private Sub MaximizeFormBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles MaximizeFormBtn.MouseClick
        Select Case FormMaximized
            Case False 'Maximizar Form:
                'Salvar informações de tamanho e localização antes de maximizar:
                FormSize = Me.Size
                FormLocation = Me.Location

                'Esconder botão de redimencionamento do form:
                ResizeForm.Hide()

                'Alterar Texto e Icon do Botão de maximizar:
                MaximizeFormBtn.ButtonTipText = "Restaurar"
                MaximizeFormBtn.ButtonIcon = My.Resources.Icon_SimensBar_NormalSizeApp_18x18

                'Maximizar Form com coordenadas e informação da resolução da tela:
                Me.Left = 0
                Me.Top = WorkingAreaForm.StatusBarBackgroudPanel.Height

                Me.Width = Screen.PrimaryScreen.WorkingArea.Width - WorkingAreaForm.FormsOpenedListBackground_Panel.Width
                Me.Height = Screen.PrimaryScreen.Bounds.Height - WorkingAreaForm.MenuSystemPanel.Height - WorkingAreaForm.StatusBarBackgroudPanel.Height

                'Informar a var que o form está maximizado:
                FormMaximized = True

                'Manter-se a cima:
                Me.TopMost = True


            Case True 'Restaurar Form:
                'Exibir botão de redimencionamento do form:
                ResizeForm.Show()

                'Alterar Texto e Icon do Botão de maximizar:
                MaximizeFormBtn.ButtonTipText = "Maximizar"
                MaximizeFormBtn.ButtonIcon = My.Resources.Icon_SimensBar_MaximizeApp_18x18

                'Restaurar Form com coordenadas e informações salvas na variavel
                Me.Location = FormLocation
                Me.Size = FormSize

                'Informar a var que o form está restaurado:
                FormMaximized = False

                'Manter-se a cima (desligar):
                Me.TopMost = False
        End Select
    End Sub

    Private Sub TaskBar_SizeChanged(sender As Object, e As EventArgs) Handles TaskBar.SizeChanged
        Select Case FormMaximized
            Case True 'Se o form estive maximizado
                Me.Width = Screen.PrimaryScreen.WorkingArea.Width - WorkingAreaForm.FormsOpenedListBackground_Panel.Width
        End Select
    End Sub

    Private Sub MinimizeForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MinimizeFormBtn.MouseClick
        MinimizeForm(Me)
    End Sub
#End Region

#End Region

End Class