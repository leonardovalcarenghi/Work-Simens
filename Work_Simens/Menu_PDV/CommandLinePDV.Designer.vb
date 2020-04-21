<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandLinePDV
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
        Me.CommandsLinesPanel = New System.Windows.Forms.Panel()
        Me.LineCommand_TextBox = New System.Windows.Forms.TextBox()
        Me.EnterCodeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._2ContainerForm = New System.Windows.Forms.Panel()
        Me._1BordesForm = New System.Windows.Forms.Panel()
        Me.ResizeForm = New System.Windows.Forms.Panel()
        Me.TitleBarHead = New System.Windows.Forms.Panel()
        Me.MinimizeFormBtn = New Work_Simens.IconButtonControl()
        Me.TitleWindow = New System.Windows.Forms.Label()
        Me.Border3 = New Work_Simens.Border()
        Me.Border2 = New Work_Simens.Border()
        Me.Border1 = New Work_Simens.Border()
        Me.CommandsLinesPanel.SuspendLayout()
        Me._2ContainerForm.SuspendLayout()
        Me._1BordesForm.SuspendLayout()
        Me.TitleBarHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandsLinesPanel
        '
        Me.CommandsLinesPanel.AutoScroll = True
        Me.CommandsLinesPanel.Controls.Add(Me.LineCommand_TextBox)
        Me.CommandsLinesPanel.Controls.Add(Me.EnterCodeLabel)
        Me.CommandsLinesPanel.Controls.Add(Me.Label1)
        Me.CommandsLinesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandsLinesPanel.Location = New System.Drawing.Point(0, 0)
        Me.CommandsLinesPanel.Name = "CommandsLinesPanel"
        Me.CommandsLinesPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.CommandsLinesPanel.Size = New System.Drawing.Size(844, 391)
        Me.CommandsLinesPanel.TabIndex = 6
        '
        'LineCommand_TextBox
        '
        Me.LineCommand_TextBox.BackColor = System.Drawing.Color.Black
        Me.LineCommand_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LineCommand_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LineCommand_TextBox.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.LineCommand_TextBox.ForeColor = System.Drawing.Color.White
        Me.LineCommand_TextBox.Location = New System.Drawing.Point(5, 45)
        Me.LineCommand_TextBox.Name = "LineCommand_TextBox"
        Me.LineCommand_TextBox.Size = New System.Drawing.Size(834, 14)
        Me.LineCommand_TextBox.TabIndex = 3
        '
        'EnterCodeLabel
        '
        Me.EnterCodeLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EnterCodeLabel.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.EnterCodeLabel.Location = New System.Drawing.Point(5, 25)
        Me.EnterCodeLabel.Margin = New System.Windows.Forms.Padding(10)
        Me.EnterCodeLabel.Name = "EnterCodeLabel"
        Me.EnterCodeLabel.Size = New System.Drawing.Size(834, 20)
        Me.EnterCodeLabel.TabIndex = 1
        Me.EnterCodeLabel.Text = "Digite o comando:"
        Me.EnterCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(834, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WORK PDV Simens - Central de Acesso Remoto dos PDVs."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_2ContainerForm
        '
        Me._2ContainerForm.Controls.Add(Me.CommandsLinesPanel)
        Me._2ContainerForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me._2ContainerForm.Location = New System.Drawing.Point(1, 30)
        Me._2ContainerForm.Name = "_2ContainerForm"
        Me._2ContainerForm.Size = New System.Drawing.Size(844, 391)
        Me._2ContainerForm.TabIndex = 8
        '
        '_1BordesForm
        '
        Me._1BordesForm.Controls.Add(Me.ResizeForm)
        Me._1BordesForm.Controls.Add(Me._2ContainerForm)
        Me._1BordesForm.Controls.Add(Me.TitleBarHead)
        Me._1BordesForm.Controls.Add(Me.Border3)
        Me._1BordesForm.Controls.Add(Me.Border2)
        Me._1BordesForm.Controls.Add(Me.Border1)
        Me._1BordesForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me._1BordesForm.Location = New System.Drawing.Point(0, 0)
        Me._1BordesForm.Name = "_1BordesForm"
        Me._1BordesForm.Size = New System.Drawing.Size(846, 422)
        Me._1BordesForm.TabIndex = 7
        '
        'ResizeForm
        '
        Me.ResizeForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResizeForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ResizeForm.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.ResizeForm.Location = New System.Drawing.Point(836, 412)
        Me.ResizeForm.Name = "ResizeForm"
        Me.ResizeForm.Size = New System.Drawing.Size(10, 10)
        Me.ResizeForm.TabIndex = 9
        '
        'TitleBarHead
        '
        Me.TitleBarHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TitleBarHead.Controls.Add(Me.MinimizeFormBtn)
        Me.TitleBarHead.Controls.Add(Me.TitleWindow)
        Me.TitleBarHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarHead.ForeColor = System.Drawing.Color.White
        Me.TitleBarHead.Location = New System.Drawing.Point(1, 0)
        Me.TitleBarHead.Name = "TitleBarHead"
        Me.TitleBarHead.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.TitleBarHead.Size = New System.Drawing.Size(844, 30)
        Me.TitleBarHead.TabIndex = 7
        '
        'MinimizeFormBtn
        '
        Me.MinimizeFormBtn.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeFormBtn.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_FormSimens_MinimizeForm_18x18
        Me.MinimizeFormBtn.ButtonTipText = "Minimizar"
        Me.MinimizeFormBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeFormBtn.Location = New System.Drawing.Point(810, 0)
        Me.MinimizeFormBtn.Name = "MinimizeFormBtn"
        Me.MinimizeFormBtn.Size = New System.Drawing.Size(30, 30)
        Me.MinimizeFormBtn.TabIndex = 2
        '
        'TitleWindow
        '
        Me.TitleWindow.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TitleWindow.AutoSize = True
        Me.TitleWindow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TitleWindow.Location = New System.Drawing.Point(8, 6)
        Me.TitleWindow.Name = "TitleWindow"
        Me.TitleWindow.Size = New System.Drawing.Size(173, 19)
        Me.TitleWindow.TabIndex = 0
        Me.TitleWindow.Text = "Windows Form Application"
        '
        'Border3
        '
        Me.Border3.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Border3.BorderPosition = Work_Simens.Border.BorderPositionEnum.Bottom
        Me.Border3.BorderSize = 1
        Me.Border3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Border3.Location = New System.Drawing.Point(1, 421)
        Me.Border3.Name = "Border3"
        Me.Border3.Size = New System.Drawing.Size(844, 1)
        Me.Border3.TabIndex = 6
        '
        'Border2
        '
        Me.Border2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Border2.BorderPosition = Work_Simens.Border.BorderPositionEnum.Left
        Me.Border2.BorderSize = 1
        Me.Border2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Border2.Location = New System.Drawing.Point(0, 0)
        Me.Border2.Name = "Border2"
        Me.Border2.Size = New System.Drawing.Size(1, 422)
        Me.Border2.TabIndex = 5
        '
        'Border1
        '
        Me.Border1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Border1.BorderPosition = Work_Simens.Border.BorderPositionEnum.Right
        Me.Border1.BorderSize = 1
        Me.Border1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Border1.Location = New System.Drawing.Point(845, 0)
        Me.Border1.Name = "Border1"
        Me.Border1.Size = New System.Drawing.Size(1, 422)
        Me.Border1.TabIndex = 4
        '
        'CommandLinePDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(846, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me._1BordesForm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CommandLinePDV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Central de Acesso Remoto dos PDVs"
        Me.CommandsLinesPanel.ResumeLayout(False)
        Me.CommandsLinesPanel.PerformLayout()
        Me._2ContainerForm.ResumeLayout(False)
        Me._1BordesForm.ResumeLayout(False)
        Me.TitleBarHead.ResumeLayout(False)
        Me.TitleBarHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CommandsLinesPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineCommand_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnterCodeLabel As System.Windows.Forms.Label
    Friend WithEvents _2ContainerForm As System.Windows.Forms.Panel
    Friend WithEvents _1BordesForm As System.Windows.Forms.Panel
    Friend WithEvents ResizeForm As System.Windows.Forms.Panel
    Friend WithEvents TitleBarHead As System.Windows.Forms.Panel
    Friend WithEvents MinimizeFormBtn As Work_Simens.IconButtonControl
    Friend WithEvents TitleWindow As System.Windows.Forms.Label
    Friend WithEvents Border3 As Work_Simens.Border
    Friend WithEvents Border2 As Work_Simens.Border
    Friend WithEvents Border1 As Work_Simens.Border
End Class
