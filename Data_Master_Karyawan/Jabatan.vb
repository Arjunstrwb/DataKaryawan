Imports System.Data.SQLite
Imports Data_Master_Karyawan

Public Class Jabatan
        Dim dirPath As String = Application.StartupPath & "\db"
        Dim datakaryawanDb As String = "datakaryawan.db"
        Dim connectionString As String = "Data Source={0};Version=3;"
    Private _connectionString As String = String.Format(connectionString, dirPath & "\" & datakaryawanDb)

    Private Sub Jabatan_laod(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub

    ''TAMBAH DATA''

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim sqlstr As String
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using cmd As New SQLiteCommand(con)
                    sqlstr = "INSERT INTO tblJabatan ([IdJabatan], [NamaJabatan])
                            VALUES ('" + txtIdJab.Text + "','" + txtNamJab.Text + "')"
                    cmd.CommandText = sqlstr
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil disimpan.")
            txtIdJab.Clear()
            txtNamJab.Clear()
            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''TAMPIL DATA''

    Private Sub FillGrid()
        Dim dtTable As New DataTable
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using data As New SQLiteDataAdapter("SELECT * FROM tblJabatan", con)
                    data.Fill(dtTable)
                    dtGridJab.DataSource = dtTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'UPDATE DATA''

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim sqlstr As String
        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()

                Using cmd As New SQLiteCommand(con)
                    sqlstr = "UPDATE tblJabatan set [NamaJabatan] = '" + txtNamJab.Text + "'
                              WHERE (IdJabatan='" + txtIdJab.Text + "')"
                    cmd.CommandText = sqlstr
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil disimpan.")
            txtIdJab.Clear()
            txtNamJab.Clear()
            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class