Imports System.Threading
Public Class MainActivity

    Private Sub BunifuImageButton16_Click(sender As Object, e As EventArgs) Handles BunifuImageButton16.Click
        Application.Exit()
    End Sub

    Private Sub MainActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripdate.Text = "วันที่ : " + Now.ToString("D")
        label_username.Text = My.Settings.Username
        'AddTasks(Tasks.item.normal, "แจ้งเตือน (Notification)", "ยังไม่มีกิจกรรม", "ไม่ค้นพบกิจกรรมที่มีในวันนี้")
        AddTasks(Tasks.item.reserve, "แจ้งเตือน (Notification)", "จอง 2 ห้อง", "มีการจองและนัดทำสัญญาในวันนี้")
    End Sub

    Sub AddTasks(type As Tasks.item, ByVal t As String, ByVal h As String, ByVal d As String)
        Dim area As New Tasks
        area.Add(type, t, h, d)
        area.Dock = DockStyle.Top
        If PanelActivity.VerticalScroll.Visible Then
            area.Width = area.Width - SystemInformation.VerticalScrollBarWidth
        End If

        PanelActivity.Controls.Add(area)
        area.BringToFront()
    End Sub

    Private Sub btn_mngcustomer_Click(sender As Object, e As EventArgs) Handles btn_mngcustomer.Click
        If Not isOpenform.mngcustomer Then
            new_mngcustomer = New MngCustomer
            new_mngcustomer.Show()
            isOpenform.mngcustomer = True
        Else
            '  new_mngcustomer.WindowState = FormWindowState.Maximized
            new_mngcustomer.BringToFront()
        End If
    End Sub

    Private Sub btn_mnginvoice_Click(sender As Object, e As EventArgs) Handles btn_mnginvoice.Click
        If Not isOpenform.mnginvoice Then
            new_mnginvoice = New MngInvoice
            new_mnginvoice.Show()
            isOpenform.mnginvoice = True
        Else
            '  new_mnginvoice.WindowState = FormWindowState.Maximized
            new_mnginvoice.BringToFront()
        End If
    End Sub

    Private Sub btn_alertmoveout_Click(sender As Object, e As EventArgs) Handles btn_alertmoveout.Click
        If Not isOpenform.mngmoveout Then
            new_mngmoveout = New MngMoveout
            new_mngmoveout.Show()
            isOpenform.mngmoveout = True
        Else
            '  new_mngmoveout.WindowState = FormWindowState.Maximized
            new_mngmoveout.BringToFront()
        End If
    End Sub

    Private Sub btn_reserve_Click(sender As Object, e As EventArgs) Handles btn_reserve.Click
        If Not isOpenform.mngreserve Then
            new_mngreserve = New MngReserve
            new_mngreserve.Show()
            isOpenform.mngreserve = True
        Else
            '   new_mngreserve.WindowState = FormWindowState.Maximized
            new_mngreserve.BringToFront()
        End If
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        If Not isOpenform.mngadmin Then
            new_mngadmin = New MngAdmin
            new_mngadmin.Show()
            isOpenform.mngadmin = True
        Else
            '  new_mngadmin.WindowState = FormWindowState.Maximized
            new_mngadmin.BringToFront()
        End If
    End Sub

    Private Sub btn_prefix_Click(sender As Object, e As EventArgs) Handles btn_prefix.Click
        If Not isOpenform.mngprefix Then
            new_mngprefix = New MngPrefix
            new_mngprefix.Show()
            isOpenform.mngprefix = True
        Else
            '  new_mngprefix.WindowState = FormWindowState.Maximized
            new_mngprefix.BringToFront()
        End If
    End Sub

    Private Sub btn_building_Click(sender As Object, e As EventArgs) Handles btn_building.Click
        If Not isOpenform.mngbuilding Then
            new_mngbuilding = New MngBuilding
            new_mngbuilding.Show()
            isOpenform.mngbuilding = True
        Else
            '   new_mngbuilding.WindowState = FormWindowState.Maximized
            new_mngbuilding.BringToFront()
        End If
    End Sub

    Private Sub btn_room_Click(sender As Object, e As EventArgs) Handles btn_room.Click
        If Not isOpenform.mngroom Then
            new_mngroom = New MngRoom
            new_mngroom.Show()
            isOpenform.mngroom = True
        Else
            '  new_mngroom.WindowState = FormWindowState.Maximized
            new_mngroom.BringToFront()
        End If
    End Sub

    Private Sub btn_typeroom_Click(sender As Object, e As EventArgs) Handles btn_typeroom.Click
        If Not isOpenform.mngtyperoom Then
            new_mngtyperoom = New MngTyperoom
            new_mngtyperoom.Show()
            isOpenform.mngtyperoom = True
        Else
            '  new_mngtyperoom.WindowState = FormWindowState.Maximized
            new_mngtyperoom.BringToFront()
        End If
    End Sub

    Private Sub btn_cancelpromise_Click(sender As Object, e As EventArgs) Handles btn_cancelpromise.Click
        If Not isOpenform.mngcencelpromise Then
            new_mngcancelpromise = New MngCancelpromise
            new_mngcancelpromise.Show()
            isOpenform.mngcencelpromise = True
        Else
            '  new_mngcancelpromise.WindowState = FormWindowState.Maximized
            new_mngcancelpromise.BringToFront()
        End If
    End Sub

    Private Sub btn_promise_Click(sender As Object, e As EventArgs) Handles btn_promise.Click
        If Not isOpenform.mngpromise Then
            new_mngpromise = New MngPromise
            new_mngpromise.Show()
            isOpenform.mngpromise = True
        Else
            '  new_mngpromise.WindowState = FormWindowState.Maximized
            new_mngpromise.BringToFront()
        End If
    End Sub

    Private Sub btn_repair_Click(sender As Object, e As EventArgs) Handles btn_repair.Click
        If Not isOpenform.mngrepair Then
            new_mngrepair = New MngRepair
            new_mngrepair.Show()
            isOpenform.mngrepair = True
        Else
            '   new_mngrepair.WindowState = FormWindowState.Maximized
            new_mngrepair.BringToFront()
        End If
    End Sub

    Private Sub btn_advice_Click(sender As Object, e As EventArgs) Handles btn_advice.Click
        If Not isOpenform.mngadvice Then
            new_mngadvice = New MngAdvice
            new_mngadvice.Show()
            isOpenform.mngadvice = True
        Else
            '  new_mngadvice.WindowState = FormWindowState.Maximized
            new_mngadvice.BringToFront()
        End If
    End Sub

    Private Sub btn_scopeadvice_Click(sender As Object, e As EventArgs) Handles btn_scopeadvice.Click
        If Not isOpenform.mngscopeadvice Then
            new_mngscopeadvice = New MngScopeAdvice
            new_mngscopeadvice.Show()
            isOpenform.mngscopeadvice = True
        Else
            ' new_mngscopeadvice.WindowState = FormWindowState.Maximized
            new_mngscopeadvice.BringToFront()
        End If
    End Sub

    Private Sub btn_packget_Click(sender As Object, e As EventArgs) Handles btn_packget.Click
        If Not isOpenform.mngpackget Then
            new_mngpackget = New MngPackget
            new_mngpackget.Show()
            isOpenform.mngpackget = True
        Else
            '  new_mngpackget.WindowState = FormWindowState.Maximized
            new_mngpackget.BringToFront()
        End If
    End Sub

    Private Sub btn_buypackget_Click(sender As Object, e As EventArgs) Handles btn_buypackget.Click
        If Not isOpenform.mngbuypackget Then
            new_mngbuypackget = New MngBuypackget
            new_mngbuypackget.Show()
            isOpenform.mngbuypackget = True
        Else
            '  new_mngbuypackget.WindowState = FormWindowState.Maximized
            new_mngbuypackget.BringToFront()
        End If
    End Sub

    Private Sub btn_realinvoice_Click(sender As Object, e As EventArgs) Handles btn_realinvoice.Click
        If Not isOpenform.mngrealinvoice Then
            new_mngrealinvoice = New MngRealinvoice
            new_mngrealinvoice.Show()
            isOpenform.mngrealinvoice = True
        Else
            ' new_mngrealinvoice.WindowState = FormWindowState.Maximized
            new_mngrealinvoice.BringToFront()
        End If
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        If Not isOpenform.mnginfoaboutdevelop Then
            new_mnginfoaboutdevelop = New InfoAboutDevelop
            new_mnginfoaboutdevelop.Show()
            isOpenform.mnginfoaboutdevelop = True
        Else
            ' new_mngrealinvoice.WindowState = FormWindowState.Maximized
            new_mnginfoaboutdevelop.BringToFront()
        End If
    End Sub
End Class
