<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        Me.LoginBackgroundPanel = New System.Windows.Forms.Panel()
        Me.LoginInformations_Panel = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.UserPhoto_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ShowPassword_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SelectUser_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.TitleSoftware_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AcessKey_Label = New System.Windows.Forms.Label()
        Me.ChaveDeAcesso_Label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoginBackgroundPanel.SuspendLayout()
        Me.LoginInformations_Panel.SuspendLayout()
        Me.Login_Panel.SuspendLayout()
        CType(Me.UserPhoto_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginBackgroundPanel
        '
        Me.LoginBackgroundPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginBackgroundPanel.Controls.Add(Me.LoginInformations_Panel)
        Me.LoginBackgroundPanel.Controls.Add(Me.Login_Panel)
        Me.LoginBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginBackgroundPanel.Location = New System.Drawing.Point(0, 80)
        Me.LoginBackgroundPanel.Name = "LoginBackgroundPanel"
        Me.LoginBackgroundPanel.Size = New System.Drawing.Size(1100, 415)
        Me.LoginBackgroundPanel.TabIndex = 6
        '
        'LoginInformations_Panel
        '
        Me.LoginInformations_Panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginInformations_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LoginInformations_Panel.Controls.Add(Me.WebBrowser1)
        Me.LoginInformations_Panel.Location = New System.Drawing.Point(550, 55)
        Me.LoginInformations_Panel.Name = "LoginInformations_Panel"
        Me.LoginInformations_Panel.Size = New System.Drawing.Size(450, 305)
        Me.LoginInformations_Panel.TabIndex = 14
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(450, 305)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Login_Panel
        '
        Me.Login_Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Login_Panel.Controls.Add(Me.Button1)
        Me.Login_Panel.Controls.Add(Me.UserPhoto_PictureBox)
        Me.Login_Panel.Controls.Add(Me.ShowPassword_CheckBox)
        Me.Login_Panel.Controls.Add(Me.Password_TextBox)
        Me.Login_Panel.Controls.Add(Me.Label4)
        Me.Login_Panel.Controls.Add(Me.SelectUser_ComboBox)
        Me.Login_Panel.Controls.Add(Me.Label3)
        Me.Login_Panel.Controls.Add(Me.Label1)
        Me.Login_Panel.Controls.Add(Me.Label2)
        Me.Login_Panel.Location = New System.Drawing.Point(100, 55)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(450, 305)
        Me.Login_Panel.TabIndex = 6
        '
        'UserPhoto_PictureBox
        '
        Me.UserPhoto_PictureBox.Location = New System.Drawing.Point(329, 109)
        Me.UserPhoto_PictureBox.Name = "UserPhoto_PictureBox"
        Me.UserPhoto_PictureBox.Size = New System.Drawing.Size(79, 79)
        Me.UserPhoto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPhoto_PictureBox.TabIndex = 14
        Me.UserPhoto_PictureBox.TabStop = False
        '
        'ShowPassword_CheckBox
        '
        Me.ShowPassword_CheckBox.AutoSize = True
        Me.ShowPassword_CheckBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassword_CheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShowPassword_CheckBox.Location = New System.Drawing.Point(23, 194)
        Me.ShowPassword_CheckBox.Name = "ShowPassword_CheckBox"
        Me.ShowPassword_CheckBox.Size = New System.Drawing.Size(106, 17)
        Me.ShowPassword_CheckBox.TabIndex = 13
        Me.ShowPassword_CheckBox.Text = "Mostrar Senha?"
        Me.ShowPassword_CheckBox.UseVisualStyleBackColor = True
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password_TextBox.Location = New System.Drawing.Point(23, 165)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.Size = New System.Drawing.Size(300, 23)
        Me.Password_TextBox.TabIndex = 12
        Me.Password_TextBox.Text = "12345678"
        Me.Password_TextBox.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Senha"
        '
        'SelectUser_ComboBox
        '
        Me.SelectUser_ComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SelectUser_ComboBox.FormattingEnabled = True
        Me.SelectUser_ComboBox.Items.AddRange(New Object() {"Leonardo Valcarenghi"})
        Me.SelectUser_ComboBox.Location = New System.Drawing.Point(23, 109)
        Me.SelectUser_ComboBox.Name = "SelectUser_ComboBox"
        Me.SelectUser_ComboBox.Size = New System.Drawing.Size(300, 23)
        Me.SelectUser_ComboBox.Sorted = True
        Me.SelectUser_ComboBox.TabIndex = 9
        Me.SelectUser_ComboBox.Text = "Leonardo Valcarenghi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Usuário"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Por favor, informe seus dados de login para acessar o sistema."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Login"
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 611)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(1100, 40)
        Me.BottomPanel.TabIndex = 7
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.TitleSoftware_Label)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1100, 80)
        Me.HeaderPanel.TabIndex = 8
        '
        'TitleSoftware_Label
        '
        Me.TitleSoftware_Label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TitleSoftware_Label.AutoSize = True
        Me.TitleSoftware_Label.BackColor = System.Drawing.Color.Transparent
        Me.TitleSoftware_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSoftware_Label.ForeColor = System.Drawing.Color.White
        Me.TitleSoftware_Label.Location = New System.Drawing.Point(436, 17)
        Me.TitleSoftware_Label.Name = "TitleSoftware_Label"
        Me.TitleSoftware_Label.Size = New System.Drawing.Size(228, 47)
        Me.TitleSoftware_Label.TabIndex = 3
        Me.TitleSoftware_Label.Text = "Work Simens"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.AcessKey_Label)
        Me.Panel2.Controls.Add(Me.ChaveDeAcesso_Label)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 495)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 116)
        Me.Panel2.TabIndex = 9
        '
        'AcessKey_Label
        '
        Me.AcessKey_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcessKey_Label.BackColor = System.Drawing.Color.Transparent
        Me.AcessKey_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.AcessKey_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AcessKey_Label.Location = New System.Drawing.Point(200, 58)
        Me.AcessKey_Label.Name = "AcessKey_Label"
        Me.AcessKey_Label.Size = New System.Drawing.Size(700, 20)
        Me.AcessKey_Label.TabIndex = 5
        Me.AcessKey_Label.Text = "AADGASDHAH52616AS1D52ASFGDSF4G56SD5G64SD1F1D65AS4D56"
        Me.AcessKey_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChaveDeAcesso_Label
        '
        Me.ChaveDeAcesso_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChaveDeAcesso_Label.AutoSize = True
        Me.ChaveDeAcesso_Label.BackColor = System.Drawing.Color.Transparent
        Me.ChaveDeAcesso_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChaveDeAcesso_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ChaveDeAcesso_Label.Location = New System.Drawing.Point(494, 39)
        Me.ChaveDeAcesso_Label.Name = "ChaveDeAcesso_Label"
        Me.ChaveDeAcesso_Label.Size = New System.Drawing.Size(113, 19)
        Me.ChaveDeAcesso_Label.TabIndex = 4
        Me.ChaveDeAcesso_Label.Text = "Chave de Acesso"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(228, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 651)
        Me.Controls.Add(Me.LoginBackgroundPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Simens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LoginBackgroundPanel.ResumeLayout(False)
        Me.LoginInformations_Panel.ResumeLayout(False)
        Me.Login_Panel.ResumeLayout(False)
        Me.Login_Panel.PerformLayout()
        CType(Me.UserPhoto_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents BottomPanel As System.Windows.Forms.Panel
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents TitleSoftware_Label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AcessKey_Label As System.Windows.Forms.Label
    Friend WithEvents ChaveDeAcesso_Label As System.Windows.Forms.Label
    Friend WithEvents Login_Panel As System.Windows.Forms.Panel
    Friend WithEvents ShowPassword_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SelectUser_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoginInformations_Panel As System.Windows.Forms.Panel
    Friend WithEvents UserPhoto_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
