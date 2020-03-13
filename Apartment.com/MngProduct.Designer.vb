<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MngProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngProduct))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripHeader = New System.Windows.Forms.ToolStrip()
        Me.btn_add = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_delete = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStripHeader.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(715, 105)
        Me.Panel1.TabIndex = 6
        '
        'ToolStripHeader
        '
        Me.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_add, Me.btn_save, Me.btn_edit, Me.btn_delete, Me.btn_clear, Me.btn_close, Me.ToolStripSeparator1})
        Me.ToolStripHeader.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripHeader.Name = "ToolStripHeader"
        Me.ToolStripHeader.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripHeader.Size = New System.Drawing.Size(715, 105)
        Me.ToolStripHeader.Stretch = True
        Me.ToolStripHeader.TabIndex = 0
        Me.ToolStripHeader.Text = "ToolStrip1"
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
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
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 105)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.Location = New System.Drawing.Point(11, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(693, 216)
        Me.DataGridView1.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_price)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btn_select)
        Me.GroupBox2.Controls.Add(Me.txt_name)
        Me.GroupBox2.Controls.Add(Me.txt_type)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 112)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(693, 129)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดข้อมูลสินค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 33)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "บาท"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(487, 78)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(131, 39)
        Me.txt_price.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 33)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ราคาต่อหน่วย :"
        '
        'btn_select
        '
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_select.Location = New System.Drawing.Point(294, 79)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(81, 34)
        Me.btn_select.TabIndex = 14
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(381, 35)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(285, 39)
        Me.txt_name.TabIndex = 4
        '
        'txt_type
        '
        Me.txt_type.Enabled = False
        Me.txt_type.Location = New System.Drawing.Point(121, 78)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(167, 39)
        Me.txt_type.TabIndex = 3
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(121, 35)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(167, 39)
        Me.txt_id.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ประเภทสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า :"
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 480)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(715, 29)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 14.0!)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 26)
        Me.ToolStripLabel1.Text = "ข้อมูลสินค้า"
        '
        'MngProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 509)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(715, 509)
        Me.MinimumSize = New System.Drawing.Size(715, 509)
        Me.Name = "MngProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ซื้อบริการเสริม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStripHeader.ResumeLayout(False)
        Me.ToolStripHeader.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripHeader As ToolStrip
    Friend WithEvents btn_add As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_delete As ToolStripButton
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents txt_type As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label4 As Label
End Class
