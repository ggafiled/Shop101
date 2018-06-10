Public Class MngMoveout
    Private Sub MngMoveout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateOut.Value = DateAdd(DateInterval.Day, 30, DateMake.Value)
        ComboBoxStatus.SelectedIndex = 0
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub MngMoveout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpenform.mngmoveout = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class