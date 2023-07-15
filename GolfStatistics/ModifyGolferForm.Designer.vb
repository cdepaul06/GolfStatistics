<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyGolferForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyGolferForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GolferSelectCbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModifyPanel = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CboClubType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtClubBrand = New System.Windows.Forms.TextBox()
        Me.TxtClubDistance = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.TxtClubModel = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBallModel = New System.Windows.Forms.TextBox()
        Me.ChkSuperSoft = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBallBrand = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkStrap = New System.Windows.Forms.CheckBox()
        Me.ChkCooler = New System.Windows.Forms.CheckBox()
        Me.ChkBagSlots = New System.Windows.Forms.CheckBox()
        Me.ChkCartBag = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBagBrand = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.GolferFormBtnSaveChanges = New System.Windows.Forms.Button()
        Me.EmailTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PhoneTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GolferFormBtnDeleteGolfer = New System.Windows.Forms.Button()
        Me.ModifyPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(495, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Golfer Form"
        '
        'GolferSelectCbo
        '
        Me.GolferSelectCbo.BackColor = System.Drawing.Color.DarkGreen
        Me.GolferSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GolferSelectCbo.ForeColor = System.Drawing.Color.White
        Me.GolferSelectCbo.FormattingEnabled = True
        Me.GolferSelectCbo.Location = New System.Drawing.Point(16, 75)
        Me.GolferSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GolferSelectCbo.Name = "GolferSelectCbo"
        Me.GolferSelectCbo.Size = New System.Drawing.Size(209, 23)
        Me.GolferSelectCbo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Golfer:"
        '
        'ModifyPanel
        '
        Me.ModifyPanel.BackColor = System.Drawing.Color.DarkGreen
        Me.ModifyPanel.Controls.Add(Me.GroupBox4)
        Me.ModifyPanel.Controls.Add(Me.GroupBox3)
        Me.ModifyPanel.Controls.Add(Me.GroupBox2)
        Me.ModifyPanel.Controls.Add(Me.GroupBox1)
        Me.ModifyPanel.Location = New System.Drawing.Point(232, 57)
        Me.ModifyPanel.Name = "ModifyPanel"
        Me.ModifyPanel.Size = New System.Drawing.Size(676, 648)
        Me.ModifyPanel.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboClubType)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TxtClubBrand)
        Me.GroupBox4.Controls.Add(Me.TxtClubDistance)
        Me.GroupBox4.Controls.Add(Me.Label61)
        Me.GroupBox4.Controls.Add(Me.TxtClubModel)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Location = New System.Drawing.Point(426, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 627)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Clubs"
        '
        'CboClubType
        '
        Me.CboClubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClubType.FormattingEnabled = True
        Me.CboClubType.IntegralHeight = False
        Me.CboClubType.Items.AddRange(New Object() {"Driver", "3 Wood", "5 Wood", "7 Wood", "2 Hybrid", "3 Hybrid", "4 Hybrid", "5 Hybrid", "3 Iron", "4 Iron", "5 Iron", "6 Iron", "7 Iron", "8 Iron", "9 Iron", "P. Wedge", "G. Wedge", "S. Wedge", "L. Wedge", "Putter"})
        Me.CboClubType.Location = New System.Drawing.Point(36, 50)
        Me.CboClubType.Name = "CboClubType"
        Me.CboClubType.Size = New System.Drawing.Size(158, 23)
        Me.CboClubType.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Club - Brand"
        '
        'TxtClubBrand
        '
        Me.TxtClubBrand.Location = New System.Drawing.Point(36, 107)
        Me.TxtClubBrand.Name = "TxtClubBrand"
        Me.TxtClubBrand.Size = New System.Drawing.Size(158, 23)
        Me.TxtClubBrand.TabIndex = 0
        '
        'TxtClubDistance
        '
        Me.TxtClubDistance.Location = New System.Drawing.Point(36, 229)
        Me.TxtClubDistance.Name = "TxtClubDistance"
        Me.TxtClubDistance.Size = New System.Drawing.Size(158, 23)
        Me.TxtClubDistance.TabIndex = 3
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(33, 211)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(90, 15)
        Me.Label61.TabIndex = 90
        Me.Label61.Text = "Club - Distance"
        '
        'TxtClubModel
        '
        Me.TxtClubModel.Location = New System.Drawing.Point(36, 168)
        Me.TxtClubModel.Name = "TxtClubModel"
        Me.TxtClubModel.Size = New System.Drawing.Size(158, 23)
        Me.TxtClubModel.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(33, 150)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 15)
        Me.Label36.TabIndex = 64
        Me.Label36.Text = "Club - Model"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(33, 32)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 15)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "Club - Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtBallModel)
        Me.GroupBox3.Controls.Add(Me.ChkSuperSoft)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtBallBrand)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 440)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 205)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ball"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ball Model:"
        '
        'TxtBallModel
        '
        Me.TxtBallModel.Location = New System.Drawing.Point(31, 97)
        Me.TxtBallModel.Name = "TxtBallModel"
        Me.TxtBallModel.Size = New System.Drawing.Size(158, 23)
        Me.TxtBallModel.TabIndex = 1
        '
        'ChkSuperSoft
        '
        Me.ChkSuperSoft.AutoSize = True
        Me.ChkSuperSoft.Location = New System.Drawing.Point(233, 50)
        Me.ChkSuperSoft.Name = "ChkSuperSoft"
        Me.ChkSuperSoft.Size = New System.Drawing.Size(80, 19)
        Me.ChkSuperSoft.TabIndex = 7
        Me.ChkSuperSoft.Text = "Super Soft"
        Me.ChkSuperSoft.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Ball Brand:"
        '
        'TxtBallBrand
        '
        Me.TxtBallBrand.Location = New System.Drawing.Point(31, 50)
        Me.TxtBallBrand.Name = "TxtBallBrand"
        Me.TxtBallBrand.Size = New System.Drawing.Size(158, 23)
        Me.TxtBallBrand.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkStrap)
        Me.GroupBox2.Controls.Add(Me.ChkCooler)
        Me.GroupBox2.Controls.Add(Me.ChkBagSlots)
        Me.GroupBox2.Controls.Add(Me.ChkCartBag)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtBagBrand)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 205)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bag"
        '
        'ChkStrap
        '
        Me.ChkStrap.AutoSize = True
        Me.ChkStrap.Location = New System.Drawing.Point(233, 125)
        Me.ChkStrap.Name = "ChkStrap"
        Me.ChkStrap.Size = New System.Drawing.Size(88, 19)
        Me.ChkStrap.TabIndex = 4
        Me.ChkStrap.Text = "Single Strap"
        Me.ChkStrap.UseVisualStyleBackColor = True
        '
        'ChkCooler
        '
        Me.ChkCooler.AutoSize = True
        Me.ChkCooler.Location = New System.Drawing.Point(233, 75)
        Me.ChkCooler.Name = "ChkCooler"
        Me.ChkCooler.Size = New System.Drawing.Size(61, 19)
        Me.ChkCooler.TabIndex = 3
        Me.ChkCooler.Text = "Cooler"
        Me.ChkCooler.UseVisualStyleBackColor = True
        '
        'ChkBagSlots
        '
        Me.ChkBagSlots.AutoSize = True
        Me.ChkBagSlots.Location = New System.Drawing.Point(233, 100)
        Me.ChkBagSlots.Name = "ChkBagSlots"
        Me.ChkBagSlots.Size = New System.Drawing.Size(103, 19)
        Me.ChkBagSlots.TabIndex = 2
        Me.ChkBagSlots.Text = "Indv. Bag Slots"
        Me.ChkBagSlots.UseVisualStyleBackColor = True
        '
        'ChkCartBag
        '
        Me.ChkCartBag.AutoSize = True
        Me.ChkCartBag.Location = New System.Drawing.Point(233, 50)
        Me.ChkCartBag.Name = "ChkCartBag"
        Me.ChkCartBag.Size = New System.Drawing.Size(71, 19)
        Me.ChkCartBag.TabIndex = 1
        Me.ChkCartBag.Text = "Cart Bag"
        Me.ChkCartBag.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bag Brand:"
        '
        'TxtBagBrand
        '
        Me.TxtBagBrand.Location = New System.Drawing.Point(31, 50)
        Me.TxtBagBrand.Name = "TxtBagBrand"
        Me.TxtBagBrand.Size = New System.Drawing.Size(158, 23)
        Me.TxtBagBrand.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtLastName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtPhone)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 205)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Golfer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Email:"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(31, 50)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(158, 23)
        Me.TxtFirstName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone Number:"
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(195, 50)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(158, 23)
        Me.TxtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name:"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(31, 107)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(158, 23)
        Me.TxtPhone.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(195, 107)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(158, 23)
        Me.TxtEmail.TabIndex = 3
        '
        'GolferFormBtnSaveChanges
        '
        Me.GolferFormBtnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.GolferFormBtnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.GolferFormBtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GolferFormBtnSaveChanges.Location = New System.Drawing.Point(16, 115)
        Me.GolferFormBtnSaveChanges.Name = "GolferFormBtnSaveChanges"
        Me.GolferFormBtnSaveChanges.Size = New System.Drawing.Size(97, 31)
        Me.GolferFormBtnSaveChanges.TabIndex = 12
        Me.GolferFormBtnSaveChanges.Text = "&Save Changes"
        Me.GolferFormBtnSaveChanges.UseVisualStyleBackColor = True
        '
        'EmailTimer
        '
        Me.EmailTimer.Interval = 1000
        '
        'PhoneTimer
        '
        Me.PhoneTimer.Interval = 1000
        '
        'GolferFormBtnDeleteGolfer
        '
        Me.GolferFormBtnDeleteGolfer.Enabled = False
        Me.GolferFormBtnDeleteGolfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.GolferFormBtnDeleteGolfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.GolferFormBtnDeleteGolfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GolferFormBtnDeleteGolfer.Location = New System.Drawing.Point(128, 115)
        Me.GolferFormBtnDeleteGolfer.Name = "GolferFormBtnDeleteGolfer"
        Me.GolferFormBtnDeleteGolfer.Size = New System.Drawing.Size(97, 31)
        Me.GolferFormBtnDeleteGolfer.TabIndex = 13
        Me.GolferFormBtnDeleteGolfer.Text = "&Delete Golfer"
        Me.GolferFormBtnDeleteGolfer.UseVisualStyleBackColor = True
        '
        'ModifyGolferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(937, 717)
        Me.Controls.Add(Me.GolferFormBtnDeleteGolfer)
        Me.Controls.Add(Me.GolferFormBtnSaveChanges)
        Me.Controls.Add(Me.ModifyPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GolferSelectCbo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "ModifyGolferForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Golfer Form"
        Me.ModifyPanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents GolferSelectCbo As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ModifyPanel As Panel
	Friend WithEvents TxtLastName As TextBox
	Friend WithEvents TxtFirstName As TextBox
	Friend WithEvents TxtEmail As TextBox
	Friend WithEvents TxtPhone As TextBox
	Friend WithEvents GolferFormBtnSaveChanges As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents EmailTimer As Timer
	Friend WithEvents PhoneTimer As Timer
	Friend WithEvents GolferFormBtnDeleteGolfer As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ChkStrap As CheckBox
	Friend WithEvents ChkCooler As CheckBox
	Friend WithEvents ChkBagSlots As CheckBox
	Friend WithEvents ChkCartBag As CheckBox
	Friend WithEvents Label7 As Label
	Friend WithEvents TxtBagBrand As TextBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label9 As Label
	Friend WithEvents TxtBallModel As TextBox
	Friend WithEvents ChkSuperSoft As CheckBox
	Friend WithEvents Label8 As Label
	Friend WithEvents TxtBallBrand As TextBox
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents TxtClubDistance As TextBox
	Friend WithEvents Label61 As Label
	Friend WithEvents TxtClubModel As TextBox
	Friend WithEvents Label36 As Label
	Friend WithEvents TxtClubBrand As TextBox
	Friend WithEvents Label35 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents CboClubType As ComboBox
End Class
