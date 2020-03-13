Imports MySql.Data.MySqlClient

Public Class MngSaleProduct

    Dim dt As New DataTable
    Dim dtCus As New DataTable
    Dim sum As Double = 0
    Dim _index As Integer = -1
    Dim row As DataGridViewRow
    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MngPackget_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngproduct = False
    End Sub

    Private Sub _clear()
        txt_productID.Clear()
        txt_password.Clear()
        TextBox1.Clear()
        TextBox2.Text = "0"
        txt_productID.Text = generateTaxID()
        sum = 0
        dt.Clear()
        dtCus.Clear()
        Label5.Text = sum.ToString("0.00")
        Label14.Text = "0"
        Label10.Text = generateTaxID()
        txt_productID.Text = ""
        txt_productID.Focus()
        _index = -1
    End Sub

    Private Sub MngPackget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel3.Text = Now.ToString("D")
        txt_productID.Focus()
        _clear()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub Label5_TextChanged(sender As Object, e As EventArgs) Handles Label5.TextChanged
        'TextBox2.Text = Double.Parse(TextBox1.Text) - Double.Parse(Label5.Text)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Dim sql = "SELECT * FROM tbl_product WHERE Product_ID = @id"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", txt_productID.Text.Trim())
            dt = QueryReturnDatatable(cmd)
            If dt.Rows.Count > 0 Then
                addToGrid()
                txt_productID.Clear()
            Else
                MessageBox.Show("ไม่พบสินค้าที่ต้องการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addToGrid()
        DataGridView1.Rows.Add(dt.Rows(0)(0), dt.Rows(0)(3), 1, dt.Rows(0)(2), Double.Parse(dt.Rows(0)(2)) * 1)
        sum += Double.Parse(dt.Rows(0)(2)) * 1
        Label5.Text = sum.ToString("0.00")
        Label14.Text = DataGridView1.Rows.Count
    End Sub

    Private Function generateTaxID()
        Dim sql As String = "SELECT * FROM tbl_saleproduct ORDER BY tbl_saleproduct.Saleslip_ID DESC LIMIT 1"
        Dim code As String = "SL"
        Dim result As String = QueryGetID(sql, code)
        Return result
    End Function

    Private Sub addCustomer()
        Label12.Text = dtCus.Rows(0)(1)
        txt_password.Text = dtCus.Rows(0)(0)
    End Sub

    Private Sub Btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Try
            Dim sql = "SELECT * FROM tbl_customer WHERE Customer_ID = @id"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", txt_password.Text.Trim())
            dtCus = QueryReturnDatatable(cmd)
            If dtCus.Rows.Count > 0 Then
                addCustomer()
            Else
                MessageBox.Show("ไม่พบสินค้าที่ต้องการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _index = e.RowIndex
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If _index >= 0 Then
            sum -= Double.Parse(DataGridView1.Rows(_index).Cells(4).Value)
            Label5.Text = sum.ToString("0.00")
            DataGridView1.Rows.RemoveAt(Int32.Parse(_index))
            Label14.Text = DataGridView1.Rows.Count
        End If
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        MngPackget_Load(sender, e)
    End Sub

    Private Sub MngSaleProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Btn_add_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            ToolStripButton1_Click(sender, e)
        ElseIf e.KeyCode = Keys.F3 Then
            Btn_save_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TextBox2.Text = Double.Parse(TextBox1.Text) - Double.Parse(Label5.Text)
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim _report As New ReportSaleProduct
        saveSaleHeader()
        Try
            Dim _loop As Integer = 0
            While DataGridView1.Rows.Count > 0
                _index = 0
                If _index >= 0 Then
                    row = DataGridView1.Rows(_index)
                    Dim _id As String = row.Cells(0).Value.ToString
                    Dim sql = "INSERT INTO tbl_saleslip (Saleslip_ID, Saleslip_Income, Saleslip_Total, Product_ID, Saleslip_Change) VALUES (@id,@income,@total,@pid,@change)"
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@id", Label10.Text)
                    cmd.Parameters.AddWithValue("@income", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@total", sum)
                    cmd.Parameters.AddWithValue("@pid", _id)
                    cmd.Parameters.AddWithValue("@change", TextBox2.Text)
                    QueryNonReturn(cmd)
                    DataGridView1.Rows.RemoveAt(Int32.Parse(_index))
                    _index += 1
                End If
            End While
            _clear()
            _report._id = Label10.Text
            _report.ShowDialog()
            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ จาก LoopSave เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub saveSaleHeader()
        Try
            If txt_password.Text.Trim() = "" Then
                txt_password.Text = "CS00000003"
            End If
            Dim time As New DateTime
            Dim sql = "INSERT INTO tbl_saleproduct (Saleslip_ID, Customer_ID, SalesDate) VALUES (@id,@cid,@date)"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", Label10.Text)
            cmd.Parameters.AddWithValue("@cid", txt_password.Text)
            cmd.Parameters.AddWithValue("@date", time.Now())
            QueryNonReturn(cmd)
            MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ เนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txt_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_productID.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuImageButton1_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuImageButton2_Click(sender, e)
        End If
    End Sub
End Class