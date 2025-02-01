Imports MySql.Data.MySqlClient

Public Class FormCekNik

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

    Private Sub FormCekNik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunctionKoneksi()

        DisableTextBoxes()
    End Sub

    Private Sub SearchByNik(nik As String)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM ktp WHERE nik = @nik"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nik", nik)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear previous results
                    'dataGridViewResults.Rows.Clear()

                    If reader.HasRows Then
                        reader.Read() ' Read the first row.
                        TxtNamaLengkap.Text = reader("nama_lengkap").ToString()
                        TxtAlamat.Text = reader("alamat").ToString()
                        TxtTanggalLahir.Text = reader("tanggal_lahir").ToString()
                        TxtTempatLahir.Text = reader("tempat_lahir").ToString()

                        ' Enable the TextBoxes to show the data
                        EnableTextBoxes()
                    Else
                        TxtAlamat.Text = ""
                        MessageBox.Show("NIK Not Found.")
                        DisableTextBoxes() ' Disable TextBoxes if no record found
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub EnableTextBoxes()
        TxtNamaLengkap.ReadOnly = True
        TxtAlamat.ReadOnly = True
        TxtTanggalLahir.ReadOnly = True
        TxtTempatLahir.ReadOnly = True
    End Sub

    Private Sub DisableTextBoxes()
        TxtNamaLengkap.ReadOnly = True
        TxtAlamat.ReadOnly = True
        TxtTanggalLahir.ReadOnly = True
        TxtTempatLahir.ReadOnly = True
    End Sub

    Private Sub BtnCariNik_Click(sender As Object, e As EventArgs) Handles BtnCariNik.Click
        FunctionKoneksi()
        Dim nik = TxtCekNik.Text
        If String.IsNullOrWhiteSpace(nik) Then
            MessageBox.Show("Please enter a NIK.")
            Return
        End If

        ' Call the function to search for the NIK
        SearchByNik(nik)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class