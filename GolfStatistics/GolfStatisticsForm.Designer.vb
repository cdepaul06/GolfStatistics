<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GolfStatisticsForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GolfStatisticsForm))
		Me.GolferSelectCbo = New System.Windows.Forms.ComboBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuFileGenerateGolferFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuFileExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.RoundControlModifyBtn = New System.Windows.Forms.Button()
		Me.GolferControlModifyBtn = New System.Windows.Forms.Button()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.CourseControlModifyBtn = New System.Windows.Forms.Button()
		Me.GolfStatisticsPanel = New System.Windows.Forms.Panel()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.TxtPhone = New System.Windows.Forms.TextBox()
		Me.TxtEmail = New System.Windows.Forms.TextBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.LblRoundsPlayed = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.LblLatestScore = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.LblAvgScore = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GolferPrintDocument = New System.Drawing.Printing.PrintDocument()
		Me.MenuStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GolfStatisticsPanel.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GolferSelectCbo
		'
		Me.GolferSelectCbo.BackColor = System.Drawing.Color.DarkGreen
		Me.GolferSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.GolferSelectCbo.ForeColor = System.Drawing.Color.White
		Me.GolferSelectCbo.FormattingEnabled = True
		Me.GolferSelectCbo.Location = New System.Drawing.Point(9, 37)
		Me.GolferSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.GolferSelectCbo.Name = "GolferSelectCbo"
		Me.GolferSelectCbo.Size = New System.Drawing.Size(184, 23)
		Me.GolferSelectCbo.TabIndex = 0
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuHelp})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(1275, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'MenuFile
		'
		Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileGenerateGolferFile, Me.MenuFilePrint, Me.MenuFileExit})
		Me.MenuFile.Name = "MenuFile"
		Me.MenuFile.Size = New System.Drawing.Size(37, 20)
		Me.MenuFile.Text = "&File"
		'
		'MenuFileGenerateGolferFile
		'
		Me.MenuFileGenerateGolferFile.Name = "MenuFileGenerateGolferFile"
		Me.MenuFileGenerateGolferFile.Size = New System.Drawing.Size(180, 22)
		Me.MenuFileGenerateGolferFile.Text = "&Save Golfer to File"
		'
		'MenuFilePrint
		'
		Me.MenuFilePrint.Name = "MenuFilePrint"
		Me.MenuFilePrint.Size = New System.Drawing.Size(180, 22)
		Me.MenuFilePrint.Text = "&Print"
		'
		'MenuFileExit
		'
		Me.MenuFileExit.Name = "MenuFileExit"
		Me.MenuFileExit.Size = New System.Drawing.Size(180, 22)
		Me.MenuFileExit.Text = "&Exit"
		'
		'MenuHelp
		'
		Me.MenuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuHelpAbout})
		Me.MenuHelp.Name = "MenuHelp"
		Me.MenuHelp.Size = New System.Drawing.Size(44, 20)
		Me.MenuHelp.Text = "&Help"
		'
		'MenuHelpAbout
		'
		Me.MenuHelpAbout.Name = "MenuHelpAbout"
		Me.MenuHelpAbout.Size = New System.Drawing.Size(107, 22)
		Me.MenuHelpAbout.Text = "&About"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 15)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Golfer:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.GolferSelectCbo)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(200, 85)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Golfer Select"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(672, 34)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(153, 21)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Golfer Information"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.RoundControlModifyBtn)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(200, 67)
		Me.GroupBox2.TabIndex = 4
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Round Control"
		'
		'RoundControlModifyBtn
		'
		Me.RoundControlModifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.RoundControlModifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
		Me.RoundControlModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.RoundControlModifyBtn.Location = New System.Drawing.Point(28, 22)
		Me.RoundControlModifyBtn.Name = "RoundControlModifyBtn"
		Me.RoundControlModifyBtn.Size = New System.Drawing.Size(134, 32)
		Me.RoundControlModifyBtn.TabIndex = 0
		Me.RoundControlModifyBtn.Text = "Modify Rounds"
		Me.RoundControlModifyBtn.UseVisualStyleBackColor = True
		'
		'GolferControlModifyBtn
		'
		Me.GolferControlModifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.GolferControlModifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
		Me.GolferControlModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GolferControlModifyBtn.Location = New System.Drawing.Point(28, 22)
		Me.GolferControlModifyBtn.Name = "GolferControlModifyBtn"
		Me.GolferControlModifyBtn.Size = New System.Drawing.Size(134, 32)
		Me.GolferControlModifyBtn.TabIndex = 1
		Me.GolferControlModifyBtn.Text = "Modify Golfers"
		Me.GolferControlModifyBtn.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.GolferControlModifyBtn)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 136)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(200, 67)
		Me.GroupBox4.TabIndex = 5
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Golfer Control"
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.CourseControlModifyBtn)
		Me.GroupBox6.Location = New System.Drawing.Point(12, 282)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(200, 67)
		Me.GroupBox6.TabIndex = 6
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "Course Control"
		'
		'CourseControlModifyBtn
		'
		Me.CourseControlModifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.CourseControlModifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
		Me.CourseControlModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.CourseControlModifyBtn.Location = New System.Drawing.Point(28, 22)
		Me.CourseControlModifyBtn.Name = "CourseControlModifyBtn"
		Me.CourseControlModifyBtn.Size = New System.Drawing.Size(134, 32)
		Me.CourseControlModifyBtn.TabIndex = 3
		Me.CourseControlModifyBtn.Text = "Modify Courses"
		Me.CourseControlModifyBtn.UseVisualStyleBackColor = True
		'
		'GolfStatisticsPanel
		'
		Me.GolfStatisticsPanel.BackColor = System.Drawing.Color.DarkGreen
		Me.GolfStatisticsPanel.Controls.Add(Me.GroupBox3)
		Me.GolfStatisticsPanel.Location = New System.Drawing.Point(233, 56)
		Me.GolfStatisticsPanel.Name = "GolfStatisticsPanel"
		Me.GolfStatisticsPanel.Size = New System.Drawing.Size(1030, 293)
		Me.GolfStatisticsPanel.TabIndex = 7
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.TxtPhone)
		Me.GroupBox3.Controls.Add(Me.TxtEmail)
		Me.GroupBox3.Controls.Add(Me.Panel3)
		Me.GroupBox3.Controls.Add(Me.Panel2)
		Me.GroupBox3.Controls.Add(Me.Panel1)
		Me.GroupBox3.Controls.Add(Me.Label3)
		Me.GroupBox3.Controls.Add(Me.Label5)
		Me.GroupBox3.Controls.Add(Me.Label7)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Controls.Add(Me.Label6)
		Me.GroupBox3.Location = New System.Drawing.Point(159, 80)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(740, 100)
		Me.GroupBox3.TabIndex = 6
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "General"
		'
		'TxtPhone
		'
		Me.TxtPhone.Location = New System.Drawing.Point(535, 51)
		Me.TxtPhone.Name = "TxtPhone"
		Me.TxtPhone.ReadOnly = True
		Me.TxtPhone.Size = New System.Drawing.Size(149, 23)
		Me.TxtPhone.TabIndex = 9
		'
		'TxtEmail
		'
		Me.TxtEmail.Location = New System.Drawing.Point(321, 51)
		Me.TxtEmail.Name = "TxtEmail"
		Me.TxtEmail.ReadOnly = True
		Me.TxtEmail.Size = New System.Drawing.Size(186, 23)
		Me.TxtEmail.TabIndex = 8
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.White
		Me.Panel3.Controls.Add(Me.LblRoundsPlayed)
		Me.Panel3.Location = New System.Drawing.Point(228, 39)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(53, 43)
		Me.Panel3.TabIndex = 7
		'
		'LblRoundsPlayed
		'
		Me.LblRoundsPlayed.AutoSize = True
		Me.LblRoundsPlayed.Location = New System.Drawing.Point(3, 15)
		Me.LblRoundsPlayed.Name = "LblRoundsPlayed"
		Me.LblRoundsPlayed.Size = New System.Drawing.Size(47, 15)
		Me.LblRoundsPlayed.TabIndex = 2
		Me.LblRoundsPlayed.Text = "--------"
		Me.LblRoundsPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.White
		Me.Panel2.Controls.Add(Me.LblLatestScore)
		Me.Panel2.Location = New System.Drawing.Point(132, 39)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(53, 43)
		Me.Panel2.TabIndex = 6
		'
		'LblLatestScore
		'
		Me.LblLatestScore.AutoSize = True
		Me.LblLatestScore.Location = New System.Drawing.Point(3, 15)
		Me.LblLatestScore.Name = "LblLatestScore"
		Me.LblLatestScore.Size = New System.Drawing.Size(47, 15)
		Me.LblLatestScore.TabIndex = 1
		Me.LblLatestScore.Text = "--------"
		Me.LblLatestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.LblAvgScore)
		Me.Panel1.Location = New System.Drawing.Point(37, 39)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(53, 43)
		Me.Panel1.TabIndex = 5
		'
		'LblAvgScore
		'
		Me.LblAvgScore.AutoSize = True
		Me.LblAvgScore.Location = New System.Drawing.Point(3, 15)
		Me.LblAvgScore.Name = "LblAvgScore"
		Me.LblAvgScore.Size = New System.Drawing.Size(47, 15)
		Me.LblAvgScore.TabIndex = 0
		Me.LblAvgScore.Text = "--------"
		Me.LblAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 19)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Average Score"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(117, 19)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(82, 17)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Latest Score"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(559, 19)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(101, 17)
		Me.Label7.TabIndex = 4
		Me.Label7.Text = "Phone Number"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(205, 19)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(99, 17)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Rounds Played"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(367, 19)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(95, 17)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Email Address"
		'
		'GolferPrintDocument
		'
		'
		'GolfStatisticsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.ForestGreen
		Me.ClientSize = New System.Drawing.Size(1275, 374)
		Me.Controls.Add(Me.GolfStatisticsPanel)
		Me.Controls.Add(Me.GroupBox6)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.Name = "GolfStatisticsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Golf Statistics"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox6.ResumeLayout(False)
		Me.GolfStatisticsPanel.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GolferSelectCbo As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents MenuFilePrint As ToolStripMenuItem
    Friend WithEvents MenuFileExit As ToolStripMenuItem
    Friend WithEvents MenuHelp As ToolStripMenuItem
    Friend WithEvents MenuHelpAbout As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RoundControlModifyBtn As Button
    Friend WithEvents GolferControlModifyBtn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CourseControlModifyBtn As Button
    Friend WithEvents GolfStatisticsPanel As Panel
    Friend WithEvents MenuFileGenerateGolferFile As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents TxtPhone As TextBox
	Friend WithEvents TxtEmail As TextBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents LblRoundsPlayed As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents LblLatestScore As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents LblAvgScore As Label
	Friend WithEvents GolferPrintDocument As Printing.PrintDocument
End Class
