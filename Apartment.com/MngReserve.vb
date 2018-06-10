Public Class MngReserve
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim new_findroom As New FindRoom
        new_findroom.ShowDialog()
    End Sub

    Private Sub MngReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        btn_select.Enabled = False
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_select.Enabled = True
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngReserve_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngreserve = False
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        txt_search.Focus()
    End Sub
End Class