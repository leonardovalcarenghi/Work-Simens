<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSimens_PDV
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.ControlsForm = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuItemListControl3 = New Work_Simens.MenuItemListControl()
        Me.MenuItemListControl1 = New Work_Simens.MenuItemListControl()
        Me.MenuItemListControl2 = New Work_Simens.MenuItemListControl()
        Me.MenuItemListControl4 = New Work_Simens.MenuItemListControl()
        Me.TitleDialogHeader_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseMenuBtn = New System.Windows.Forms.PictureBox()
        Me.MenuTitle_Label = New System.Windows.Forms.Label()
        Me.BorderLeft = New Work_Simens.Border()
        Me.BorderBottom = New Work_Simens.Border()
        Me.BorderRight = New Work_Simens.Border()
        Me.BorderTop = New Work_Simens.Border()
        Me.Timer_Loading = New System.Windows.Forms.Timer(Me.components)
        Me.BordersPanel.SuspendLayout()
        Me.ControlsForm.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TitleDialogHeader_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BordersPanel
        '
        Me.BordersPanel.Controls.Add(Me.ControlsForm)
        Me.BordersPanel.Controls.Add(Me.BorderLeft)
        Me.BordersPanel.Controls.Add(Me.BorderBottom)
        Me.BordersPanel.Controls.Add(Me.BorderRight)
        Me.BordersPanel.Controls.Add(Me.BorderTop)
        Me.BordersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BordersPanel.Location = New System.Drawing.Point(0, 0)
        Me.BordersPanel.Name = "BordersPanel"
        Me.BordersPanel.Size = New System.Drawing.Size(450, 600)
        Me.BordersPanel.TabIndex = 2
        '
        'ControlsForm
        '
        Me.ControlsForm.Controls.Add(Me.Panel2)
        Me.ControlsForm.Controls.Add(Me.TitleDialogHeader_Panel)
        Me.ControlsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsForm.Location = New System.Drawing.Point(1, 1)
        Me.ControlsForm.Name = "ControlsForm"
        Me.ControlsForm.Size = New System.Drawing.Size(448, 598)
        Me.ControlsForm.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuItemListControl3)
        Me.Panel2.Controls.Add(Me.MenuItemListControl1)
        Me.Panel2.Controls.Add(Me.MenuItemListControl2)
        Me.Panel2.Controls.Add(Me.MenuItemListControl4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 548)
        Me.Panel2.TabIndex = 6
        '
        'MenuItemListControl3
        '
        Me.MenuItemListControl3.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl3.Location = New System.Drawing.Point(0, 150)
        Me.MenuItemListControl3.MenuDescription = "Acessar configurações de cada PDV"
        Me.MenuItemListControl3.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_MenuList_Settings_32x32
        Me.MenuItemListControl3.MenuListMode = Work_Simens.MenuItemListControl.MenuListModeEnum.TitleAndDescription
        Me.MenuItemListControl3.MenuTitle = "Configurar PDVs"
        Me.MenuItemListControl3.Name = "MenuItemListControl3"
        Me.MenuItemListControl3.ShowIcon = True
        Me.MenuItemListControl3.Size = New System.Drawing.Size(448, 50)
        Me.MenuItemListControl3.TabIndex = 3
        '
        'MenuItemListControl1
        '
        Me.MenuItemListControl1.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl1.Location = New System.Drawing.Point(0, 100)
        Me.MenuItemListControl1.MenuDescription = "Acessar linha de comando dos PDV's."
        Me.MenuItemListControl1.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_MenuList_RemoteControl_32x32
        Me.MenuItemListControl1.MenuListMode = Work_Simens.MenuItemListControl.MenuListModeEnum.TitleAndDescription
        Me.MenuItemListControl1.MenuTitle = "Acesso Remoto"
        Me.MenuItemListControl1.Name = "MenuItemListControl1"
        Me.MenuItemListControl1.ShowIcon = True
        Me.MenuItemListControl1.Size = New System.Drawing.Size(448, 50)
        Me.MenuItemListControl1.TabIndex = 1
        '
        'MenuItemListControl2
        '
        Me.MenuItemListControl2.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl2.Location = New System.Drawing.Point(0, 50)
        Me.MenuItemListControl2.MenuDescription = "Gerenciar Pdvs"
        Me.MenuItemListControl2.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_MenuList_ManagerDevices_32x32
        Me.MenuItemListControl2.MenuListMode = Work_Simens.MenuItemListControl.MenuListModeEnum.TitleAndDescription
        Me.MenuItemListControl2.MenuTitle = "Gerenciar Pontos de Venda"
        Me.MenuItemListControl2.Name = "MenuItemListControl2"
        Me.MenuItemListControl2.ShowIcon = True
        Me.MenuItemListControl2.Size = New System.Drawing.Size(448, 50)
        Me.MenuItemListControl2.TabIndex = 2
        '
        'MenuItemListControl4
        '
        Me.MenuItemListControl4.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemListControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuItemListControl4.Location = New System.Drawing.Point(0, 0)
        Me.MenuItemListControl4.MenuDescription = "Acessar configurações de cada PDV"
        Me.MenuItemListControl4.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_MenuList_Settings_32x32
        Me.MenuItemListControl4.MenuListMode = Work_Simens.MenuItemListControl.MenuListModeEnum.OnlyTitle
        Me.MenuItemListControl4.MenuTitle = "Novo PDV"
        Me.MenuItemListControl4.Name = "MenuItemListControl4"
        Me.MenuItemListControl4.ShowIcon = True
        Me.MenuItemListControl4.Size = New System.Drawing.Size(448, 50)
        Me.MenuItemListControl4.TabIndex = 4
        '
        'TitleDialogHeader_Panel
        '
        Me.TitleDialogHeader_Panel.Controls.Add(Me.Panel1)
        Me.TitleDialogHeader_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleDialogHeader_Panel.Location = New System.Drawing.Point(0, 0)
        Me.TitleDialogHeader_Panel.Name = "TitleDialogHeader_Panel"
        Me.TitleDialogHeader_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.TitleDialogHeader_Panel.Size = New System.Drawing.Size(448, 50)
        Me.TitleDialogHeader_Panel.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseMenuBtn)
        Me.Panel1.Controls.Add(Me.MenuTitle_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 30)
        Me.Panel1.TabIndex = 6
        '
        'CloseMenuBtn
        '
        Me.CloseMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CloseMenuBtn.Image = Global.Work_Simens.My.Resources.Resources.Icon_CloseMenu_Enter_16x16
        Me.CloseMenuBtn.Location = New System.Drawing.Point(410, 7)
        Me.CloseMenuBtn.Name = "CloseMenuBtn"
        Me.CloseMenuBtn.Size = New System.Drawing.Size(16, 16)
        Me.CloseMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CloseMenuBtn.TabIndex = 8
        Me.CloseMenuBtn.TabStop = False
        '
        'MenuTitle_Label
        '
        Me.MenuTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuTitle_Label.AutoSize = True
        Me.MenuTitle_Label.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.MenuTitle_Label.Location = New System.Drawing.Point(15, 3)
        Me.MenuTitle_Label.Name = "MenuTitle_Label"
        Me.MenuTitle_Label.Size = New System.Drawing.Size(48, 25)
        Me.MenuTitle_Label.TabIndex = 6
        Me.MenuTitle_Label.Text = "PDV"
        Me.MenuTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderLeft.BorderPosition = Work_Simens.Border.BorderPositionEnum.Left
        Me.BorderLeft.BorderSize = 1
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 1)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 598)
        Me.BorderLeft.TabIndex = 3
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderBottom.BorderPosition = Work_Simens.Border.BorderPositionEnum.Bottom
        Me.BorderBottom.BorderSize = 1
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 599)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(449, 1)
        Me.BorderBottom.TabIndex = 2
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderRight.BorderPosition = Work_Simens.Border.BorderPositionEnum.Top
        Me.BorderRight.BorderSize = 1
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(449, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 599)
        Me.BorderRight.TabIndex = 1
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderTop.BorderPosition = Work_Simens.Border.BorderPositionEnum.Top
        Me.BorderTop.BorderSize = 1
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(450, 1)
        Me.BorderTop.TabIndex = 0
        '
        'Timer_Loading
        '
        Me.Timer_Loading.Interval = 1000
        '
        'MenuSimens_PDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 600)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuSimens_PDV"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.BordersPanel.ResumeLayout(False)
        Me.ControlsForm.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TitleDialogHeader_Panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CloseMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlsForm As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuItemListControl2 As Work_Simens.MenuItemListControl
    Friend WithEvents MenuItemListControl1 As Work_Simens.MenuItemListControl
    Friend WithEvents TitleDialogHeader_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuTitle_Label As System.Windows.Forms.Label
    Friend WithEvents BorderLeft As Work_Simens.Border
    Friend WithEvents BorderBottom As Work_Simens.Border
    Friend WithEvents BorderRight As Work_Simens.Border
    Friend WithEvents BorderTop As Work_Simens.Border
    Friend WithEvents Timer_Loading As System.Windows.Forms.Timer
    Friend WithEvents MenuItemListControl3 As Work_Simens.MenuItemListControl
    Friend WithEvents CloseMenuBtn As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItemListControl4 As Work_Simens.MenuItemListControl

End Class
