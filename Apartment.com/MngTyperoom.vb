Public Class MngTyperoom
    Private edit As Boolean = False
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngTyperoom_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngtyperoom = False
    End Sub

    Private Sub headdata()
        DataGridView1.Columns(0).HeaderText = "รหัส"
        DataGridView1.Columns(1).HeaderText = "ชื่อประเภท"
        DataGridView1.Columns(2).HeaderText = "ราคา"
        DataGridView1.Columns(3).HeaderText = "ค่าประกัน"
    End Sub


    Private Sub disableControl()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        txt_id.Enabled = False
        txt_name.Enabled = False
        txt_price.Enabled = False
        txt_deposit.Enabled = False
    End Sub

    Private Sub MngTyperoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call disableControl()
        Call showdata()
        Call getid()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT * FROM tbl_typeroom")
        Call headdata()
    End Sub

    Private Sub getid()
        txt_id.Text = QueryGetID("SELECT typeroom_id FROM tbl_typeroom Order by typeroom_id DESC", "TY")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = True
        btn_clear.Enabled = True
        txt_id.Enabled = False
        txt_name.Enabled = True
        txt_price.Enabled = True
        txt_deposit.Enabled = True
        edit = False
        txt_name.Clear()
        txt_price.Clear()
        txt_deposit.Clear()
        txt_name.Focus()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        getid()
        txt_name.Clear()
        txt_price.Clear()
        txt_deposit.Clear()
        edit = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_add.Enabled = True
        btn_save.Enabled = False
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        txt_id.Enabled = True
        txt_name.Enabled = True
        txt_price.Enabled = True
        txt_deposit.Enabled = True
        btn_edit.Enabled = False
        btn_add.Enabled = False
        edit = True
        btn_save.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btn_add.Enabled = False
        btn_save.Enabled = False
        btn_edit.Enabled = True
        btn_delete.Enabled = True
        btn_clear.Enabled = True
        txt_id.Enabled = False
        txt_name.Enabled = False
        txt_price.Enabled = False
        txt_deposit.Enabled = False
        txt_id.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_name.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_price.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_deposit.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not edit Then
            Dim sql As String = "INSERT INTO tbl_typeroom VALUES (" + "'" + txt_id.Text + "'" + "," + "'" + txt_name.Text + "'" + "," + "'" + txt_price.Text + "'" + "," + "'" + txt_deposit.Text + "'" + ")"
            QueryNonReturn(sql)
            Call showdata()
            btn_add_Click(sender, e)
        Else
            Dim sql As String = "UPDATE tbl_typeroom SET typeroom_name =" + "'" + txt_name.Text + "'" + ", typeroom_price=" + "'" + txt_price.Text + "'" + ", typeroom_deposit=" + "'" + txt_deposit.Text + "'" + " WHERE typeroom_id=" + "'" + txt_id.Text + "'"
            QueryNonReturn(sql)
            Call showdata()
        End If
        edit = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql As String = "Delete FROM tbl_typeroom WHERE typeroom_id =" + "'" + txt_id.Text + "'"
        QueryNonReturn(sql)
        Call showdata()
        btn_clear_Click(sender, e)
    End Sub

End Class
