Public Class MngOrder
    Private edit As Boolean = False
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngBuilding_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngorder = False
    End Sub

    Private Sub MngBuilding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripHeader.Renderer = New CustomTool
        Call disableControl()
        Call showdata()
        Call getID()
    End Sub

    Private Sub disableControl()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = True
        txt_id.Enabled = False
        txt_name.Enabled = False
        txt_address.Enabled = False
        txt_water.Enabled = False
        txt_elec.Enabled = False
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT * FROM tbl_building")
        Call headdata()
    End Sub

    Private Sub headdata()
        DataGridView1.Columns(0).HeaderText = "รหัสตึก"
        DataGridView1.Columns(1).HeaderText = "ชื่อตึก/อาคาร"
        DataGridView1.Columns(2).HeaderText = "ตำแหน่งที่ตั้ง"
        DataGridView1.Columns(3).HeaderText = "อัตราค่าน้ำ"
        DataGridView1.Columns(4).HeaderText = "อัตราค่าไฟ"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            txt_id.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txt_name.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txt_address.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txt_water.Text = String.Format(DataGridView1.Rows(e.RowIndex).Cells(3).Value, "0.00")
            txt_elec.Text = String.Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0.00")
            btn_add.Enabled = False
            btn_save.Enabled = False
            btn_edit.Enabled = True
            btn_delete.Enabled = True
            btn_clear.Enabled = True
            txt_id.Enabled = False
            txt_name.Enabled = False
            txt_address.Enabled = False
            txt_water.Enabled = False
            txt_elec.Enabled = False
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_clear_Click(sender, e)
        btn_add.Enabled = False
        btn_save.Enabled = True
        btn_clear.Enabled = True
        txt_name.Enabled = True
        txt_address.Enabled = True
        txt_water.Enabled = True
        txt_elec.Enabled = True
        txt_name.Focus()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = False
        txt_name.Clear()
        txt_address.Clear()
        txt_water.Text = "0.00"
        txt_elec.Text = "0.00"
        txt_name.Enabled = False
        txt_id.Enabled = False
        txt_elec.Enabled = False
        txt_address.Enabled = False
        txt_water.Enabled = False
        txt_name.Focus()
        edit = False
        Call getID()
    End Sub

    Private Sub getID()
        txt_id.Text = QueryGetID("SELECT building_id FROM tbl_building Order by building_id DESC", "BD")
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        txt_name.Enabled = True
        txt_address.Enabled = True
        txt_water.Enabled = True
        txt_elec.Enabled = True
        btn_edit.Enabled = False
        btn_add.Enabled = False
        edit = True
        btn_save.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not edit Then
            Dim sql As String = "INSERT INTO tbl_building VALUES ('{0}','{1}','{2}','{3}','{4}')"
            sql = String.Format(sql, txt_id.Text, txt_name.Text, txt_address.Text, txt_water.Text, txt_elec.Text)
            QueryNonReturn(sql)
            Call showdata()
            btn_add_Click(sender, e)
        Else
            Dim sql As String = "UPDATE tbl_building SET building_name='{0}',building_address='{1}',building_ratewater='{2}',building_rateelec='{3}' WHERE building_id='{4}'"
            sql = String.Format(sql, txt_name.Text, txt_address.Text, txt_water.Text, txt_elec.Text, txt_id.Text)
            QueryNonReturn(sql)
            Call showdata()
        End If
        edit = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql As String = "Delete FROM tbl_building WHERE building_id ='{0}'"
        sql = String.Format(sql, txt_id.Text)
        QueryNonReturn(sql)
        Call showdata()
        btn_clear_Click(sender, e)
    End Sub

End Class