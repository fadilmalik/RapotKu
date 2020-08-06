Public Class popnis
    Dim sqlnya As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_siswa", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_siswa")
        gridnis.DataSource = DS.Tables("tb_siswa")
        gridnis.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Private Sub Popmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    Private Sub gridnis_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridnis.RowHeaderMouseClick
        Dim u As Integer
        u = gridnis.CurrentRow.Index
        Dashboard.nisnilai.Text = gridnis.Item(0, u).Value
        Me.Hide()
    End Sub
End Class