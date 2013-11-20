Public Class Form1

    ' Developed by Pablo Henrique P. Silva
    ' November 20th of 2013
    ' App. Development Class
    ' Morgan State University

    Dim dimension As Integer
    Dim arrayPanel(dimension, dimension) As Panel 'this matrix will be assigned after the variable 'dimension' is assigned. Metaprogramming.
    Dim counter As Integer = 0

    ' Ideas for future project: Use the Design Pattern Prototype to make copies of the objects used in the arrays.
    ' Using this pattern, the momery use will be decreased and all the panels will be created faster.

    ' Another idea is to reduce the iteractions finding "infected" houses. Find the best alternative for it
    ' Could use a QuickSort method based to reduce the number of interactions given a nested loop.
    ' Search for "O notation" or "Big O notation"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aux As String = InputBox("Insert a number for a dimension: ")
        If IsNumeric(Integer.Parse(aux)) Then
            dimension = Integer.Parse(aux)
        End If
        Dim arrayPanels(dimension, dimension) As Panel

        Dim width As Integer = 20
        Dim height As Integer = 20

        For row As Integer = 0 To dimension - 1
            For column As Integer = 0 To dimension - 1
                arrayPanels(row, column) = New Panel()
                arrayPanels(row, column).Location = New Point(width, height)
                arrayPanels(row, column).Size = New Size(20, 20)
                If Rnd() > 0.5 Then
                    arrayPanels(row, column).BackColor = Color.Blue
                Else
                    arrayPanels(row, column).BackColor = Color.Red
                    counter += 1
                End If
                width += 25
                Me.Controls.Add(arrayPanels(row, column))
            Next
            height += 25
            width = 20
        Next
        arrayPanel = arrayPanels
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For row As Integer = 0 To dimension - 1
            For column As Integer = 0 To dimension - 1
                Dim infected As Integer = 0
                If arrayPanel(row, column).BackColor = Color.Red Then
                    Continue For
                Else
                    If (row + 1) < dimension Then
                        If arrayPanel(row + 1, column).BackColor = Color.Red Then
                            infected += 1
                        End If
                    End If
                    If (row - 1) > -1 Then
                        If arrayPanel(row - 1, column).BackColor = Color.Red Then
                            infected += 1
                        End If
                    End If
                    If (column + 1) < dimension Then
                        If arrayPanel(row, column + 1).BackColor = Color.Red Then
                            infected += 1
                        End If
                    End If
                    If (column - 1) > -1 Then
                        If arrayPanel(row, column - 1).BackColor = Color.Red Then
                            infected += 1
                        End If
                    End If
                End If

                If infected >= 2 Then
                    arrayPanel(row, column).BackColor = Color.Red
                    counter += 1
                End If
            Next
        Next
        MessageBox.Show("Infected houses: " & counter)
    End Sub

    Private Sub setButtonPosition(sender As Object, e As EventArgs) Handles MyBase.MaximumSizeChanged
        Button1.Location = New Point(Me.Location.X, Button1.Location.Y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        counter = 0
        For row As Integer = 0 To dimension - 1
            For column As Integer = 0 To dimension - 1
                If Rnd() > 0.5 Then
                    arrayPanel(row, column).BackColor = Color.Blue
                Else
                    arrayPanel(row, column).BackColor = Color.Red
                    counter += 1
                End If
            Next
        Next
    End Sub
End Class
