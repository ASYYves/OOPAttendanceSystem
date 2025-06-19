Public Class Form1

    Public Shared students As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Public Shared attendanceLogs As New Dictionary(Of String, List(Of String))
    Public Shared lateCounts As New Dictionary(Of String, Integer)
    Public Shared absentCounts As New Dictionary(Of String, Integer)

    Private Sub StudentData(Sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load student info
        If IO.File.Exists("studentRecords.txt") Then
            Dim lines = IO.File.ReadAllLines("studentRecords.txt")
            For Each line In lines
                Dim parts = line.Split("|"c)
                If parts.Length = 4 Then
                    students(parts(0)) = (parts(1), parts(2), parts(3))
                End If
            Next
        End If

        ' Load attendance logs
        If IO.File.Exists("attendance.txt") Then
            For Each line In IO.File.ReadAllLines("attendance.txt")
                Dim parts = line.Split("|"c)
                If parts.Length = 2 Then
                    If Not attendanceLogs.ContainsKey(parts(0)) Then
                        attendanceLogs(parts(0)) = New List(Of String)
                    End If
                    attendanceLogs(parts(0)).Add(parts(1))
                End If
            Next
        End If

        ' Load lates and absents
        If IO.File.Exists("lates_absents.txt") Then
            For Each line In IO.File.ReadAllLines("lates_absents.txt")
                Dim parts = line.Split("|"c)
                If parts.Length = 3 Then
                    lateCounts(parts(0)) = Integer.Parse(parts(1))
                    absentCounts(parts(0)) = Integer.Parse(parts(2))
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
        Dim inputID As String = tbxEnterID.Text.Trim().ToUpper()

        If inputID = "2023-00001-BN-0" Then
            tbxStudent.Text = "Welcome Admin!"
            tbxInOut.Text = ""
            tbxSchedule.Text = ""
            tbxLogged.Text = ""
            Me.Hide()
            Dim adminForm As New Form2(students)
            adminForm.Show()
            Exit Sub
        End If

        If students.ContainsKey(inputID) Then
            Dim student = students(inputID)
            tbxStudent.Text = student.Name & "!"
            tbxCourse.Text = student.Course
            tbxSchedule.Text = student.Sched

            ' Show lates/absents
            Dim late = If(lateCounts.ContainsKey(inputID), lateCounts(inputID), 0)
            Dim absent = If(absentCounts.ContainsKey(inputID), absentCounts(inputID), 0)
            tbxLates.Text = late.ToString()
            tbxAbsents.Text = absent.ToString()

            ' IN/OUT logic
            If Not attendanceLogs.ContainsKey(inputID) Then
                attendanceLogs(inputID) = New List(Of String)
            End If

            Dim logCount = attendanceLogs(inputID).Count
            Dim status = If(logCount Mod 2 = 0, "IN", "OUT")
            Dim currentTime = DateTime.Now
            attendanceLogs(inputID).Add(currentTime.ToString("yyyy-MM-dd hh:mm tt") & " " & status)
            tbxInOut.Text = status
            tbxLogged.Text = currentTime.ToString("hh:mm tt")

            ' Check for lates (only for IN status)
            If status = "IN" Then
                Dim schedParts = student.Sched.Split("-"c)
                If schedParts.Length = 2 Then
                    Dim schedStartStr = schedParts(0).Trim()
                    Dim schedEndStr = schedParts(1).Trim()
                    Dim schedStart As DateTime
                    Dim schedEnd As DateTime
                    If DateTime.TryParse(schedStartStr, schedStart) AndAlso DateTime.TryParse(schedEndStr, schedEnd) Then
                        ' Mark absent if log-in is after scheduled end
                        Dim isAbsent = False
                        If currentTime.TimeOfDay > schedEnd.TimeOfDay Then
                            If Not absentCounts.ContainsKey(inputID) Then absentCounts(inputID) = 0
                            absentCounts(inputID) += 1
                            isAbsent = True
                        End If
                        ' Late if more than 15 mins after sched start and not absent
                        If Not isAbsent AndAlso currentTime.TimeOfDay > schedStart.AddMinutes(15).TimeOfDay Then
                            If Not lateCounts.ContainsKey(inputID) Then lateCounts(inputID) = 0
                            lateCounts(inputID) += 1
                        End If
                    End If
                End If
            End If

            SaveAttendance()
        Else
            tbxStudent.Text = "ID NOT RECOGNIZED"
            tbxInOut.Text = ""
            tbxSchedule.Text = ""
            tbxLogged.Text = ""
            tbxLates.Text = ""
            tbxAbsents.Text = ""
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

    Private Sub SaveAttendance()
        ' Save attendance logs
        Dim lines As New List(Of String)
        For Each kvp In attendanceLogs
            For Each log In kvp.Value
                lines.Add(kvp.Key & "|" & log)
            Next
        Next
        IO.File.WriteAllLines("attendance.txt", lines)

        ' Save lates and absents
        Dim laLines As New List(Of String)
        For Each id In students.Keys
            Dim lates = If(lateCounts.ContainsKey(id), lateCounts(id), 0)
            Dim absents = If(absentCounts.ContainsKey(id), absentCounts(id), 0)
            laLines.Add(id & "|" & lates & "|" & absents)
        Next
        IO.File.WriteAllLines("lates_absents.txt", laLines)

        ' Save updated student schedules (optional update if needed)
        Dim studentLines As New List(Of String)
        For Each kvp In students
            studentLines.Add(kvp.Key & "|" & kvp.Value.Name & "|" & kvp.Value.Course & "|" & kvp.Value.Sched)
        Next
        IO.File.WriteAllLines("studentRecords.txt", studentLines)
    End Sub


End Class