Public Class MngScopeAdvice
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngScopeAdvice_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngscopeadvice = False
    End Sub

    Private Sub MngScopeAdvice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
    End Sub
End Class