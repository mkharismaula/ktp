Imports MySql.Data.MySqlClient

Public Class FormDashboard

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

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunctionKoneksi()

        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Function LoadData()
        ds = New DataSet
        Dim query As String = "select * from ktp"
        da = New MySqlDataAdapter(query, conn)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Function

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        ' Show a message box asking if the user wants to close the application
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the result of the message box
        If result = DialogResult.Yes Then
            Dim login As New FormLogin()
            login.Show()
            Me.Hide()
        Else
            ' Do nothing, stay on the form
        End If
    End Sub
End Class
