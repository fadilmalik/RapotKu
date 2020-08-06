<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cetak))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gridprint = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.NIS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.thn_ajar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.semester = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kd_nilai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN HASIL PENCAPAIAN SISWA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RaportKu.My.Resources.Resources.printer_
        Me.PictureBox1.Location = New System.Drawing.Point(920, 464)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'gridprint
        '
        Me.gridprint.AllowUserToAddRows = False
        Me.gridprint.AllowUserToDeleteRows = False
        Me.gridprint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridprint.BackgroundColor = System.Drawing.Color.White
        Me.gridprint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridprint.Enabled = False
        Me.gridprint.Location = New System.Drawing.Point(12, 96)
        Me.gridprint.Name = "gridprint"
        Me.gridprint.ReadOnly = True
        Me.gridprint.RowTemplate.ReadOnly = True
        Me.gridprint.Size = New System.Drawing.Size(786, 370)
        Me.gridprint.TabIndex = 2
        Me.gridprint.VirtualMode = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'nama
        '
        Me.nama.BackColor = System.Drawing.Color.White
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nama.Enabled = False
        Me.nama.ForeColor = System.Drawing.Color.Black
        Me.nama.Location = New System.Drawing.Point(217, 70)
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Size = New System.Drawing.Size(100, 13)
        Me.nama.TabIndex = 4
        '
        'NIS
        '
        Me.NIS.BackColor = System.Drawing.Color.White
        Me.NIS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NIS.Enabled = False
        Me.NIS.ForeColor = System.Drawing.Color.Black
        Me.NIS.Location = New System.Drawing.Point(217, 46)
        Me.NIS.Name = "NIS"
        Me.NIS.ReadOnly = True
        Me.NIS.Size = New System.Drawing.Size(100, 13)
        Me.NIS.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NIS"
        '
        'thn_ajar
        '
        Me.thn_ajar.BackColor = System.Drawing.Color.White
        Me.thn_ajar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.thn_ajar.Enabled = False
        Me.thn_ajar.ForeColor = System.Drawing.Color.Black
        Me.thn_ajar.Location = New System.Drawing.Point(528, 70)
        Me.thn_ajar.Name = "thn_ajar"
        Me.thn_ajar.ReadOnly = True
        Me.thn_ajar.Size = New System.Drawing.Size(100, 13)
        Me.thn_ajar.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tahun Pelajaran "
        '
        'semester
        '
        Me.semester.BackColor = System.Drawing.Color.White
        Me.semester.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.semester.Enabled = False
        Me.semester.ForeColor = System.Drawing.Color.Black
        Me.semester.Location = New System.Drawing.Point(528, 46)
        Me.semester.Name = "semester"
        Me.semester.ReadOnly = True
        Me.semester.Size = New System.Drawing.Size(100, 13)
        Me.semester.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Semester "
        '
        'kd_nilai
        '
        Me.kd_nilai.Location = New System.Drawing.Point(920, 437)
        Me.kd_nilai.Name = "kd_nilai"
        Me.kd_nilai.Size = New System.Drawing.Size(62, 20)
        Me.kd_nilai.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(917, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kode Nilai :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RaportKu.My.Resources.Resources.logo_wk
        Me.PictureBox2.Location = New System.Drawing.Point(33, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(920, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintForm2
        '
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 555)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.kd_nilai)
        Me.Controls.Add(Me.thn_ajar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.semester)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NIS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridprint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cetak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cetak"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gridprint As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents NIS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents thn_ajar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents semester As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents kd_nilai As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintForm2 As PowerPacks.Printing.PrintForm
End Class
