Public Class CommandLinePDV

    Dim BordersColor_Actived As Color = Color.FromArgb(120, 127, 255)
    Dim BordersColor_Desactived As Color = Color.FromArgb(147, 152, 255)

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim movef As MoveForm
    Private Sub Window_MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleWindow.MouseDown, TitleBarHead.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        movef.X = Me.Left - MousePosition.X
        movef.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Window_MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleWindow.MouseMove, TitleBarHead.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = movef.X + MousePosition.X
        Me.Top = movef.y + MousePosition.Y
    End Sub


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
    End Sub

    Private Sub Window_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Window_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub Window_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub Window_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        TitleWindow.Text = Me.Text
    End Sub


    Private Sub MinimizeForm_Load(sender As Object, e As EventArgs) Handles MinimizeFormBtn.Load

    End Sub

    Private Sub MinimizeForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MinimizeFormBtn.MouseClick
        MinimizeForm(Me)


    End Sub

    Private Sub FormLayoutTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LineCommand_TextBox_LostFocus(sender As Object, e As EventArgs) Handles LineCommand_TextBox.LostFocus
        'LineCommand_TextBox.Focus() : LineCommand_TextBox.Select()
    End Sub

  
    Private Sub LineCommand_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LineCommand_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If LineCommand_TextBox.Text <> "" Then EnterCode(LineCommand_TextBox.Text)
        End If
    End Sub

    Function WriteLine(text As String, Optional autos As Boolean = False)
        Dim LN As New Label
        LN = New Label : With LN : .AutoSize = autos : .Dock = DockStyle.Top : .Font = New Font("Lucida Console", 10) : .TextAlign = ContentAlignment.MiddleLeft : End With
        LN.Text = text
        CommandsLinesPanel.Controls.Add(LN) : LN.BringToFront()
    End Function


    Private Sub EnterCode(ByVal command As String)
        WriteLine("Comando: " & command)

        Select Case command

            Case "_listpdvstatus" : COMMAND_ListPdvStatus()

            Case "_clear" : COMMAND_Clear()

            Case "_exit", "_close" : COMMAND_ExitClose()

            Case Else : EnterCodeWithParameters(command)

        End Select
        EnterCodeLabel.BringToFront()
        LineCommand_TextBox.BringToFront() : LineCommand_TextBox.Text = ""
    End Sub

    Private Sub EnterCodeWithParameters(ByVal command As String)
        Select Case True
            Case command.Contains("_shutdownpdv")
                COMMAND_ShutdownPdv(command)

            Case Else
                COMMAND_CommandNotFound()
        End Select

    End Sub


    Sub COMMAND_ListPdvStatus()
        WriteLine("PDV 01 ------------------------------ Sistema Online" & vbNewLine & _
            "PDV 02 ------------------------------ Sistema Online" & vbNewLine & _
               "PDV 03 ------------------------------ Sistema Online" & vbNewLine & _
                  "PDV 04 ------------------------------ Sistema Online" & vbNewLine & _
                     "PDV 05 ------------------------------ Ligado (Venda em Andamento)" & vbNewLine & _
                        "PDV 06 ------------------------------ Sistema Reiniciando" & vbNewLine, True)
    End Sub

    Sub COMMAND_Clear()
        CommandsLinesPanel.Controls.Clear()
        CommandsLinesPanel.Controls.Add(Label1)
        CommandsLinesPanel.Controls.Add(EnterCodeLabel)
        CommandsLinesPanel.Controls.Add(LineCommand_TextBox)
        LineCommand_TextBox.Select() : LineCommand_TextBox.Focus()
    End Sub

    Sub COMMAND_ExitClose()
        Me.Close()
    End Sub

    Sub COMMAND_ShutdownPdv(command As String)
        Dim a As String = command
        a = a.Replace("_shutdownpdv(", "")
        a = a.Replace(")", "")
        If Not IsNumeric(a) Then
            WriteLine("Parâmetros do comando estão inválidos.")
        Else
            WriteLine("Encerrando o sistema do PDV " & a & " a partir de agora.")
        End If

    End Sub

    Sub COMMAND_CommandNotFound()
        WriteLine("Este comando é inválido. Tente novamente.")
    End Sub

End Class