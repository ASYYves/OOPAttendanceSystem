Public Class Form2


    Private studentsDummy As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Public Sub New(students As Dictionary(Of String, (Name As String, Sched As String, Course As String)))
        InitializeComponent()
        studentsDummy = students

    End Sub
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click

        Dim studentID As String = Student_ID_txbx.Text.Trim()
        Dim studentName As String = Student_name_txbx.Text.Trim()
        Dim studentcourse As String = course_txbx.Text.Trim()
        Dim studentSched As String = schedule_txbx.Text.Trim()

        studentsDummy.Add(studentID, (studentName, studentSched, studentcourse))



        Student_ID_txbx.Clear()
        Student_name_txbx.Clear()
        course_txbx.Clear()
        schedule_txbx.Clear()

    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles Del_btn.Click

    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click

    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class