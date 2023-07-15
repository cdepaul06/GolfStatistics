' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * ModifyCourseForm

Imports System.Data.Entity
Imports System.Text.RegularExpressions
Imports GolfStatistics.FormUtilities

Public Class ModifyCourseForm

#Region "Initialize"

    Private ReadOnly _context As GolfStatisticsDbContext
    Private ReadOnly _newCourseAdded
    Private ReadOnly _includeAddNew = True

    Public Sub New()
        InitializeComponent()

        _context = New GolfStatisticsDbContext()
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles ModifyPanel.Paint
        ' Create a new Pen object with a black color and a thickness of 2 pixels.
        Dim pen As New Pen(Color.Black, 2)

        ' Create a new Rectangle object that covers the entire surface of the ModifyPanel control.
        Dim rect As New Rectangle(0, 0, ModifyPanel.Width, ModifyPanel.Height)

        ' Use the Graphics object provided by the PaintEventArgs parameter to draw the black rectangle on the control's surface.
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

#End Region

#Region "Form Load"
    Private Sub ModifyCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Refresh the combobox on form load
        RefreshCourseComboBox(CourseSelectCbo, _context, _newCourseAdded, _includeAddNew)

    End Sub
#End Region

#Region "Save Changes"
    Private Sub GolferFormBtnSaveChanges_Click(sender As Object, e As EventArgs) Handles CourseFormBtnSaveChanges.Click

        ' Check if all fields are valid. If not, display an error message and return.
        If Not AllFieldsValid() Then
            MessageBox.Show("Please enter all fields. The course location must be 'City, State Abbreviation'. Hole designations must match Course Par", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the currently selected course from the combo box.
        Dim selectedCourse = DirectCast(CourseSelectCbo.SelectedItem, Object)

        ' Get the existing course from the database with the same ID as the selected course.
        Dim existingCourse = GetExistingCourse(_context, selectedCourse.CourseID)

        ' If the selected course is a new course (has an ID of 0), create a new Course object and add it to the database.
        If selectedCourse.CourseID = 0 Then

            Dim newCourse As New Course With {
        .CourseName = TxtCourseName.Text,
        .CourseLocation = TxtCourseLocation.Text,
        .CoursePar = TxtCoursePar.Text,
        .Par3 = TxtPar3.Text,
        .Par4 = TxtPar4.Text,
        .Par5 = TxtPar5.Text
    }

            _context.Courses.Add(newCourse)

            ' If the selected course already exists in the database, update its properties and mark it as modified.
        ElseIf existingCourse.CourseID Then
            existingCourse.CourseName = TxtCourseName.Text
            existingCourse.CourseLocation = TxtCourseLocation.Text
            existingCourse.CoursePar = TxtCoursePar.Text
            existingCourse.Par3 = TxtPar3.Text
            existingCourse.Par4 = TxtPar4.Text
            existingCourse.Par5 = TxtPar5.Text

            _context.Entry(existingCourse).State = EntityState.Modified

        End If

        ' Display a message box to indicate that the course has been saved successfully.
        MessageBox.Show("Course Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Save the changes to the database and refresh the course combo box.
        _context.SaveChanges()
        RefreshCourseComboBox(CourseSelectCbo, _context, _newCourseAdded)

    End Sub

#End Region

#Region "Delete Course"
    Private Sub CourseFormBtnDeleteCourse_Click(sender As Object, e As EventArgs) Handles CourseFormBtnDeleteCourse.Click

        ' Get the currently selected course from the combo box.
        Dim selectedCourse = DirectCast(CourseSelectCbo.SelectedItem, Object)

        ' Check if the selected course is an existing course (i.e., not a new course).
        If selectedCourse.CourseID <> 0 Then

            ' Get the existing course from the database with the same ID as the selected course.
            Dim existingCourse = GetExistingCourse(_context, selectedCourse.CourseID)

            ' Check if the existing course was found in the database.
            If existingCourse IsNot Nothing Then

                ' Display a confirmation message box to ensure the user wants to delete the course.
                Dim result = MessageBox.Show("Are you sure you want to delete the selected course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If the user clicked "Yes" in the confirmation message box, remove the course from the database and reset the form controls.
                If result = DialogResult.Yes Then

                    _context.Courses.Remove(existingCourse)
                    _context.SaveChanges()

                    TxtCourseName.Text = ""
                    TxtCourseLocation.Text = ""
                    TxtCoursePar.Text = ""
                    TxtPar3.Text = ""
                    TxtPar4.Text = ""
                    TxtPar5.Text = ""
                    CourseSelectCbo.SelectedIndex = -1
                    RefreshCourseComboBox(CourseSelectCbo, _context, _newCourseAdded)
                End If
            End If
        End If
    End Sub

#End Region

#Region "CombobBox Events"
    Private Sub CourseSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseSelectCbo.SelectedIndexChanged

        ' Get the currently selected course from the combo box.
        Dim selectedCourse = DirectCast(CourseSelectCbo.SelectedItem, Course)

        ' If no course is selected, return without doing anything.
        If selectedCourse Is Nothing Then
            Return
        End If

        ' Get the existing course from the database with the same ID as the selected course.
        Dim existingCourse = _context.Courses.FirstOrDefault(Function(c) c.CourseID = selectedCourse.CourseID)

        ' If the existing course was found in the database, populate the form controls with its properties.
        If existingCourse IsNot Nothing Then
            TxtCourseName.Text = existingCourse.CourseName
            TxtCourseLocation.Text = existingCourse.CourseLocation
            TxtCoursePar.Text = existingCourse.CoursePar
            TxtPar3.Text = existingCourse.Par3
            TxtPar4.Text = existingCourse.Par4
            TxtPar5.Text = existingCourse.Par5
            ' Otherwise, clear the form controls.
        Else
            TxtCourseName.Text = ""
            TxtCourseLocation.Text = ""
            TxtCoursePar.Text = ""
            TxtPar3.Text = ""
            TxtPar4.Text = ""
            TxtPar5.Text = ""
        End If

        ' Enable or disable the "Delete Course" button based on whether the selected course is a new course.
        If CourseSelectCbo.SelectedIndex <> 0 Then
            CourseFormBtnDeleteCourse.Enabled = True
        Else
            CourseFormBtnDeleteCourse.Enabled = False
        End If

    End Sub



#End Region

#Region "Helper Functions"

    Private Function AllFieldsValid() As Boolean
        ' Define a blank course name to check for empty input.
        Dim blankCourseName As String = ""

        ' Define a pattern to match any digit (\d+) in a string.
        Dim pattern As String = "\d+"

        ' Define a pattern to match a location string in the format "City, State Abbreviation".
        Dim locationPattern As String = "^[A-Za-z]+\s*,\s*[A-Za-z]{2}$"

        ' Check if the course name is empty.
        If (TxtCourseName.Text = blankCourseName) Then
            Return False
        End If

        ' Check if the course location matches the expected pattern.
        If (Not Regex.IsMatch(TxtCourseLocation.Text, locationPattern)) Then
            Return False
        End If

        ' Check if the course par matches the expected pattern.
        If (Not Regex.IsMatch(TxtCoursePar.Text, pattern)) Then
            Return False
        End If

        ' Check if the Par 3 hole designation matches the expected pattern.
        If (Not Regex.IsMatch(TxtPar3.Text, pattern)) Then
            Return False
        End If

        ' Check if the Par 4 hole designation matches the expected pattern.
        If (Not Regex.IsMatch(TxtPar4.Text, pattern)) Then
            Return False
        End If

        ' Check if the Par 5 hole designation matches the expected pattern.
        If (Not Regex.IsMatch(TxtPar5.Text, pattern)) Then
            Return False
        End If

        ' Calculate the total par for the course and check if it matches the Course Par value.
        Dim totalPar As Integer = CInt(TxtPar3.Text) * 3 + CInt(TxtPar4.Text) * 4 + CInt(TxtPar5.Text) * 5
        If (totalPar <> CInt(TxtCoursePar.Text)) Then
            Return False
        End If

        ' If all fields are valid, return True.
        Return True
    End Function


#End Region

#Region "Form Close"
    Private Sub ModifyCourseForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Dispose of the context object when the form is closing.
        _context.Dispose()
    End Sub
#End Region
End Class