Public Class MenuItemControl

    Private Sub MenuItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Left
        Me.BackColor = Color.Transparent
    End Sub

    Public Property MenuIcon As Image
        Get
            Return PictureBox1.Image
        End Get
        Set(value As Image)
            PictureBox1.Image = value
        End Set
    End Property


    Public Property MenuText As String
        Get
            Return MenuText_Label.TEXT
        End Get
        Set(value As String)
            Dim V = value
            V = V.ToUpper
            MenuText_Label.Text = V

            Dim L = MenuText_Label.Left + MenuText_Label.Width + 10
            Me.Width = L
        End Set
    End Property

    Private Sub Menu_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick, MenuText_Label.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyBase.OnMouseClick(e)
        End If
    End Sub

    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, MyBase.MouseDown, MenuText_Label.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then Me.BackColor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub Menu_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, MyBase.MouseEnter, MenuText_Label.MouseEnter
        Me.BackColor = Color.FromArgb(61, 61, 61)
    End Sub

    Private Sub Menu_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, MyBase.MouseLeave, MenuText_Label.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
