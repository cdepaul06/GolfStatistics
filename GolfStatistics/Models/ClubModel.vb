' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Club

Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Club
    ' This property represents the primary key for the Club entity.
    <Key>
    Public Property ClubID As Integer

    ' This property represents the foreign key for the associated Bag entity.
    <ForeignKey("Bag")>
    Public Property BagID As Integer

    ' This property represents the brand of the golf club.
    Public Property Brand As String

    ' This property represents the type of the golf club (e.g., driver, putter, iron).
    Public Property Type As String

    ' This property represents the model of the golf club.
    Public Property Model As String

    ' This property represents the average distance achieved by the golf club, in yards.
    Public Property Distance As Integer?

    ' This property represents the associated Bag entity.
    ' The Overridable keyword allows this property to be overridden in derived classes.
    Public Overridable Property Bag As Bag
End Class
