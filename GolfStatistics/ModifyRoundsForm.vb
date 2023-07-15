' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * ModifyRoundsForm

Imports System.Data.Entity
Imports GolfStatistics.FormUtilities

Public Class ModifyRoundsForm

#Region "Initialize"
    ' Defines the GolfStatisticsDbContext object and a Boolean value indicating whether a new round has been added.
    Private ReadOnly _context As GolfStatisticsDbContext
    Private ReadOnly _newRoundAdded

    ' Initializes a new instance of the GolfForm class.
    Public Sub New()
        InitializeComponent()

        ' Instantiates a new GolfStatisticsDbContext object and assigns it to the _context field.
        _context = New GolfStatisticsDbContext()
    End Sub

    ' Draws a border around the ModifyPanel control.
    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles ModifyPanel.Paint
        ' Creates a new Pen object with a black color and a width of 2 pixels.
        Dim pen As New Pen(Color.Black, 2)

        ' Creates a new Rectangle object that is the same size as the ModifyPanel control.
        Dim rect As New Rectangle(0, 0, ModifyPanel.Width, ModifyPanel.Height)

        ' Draws the rectangle border using the Pen object on the Graphics object associated with the control.
        e.Graphics.DrawRectangle(pen, rect)
    End Sub


#End Region

#Region "Form Load"
    ' Handles the Load event of the ModifyRoundsForm form.
    Private Sub ModifyRoundsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Gets the selected Golfer object from the GolferSelectCbo ComboBox.
        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

        ' If a Golfer is selected, gets the existing Golfer object from the database using the selectedGolfer's ID.
        If selectedGolfer IsNot Nothing Then
            Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)
        End If

        ' Refreshes the data in the GolferSelectCbo ComboBox.
        RefreshGolferComboBox(GolferSelectCbo, _context)

        ' Refreshes the data in the CourseSelectCbo ComboBox.
        RefreshCourseComboBox(CourseSelectCbo, _context)

        ' Refreshes the data in the RoundSelectCbo ComboBox for the selected Golfer object.
        RefreshRoundComboBox(RoundSelectCbo, _context, GetType(Golfer), selectedGolfer)

    End Sub

#End Region

#Region "Save Changes"

    Private Sub RoundFormBtnAddRound_Click(sender As Object, e As EventArgs) Handles RoundFormBtnAddRound.Click

        Try
            'Get the selected golfer, round, and course from their respective combo boxes
            Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)
            Dim selectedRound = DirectCast(RoundSelectCbo.SelectedItem, Round)
            Dim selectedCourse = DirectCast(CourseSelectCbo.SelectedItem, Course)

            Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)
            Dim existingRound = GetExistingRound(_context, selectedRound.RoundID, selectedGolfer.GolferID)
            Dim existingCourse = GetExistingCourse(_context, selectedCourse.CourseID)

            'If the selected round is a new round (i.e., has a RoundID of 0), create a new Round object with the selected golfer, course, and round details
            If selectedRound.RoundID = 0 Then
                Dim newRound As New Round With {
        .GolferID = selectedGolfer.GolferID,
        .CourseID = selectedCourse.CourseID,
        .RoundName = DatePlayedDtp.Value.Date.ToString("MM/dd/yyyy") & " " & selectedCourse.CourseName,
        .DatePlayed = DatePlayedDtp.Value.Date,
        .RoundDuration = TxtRoundDuration.Text,
        .Score = TxtRoundScore.Text,
        .HoleInOne = If(HoleInOneCbo.SelectedIndex >= 0, HoleInOneCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Albatross = If(AlbatrossCbo.SelectedIndex >= 0, AlbatrossCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Eagle = If(EagleCbo.SelectedIndex >= 0, EagleCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Birdie = If(BirdieCbo.SelectedIndex >= 0, BirdieCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Par = If(ParCbo.SelectedIndex >= 0, ParCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Bogey = If(BogieCbo.SelectedIndex >= 0, BogieCbo.SelectedIndex, CType(Nothing, Integer?)),
        .DoubleBogey = If(DoubleBogieCbo.SelectedIndex >= 0, DoubleBogieCbo.SelectedIndex, CType(Nothing, Integer?)),
        .TripleBogey = If(TripleBogieCbo.SelectedIndex >= 0, TripleBogieCbo.SelectedIndex, CType(Nothing, Integer?)),
        .TriplePlus = If(TriplePlusCbo.SelectedIndex >= 0, TriplePlusCbo.SelectedIndex, CType(Nothing, Integer?)),
        .UpAndDown = If(UpAndDownCbo.SelectedIndex >= 0, UpAndDownCbo.SelectedIndex, CType(Nothing, Integer?)),
        .HazardsHit = If(HazardCbo.SelectedIndex >= 0, HazardCbo.SelectedIndex, CType(Nothing, Integer?)),
        .OnePutt = If(OnePuttCbo.SelectedIndex >= 0, OnePuttCbo.SelectedIndex, CType(Nothing, Integer?)),
        .ThreePutt = If(ThreePuttCbo.SelectedIndex >= 0, ThreePuttCbo.SelectedIndex, CType(Nothing, Integer?)),
        .HoleOut = If(HoleOutCbo.SelectedIndex >= 0, HoleOutCbo.SelectedIndex, CType(Nothing, Integer?)),
        .Penalties = If(PenaltyCbo.SelectedIndex >= 0, PenaltyCbo.SelectedIndex, CType(Nothing, Integer?))
    }

                ' Save context
                _context.Rounds.Add(newRound)

                ' Update existing round
            ElseIf existingRound IsNot Nothing Then
                existingRound.DatePlayed = DatePlayedDtp.Value
                existingRound.RoundDuration = TxtRoundDuration.Text
                existingRound.Score = TxtRoundScore.Text
                existingRound.HoleInOne = If(HoleInOneCbo.SelectedIndex >= 0, HoleInOneCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Albatross = If(HoleInOneCbo.SelectedIndex >= 0, HoleInOneCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Eagle = If(EagleCbo.SelectedIndex >= 0, EagleCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Birdie = If(BirdieCbo.SelectedIndex >= 0, BirdieCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Par = If(ParCbo.SelectedIndex >= 0, ParCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Bogey = If(BogieCbo.SelectedIndex >= 0, BogieCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.DoubleBogey = If(DoubleBogieCbo.SelectedIndex >= 0, DoubleBogieCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.TripleBogey = If(TripleBogieCbo.SelectedIndex >= 0, TripleBogieCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.TriplePlus = If(TriplePlusCbo.SelectedIndex >= 0, TriplePlusCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.UpAndDown = If(UpAndDownCbo.SelectedIndex >= 0, UpAndDownCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.HazardsHit = If(HazardCbo.SelectedIndex >= 0, HazardCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.OnePutt = If(OnePuttCbo.SelectedIndex >= 0, OnePuttCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.ThreePutt = If(ThreePuttCbo.SelectedIndex >= 0, ThreePuttCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.HoleOut = If(HoleOutCbo.SelectedIndex >= 0, HoleOutCbo.SelectedIndex, CType(Nothing, Integer?))
                existingRound.Penalties = If(PenaltyCbo.SelectedIndex >= 0, PenaltyCbo.SelectedIndex, CType(Nothing, Integer?))

                ' Save context entry
                _context.Entry(existingRound).State = EntityState.Modified

            End If

            ' Save all changes to context
            _context.SaveChanges()

            'Update Golfer's average score
            If existingGolfer.AverageScore Is Nothing Then
                existingGolfer.AverageScore = selectedRound.Score
            Else
                ' Retrieve all the golfer's rounds
                Dim rounds As List(Of Round) = _context.Rounds.Where(Function(r) r.GolferID = existingGolfer.GolferID).ToList()

                ' Calculate the new average score
                Dim totalScore As Integer = rounds.Sum(Function(r) r.Score)
                Dim numberOfRounds As Integer = rounds.Count
                existingGolfer.AverageScore = totalScore / numberOfRounds
            End If

            ' Update the golfer's average score in the database
            _context.Entry(existingGolfer).State = EntityState.Modified
            _context.SaveChanges()

            MessageBox.Show("Round Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshGolferComboBox(GolferSelectCbo, _context)
            RefreshCourseComboBox(CourseSelectCbo, _context)
            RefreshRoundComboBox(RoundSelectCbo, _context, GetType(Golfer), selectedGolfer, _newRoundAdded)

        Catch ex As Exception
            MessageBox.Show("Error Saving Round: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Combobox Events"
    Private Sub GolferSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GolferSelectCbo.SelectedIndexChanged

        ' Get the currently selected golfer from the dropdown
        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

        ' Get the existing golfer from the database
        Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)

        ' If a golfer is selected in the dropdown, refresh the round selection dropdown
        If selectedGolfer IsNot Nothing Then
            RefreshRoundComboBox(RoundSelectCbo, _context, GetType(Golfer), selectedGolfer)
        End If


    End Sub

    Private Sub CourseSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseSelectCbo.SelectedIndexChanged
        ' Get the currently selected course from the dropdown
        Dim selectedCourse = DirectCast(CourseSelectCbo.SelectedItem, Course)

        ' If a course is selected in the dropdown, populate the course information fields
        If selectedCourse IsNot Nothing Then
            TxtCourseName.Text = selectedCourse.CourseName
            TxtCourseLocation.Text = selectedCourse.CourseLocation
            TxtCoursePar.Text = selectedCourse.CoursePar.ToString()
        End If

    End Sub
#End Region

#Region "Form Close"
    Private Sub ModifyRoundsForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        _context.Dispose()
    End Sub

    Private Sub RoundSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoundSelectCbo.SelectedIndexChanged
        Dim selectedRound = DirectCast(RoundSelectCbo.SelectedItem, Round)
        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

        If selectedRound IsNot Nothing AndAlso selectedGolfer IsNot Nothing Then

            Dim existingRound = GetExistingRound(_context, selectedRound.RoundID, selectedGolfer.GolferID)

            If existingRound IsNot Nothing Then
                DatePlayedDtp.Value = existingRound.DatePlayed
                TxtRoundDuration.Text = existingRound.RoundDuration
                TxtRoundScore.Text = existingRound.Score
                If existingRound.HoleInOne.HasValue Then HoleInOneCbo.SelectedIndex = existingRound.HoleInOne.Value
                If existingRound.Albatross.HasValue Then AlbatrossCbo.SelectedIndex = existingRound.Albatross.Value
                If existingRound.Eagle.HasValue Then EagleCbo.SelectedIndex = existingRound.Eagle.Value
                If existingRound.Birdie.HasValue Then BirdieCbo.SelectedIndex = existingRound.Birdie.Value
                If existingRound.Par.HasValue Then ParCbo.SelectedIndex = existingRound.Par.Value
                If existingRound.HoleOut.HasValue Then HoleOutCbo.SelectedIndex = existingRound.HoleOut.Value
                If existingRound.Bogey.HasValue Then BogieCbo.SelectedIndex = existingRound.Bogey.Value
                If existingRound.DoubleBogey.HasValue Then DoubleBogieCbo.SelectedIndex = existingRound.DoubleBogey.Value
                If existingRound.TripleBogey.HasValue Then TripleBogieCbo.SelectedIndex = existingRound.TripleBogey.Value
                If existingRound.TriplePlus.HasValue Then TriplePlusCbo.SelectedIndex = existingRound.TriplePlus.Value
                If existingRound.UpAndDown.HasValue Then UpAndDownCbo.SelectedIndex = existingRound.UpAndDown.Value
                If existingRound.HazardsHit.HasValue Then HazardCbo.SelectedIndex = existingRound.HazardsHit.Value
                If existingRound.OnePutt.HasValue Then OnePuttCbo.SelectedIndex = existingRound.OnePutt.Value
                If existingRound.ThreePutt.HasValue Then ThreePuttCbo.SelectedIndex = existingRound.ThreePutt.Value
                If existingRound.Penalties.HasValue Then PenaltyCbo.SelectedIndex = existingRound.Penalties.Value
            Else
                DatePlayedDtp.Value = Date.Today
                TxtRoundDuration.Text = ""
                TxtRoundScore.Text = ""
                HoleInOneCbo.SelectedIndex = -1
                AlbatrossCbo.SelectedIndex = -1
                EagleCbo.SelectedIndex = -1
                BirdieCbo.SelectedIndex = -1
                ParCbo.SelectedIndex = -1
                HoleOutCbo.SelectedIndex = -1
                BogieCbo.SelectedIndex = -1
                DoubleBogieCbo.SelectedIndex = -1
                TripleBogieCbo.SelectedIndex = -1
                TriplePlusCbo.SelectedIndex = -1
                UpAndDownCbo.SelectedIndex = -1
                HazardCbo.SelectedIndex = -1
                OnePuttCbo.SelectedIndex = -1
                ThreePuttCbo.SelectedIndex = -1
                PenaltyCbo.SelectedIndex = -1
            End If
        End If
    End Sub

#End Region

End Class