Public Class Form2

    Private StudentsDummy As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Public Sub New(students As Dictionary(Of String, (Name As String, Sched As String, Course As String)))
        InitializeComponent()
        StudentsDummy = students
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        Dim StudentID As String = Student_ID_txbx.Text.Trim()
        Dim StudentName As String = Student_name_txbx.Text.Trim()
        Dim StudentCourse As String = course_txbx.Text.Trim()
        Dim StudentSched As String = schedule_txbx.Text.Trim()

        StudentsDummy(StudentID) = (StudentName, StudentSched, StudentCourse)
        Form1.SaveStudentsToFile()

        Student_ID_txbx.Clear()
        Student_name_txbx.Clear()
        course_txbx.Clear()
        schedule_txbx.Clear()

        MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles Del_btn.Click
        Dim StudentID As String = Student_ID_txbx.Text.Trim()

        If StudentsDummy.ContainsKey(StudentID) Then
            StudentsDummy.Remove(StudentID)
            Form1.SaveStudentsToFile()
        End If

        Student_ID_txbx.Clear()
        Student_name_txbx.Clear()
        course_txbx.Clear()
        schedule_txbx.Clear()

        MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Dim StudentID As String = Student_ID_txbx.Text.Trim()
        Dim StudentName As String = Student_name_txbx.Text.Trim()
        Dim StudentCourse As String = course_txbx.Text.Trim()
        Dim StudentSched As String = schedule_txbx.Text.Trim()

        If StudentsDummy.ContainsKey(StudentID) Then
            StudentsDummy(StudentID) = (StudentName, StudentSched, StudentCourse)
            Form1.SaveStudentsToFile()
        End If

        Student_ID_txbx.Clear()
        Student_name_txbx.Clear()
        course_txbx.Clear()
        schedule_txbx.Clear()

        MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class