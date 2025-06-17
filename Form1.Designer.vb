<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnEnterId = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblEnterID = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblInOut = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblLogged = New System.Windows.Forms.Label()
        Me.tbxEnterID = New System.Windows.Forms.TextBox()
        Me.tbxCourse = New System.Windows.Forms.TextBox()
        Me.tbxInOut = New System.Windows.Forms.TextBox()
        Me.tbxSchedule = New System.Windows.Forms.TextBox()
        Me.tbxLogged = New System.Windows.Forms.TextBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.tbxStudent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterId
        '
        Me.btnEnterId.Location = New System.Drawing.Point(498, 124)
        Me.btnEnterId.Name = "btnEnterId"
        Me.btnEnterId.Size = New System.Drawing.Size(132, 36)
        Me.btnEnterId.TabIndex = 0
        Me.btnEnterId.Text = "Enter"
        Me.btnEnterId.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(42, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(324, 46)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcom PUPian!"
        '
        'lblEnterID
        '
        Me.lblEnterID.AutoSize = True
        Me.lblEnterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblEnterID.Location = New System.Drawing.Point(75, 134)
        Me.lblEnterID.Name = "lblEnterID"
        Me.lblEnterID.Size = New System.Drawing.Size(95, 25)
        Me.lblEnterID.TabIndex = 2
        Me.lblEnterID.Text = "Enter ID:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblCourse.Location = New System.Drawing.Point(89, 240)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(81, 25)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Course"
        '
        'lblInOut
        '
        Me.lblInOut.AutoSize = True
        Me.lblInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblInOut.Location = New System.Drawing.Point(2, 304)
        Me.lblInOut.Name = "lblInOut"
        Me.lblInOut.Size = New System.Drawing.Size(168, 20)
        Me.lblInOut.TabIndex = 4
        Me.lblInOut.Text = "You are now clocked "
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblSchedule.Location = New System.Drawing.Point(68, 359)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(102, 25)
        Me.lblSchedule.TabIndex = 5
        Me.lblSchedule.Text = "Schedule"
        '
        'lblLogged
        '
        Me.lblLogged.AutoSize = True
        Me.lblLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblLogged.Location = New System.Drawing.Point(24, 410)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(146, 25)
        Me.lblLogged.TabIndex = 6
        Me.lblLogged.Text = "You logged at"
        '
        'tbxEnterID
        '
        Me.tbxEnterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxEnterID.Location = New System.Drawing.Point(183, 129)
        Me.tbxEnterID.Name = "tbxEnterID"
        Me.tbxEnterID.Size = New System.Drawing.Size(297, 31)
        Me.tbxEnterID.TabIndex = 2
        Me.tbxEnterID.Tag = ""
        Me.tbxEnterID.Text = "0000-0000-BN-0"
        '
        'tbxCourse
        '
        Me.tbxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxCourse.Location = New System.Drawing.Point(183, 234)
        Me.tbxCourse.Name = "tbxCourse"
        Me.tbxCourse.ReadOnly = True
        Me.tbxCourse.Size = New System.Drawing.Size(297, 31)
        Me.tbxCourse.TabIndex = 8
        '
        'tbxInOut
        '
        Me.tbxInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxInOut.Location = New System.Drawing.Point(183, 293)
        Me.tbxInOut.Name = "tbxInOut"
        Me.tbxInOut.ReadOnly = True
        Me.tbxInOut.Size = New System.Drawing.Size(297, 31)
        Me.tbxInOut.TabIndex = 9
        '
        'tbxSchedule
        '
        Me.tbxSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxSchedule.Location = New System.Drawing.Point(183, 353)
        Me.tbxSchedule.Name = "tbxSchedule"
        Me.tbxSchedule.ReadOnly = True
        Me.tbxSchedule.Size = New System.Drawing.Size(297, 31)
        Me.tbxSchedule.TabIndex = 10
        '
        'tbxLogged
        '
        Me.tbxLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxLogged.Location = New System.Drawing.Point(183, 404)
        Me.tbxLogged.Name = "tbxLogged"
        Me.tbxLogged.ReadOnly = True
        Me.tbxLogged.Size = New System.Drawing.Size(297, 31)
        Me.tbxLogged.TabIndex = 11
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblStudent.Location = New System.Drawing.Point(69, 189)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(101, 25)
        Me.lblStudent.TabIndex = 12
        Me.lblStudent.Text = "Welcome"
        '
        'tbxStudent
        '
        Me.tbxStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxStudent.Location = New System.Drawing.Point(183, 183)
        Me.tbxStudent.Name = "tbxStudent"
        Me.tbxStudent.ReadOnly = True
        Me.tbxStudent.Size = New System.Drawing.Size(297, 31)
        Me.tbxStudent.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Dash are automatic"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnterId
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxStudent)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.tbxLogged)
        Me.Controls.Add(Me.tbxSchedule)
        Me.Controls.Add(Me.tbxInOut)
        Me.Controls.Add(Me.tbxCourse)
        Me.Controls.Add(Me.tbxEnterID)
        Me.Controls.Add(Me.lblLogged)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblInOut)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblEnterID)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnEnterId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterId As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblEnterID As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblInOut As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblLogged As Label
    Friend WithEvents tbxEnterID As TextBox
    Friend WithEvents tbxCourse As TextBox
    Friend WithEvents tbxInOut As TextBox
    Friend WithEvents tbxSchedule As TextBox
    Friend WithEvents tbxLogged As TextBox
    Friend WithEvents lblStudent As Label
    Friend WithEvents tbxStudent As TextBox
    Friend WithEvents Label1 As Label
End Class
