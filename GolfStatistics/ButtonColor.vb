' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * ButtonColor

Public Class ButtonColor
    Inherits Button

    Public Sub New()
        MyBase.New()
        SetDefaultColors()
    End Sub

    Private Sub SetDefaultColors()
        ' Default background color for all buttons is ForestGreen
        Me.BackColor = Color.ForestGreen
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        ' Any time a user enters a button control, change the backcolor to LimeGreen (UX/Feedback)
        MyBase.OnMouseEnter(e)
        Me.BackColor = Color.LimeGreen
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        ' Any time a user leaves a button control, return to default colors (ForestGreen)
        MyBase.OnMouseLeave(e)
        SetDefaultColors()
    End Sub
End Class
