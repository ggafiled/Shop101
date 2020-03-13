Imports MySql.Data.MySqlClient

Public Class MngCategory

    Private edit As Boolean = False
    Dim _index As Integer = -1
    Dim row As DataGridViewRow
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngTyperoom_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngcategory = False
    End Sub

    Private Sub disableControl()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        txt_id.Enabled = False
        txt_name.Enabled = False
    End Sub

    Private Sub MngTyperoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        getToolLoad()
        _clear()
        Call disableControl()
        Call showdata()
        Call getid()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub getToolLoad()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        btn_add.Enabled = True
        txt_id.Enabled = False
        txt_name.Text = False
    End Sub

    Private Sub _clear()
        txt_name.Clear()
        getid()
        txt_name.Focus()
        _index = -1
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT `Category_ID` as 'รหัสสินค้า', `Category_Name` as 'ชื่อประเภทสินค้า' FROM tbl_category")
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ประเภทสินค้า"
    End Sub

    Private Sub getid()
        txt_id.Text = QueryGetID("SELECT * FROM tbl_category ORDER BY Category_ID DESC LIMIT 1", "CT")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        getToolSave()
        _clear()
        DataGridView1.Refresh()
        btn_edit.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        MngTyperoom_Load(sender, e)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If _index <> -1 Then
                row = DataGridView1.Rows(_index)
                Dim _id As String = row.Cells(0).Value.ToString
                Dim sql = "UPDATE tbl_category SET Category_Name= @name WHERE Category_ID=@id"
                Dim cmd As New MySqlCommand
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@id", _id)
                cmd.Parameters.AddWithValue("@name", txt_name.Text)
                QueryNonReturn(cmd)
                getid()
                getToolLoad()
                _clear()
                showdata()
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("กรุณาเลือกหมายเลขลูกค้าที่ต้องการลบค่ะ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _index = e.RowIndex
        If _index >= 0 Then
            row = DataGridView1.Rows(_index)
            Dim _id As String = row.Cells(0).Value.ToString
            Dim _name As String = row.Cells(1).Value.ToString
            txt_id.Text = _id
            txt_name.Text = _name
            getToolSave()
            btn_save.Enabled = False
        End If
    End Sub

    Private Sub getToolSave()
        btn_save.Enabled = True
        btn_edit.Enabled = True
        btn_delete.Enabled = True
        btn_clear.Enabled = True
        btn_add.Enabled = False
        txt_name.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Dim sql = "INSERT INTO tbl_category (Category_ID, Category_Name) VALUES (@id,@name)"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", txt_id.Text)
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            QueryNonReturn(cmd)
            getid()
            getToolLoad()
            _clear()
            showdata()
            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If _index <> -1 Then
                If MessageBox.Show("ต้องการลบข้อมูลนี้จริงหรือไม่?", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                    row = DataGridView1.Rows(_index)
                    Dim _id As String = row.Cells(0).Value.ToString
                    Dim sql = "DELETE FROM tbl_category WHERE Category_ID=@id"
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@id", _id)
                    QueryNonReturn(cmd)
                    showdata()
                    getToolLoad()
                    _clear()
                    showdata()
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Try
                End If
            Else
                MessageBox.Show("กรุณาเลือกหมายเลขลูกค้าที่ต้องการลบค่ะ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
