' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Round

Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Round
    ' This property represents the primary key for the Round entity.
    <Key>
    Public Property RoundID As Integer

    ' This property represents the foreign key for the Golfer entity.
    <ForeignKey("Golfer")>
    Public Property GolferID As Integer

    ' This property represents the foreign key for the Course entity.
    <ForeignKey("Course")>
    Public Property CourseID As Integer

    ' This property represents the name of the round.
    Public Property RoundName As String

    ' This property represents the date the round was played.
    Public Property DatePlayed As Date

    ' This property represents the duration of the round in hours.
    Public Property RoundDuration As Double?

    ' This property represents the score for the round.
    Public Property Score As Integer?

    ' These properties represent the number of times different events occurred during the round.
    Public Property HoleInOne As Integer?
    Public Property Albatross As Integer?
    Public Property Eagle As Integer?
    Public Property Birdie As Integer?
    Public Property Par As Integer?
    Public Property Bogey As Integer?
    Public Property DoubleBogey As Integer?
    Public Property TripleBogey As Integer?
    Public Property TriplePlus As Integer?
    Public Property UpAndDown As Integer?
    Public Property HazardsHit As Integer?
    Public Property OnePutt As Integer?
    Public Property ThreePutt As Integer?
    Public Property HoleOut As Integer?
    Public Property Penalties As Integer?

    ' These properties allow navigation to the Golfer and Course entities.
    Public Overridable Property Golfer As Golfer
    Public Overridable Property Course As Course

    ' This method overrides the default ToString() method to return the DatePlayed property,
    ' or "<Add New>" if the RoundID property is 0.
    Public Overrides Function ToString() As String
        If RoundID <> 0 Then
            Return $"{DatePlayed}"
        Else
            Return "<Add New>"
        End If
    End Function
End Class
