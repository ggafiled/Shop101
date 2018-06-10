Public Class MngCustomer

    Private Sub MngCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_clear.Enabled = False
        ComboBox.SelectedIndex = 0
        DateTimePickerBorn.Value = Now.ToShortDateString
        ComboBoxPrefix3.Visible = False
        txt_name3.Visible = False
        txt_lastname3.Visible = False
        txt_phone3.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        ToolStripHeader.Renderer = New CustomTool
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxPatner.CheckStateChanged
        If CheckBoxPatner.CheckState = CheckState.Unchecked Then
            ComboBoxPrefix3.Visible = False
            txt_name3.Visible = False
            txt_lastname3.Visible = False
            txt_phone3.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
        Else
            ComboBoxPrefix3.Visible = True
            txt_name3.Visible = True
            txt_lastname3.Visible = True
            txt_phone3.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
        End If
    End Sub

    Private Sub MngCustomer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        isOpenform.mngcustomer = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub


End Class