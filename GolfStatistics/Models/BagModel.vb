' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * Bag

Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Bag
    ' This property represents the primary key for the Bag entity.
    <Key>
    Public Property BagID As Integer

    ' This property represents the foreign key for the associated Golfer entity.
    <ForeignKey("Golfer")>
    Public Property GolferID As Integer

    ' This property represents the brand of the golf bag.
    Public Property BagBrand As String

    ' This property indicates whether the golf bag is a cartbag or not.
    Public Property CartBag As Boolean?

    ' This property indicates whether the golf bag has individual club slots
    Public Property IndividualClubSlots As Boolean?

    ' This property indicates whether the golf bag has a built-in cooler.
    Public Property Cooler As Boolean?

    ' This property indicates whether the golf bag has a single strap.
    Public Property SingleStrap As Boolean?

    ' This property represents the associated Golfer entity.
    Public Overridable Property Golfer As Golfer

    ' This property represents the collection of Club entities associated with this Bag entity.
    Public Property Clubs As List(Of Club)
End Class
