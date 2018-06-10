Public Class MngRoom
    Dim edit As Boolean = False
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MngRoom_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mngroom = False
    End Sub

    Private Sub MngRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getAddressBuilding()
        Call getStatus()
        Call getTyperoom()
        Call getID()
        Call showdata()
        Call getToolstripBottom()
        Call disableControl()
        ToolStripHeader.Renderer = New CustomTool()
    End Sub

    Private Sub disableControl()
        txt_id.Enabled = False
        txt_roomname.Enabled = False
        txt_detail.Enabled = False
        txt_water.Enabled = False
        txt_elec.Enabled = False
        ComboBoxAddressBuilding.Enabled = False
        ComboBoxStatus.Enabled = False
        ComboBoxTyperoom.Enabled = False
        ComboBoxTyperoom.SelectedIndex = 0
        ComboBoxStatus.SelectedIndex = 0
        ComboBoxAddressBuilding.SelectedIndex = 0
        ComboBoxSearch.SelectedIndex = 0
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
    End Sub

    Private Sub pressAdd()
        btn_add.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = True
        btn_clear.Enabled = True
        txt_id.Enabled = False
        txt_roomname.Enabled = True
        txt_detail.Enabled = True
        txt_water.Enabled = True
        txt_elec.Enabled = True
        ComboBoxAddressBuilding.Enabled = True
        ComboBoxStatus.Enabled = True
        ComboBoxTyperoom.Enabled = True
        edit = False
        txt_roomname.Clear()
        txt_water.Clear()
        txt_elec.Clear()
        txt_detail.Text = "-"
        ComboBoxAddressBuilding.SelectedIndex = 0
        ComboBoxStatus.SelectedIndex = 0
        ComboBoxTyperoom.SelectedIndex = 0
        txt_roomname.Focus()
    End Sub

    Private Sub getAddressBuilding()
        Dim dt As DataTable = QueryReturnDatatable("SELECT * FROM tbl_building")
        ComboBoxAddressBuilding.DataSource = dt
        ComboBoxAddressBuilding.DisplayMember = "building_name"
        ComboBoxAddressBuilding.ValueMember = "building_id"
    End Sub

    Private Sub getStatus()
        Dim dt As DataTable = QueryReturnDatatable("SELECT * FROM tbl_statusroom")
        ComboBoxStatus.DataSource = dt
        ComboBoxStatus.DisplayMember = "status_name"
        ComboBoxStatus.ValueMember = "status_id"
    End Sub

    Private Sub getTyperoom()
        Dim dt As DataTable = QueryReturnDatatable("SELECT typeroom_id,typeroom_name FROM tbl_typeroom")
        ComboBoxTyperoom.DataSource = dt
        ComboBoxTyperoom.DisplayMember = "typeroom_name"
        ComboBoxTyperoom.ValueMember = "typeroom_id"
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Call pressAdd()
    End Sub

    Private Sub getID()
        txt_id.Text = QueryGetID("SELECT room_id FROM tbl_room Order by room_id DESC", "RM")
    End Sub

    Private Sub showdata()
        Datagridshow.DataSource = QueryReturnDatatable("SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id")
        Call headdata()
    End Sub

    Private Sub headdata()
        Datagridshow.Columns(0).HeaderText = "รหัสห้อง"
        Datagridshow.Columns(1).HeaderText = "สถานะห้อง"
        Datagridshow.Columns(2).HeaderText = "หมายเลขห้อง"
        Datagridshow.Columns(3).HeaderText = "สังกัดตึก/อาคาร"
        Datagridshow.Columns(4).HeaderText = "ประเภทห้อง"
        Datagridshow.Columns(5).HeaderText = "ค่าน้ำต่อหน่วย"
        Datagridshow.Columns(6).HeaderText = "ค่าไฟต่อหน่วย"
        Datagridshow.Columns(7).HeaderText = "รายละเอียดห้อง"

    End Sub

    Private Sub getToolstripBottom()
        ToolStripLabelALLROOM.Text = QueryReturnDatatableOverride("SELECT COUNT(*) FROM tbl_room")(0)(0).ToString + " ห้อง"
        ToolStripLabelNULL.Text = QueryReturnDatatableOverride("SELECT COUNT(*) FROM tbl_room WHERE room_status ='ST0001'")(0)(0).ToString + " ห้อง"
    End Sub

    Private Sub Datagridshow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridshow.CellClick
        If e.RowIndex >= 0 Then
            txt_id.Text = Datagridshow.Rows(e.RowIndex).Cells(0).Value
            ComboBoxStatus.Text = Datagridshow.Rows(e.RowIndex).Cells(1).Value
            txt_roomname.Text = Datagridshow.Rows(e.RowIndex).Cells(2).Value
            ComboBoxAddressBuilding.Text = Datagridshow.Rows(e.RowIndex).Cells(3).Value
            ComboBoxTyperoom.Text = Datagridshow.Rows(e.RowIndex).Cells(4).Value
            txt_water.Text = Datagridshow.Rows(e.RowIndex).Cells(5).Value
            txt_elec.Text = Datagridshow.Rows(e.RowIndex).Cells(6).Value
            txt_detail.Text = Datagridshow.Rows(e.RowIndex).Cells(7).Value
            edit = True
            btn_add.Enabled = False
            btn_save.Enabled = False
            btn_edit.Enabled = True
            btn_delete.Enabled = True
            btn_clear.Enabled = True
            txt_id.Enabled = False
            txt_roomname.Enabled = False
            txt_detail.Enabled = False
            txt_water.Enabled = False
            txt_elec.Enabled = False
            ComboBoxAddressBuilding.Enabled = False
            ComboBoxStatus.Enabled = False
            ComboBoxTyperoom.Enabled = False
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        edit = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_add.Enabled = True
        btn_save.Enabled = False
        txt_id.Clear()
        txt_roomname.Clear()
        txt_search.Clear()
        txt_water.Clear()
        txt_elec.Clear()
        txt_detail.Clear()
        Call getID()
        Call getTyperoom()
        Call getStatus()
        Call getAddressBuilding()
        Call showdata()
        ComboBoxSearch.SelectedIndex = 0
        ComboBoxAddressBuilding.SelectedIndex = 0
        ComboBoxStatus.SelectedIndex = 0
        ComboBoxTyperoom.SelectedIndex = 0
        txt_roomname.Focus()
    End Sub

    Private Sub txt_water_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_water.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_elec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_elec.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not edit Then
            Dim sql As String = "INSERT INTO tbl_room VALUES ( '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
            sql = String.Format(sql, txt_id.Text, ComboBoxStatus.SelectedValue, txt_roomname.Text, ComboBoxAddressBuilding.SelectedValue, ComboBoxTyperoom.SelectedValue, txt_detail.Text, txt_water.Text.ToString, txt_elec.Text.ToString)
            QueryNonReturn(sql)
            Call showdata()
            Call pressAdd()
        Else
            Dim sql As String = "UPDATE tbl_room SET room_status='{1}',room_number='{2}',building_id='{3}',typeroom_id='{4}',room_note='{5}',room_water='{6}',room_electric='{7}' WHERE room_id='{0}'"
            sql = String.Format(sql, txt_id.Text, ComboBoxStatus.SelectedValue, txt_roomname.Text, ComboBoxAddressBuilding.SelectedValue, ComboBoxTyperoom.SelectedValue, txt_detail.Text, txt_water.Text.ToString, txt_elec.Text.ToString)
            QueryNonReturn(sql)
            Call showdata()
        End If
        edit = False
        Call getToolstripBottom()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call pressEdit()
    End Sub

    Private Sub pressEdit()
        txt_roomname.Enabled = True
        txt_detail.Enabled = True
        txt_water.Enabled = True
        txt_elec.Enabled = True
        ComboBoxAddressBuilding.Enabled = True
        ComboBoxStatus.Enabled = True
        ComboBoxTyperoom.Enabled = True
        txt_roomname.Focus()
        btn_edit.Enabled = False
        btn_save.Enabled = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sql As String = "DELETE FROM tbl_room WHERE room_id = '{0}'"
        sql = String.Format(sql, txt_id.Text)
        QueryNonReturn(sql)
        Call showdata()
        btn_clear_Click(sender, e)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If ComboBoxSearch.Text <> "-ค้นหาตาม" Then
            If ComboBoxSearch.Text = "ตำแหน่งที่อยู่ห้อง" Then
                Dim sql As String = "SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_building.building_name LIKE '%{0}%'"
                sql = String.Format(sql, txt_search.Text)
                Datagridshow.DataSource = QueryReturnDatatable(sql)
                Call headdata()
            ElseIf ComboBoxSearch.Text = "ประเภทห้อง" Then
                Dim sql As String = "SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_typeroom.typeroom_name LIKE '%{0}%'"
                sql = String.Format(sql, txt_search.Text)
                Datagridshow.DataSource = QueryReturnDatatable(sql)
                Call headdata()
            ElseIf ComboBoxSearch.Text = "ห้องที่ว่างเท่านั้น" Then
                txt_search.Enabled = False
                Datagridshow.DataSource = QueryReturnDatatable("SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_room.room_status='ST0001'")
                Call headdata()
            End If
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If ComboBoxSearch.Text <> "-ค้นหาตาม" Then
            If ComboBoxSearch.Text = "ตำแหน่งที่อยู่ห้อง" Then
                Dim sql As String = "SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_building.building_name LIKE '%{0}%'"
                sql = String.Format(sql, txt_search.Text)
                Datagridshow.DataSource = QueryReturnDatatable(sql)
                Call headdata()
            ElseIf ComboBoxSearch.Text = "ประเภทห้อง" Then
                Dim sql As String = "SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_typeroom.typeroom_name LIKE '%{0}%'"
                sql = String.Format(sql, txt_search.Text)
                Datagridshow.DataSource = QueryReturnDatatable(sql)
                Call headdata()
            ElseIf ComboBoxSearch.Text = "ห้องที่ว่างเท่านั้น" Then
                txt_search.Enabled = False
                Datagridshow.DataSource = QueryReturnDatatable("SELECT tbl_room.room_id,tbl_statusroom.status_name,tbl_room.room_number,tbl_building.building_name,tbl_typeroom.typeroom_name,tbl_room.room_water,tbl_room.room_electric,tbl_room.room_note FROM tbl_room,tbl_typeroom,tbl_building,tbl_statusroom WHERE tbl_room.building_id = tbl_building.building_id AND tbl_room.typeroom_id = tbl_typeroom.typeroom_id AND tbl_room.room_status = tbl_statusroom.status_id AND tbl_room.room_status='ST0001'")
                Call headdata()
            End If
        End If
    End Sub
End Class
