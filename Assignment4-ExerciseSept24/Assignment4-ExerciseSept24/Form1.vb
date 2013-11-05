Public Class Form1

    Public intArray As New ArrayList()
    Public doubleArray As New ArrayList()
    Public stringArray As New ArrayList()

    Private Sub fillArrays(sender As Object, e As EventArgs) Handles btnEx1A.Click, btnEx1B.Click, btnEx1C.Click
        Dim this As Button = sender
        If this.Tag.ToString() = "1" Then
            For Each elem In txtEx1A.Text.Trim.Split(",")
                If IsNumeric(elem) Then
                    intArray.Add(Convert.ToInt32(elem))
                End If
            Next
        ElseIf this.Tag.ToString() = "2" Then
            For Each elem In txtEx1B.Text.Trim.Split(",")
                If IsNumeric(elem) Then
                    doubleArray.Add(Convert.ToDouble(elem))
                End If
            Next
        Else
            Dim input As String = InputBox("Add a string in an array (tipe x to exit)")
            While input.ToLower() <> "x"
                stringArray.Add(input)
                txtEx1C.Text &= input & ","
                input = InputBox("Add a string in an array (tipe x to exit)")
            End While
        End If
    End Sub

    Private Sub btnEx2A_Click(sender As Object, e As EventArgs) Handles btnEx2A.Click
        If txtEx2A.Text <> "" Then
            If IsNumeric(txtEx2A.Text) Then
                Dim number As Double = Double.Parse(txtEx2A.Text)
                If number Mod 23 = 0 Then
                    MessageBox.Show("Bingo")
                ElseIf number Mod 2 = 0 Then
                    MessageBox.Show("Even")
                Else
                    MessageBox.Show("Odd number")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input As String = InputBox("Insert a number (press x to exit)")
        Dim aux As Double
        While input.ToLower() <> "x"
            If IsNumeric(input) Then
                aux = Double.Parse(input)
                If aux >= 101 Or aux <= 200 Then
                    aux -= 5
                End If
                If aux > 100 Then
                    aux += aux * 0.1
                End If
            End If
            txtEx4A.Text &= aux.ToString() & ","
            input = InputBox("Insert a number (press x to exit)")
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = InputBox("Insert the raw ticket value:")
        If IsNumeric(input) Then
            Dim aux As Double = Double.Parse(input)
            lblEx5A.Text = (aux * 0.11).ToString()
            lblEx5B.Text = "25"
            lblEx5C.Text = (aux * 0.5)
            lblEx5D.Text = (aux + (aux * 0.11) + 25 + (aux * 0.5)).ToString()
        End If
    End Sub

    Private Sub btnEx3_Click(sender As Object, e As EventArgs) Handles btnEx3.Click
        If intArray.Count <> 0 And doubleArray.Count <> 0 Then
            Dim min As New ArrayList()
            Dim max As New ArrayList()
            Dim conc1 As New ArrayList()
            Dim conc2 As New ArrayList()
            If intArray.Count > doubleArray.Count Then
                min.AddRange(doubleArray)
                max.AddRange(intArray)
            Else
                min.AddRange(intArray)
                max.AddRange(doubleArray)
            End If

            Dim result As Double = 0

            For counter As Integer = 0 To min.Count - 1
                result += Convert.ToDouble(min.Item(counter)) + Convert.ToDouble(max.Item(counter))
            Next

            txtEx3A.Text = result
            conc1.AddRange(stringArray)
            conc1.AddRange(intArray)

            For Each elem In conc1
                txtEx3B.Text &= elem.ToString()
            Next

            conc2.AddRange(stringArray)
            conc2.AddRange(doubleArray)

            For Each elem In conc2
                txtEx3C.Text &= elem.ToString()
            Next

        End If
    End Sub
End Class
