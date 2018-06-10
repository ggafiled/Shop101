Public Class InfoAboutDevelop
    Private Sub imgExit_MouseHover(sender As Object, e As EventArgs) Handles imgExit.MouseHover
        imgExit.Image = My.Resources.remove
    End Sub

    Private Sub imgExit_MouseLeave(sender As Object, e As EventArgs) Handles imgExit.MouseLeave
        imgExit.Image = My.Resources.remove_symbol
    End Sub

    Private Sub imgExit_Click(sender As Object, e As EventArgs) Handles imgExit.Click
        Me.Close()
    End Sub

    Private Sub InfoAboutDevelop_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mnginfoaboutdevelop = False
    End Sub
End Class