Public Class MngAdvice
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngAdvice_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngadvice = False
    End Sub

    Private Sub MngAdvice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
    End Sub
End Class