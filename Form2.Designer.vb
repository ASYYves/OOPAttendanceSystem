<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.Del_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.schedule_txbx = New System.Windows.Forms.TextBox()
        Me.course_txbx = New System.Windows.Forms.TextBox()
        Me.Student_name_txbx = New System.Windows.Forms.TextBox()
        Me.Student_ID_txbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Back_btn
        '
        Me.Back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.Location = New System.Drawing.Point(606, 530)
        Me.Back_btn.MaximumSize = New System.Drawing.Size(70, 32)
        Me.Back_btn.MinimumSize = New System.Drawing.Size(70, 32)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(70, 32)
        Me.Back_btn.TabIndex = 12
        Me.Back_btn.Text = "back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'Del_btn
        '
        Me.Del_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del_btn.Location = New System.Drawing.Point(523, 457)
        Me.Del_btn.Name = "Del_btn"
        Me.Del_btn.Size = New System.Drawing.Size(107, 44)
        Me.Del_btn.TabIndex = 11
        Me.Del_btn.Text = "Delete"
        Me.Del_btn.UseVisualStyleBackColor = True
        '
        'Update_btn
        '
        Me.Update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.Location = New System.Drawing.Point(343, 457)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(117, 44)
        Me.Update_btn.TabIndex = 10
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'Add_btn
        '
        Me.Add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.Location = New System.Drawing.Point(176, 457)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(99, 44)
        Me.Add_btn.TabIndex = 9
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'schedule_txbx
        '
        Me.schedule_txbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedule_txbx.Location = New System.Drawing.Point(168, 354)
        Me.schedule_txbx.Name = "schedule_txbx"
        Me.schedule_txbx.Size = New System.Drawing.Size(210, 36)
        Me.schedule_txbx.TabIndex = 8
        '
        'course_txbx
        '
        Me.course_txbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course_txbx.Location = New System.Drawing.Point(145, 280)
        Me.course_txbx.Name = "course_txbx"
        Me.course_txbx.Size = New System.Drawing.Size(192, 36)
        Me.course_txbx.TabIndex = 7
        '
        'Student_name_txbx
        '
        Me.Student_name_txbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_name_txbx.Location = New System.Drawing.Point(218, 204)
        Me.Student_name_txbx.Name = "Student_name_txbx"
        Me.Student_name_txbx.Size = New System.Drawing.Size(355, 36)
        Me.Student_name_txbx.TabIndex = 6
        '
        'Student_ID_txbx
        '
        Me.Student_ID_txbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_ID_txbx.Location = New System.Drawing.Point(193, 129)
        Me.Student_ID_txbx.Name = "Student_ID_txbx"
        Me.Student_ID_txbx.Size = New System.Drawing.Size(267, 36)
        Me.Student_ID_txbx.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Schedule:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 9)
        Me.Label1.MaximumSize = New System.Drawing.Size(389, 52)
        Me.Label1.MinimumSize = New System.Drawing.Size(389, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Dashboard"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.OOPIDAttendanceSystem.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(689, 543)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Del_btn)
        Me.Controls.Add(Me.Student_ID_txbx)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.schedule_txbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.course_txbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Student_name_txbx)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN DASHBOARD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents schedule_txbx As TextBox
    Friend WithEvents course_txbx As TextBox
    Friend WithEvents Student_name_txbx As TextBox
    Friend WithEvents Student_ID_txbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Del_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents Add_btn As Button
    Friend WithEvents Back_btn As Button
End Class
