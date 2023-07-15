' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Golfer

Imports System.ComponentModel.DataAnnotations

Public Class Golfer
    ' This property represents the primary key for the Golfer entity.
    <Key>
    Public Property GolferID As Integer

    ' This property represents the first name of the golfer.
    Public Property FirstName As String

    ' This property represents the last name of the golfer.
    Public Property LastName As String

    ' This property represents the phone number of the golfer.
    Public Property PhoneNumber As String

    ' This property represents the email address of the golfer.
    Public Property Email As String

    ' This property represents the average score of the golfer.
    Public Property AverageScore As Double?

    ' This method overrides the default ToString() method to return the LastName and FirstName properties,
    ' or "<Add New>" if the GolferID property is 0.
    Public Overrides Function ToString() As String
        If GolferID <> 0 Then
            Return $"{LastName}, {FirstName}"
        Else
            Return "<Add New>"
        End If
    End Function
End Class
