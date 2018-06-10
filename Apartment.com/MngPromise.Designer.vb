<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MngPromise
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngPromise))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripHeader = New System.Windows.Forms.ToolStrip()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_lastname2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_name2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_thaiid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_selectcustomer = New System.Windows.Forms.Button()
        Me.btn_selectroom = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1108, 103)
        Me.Panel1.TabIndex = 2
        '
        'ToolStripHeader
        '
        Me.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_add, Me.btn_save, Me.btn_edit, Me.btn_clear, Me.btn_close, Me.ToolStripSeparator1})
        Me.ToolStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripHeader.Name = "ToolStripHeader"
        Me.ToolStripHeader.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripHeader.Size = New System.Drawing.Size(1108, 98)
        Me.ToolStripHeader.Stretch = True
        Me.ToolStripHeader.TabIndex = 0
        Me.ToolStripHeader.Text = "ToolStrip1"
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
        Me.btn_add.Size = New System.Drawing.Size(96, 98)
        Me.btn_add.Text = "เพิ่มสัญญา"
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
        Me.btn_edit.Image = Global.Apartment.com.My.Resources.Resources.printer48px
        Me.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_edit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_edit.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_edit.Size = New System.Drawing.Size(101, 98)
        Me.btn_edit.Text = "พิมพ์สัญญา"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txt_lastname2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_name2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_thaiid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_selectcustomer)
        Me.GroupBox1.Controls.Add(Me.btn_selectroom)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 109)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(673, 203)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลสัญญา"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(427, 153)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 34)
        Me.TextBox1.TabIndex = 20
        '
        'txt_lastname2
        '
        Me.txt_lastname2.Location = New System.Drawing.Point(427, 115)
        Me.txt_lastname2.MaxLength = 50
        Me.txt_lastname2.Name = "txt_lastname2"
        Me.txt_lastname2.Size = New System.Drawing.Size(212, 34)
        Me.txt_lastname2.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(353, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 26)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "นามสกุล  :"
        '
        'txt_name2
        '
        Me.txt_name2.Location = New System.Drawing.Point(427, 40)
        Me.txt_name2.MaxLength = 50
        Me.txt_name2.Name = "txt_name2"
        Me.txt_name2.Size = New System.Drawing.Size(124, 34)
        Me.txt_name2.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(386, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 26)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "ชื่อ  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(350, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 26)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "คำนำหน้า :"
        '
        'txt_thaiid
        '
        Me.txt_thaiid.Location = New System.Drawing.Point(427, 78)
        Me.txt_thaiid.MaxLength = 13
        Me.txt_thaiid.Name = "txt_thaiid"
        Me.txt_thaiid.Size = New System.Drawing.Size(212, 34)
        Me.txt_thaiid.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "หมายเลขบัตรประชาชน :"
        '
        'btn_selectcustomer
        '
        Me.btn_selectcustomer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_selectcustomer.Location = New System.Drawing.Point(255, 118)
        Me.btn_selectcustomer.Name = "btn_selectcustomer"
        Me.btn_selectcustomer.Size = New System.Drawing.Size(81, 34)
        Me.btn_selectcustomer.TabIndex = 14
        Me.btn_selectcustomer.Text = "เลือก"
        Me.btn_selectcustomer.UseVisualStyleBackColor = True
        '
        'btn_selectroom
        '
        Me.btn_selectroom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_selectroom.Location = New System.Drawing.Point(255, 81)
        Me.btn_selectroom.Name = "btn_selectroom"
        Me.btn_selectroom.Size = New System.Drawing.Size(81, 34)
        Me.btn_selectroom.TabIndex = 13
        Me.btn_selectroom.Text = "เลือก"
        Me.btn_selectroom.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 34)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(130, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(119, 34)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(130, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 34)
        Me.TextBox2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "วันที่ทำสัญญา :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รหัสผู้เช่า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "รหัสห้องพัก :"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(130, 43)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(119, 34)
        Me.txt_id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขที่สัญญา :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(693, 109)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(396, 203)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค่าเริ่มต้น"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 26)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "มิเตอร์ไฟเริ่มต้น  :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(153, 146)
        Me.TextBox7.MaxLength = 13
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(150, 34)
        Me.TextBox7.TabIndex = 29
        Me.TextBox7.Text = "0.00"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 26)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "มิเตอร์น้ำเริ่มต้น  :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(153, 109)
        Me.TextBox6.MaxLength = 13
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 34)
        Me.TextBox6.TabIndex = 27
        Me.TextBox6.Text = "0.00"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 26)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "ค่าห้องพัก  :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(153, 71)
        Me.TextBox5.MaxLength = 13
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 34)
        Me.TextBox5.TabIndex = 25
        Me.TextBox5.Text = "0.00"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "ค่าประกัน  :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(153, 33)
        Me.TextBox4.MaxLength = 13
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 34)
        Me.TextBox4.TabIndex = 23
        Me.TextBox4.Text = "0.00"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.Location = New System.Drawing.Point(11, 491)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1078, 170)
        Me.DataGridView1.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.ColumnHeadersHeight = 25
        Me.DataGridView2.Location = New System.Drawing.Point(11, 341)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1078, 124)
        Me.DataGridView2.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(12, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 26)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "รายละเอียดการซ่อมแซม"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(12, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 26)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "รายละเอียดสัญญา"
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
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 675)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1108, 28)
        Me.ToolStrip3.TabIndex = 17
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Cordia New", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(61, 25)
        Me.ToolStripLabel7.Text = "ทำสัญญา"
        '
        'MngPromise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 703)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1108, 703)
        Me.MinimumSize = New System.Drawing.Size(1108, 703)
        Me.Name = "MngPromise"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำสัญญา"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_selectcustomer As Button
    Friend WithEvents btn_selectroom As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_lastname2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_name2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_thaiid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
End Class
