<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MngCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngCustomer))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_phone1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_name1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
        '
        'ToolStripHeader
        '
        Me.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_search, Me.txt_search, Me.ComboBox, Me.ToolStripLabel1, Me.btn_add, Me.btn_save, Me.btn_edit, Me.btn_delete, Me.btn_clear, Me.btn_close, Me.ToolStripSeparator1})
        Me.ToolStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripHeader.Name = "ToolStripHeader"
        Me.ToolStripHeader.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripHeader.Size = New System.Drawing.Size(1000, 105)
        Me.ToolStripHeader.TabIndex = 0
        Me.ToolStripHeader.Text = "ToolStrip1"
        '
        'btn_search
        '
        Me.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_search.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.ggafiled.com.My.Resources.Resources.search48px
        Me.btn_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_search.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_search.Size = New System.Drawing.Size(76, 105)
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txt_search
        '
        Me.txt_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("TH SarabunPSK", 16.0!)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(150, 105)
        '
        'ComboBox
        '
        Me.ComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ComboBox.Font = New System.Drawing.Font("TH SarabunPSK", 16.0!)
        Me.ComboBox.Items.AddRange(New Object() {"-ค้นหาตาม", "รหัสลูกค้า", "ชื่อ-นามสกุล", "เบอร์โทรศัพท์"})
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(150, 105)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(79, 102)
        Me.ToolStripLabel1.Text = "ค้นหาด่วน"
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
        Me.btn_add.Size = New System.Drawing.Size(102, 105)
        Me.btn_add.Text = "เพิ่มข้อมูล"
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
        Me.btn_save.Size = New System.Drawing.Size(78, 105)
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Image = Global.ggafiled.com.My.Resources.Resources.edit48px
        Me.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_edit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_edit.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_edit.Size = New System.Drawing.Size(72, 105)
        Me.btn_edit.Text = "แก้ไข"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.btn_delete.Size = New System.Drawing.Size(72, 105)
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = Global.ggafiled.com.My.Resources.Resources.clear48px
        Me.btn_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_clear.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_clear.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_clear.Size = New System.Drawing.Size(72, 105)
        Me.btn_clear.Text = "ล้าง"
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 105)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_phone1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_name1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(976, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลลูกค้า"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(563, 78)
        Me.txt_address.MaxLength = 150
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(403, 39)
        Me.txt_address.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(508, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 33)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ที่อยู่ :"
        '
        'txt_phone1
        '
        Me.txt_phone1.Location = New System.Drawing.Point(135, 78)
        Me.txt_phone1.MaxLength = 10
        Me.txt_phone1.Name = "txt_phone1"
        Me.txt_phone1.Size = New System.Drawing.Size(354, 39)
        Me.txt_phone1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "เบอร์โทรศัพท์ :"
        '
        'txt_name1
        '
        Me.txt_name1.Location = New System.Drawing.Point(563, 35)
        Me.txt_name1.MaxLength = 50
        Me.txt_name1.Name = "txt_name1"
        Me.txt_name1.Size = New System.Drawing.Size(403, 39)
        Me.txt_name1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(513, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อ  :"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(135, 35)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(354, 39)
        Me.txt_id.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสลูกค้า :"
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
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 480)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1000, 29)
        Me.ToolStrip3.TabIndex = 16
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.ToolStripLabel7.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(120, 26)
        Me.ToolStripLabel7.Text = "การจัดการข้อมูลลูกค้า"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(976, 218)
        Me.DataGridView1.TabIndex = 17
        '
        'MngCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 509)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 509)
        Me.MinimumSize = New System.Drawing.Size(1000, 509)
        Me.Name = "MngCustomer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "การจัดการข้อมูลผู้เช่า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ComboBox As ToolStripComboBox
    Friend WithEvents txt_search As ToolStripTextBox
    Friend WithEvents btn_search As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_name1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_phone1 As TextBox
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents DataGridView1 As DataGridView
End Class
