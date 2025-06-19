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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnEnterId = New System.Windows.Forms.Button()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxLates = New System.Windows.Forms.TextBox()
        Me.tbxAbsents = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnterId
        '
        Me.btnEnterId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterId.Location = New System.Drawing.Point(401, 224)
        Me.btnEnterId.Name = "btnEnterId"
        Me.btnEnterId.Size = New System.Drawing.Size(86, 29)
        Me.btnEnterId.TabIndex = 0
        Me.btnEnterId.Text = "Enter"
        Me.btnEnterId.UseVisualStyleBackColor = True
        '
        'lblEnterID
        '
        Me.lblEnterID.AutoSize = True
        Me.lblEnterID.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterID.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterID.ForeColor = System.Drawing.Color.Black
        Me.lblEnterID.Location = New System.Drawing.Point(145, 223)
        Me.lblEnterID.Name = "lblEnterID"
        Me.lblEnterID.Size = New System.Drawing.Size(96, 27)
        Me.lblEnterID.TabIndex = 2
        Me.lblEnterID.Text = "Enter ID:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(145, 325)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(81, 27)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Course:"
        '
        'lblInOut
        '
        Me.lblInOut.AutoSize = True
        Me.lblInOut.BackColor = System.Drawing.Color.Transparent
        Me.lblInOut.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOut.Location = New System.Drawing.Point(145, 372)
        Me.lblInOut.Name = "lblInOut"
        Me.lblInOut.Size = New System.Drawing.Size(204, 27)
        Me.lblInOut.TabIndex = 4
        Me.lblInOut.Text = "You are now clocked "
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.BackColor = System.Drawing.Color.Transparent
        Me.lblSchedule.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(145, 510)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(100, 27)
        Me.lblSchedule.TabIndex = 5
        Me.lblSchedule.Text = "Schedule:"
        '
        'lblLogged
        '
        Me.lblLogged.AutoSize = True
        Me.lblLogged.BackColor = System.Drawing.Color.Transparent
        Me.lblLogged.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogged.Location = New System.Drawing.Point(145, 560)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(135, 27)
        Me.lblLogged.TabIndex = 6
        Me.lblLogged.Text = "You logged at"
        '
        'tbxEnterID
        '
        Me.tbxEnterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxEnterID.Location = New System.Drawing.Point(236, 223)
        Me.tbxEnterID.Name = "tbxEnterID"
        Me.tbxEnterID.Size = New System.Drawing.Size(152, 31)
        Me.tbxEnterID.TabIndex = 2
        Me.tbxEnterID.Tag = ""
        Me.tbxEnterID.Text = "0000-0000-BN-0"
        '
        'tbxCourse
        '
        Me.tbxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxCourse.Location = New System.Drawing.Point(228, 320)
        Me.tbxCourse.Name = "tbxCourse"
        Me.tbxCourse.ReadOnly = True
        Me.tbxCourse.Size = New System.Drawing.Size(117, 31)
        Me.tbxCourse.TabIndex = 8
        '
        'tbxInOut
        '
        Me.tbxInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxInOut.Location = New System.Drawing.Point(348, 372)
        Me.tbxInOut.Name = "tbxInOut"
        Me.tbxInOut.ReadOnly = True
        Me.tbxInOut.Size = New System.Drawing.Size(82, 31)
        Me.tbxInOut.TabIndex = 9
        '
        'tbxSchedule
        '
        Me.tbxSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxSchedule.Location = New System.Drawing.Point(242, 510)
        Me.tbxSchedule.Name = "tbxSchedule"
        Me.tbxSchedule.ReadOnly = True
        Me.tbxSchedule.Size = New System.Drawing.Size(206, 31)
        Me.tbxSchedule.TabIndex = 10
        '
        'tbxLogged
        '
        Me.tbxLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxLogged.Location = New System.Drawing.Point(286, 560)
        Me.tbxLogged.Name = "tbxLogged"
        Me.tbxLogged.ReadOnly = True
        Me.tbxLogged.Size = New System.Drawing.Size(162, 31)
        Me.tbxLogged.TabIndex = 11
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblStudent.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(145, 275)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(95, 27)
        Me.lblStudent.TabIndex = 12
        Me.lblStudent.Text = "Welcome"
        '
        'tbxStudent
        '
        Me.tbxStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxStudent.Location = New System.Drawing.Point(242, 270)
        Me.tbxStudent.Name = "tbxStudent"
        Me.tbxStudent.ReadOnly = True
        Me.tbxStudent.Size = New System.Drawing.Size(297, 31)
        Me.tbxStudent.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Dash are automatic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Number of Lates:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 27)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Number of  Absents:"
        '
        'tbxLates
        '
        Me.tbxLates.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxLates.Location = New System.Drawing.Point(322, 418)
        Me.tbxLates.Name = "tbxLates"
        Me.tbxLates.ReadOnly = True
        Me.tbxLates.Size = New System.Drawing.Size(82, 31)
        Me.tbxLates.TabIndex = 17
        '
        'tbxAbsents
        '
        Me.tbxAbsents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.tbxAbsents.Location = New System.Drawing.Point(348, 462)
        Me.tbxAbsents.Name = "tbxAbsents"
        Me.tbxAbsents.ReadOnly = True
        Me.tbxAbsents.Size = New System.Drawing.Size(82, 31)
        Me.tbxAbsents.TabIndex = 18
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnterId
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OOPIDAttendanceSystem.My.Resources.Resources.BGOOP2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(669, 609)
        Me.Controls.Add(Me.tbxAbsents)
        Me.Controls.Add(Me.tbxLates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.btnEnterId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATTENDANCE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterId As Button
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxLates As TextBox
    Friend WithEvents tbxAbsents As TextBox
End Class
