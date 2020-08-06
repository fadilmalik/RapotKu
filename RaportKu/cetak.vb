Public Class cetak
    Dim ql As String
    Dim mapel As String

    Sub cet()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM qw_jadi", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "qw_jadi")
        gridprint.DataSource = DS.Tables("qw_jadi")
        gridprint.Enabled = True
    End Sub
    Sub lan()
        Dim cc As New System.Data.OleDb.OleDbCommand
        Call konek()
        cc.Connection = conn
        cc.CommandType = CommandType.Text
        cc.CommandText = ql
        cc.ExecuteNonQuery()
        cc.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub cetak_Load(sender As Object, e As EventArgs) Handles Me.Load
        gridprint.Columns(0).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class