Imports System.ComponentModel
Imports System.Threading
Public Class MainActivity



    Private Sub BunifuImageButton16_Click(sender As Object, e As EventArgs) Handles BunifuImageButton16.Click
        Application.Exit()
    End Sub

    Private Sub MainActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripdate.Text = "วันที่ : " + Now.ToString("D")
        label_username.Text = My.Settings.Username
        AddTasks(Tasks.item.normal, "แจ้งเตือน (Notification)", "ยังไม่มีกิจกรรม", "ไม่ค้นพบกิจกรรมที่มีในวันนี้")
        Bunifu.Framework.Lib.Elipse.Apply(Me, 10)
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


    Private Sub btn_building_Click(sender As Object, e As EventArgs) Handles btn_building.Click

    End Sub

    Private Sub btn_typeroom_Click(sender As Object, e As EventArgs) Handles btn_typeroom.Click
        If Not isOpenform.mngcategory Then
            new_mngcategory = New MngCategory
            new_mngcategory.Show()
            isOpenform.mngcategory = True
        Else
            '  new_mngtyperoom.WindowState = FormWindowState.Maximized
            new_mngcategory.BringToFront()
        End If
    End Sub


    Private Sub btn_packget_Click(sender As Object, e As EventArgs) Handles btn_packget.Click
        If Not isOpenform.mngproduct Then
            new_mngproduct = New MngProduct
            new_mngproduct.Show()
            isOpenform.mngproduct = True
        Else
            '  new_mngpackget.WindowState = FormWindowState.Maximized
            new_mngproduct.BringToFront()
        End If
    End Sub

    Private Sub btn_buypackget_Click(sender As Object, e As EventArgs) Handles btn_buypackget.Click
        If Not isOpenform.mngsaleProduct Then
            new_mngsaleProduct = New MngSaleProduct
            new_mngsaleProduct.Show()
            isOpenform.mngsaleProduct = True
        Else
            '  new_mngbuypackget.WindowState = FormWindowState.Maximized
            new_mngsaleProduct.BringToFront()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        btn_mngcustomer_Click(sender, e)
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        btn_building_Click(sender, e)
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        btn_packget_Click(sender, e)
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        btn_info_Click(sender, e)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        btn_typeroom_Click(sender, e)
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        btn_buypackget_Click(sender, e)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        BunifuImageButton10_Click(sender, e)
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click

    End Sub
End Class
