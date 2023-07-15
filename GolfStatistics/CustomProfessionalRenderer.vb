' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * CustomProfessionalRenderer

Public Class CustomProfessionalRenderer
    Inherits ToolStripProfessionalRenderer

    ' This method overrides the OnRenderMenuItemBackground method in the base class.
    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        ' Call the base method to perform the default rendering.
        MyBase.OnRenderMenuItemBackground(e)

        ' Set the background color and foreground color for the menu item to dark green and white, respectively.
        e.Item.BackColor = Color.DarkGreen
        e.Item.ForeColor = Color.White

        ' If the item is currently selected, set the background and foreground colors again to ensure they are correct.
        If e.Item.Selected Then
            e.Item.BackColor = Color.DarkGreen
            e.Item.ForeColor = Color.White
        Else
            e.Item.BackColor = Color.DarkGreen
            e.Item.ForeColor = Color.White
        End If
    End Sub
End Class
