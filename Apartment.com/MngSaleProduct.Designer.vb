<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MngSaleProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngSaleProduct))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.สินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ประเภทสินค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคาต่อหน่วย = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนเงิน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStripHeader = New System.Windows.Forms.ToolStrip()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.สินค้า, Me.ประเภทสินค้า, Me.จำนวน, Me.ราคาต่อหน่วย, Me.จำนวนเงิน})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(648, 259)
        Me.DataGridView1.TabIndex = 9
        '
        'สินค้า
        '
        Me.สินค้า.HeaderText = "สินค้า"
        Me.สินค้า.Name = "สินค้า"
        '
        'ประเภทสินค้า
        '
        Me.ประเภทสินค้า.HeaderText = "ประเภทสินค้า"
        Me.ประเภทสินค้า.Name = "ประเภทสินค้า"
        '
        'จำนวน
        '
        Me.จำนวน.HeaderText = "จำนวน"
        Me.จำนวน.Name = "จำนวน"
        '
        'ราคาต่อหน่วย
        '
        Me.ราคาต่อหน่วย.HeaderText = "ราคาต่อหน่วย"
        Me.ราคาต่อหน่วย.Name = "ราคาต่อหน่วย"
        '
        'จำนวนเงิน
        '
        Me.จำนวนเงิน.HeaderText = "จำนวนเงิน"
        Me.จำนวนเงิน.Name = "จำนวนเงิน"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BunifuImageButton2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(677, 171)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 310)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดข้อมูลบริการ"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton2.Image = Global.ggafiled.com.My.Resources.Resources.magnifying_glass__1_
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(415, 32)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(44, 39)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(416, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "บาท"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(144, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(254, 39)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 33)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "เงินทอน :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "บาท"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 39)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "รับเงินมา :"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(144, 32)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(254, 39)
        Me.txt_password.TabIndex = 4
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสสมาชิก :"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 578)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1187, 29)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 26)
        Me.ToolStripLabel1.Text = "หน้าการขาย"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 26)
        Me.ToolStripLabel2.Text = "วันที่ : "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(105, 26)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(658, 112)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รวมเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TH SarabunPSK", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 71)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 196)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(658, 285)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_productID)
        Me.GroupBox4.Controls.Add(Me.BunifuImageButton1)
        Me.GroupBox4.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(677, 95)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(502, 74)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'txt_productID
        '
        Me.txt_productID.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_productID.Location = New System.Drawing.Point(11, 25)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.Size = New System.Drawing.Size(432, 39)
        Me.txt_productID.TabIndex = 5
        Me.txt_productID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = Global.ggafiled.com.My.Resources.Resources.magnifying_glass__1_
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(449, 25)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(44, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 470)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(658, 102)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(475, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 33)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "0000000000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(363, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 33)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "จำนวนหน่วย :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(149, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 33)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "รอใส่ข้อมูลหากมี"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 33)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "ชื่อลูกค้า :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(475, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 33)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "0000000000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(331, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 33)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "เลขที่ใบกำกับภาษี :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 33)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Adminstrator(Admin)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 33)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "พนักงาน :"
        '
        'ToolStripHeader
        '
        Me.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_close, Me.btn_add, Me.btn_save, Me.ToolStripButton1, Me.btn_delete, Me.ToolStripSeparator1})
        Me.ToolStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripHeader.Name = "ToolStripHeader"
        Me.ToolStripHeader.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripHeader.Size = New System.Drawing.Size(1187, 105)
        Me.ToolStripHeader.TabIndex = 15
        Me.ToolStripHeader.Text = "ToolStrip1"
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = Global.ggafiled.com.My.Resources.Resources.close48px
        Me.btn_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_close.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_close.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_close.Size = New System.Drawing.Size(72, 105)
        Me.btn_close.Text = "ปิด"
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Image = Global.ggafiled.com.My.Resources.Resources.new_user48px
        Me.btn_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_add.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_add.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_add.Size = New System.Drawing.Size(129, 105)
        Me.btn_add.Text = "เริ่มบิลใหม่ F1"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.ggafiled.com.My.Resources.Resources.save48px
        Me.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_save.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_save.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_save.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_save.Size = New System.Drawing.Size(100, 105)
        Me.btn_save.Text = "บันทึก F3"
        Me.btn_save.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.ggafiled.com.My.Resources.Resources.printer48px
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton1.Size = New System.Drawing.Size(130, 105)
        Me.ToolStripButton1.Text = "คิดเงินทอน F2"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.ggafiled.com.My.Resources.Resources.delete48px
        Me.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_delete.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_delete.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_delete.Size = New System.Drawing.Size(80, 105)
        Me.btn_delete.Text = "ลบ F4"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 105)
        '
        'MngSaleProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 607)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStripHeader)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MngSaleProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลบริการเสริม"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents สินค้า As DataGridViewTextBoxColumn
    Friend WithEvents ประเภทสินค้า As DataGridViewTextBoxColumn
    Friend WithEvents จำนวน As DataGridViewTextBoxColumn
    Friend WithEvents ราคาต่อหน่วย As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนเงิน As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_productID As TextBox
End Class
