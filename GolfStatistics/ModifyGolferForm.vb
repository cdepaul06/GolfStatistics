' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * ModifyGolferForm

Imports System.Data.Entity
Imports System.Text.RegularExpressions
Imports GolfStatistics.FormUtilities

Public Class ModifyGolferForm

#Region "Initialize"
    ' a private field to store the database context
    Private ReadOnly _context As GolfStatisticsDbContext
    ' a private field to store if a new golfer was added
    Private ReadOnly _newGolferAdded
    ' a private field to determine if an "Add New" option should be included in the combobox
    Private ReadOnly _includeAddNew As Boolean = True

    Public Sub New()
        InitializeComponent()
        ' create a new instance of the database context
        _context = New GolfStatisticsDbContext()
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles ModifyPanel.Paint
        ' event handler to draw a border around the panel
        ' create a black pen with a width of 2 pixels
        Dim pen As New Pen(Color.Black, 2)
        ' create a rectangle that covers the entire panel
        Dim rect As New Rectangle(0, 0, ModifyPanel.Width, ModifyPanel.Height)
        ' draw the rectangle using the pen
        e.Graphics.DrawRectangle(pen, rect)
    End Sub

#End Region

#Region "Form Load"
    Private Sub ModifyGolferForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' event handler to load the form
        RefreshGolferComboBox(GolferSelectCbo, _context, _newGolferAdded, _includeAddNew) ' refresh the golfer combobox with data from the database
    End Sub
#End Region


#Region "Save Changes"
    Private Sub GolferFormBtnSaveChanges_Click(sender As Object, e As EventArgs) Handles GolferFormBtnSaveChanges.Click

        ' Check if all fields in the form are valid
        If Not AllFieldsValid() Then
            MessageBox.Show("Please enter valid values for all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Get the selected golfer from the combo box
            Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

            ' Get the existing golfer entity from the database using the selected golfer ID
            Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)

            ' If the selected golfer is a new golfer (ID is 0), create a new golfer entity and add it to the database
            If selectedGolfer.GolferID = 0 Then

                ' Create a new golfer entity with the form data
                Dim newGolfer As New Golfer With {
            .FirstName = TxtFirstName.Text,
            .LastName = TxtLastName.Text,
            .Email = TxtEmail.Text,
            .PhoneNumber = TxtPhone.Text
        }
                ' Add the new golfer entity to the database context
                _context.Golfers.Add(newGolfer)

                ' Create a new bag entity with the form data, and set its GolferID to the ID of the new golfer
                Dim newBag As New Bag With {
            .GolferID = newGolfer.GolferID,
            .BagBrand = TxtBagBrand.Text,
            .CartBag = ChkCartBag.Checked,
            .Cooler = ChkCooler.Checked,
            .IndividualClubSlots = ChkBagSlots.Checked,
            .SingleStrap = ChkStrap.Checked
        }
                ' Add the new bag entity to the database context
                _context.Bags.Add(newBag)

                ' Create a new ball entity with the form data, and set its BagID to the ID of the new bag
                Dim newBall As New Ball With {
            .BagID = newBag.BagID,
            .Brand = TxtBallBrand.Text,
            .Model = TxtBallModel.Text
        }
                ' Add the new ball entity to the database context
                _context.Balls.Add(newBall)

                ' Declare variables to be used in rest of logic
                Dim clubDistance As Integer?
                Dim tempClubDistance As Integer

                ' If the club distance can be parsed to text, set it to temp variable else do not
                If Integer.TryParse(TxtClubDistance.Text, tempClubDistance) Then
                    clubDistance = tempClubDistance
                Else
                    clubDistance = Nothing
                End If

                ' Delcare a new club object
                Dim newClub As New Club With {
                .BagID = newBag.BagID,
                .Brand = TxtClubBrand.Text,
                .Type = CStr(CboClubType.SelectedItem),
                .Model = TxtClubModel.Text,
                .Distance = clubDistance
            }
                _context.Clubs.Add(newClub)

            Else
                ' If there is an existing bag and ball
                Dim existingBag = GetExistingBag(_context, selectedGolfer.GolferID)
                Dim existingBall = GetExistingBall(_context, existingBag.BagID)

                ' And if there is an existing golfer set all the fields
                If existingGolfer IsNot Nothing Then
                    existingGolfer.FirstName = TxtFirstName.Text
                    existingGolfer.LastName = TxtLastName.Text
                    existingGolfer.Email = TxtEmail.Text
                    existingGolfer.PhoneNumber = TxtPhone.Text

                    existingBag.BagBrand = TxtBagBrand.Text
                    existingBag.CartBag = ChkCartBag.Checked
                    existingBag.Cooler = ChkCooler.Checked
                    existingBag.IndividualClubSlots = ChkBagSlots.Checked
                    existingBag.SingleStrap = ChkStrap.Checked

                    existingBall.Brand = TxtBallBrand.Text
                    existingBall.Model = TxtBallModel.Text
                    existingBall.SuperSoft = ChkSuperSoft.Checked

                    ' Save context changes
                    _context.Entry(existingGolfer).State = EntityState.Modified
                    _context.Entry(existingBag).State = EntityState.Modified
                    _context.Entry(existingBall).State = EntityState.Modified

                End If
                ' Check to see if there is an existing club for a golfer
                Dim existingClub = existingBag.Clubs?.FirstOrDefault(Function(c) c.Type = CStr(CboClubType.SelectedItem))

                ' If the user is not editing a club, do nothing, else save changes
                If Not String.IsNullOrEmpty(TxtClubBrand.Text) AndAlso
                Not String.IsNullOrEmpty(CStr(CboClubType.SelectedItem)) AndAlso
                Not String.IsNullOrEmpty(TxtClubModel.Text) AndAlso
                Not String.IsNullOrEmpty(TxtClubDistance.Text) Then

                    If existingClub Is Nothing Then
                        Dim newClub As New Club With {
                        .BagID = existingBag.BagID,
                        .Brand = TxtClubBrand.Text,
                        .Type = CStr(CboClubType.SelectedItem),
                        .Model = TxtClubModel.Text,
                        .Distance = TxtClubDistance.Text
                    }
                        _context.Clubs.Add(newClub)
                    Else
                        existingClub.Brand = TxtClubBrand.Text
                        existingClub.Type = CStr(CboClubType.SelectedItem)
                        existingClub.Model = TxtClubModel.Text
                        existingClub.Distance = TxtClubDistance.Text

                        _context.Entry(existingClub).State = EntityState.Modified
                    End If
                End If
            End If

            ' Save all changes to context
            _context.SaveChanges()
            MessageBox.Show("Golfer Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error Saving Golfer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Refresh combobox
        RefreshGolferComboBox(GolferSelectCbo, _context, _newGolferAdded, _includeAddNew)

    End Sub


#End Region

#Region "Delete Golfer"

    ' Handles the Click event of the "Delete Golfer" button.
    Private Sub GolferFormBtnDeleteGolfer_Click(sender As Object, e As EventArgs) Handles GolferFormBtnDeleteGolfer.Click

        ' Retrieves the currently selected Golfer object from the GolferSelectCbo ComboBox.
        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Object)

        ' If the selected Golfer's ID is not 0 (i.e., it exists in the database), retrieves the existing Golfer record 
        ' from the database using the GetExistingGolfer method.
        If selectedGolfer.GolferID <> 0 Then
            Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)

            ' If the existing Golfer record was found in the database, prompts the user with a confirmation dialog 
            ' to confirm the deletion.
            If existingGolfer IsNot Nothing Then
                Dim result = MessageBox.Show("Are you sure you want to delete the selected golfer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If the user clicks the "Yes" button in the confirmation dialog, removes the existing Golfer record 
                ' from the _context.Golfers DbSet and saves the changes to the database.
                ' Also clears the input fields, resets the selected index of the GolferSelectCbo ComboBox, and 
                ' refreshes the contents of the GolferSelectCbo ComboBox.
                If result = DialogResult.Yes Then
                    _context.Golfers.Remove(existingGolfer)
                    _context.SaveChanges()

                    TxtFirstName.Text = ""
                    TxtLastName.Text = ""
                    TxtEmail.Text = ""
                    TxtPhone.Text = ""
                    TxtEmail.Text = ""

                    GolferSelectCbo.SelectedIndex = -1

                    RefreshGolferComboBox(GolferSelectCbo, _context, _newGolferAdded)
                End If
            End If
        End If
    End Sub

#End Region


#Region "Validation"
    ' Handles the TextChanged event of the TxtEmail TextBox.
    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

        ' If the TxtEmail TextBox is empty, disables the EmailTimer and returns.
        If TxtEmail.Text = "" Then
            EmailTimer.Enabled = False
            Return
        End If

        ' Disables the EmailTimer to ensure that it is only started once per user input.
        EmailTimer.Enabled = False

        ' Enables the EmailTimer, which will fire the EmailTimer_Tick event after a set amount of time.
        EmailTimer.Enabled = True

    End Sub

    ' Handles the Tick event of the EmailTimer Timer.
    Private Sub EmailTimer_Tick(sender As Object, e As EventArgs) Handles EmailTimer.Tick

        ' Disables the EmailTimer to ensure that it is only started once per user input.
        EmailTimer.Enabled = False

        ' Defines a regular expression pattern for validating email addresses.
        Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

        ' If the text in the TxtEmail TextBox matches the emailPattern regular expression pattern, sets the background 
        ' color of the TxtEmail TextBox to white and the foreground color to black.
        ' Otherwise, sets the background color of the TxtEmail TextBox to red and the foreground color to white, 
        ' displays an error message box, and prompts the user to enter a valid email address.
        If Regex.IsMatch(TxtEmail.Text, emailPattern) Then
            TxtEmail.BackColor = Color.White
            TxtEmail.ForeColor = Color.Black
        Else
            TxtEmail.BackColor = Color.Red
            TxtEmail.ForeColor = Color.White
            MessageBox.Show("Invalid email address. Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handles the TextChanged event of the TxtPhone TextBox.
    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged

        ' If the TxtPhone TextBox is empty, disables the PhoneTimer and returns.
        If TxtPhone.Text = "" Then
            PhoneTimer.Enabled = False
            Return
        End If

        ' Disables the PhoneTimer to ensure that it is only started once per user input.
        PhoneTimer.Enabled = False

        ' Enables the PhoneTimer, which will fire the PhoneTimer_Tick event after a set amount of time.
        PhoneTimer.Enabled = True
    End Sub

    ' Handles the Tick event of the PhoneTimer Timer.
    Private Sub PhoneTimer_Tick(sender As Object, e As EventArgs) Handles PhoneTimer.Tick

        ' Disables the PhoneTimer to ensure that it is only started once per user input.
        PhoneTimer.Enabled = False

        ' Defines a regular expression pattern for validating phone numbers.
        Dim phonePattern As String = "^\(\d{3}\) \d{3}-\d{4}$"

        ' If the text in the TxtPhone TextBox matches the phonePattern regular expression pattern, sets the background 
        ' color of the TxtPhone TextBox to white and the foreground color to black.
        ' Otherwise, sets the background color of the TxtPhone TextBox to red and the foreground color to white, 
        ' displays an error message box, and prompts the user to enter a phone number in the correct format.
        If Regex.IsMatch(TxtPhone.Text, phonePattern) Then
            TxtPhone.BackColor = Color.White
            TxtPhone.ForeColor = Color.Black
        Else
            TxtPhone.BackColor = Color.Red
            TxtPhone.ForeColor = Color.White
            MessageBox.Show("Invalid phone number. Phone Number must in the proper format (XXX) XXX-XXXX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


#End Region

#Region "ComboBox Events"
    Private Sub GolferSelectCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GolferSelectCbo.SelectedIndexChanged

        ' Retrieves the currently selected Golfer object from the GolferSelectCbo ComboBox.
        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

        ' If the selectedGolfer object is null, returns.
        If selectedGolfer Is Nothing Then
            Return
        End If

        ' If the selectedGolfer object is not null, retrieves the existing Golfer, Bag, and Ball records from the database 
        ' using the GetExistingGolfer, GetExistingBag, and GetExistingBall methods, respectively.
        Dim existingGolfer = GetExistingGolfer(_context, selectedGolfer.GolferID)
        Dim existingBag = GetExistingBag(_context, selectedGolfer.GolferID)
        Dim existingBall As Ball = Nothing
        If existingBag IsNot Nothing Then
            existingBall = GetExistingBall(_context, existingBag.BagID)
        End If

        ' Sets the text of the input fields on the form to the corresponding values retrieved from the database.
        TxtFirstName.Text = existingGolfer?.FirstName
        TxtLastName.Text = existingGolfer?.LastName
        TxtEmail.Text = existingGolfer?.Email
        TxtPhone.Text = existingGolfer?.PhoneNumber

        TxtBagBrand.Text = existingBag?.BagBrand
        ChkCartBag.Checked = If(existingBag?.CartBag.HasValue, existingBag.CartBag.Value, False)
        ChkCooler.Checked = If(existingBag?.Cooler.HasValue, existingBag.Cooler.Value, False)
        ChkBagSlots.Checked = If(existingBag?.IndividualClubSlots.HasValue, existingBag.IndividualClubSlots.Value, False)
        ChkStrap.Checked = If(existingBag?.SingleStrap.HasValue, existingBag.SingleStrap.Value, False)

        TxtBallBrand.Text = existingBall?.Brand
        TxtBallModel.Text = existingBall?.Model
        ChkSuperSoft.Checked = If(existingBall?.SuperSoft.HasValue, existingBall.SuperSoft, False)

        ' If the selectedGolfer object is null, sets the text of the input fields on the form to empty strings 
        ' and clears the checked state of the CheckBox controls.
        ' Also clears the input fields for the new Club object.
        If selectedGolfer Is Nothing Then
            TxtFirstName.Text = ""
            TxtLastName.Text = ""
            TxtEmail.Text = ""
            TxtPhone.Text = ""

            TxtBagBrand.Text = ""
            ChkCartBag.Checked = False
            ChkCooler.Checked = False
            ChkBagSlots.Checked = False
            ChkStrap.Checked = False

            TxtBallBrand.Text = ""
            TxtBallModel.Text = ""
            ChkSuperSoft.Checked = False

            CboClubType.SelectedIndex = -1
            TxtClubBrand.Text = ""
            TxtClubModel.Text = ""
            TxtClubDistance.Text = ""

        End If

        ' If the selected index of the GolferSelectCbo ComboBox is not 0 (i.e., a Golfer is selected), enables the 
        ' "Delete Golfer" button. Otherwise, disables the button.
        If GolferSelectCbo.SelectedIndex <> 0 Then
            GolferFormBtnDeleteGolfer.Enabled = True
        Else
            GolferFormBtnDeleteGolfer.Enabled = False
        End If


    End Sub

    Private Sub CboClubType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboClubType.SelectedIndexChanged

        Dim selectedGolfer = DirectCast(GolferSelectCbo.SelectedItem, Golfer)

        If selectedGolfer IsNot Nothing Then

            Dim selectedGolferClub = GetExistingGolfer(_context, selectedGolfer.GolferID) ' Get the selected golfer from your UI

            Dim selectedClubType = CStr(CboClubType.SelectedItem) ' Get the selected club type from the ComboBox

            Dim existingClub = GetExistingClub(_context, selectedGolfer.GolferID, selectedClubType)

            If existingClub IsNot Nothing Then
                ' Populate UI controls with existing club information
                TxtClubBrand.Text = existingClub.Brand
                CboClubType.SelectedItem = existingClub.Type
                TxtClubModel.Text = existingClub.Model
                TxtClubDistance.Text = existingClub.Distance.ToString()
            Else
                TxtClubBrand.Text = ""
                TxtClubModel.Text = ""
                TxtClubDistance.Text = ""

            End If

        End If

    End Sub


#End Region

#Region "Helper Functions"

    ' Validates all input fields on the form and returns a Boolean value indicating whether they are all valid.
    Private Function AllFieldsValid() As Boolean

        ' Defines regular expression patterns for validating email addresses and phone numbers, and a blank string.
        Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Dim phonePattern As String = "^\(\d{3}\) \d{3}-\d{4}$"
        Dim blankField As String = ""

        ' If the TxtFirstName TextBox is blank, returns false.
        If (TxtFirstName.Text = blankField) Then
            Return False
        End If

        ' If the TxtLastName TextBox is blank, returns false.
        If (TxtLastName.Text = blankField) Then
            Return False
        End If

        ' If the text in the TxtEmail TextBox does not match the emailPattern regular expression pattern, returns false.
        If Not Regex.IsMatch(TxtEmail.Text, emailPattern) Then
            Return False
        End If

        ' If the text in the TxtPhone TextBox does not match the phonePattern regular expression pattern, returns false.
        If Not Regex.IsMatch(TxtPhone.Text, phonePattern) Then
            Return False
        End If

        ' If the TxtBagBrand TextBox is blank, returns false.
        If (TxtBagBrand.Text = blankField) Then
            Return False
        End If

        ' If the TxtBallBrand TextBox is blank, returns false.
        If (TxtBallBrand.Text = blankField) Then
            Return False
        End If

        ' If the TxtBallModel TextBox is blank, returns false.
        If (TxtBallModel.Text = blankField) Then
            Return False
        End If

        ' Otherwise, returns true to indicate that all input fields are valid.
        Return True
    End Function

#End Region

#Region "Form Close"
    Private Sub ModifyGolferForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        _context.Dispose()
    End Sub
#End Region

End Class
