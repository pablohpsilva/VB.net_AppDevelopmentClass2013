Public Class Assignment2

    Private Sub btnExA_Click(sender As Object, e As EventArgs) Handles btnExA.Click
        If IsNumeric(tboxExA.Text) Then
            lblExA.Text = Math.Pow(Double.Parse(tboxExA.Text), 2)
        Else
            lblExA.Text = "Numbers only"
        End If
    End Sub

    Private Sub sayDay(sender As System.Object, e As System.EventArgs) Handles rbtnExBSunday.CheckedChanged, rbtnExBMonday.CheckedChanged, rbtnExBTuesday.CheckedChanged, rbtnExBWednesday.CheckedChanged, rbtnExBThursday.CheckedChanged, rbtnExBFriday.CheckedChanged, rbtnExBSaturday.CheckedChanged
        Dim this As RadioButton = sender
        Dim weekdays() As String = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        If this.Text <> "" Then
            If this.Checked = True Then
                MessageBox.Show(weekdays.GetValue(Integer.Parse(this.Text) - 1))
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = InputBox("Enter something")
        Dim result As String = ""
        While input.ToLower <> "x"
            result = result & input
            input = InputBox("Enter something")
        End While
        lblExC.Text = result
    End Sub

    Private Sub prompInput(sender As Object, e As EventArgs) Handles TabPage4.Click
beginning:
        Dim input As String = InputBox("How many character you want to input?")
        If IsNumeric(input) Then
            Dim times As Integer = Integer.Parse(input)
            Dim aux As String = ""
            For index As Integer = 1 To times
                aux = aux & InputBox("Enter a character")
                aux = aux & ";"
            Next
            Dim result As String = ""
            For Each index As String In aux.Split(";")
                result = result & index & index & index & index & index
            Next
            MessageBox.Show(result & "!")
        Else
            MessageBox.Show("Only numbers, please... Let's start over.")
            GoTo beginning
        End If
    End Sub

    Private Sub btnExE_Click(sender As Object, e As EventArgs) Handles btnExE.Click
        Dim vector As Array = {0, 0, 0}
        '10,100,1000,10000,100000,1000000,1000000
        For Each index In tboxExE.Text.Trim().Split(",")
            If IsNumeric(index) Then
                Dim aux As Integer = Integer.Parse(index)
                If aux <= 10000 Then
                    vector.SetValue(1 + vector.GetValue(0), 0)
                ElseIf aux > 10000 And aux <= 100000 Then
                    vector.SetValue(1 + vector.GetValue(1), 1)
                ElseIf aux > 100000 Then
                    vector.SetValue(1 + vector.GetValue(2), 2)
                End If
            End If
        Next
        MessageBox.Show(vector.GetValue(0) & " small town(s), " & vector.GetValue(1) & " medium town(s), " & vector.GetValue(2) & " large town(s)")
    End Sub

    Private Sub btnExtra1_Click(sender As Object, e As EventArgs) Handles btnExtra1.Click
        If IsNumeric(tboxExtra1A.Text) Then
            If IsNumeric(tboxExtra1B.Text) Then
                Dim x As Double = tboxExtra1A.Text
                Dim y As Double = tboxExtra1B.Text
                Dim Min As Double
                Dim Max As Double
                If x >= y Then
                    Min = y
                    Max = x
                ElseIf y >= x Then
                    Min = x
                    Max = y
                End If
                Dim Generator As System.Random = New System.Random()
                lblExtra1.Text = Generator.Next(Min, Max)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
beginning:
        Dim input As String = InputBox("How many character you want to input?")
        If IsNumeric(input) Then
            Dim times As Integer = Integer.Parse(input)
            Dim aux As String = ""
            Dim result As String = ""
            For index As Integer = 1 To times
                aux = InputBox("Enter a character")
                For i As Integer = 1 To 5
                    result &= aux
                Next
            Next
            MessageBox.Show(result & "!")
        Else
            MessageBox.Show("Only numbers, please... Let's start over.")
            GoTo beginning
        End If
    End Sub
End Class
