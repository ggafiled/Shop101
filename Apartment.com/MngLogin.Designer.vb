<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MngLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MngLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.lbggafiledname = New System.Windows.Forms.Label()
        Me.lbNewVersion = New System.Windows.Forms.Label()
        Me.txtUser = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPwd = New Bunifu.Framework.UI.BunifuTextbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.imgExit = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        '
        'lbggafiledname
        '
        Me.lbggafiledname.AutoSize = True
        Me.lbggafiledname.Font = New System.Drawing.Font("TH SarabunPSK", 26.0!)
        Me.lbggafiledname.ForeColor = System.Drawing.Color.Black
        Me.lbggafiledname.Location = New System.Drawing.Point(99, 160)
        Me.lbggafiledname.Name = "lbggafiledname"
        Me.lbggafiledname.Size = New System.Drawing.Size(165, 39)
        Me.lbggafiledname.TabIndex = 11
        Me.lbggafiledname.Text = "ร้านกระยาสารท"
        Me.lbggafiledname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNewVersion
        '
        Me.lbNewVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbNewVersion.ForeColor = System.Drawing.Color.Black
        Me.lbNewVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbNewVersion.Location = New System.Drawing.Point(224, 368)
        Me.lbNewVersion.Name = "lbNewVersion"
        Me.lbNewVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbNewVersion.Size = New System.Drawing.Size(112, 22)
        Me.lbNewVersion.TabIndex = 13
        Me.lbNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtUser.BackgroundImage = CType(resources.GetObject("txtUser.BackgroundImage"), System.Drawing.Image)
        Me.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUser.Font = New System.Drawing.Font("TH SarabunPSK", 8.25!)
        Me.txtUser.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtUser.Icon = CType(resources.GetObject("txtUser.Icon"), System.Drawing.Image)
        Me.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUser.Location = New System.Drawing.Point(51, 207)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(250, 43)
        Me.txtUser.TabIndex = 1
        Me.txtUser.text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ggafiled.com.My.Resources.Resources.store
        Me.PictureBox2.Location = New System.Drawing.Point(106, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtPwd.BackgroundImage = CType(resources.GetObject("txtPwd.BackgroundImage"), System.Drawing.Image)
        Me.txtPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPwd.Font = New System.Drawing.Font("TH SarabunPSK", 8.25!)
        Me.txtPwd.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtPwd.Icon = CType(resources.GetObject("txtPwd.Icon"), System.Drawing.Image)
        Me.txtPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPwd.Location = New System.Drawing.Point(51, 256)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(250, 43)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.text = ""
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 5
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = CType(resources.GetObject("btnLogin.Iconimage"), System.Drawing.Image)
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0R
        Me.btnLogin.IconVisible = False
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(51, 321)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogin.OnHovercolor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(250, 48)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'imgExit
        '
        Me.imgExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgExit.Image = Global.ggafiled.com.My.Resources.Resources.remove_symbol
        Me.imgExit.Location = New System.Drawing.Point(306, 11)
        Me.imgExit.Name = "imgExit"
        Me.imgExit.Size = New System.Drawing.Size(28, 27)
        Me.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgExit.TabIndex = 6
        Me.imgExit.TabStop = False
        '
        'MngLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 394)
        Me.Controls.Add(Me.lbNewVersion)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lbggafiledname)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.imgExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MngLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MngLogin"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbggafiledname As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPwd As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents imgExit As PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents lbNewVersion As Label
End Class
