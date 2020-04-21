Public Class LoadingSystemForm

    Private Sub TitleSoftware_Label_Click(sender As Object, e As EventArgs) Handles TitleSoftware_Label.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoadingSystemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height)
    End Sub
End Class
