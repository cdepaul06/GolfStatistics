<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyRoundsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyRoundsForm))
        Me.ModifyPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PenaltyCbo = New System.Windows.Forms.ComboBox()
        Me.ThreePuttCbo = New System.Windows.Forms.ComboBox()
        Me.OnePuttCbo = New System.Windows.Forms.ComboBox()
        Me.HazardCbo = New System.Windows.Forms.ComboBox()
        Me.UpAndDownCbo = New System.Windows.Forms.ComboBox()
        Me.TriplePlusCbo = New System.Windows.Forms.ComboBox()
        Me.TripleBogieCbo = New System.Windows.Forms.ComboBox()
        Me.DoubleBogieCbo = New System.Windows.Forms.ComboBox()
        Me.BogieCbo = New System.Windows.Forms.ComboBox()
        Me.HoleOutCbo = New System.Windows.Forms.ComboBox()
        Me.ParCbo = New System.Windows.Forms.ComboBox()
        Me.BirdieCbo = New System.Windows.Forms.ComboBox()
        Me.EagleCbo = New System.Windows.Forms.ComboBox()
        Me.AlbatrossCbo = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DatePlayedDtp = New System.Windows.Forms.DateTimePicker()
        Me.TxtRoundDuration = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtRoundScore = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.HoleInOneCbo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCoursePar = New System.Windows.Forms.TextBox()
        Me.TxtCourseLocation = New System.Windows.Forms.TextBox()
        Me.TxtCourseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GolferSelectCbo = New System.Windows.Forms.ComboBox()
        Me.RoundFormBtnDeleteRound = New System.Windows.Forms.Button()
        Me.RoundFormBtnAddRound = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoundSelectCbo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CourseSelectCbo = New System.Windows.Forms.ComboBox()
        Me.ModifyPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModifyPanel
        '
        Me.ModifyPanel.BackColor = System.Drawing.Color.DarkGreen
        Me.ModifyPanel.Controls.Add(Me.GroupBox1)
        Me.ModifyPanel.Controls.Add(Me.Label5)
        Me.ModifyPanel.Controls.Add(Me.Label4)
        Me.ModifyPanel.Controls.Add(Me.Label3)
        Me.ModifyPanel.Controls.Add(Me.TxtCoursePar)
        Me.ModifyPanel.Controls.Add(Me.TxtCourseLocation)
        Me.ModifyPanel.Controls.Add(Me.TxtCourseName)
        Me.ModifyPanel.Location = New System.Drawing.Point(232, 52)
        Me.ModifyPanel.Name = "ModifyPanel"
        Me.ModifyPanel.Size = New System.Drawing.Size(689, 620)
        Me.ModifyPanel.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PenaltyCbo)
        Me.GroupBox1.Controls.Add(Me.ThreePuttCbo)
        Me.GroupBox1.Controls.Add(Me.OnePuttCbo)
        Me.GroupBox1.Controls.Add(Me.HazardCbo)
        Me.GroupBox1.Controls.Add(Me.UpAndDownCbo)
        Me.GroupBox1.Controls.Add(Me.TriplePlusCbo)
        Me.GroupBox1.Controls.Add(Me.TripleBogieCbo)
        Me.GroupBox1.Controls.Add(Me.DoubleBogieCbo)
        Me.GroupBox1.Controls.Add(Me.BogieCbo)
        Me.GroupBox1.Controls.Add(Me.HoleOutCbo)
        Me.GroupBox1.Controls.Add(Me.ParCbo)
        Me.GroupBox1.Controls.Add(Me.BirdieCbo)
        Me.GroupBox1.Controls.Add(Me.EagleCbo)
        Me.GroupBox1.Controls.Add(Me.AlbatrossCbo)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.DatePlayedDtp)
        Me.GroupBox1.Controls.Add(Me.TxtRoundDuration)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TxtRoundScore)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.HoleInOneCbo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 469)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Round Statistics"
        '
        'PenaltyCbo
        '
        Me.PenaltyCbo.BackColor = System.Drawing.Color.White
        Me.PenaltyCbo.DropDownHeight = 50
        Me.PenaltyCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PenaltyCbo.FormattingEnabled = True
        Me.PenaltyCbo.IntegralHeight = False
        Me.PenaltyCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.PenaltyCbo.Location = New System.Drawing.Point(352, 407)
        Me.PenaltyCbo.Name = "PenaltyCbo"
        Me.PenaltyCbo.Size = New System.Drawing.Size(227, 23)
        Me.PenaltyCbo.TabIndex = 58
        '
        'ThreePuttCbo
        '
        Me.ThreePuttCbo.BackColor = System.Drawing.Color.White
        Me.ThreePuttCbo.DropDownHeight = 50
        Me.ThreePuttCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThreePuttCbo.FormattingEnabled = True
        Me.ThreePuttCbo.IntegralHeight = False
        Me.ThreePuttCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.ThreePuttCbo.Location = New System.Drawing.Point(352, 363)
        Me.ThreePuttCbo.Name = "ThreePuttCbo"
        Me.ThreePuttCbo.Size = New System.Drawing.Size(227, 23)
        Me.ThreePuttCbo.TabIndex = 57
        '
        'OnePuttCbo
        '
        Me.OnePuttCbo.BackColor = System.Drawing.Color.White
        Me.OnePuttCbo.DropDownHeight = 50
        Me.OnePuttCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnePuttCbo.FormattingEnabled = True
        Me.OnePuttCbo.IntegralHeight = False
        Me.OnePuttCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.OnePuttCbo.Location = New System.Drawing.Point(352, 319)
        Me.OnePuttCbo.Name = "OnePuttCbo"
        Me.OnePuttCbo.Size = New System.Drawing.Size(227, 23)
        Me.OnePuttCbo.TabIndex = 56
        '
        'HazardCbo
        '
        Me.HazardCbo.BackColor = System.Drawing.Color.White
        Me.HazardCbo.DropDownHeight = 50
        Me.HazardCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HazardCbo.FormattingEnabled = True
        Me.HazardCbo.IntegralHeight = False
        Me.HazardCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.HazardCbo.Location = New System.Drawing.Point(352, 275)
        Me.HazardCbo.Name = "HazardCbo"
        Me.HazardCbo.Size = New System.Drawing.Size(227, 23)
        Me.HazardCbo.TabIndex = 55
        '
        'UpAndDownCbo
        '
        Me.UpAndDownCbo.BackColor = System.Drawing.Color.White
        Me.UpAndDownCbo.DropDownHeight = 50
        Me.UpAndDownCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UpAndDownCbo.FormattingEnabled = True
        Me.UpAndDownCbo.IntegralHeight = False
        Me.UpAndDownCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.UpAndDownCbo.Location = New System.Drawing.Point(352, 233)
        Me.UpAndDownCbo.Name = "UpAndDownCbo"
        Me.UpAndDownCbo.Size = New System.Drawing.Size(227, 23)
        Me.UpAndDownCbo.TabIndex = 54
        '
        'TriplePlusCbo
        '
        Me.TriplePlusCbo.BackColor = System.Drawing.Color.White
        Me.TriplePlusCbo.DropDownHeight = 50
        Me.TriplePlusCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TriplePlusCbo.FormattingEnabled = True
        Me.TriplePlusCbo.IntegralHeight = False
        Me.TriplePlusCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.TriplePlusCbo.Location = New System.Drawing.Point(352, 189)
        Me.TriplePlusCbo.Name = "TriplePlusCbo"
        Me.TriplePlusCbo.Size = New System.Drawing.Size(227, 23)
        Me.TriplePlusCbo.TabIndex = 53
        '
        'TripleBogieCbo
        '
        Me.TripleBogieCbo.BackColor = System.Drawing.Color.White
        Me.TripleBogieCbo.DropDownHeight = 50
        Me.TripleBogieCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TripleBogieCbo.FormattingEnabled = True
        Me.TripleBogieCbo.IntegralHeight = False
        Me.TripleBogieCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.TripleBogieCbo.Location = New System.Drawing.Point(352, 145)
        Me.TripleBogieCbo.Name = "TripleBogieCbo"
        Me.TripleBogieCbo.Size = New System.Drawing.Size(227, 23)
        Me.TripleBogieCbo.TabIndex = 52
        '
        'DoubleBogieCbo
        '
        Me.DoubleBogieCbo.BackColor = System.Drawing.Color.White
        Me.DoubleBogieCbo.DropDownHeight = 50
        Me.DoubleBogieCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DoubleBogieCbo.FormattingEnabled = True
        Me.DoubleBogieCbo.IntegralHeight = False
        Me.DoubleBogieCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.DoubleBogieCbo.Location = New System.Drawing.Point(352, 101)
        Me.DoubleBogieCbo.Name = "DoubleBogieCbo"
        Me.DoubleBogieCbo.Size = New System.Drawing.Size(227, 23)
        Me.DoubleBogieCbo.TabIndex = 51
        '
        'BogieCbo
        '
        Me.BogieCbo.BackColor = System.Drawing.Color.White
        Me.BogieCbo.DropDownHeight = 50
        Me.BogieCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BogieCbo.FormattingEnabled = True
        Me.BogieCbo.IntegralHeight = False
        Me.BogieCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.BogieCbo.Location = New System.Drawing.Point(352, 57)
        Me.BogieCbo.Name = "BogieCbo"
        Me.BogieCbo.Size = New System.Drawing.Size(227, 23)
        Me.BogieCbo.TabIndex = 50
        '
        'HoleOutCbo
        '
        Me.HoleOutCbo.BackColor = System.Drawing.Color.White
        Me.HoleOutCbo.DropDownHeight = 50
        Me.HoleOutCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoleOutCbo.FormattingEnabled = True
        Me.HoleOutCbo.IntegralHeight = False
        Me.HoleOutCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.HoleOutCbo.Location = New System.Drawing.Point(54, 407)
        Me.HoleOutCbo.Name = "HoleOutCbo"
        Me.HoleOutCbo.Size = New System.Drawing.Size(227, 23)
        Me.HoleOutCbo.TabIndex = 49
        '
        'ParCbo
        '
        Me.ParCbo.BackColor = System.Drawing.Color.White
        Me.ParCbo.DropDownHeight = 50
        Me.ParCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParCbo.FormattingEnabled = True
        Me.ParCbo.IntegralHeight = False
        Me.ParCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.ParCbo.Location = New System.Drawing.Point(54, 363)
        Me.ParCbo.Name = "ParCbo"
        Me.ParCbo.Size = New System.Drawing.Size(227, 23)
        Me.ParCbo.TabIndex = 48
        '
        'BirdieCbo
        '
        Me.BirdieCbo.BackColor = System.Drawing.Color.White
        Me.BirdieCbo.DropDownHeight = 50
        Me.BirdieCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BirdieCbo.FormattingEnabled = True
        Me.BirdieCbo.IntegralHeight = False
        Me.BirdieCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.BirdieCbo.Location = New System.Drawing.Point(54, 319)
        Me.BirdieCbo.Name = "BirdieCbo"
        Me.BirdieCbo.Size = New System.Drawing.Size(227, 23)
        Me.BirdieCbo.TabIndex = 47
        '
        'EagleCbo
        '
        Me.EagleCbo.BackColor = System.Drawing.Color.White
        Me.EagleCbo.DropDownHeight = 50
        Me.EagleCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EagleCbo.FormattingEnabled = True
        Me.EagleCbo.IntegralHeight = False
        Me.EagleCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.EagleCbo.Location = New System.Drawing.Point(54, 275)
        Me.EagleCbo.Name = "EagleCbo"
        Me.EagleCbo.Size = New System.Drawing.Size(227, 23)
        Me.EagleCbo.TabIndex = 46
        '
        'AlbatrossCbo
        '
        Me.AlbatrossCbo.BackColor = System.Drawing.Color.White
        Me.AlbatrossCbo.DropDownHeight = 50
        Me.AlbatrossCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlbatrossCbo.FormattingEnabled = True
        Me.AlbatrossCbo.IntegralHeight = False
        Me.AlbatrossCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.AlbatrossCbo.Location = New System.Drawing.Point(54, 233)
        Me.AlbatrossCbo.Name = "AlbatrossCbo"
        Me.AlbatrossCbo.Size = New System.Drawing.Size(227, 23)
        Me.AlbatrossCbo.TabIndex = 45
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(349, 389)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 15)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Penalties:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(51, 389)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 15)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Hole Out:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date Played:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(350, 345)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 15)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Three Putts:"
        '
        'DatePlayedDtp
        '
        Me.DatePlayedDtp.Location = New System.Drawing.Point(54, 57)
        Me.DatePlayedDtp.Name = "DatePlayedDtp"
        Me.DatePlayedDtp.Size = New System.Drawing.Size(227, 23)
        Me.DatePlayedDtp.TabIndex = 0
        '
        'TxtRoundDuration
        '
        Me.TxtRoundDuration.Location = New System.Drawing.Point(54, 101)
        Me.TxtRoundDuration.Name = "TxtRoundDuration"
        Me.TxtRoundDuration.Size = New System.Drawing.Size(227, 23)
        Me.TxtRoundDuration.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(349, 301)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "One Putts:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Round Duration:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Score:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(351, 259)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 15)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Hazards Hit:"
        '
        'TxtRoundScore
        '
        Me.TxtRoundScore.Location = New System.Drawing.Point(54, 145)
        Me.TxtRoundScore.Name = "TxtRoundScore"
        Me.TxtRoundScore.Size = New System.Drawing.Size(227, 23)
        Me.TxtRoundScore.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Hole in Ones:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(350, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 15)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Up and Downs:"
        '
        'HoleInOneCbo
        '
        Me.HoleInOneCbo.BackColor = System.Drawing.Color.White
        Me.HoleInOneCbo.DropDownHeight = 50
        Me.HoleInOneCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoleInOneCbo.FormattingEnabled = True
        Me.HoleInOneCbo.IntegralHeight = False
        Me.HoleInOneCbo.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.HoleInOneCbo.Location = New System.Drawing.Point(54, 189)
        Me.HoleInOneCbo.Name = "HoleInOneCbo"
        Me.HoleInOneCbo.Size = New System.Drawing.Size(227, 23)
        Me.HoleInOneCbo.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Albatrosses:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(349, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Triple +:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Eagles:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(350, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Triple Bogies:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Birdies:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(350, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 15)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Double Bogies:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(51, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Pars:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(349, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Bogies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Course Par:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Course Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Course Name:"
        '
        'TxtCoursePar
        '
        Me.TxtCoursePar.Location = New System.Drawing.Point(458, 44)
        Me.TxtCoursePar.Name = "TxtCoursePar"
        Me.TxtCoursePar.ReadOnly = True
        Me.TxtCoursePar.Size = New System.Drawing.Size(155, 23)
        Me.TxtCoursePar.TabIndex = 2
        '
        'TxtCourseLocation
        '
        Me.TxtCourseLocation.Location = New System.Drawing.Point(274, 44)
        Me.TxtCourseLocation.Name = "TxtCourseLocation"
        Me.TxtCourseLocation.ReadOnly = True
        Me.TxtCourseLocation.Size = New System.Drawing.Size(155, 23)
        Me.TxtCourseLocation.TabIndex = 1
        '
        'TxtCourseName
        '
        Me.TxtCourseName.Location = New System.Drawing.Point(91, 44)
        Me.TxtCourseName.Name = "TxtCourseName"
        Me.TxtCourseName.ReadOnly = True
        Me.TxtCourseName.Size = New System.Drawing.Size(155, 23)
        Me.TxtCourseName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Golfer:"
        '
        'GolferSelectCbo
        '
        Me.GolferSelectCbo.BackColor = System.Drawing.Color.DarkGreen
        Me.GolferSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GolferSelectCbo.ForeColor = System.Drawing.Color.White
        Me.GolferSelectCbo.FormattingEnabled = True
        Me.GolferSelectCbo.Location = New System.Drawing.Point(16, 70)
        Me.GolferSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GolferSelectCbo.Name = "GolferSelectCbo"
        Me.GolferSelectCbo.Size = New System.Drawing.Size(209, 23)
        Me.GolferSelectCbo.TabIndex = 0
        '
        'RoundFormBtnDeleteRound
        '
        Me.RoundFormBtnDeleteRound.Enabled = False
        Me.RoundFormBtnDeleteRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RoundFormBtnDeleteRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.RoundFormBtnDeleteRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundFormBtnDeleteRound.Location = New System.Drawing.Point(128, 197)
        Me.RoundFormBtnDeleteRound.Name = "RoundFormBtnDeleteRound"
        Me.RoundFormBtnDeleteRound.Size = New System.Drawing.Size(97, 31)
        Me.RoundFormBtnDeleteRound.TabIndex = 15
        Me.RoundFormBtnDeleteRound.Text = "&Delete Round"
        Me.RoundFormBtnDeleteRound.UseVisualStyleBackColor = True
        '
        'RoundFormBtnAddRound
        '
        Me.RoundFormBtnAddRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.RoundFormBtnAddRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.RoundFormBtnAddRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundFormBtnAddRound.Location = New System.Drawing.Point(16, 197)
        Me.RoundFormBtnAddRound.Name = "RoundFormBtnAddRound"
        Me.RoundFormBtnAddRound.Size = New System.Drawing.Size(97, 31)
        Me.RoundFormBtnAddRound.TabIndex = 14
        Me.RoundFormBtnAddRound.Text = "&Save Round"
        Me.RoundFormBtnAddRound.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Round:"
        '
        'RoundSelectCbo
        '
        Me.RoundSelectCbo.BackColor = System.Drawing.Color.DarkGreen
        Me.RoundSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoundSelectCbo.ForeColor = System.Drawing.Color.White
        Me.RoundSelectCbo.FormattingEnabled = True
        Me.RoundSelectCbo.Location = New System.Drawing.Point(16, 114)
        Me.RoundSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RoundSelectCbo.Name = "RoundSelectCbo"
        Me.RoundSelectCbo.Size = New System.Drawing.Size(209, 23)
        Me.RoundSelectCbo.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(495, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 32)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Round Form"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 140)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Course:"
        '
        'CourseSelectCbo
        '
        Me.CourseSelectCbo.BackColor = System.Drawing.Color.DarkGreen
        Me.CourseSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseSelectCbo.ForeColor = System.Drawing.Color.White
        Me.CourseSelectCbo.FormattingEnabled = True
        Me.CourseSelectCbo.Location = New System.Drawing.Point(16, 158)
        Me.CourseSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CourseSelectCbo.Name = "CourseSelectCbo"
        Me.CourseSelectCbo.Size = New System.Drawing.Size(209, 23)
        Me.CourseSelectCbo.TabIndex = 2
        '
        'ModifyRoundsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(933, 696)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CourseSelectCbo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoundSelectCbo)
        Me.Controls.Add(Me.RoundFormBtnDeleteRound)
        Me.Controls.Add(Me.RoundFormBtnAddRound)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GolferSelectCbo)
        Me.Controls.Add(Me.ModifyPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "ModifyRoundsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rounds Form"
        Me.ModifyPanel.ResumeLayout(False)
        Me.ModifyPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModifyPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GolferSelectCbo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCoursePar As TextBox
    Friend WithEvents TxtCourseLocation As TextBox
    Friend WithEvents TxtCourseName As TextBox
    Friend WithEvents RoundFormBtnDeleteRound As Button
    Friend WithEvents RoundFormBtnAddRound As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundSelectCbo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CourseSelectCbo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DatePlayedDtp As DateTimePicker
    Friend WithEvents TxtRoundDuration As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtRoundScore As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents HoleInOneCbo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PenaltyCbo As ComboBox
    Friend WithEvents ThreePuttCbo As ComboBox
    Friend WithEvents OnePuttCbo As ComboBox
    Friend WithEvents HazardCbo As ComboBox
    Friend WithEvents UpAndDownCbo As ComboBox
    Friend WithEvents TriplePlusCbo As ComboBox
    Friend WithEvents TripleBogieCbo As ComboBox
    Friend WithEvents DoubleBogieCbo As ComboBox
    Friend WithEvents BogieCbo As ComboBox
    Friend WithEvents HoleOutCbo As ComboBox
    Friend WithEvents ParCbo As ComboBox
    Friend WithEvents BirdieCbo As ComboBox
    Friend WithEvents EagleCbo As ComboBox
    Friend WithEvents AlbatrossCbo As ComboBox
End Class
