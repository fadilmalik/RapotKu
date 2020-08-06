Imports System.Data.OleDb
Public Class Login

    Public da As OleDbDataAdapter
    Private Sub bttnlog_Click(sender As Object, e As EventArgs) Handles bttnlog.Click
        Dim tb As New DataTable
        konek()
        da = New OleDbDataAdapter("SELECT * FROM tb_login where ID = '" & txtuser.Text & "' and pass='" & txtpass.Text & "'", conn)
        da.Fill(tb)
        If tb.Rows.Count > 0 Then
            MsgBox("Login Sukses!")
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Username/Password yang anda masukan salah!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call konek()
    End Sub

    Private Sub txtpass_OnValueChanged(sender As Object, e As EventArgs) Handles txtpass.OnValueChanged
        txtpass.isPassword = True
        If txtpass.Text = "" Then
            pass.Show()
        Else
            pass.Hide()
        End If
    End Sub
    Private Sub Txtuser_OnValueChanged(sender As Object, e As EventArgs) Handles txtuser.OnValueChanged
        If txtuser.Text = "" Then
            user.Show()
        Else
            user.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        End
    End Sub

End Class
