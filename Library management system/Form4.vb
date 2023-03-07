Imports MySql.Data.MySqlClient
Public Class Form4
    Dim cn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim dt As New DataTable
    Dim cmd As MySqlCommand

    Public Sub connect()
        Try
            cn = New MySqlConnection("server=localhost;userid=root;password=;database=sysmanbibliotheque")
            cn.Open()


        Catch ex As Exception
            MessageBox.Show("echec de connexion")

        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()


    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect()
            cmd = New MySqlCommand("select count(*) from adherent", cn)
            Label2.Text = cmd.ExecuteScalar
            cn.Close()
            connect()
            cmd = New MySqlCommand("select count(*) from loan", cn)
            Label3.Text = cmd.ExecuteScalar
            cn.Close()
            connect()
            cmd = New MySqlCommand("select count(*) from return_book", cn)
            Label4.Text = cmd.ExecuteScalar
            cn.Close()
            connect()
            cmd = New MySqlCommand("select count(*) from book", cn)
            Label5.Text = cmd.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class