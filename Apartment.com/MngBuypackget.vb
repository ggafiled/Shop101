Public Class MngBuypackget
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngBuypackget_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngbuypackget = False
    End Sub

    Private Sub MngBuypackget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
    End Sub
End Class