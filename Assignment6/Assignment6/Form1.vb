Public Class Form1

    Dim arrayString(9) As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblTarget.Text = "Result:"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index As Integer = 0 To arrayString.Length - 1
            arrayString(index) = index
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblTarget.Text &= "  |  "
        For index As Integer = 0 To arrayString.Length - 1
            lblTarget.Text &= arrayString(index) & "  |  "
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblTarget.Text &= "  |  "
        For Each elem As String In arrayString
            lblTarget.Text &= elem & "  |  "
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            For Each elem As String In arrayString
                If elem.Equals(TextBox1.Text) Then
                    MessageBox.Show("Bingo!")
                    Return
                End If
            Next
        End If
    End Sub

    '******************************
    '*******   PSEUDO-CODE   ******
    '******************************
    ' MinMax(Integer min, Integer max, Array elems)
    ' Integer aux
    ' For index = 0; index < length(elems); index++
    '   aux = elems(index)
    '   if index = 0
    '      max = aux
    '      min = aux
    '   else
    '      if aux > max
    '         max = aux
    '      else if aux < min
    '         min = aux

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim min As Integer
        Dim max As Integer
        Dim aux As Integer
        For index As Integer = 0 To arrayString.Length - 1
            aux = Integer.Parse(arrayString(index))
            If index = 0 Then
                min = aux
                max = aux
            Else
                If aux > max Then
                    max = aux
                ElseIf aux < min Then
                    min = aux
                End If
            End If
        Next
        MessageBox.Show("Minimum: " & min & "    |    Maximum: " & max)
    End Sub
End Class
