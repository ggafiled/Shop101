Public Class MngRealinvoice
    Private Sub MngRealinvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_month.Text = tanfomdate(Now.Month)
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_clear.Enabled = False
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngRealinvoice_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngrealinvoice = False
    End Sub

End Class