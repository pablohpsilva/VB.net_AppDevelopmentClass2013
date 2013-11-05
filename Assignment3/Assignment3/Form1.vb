Imports System
Imports System.Timers
Public Class Form1

    '
    ' Create 2 arrays.
    '   First: Q, R, T, U, V
    '   Second: P, S, V
    ' Every time I un/check a checkbox I should update the arrays
    ' Every time I un/check a checkbox I check the path before it to see if its all 
    ' Open (checked) or Close (unchecked).

    Public counter As Integer = 0
    Public rabbits As Integer
    Public wolves As Integer
    Public vetor As Array = {"xx", "yx", "xy", "yy"}
    Dim aTimer As System.Timers.Timer = New System.Timers.Timer(10000)

    Private Sub checkPipesQ(sender As Object, e As EventArgs) Handles cboxE1Q.CheckedChanged
        Dim farms As String = ""
        If cboxE1Q.Checked = False Then
            farms &= "A, B"
            If cboxE1T.Checked = False Then
                farms &= ", D"
            End If
            MessageBox.Show("Farm(s) " & farms & " was(were) affected")
        End If
    End Sub

    Private Sub checkPipes(sender As Object, e As EventArgs) Handles cboxE1R.CheckedChanged, cboxE1U.CheckedChanged, cboxE1V.CheckedChanged, cboxE1S.CheckedChanged
        Dim farms As String = ""
        Dim this As CheckBox = sender
        If this.Checked = False Then
            If this.Text = "R" Then
                farms &= "A"
            ElseIf this.Text = "U" Then
                farms &= "B"
            ElseIf this.Text = "V" Then
                farms &= "D"
            ElseIf this.Text = "S" Then
                farms &= "C"
            End If
            MessageBox.Show("Farm(s) " & farms & " was(were) affected")
        End If
    End Sub

    Private Sub checkPipesP(sender As Object, e As EventArgs) Handles cboxE1P.CheckedChanged
        Dim farms As String = ""
        If cboxE1P.Checked = False Then
            farms &= "C"
            If cboxE1T.Checked = False Then
                farms &= ", D"
            End If
            MessageBox.Show("Farm(s) " & farms & " was(were) affected")
        End If
    End Sub

    Private Sub btnEx2_Click(sender As Object, e As EventArgs) Handles btnEx2.Click
        If IsNumeric(tBoxEx2A.Text) And IsNumeric(tBoxEx2B.Text) Then
            rabbits = Integer.Parse(tBoxEx2A.Text)
            wolves = Integer.Parse(tBoxEx2B.Text)
            If rabbits > 0 And wolves > 0 Then
                AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
                aTimer.Interval = 8000
                aTimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        counter += 1
        If rabbits <= 0 Or wolves <= 0 Then
            aTimer.Enabled = False
            MessageBox.Show("Done!")
            Return
        End If
        If (counter Mod 3 = 0) Then
            wolves -= 1
            MessageBox.Show("One wolf died")
        End If
        rabbits += 30
        MessageBox.Show("30 more little rabbits were born! Total: " & rabbits)
        wolves += (wolves * 0.1)
        MessageBox.Show("10% more wolves were born! Total: " & wolves)
        rabbits -= wolves * 2
        MessageBox.Show("Wolves have to eat! There are " & rabbits & " rabbits left")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(vetor.GetValue(CInt(Math.Ceiling(Rnd() * 4)) - 1).ToString())
    End Sub
End Class
