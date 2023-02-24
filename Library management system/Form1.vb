Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim dt As New DataTable
    Dim cmd As MySqlCommand


    Public Function connect()
        Try
            cn = New MySqlConnection("server=192.168.35.65;userid=root;password=;database=biblio")
            Return 1

        Catch ex As Exception
            Return 0

        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = connect()
        If (a = 1) Then
            MessageBox.Show("connected")
            cn.Open()
            cmd = New MySqlCommand("select * from bibliographie", cn)
            dr = cmd.ExecuteReader
            dt.Load(dr)
            DataGridView1.DataSource = dt
            cn.Close()
        Else
            MessageBox.Show("not connected")
        End If


    End Sub
End Class
