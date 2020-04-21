Public Class WorkingAreaForm

    Private Sub WorkingAreaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormsOpenedListBackground_Panel.Width = 15
    End Sub

    Private Sub OpenList_Panel_MouseClick(sender As Object, e As MouseEventArgs) Handles OpenList_Panel.MouseClick
        FormsOpenedListBackground_Panel.Width = 250
    End Sub

    Private Sub MenuItemControl_Products_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemControl_Products.MouseClick
        MenuSimens_Products.ShowDialog()
    End Sub

    Private Sub MenuItemControl_Stock_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemControl_Stock.MouseClick
        MenuSimens_Stock.ShowDialog()
    End Sub

    Private Sub MenuItemControl_Employes_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemControl_Employes.MouseClick
        MenuSimens_Employees.ShowDialog()
    End Sub

    Private Sub MenuItemControl_PDVs_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemControl_PDVs.MouseClick
        MenuSimens_PDV.Show()
    End Sub

    Private Sub TitleSoftware_Label_Click(sender As Object, e As EventArgs)
        MDIParent1.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        '  sync()
    End Sub

    Private Sub MenuItemControl_Sales_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuItemControl_Sales.MouseClick
        MenuSimens_Sales.ShowDialog()
    End Sub


    Private Sub IconButton_MinimizeSystem_MouseClick(sender As Object, e As MouseEventArgs) Handles IconButton_MinimizeSystem.MouseClick
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub TitleSoftware_Label_Click_1(sender As Object, e As EventArgs) Handles TitleSoftware_Label.Click
        ShowForm(FormLayoutTest)
    End Sub
End Class