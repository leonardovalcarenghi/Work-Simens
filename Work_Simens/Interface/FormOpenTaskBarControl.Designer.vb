<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpenTaskBarControl
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
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
        Me.ApplicationText_Label = New System.Windows.Forms.Label()
        Me.AppVisible = New System.Windows.Forms.Panel()
        Me.ApplicationIcon_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ApplicationIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicationText_Label
        '
        Me.ApplicationText_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ApplicationText_Label.AutoSize = True
        Me.ApplicationText_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationText_Label.ForeColor = System.Drawing.Color.White
        Me.ApplicationText_Label.Location = New System.Drawing.Point(36, 10)
        Me.ApplicationText_Label.Name = "ApplicationText_Label"
        Me.ApplicationText_Label.Size = New System.Drawing.Size(50, 15)
        Me.ApplicationText_Label.TabIndex = 14
        Me.ApplicationText_Label.Text = "app text"
        '
        'AppVisible
        '
        Me.AppVisible.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AppVisible.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppVisible.Location = New System.Drawing.Point(0, 1)
        Me.AppVisible.Name = "AppVisible"
        Me.AppVisible.Size = New System.Drawing.Size(3, 32)
        Me.AppVisible.TabIndex = 15
        Me.AppVisible.Visible = False
        '
        'ApplicationIcon_PictureBox
        '
        Me.ApplicationIcon_PictureBox.Image = Global.Work_Simens.My.Resources.Resources.Icon_WindowApplication_20x20
        Me.ApplicationIcon_PictureBox.Location = New System.Drawing.Point(11, 5)
        Me.ApplicationIcon_PictureBox.Name = "ApplicationIcon_PictureBox"
        Me.ApplicationIcon_PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.ApplicationIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ApplicationIcon_PictureBox.TabIndex = 0
        Me.ApplicationIcon_PictureBox.TabStop = False
        '
        'FormOpenTaskBarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Controls.Add(Me.AppVisible)
        Me.Controls.Add(Me.ApplicationText_Label)
        Me.Controls.Add(Me.ApplicationIcon_PictureBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FormOpenTaskBarControl"
        Me.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.Size = New System.Drawing.Size(235, 34)
        CType(Me.ApplicationIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApplicationIcon_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ApplicationText_Label As System.Windows.Forms.Label
    Friend WithEvents AppVisible As System.Windows.Forms.Panel

End Class
