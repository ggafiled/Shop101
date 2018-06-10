Public Class MngAdmin

    Private edit As Boolean = False
    Private Sub MngAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxGrant.SelectedIndex = 0
        Call disableControl()
        Call showdata()
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub MngAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpenform.mngadmin = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub disableControl()
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        txt_user.Enabled = False
        txt_password.Enabled = False
        ComboBoxGrant.Enabled = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = True
        btn_clear.Enabled = True
        txt_user.Enabled = True
        txt_password.Enabled = True
        ComboBoxGrant.Enabled = True
        edit = False
        btn_clear_Click(sender, e)
        txt_user.Focus()
    End Sub

    Private Sub showdata()
        DataGridView1.DataSource = QueryReturnDatatable("SELECT User_name,User_password,User_Grant FROM userauthen")
        Call headdata()
    End Sub

    Private Sub headdata()
        DataGridView1.Columns(0).HeaderText = "ชื่อผู้ใช้งาน"
        DataGridView1.Columns(1).HeaderText = "รหัสผ่าน"
        DataGridView1.Columns(2).HeaderText = "ระดับสิทธิ์"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btn_add.Enabled = False
        btn_save.Enabled = False
        btn_edit.Enabled = True
        btn_delete.Enabled = True
        btn_clear.Enabled = True
        txt_user.Enabled = False
        txt_password.Enabled = False
        ComboBoxGrant.Enabled = False
        txt_user.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_password.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBoxGrant.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        txt_user.Enabled = True
        txt_password.Enabled = True
        ComboBoxGrant.Enabled = True
        btn_edit.Enabled = False
        btn_add.Enabled = False
        edit = True
        btn_save.Enabled = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_user.Clear()
        txt_password.Clear()
        ComboBoxGrant.SelectedIndex = 0
        edit = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not edit Then
            Dim sql As String = "INSERT INTO userauthen VALUES (" + "'" + txt_user.Text + "'" + "," + "'" + txt_password.Text + "'" + "," + "'" + ComboBoxGrant.Text + "'" + ")"
            QueryNonReturn(sql)
            Call showdata()
            btn_add_Click(sender, e)
        Else
            Dim sql As String = "UPDATE userauthen SET user_name =" + "'" + txt_user.Text + "'" + ", user_password =" + "'" + txt_password.Text + "'" + ", User_grant=" + "'" + ComboBoxGrant.Text + "'" + " WHERE user_name=" + "'" + txt_user.Text + "'"
            QueryNonReturn(sql)
            Call showdata()
        End If
        edit = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql As String = "Delete FROM userauthen WHERE user_name =" + "'" + txt_user.Text + "'" + "AND user_password =" + "'" + txt_password.Text + "'"
        QueryNonReturn(sql)
        Call showdata()
        btn_clear_Click(sender, e)
    End Sub
End Class