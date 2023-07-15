' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Course

Imports System.ComponentModel.DataAnnotations

Public Class Course
    ' This property represents the primary key for the Course entity.
    <Key>
    Public Property CourseID As Integer

    ' This property represents the name of the golf course.
    Public Property CourseName As String

    ' This property represents the location of the golf course.
    Public Property CourseLocation As String

    ' This property represents the par for the entire golf course.
    Public Property CoursePar As Integer?

    ' This property represents the par for all par 3 holes on the golf course.
    Public Property Par3 As Integer?

    ' This property represents the par for all par 4 holes on the golf course.
    Public Property Par4 As Integer?

    ' This property represents the par for all par 5 holes on the golf course.
    Public Property Par5 As Integer?

    ' This method overrides the default ToString() method to return the CourseName property,
    ' or "<Add New>" if the CourseID property is 0.
    Public Overrides Function ToString() As String
        If CourseID <> 0 Then
            Return $"{CourseName}"
        Else
            Return "<Add New>"
        End If
    End Function
End Class
