Public Class Tasks
    Dim type As item
    Public Sub Add(type As item, ByVal t As String, ByVal h As String, ByVal d As String)
        Me.type = type
        Subtitle.Text = t
        Subhead.Text = h
        Subdetail.Text = d
        If type = item.checkout Then
            SeparatorMain.LineColor = Color.FromArgb(231, 74, 74)
        End If
        If type = item.notpayment Then
            SeparatorMain.LineColor = Color.FromArgb(247, 223, 48)
        End If
        If type = item.reserve Then
            SeparatorMain.LineColor = Color.FromArgb(101, 45, 144)
        End If
    End Sub

    Public Enum item
        checkout
        reserve
        notpayment
        normal
    End Enum

    Private Sub Tasks_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, SeparatorMain.MouseMove, SeparatorSplit.MouseMove, Subdetail.MouseMove, Subhead.MouseMove, Subtitle.MouseMove, PictureStatus.MouseMove
        Me.BackColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Tasks_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, SeparatorMain.MouseLeave, SeparatorSplit.MouseLeave, Subdetail.MouseLeave, Subhead.MouseLeave, Subtitle.MouseLeave, PictureStatus.MouseLeave
        Me.BackColor = Color.FromArgb(241, 244, 253)
    End Sub

End Class
