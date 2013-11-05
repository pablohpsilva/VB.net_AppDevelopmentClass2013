Public Class Form1

    Dim vetor As String() = {"", "", "", "", "", "", "", ""}

    Private Sub ChangeResult(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        Dim this As TextBox = sender
        If this.Equals(TextBox1) And TextBox1.Text <> "" Then
            Label1.Text = ""
            Label1.Text &= TextBox1.Text
            If TextBox2.Text <> "" Then
                Label1.Text &= TextBox2.Text
            End If
        ElseIf TextBox2.Text <> "" Then
            Label1.Text = ""
            If TextBox1.Text <> "" Then
                Label1.Text &= TextBox1.Text
            End If
            Label1.Text &= TextBox2.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = InputBox("Insira um numero")
        If IsNumeric(input) Then
            Dim aux As Double = Double.Parse(input)
            If aux > 0 And aux < 10 Then
                MessageBox.Show("It's bigger than zero and smallest than ten.")
            ElseIf aux <= 0 Or aux >= 10 Then
                MessageBox.Show("It's not in zero to ten range.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Double = 0.0
        Dim aux As String
        For index As Integer = 1 To 3
            aux = InputBox("Insert a number")
            If IsNumeric(aux) Then
                result += Double.Parse(aux)
            Else
                index -= 1
                If index < 1 Then
                    index = 1
                End If
            End If
        Next
        MessageBox.Show(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim stopper As Boolean = True
        While stopper
            If InputBox("If you type anything besides OK, this window will insist in pop up").ToLower() = "ok" Then
                stopper = False
            End If
        End While
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim array As Array = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6}
        Dim result As Integer = 0
        Dim aux As CheckBox
        For Each elem In array
            aux = elem
            If aux.Checked Then
                result += Integer.Parse(aux.Text)
            End If
        Next
        MessageBox.Show(result)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim array As Array = {lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7}
        For index As Integer = 0 To 7
            If (index Mod 2) <> 0 And vetor.GetValue(index) = "" Then
                vetor.SetValue(InputBox("Insert anything"), index)
                Dim aux As Label = array.GetValue(index)
                aux.Text = vetor.GetValue(index)
                Return
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label9.Text = Conversion.Int(Math.Ceiling(Rnd() * 6))
        Label10.Text = Conversion.Int(Math.Ceiling(Rnd() * 6))
    End Sub
End Class
