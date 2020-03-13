Imports MySql.Data.MySqlClient

Public Class MngProduct

    Dim _index As Integer = -1
    Dim row As DataGridViewRow
    Public _catagoryID As String = ""
    Public _catagoryNAME As String = ""
    Dim _findProduct = New FindProduct
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngBuypackget_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngsaleProduct = False
    End Sub

    Private Sub MngBuypackget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        getToolLoad()
        _clear()
        Call showdata()
        Call getid()
        txt_type.Text = _catagoryID
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub getToolLoad()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        btn_add.Enabled = True
        txt_id.Enabled = False
        txt_name.Enabled = False
        txt_type.Enabled = False
        txt_price.Enabled = False
        btn_select.Enabled = False
    End Sub

    Private Sub _clear()
        txt_price.Clear()
        txt_type.Clear()
        txt_name.Clear()
        getid()
        txt_name.Focus()
        _index = -1
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT tbl_product.Product_ID as 'รหัสสินค้า', tbl_product.Product_Name as 'ชื่อสินค้า', tbl_product.Product_Sprice as 'ราคาต่อหน่วย', tbl_category.Category_Name as 'ประเภทสินค้า' FROM tbl_product INNER JOIN tbl_category ON tbl_product.Category_ID = tbl_category.Category_ID")
        DataGridView1.Columns(0).HeaderText = "รหัสสินค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อสินค้า"
        DataGridView1.Columns(2).HeaderText = "ราคาต่อหน่วย"
        DataGridView1.Columns(3).HeaderText = "ประเภทสินค้า"
    End Sub

    Private Sub getid()
        txt_id.Text = QueryGetID("SELECT * FROM tbl_product ORDER BY Product_ID DESC LIMIT 1", "PD")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _index = e.RowIndex
        If _index >= 0 Then
            row = DataGridView1.Rows(_index)
            Dim _id As String = row.Cells(0).Value.ToString
            Dim _name As String = row.Cells(1).Value.ToString
            Dim _type As String = row.Cells(3).Value.ToString
            Dim _price As String = row.Cells(2).Value.ToString
            txt_id.Text = _id
            txt_name.Text = _name
            txt_type.Text = _type
            txt_price.Text = _price
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
        txt_type.Enabled = True
        txt_price.Enabled = True
        btn_select.Enabled = True
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        getToolSave()
        _clear()
        DataGridView1.Refresh()
        btn_edit.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Dim sql = "INSERT INTO tbl_product (Product_ID, Product_Name, Product_Sprice, Category_ID) VALUES (@id,@name,@sprice,@cat)"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", txt_id.Text)
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@sprice", txt_price.Text)
            cmd.Parameters.AddWithValue("@cat", _catagoryID)
            QueryNonReturn(cmd)
            showdata()
            getToolLoad()
            _clear()
            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If _index <> -1 Then
                row = DataGridView1.Rows(_index)
                Dim _id As String = row.Cells(0).Value.ToString
                Dim sql = "UPDATE tbl_product SET Product_Name= @name,Product_Sprice= @sprice,Category_ID= @cat WHERE Product_ID=@id"
                Dim cmd As New MySqlCommand
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@id", _id)
                cmd.Parameters.AddWithValue("@name", txt_name.Text)
                cmd.Parameters.AddWithValue("@sprice", txt_price.Text)
                cmd.Parameters.AddWithValue("@cat", _catagoryID)
                QueryNonReturn(cmd)
                showdata()
                getToolLoad()
                _clear()
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("กรุณาเลือกหมายเลขลูกค้าที่ต้องการลบค่ะ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If _index <> -1 Then
                If MessageBox.Show("ต้องการลบข้อมูลนี้จริงหรือไม่?", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                    row = DataGridView1.Rows(_index)
                    Dim _id As String = row.Cells(0).Value.ToString
                    Dim sql = "DELETE FROM tbl_product WHERE Product_ID=@id"
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@id", _id)
                    QueryNonReturn(cmd)
                    showdata()
                    getToolLoad()
                    _clear()
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

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        MngBuypackget_Load(sender, e)
    End Sub

    Private Sub Btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Try
            _findProduct.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class