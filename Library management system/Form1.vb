Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cn As MySqlConnection
    Dim dr As MySqlDataReader
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect()
            cmd = New MySqlCommand("select status from adherent where username = '" + TextBox1.Text + "'", cn)
            cmd1 = New MySqlCommand("select password from adherent where username = '" + TextBox1.Text + "'", cn)
            cmd.ExecuteScalar()
            cmd1.ExecuteScalar()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ''If (cmd.ExecuteScalar() = "admin" And TextBox2.Text = cmd1.ExecuteScalar()) Then
        If (TextBox1.Text = "root" And TextBox2.Text = "root") Then

            Me.Hide()
            Form4.Show()

            TextBox1.Clear()
            TextBox2.Clear()

        Else
            ''If (TextBox2.Text = cmd1.ExecuteScalar()) Then
            Me.Hide()
                Form2.Show()
                TextBox1.Clear()
                TextBox2.Clear()
            ''Else    MessageBox.Show("username doesn't match password")
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form3.Show()

    End Sub
End Class
