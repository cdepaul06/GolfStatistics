<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyCourseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyCourseForm))
        Me.CourseFormBtnDeleteCourse = New System.Windows.Forms.Button()
        Me.CourseFormBtnSaveChanges = New System.Windows.Forms.Button()
        Me.ModifyPanel = New System.Windows.Forms.Panel()
        Me.TxtPar4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPar5 = New System.Windows.Forms.TextBox()
        Me.TxtPar3 = New System.Windows.Forms.TextBox()
        Me.TxtCoursePar = New System.Windows.Forms.TextBox()
        Me.TxtCourseLocation = New System.Windows.Forms.TextBox()
        Me.TxtCourseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CourseSelectCbo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModifyPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CourseFormBtnDeleteCourse
        '
        Me.CourseFormBtnDeleteCourse.Enabled = False
        Me.CourseFormBtnDeleteCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CourseFormBtnDeleteCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.CourseFormBtnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CourseFormBtnDeleteCourse.Location = New System.Drawing.Point(128, 120)
        Me.CourseFormBtnDeleteCourse.Name = "CourseFormBtnDeleteCourse"
        Me.CourseFormBtnDeleteCourse.Size = New System.Drawing.Size(97, 31)
        Me.CourseFormBtnDeleteCourse.TabIndex = 19
        Me.CourseFormBtnDeleteCourse.Text = "&Delete Course"
        Me.CourseFormBtnDeleteCourse.UseVisualStyleBackColor = True
        '
        'CourseFormBtnSaveChanges
        '
        Me.CourseFormBtnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CourseFormBtnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.CourseFormBtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CourseFormBtnSaveChanges.Location = New System.Drawing.Point(16, 120)
        Me.CourseFormBtnSaveChanges.Name = "CourseFormBtnSaveChanges"
        Me.CourseFormBtnSaveChanges.Size = New System.Drawing.Size(97, 31)
        Me.CourseFormBtnSaveChanges.TabIndex = 18
        Me.CourseFormBtnSaveChanges.Text = "&Save Changes"
        Me.CourseFormBtnSaveChanges.UseVisualStyleBackColor = True
        '
        'ModifyPanel
        '
        Me.ModifyPanel.BackColor = System.Drawing.Color.DarkGreen
        Me.ModifyPanel.Controls.Add(Me.TxtPar4)
        Me.ModifyPanel.Controls.Add(Me.Label8)
        Me.ModifyPanel.Controls.Add(Me.Label7)
        Me.ModifyPanel.Controls.Add(Me.Label6)
        Me.ModifyPanel.Controls.Add(Me.Label5)
        Me.ModifyPanel.Controls.Add(Me.Label4)
        Me.ModifyPanel.Controls.Add(Me.Label3)
        Me.ModifyPanel.Controls.Add(Me.TxtPar5)
        Me.ModifyPanel.Controls.Add(Me.TxtPar3)
        Me.ModifyPanel.Controls.Add(Me.TxtCoursePar)
        Me.ModifyPanel.Controls.Add(Me.TxtCourseLocation)
        Me.ModifyPanel.Controls.Add(Me.TxtCourseName)
        Me.ModifyPanel.Location = New System.Drawing.Point(232, 62)
        Me.ModifyPanel.Name = "ModifyPanel"
        Me.ModifyPanel.Size = New System.Drawing.Size(689, 159)
        Me.ModifyPanel.TabIndex = 17
        '
        'TxtPar4
        '
        Me.TxtPar4.Location = New System.Drawing.Point(266, 92)
        Me.TxtPar4.Name = "TxtPar4"
        Me.TxtPar4.Size = New System.Drawing.Size(158, 23)
        Me.TxtPar4.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(449, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Par 5's:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Par 4's:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Par 3's:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Course Par:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Course Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Course Name:"
        '
        'TxtPar5
        '
        Me.TxtPar5.Location = New System.Drawing.Point(452, 92)
        Me.TxtPar5.Name = "TxtPar5"
        Me.TxtPar5.Size = New System.Drawing.Size(158, 23)
        Me.TxtPar5.TabIndex = 5
        '
        'TxtPar3
        '
        Me.TxtPar3.Location = New System.Drawing.Point(82, 92)
        Me.TxtPar3.Name = "TxtPar3"
        Me.TxtPar3.Size = New System.Drawing.Size(158, 23)
        Me.TxtPar3.TabIndex = 3
        '
        'TxtCoursePar
        '
        Me.TxtCoursePar.Location = New System.Drawing.Point(452, 44)
        Me.TxtCoursePar.Name = "TxtCoursePar"
        Me.TxtCoursePar.Size = New System.Drawing.Size(158, 23)
        Me.TxtCoursePar.TabIndex = 2
        '
        'TxtCourseLocation
        '
        Me.TxtCourseLocation.Location = New System.Drawing.Point(266, 44)
        Me.TxtCourseLocation.Name = "TxtCourseLocation"
        Me.TxtCourseLocation.Size = New System.Drawing.Size(158, 23)
        Me.TxtCourseLocation.TabIndex = 1
        '
        'TxtCourseName
        '
        Me.TxtCourseName.Location = New System.Drawing.Point(82, 44)
        Me.TxtCourseName.Name = "TxtCourseName"
        Me.TxtCourseName.Size = New System.Drawing.Size(158, 23)
        Me.TxtCourseName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Course:"
        '
        'CourseSelectCbo
        '
        Me.CourseSelectCbo.BackColor = System.Drawing.Color.DarkGreen
        Me.CourseSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseSelectCbo.ForeColor = System.Drawing.Color.White
        Me.CourseSelectCbo.FormattingEnabled = True
        Me.CourseSelectCbo.Location = New System.Drawing.Point(16, 80)
        Me.CourseSelectCbo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CourseSelectCbo.Name = "CourseSelectCbo"
        Me.CourseSelectCbo.Size = New System.Drawing.Size(209, 23)
        Me.CourseSelectCbo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(497, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Course Form"
        '
        'ModifyCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(933, 285)
        Me.Controls.Add(Me.CourseFormBtnDeleteCourse)
        Me.Controls.Add(Me.CourseFormBtnSaveChanges)
        Me.Controls.Add(Me.ModifyPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CourseSelectCbo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "ModifyCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyCourseForm"
        Me.ModifyPanel.ResumeLayout(False)
        Me.ModifyPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CourseFormBtnDeleteCourse As Button
    Friend WithEvents CourseFormBtnSaveChanges As Button
    Friend WithEvents ModifyPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPar5 As TextBox
    Friend WithEvents TxtPar3 As TextBox
    Friend WithEvents TxtCoursePar As TextBox
    Friend WithEvents TxtCourseLocation As TextBox
    Friend WithEvents TxtCourseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CourseSelectCbo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPar4 As TextBox
End Class
