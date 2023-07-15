Imports System.Data.Entity
Imports System.Xml

Public Class GolfStatisticsDbContext
    Inherits DbContext

    Public Property Bags As DbSet(Of Bag)

    Public Property Balls As DbSet(Of Ball)

    Public Property Clubs As DbSet(Of Club)

    Public Property Courses As DbSet(Of Course)

    Public Property Golfers As DbSet(Of Golfer)

    Public Property Rounds As DbSet(Of Round)

End Class
