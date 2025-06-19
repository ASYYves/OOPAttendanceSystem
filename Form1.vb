Public Class Form1

    Public Shared students As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Private Sub StudentData(Sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("studentRecords.txt") Then
            Dim lines = IO.File.ReadAllLines("studentRecords.txt")
            For Each line In lines
                Dim parts = line.Split("|"c)
                If parts.Length = 4 Then
                    students(parts(0)) = (parts(1), parts(2), parts(3))
                End If
            Next
        End If

        If Not students.ContainsKey("2023-00001-BN-0") Then
            students.Add("2023-00001-BN-0", ("Admin", "", "FACULTY"))
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxEnterID.Focus()
        tbxEnterID.SelectAll()
    End Sub

    Private Sub txbEnterID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxEnterID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnterId.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnEnterId_Click(sender As Object, e As EventArgs) Handles btnEnterId.Click
        Dim inputID As String = tbxEnterID.Text.Trim()

        If inputID = "2023-00001-BN-0" Then
            tbxStudent.Text = "Welcome Admin!"
            tbxInOut.Text = ""
            tbxSchedule.Text = ""
            tbxLogged.Text = ""

            Me.Hide()
            Dim adminForm As New Form2(students)
            adminForm.Show()

        ElseIf students.ContainsKey(inputID) Then
            Dim student = students(inputID)

            tbxStudent.Text = "Welcome " & student.Name & "!"
            tbxCourse.Text = student.Course
            tbxInOut.Text = "IN"
            tbxSchedule.Text = "Schedule: " & student.Sched
            tbxLogged.Text = "Attendance Logged at " & DateTime.Now.ToString("hh:mm:tt")
        Else
            tbxStudent.Text = "ID NOT RECOGNIZED"
            tbxInOut.Text = ""
            tbxSchedule.Text = ""
            tbxLogged.Text = ""
        End If

        tbxEnterID.Focus()
        tbxEnterID.SelectAll()
    End Sub

    Private Sub txbEnterID_TextChanged(sender As Object, e As EventArgs) Handles tbxEnterID.TextChanged
        Dim cursorPos As Integer = tbxEnterID.SelectionStart
        Dim raw = tbxEnterID.Text.Replace("-", "").ToUpper()

        If raw.Length > 13 Then raw = raw.Substring(0, 13)

        Dim formatted As String = ""
        Dim dashOffsets As New List(Of Integer) From {4, 9, 11}

        For i As Integer = 0 To raw.Length - 1
            formatted &= raw(i)
            If dashOffsets.Contains(i + 1) AndAlso i <> raw.Length - 1 Then
                formatted &= "-"
            End If
        Next

        If tbxEnterID.Text <> formatted Then
            Dim addedLength = formatted.Length - tbxEnterID.Text.Length
            tbxEnterID.Text = formatted
            cursorPos += addedLength
            If cursorPos < 0 Then cursorPos = 0
            If cursorPos > formatted.Length Then cursorPos = formatted.Length
            tbxEnterID.SelectionStart = cursorPos
        End If
    End Sub

    Private Sub txbEnterID_GotFocus(sender As Object, e As EventArgs) Handles tbxEnterID.GotFocus
        tbxEnterID.SelectAll()
    End Sub

    Public Shared Sub SaveStudentsToFile()
        Dim lines As New List(Of String)
        For Each s In students
            lines.Add(s.Key & "|" & s.Value.Name & "|" & s.Value.Sched & "|" & s.Value.Course)
        Next
        IO.File.WriteAllLines("studentRecords.txt", lines)
    End Sub

End Class