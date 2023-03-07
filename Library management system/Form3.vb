Imports MySql.Data.MySqlClient
Public Class Form3
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
        Try
            connect()
            cmd = New MySqlCommand("insert into adherent values('" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox6.Text + "','" + DateTimePicker1.Value + "')", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Me.Hide()
        Form1.Show()
    End Sub
End Class