<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItemListControl
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
        Me.MenuTitle_Label = New System.Windows.Forms.Label()
        Me.MenuDescription_Label = New System.Windows.Forms.Label()
        Me.MenuIcon_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.MenuIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTitle_Label
        '
        Me.MenuTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuTitle_Label.AutoSize = True
        Me.MenuTitle_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTitle_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuTitle_Label.Location = New System.Drawing.Point(55, 7)
        Me.MenuTitle_Label.Name = "MenuTitle_Label"
        Me.MenuTitle_Label.Size = New System.Drawing.Size(33, 17)
        Me.MenuTitle_Label.TabIndex = 7
        Me.MenuTitle_Label.Text = "Title"
        Me.MenuTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuDescription_Label
        '
        Me.MenuDescription_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuDescription_Label.AutoSize = True
        Me.MenuDescription_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDescription_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuDescription_Label.Location = New System.Drawing.Point(55, 28)
        Me.MenuDescription_Label.Name = "MenuDescription_Label"
        Me.MenuDescription_Label.Size = New System.Drawing.Size(65, 15)
        Me.MenuDescription_Label.TabIndex = 8
        Me.MenuDescription_Label.Text = "description"
        Me.MenuDescription_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuIcon_PictureBox
        '
        Me.MenuIcon_PictureBox.Location = New System.Drawing.Point(10, 3)
        Me.MenuIcon_PictureBox.Name = "MenuIcon_PictureBox"
        Me.MenuIcon_PictureBox.Size = New System.Drawing.Size(44, 44)
        Me.MenuIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuIcon_PictureBox.TabIndex = 0
        Me.MenuIcon_PictureBox.TabStop = False
        '
        'MenuItemListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuDescription_Label)
        Me.Controls.Add(Me.MenuTitle_Label)
        Me.Controls.Add(Me.MenuIcon_PictureBox)
        Me.Name = "MenuItemListControl"
        Me.Size = New System.Drawing.Size(450, 50)
        CType(Me.MenuIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuIcon_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MenuTitle_Label As System.Windows.Forms.Label
    Friend WithEvents MenuDescription_Label As System.Windows.Forms.Label

End Class
