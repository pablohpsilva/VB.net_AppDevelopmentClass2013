Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim test(0) As Integer
        'For index As Integer = 0 To 2
        test(0) = 1
        'Next
        'For index As Integer = 0 To 2
        MessageBox.Show(test(0).ToString())
        'Next
    End Sub
End Class
