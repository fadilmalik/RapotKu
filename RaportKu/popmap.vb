Public Class popmap
    Dim sqlnya As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_mapel", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_mapel")
        gridmapel.DataSource = DS.Tables("tb_mapel")
        gridmapel.Enabled = True
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
    Private Sub gridmapel_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridmapel.RowHeaderMouseClick
        Dim u As Integer
        u = gridmapel.CurrentRow.Index
        Dashboard.kd_mapel.Text = gridmapel.Item(0, u).Value
        Me.Hide()
    End Sub
End Class