Public Class MngPromise
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngPromise_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngpromise = False
    End Sub

    Private Sub btn_selectroom_Click(sender As Object, e As EventArgs) Handles btn_selectroom.Click
        Dim new_room As New FindRoom
        new_room.Show()
    End Sub

    Private Sub btn_selectcustomer_Click(sender As Object, e As EventArgs) Handles btn_selectcustomer.Click
        Dim new_reserve As New FindReserve
        new_reserve.Show()
    End Sub

    Private Sub MngPromise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
    End Sub
End Class