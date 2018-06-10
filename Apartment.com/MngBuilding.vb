Public Class MngBuilding
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngBuilding_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngbuilding = False
    End Sub

    Private Sub MngBuilding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
    End Sub
End Class