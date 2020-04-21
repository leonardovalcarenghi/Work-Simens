Public Class FormOpenTaskBarControl

    Private Sub FormOpenTaskBarControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
    End Sub

    Dim WithEvents VAR_ApplicationForm As Form
    Public Property ApplicationForm As Form
        Get
            Return VAR_ApplicationForm
        End Get
        Set(value As Form)
            VAR_ApplicationForm = value

            ApplicationText_Label.Text = value.Text
        End Set
    End Property


    Private Sub FormOpenTaskBarControl_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, ApplicationText_Label.MouseClick, ApplicationIcon_PictureBox.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case VAR_ApplicationForm.WindowState
                Case FormWindowState.Minimized
                    RestaureForm(VAR_ApplicationForm)

                Case FormWindowState.Normal
                    MinimizeForm(VAR_ApplicationForm)
            End Select
        End If
    End Sub

    Private Sub FormOpenTaskBarControl_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, ApplicationText_Label.MouseDown, ApplicationIcon_PictureBox.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then Me.BackColor = Color.FromArgb(27, 27, 27)
    End Sub

    Private Sub FormOpenTaskBarControl_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, ApplicationText_Label.MouseEnter, ApplicationIcon_PictureBox.MouseEnter
        Me.BackColor = Color.FromArgb(39, 39, 39)
    End Sub

    Private Sub FormOpenTaskBarControl_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, ApplicationText_Label.MouseLeave, ApplicationIcon_PictureBox.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub VAR_ApplicationForm_Activated(sender As Object, e As EventArgs) Handles VAR_ApplicationForm.Activated
        AppVisible.Show()
    End Sub

    Private Sub VAR_ApplicationForm_Deactivate(sender As Object, e As EventArgs) Handles VAR_ApplicationForm.Deactivate
        '  AppVisible.Hide()
    End Sub

    Private Sub VAR_ApplicationForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles VAR_ApplicationForm.FormClosed
        Me.Hide()
    End Sub

    Private Sub VAR_ApplicationForm_TextChanged(sender As Object, e As EventArgs) Handles VAR_ApplicationForm.TextChanged
        ApplicationText_Label.Text = VAR_ApplicationForm.Text
    End Sub
End Class
