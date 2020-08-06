<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.bttnlog = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.HintForeColor = System.Drawing.Color.Empty
        Me.txtuser.HintText = ""
        Me.txtuser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtuser.isPassword = False
        Me.txtuser.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtuser.LineIdleColor = System.Drawing.Color.DarkGray
        Me.txtuser.LineMouseHoverColor = System.Drawing.Color.DarkGray
        Me.txtuser.LineThickness = 3
        Me.txtuser.Location = New System.Drawing.Point(368, 162)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(342, 41)
        Me.txtuser.TabIndex = 0
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(117, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RaportKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Aplikasi Pengolahan Nilai Raport"
        '
        'txtpass
        '
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.HintForeColor = System.Drawing.Color.Empty
        Me.txtpass.HintText = ""
        Me.txtpass.isPassword = False
        Me.txtpass.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtpass.LineIdleColor = System.Drawing.Color.DarkGray
        Me.txtpass.LineMouseHoverColor = System.Drawing.Color.DarkGray
        Me.txtpass.LineThickness = 3
        Me.txtpass.Location = New System.Drawing.Point(368, 211)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(342, 41)
        Me.txtpass.TabIndex = 6
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.RaportKu.My.Resources.Resources.Password
        Me.PictureBox4.Location = New System.Drawing.Point(674, 217)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'bttnlog
        '
        Me.bttnlog.ActiveBorderThickness = 1
        Me.bttnlog.ActiveCornerRadius = 20
        Me.bttnlog.ActiveFillColor = System.Drawing.Color.Teal
        Me.bttnlog.ActiveForecolor = System.Drawing.Color.White
        Me.bttnlog.ActiveLineColor = System.Drawing.Color.Teal
        Me.bttnlog.BackColor = System.Drawing.SystemColors.Control
        Me.bttnlog.BackgroundImage = CType(resources.GetObject("bttnlog.BackgroundImage"), System.Drawing.Image)
        Me.bttnlog.ButtonText = "LOGIN"
        Me.bttnlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnlog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnlog.ForeColor = System.Drawing.Color.White
        Me.bttnlog.IdleBorderThickness = 1
        Me.bttnlog.IdleCornerRadius = 20
        Me.bttnlog.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.bttnlog.IdleForecolor = System.Drawing.Color.White
        Me.bttnlog.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.bttnlog.Location = New System.Drawing.Point(368, 258)
        Me.bttnlog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bttnlog.Name = "bttnlog"
        Me.bttnlog.Size = New System.Drawing.Size(342, 50)
        Me.bttnlog.TabIndex = 8
        Me.bttnlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RaportKu.My.Resources.Resources.logo_wk
        Me.PictureBox2.Location = New System.Drawing.Point(469, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RaportKu.My.Resources.Resources.student
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 313)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RaportKu.My.Resources.Resources.User
        Me.PictureBox3.Location = New System.Drawing.Point(674, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.SystemColors.Control
        Me.user.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.DarkGray
        Me.user.Location = New System.Drawing.Point(374, 173)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(98, 15)
        Me.user.TabIndex = 11
        Me.user.Text = "Type Username"
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.BackColor = System.Drawing.SystemColors.Control
        Me.pass.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.DarkGray
        Me.pass.Location = New System.Drawing.Point(374, 223)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(133, 15)
        Me.pass.TabIndex = 12
        Me.pass.Text = "Type Your Password"
        '
        'cancel
        '
        Me.cancel.ActiveBorderThickness = 1
        Me.cancel.ActiveCornerRadius = 20
        Me.cancel.ActiveFillColor = System.Drawing.Color.Gray
        Me.cancel.ActiveForecolor = System.Drawing.Color.White
        Me.cancel.ActiveLineColor = System.Drawing.Color.Gray
        Me.cancel.BackColor = System.Drawing.SystemColors.Control
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.ButtonText = "CANCEL"
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.IdleBorderThickness = 1
        Me.cancel.IdleCornerRadius = 20
        Me.cancel.IdleFillColor = System.Drawing.Color.LightGray
        Me.cancel.IdleForecolor = System.Drawing.Color.White
        Me.cancel.IdleLineColor = System.Drawing.Color.DarkGray
        Me.cancel.Location = New System.Drawing.Point(368, 301)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(342, 50)
        Me.cancel.TabIndex = 13
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 381)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.bttnlog)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents bttnlog As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents user As Label
    Friend WithEvents pass As Label
    Friend WithEvents cancel As Bunifu.Framework.UI.BunifuThinButton2
End Class
