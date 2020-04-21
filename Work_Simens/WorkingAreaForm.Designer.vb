<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkingAreaForm
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
        Me.StatusBarBackgroudPanel = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TitleSoftware_Label = New System.Windows.Forms.Label()
        Me.UserPanel = New System.Windows.Forms.Panel()
        Me.UserJob_Label = New System.Windows.Forms.Label()
        Me.UserIcon_Picturebox = New System.Windows.Forms.PictureBox()
        Me.UserName_Label = New System.Windows.Forms.Label()
        Me.MenuSystemPanel = New System.Windows.Forms.Panel()
        Me.FormsOpenedListBackground_Panel = New System.Windows.Forms.Panel()
        Me.FormsOpenedList_Panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenList_Panel = New System.Windows.Forms.Panel()
        Me.MenuItemControl4 = New Work_Simens.MenuItemControl()
        Me.MenuItemControl_PDVs = New Work_Simens.MenuItemControl()
        Me.MenuItemControl_Employes = New Work_Simens.MenuItemControl()
        Me.MenuItemControl_Stock = New Work_Simens.MenuItemControl()
        Me.MenuItemControl_Sales = New Work_Simens.MenuItemControl()
        Me.MenuItemControl_Products = New Work_Simens.MenuItemControl()
        Me.IconButton_MinimizeSystem = New Work_Simens.IconButtonControl()
        Me.IconButton_Sync = New Work_Simens.IconButtonControl()
        Me.IconButton_ChangeUser = New Work_Simens.IconButtonControl()
        Me.StatusBarBackgroudPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.UserPanel.SuspendLayout()
        CType(Me.UserIcon_Picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuSystemPanel.SuspendLayout()
        Me.FormsOpenedListBackground_Panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBarBackgroudPanel
        '
        Me.StatusBarBackgroudPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StatusBarBackgroudPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.StatusBarBackgroudPanel.Controls.Add(Me.TitleSoftware_Label)
        Me.StatusBarBackgroudPanel.Controls.Add(Me.UserPanel)
        Me.StatusBarBackgroudPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusBarBackgroudPanel.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarBackgroudPanel.Name = "StatusBarBackgroudPanel"
        Me.StatusBarBackgroudPanel.Size = New System.Drawing.Size(1000, 50)
        Me.StatusBarBackgroudPanel.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.IconButton_MinimizeSystem)
        Me.FlowLayoutPanel1.Controls.Add(Me.IconButton_Sync)
        Me.FlowLayoutPanel1.Controls.Add(Me.IconButton_ChangeUser)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(7)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(294, 50)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'TitleSoftware_Label
        '
        Me.TitleSoftware_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleSoftware_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSoftware_Label.ForeColor = System.Drawing.Color.White
        Me.TitleSoftware_Label.Location = New System.Drawing.Point(300, 10)
        Me.TitleSoftware_Label.Name = "TitleSoftware_Label"
        Me.TitleSoftware_Label.Size = New System.Drawing.Size(400, 30)
        Me.TitleSoftware_Label.TabIndex = 16
        Me.TitleSoftware_Label.Text = "Work Simens"
        Me.TitleSoftware_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserPanel
        '
        Me.UserPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UserPanel.Controls.Add(Me.UserJob_Label)
        Me.UserPanel.Controls.Add(Me.UserIcon_Picturebox)
        Me.UserPanel.Controls.Add(Me.UserName_Label)
        Me.UserPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.UserPanel.Location = New System.Drawing.Point(750, 0)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(250, 50)
        Me.UserPanel.TabIndex = 0
        '
        'UserJob_Label
        '
        Me.UserJob_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UserJob_Label.AutoSize = True
        Me.UserJob_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserJob_Label.ForeColor = System.Drawing.Color.Gainsboro
        Me.UserJob_Label.Location = New System.Drawing.Point(45, 27)
        Me.UserJob_Label.Name = "UserJob_Label"
        Me.UserJob_Label.Size = New System.Drawing.Size(113, 15)
        Me.UserJob_Label.TabIndex = 16
        Me.UserJob_Label.Text = "Analista de Sistemas"
        Me.UserJob_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserIcon_Picturebox
        '
        Me.UserIcon_Picturebox.Image = Global.Work_Simens.My.Resources.Resources.Icon_User_White_32x32
        Me.UserIcon_Picturebox.Location = New System.Drawing.Point(10, 9)
        Me.UserIcon_Picturebox.Name = "UserIcon_Picturebox"
        Me.UserIcon_Picturebox.Size = New System.Drawing.Size(32, 32)
        Me.UserIcon_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.UserIcon_Picturebox.TabIndex = 15
        Me.UserIcon_Picturebox.TabStop = False
        '
        'UserName_Label
        '
        Me.UserName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UserName_Label.AutoSize = True
        Me.UserName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_Label.ForeColor = System.Drawing.Color.White
        Me.UserName_Label.Location = New System.Drawing.Point(45, 9)
        Me.UserName_Label.Name = "UserName_Label"
        Me.UserName_Label.Size = New System.Drawing.Size(138, 17)
        Me.UserName_Label.TabIndex = 15
        Me.UserName_Label.Text = "Leonardo Valcarenghi"
        Me.UserName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuSystemPanel
        '
        Me.MenuSystemPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl4)
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl_PDVs)
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl_Employes)
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl_Stock)
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl_Sales)
        Me.MenuSystemPanel.Controls.Add(Me.MenuItemControl_Products)
        Me.MenuSystemPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuSystemPanel.Location = New System.Drawing.Point(0, 460)
        Me.MenuSystemPanel.Name = "MenuSystemPanel"
        Me.MenuSystemPanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuSystemPanel.Size = New System.Drawing.Size(1000, 40)
        Me.MenuSystemPanel.TabIndex = 10
        '
        'FormsOpenedListBackground_Panel
        '
        Me.FormsOpenedListBackground_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FormsOpenedListBackground_Panel.Controls.Add(Me.FormsOpenedList_Panel)
        Me.FormsOpenedListBackground_Panel.Controls.Add(Me.Panel2)
        Me.FormsOpenedListBackground_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormsOpenedListBackground_Panel.Location = New System.Drawing.Point(750, 50)
        Me.FormsOpenedListBackground_Panel.Name = "FormsOpenedListBackground_Panel"
        Me.FormsOpenedListBackground_Panel.Size = New System.Drawing.Size(250, 410)
        Me.FormsOpenedListBackground_Panel.TabIndex = 11
        '
        'FormsOpenedList_Panel
        '
        Me.FormsOpenedList_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.FormsOpenedList_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormsOpenedList_Panel.Location = New System.Drawing.Point(15, 0)
        Me.FormsOpenedList_Panel.Name = "FormsOpenedList_Panel"
        Me.FormsOpenedList_Panel.Size = New System.Drawing.Size(235, 410)
        Me.FormsOpenedList_Panel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.OpenList_Panel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(15, 410)
        Me.Panel2.TabIndex = 0
        '
        'OpenList_Panel
        '
        Me.OpenList_Panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenList_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.OpenList_Panel.Location = New System.Drawing.Point(0, 180)
        Me.OpenList_Panel.Name = "OpenList_Panel"
        Me.OpenList_Panel.Size = New System.Drawing.Size(15, 50)
        Me.OpenList_Panel.TabIndex = 0
        '
        'MenuItemControl4
        '
        Me.MenuItemControl4.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl4.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl4.Location = New System.Drawing.Point(590, 0)
        Me.MenuItemControl4.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_Nfce_20x20
        Me.MenuItemControl4.MenuText = "NFC-E"
        Me.MenuItemControl4.Name = "MenuItemControl4"
        Me.MenuItemControl4.Size = New System.Drawing.Size(92, 40)
        Me.MenuItemControl4.TabIndex = 4
        '
        'MenuItemControl_PDVs
        '
        Me.MenuItemControl_PDVs.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl_PDVs.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl_PDVs.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl_PDVs.Location = New System.Drawing.Point(511, 0)
        Me.MenuItemControl_PDVs.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_Pdvs_20x20
        Me.MenuItemControl_PDVs.MenuText = "PDV"
        Me.MenuItemControl_PDVs.Name = "MenuItemControl_PDVs"
        Me.MenuItemControl_PDVs.Size = New System.Drawing.Size(79, 40)
        Me.MenuItemControl_PDVs.TabIndex = 2
        '
        'MenuItemControl_Employes
        '
        Me.MenuItemControl_Employes.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl_Employes.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl_Employes.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl_Employes.Location = New System.Drawing.Point(355, 0)
        Me.MenuItemControl_Employes.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_contributors_20x20
        Me.MenuItemControl_Employes.MenuText = "FUNCIONÁRIOS"
        Me.MenuItemControl_Employes.Name = "MenuItemControl_Employes"
        Me.MenuItemControl_Employes.Size = New System.Drawing.Size(156, 40)
        Me.MenuItemControl_Employes.TabIndex = 6
        '
        'MenuItemControl_Stock
        '
        Me.MenuItemControl_Stock.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl_Stock.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl_Stock.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl_Stock.Location = New System.Drawing.Point(242, 0)
        Me.MenuItemControl_Stock.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_Stock_20x20
        Me.MenuItemControl_Stock.MenuText = "ESTOQUE"
        Me.MenuItemControl_Stock.Name = "MenuItemControl_Stock"
        Me.MenuItemControl_Stock.Size = New System.Drawing.Size(113, 40)
        Me.MenuItemControl_Stock.TabIndex = 3
        '
        'MenuItemControl_Sales
        '
        Me.MenuItemControl_Sales.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl_Sales.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl_Sales.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl_Sales.Location = New System.Drawing.Point(136, 0)
        Me.MenuItemControl_Sales.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_Stock_20x20
        Me.MenuItemControl_Sales.MenuText = "VENDAS"
        Me.MenuItemControl_Sales.Name = "MenuItemControl_Sales"
        Me.MenuItemControl_Sales.Size = New System.Drawing.Size(106, 40)
        Me.MenuItemControl_Sales.TabIndex = 7
        '
        'MenuItemControl_Products
        '
        Me.MenuItemControl_Products.BackColor = System.Drawing.Color.Transparent
        Me.MenuItemControl_Products.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuItemControl_Products.ForeColor = System.Drawing.Color.White
        Me.MenuItemControl_Products.Location = New System.Drawing.Point(10, 0)
        Me.MenuItemControl_Products.MenuIcon = Global.Work_Simens.My.Resources.Resources.Icon_Menu_Products_20x20
        Me.MenuItemControl_Products.MenuText = "PRODUTOS"
        Me.MenuItemControl_Products.Name = "MenuItemControl_Products"
        Me.MenuItemControl_Products.Size = New System.Drawing.Size(126, 40)
        Me.MenuItemControl_Products.TabIndex = 1
        '
        'IconButton_MinimizeSystem
        '
        Me.IconButton_MinimizeSystem.BackColor = System.Drawing.Color.Transparent
        Me.IconButton_MinimizeSystem.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_SimensBar_MinimizeSystem_18x18
        Me.IconButton_MinimizeSystem.ButtonTipText = "Minimizar Sistema"
        Me.IconButton_MinimizeSystem.Location = New System.Drawing.Point(10, 10)
        Me.IconButton_MinimizeSystem.Name = "IconButton_MinimizeSystem"
        Me.IconButton_MinimizeSystem.Size = New System.Drawing.Size(30, 30)
        Me.IconButton_MinimizeSystem.TabIndex = 20
        '
        'IconButton_Sync
        '
        Me.IconButton_Sync.BackColor = System.Drawing.Color.Transparent
        Me.IconButton_Sync.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_SimensBar_CloundOk_18x18
        Me.IconButton_Sync.ButtonTipText = "Sincronização de Dados"
        Me.IconButton_Sync.Location = New System.Drawing.Point(46, 10)
        Me.IconButton_Sync.Name = "IconButton_Sync"
        Me.IconButton_Sync.Size = New System.Drawing.Size(30, 30)
        Me.IconButton_Sync.TabIndex = 21
        '
        'IconButton_ChangeUser
        '
        Me.IconButton_ChangeUser.BackColor = System.Drawing.Color.Transparent
        Me.IconButton_ChangeUser.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_SimensBar_ChangeUser_18x18
        Me.IconButton_ChangeUser.ButtonTipText = "Trocar de Usuário"
        Me.IconButton_ChangeUser.Location = New System.Drawing.Point(82, 10)
        Me.IconButton_ChangeUser.Name = "IconButton_ChangeUser"
        Me.IconButton_ChangeUser.Size = New System.Drawing.Size(30, 30)
        Me.IconButton_ChangeUser.TabIndex = 22
        '
        'WorkingAreaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.FormsOpenedListBackground_Panel)
        Me.Controls.Add(Me.MenuSystemPanel)
        Me.Controls.Add(Me.StatusBarBackgroudPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WorkingAreaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Simens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusBarBackgroudPanel.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        CType(Me.UserIcon_Picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuSystemPanel.ResumeLayout(False)
        Me.FormsOpenedListBackground_Panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatusBarBackgroudPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuSystemPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuItemControl_Products As Work_Simens.MenuItemControl
    Friend WithEvents MenuItemControl_Employes As Work_Simens.MenuItemControl
    Friend WithEvents MenuItemControl4 As Work_Simens.MenuItemControl
    Friend WithEvents MenuItemControl_Stock As Work_Simens.MenuItemControl
    Friend WithEvents MenuItemControl_PDVs As Work_Simens.MenuItemControl
    Friend WithEvents UserPanel As System.Windows.Forms.Panel
    Friend WithEvents UserIcon_Picturebox As System.Windows.Forms.PictureBox
    Friend WithEvents UserName_Label As System.Windows.Forms.Label
    Friend WithEvents UserJob_Label As System.Windows.Forms.Label
    Friend WithEvents TitleSoftware_Label As System.Windows.Forms.Label
    Friend WithEvents MenuItemControl_Sales As Work_Simens.MenuItemControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents IconButton_MinimizeSystem As Work_Simens.IconButtonControl
    Friend WithEvents IconButton_Sync As Work_Simens.IconButtonControl
    Friend WithEvents IconButton_ChangeUser As Work_Simens.IconButtonControl
    Friend WithEvents FormsOpenedListBackground_Panel As System.Windows.Forms.Panel
    Friend WithEvents FormsOpenedList_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenList_Panel As System.Windows.Forms.Panel
End Class
