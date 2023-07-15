' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * GolfStatisticsForm

Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports GolfStatistics.FormUtilities

Public Class GolfStatisticsForm

#Region "Initialize"
	Private ReadOnly _context As GolfStatisticsDbContext
	Private ReadOnly _newGolferAdded

	' This method handles the Paint event for the GolfStatisticsPanel.
	Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles GolfStatisticsPanel.Paint
		' Create a new Pen object with a black color and a width of 2.
		Dim pen As New Pen(Color.Black, 2)

		' Create a new Rectangle object that represents the size of the GolfStatisticsPanel.
		Dim rect As New Rectangle(0, 0, GolfStatisticsPanel.Width, GolfStatisticsPanel.Height)

		' Use the Graphics object of the PaintEventArgs to draw a rectangle with the pen and rectangle objects.
		e.Graphics.DrawRectangle(pen, rect)
	End Sub

	' This is the constructor for the form.
	Public Sub New()
		InitializeComponent()

		' Create a new GolfStatisticsDbContext and store it in the _context field.
		_context = New GolfStatisticsDbContext()
	End Sub

#End Region

#Region "Form Load Region"
	' This method handles the Load event for the GolfStatisticsForm.
	Private Sub GolfStatisticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Create a new CustomProfessionalRenderer object and set it as the renderer for the MenuStrip1 control.
		Dim renderer As New CustomProfessionalRenderer()
		MenuStrip1.Renderer = renderer

		' Loop through all of the Button controls in the form and add a new ButtonColor control for each one.
		For Each btn As Button In Me.Controls.OfType(Of Button)()
			Dim colorBtn As New ButtonColor()
			Me.Controls.Add(colorBtn)
		Next

		' Call the RefreshGolferComboBox method to populate the GolferSelectCbo ComboBox with golfers from the database context.
		RefreshGolferComboBox(GolferSelectCbo, _context, _newGolferAdded)
	End Sub


#End Region

#Region "Modify Forms Region"
	' This method handles the Click event for the GolferControlModifyBtn button.
	Private Sub GolferControlModifyBtn_Click(sender As Object, e As EventArgs) Handles GolferControlModifyBtn.Click
		' Disable the current form to prevent user interaction while the ModifyGolferForm is open.
		Me.Enabled = False

		' Create a new instance of the ModifyGolferForm and display it to the user.
		Dim modifyGolferForm As New ModifyGolferForm()
		AddHandler modifyGolferForm.FormClosed, AddressOf ModifyGolferForm_FormClosed
		modifyGolferForm.Show()
	End Sub

	' This method is called when the ModifyGolferForm is closed.
	Private Sub ModifyGolferForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		' Re-enable the GolfStatisticsForm when the ModifyGolferForm is closed.
		Me.Enabled = True
	End Sub

	' This method is called when the ModifyRoundsForm is closed.
	Private Sub ModifyRoundsForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		' Re-enable the GolfStatisticsForm when the ModifyRoundsForm is closed.
		Me.Enabled = True
	End Sub

	' This method is called when the ModifyCoursesForm is closed.
	Private Sub ModifyCoursesForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		' Re-enable the GolfStatisticsForm when the ModifyCoursesForm is closed.
		Me.Enabled = True
	End Sub

	' This method handles the Click event for the RoundControlModifyBtn button.
	Private Sub RoundControlModifyBtn_Click(sender As Object, e As EventArgs) Handles RoundControlModifyBtn.Click
		' Disable the current form to prevent user interaction while the ModifyRoundsForm is open.
		Me.Enabled = False

		' Create a new instance of the ModifyRoundsForm and display it to the user.
		Dim modifyRoundForm As New ModifyRoundsForm()
		AddHandler modifyRoundForm.FormClosed, AddressOf ModifyRoundsForm_FormClosed
		modifyRoundForm.Show()
	End Sub

	' This method handles the Click event for the CourseControlModifyBtn button.
	Private Sub CourseControlModifyBtn_Click(sender As Object, e As EventArgs) Handles CourseControlModifyBtn.Click
		' Disable the current form to prevent user interaction while the ModifyCourseForm is open.
		Me.Enabled = False

		' Create a new instance of the ModifyCourseForm and display it to the user.
		Dim courseModifyForm As New ModifyCourseForm()
		AddHandler courseModifyForm.FormClosed, AddressOf ModifyCoursesForm_FormClosed
		courseModifyForm.Show()
	End Sub


#End Region

#Region "Menu Strip Region"
	Private Sub MenuFileExit_Click(sender As Object, e As EventArgs) Handles MenuFileExit.Click
		' Exit the application on user clicking the File > Exit button
		Application.Exit()
	End Sub
#End Region

#Region "Form Closing Region"
	' When the form closes, ensure we are disposing the connection to context (database) and releasing any resources associated with it
	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		' Dispose the context when the form is closing
		_context.Dispose()
	End Sub
#End Region

#Region "Combobox Events"
	Private Sub GolferSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GolferSelectCbo.SelectedIndexChanged
		Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

		If selectedGolfer IsNot Nothing Then
			' Get the AverageScore, Email, and PhoneNumber from the selected golfer
			Dim avgScore = selectedGolfer.AverageScore
			Dim email = selectedGolfer.Email
			Dim phoneNumber = selectedGolfer.PhoneNumber

			' Get the total amount of rounds played for the selected golfer
			Dim totalRounds = _context.Rounds.Count(Function(r) r.GolferID = selectedGolfer.GolferID)

			' Get the latest round played for the selected golfer
			Dim latestRound = _context.Rounds.Where(Function(r) r.GolferID = selectedGolfer.GolferID).OrderByDescending(Function(r) r.DatePlayed).FirstOrDefault()

			' Display the information
			' Use the information as needed, for example:
			LblAvgScore.Text = avgScore.ToString()
			TxtEmail.Text = email
			TxtPhone.Text = phoneNumber
			LblRoundsPlayed.Text = totalRounds.ToString()

			If latestRound IsNot Nothing Then
				' Get the most recent score for the golfer from the Course table
				Dim mostRecentScore = latestRound.Score
				LblLatestScore.Text = mostRecentScore.ToString()

				' Add other details as needed
			Else
				LblLatestScore.Text = "N/A"
				' Clear other details as needed
			End If
		End If
	End Sub
#End Region

#Region "Save File"
	Private Sub MenuFileGenerateGolferFile_Click(sender As Object, e As EventArgs) Handles MenuFileGenerateGolferFile.Click
		Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

		If selectedGolfer IsNot Nothing Then
			' Get the golfer's information
			Dim avgScore = selectedGolfer.AverageScore
			Dim email = selectedGolfer.Email
			Dim phoneNumber = selectedGolfer.PhoneNumber
			Dim totalRounds = _context.Rounds.Count(Function(r) r.GolferID = selectedGolfer.GolferID)

			' Format the information as a string
			Dim golferInfo As String = $"First Name: {selectedGolfer.FirstName}
Last Name: {selectedGolfer.LastName}
Average Score: {avgScore}
Rounds Played: {totalRounds}
Email: {email}
Phone Number: {phoneNumber}"

			' Save the golfer's information to a text file
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Filter = "Text files (*.txt)|*.txt"
			saveFileDialog.Title = "Save Golfer Information"
			saveFileDialog.FileName = $"{selectedGolfer.FirstName}_{selectedGolfer.LastName}_GolferInfo.txt"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				File.WriteAllText(saveFileDialog.FileName, golferInfo)
				MessageBox.Show("Golfer information saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Else
			MessageBox.Show("Please select a golfer from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
#End Region

#Region "Print Functions"
	Private Sub MenuFilePrint_Click(sender As Object, e As EventArgs) Handles MenuFilePrint.Click
		' Get the currently selected golfer
		Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

		If selectedGolfer IsNot Nothing Then
			' Set up the Print Dialog
			Dim printDialog As New PrintDialog()
			printDialog.Document = GolferPrintDocument

			' Display the Print Dialog
			If printDialog.ShowDialog() = DialogResult.OK Then
				' If the user clicks OK, print the document
				GolferPrintDocument.Print()
			End If
		Else
			' If no golfer is selected, display a warning message
			MessageBox.Show("Please select a golfer from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub GolferPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles GolferPrintDocument.PrintPage
		' Get the currently selected golfer
		Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

		If selectedGolfer IsNot Nothing Then
			' Get the golfer's information
			Dim avgScore = selectedGolfer.AverageScore
			Dim email = selectedGolfer.Email
			Dim phoneNumber = selectedGolfer.PhoneNumber
			Dim totalRounds = _context.Rounds.Count(Function(r) r.GolferID = selectedGolfer.GolferID)

			' Format the information as a string
			Dim golferInfo As String = $"First Name: {selectedGolfer.FirstName}
Last Name: {selectedGolfer.LastName}
Average Score: {avgScore}
Rounds Played: {totalRounds}
Email: {email}
Phone Number: {phoneNumber}"

			' Print the golfer's information
			Dim printFont As New Font("Arial", 12)
			e.Graphics.DrawString(golferInfo, printFont, Brushes.Black, New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height))
		End If
	End Sub

#End Region

End Class
