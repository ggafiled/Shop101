<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SeparatorMain = New Bunifu.Framework.UI.BunifuSeparator()
        Me.SeparatorSplit = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Subtitle = New System.Windows.Forms.Label()
        Me.Subdetail = New System.Windows.Forms.Label()
        Me.Subhead = New System.Windows.Forms.Label()
        Me.PictureStatus = New System.Windows.Forms.PictureBox()
        CType(Me.PictureStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeparatorMain
        '
        Me.SeparatorMain.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorMain.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SeparatorMain.LineThickness = 2
        Me.SeparatorMain.Location = New System.Drawing.Point(4, 6)
        Me.SeparatorMain.Name = "SeparatorMain"
        Me.SeparatorMain.Size = New System.Drawing.Size(10, 70)
        Me.SeparatorMain.TabIndex = 0
        Me.SeparatorMain.Transparency = 255
        Me.SeparatorMain.Vertical = True
        '
        'SeparatorSplit
        '
        Me.SeparatorSplit.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorSplit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SeparatorSplit.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SeparatorSplit.LineThickness = 1
        Me.SeparatorSplit.Location = New System.Drawing.Point(0, 77)
        Me.SeparatorSplit.Name = "SeparatorSplit"
        Me.SeparatorSplit.Size = New System.Drawing.Size(243, 10)
        Me.SeparatorSplit.TabIndex = 1
        Me.SeparatorSplit.Transparency = 255
        Me.SeparatorSplit.Vertical = False
        '
        'Subtitle
        '
        Me.Subtitle.AutoSize = True
        Me.Subtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Subtitle.Location = New System.Drawing.Point(17, 6)
        Me.Subtitle.Name = "Subtitle"
        Me.Subtitle.Size = New System.Drawing.Size(55, 17)
        Me.Subtitle.TabIndex = 3
        Me.Subtitle.Text = "Subtitle"
        '
        'Subdetail
        '
        Me.Subdetail.AutoSize = True
        Me.Subdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Subdetail.Location = New System.Drawing.Point(17, 60)
        Me.Subdetail.Name = "Subdetail"
        Me.Subdetail.Size = New System.Drawing.Size(67, 17)
        Me.Subdetail.TabIndex = 4
        Me.Subdetail.Text = "Subdetail"
        '
        'Subhead
        '
        Me.Subhead.AutoSize = True
        Me.Subhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Subhead.Location = New System.Drawing.Point(54, 30)
        Me.Subhead.Name = "Subhead"
        Me.Subhead.Size = New System.Drawing.Size(87, 24)
        Me.Subhead.TabIndex = 5
        Me.Subhead.Text = "Subhead"
        '
        'PictureStatus
        '
        Me.PictureStatus.Image = Global.Apartment.com.My.Resources.Resources.notification
        Me.PictureStatus.Location = New System.Drawing.Point(20, 29)
        Me.PictureStatus.Name = "PictureStatus"
        Me.PictureStatus.Size = New System.Drawing.Size(28, 28)
        Me.PictureStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureStatus.TabIndex = 2
        Me.PictureStatus.TabStop = False
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Controls.Add(Me.Subhead)
        Me.Controls.Add(Me.Subdetail)
        Me.Controls.Add(Me.Subtitle)
        Me.Controls.Add(Me.PictureStatus)
        Me.Controls.Add(Me.SeparatorSplit)
        Me.Controls.Add(Me.SeparatorMain)
        Me.Name = "Tasks"
        Me.Size = New System.Drawing.Size(243, 87)
        CType(Me.PictureStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeparatorMain As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents SeparatorSplit As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureStatus As PictureBox
    Friend WithEvents Subtitle As Label
    Friend WithEvents Subdetail As Label
    Friend WithEvents Subhead As Label
End Class
