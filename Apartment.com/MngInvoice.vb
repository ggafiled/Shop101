Public Class MngInvoice

    Private Sub MngInvoice_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpenform.mnginvoice = False
    End Sub

    Private Sub MngInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_clear.Enabled = False
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class