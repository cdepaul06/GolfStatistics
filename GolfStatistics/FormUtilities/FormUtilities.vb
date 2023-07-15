' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * FormUtilities

Public Class FormUtilities

#Region "Refresh Comboboxes"

    ' This public shared method is used to refresh a ComboBox with a list of golfers.
    ' It takes a ComboBox object, a GolfStatisticsDbContext object, and two optional parameters.
    ' The newGolferAdded parameter is used to specify the newly added golfer (if any) to be selected in the ComboBox.
    ' The includeAddNew parameter is used to indicate whether an "<Add New>" item should be included in the ComboBox.
    Public Shared Sub RefreshGolferComboBox(cbo As ComboBox, context As GolfStatisticsDbContext, Optional newGolferAdded As Golfer = Nothing, Optional includeAddNew As Boolean = False)
        ' Clear all items from the ComboBox
        cbo.Items.Clear()

        ' If an "<Add New>" item should be included, create a new Golfer object and add it to the ComboBox
        If includeAddNew Then
            Dim addNewGolfer = New Golfer With {
                .GolferID = 0,
                .LastName = "<Add New>"
            }
            cbo.Items.Add(addNewGolfer)
        End If

        ' Retrieve all golfers from the database context, ordered by last name
        Dim golfers = context.Golfers.OrderBy(Function(g) g.LastName)

        ' Add each golfer to the ComboBox
        For Each golfer In golfers
            cbo.Items.Add(golfer)
        Next

        ' If a new golfer has been added, select it in the ComboBox
        If newGolferAdded IsNot Nothing Then
            cbo.SelectedItem = newGolferAdded
        End If
    End Sub

    ' This public shared method is used to refresh a ComboBox with a list of courses.
    ' It takes a ComboBox object, a GolfStatisticsDbContext object, and two optional parameters.
    ' The newCourseAdded parameter is used to specify the newly added course (if any) to be selected in the ComboBox.
    ' The includeAddNew parameter is used to indicate whether an "<Add New>" item should be included in the ComboBox.
    Public Shared Sub RefreshCourseComboBox(cbo As ComboBox, context As GolfStatisticsDbContext, Optional newCourseAdded As Course = Nothing, Optional includeAddNew As Boolean = False)
        ' Clear all items from the ComboBox
        cbo.Items.Clear()

        ' If an "<Add New>" item should be included, create a new Course object and add it to the ComboBox
        If includeAddNew Then
            Dim addNewCourse = New Course With {
                .CourseID = 0,
                .CourseName = "<Add New>"
            }
            cbo.Items.Add(addNewCourse)
        End If

        ' Retrieve all courses from the database context, ordered by course name
        Dim courses = context.Courses.OrderBy(Function(c) c.CourseName)

        ' Add each course to the ComboBox
        For Each course In courses
            cbo.Items.Add(course)
        Next

        ' If a new course has been added, select it in the ComboBox
        If newCourseAdded IsNot Nothing Then
            cbo.SelectedItem = newCourseAdded
        End If
    End Sub

    ' This public shared method is used to refresh a ComboBox with a list of rounds played by a selected golfer.
    ' It takes a ComboBox object, a GolfStatisticsDbContext object, a Type object representing the selected item type (should be Golfer), and the selected golfer.
    ' The newRoundAdded
    ' parameter is used to specify the newly added round (if any) to be selected in the ComboBox.
    Public Shared Sub RefreshRoundComboBox(cbo As ComboBox, context As GolfStatisticsDbContext, selectedItemType As Type, selectedGolfer As Golfer, Optional newRoundAdded As Round = Nothing)
        ' If the selected item type is Golfer and a golfer has been selected, retrieve all rounds played by the selected golfer
        If selectedItemType = GetType(Golfer) AndAlso selectedGolfer IsNot Nothing Then
            Dim rounds = context.Rounds.Where(Function(r) r.GolferID = selectedGolfer.GolferID).OrderBy(Function(r) r.DatePlayed).ToList()

            ' Create a new list to hold the ComboBox items
            Dim roundItems As New List(Of Round)

            ' Add an "<Add New>" item to the list of ComboBox items
            Dim addNewRoundItem = New Round With {.RoundID = 0, .RoundName = "<Add New>"}
            roundItems.Add(addNewRoundItem)

            ' Add all existing rounds played by the selected golfer to the list of ComboBox items
            roundItems.AddRange(rounds)

            ' Set the ComboBox DataSource to the list of ComboBox items, with RoundName as the DisplayMember and RoundID as the ValueMember
            cbo.DataSource = roundItems
            cbo.DisplayMember = "RoundName"
            cbo.ValueMember = "RoundID"

            ' If a new round has been added, select it in the ComboBox; otherwise, select the "<Add New>" item
            If newRoundAdded IsNot Nothing Then
                cbo.SelectedItem = newRoundAdded
            Else
                cbo.SelectedItem = addNewRoundItem
            End If
        End If
    End Sub

#End Region

#Region "GetExisting 'Entity' Region"

    ' This method retrieves an existing Bag object from the database context for the specified golfer ID.
    Public Shared Function GetExistingBag(ByVal context As GolfStatisticsDbContext, ByVal golferID As Integer) As Bag
        Return context.Bags.FirstOrDefault(Function(b) b.GolferID = golferID)
    End Function

    ' This method retrieves an existing Ball object from the database context for the specified bag ID.
    Public Shared Function GetExistingBall(ByVal context As GolfStatisticsDbContext, ByVal bagID As Integer) As Ball
        Return context.Balls.FirstOrDefault(Function(b) b.BagID = bagID)
    End Function

    ' This method retrieves an existing Club object from the database context for the specified golfer ID and club type.
    Public Shared Function GetExistingClub(ByVal context As GolfStatisticsDbContext, ByVal golferID As Integer, ByVal clubType As String) As Club
        ' Retrieve the bag for the specified golfer
        Dim bagForGolfer = context.Bags.FirstOrDefault(Function(b) b.GolferID = golferID)

        If bagForGolfer IsNot Nothing Then
            ' Retrieve the club for the specified bag and club type
            Dim clubForGolfer = context.Clubs.FirstOrDefault(Function(c) c.BagID = bagForGolfer.BagID AndAlso c.Type = clubType)

            Return clubForGolfer
        Else
            ' Return null if no bag is found for the specified golfer
            Return Nothing
        End If
    End Function

    ' This method retrieves an existing Course object from the database context for the specified course ID.
    Public Shared Function GetExistingCourse(ByVal context As GolfStatisticsDbContext, ByVal courseID As Integer) As Course
        Return context.Courses.FirstOrDefault(Function(c) c.CourseID = courseID)
    End Function

    ' This method retrieves an existing Golfer object from the database context for the specified golfer ID.
    Public Shared Function GetExistingGolfer(ByVal context As GolfStatisticsDbContext, ByVal golferID As Integer) As Golfer
        Return context.Golfers.FirstOrDefault(Function(g) g.GolferID = golferID)
    End Function

    ' This method retrieves an existing Round object from the database context for the specified round ID and golfer ID.
    Public Shared Function GetExistingRound(ByVal context As GolfStatisticsDbContext, ByVal roundID As Integer, ByVal golferID As Integer) As Round
        Return context.Rounds.FirstOrDefault(Function(r) r.RoundID = roundID AndAlso r.GolferID = golferID)
    End Function

#End Region

End Class