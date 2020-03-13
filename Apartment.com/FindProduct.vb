Public Class FindProduct

    Public _index As Integer = -1
    Dim row As DataGridViewRow
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub FindReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT tbl_category.Category_ID , tbl_category.Category_Name  FROM tbl_category ")
        DataGridView1.Columns(0).HeaderText = "รหัสประเภท"
        DataGridView1.Columns(1).HeaderText = "ชื่อประเภทสินค้า"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        _index = e.RowIndex
        If _index >= 0 Then
            row = DataGridView1.Rows(_index)
            Dim _id As String = row.Cells(0).Value.ToString()
            Dim _name As String = row.Cells(1).Value.ToString()
            new_mngproduct._catagoryID = _id
            new_mngproduct._catagoryNAME = _name
            new_mngproduct.txt_type.Text = _name
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If _index >= 0 Then
            row = DataGridView1.Rows(_index)
            Dim _id As String = row.Cells(0).Value.ToString()
            Dim _name As String = row.Cells(1).Value.ToString()
            new_mngproduct._catagoryID = _id
            new_mngproduct._catagoryNAME = _name
            new_mngproduct.txt_type.Text = _name
            new_mngproduct.BringToFront()
            Me.Close()
        End If
    End Sub
End Class