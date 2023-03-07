Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cn As MySqlConnection
    Dim dr, dr1 As MySqlDataReader
    Dim dt As New DataTable
    Dim cmd, cmd1 As MySqlCommand
    Public Sub connect()
        Try
            cn = New MySqlConnection("server=localhost;userid=root;password=;database=sysmanbibliotheque")
            cn.Open()


        Catch ex As Exception
            MessageBox.Show("echec de connexion")

        End Try

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''connect()
        ''cmd = New MySqlCommand("select username,password,first_name,last_name,phone_num,status from adherent", cn)
        ''dr = cmd.ExecuteReader
        ''dt.Load(dr)
        ''DataGridView1.DataSource() = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        cmd = New MySqlCommand("select * from book where title = '" + TextBox1.Text + "'", cn)
        cmd.ExecuteReader()
        dr1 = cmd.ExecuteReader()
        DataGridView1.DataSource = dr
        cn.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ''connect()
        ''cmd = New MySqlCommand("select * from book where title like '" + TextBox1.Text + "%'", cn)
        ''dr = cmd.ExecuteReader()
        ''DataGridView1.DataSource = dr
        ''cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class