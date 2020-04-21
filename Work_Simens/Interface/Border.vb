Public Class Border

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Dock = DockStyle.Top
        Me.Size = New Size(VAR_BorderSize, VAR_BorderSize)

    End Sub
    Dim VAR_BorderPosition As BorderPositionEnum = BorderPositionEnum.Top
    Public Property BorderPosition As BorderPositionEnum
        Get
            Return VAR_BorderPosition
        End Get
        Set(value As BorderPositionEnum)
            VAR_BorderPosition = value
            Select Case value
                Case BorderPositionEnum.Top : Me.Dock = DockStyle.Top : Me.Name = "BorderTop"
                Case BorderPositionEnum.Bottom : Me.Dock = DockStyle.Bottom : Me.Name = "BorderBottom"
                Case BorderPositionEnum.Right : Me.Dock = DockStyle.Right : Me.Name = "BorderRight"
                Case BorderPositionEnum.Left : Me.Dock = DockStyle.Left : Me.Name = "BorderLeft"
            End Select
            Me.Size = New Size(VAR_BorderSize, VAR_BorderSize)
        End Set
    End Property

    Dim VAR_BorderSize As Integer = 1
    Public Property BorderSize As Integer
        Get
            Return VAR_BorderSize
        End Get
        Set(value As Integer)
            VAR_BorderSize = value
            Me.Size = New Size(value, value)
        End Set
    End Property

    Enum BorderPositionEnum
        Top
        Bottom
        Right
        Left
    End Enum

    Private Sub Border_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
