' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Ball

Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ball
    ' This property represents the primary key for the Ball entity.
    <Key>
    Public Property Ball_ID As Integer

    ' This property represents the brand of the golf ball.
    Public Property Brand As String

    ' This property represents the model of the golf ball.
    Public Property Model As String

    ' This property indicates whether the golf ball is a super soft ball.
    Public Property SuperSoft As Boolean?

    ' This property represents the foreign key for the associated Bag entity.
    <ForeignKey("Bag")>
    Public Property BagID As Integer?

    ' This property represents the associated Bag entity.
    ' The Overridable keyword allows this property to be overridden in derived classes.
    Public Overridable Property Bag As Bag
End Class
