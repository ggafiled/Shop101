Imports MySql.Data.MySqlClient

Public Class MngCustomer

    Dim _index As Integer = -1
    Dim row As DataGridViewRow

    Private Sub MngCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        ComboBox.SelectedIndex = 0
        getData_to_tatble()
        getToolLoad()
        _clear()
        txt_id.Text = generateCustomerID()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub MngCustomer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpenform.mngcustomer = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub getData_to_tatble()
        Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer`"
        DataGridView1.DataSource = QueryReturnDatatable(sql)
        DataGridView1.Refresh()
        DataGridView1.Columns(0).HeaderText = "รหัสลูกค้า"
        DataGridView1.Columns(1).HeaderText = "ชื่อลูกค้า"
        DataGridView1.Columns(2).HeaderText = "เบอร์โทรศัพท์(ติดต่อ)"
        DataGridView1.Columns(3).HeaderText = "ที่อยู่"
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        getToolSave()
        _clear()
        DataGridView1.Refresh()
        btn_edit.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Private Function generateCustomerID()
        Dim sql As String = "SELECT * FROM tbl_customer ORDER BY tbl_customer.Customer_ID DESC LIMIT 1"
        Dim code As String = "CS"
        Dim result As String = QueryGetID(sql, code)
        Return result
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _index = e.RowIndex
        If _index >= 0 Then
            row = DataGridView1.Rows(_index)
            Dim _id As String = row.Cells(0).Value.ToString
            Dim _name As String = row.Cells(1).Value.ToString
            Dim _address As String = row.Cells(3).Value.ToString
            Dim _tel As String = row.Cells(2).Value.ToString
            txt_id.Text = _id
            txt_name1.Text = _name
            txt_address.Text = _address
            txt_phone1.Text = _tel

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
        txt_name1.Enabled = True
        txt_address.Enabled = True
        txt_phone1.Enabled = True
    End Sub

    Private Sub getToolLoad()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        btn_add.Enabled = True
        txt_name1.Enabled = False
        txt_address.Enabled = False
        txt_phone1.Enabled = False
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        MngCustomer_Load(sender, e)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Dim sql = "INSERT INTO tbl_customer (Customer_ID, Customer_Name, Customer_Address, Customer_Tel) VALUES (@id,@name,@address,@tel)"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", txt_id.Text)
            cmd.Parameters.AddWithValue("@name", txt_name1.Text)
            cmd.Parameters.AddWithValue("@address", txt_address.Text)
            cmd.Parameters.AddWithValue("@tel", txt_phone1.Text)
            QueryNonReturn(cmd)
            getData_to_tatble()
            getToolLoad()
            _clear()
            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub _clear()
        txt_name1.Clear()
        txt_phone1.Clear()
        txt_address.Clear()
        txt_name1.Focus()
        txt_id.Text = generateCustomerID()
        _index = -1
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If _index <> -1 Then
                row = DataGridView1.Rows(_index)
                Dim _id As String = row.Cells(0).Value.ToString
                Dim sql = "UPDATE tbl_customer SET Customer_Name= @name,Customer_Address= @address,Customer_Tel= @tel WHERE Customer_ID=@id"
                Dim cmd As New MySqlCommand
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@id", _id)
                cmd.Parameters.AddWithValue("@name", txt_name1.Text)
                cmd.Parameters.AddWithValue("@address", txt_address.Text)
                cmd.Parameters.AddWithValue("@tel", txt_phone1.Text)
                QueryNonReturn(cmd)
                getData_to_tatble()
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

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If _index <> -1 Then
                If MessageBox.Show("ต้องการลบข้อมูลนี้จริงหรือไม่?", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                    row = DataGridView1.Rows(_index)
                    Dim _id As String = row.Cells(0).Value.ToString
                    Dim sql = "DELETE FROM tbl_customer WHERE Customer_ID=@id"
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@id", _id)
                    QueryNonReturn(cmd)
                    getData_to_tatble()
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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If ComboBox.SelectedIndex = 1 Then 'รหัส
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_ID` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        ElseIf ComboBox.SelectedIndex = 2 Then 'ชื่อ
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_Name` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        ElseIf ComboBox.SelectedIndex = 3 Then 'เบอร์โทร
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_Tel` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If ComboBox.SelectedIndex = 1 Then 'รหัส
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_ID` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        ElseIf ComboBox.SelectedIndex = 2 Then 'ชื่อ
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_Name` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        ElseIf ComboBox.SelectedIndex = 3 Then 'เบอร์โทร
            Dim sql As String = "SELECT `tbl_customer`.`Customer_ID` as 'รหัสลูกค้า',`tbl_customer`.`Customer_Name` as 'ชื่อลูกค้า',`tbl_customer`.`Customer_Tel` as 'เบอร์โทรศัพท์(ติดต่อ)',`tbl_customer`.`Customer_Address` as 'ที่อยู่' FROM `tbl_customer` WHERE `tbl_customer`.`Customer_Tel` LIKE '%" + txt_search.Text + "%'"
            DataGridView1.DataSource = QueryReturnDatatable(sql)
            DataGridView1.Refresh()
        End If
    End Sub

End Class