<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoAboutDevelop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoAboutDevelop))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.imgExit = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'imgExit
        '
        Me.imgExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgExit.Image = Global.Apartment.com.My.Resources.Resources.remove_symbol
        Me.imgExit.Location = New System.Drawing.Point(383, 12)
        Me.imgExit.Name = "imgExit"
        Me.imgExit.Size = New System.Drawing.Size(28, 27)
        Me.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgExit.TabIndex = 7
        Me.imgExit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 26.0!)
        Me.Label1.Location = New System.Drawing.Point(117, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 48)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Apartment.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 26.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 48)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ระบบจัดการหอพัก ชุดทดลองใช้งาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(144, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Version 1.0.0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(144, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 37)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "IG: GGAFILED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(118, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "LINE: FOTAFOTA125"
        '
        'InfoAboutDevelop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 332)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(423, 332)
        Me.MinimumSize = New System.Drawing.Size(423, 332)
        Me.Name = "InfoAboutDevelop"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoAboutDevelop"
        CType(Me.imgExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents imgExit As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
