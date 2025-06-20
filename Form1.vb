Public Class Form1

    Public Shared Students As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Public Shared AttendanceLogs As New Dictionary(Of String, List(Of String))
    Public Shared LateCounts As New Dictionary(Of String, Integer)
    Public Shared AbsentCounts As New Dictionary(Of String, Integer)

    Private Sub StudentData(Sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Student Data
        If IO.File.Exists("studentRecords.txt") Then
            Dim lines = IO.File.ReadAllLines("studentRecords.txt")
            For Each line In lines
                Dim parts = line.Split("|"c)
                If parts.Length = 4 Then
                    Students(parts(0)) = (parts(1), parts(2), parts(3))
                End If
            Next
        End If

        ' Load Attendance Logs
        If IO.File.Exists("attendance.txt") Then
            For Each line In IO.File.ReadAllLines("attendance.txt")
                Dim Parts = line.Split("|"c)
                If Parts.Length = 2 Then
                    If Not AttendanceLogs.ContainsKey(Parts(0)) Then
                        AttendanceLogs(Parts(0)) = New List(Of String)
                    End If
                    AttendanceLogs(Parts(0)).Add(Parts(1))
                End If
            Next
        End If

        ' Load Lates and Absents
        If IO.File.Exists("lates_absents.txt") Then
            For Each line In IO.File.ReadAllLines("lates_absents.txt")
                Dim parts = line.Split("|"c)
                If parts.Length = 3 Then
                    LateCounts(parts(0)) = Integer.Parse(parts(1))
                    AbsentCounts(parts(0)) = Integer.Parse(parts(2))
                End If
            Next
        End If

        If Not Students.ContainsKey("2023-00001-BN-0") Then
            Students.Add("2023-00001-BN-0", ("ADMIN", "", "FACULTY"))
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

    Private Sub btnEnterID_Click(sender As Object, e As EventArgs) Handles btnEnterId.Click
        Dim InputID As String = tbxEnterID.Text.Trim().ToUpper()

        If InputID = "2023-00001-BN-0" Then
            tbxStudent.Text = "Welcome Admin!"
            tbxInOut.Text = ""
            tbxSchedule.Text = ""
            tbxLogged.Text = ""
            Me.Hide()
            Dim AdminForm As New Form2(Students)
            AdminForm.Show()
            Exit Sub
        End If

        If Students.ContainsKey(InputID) Then
            Dim Student = Students(InputID)
            tbxStudent.Text = Student.Name & "!"
            tbxCourse.Text = Student.Course
            tbxSchedule.Text = Student.Sched

            ' Display Lates/Absents
            Dim Late = If(LateCounts.ContainsKey(InputID), LateCounts(InputID), 0)
            Dim Absent = If(AbsentCounts.ContainsKey(InputID), AbsentCounts(InputID), 0)
            tbxLates.Text = Late.ToString()
            tbxAbsents.Text = Absent.ToString()

            ' IN/OUT logic
            If Not AttendanceLogs.ContainsKey(InputID) Then
                AttendanceLogs(InputID) = New List(Of String)
            End If

            Dim LogCount = AttendanceLogs(InputID).Count
            Dim status = If(LogCount Mod 2 = 0, "IN", "OUT")
            Dim CurrentTime = DateTime.Now
            AttendanceLogs(InputID).Add(CurrentTime.ToString("yyyy-MM-dd hh:mm tt") & " " & status)
            tbxInOut.Text = status
            tbxLogged.Text = CurrentTime.ToString("hh:mm tt")

            ' Check for Lates (Only for IN Status)
            If status = "IN" Then
                Dim SchedParts = Student.Sched.Split("-"c)
                If SchedParts.Length = 2 Then
                    Dim SchedStartStr = SchedParts(0).Trim()
                    Dim SchedEndStr = SchedParts(1).Trim()
                    Dim SchedStart As DateTime
                    Dim SchedEnd As DateTime
                    If DateTime.TryParse(SchedStartStr, SchedStart) AndAlso DateTime.TryParse(SchedEndStr, SchedEnd) Then
                        ' Mark absent if log-in is after scheduled end
                        Dim IsAbsent = False
                        If CurrentTime.TimeOfDay > SchedEnd.TimeOfDay Then
                            If Not AbsentCounts.ContainsKey(InputID) Then AbsentCounts(InputID) = 0
                            AbsentCounts(InputID) += 1
                            IsAbsent = True
                        End If
                        ' Late if more than 15 mins after sched start and not absent
                        If Not IsAbsent AndAlso CurrentTime.TimeOfDay > SchedStart.AddMinutes(15).TimeOfDay Then
                            If Not LateCounts.ContainsKey(InputID) Then LateCounts(InputID) = 0
                            LateCounts(InputID) += 1
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
        Dim DashOffsets As New List(Of Integer) From {4, 9, 11}

        For i As Integer = 0 To raw.Length - 1
            formatted &= raw(i)
            If DashOffsets.Contains(i + 1) AndAlso i <> raw.Length - 1 Then
                formatted &= "-"
            End If
        Next

        If tbxEnterID.Text <> formatted Then
            Dim AddedLength = formatted.Length - tbxEnterID.Text.Length
            tbxEnterID.Text = formatted
            cursorPos += AddedLength
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
        For Each s In Students
            lines.Add(s.Key & "|" & s.Value.Name & "|" & s.Value.Sched & "|" & s.Value.Course)
        Next
        IO.File.WriteAllLines("studentRecords.txt", lines)
    End Sub

    Private Sub SaveAttendance()
        ' Save Attendance Logs
        Dim lines As New List(Of String)
        For Each kvp In AttendanceLogs
            For Each log In kvp.Value
                lines.Add(kvp.Key & "|" & log)
            Next
        Next
        IO.File.WriteAllLines("attendance.txt", lines)

        ' Save Lates and Absents
        Dim laLines As New List(Of String)
        For Each id In Students.Keys
            Dim lates = If(LateCounts.ContainsKey(id), LateCounts(id), 0)
            Dim absents = If(AbsentCounts.ContainsKey(id), AbsentCounts(id), 0)
            laLines.Add(id & "|" & lates & "|" & absents)
        Next
        IO.File.WriteAllLines("lates_absents.txt", laLines)

        ' Save Updated Student Schedules (Optional Update if Needed)
        Dim StudentLines As New List(Of String)
        For Each kvp In Students
            StudentLines.Add(kvp.Key & "|" & kvp.Value.Name & "|" & kvp.Value.Course & "|" & kvp.Value.Sched)
        Next
        IO.File.WriteAllLines("studentRecords.txt", StudentLines)
    End Sub


End Class

