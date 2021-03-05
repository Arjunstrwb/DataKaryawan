Imports System.Data.SQLite
Imports Data_Master_Karyawan
Public Class JenisIdentitas
    Dim dirPath As String = Application.StartupPath & "\db"
    Dim datakaryawanDb As String = "datakaryawan.db"
    Dim connectionString As String = "Data Source={0};Version=3;"
    Private _connectionString As String = String.Format(connectionString, dirPath & "\" & datakaryawanDb)

    Private Sub Divisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim sqlstr As String
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using cmd As New SQLiteCommand(con)
                    sqlstr = "INSERT INTO tblJenisIdentitas ([IdJenisIdentitas], [JenisIdentitas])
                            VALUES ('" + txtIdIden.Text + "','" + txtJnsIden.Text + "')"
                    cmd.CommandText = sqlstr
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil disimpan.")
            txtIdIden.Clear()
            txtJnsIden.Clear()
            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FillGrid()
        Dim dtTable As New DataTable
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using data As New SQLiteDataAdapter("SELECT * FROM tblJenisIdentitas", con)
                    data.Fill(dtTable)
                    dtGridJns.DataSource = dtTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim sqlstr As String
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using cmd As New SQLiteCommand(con)
                    sqlstr = "UPDATE tblJenisIdentitas set [JenisIdentitas] = '" + txtJnsIden.Text + "'
                              WHERE (IdJenisIdentitas='" + txtIdIden.Text + "')"
                    cmd.CommandText = sqlstr
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil disimpan.")
            txtIdIden.Clear()
            txtJnsIden.Clear()
            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
