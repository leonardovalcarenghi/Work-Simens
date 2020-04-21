Public Class IconButtonControl

    Private Sub IconButtonControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub

    Public Property ButtonIcon As Image
        Get
            Return PictureBox1.Image
        End Get
        Set(value As Image)
            PictureBox1.Image = value
        End Set
    End Property

    Public Property ButtonTipText As String
        Get
            Return ToolTip1.GetToolTip(Me)
        End Get
        Set(value As String)
            ToolTip1.SetToolTip(Me, value)
            ToolTip1.SetToolTip(PictureBox1, value)
        End Set
    End Property

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        MyBase.OnMouseClick(e)
    End Sub


    Private Sub IconButtonControl_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, MyBase.MouseDown
        Me.BackColor = Color.FromArgb(75, 75, 75)
    End Sub

    Private Sub IconButtonControl_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, MyBase.MouseEnter
        Me.BackColor = Color.FromArgb(70, 70, 70)
    End Sub

    Private Sub IconButtonControl_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, MyBase.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
