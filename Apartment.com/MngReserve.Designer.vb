<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MngReserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngReserve))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripHeader = New System.Windows.Forms.ToolStrip()
        Me.btn_search = New System.Windows.Forms.ToolStripButton()
        Me.txt_search = New System.Windows.Forms.ToolStripTextBox()
        Me.ComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_search, Me.txt_search, Me.ComboBox, Me.ToolStripLabel1, Me.btn_add, Me.btn_save, Me.btn_edit, Me.btn_delete, Me.btn_clear, Me.btn_close, Me.ToolStripSeparator1})
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
        'ComboBox
        '
        Me.ComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ComboBox.Font = New System.Drawing.Font("Cordia New", 14.0!)
        Me.ComboBox.Items.AddRange(New Object() {"-ค้นหาตาม", "รหัสผู้เช่า", "คำนำหน้า", "ชื่อ-นามสกุล", "หมายเลขบัตรประชาชน", "เบอร์โทรศัพท์"})
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(150, 98)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_select)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Cordia New", 14.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(976, 159)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลการจอง"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"จอง", "ยกเลิก"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 26)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "สถานะ :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(794, 76)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 34)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(708, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "วันที่เข้าพัก :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(527, 76)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 34)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(460, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "วันที่จอง :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(310, 76)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 34)
        Me.TextBox3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "เบอร์โทรศัพท์ :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 34)
        Me.TextBox2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ค่าจอง :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(652, 36)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(302, 34)
        Me.TextBox4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(535, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ชื่อ-นามสกุลผู้จอง :"
        '
        'btn_select
        '
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_select.Location = New System.Drawing.Point(444, 36)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(81, 34)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(313, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(119, 34)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "รหัสห้องพัก :"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(77, 36)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(119, 34)
        Me.txt_id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัส :"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 278)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(976, 352)
        Me.DataGridView1.TabIndex = 4
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
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 646)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1000, 28)
        Me.ToolStrip3.TabIndex = 17
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Cordia New", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(68, 25)
        Me.ToolStripLabel7.Text = "จองห้องพัก"
        '
        'MngReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 674)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 674)
        Me.MinimumSize = New System.Drawing.Size(1000, 674)
        Me.Name = "MngReserve"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จองห้องพัก"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents btn_search As ToolStripButton
    Friend WithEvents txt_search As ToolStripTextBox
    Friend WithEvents ComboBox As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
End Class
