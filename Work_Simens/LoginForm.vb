Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = "<h1>Seja bem-vindo ao Simens!</h1>" & _
            "<p>Para acessar o sistema, por favor entrar com seus dados de login (Usuário e Senha).</p>"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WorkingAreaForm.Show()
        Me.Hide()
    End Sub
End Class
