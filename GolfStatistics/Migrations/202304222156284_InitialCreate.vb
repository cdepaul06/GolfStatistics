Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Bags",
                Function(c) New With
                    {
                        .BagID = c.Int(nullable := False, identity := True),
                        .GolferID = c.Int(nullable := False),
                        .BagBrand = c.String(),
                        .CartBag = c.Boolean(nullable := False),
                        .IndividualClubSlots = c.Boolean(nullable := False),
                        .Cooler = c.Boolean(nullable := False),
                        .SingleStrap = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.BagID)
            
            CreateTable(
                "dbo.Balls",
                Function(c) New With
                    {
                        .Ball_ID = c.Int(nullable := False, identity := True),
                        .Brand = c.String(),
                        .Model = c.String(),
                        .SuperSoft = c.Boolean(nullable := False),
                        .BagID = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Ball_ID)
            
            CreateTable(
                "dbo.Clubs",
                Function(c) New With
                    {
                        .ClubID = c.Int(nullable := False, identity := True),
                        .BagID = c.Int(nullable := False),
                        .Brand = c.String(),
                        .Type = c.String(),
                        .Model = c.String(),
                        .Distance = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.ClubID)
            
            CreateTable(
                "dbo.Courses",
                Function(c) New With
                    {
                        .CourseID = c.Int(nullable := False, identity := True),
                        .CourseName = c.String(),
                        .CourseLocation = c.String(),
                        .CoursePar = c.Int(nullable := False),
                        .Par3 = c.Int(nullable := False),
                        .Par4 = c.Int(nullable := False),
                        .Par5 = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.CourseID)
            
            CreateTable(
                "dbo.Golfers",
                Function(c) New With
                    {
                        .GolferID = c.Int(nullable := False, identity := True),
                        .FirstName = c.String(),
                        .LastName = c.String(),
                        .PhoneNumber = c.String(),
                        .Email = c.String(),
                        .AverageScore = c.Double(nullable := False),
                        .Password = c.String()
                    }) _
                .PrimaryKey(Function(t) t.GolferID)
            
            CreateTable(
                "dbo.Rounds",
                Function(c) New With
                    {
                        .RoundID = c.Int(nullable := False, identity := True),
                        .GolferID = c.Int(nullable := False),
                        .CourseID = c.Int(nullable := False),
                        .DatePlayed = c.DateTime(nullable := False),
                        .RoundDuration = c.Int(nullable := False),
                        .Score = c.Int(nullable := False),
                        .HoleInOne = c.Int(nullable := False),
                        .Albatross = c.Int(nullable := False),
                        .Eagle = c.Int(nullable := False),
                        .Birdie = c.Int(nullable := False),
                        .Par = c.Int(nullable := False),
                        .Bogey = c.Int(nullable := False),
                        .DoubleBogey = c.Int(nullable := False),
                        .TripleBogey = c.Int(nullable := False),
                        .TriplePlus = c.Int(nullable := False),
                        .UpAndDown = c.Int(nullable := False),
                        .HazardsHit = c.Int(nullable := False),
                        .OnePutt = c.Int(nullable := False),
                        .ThreePutt = c.Int(nullable := False),
                        .HoleOut = c.Int(nullable := False),
                        .Penalties = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.RoundID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Rounds")
            DropTable("dbo.Golfers")
            DropTable("dbo.Courses")
            DropTable("dbo.Clubs")
            DropTable("dbo.Balls")
            DropTable("dbo.Bags")
        End Sub
    End Class
End Namespace
