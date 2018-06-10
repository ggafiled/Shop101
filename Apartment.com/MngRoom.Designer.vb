<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MngRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngRoom))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripHeader = New System.Windows.Forms.ToolStrip()
        Me.btn_search = New System.Windows.Forms.ToolStripButton()
        Me.txt_search = New System.Windows.Forms.ToolStripTextBox()
        Me.ComboBoxSearch = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxAddressBuilding = New System.Windows.Forms.ComboBox()
        Me.txt_elec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_water = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxTyperoom = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_roomname = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Datagridshow = New System.Windows.Forms.DataGridView()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelALLROOM = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelNULL = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Datagridshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ToolStripHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 105)
        Me.Panel1.TabIndex = 1
        '
        'ToolStripHeader
        '
        Me.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_search, Me.txt_search, Me.ComboBoxSearch, Me.ToolStripLabel1, Me.btn_add, Me.btn_save, Me.btn_edit, Me.btn_delete, Me.btn_clear, Me.btn_close, Me.ToolStripSeparator1})
        Me.ToolStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripHeader.Name = "ToolStripHeader"
        Me.ToolStripHeader.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripHeader.Size = New System.Drawing.Size(1000, 98)
        Me.ToolStripHeader.TabIndex = 0
        Me.ToolStripHeader.Text = "ToolStrip1"
        '
        'btn_search
        '
        Me.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_search.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.Apartment.com.My.Resources.Resources.search48px
        Me.btn_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_search.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_search.Size = New System.Drawing.Size(72, 98)
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txt_search
        '
        Me.txt_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_search.Font = New System.Drawing.Font("Cordia New", 14.0!)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(150, 98)
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearch.Font = New System.Drawing.Font("Cordia New", 14.0!)
        Me.ComboBoxSearch.Items.AddRange(New Object() {"-ค้นหาตาม", "ตำแหน่งที่อยู่ห้อง", "ประเภทห้อง", "ห้องที่ว่างเท่านั้น"})
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(150, 98)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 95)
        Me.ToolStripLabel1.Text = "ค้นหาด่วน"
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Image = Global.Apartment.com.My.Resources.Resources.new_user48px
        Me.btn_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_add.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_add.Size = New System.Drawing.Size(87, 98)
        Me.btn_add.Text = "เพิ่มข้อมูล"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Apartment.com.My.Resources.Resources.save48px
        Me.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_save.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_save.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_save.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_save.Size = New System.Drawing.Size(72, 98)
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Image = Global.Apartment.com.My.Resources.Resources.edit48px
        Me.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_edit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_edit.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_edit.Size = New System.Drawing.Size(72, 98)
        Me.btn_edit.Text = "แก้ไข"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Apartment.com.My.Resources.Resources.delete48px
        Me.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_delete.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_delete.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_delete.Size = New System.Drawing.Size(72, 98)
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = Global.Apartment.com.My.Resources.Resources.clear48px
        Me.btn_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_clear.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_clear.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_clear.Size = New System.Drawing.Size(72, 98)
        Me.btn_clear.Text = "ล้าง"
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = Global.Apartment.com.My.Resources.Resources.close48px
        Me.btn_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_close.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_close.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_close.Size = New System.Drawing.Size(72, 98)
        Me.btn_close.Text = "ปิด"
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 98)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxAddressBuilding)
        Me.GroupBox1.Controls.Add(Me.txt_elec)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_water)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_detail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTyperoom)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_roomname)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(978, 170)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลผู้เช่า"
        '
        'ComboBoxAddressBuilding
        '
        Me.ComboBoxAddressBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAddressBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxAddressBuilding.FormattingEnabled = True
        Me.ComboBoxAddressBuilding.Location = New System.Drawing.Point(567, 27)
        Me.ComboBoxAddressBuilding.Name = "ComboBoxAddressBuilding"
        Me.ComboBoxAddressBuilding.Size = New System.Drawing.Size(362, 34)
        Me.ComboBoxAddressBuilding.TabIndex = 19
        '
        'txt_elec
        '
        Me.txt_elec.Location = New System.Drawing.Point(799, 116)
        Me.txt_elec.MaxLength = 50
        Me.txt_elec.Name = "txt_elec"
        Me.txt_elec.Size = New System.Drawing.Size(130, 34)
        Me.txt_elec.TabIndex = 18
        Me.txt_elec.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(730, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "หน่วยไฟ :"
        '
        'txt_water
        '
        Me.txt_water.Location = New System.Drawing.Point(567, 116)
        Me.txt_water.MaxLength = 50
        Me.txt_water.Name = "txt_water"
        Me.txt_water.Size = New System.Drawing.Size(130, 34)
        Me.txt_water.TabIndex = 16
        Me.txt_water.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(497, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "หน่วยน้ำ :"
        '
        'txt_detail
        '
        Me.txt_detail.Location = New System.Drawing.Point(151, 74)
        Me.txt_detail.MaxLength = 50
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(291, 86)
        Me.txt_detail.TabIndex = 14
        Me.txt_detail.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "รายละเอียดห้องพัก :"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Location = New System.Drawing.Point(799, 69)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(130, 34)
        Me.ComboBoxStatus.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(716, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "สถานะห้อง :"
        '
        'ComboBoxTyperoom
        '
        Me.ComboBoxTyperoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTyperoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxTyperoom.FormattingEnabled = True
        Me.ComboBoxTyperoom.Location = New System.Drawing.Point(567, 69)
        Me.ComboBoxTyperoom.Name = "ComboBoxTyperoom"
        Me.ComboBoxTyperoom.Size = New System.Drawing.Size(130, 34)
        Me.ComboBoxTyperoom.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(455, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 26)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "ตำแหน่งที่อยู่ห้อง :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ประเภทห้องพัก :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "หมายเลขห้อง :"
        '
        'txt_roomname
        '
        Me.txt_roomname.Location = New System.Drawing.Point(308, 27)
        Me.txt_roomname.MaxLength = 50
        Me.txt_roomname.Name = "txt_roomname"
        Me.txt_roomname.Size = New System.Drawing.Size(134, 34)
        Me.txt_roomname.TabIndex = 7
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(72, 27)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(126, 34)
        Me.txt_id.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัส :"
        '
        'Datagridshow
        '
        Me.Datagridshow.AllowUserToAddRows = False
        Me.Datagridshow.AllowUserToDeleteRows = False
        Me.Datagridshow.AllowUserToResizeColumns = False
        Me.Datagridshow.AllowUserToResizeRows = False
        Me.Datagridshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Datagridshow.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Datagridshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Datagridshow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datagridshow.ColumnHeadersHeight = 25
        Me.Datagridshow.Location = New System.Drawing.Point(11, 284)
        Me.Datagridshow.Margin = New System.Windows.Forms.Padding(0)
        Me.Datagridshow.Name = "Datagridshow"
        Me.Datagridshow.ReadOnly = True
        Me.Datagridshow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Datagridshow.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Datagridshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridshow.Size = New System.Drawing.Size(978, 214)
        Me.Datagridshow.TabIndex = 7
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripLabelALLROOM, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.ToolStripLabelNULL})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 512)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1000, 28)
        Me.ToolStrip3.TabIndex = 18
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Cordia New", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(128, 25)
        Me.ToolStripLabel7.Text = "การจัดการข้อมูลห้องพัก"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Cordia New", 13.0!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(127, 25)
        Me.ToolStripLabel2.Text = "จำนวนห้องพักทั้งหมด :"
        '
        'ToolStripLabelALLROOM
        '
        Me.ToolStripLabelALLROOM.Font = New System.Drawing.Font("Cordia New", 13.0!)
        Me.ToolStripLabelALLROOM.Name = "ToolStripLabelALLROOM"
        Me.ToolStripLabelALLROOM.Size = New System.Drawing.Size(147, 25)
        Me.ToolStripLabelALLROOM.Text = "ToolStripLabelALLROOM"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Cordia New", 13.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(57, 25)
        Me.ToolStripLabel4.Text = "ห้องว่าง :"
        '
        'ToolStripLabelNULL
        '
        Me.ToolStripLabelNULL.Font = New System.Drawing.Font("Cordia New", 13.0!)
        Me.ToolStripLabelNULL.Name = "ToolStripLabelNULL"
        Me.ToolStripLabelNULL.Size = New System.Drawing.Size(123, 25)
        Me.ToolStripLabelNULL.Text = "ToolStripLabelNULL"
        '
        'MngRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 540)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Datagridshow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 540)
        Me.MinimumSize = New System.Drawing.Size(1000, 540)
        Me.Name = "MngRoom"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "การจัดการข้อมูลห้องพัก"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Datagridshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents btn_search As ToolStripButton
    Friend WithEvents txt_search As ToolStripTextBox
    Friend WithEvents ComboBoxSearch As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_roomname As TextBox
    Friend WithEvents txt_elec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_water As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_detail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxTyperoom As ComboBox
    Friend WithEvents Datagridshow As DataGridView
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabelALLROOM As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabelNULL As ToolStripLabel
    Friend WithEvents ComboBoxAddressBuilding As ComboBox
    Friend WithEvents Label8 As Label
End Class
