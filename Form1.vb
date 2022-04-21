Public Class Form1
    Private Sub cmdWake_Click(sender As Object, e As EventArgs) Handles cmdWake.Click
        'loop variable
        Dim i As Integer
        Dim intTimes As Integer = cboTimes.SelectedItem

        cboTimes.Focus()
        lstOut.Items.Clear()
        For i = 1 To intTimes
            lstOut.Items.Add("Wake Up !")

        Next i

    End Sub
End Class
