Imports System.Windows.Forms

Public Class MenuSimens_PDV

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MenuItemListControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemListControl1.MouseClick
        ShowForm(CommandLinePDV)
        Me.Close()
        'CommandLinePDV.MdiParent = WorkingAreaForm

    End Sub
End Class
