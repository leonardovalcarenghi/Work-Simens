Imports System.Windows.Forms

Public Class MenuSimens_Products

#Region "Default Events Form"
#Region "Close Form Button"
    Private Sub CloseMenuBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles CloseMenuBtn.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Close()
        End If
    End Sub

    Private Sub CloseMenuBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseMenuBtn.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            CloseMenuBtn.Image = My.Resources.Icon_CloseMenu_Down_16x16
        End If
    End Sub

    Private Sub CloseMenuBtn_MouseEnter(sender As Object, e As EventArgs) Handles CloseMenuBtn.MouseEnter
        CloseMenuBtn.Image = My.Resources.Icon_CloseMenu_Enter_16x16
        CloseMenuBtn.BackColor = Color.FromArgb(245, 245, 245)
    End Sub

    Private Sub CloseMenuBtn_MouseLeave(sender As Object, e As EventArgs) Handles CloseMenuBtn.MouseLeave
        CloseMenuBtn.Image = My.Resources.Icon_CloseMenu_Normal_16x16
        CloseMenuBtn.BackColor = Color.Transparent
    End Sub
#End Region

#End Region

   
End Class
