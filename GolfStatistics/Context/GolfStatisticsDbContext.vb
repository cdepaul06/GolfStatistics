' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * GolfStatisticsDbContext

Imports System.Data.Entity

Public Class GolfStatisticsDbContext
    Inherits DbContext ' Inherit from the DbContext class

    Public Sub New() ' Define a constructor for the class
        MyBase.New("name=GolfStatisticsDbContext") ' Call the base constructor with a connection string named "GolfStatisticsDbContext"
    End Sub

    Public Property Bags As DbSet(Of Bag) ' Define a public property for the Bags table

    Public Property Balls As DbSet(Of Ball) ' Define a public property for the Balls table

    Public Property Clubs As DbSet(Of Club) ' Define a public property for the Clubs table

    Public Property Courses As DbSet(Of Course) ' Define a public property for the Courses table

    Public Property Golfers As DbSet(Of Golfer) ' Define a public property for the Golfers table

    Public Property Rounds As DbSet(Of Round) ' Define a public property for the Rounds table

End Class
