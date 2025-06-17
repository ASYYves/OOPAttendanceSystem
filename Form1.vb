Public Class Form1

    Private students As New Dictionary(Of String, (Name As String, Sched As String, Course As String))

    Private Sub StudentData(Sender As Object, e As EventArgs) Handles MyBase.Load


        students.Add("2023-00339-BN-0", ("Yves Carranza", "7:00 AM", "BSIT"))


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxEnterID.Focus()
        tbxEnterID.SelectAll()
    End Sub

    Private Sub txbEnterID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxEnterID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnterId.PerformClick() ' Simulates button click
            e.Handled = True
            e.SuppressKeyPress = True ' Prevents ding sound
        End If
    End Sub

    Private Sub btnEnterId_Click(sender As Object, e As EventArgs) Handles btnEnterId.Click


        Dim inputID As String = tbxEnterID.Text.Trim().ToUpper


        If students.ContainsKey(inputID) Then


            Dim student = students(inputID)


            tbxStudent.Text = "Welcome " & student.Name & "!"

            tbxCourse.Text = "Course: " & student.Course

            tbxInOut.Text = "IN"

            tbxSchedule.Text = student.Sched

            tbxLogged.Text = DateTime.Now.ToString("hh:mm:tt")


        Else

            tbxStudent.Text = "ID NOT RECOGNIZED"

            tbxCourse.Text = ""

            tbxInOut.Text = ""

            tbxSchedule.Text = ""

            tbxLogged.Text = ""

        End If

        tbxEnterID.Focus()
        tbxEnterID.SelectAll()

    End Sub

    Private Sub txbEnterID_TextChanged(sender As Object, e As EventArgs) Handles tbxEnterID.TextChanged
        ' Store current cursor position
        Dim cursorPos As Integer = tbxEnterID.SelectionStart
        Dim raw = tbxEnterID.Text.Replace("-", "").ToUpper()

        ' Auto-format input as XXXX-XXXXX-XX-X
        If raw.Length > 13 Then raw = raw.Substring(0, 13)

        Dim formatted As String = ""
        Dim dashOffsets As New List(Of Integer) From {4, 9, 11} ' Dash positions

        For i As Integer = 0 To raw.Length - 1
            formatted &= raw(i)
            If dashOffsets.Contains(i + 1) AndAlso i <> raw.Length - 1 Then
                formatted &= "-"
            End If
        Next

        ' Only update if changed
        If tbxEnterID.Text <> formatted Then
            Dim addedLength = formatted.Length - tbxEnterID.Text.Length
            tbxEnterID.Text = formatted

            ' Adjust cursor position
            cursorPos += addedLength
            If cursorPos < 0 Then cursorPos = 0
            If cursorPos > formatted.Length Then cursorPos = formatted.Length

            tbxEnterID.SelectionStart = cursorPos
        End If
    End Sub

    Private Sub txbEnterID_GotFocus(sender As Object, e As EventArgs) Handles tbxEnterID.GotFocus
        tbxEnterID.SelectAll()
    End Sub

End Class
