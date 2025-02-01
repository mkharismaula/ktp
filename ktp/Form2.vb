Imports MySql.Data.MySqlClient

Public Class FormLogin

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim rd As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Sub FunctionKoneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=db_ktp"

        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Dim isValid As Boolean = False

        Try
            conn.Open()
            If username = "admin" Then
                str = "SELECT COUNT(*) 
                        FROM users u
                        WHERE u.username=@username AND u.password=@password"
            Else
                str = "SELECT COUNT(*) 
                        FROM users u 
                        JOIN ktp k on k.nik = u.nik
                        WHERE u.username=@username AND u.password=@password"
            End If

            Using cmd As New MySqlCommand(str, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password) ' Note: Use hashed passwords in production

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    isValid = True
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Return isValid
    End Function

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunctionKoneksi()
        ' Set the PasswordChar property to hide the password input
        txtPassword.PasswordChar = "*"c ' Use 'c' to denote a Char type
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Check if the username and password are valid
        If ValidateUser(username, password) Then
            MessageBox.Show("Login successful!")
            ' Show the dashboard form
            Dim dashboard As New FormDashboard()
            dashboard.Show() ' Show the dashboard form
            Me.Hide() ' Hide the login form
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub TxtLinkDisini_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TxtLinkDisini.LinkClicked
        Dim cekNik As New FormCekNik()
        cekNik.Show()
    End Sub
End Class