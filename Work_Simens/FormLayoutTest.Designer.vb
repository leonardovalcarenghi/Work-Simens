<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLayoutTest
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
        Me._1BordesForm = New System.Windows.Forms.Panel()
        Me.ResizeForm = New System.Windows.Forms.Panel()
        Me._2ContainerForm = New System.Windows.Forms.Panel()
        Me.TitleBarHead = New System.Windows.Forms.Panel()
        Me.MaximizeFormBtn = New Work_Simens.IconButtonControl()
        Me.MinimizeFormBtn = New Work_Simens.IconButtonControl()
        Me.TitleWindow = New System.Windows.Forms.Label()
        Me.Border3 = New Work_Simens.Border()
        Me.Border2 = New Work_Simens.Border()
        Me.Border1 = New Work_Simens.Border()
        Me._1BordesForm.SuspendLayout()
        Me.TitleBarHead.SuspendLayout()
        Me.SuspendLayout()
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
        Me._1BordesForm.Size = New System.Drawing.Size(1000, 500)
        Me._1BordesForm.TabIndex = 4
        '
        'ResizeForm
        '
        Me.ResizeForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResizeForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ResizeForm.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.ResizeForm.Location = New System.Drawing.Point(990, 490)
        Me.ResizeForm.Name = "ResizeForm"
        Me.ResizeForm.Size = New System.Drawing.Size(10, 10)
        Me.ResizeForm.TabIndex = 9
        '
        '_2ContainerForm
        '
        Me._2ContainerForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me._2ContainerForm.Location = New System.Drawing.Point(1, 30)
        Me._2ContainerForm.Name = "_2ContainerForm"
        Me._2ContainerForm.Size = New System.Drawing.Size(998, 469)
        Me._2ContainerForm.TabIndex = 8
        '
        'TitleBarHead
        '
        Me.TitleBarHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TitleBarHead.Controls.Add(Me.MaximizeFormBtn)
        Me.TitleBarHead.Controls.Add(Me.MinimizeFormBtn)
        Me.TitleBarHead.Controls.Add(Me.TitleWindow)
        Me.TitleBarHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarHead.ForeColor = System.Drawing.Color.White
        Me.TitleBarHead.Location = New System.Drawing.Point(1, 0)
        Me.TitleBarHead.Name = "TitleBarHead"
        Me.TitleBarHead.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.TitleBarHead.Size = New System.Drawing.Size(998, 30)
        Me.TitleBarHead.TabIndex = 7
        '
        'MaximizeFormBtn
        '
        Me.MaximizeFormBtn.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeFormBtn.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_SimensBar_MaximizeApp_18x18
        Me.MaximizeFormBtn.ButtonTipText = "Maximizar"
        Me.MaximizeFormBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeFormBtn.Location = New System.Drawing.Point(934, 0)
        Me.MaximizeFormBtn.Name = "MaximizeFormBtn"
        Me.MaximizeFormBtn.Size = New System.Drawing.Size(30, 30)
        Me.MaximizeFormBtn.TabIndex = 4
        '
        'MinimizeFormBtn
        '
        Me.MinimizeFormBtn.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeFormBtn.ButtonIcon = Global.Work_Simens.My.Resources.Resources.Icon_FormSimens_MinimizeForm_18x18
        Me.MinimizeFormBtn.ButtonTipText = "Minimizar"
        Me.MinimizeFormBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeFormBtn.Location = New System.Drawing.Point(964, 0)
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
        Me.Border3.Location = New System.Drawing.Point(1, 499)
        Me.Border3.Name = "Border3"
        Me.Border3.Size = New System.Drawing.Size(998, 1)
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
        Me.Border2.Size = New System.Drawing.Size(1, 500)
        Me.Border2.TabIndex = 5
        '
        'Border1
        '
        Me.Border1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Border1.BorderPosition = Work_Simens.Border.BorderPositionEnum.Right
        Me.Border1.BorderSize = 1
        Me.Border1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Border1.Location = New System.Drawing.Point(999, 0)
        Me.Border1.Name = "Border1"
        Me.Border1.Size = New System.Drawing.Size(1, 500)
        Me.Border1.TabIndex = 4
        '
        'FormLayoutTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me._1BordesForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLayoutTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Window Layout Test"
        Me._1BordesForm.ResumeLayout(False)
        Me.TitleBarHead.ResumeLayout(False)
        Me.TitleBarHead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _1BordesForm As System.Windows.Forms.Panel
    Friend WithEvents _2ContainerForm As System.Windows.Forms.Panel
    Friend WithEvents TitleBarHead As System.Windows.Forms.Panel
    Friend WithEvents MinimizeFormBtn As Work_Simens.IconButtonControl
    Friend WithEvents TitleWindow As System.Windows.Forms.Label
    Friend WithEvents Border3 As Work_Simens.Border
    Friend WithEvents Border2 As Work_Simens.Border
    Friend WithEvents Border1 As Work_Simens.Border
    Friend WithEvents ResizeForm As System.Windows.Forms.Panel
    Friend WithEvents MaximizeFormBtn As Work_Simens.IconButtonControl
End Class
