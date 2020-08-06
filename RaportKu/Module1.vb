Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As DataSet
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public loc As String
    Public Sub konek()
        loc = "provider=microsoft.jet.oledb.4.0;data source=rapot.mdb"
        conn = New OleDbConnection(loc)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
