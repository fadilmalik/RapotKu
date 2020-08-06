
Imports System.Drawing.Printing
Imports System.Data.OleDb
Public Class Dashboard
    Dim sqlnya As String
    Dim sql As String
    Dim sq As String
    Dim s As String
    Dim ql As String
    Dim jk As String
    Dim gm As String
    Dim quel As String
    Dim baca As OleDbDataReader
    Dim maca As OleDbDataReader
    Private Sub bttnsiswa_Click(sender As Object, e As EventArgs) Handles bttnsiswa.Click
        pnlsiswa.BringToFront()
    End Sub

    Private Sub bttnnilai_Click(sender As Object, e As EventArgs) Handles bttnnilai.Click
        pnlnilai.BringToFront()
        namamenu.Text = "Menu Nilai"
    End Sub

    Private Sub bttnmapel_Click(sender As Object, e As EventArgs) Handles bttnmapel.Click
        pnlmapel.BringToFront()
        namamenu.Text = "Menu Mata Pelajaran"
    End Sub

    Private Sub bttnrayon_Click(sender As Object, e As EventArgs) Handles bttnrayon.Click
        pnlrayon.BringToFront()
        namamenu.Text = "Menu Rayon"
    End Sub

    Private Sub bttncetak_Click(sender As Object, e As EventArgs) Handles bttncetak.Click
        pnlcetak.BringToFront()
        namamenu.Text = "Menu Cetak"
    End Sub
    Private Sub bttnguru_Click(sender As Object, e As EventArgs) Handles bttnguru.Click
        pnlguru.BringToFront()
        namamenu.Text = "Menu Guru"
    End Sub
    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles cls.Click
        End
    End Sub
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_siswa", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_siswa")
        gridsiswa.DataSource = DS.Tables("tb_siswa")
        gridsiswa.Enabled = True
    End Sub
    Sub pd()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_nilai", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_nilai")
        gridnilai.DataSource = DS.Tables("tb_nilai")
        gridnilai.Enabled = True
    End Sub
    Sub panggil()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_mapel", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_mapel")
        gridmapel.DataSource = DS.Tables("tb_mapel")
        gridmapel.Enabled = True
    End Sub
    Sub data()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_rayon", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_rayon")
        gridrayon.DataSource = DS.Tables("tb_rayon")
        gridrayon.Enabled = True
    End Sub
    Sub suban()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM qw_rapot", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "qw_rapot")
        gridcetak.DataSource = DS.Tables("qw_rapot")
        gridcetak.Enabled = True
    End Sub
    Sub pangdat()
        konek()
        DA = New OleDbDataAdapter("SELECT * FROM tb_guru", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_guru")
        gridguru.DataSource = DS.Tables("tb_guru")
        gridguru.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        siswanis.Text = ""
        namasiswa.Text = ""
        alamat.Text = ""
        tempat.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ttl.ResetText()
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        angkatan.SelectedIndex = -1
        foto.ImageLocation = ""
        foto.Image = Nothing
    End Sub
    Sub jln()
        Dim abc As New System.Data.OleDb.OleDbCommand
        Call konek()
        abc.Connection = conn
        abc.CommandType = CommandType.Text
        abc.CommandText = sql
        abc.ExecuteNonQuery()
        abc.Dispose()
        kd_nilai.Clear()
        nisnilai.Clear()
        kd_mapel.Clear()
        nilai.Clear()
        jenis.SelectedIndex = -1
        semester.SelectedIndex = -1
        thn_ajar.SelectedIndex = -1
    End Sub
    Sub jl()
        Dim abe As New System.Data.OleDb.OleDbCommand
        Call konek()
        abe.Connection = conn
        abe.CommandType = CommandType.Text
        abe.CommandText = sq
        abe.ExecuteNonQuery()
        abe.Dispose()
        mapelkode.Clear()
        mapel.SelectedIndex = -1
    End Sub
    Sub road()
        Dim ace As New System.Data.OleDb.OleDbCommand
        Call konek()
        ace.Connection = conn
        ace.CommandType = CommandType.Text
        ace.CommandText = s
        ace.ExecuteNonQuery()
        ace.Dispose()
        kode_rayon.Clear()
        rayon.SelectedIndex = -1
        pmbbng.Clear()
    End Sub
    Sub lan()
        Dim cc As New System.Data.OleDb.OleDbCommand
        Call konek()
        cc.Connection = conn
        cc.CommandType = CommandType.Text
        cc.CommandText = ql
        cc.ExecuteNonQuery()
        cc.Dispose()
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    Sub que()
        Dim cc As New System.Data.OleDb.OleDbCommand
        Call konek()
        cc.Connection = conn
        cc.CommandType = CommandType.Text
        cc.CommandText = quel
        cc.ExecuteNonQuery()
        cc.Dispose()
        NIP.Clear()
        nmguru.Clear()
        mapelguru.SelectedIndex = -1
    End Sub
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call panggildata()
        Call pd()
        Call panggil()
        Call data()
        Call suban()
        Call pangdat()
        kode_rayon.Enabled = False
        ket.Enabled = False
        kd_mapel.Enabled = False
        nisnilai.Enabled = False
        kd_nilai.Enabled = False
        TextBox1.Enabled = False
        namamenu.Text = "Menu Siswa"
        konek()
        CMD = New OleDbCommand("select * from tb_nilai order by kd_nilai Desc", conn)
        baca = CMD.ExecuteReader
        baca.Read()
        If Not baca.HasRows Then
            kd_nilai.Text = "N" + "011"
        Else
            kd_nilai.Text = Val(Microsoft.VisualBasic.Mid(baca.Item("kd_nilai").ToString, 4, 3)) + 1
            If Len(kd_nilai.Text) = 1 Then
                kd_nilai.Text = "N00" & kd_nilai.Text & ""
            ElseIf Len(kd_nilai.Text) = 2 Then
                kd_nilai.Text = "N0" & kd_nilai.Text & ""
            ElseIf Len(kd_nilai.Text) = 3 Then
                kd_nilai.Text = "N" & kd_nilai.Text & ""
            End If
        End If
        konek()
        CMD = New OleDbCommand("select * from tb_mapel order by kd_mapel Desc", conn)
        maca = CMD.ExecuteReader
        maca.Read()
    End Sub
    '==========================================================================MENU SISWA====================================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlnya = "insert into tb_siswa(NIS,nama,jk,tempat,ttl,rombel,kd_rayon,alamat,angkatan,foto)values('" & siswanis.Text & "','" & namasiswa.Text & "','" & jk & "','" & tempat.Text & "','" & ttl.Text & "','" & ComboBox3.Text & "','" & ComboBox1.Text & "','" & alamat.Text & "','" & angkatan.Text & "','" & TextBox1.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlnya = "UPDATE tb_siswa set nama ='" & namasiswa.Text & "', jk = '" & jk & "',tempat = '" & tempat.Text & "', ttl ='" & ttl.Text & "',rombel='" & ComboBox3.Text & "' ,kd_rayon='" & ComboBox1.Text & "',alamat='" & alamat.Text & "',angkatan='" & angkatan.Text & "',foto='" & TextBox1.Text & "' where NIS='" & siswanis.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terubah")
        Call panggildata()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlnya = "delete from tb_siswa where NIS='" & siswanis.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        Call panggildata()
    End Sub
    Private Sub gridsiswa_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridsiswa.RowHeaderMouseClick
        Dim i As Integer
        i = gridsiswa.CurrentRow.Index
        siswanis.Text = gridsiswa.Item(0, i).Value
            namasiswa.Text = gridsiswa.Item(1, i).Value
            Dim j = gridsiswa.Item(2, i).Value
        If j = "Laki - laki" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf j = "Perempuan" Then
            RadioButton2.Checked = True
            RadioButton1.Checked = False
        End If
        tempat.Text = gridsiswa.Item(3, i).Value
        ttl.Text = gridsiswa.Item(4, i).Value
        ComboBox3.SelectedItem = gridsiswa.Item(5, i).Value
        ComboBox1.SelectedItem = gridsiswa.Item(6, i).Value
        alamat.Text = gridsiswa.Item(7, i).Value
        angkatan.SelectedItem = gridsiswa.Item(8, i).Value
        TextBox1.Text = gridsiswa.Item(9, i).Value
        foto.ImageLocation = gridsiswa.Item(9, i).Value
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        Button1.Enabled = False
    End Sub
    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_siswa where NIS like '%" & TextBox20.Text & "%' OR nama like '%" & TextBox20.Text & "%' ", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_siswa")
        gridsiswa.DataSource = DS.Tables("tb_siswa")
    End Sub
    Private PathFile As String = Nothing
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            foto.SizeMode = PictureBoxSizeMode.StretchImage
            foto.Image = New Bitmap(OpenFileDialog1.FileName)
            Button13.Enabled = True
            PathFile = OpenFileDialog1.FileName
            TextBox1.Text = OpenFileDialog1.FileName
            gm = OpenFileDialog1.FileName
            foto.Image = Image.FromFile(TextBox1.Text)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If (RadioButton1.Checked) Then
            jk = "Laki - laki"
        ElseIf (RadioButton2.Checked) Then
            jk = "Perempuan"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Clear()
        siswanis.Clear()
        namasiswa.Clear()
        alamat.Clear()
        tempat.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ttl.ResetText()
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        angkatan.SelectedIndex = -1
        foto.ImageLocation = ""
        foto.Image = Nothing
    End Sub
    '==========================================================================MENU NILAI===================================================================='
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "insert into tb_nilai(kd_nilai,NIS,kd_mapel,jns_ul,nilai,ket,semester,thn_ajar)values('" & kd_nilai.Text & "','" & nisnilai.Text & "','" & kd_mapel.Text & "','" & jenis.Text & "','" & nilai.Text & "','" & ket.Text & "','" & semester.Text & "','" & thn_ajar.Text & "')"
        Call jln()
        MsgBox("Data Berhasil Tersimpan")
        Call pd()
        konek()
        CMD = New OleDbCommand("select * from tb_nilai order by kd_nilai Desc", conn)
        baca = CMD.ExecuteReader
        baca.Read()
        kd_nilai.Text = Val(Microsoft.VisualBasic.Mid(baca.Item("kd_nilai").ToString, 4, 3)) + 1
        If Len(kd_nilai.Text) = 1 Then
            kd_nilai.Text = "N00" & kd_nilai.Text & ""
        ElseIf Len(kd_nilai.Text) = 2 Then
            kd_nilai.Text = "N0" & kd_nilai.Text & ""
        ElseIf Len(kd_nilai.Text) = 3 Then
            kd_nilai.Text = "N" & kd_nilai.Text & ""
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "UPDATE tb_nilai set NIS ='" & nisnilai.Text & "', kd_mapel = '" & kd_mapel.Text & "', nilai ='" & nilai.Text & "',jnl_ul = '" & jenis.Text & "',semester='" & semester.Text & "' ,ket = '" & ket.Text & "',thn_ajar='" & thn_ajar.Text & "' where kd_nilai='" & kd_nilai.Text & "'"
        Call jln()
        MsgBox("Data Berhasil Terubah")
        Call pd()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "delete from tb_nilai where kd_nilai='" & kd_nilai.Text & "'"
        Call jln()
        MsgBox("Data Berhasil Terhapus")
        Call pd()
    End Sub
    Private Sub gridnilai_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridnilai.RowHeaderMouseClick
        Dim a As Integer
        a = gridnilai.CurrentRow.Index
        kd_nilai.Text = gridnilai.Item(0, a).Value
        nisnilai.Text = gridnilai.Item(1, a).Value
        kd_mapel.Text = gridnilai.Item(2, a).Value
        nilai.Text = gridnilai.Item(4, a).Value
        jenis.SelectedItem = gridnilai.Item(3, a).Value
        semester.SelectedItem = gridnilai.Item(6, a).Value
        ket.Text = gridnilai.Item(7, a).Value
        thn_ajar.SelectedItem = gridnilai.Item(7, a).Value
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_nilai where kd_nilai like '%" & TextBox13.Text & "%' OR NIS like '%" & TextBox13.Text & "%' ", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_nilai")
        gridnilai.DataSource = DS.Tables("tb_nilai")
    End Sub
    Private Sub nilai_TextChanged(sender As Object, e As EventArgs) Handles nilai.TextChanged
        Dim n As String = Val(nilai.Text)
        If Val(n) = Nothing Then
            ket.Text = ""
        ElseIf Val(n) >= 75 Then
            ket.Text = "Kompeten"
        Else
            ket.Text = "Belum Kompeten"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        kd_nilai.Clear()
        nisnilai.Clear()
        kd_mapel.Clear()
        nilai.Clear()
        ket.Clear()
        jenis.SelectedIndex = -1
        semester.SelectedIndex = -1
        thn_ajar.SelectedIndex = -1
    End Sub
    '==========================================================================MENU MAPEL===================================================================='
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sq = "insert into tb_mapel(kd_mapel,mapel)values('" & mapelkode.Text & "','" & mapel.Text & "')"
        Call jl()
        MsgBox("Data Berhasil Tersimpan")
        Call panggil()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sq = "UPDATE tb_mapel set mapel ='" & mapel.Text & "' where kd_mapel='" & mapelkode.Text & "'"
        Call jl()
        MsgBox("Data Berhasil Terubah")
        Call panggil()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sq = "delete from tb_mapel where kd_mapel='" & mapelkode.Text & "'"
        Call jl()
        MsgBox("Data Berhasil Terhapus")
        Call panggil()
    End Sub
    Private Sub gridmapel_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridmapel.RowHeaderMouseClick
        Dim u As Integer
        u = gridmapel.CurrentRow.Index
        mapelkode.Text = gridmapel.Item(0, u).Value
        mapel.SelectedItem = gridmapel.Item(1, u).Value
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_mapel where kd_mapel like '%" & TextBox17.Text & "%' OR mapel like '%" & TextBox17.Text & "%' ", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_mapel")
        gridmapel.DataSource = DS.Tables("tb_mapel")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        mapelkode.Clear()
        mapel.SelectedIndex = -1
    End Sub
    '==========================================================================MENU RAYON===================================================================='
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim tb As New DataTable
        konek()
        DA = New OleDbDataAdapter("SELECT * FROM tb_rayon where kd_rayon = '" & kode_rayon.Text & "'", conn)
        DA.Fill(tb)
        If tb.Rows.Count > 0 Then
            MsgBox("Rayon Sudah Tersedia!")
            rayon.SelectedIndex = -1
            kode_rayon.Clear()
            pmbbng.Clear()
        Else
            s = "insert into tb_rayon(kd_rayon,rayon,pembimbing)values('" & kode_rayon.Text & "','" & rayon.Text & "','" & pmbbng.Text & "')"
            Call road()
            MsgBox("Data Berhasil Tersimpan")
            Call data()
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        s = "UPDATE tb_rayon set rayon ='" & rayon.Text & "', pembimbing = '" & pmbbng.Text & "' where kd_rayon='" & kode_rayon.Text & "'"
        Call road()
        MsgBox("Data Berhasil Terubah")
        Call data()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        s = "delete from tb_rayon where kd_rayon='" & kode_rayon.Text & "'"
        Call road()
        MsgBox("Data Berhasil Terhapus")
        Call data()
    End Sub
    Private Sub gridrayon_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridrayon.RowHeaderMouseClick
        Dim o As Integer = gridrayon.CurrentRow.Index
        kode_rayon.Text = gridrayon.Item(0, o).Value
        rayon.SelectedItem = gridrayon.Item(1, o).Value
        pmbbng.Text = gridrayon.Item(2, o).Value
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_rayon where kd_rayon like '%" & TextBox18.Text & "%' OR rayon like '%" & TextBox18.Text & "%' ", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_rayon")
        gridrayon.DataSource = DS.Tables("tb_rayon")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        kode_rayon.Text = -1
        rayon.SelectedIndex = -1
        pmbbng.Clear()
    End Sub

    Private Sub Rayon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rayon.SelectedIndexChanged
        Select Case rayon.SelectedItem
            Case Is = "Cisarua 1"
                kode_rayon.Text = "CIS01"
            Case Is = "Cisarua 2"
                kode_rayon.Text = "CIS02"
            Case Is = "Cisarua 3"
                kode_rayon.Text = "CIS03"
            Case Is = "Cisarua 4"
                kode_rayon.Text = "CIS04"
            Case Is = "Cisarua 5"
                kode_rayon.Text = "CIS05"
            Case Is = "Cisarua 6"
                kode_rayon.Text = "CIS06"
            Case Is = "Cicurug 1"
                kode_rayon.Text = "CIC01"
            Case Is = "Cicurug 2"
                kode_rayon.Text = "CIC02"
            Case Is = "Cicurug 3"
                kode_rayon.Text = "CIC03"
            Case Is = "Cicurug 4"
                kode_rayon.Text = "CIC04"
            Case Is = "Cicurug 5"
                kode_rayon.Text = "CIC05"
            Case Is = "Cicurug 6"
                kode_rayon.Text = "CIC06"
            Case Is = "Cicurug 7"
                kode_rayon.Text = "CIC07"
            Case Is = "Cibedug 1"
                kode_rayon.Text = "CIB01"
            Case Is = "Cibedug 2"
                kode_rayon.Text = "CIB02"
            Case Is = "Cicurug 3"
                kode_rayon.Text = "CIB03"
            Case Is = "Ciawi 1"
                kode_rayon.Text = "CIA01"
            Case Is = "Ciawi 2"
                kode_rayon.Text = "CIA02"
            Case Is = "Ciawi 3"
                kode_rayon.Text = "CIA03"
            Case Is = "Ciawi 4"
                kode_rayon.Text = "CIA04"
            Case Is = "Ciawi 5"
                kode_rayon.Text = "CIA05"
            Case Is = "Tajur 1"
                kode_rayon.Text = "TAJ01"
            Case Is = "Tajur 2"
                kode_rayon.Text = "TAJ02"
            Case Is = "Tajur 3"
                kode_rayon.Text = "TAJ03"
            Case Is = "Tajur 4"
                kode_rayon.Text = "TAJ04"
            Case Is = "Wikrama 1"
                kode_rayon.Text = "WIK01"
            Case Is = "Wikrama 2"
                kode_rayon.Text = "WIK02"
            Case Is = "Wikrama 3"
                kode_rayon.Text = "WIK03"
            Case Is = "Wikrama 4"
                kode_rayon.Text = "WIK04"
            Case Is = "Sukasari 1"
                kode_rayon.Text = "SUK01"
            Case Is = "Sukasari 2"
                kode_rayon.Text = "SUK02"
        End Select
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM qw_rapot where jns_ul like '%" & ComboBox4.Text & "%' and thn_ajar like '%" & ComboBox5.Text & "%' and semester like '%" & ComboBox2.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "qw_rapot")
        gridcetak.DataSource = DS.Tables("qw_rapot")
    End Sub

    Private Sub Tes_Click(sender As Object, e As EventArgs) Handles tes.Click
        konek()
        If Not (gridcetak.CurrentRow.Index = -1) Then
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM qw_jadi WHERE kd_nilai='" & gridcetak.Rows(gridcetak.CurrentRow.Index).Cells(0).Value & "';", conn)
        Else
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM qw_jadi WHERE kd_nilai like '%" & cetak.kd_nilai.Text & "%'", conn)
        End If
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "qw_jadi")
        cetak.gridprint.DataSource = DS.Tables("qw_jadi")
        cetak.Show()
    End Sub

    Private Sub gridcetak_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridcetak.RowHeaderMouseClick
        Dim ceet As Integer = gridcetak.CurrentRow.Index
        cetak.nama.Text = ": " + gridcetak.Item(2, ceet).Value
        cetak.NIS.Text = ": " + gridcetak.Item(1, ceet).Value
        cetak.thn_ajar.Text = ": " + gridcetak.Item(12, ceet).Value
        cetak.semester.Text = ": " + gridcetak.Item(11, ceet).Value
        cetak.kd_nilai.Text = gridcetak.Item(0, ceet).Value
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        popmap.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        popnis.Show()
    End Sub
    '===================================================MENU GURU =========================================================================================='
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        quel = "insert into tb_guru(NIP,guru,mapel)values('" & NIP.Text & "','" & nmguru.Text & "','" & mapelguru.Text & "')"
        Call que()
        MsgBox("Data Berhasil Tersimpan")
        Call pangdat()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        quel = "UPDATE tb_guru set guru ='" & nmguru.Text & "', mapel = '" & mapelguru.Text & "' where NIP='" & NIP.Text & "'"
        Call que()
        MsgBox("Data Berhasil Terubah")
        Call pangdat()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        quel = "delete from tb_rayon where NIP='" & NIP.Text & "'"
        Call que()
        MsgBox("Data Berhasil Terhapus")
        Call pangdat()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        NIP.Clear()
        nmguru.Clear()
        mapelguru.SelectedIndex = -1
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_guru where NIP like '%" & NIP.Text & "%' OR guru like '%" & nmguru.Text & "%' ", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_guru")
        gridguru.DataSource = DS.Tables("tb_guru")
    End Sub

    Private Sub gridguru_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridguru.RowHeaderMouseClick
        Dim gur As Integer = gridguru.CurrentRow.Index
        NIP.Text = gridguru.Item(0, gur).Value
        nmguru.Text = gridguru.Item(1, gur).Value
        mapelguru.Text = gridguru.Item(2, gur).Value
    End Sub
End Class