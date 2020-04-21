Public Class MenuItemListControl

    Private Sub MenuItemListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
        Me.Dock = DockStyle.Top
    End Sub

    Public Property MenuTitle As String
        Get
            Return MenuTitle_Label.Text
        End Get
        Set(value As String)
            MenuTitle_Label.Text = value
        End Set
    End Property
    Public Property MenuDescription As String
        Get
            Return MenuDescription_Label.Text
        End Get
        Set(value As String)
            MenuDescription_Label.Text = value
        End Set
    End Property
    Public Property MenuIcon As Image
        Get
            Return MenuIcon_PictureBox.Image
        End Get
        Set(value As Image)
            MenuIcon_PictureBox.Image = value
        End Set
    End Property

    Dim VAR_MenuListMode As MenuListModeEnum = MenuListModeEnum.TitleAndDescription
    Public Property MenuListMode As MenuListModeEnum
        Get
            Return VAR_MenuListMode
        End Get
        Set(value As MenuListModeEnum)
            VAR_MenuListMode = value
            Select Case value
                Case MenuListModeEnum.OnlyTitle
                    If VAR_ShowIcon = False Then Me.Height = 30 Else Me.Height = 50
                    MenuTitle_Label.Top = (Me.Height - MenuTitle_Label.Height) / 2
                    MenuDescription_Label.Hide()

                Case MenuListModeEnum.TitleAndDescription
                    Me.Height = 50
                    MenuTitle_Label.Top = 8
                    MenuDescription_Label.Show()
            End Select
        End Set
    End Property

    Dim VAR_ShowIcon As Boolean = True
    Public Property ShowIcon As Boolean
        Get
            Return VAR_ShowIcon
        End Get
        Set(value As Boolean)
            VAR_ShowIcon = value
            MenuIcon_PictureBox.Visible = value

            Select Case value

                Case False
                    MenuTitle_Label.Left = 10
                    MenuDescription_Label.Left = 10
                    If VAR_MenuListMode = MenuListModeEnum.OnlyTitle Then Me.Height = 30 Else Me.Height = 50

                Case True
                    Me.Height = 50
                    MenuTitle_Label.Left = 55
                    MenuDescription_Label.Left = 55
            End Select
        End Set
    End Property

    Enum MenuListModeEnum
        OnlyTitle
        TitleAndDescription
    End Enum

    Private Sub MenuTitle_Label_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuTitle_Label.MouseClick, MenuIcon_PictureBox.MouseClick, MenuDescription_Label.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyBase.OnMouseClick(e)
        End If
    End Sub

    Private Sub MenuTitle_Label_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, MenuTitle_Label.MouseDown, MenuIcon_PictureBox.MouseDown, MenuDescription_Label.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.BackColor = Color.FromArgb(220, 220, 220)
        End If
    End Sub

    Private Sub MenuTitle_Label_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, MenuTitle_Label.MouseEnter, MenuIcon_PictureBox.MouseEnter, MenuDescription_Label.MouseEnter
        Me.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub MenuTitle_Label_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, MenuTitle_Label.MouseLeave, MenuIcon_PictureBox.MouseLeave, MenuDescription_Label.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
