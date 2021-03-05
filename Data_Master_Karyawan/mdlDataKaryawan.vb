Imports System.Data.SQLite
Imports System.IO

Module mdlDataKaryawan
    Dim dirPath As String = Application.StartupPath & "\db"
    Dim datakaryawanDb As String = "datakaryawan.db"
    Dim connectionString As String = "Data Source={0};Version=3;"

    Public Sub create_sqlite_database()

        If Not Directory.Exists(dirPath) Then
            Directory.CreateDirectory(dirPath)
        End If

        Try
            If Not File.Exists(dirPath & "\" & datakaryawanDb) Then
                SQLiteConnection.CreateFile(dirPath & "\" & datakaryawanDb)
            End If
            connectionString = String.Format(connectionString, dirPath & "\" & datakaryawanDb)
            create_table(connectionString)
        Catch ex As Exception
            MessageBox.Show("DataBase tidak bisa dibuat")
        End Try
    End Sub

    Private Sub create_table(connectionString As String)
        Dim create_tblKaryawan As String = String.Empty
        Dim create_tblDepartemen As String = String.Empty
        Dim create_tblDivisi As String = String.Empty
        Dim create_tbljabatan As String = String.Empty
        Dim create_tblAgama As String = String.Empty
        Dim create_tblKebangsaan As String = String.Empty
        Dim create_tblStatusKawin As String = String.Empty
        Dim create_tblJenisIdentitas As String = String.Empty

        create_tblKaryawan = "CREATE TABLE IF NOT EXISTS tblKaryawan (" _
                               & "Nik       TEXT PRIMARY KEY NOT NULL," _
                               & "Nama_Karyawan TEXT," _
                               & "Departemen TEXT," _
                               & "Divisi TEXT," _
                               & "Jabatan TEXT," _
                               & "Agama TEXT," _
                               & "Kebangsaan TEXT," _
                               & "JenisKelamin TEXT," _
                               & "NoRekening TEXT," _
                               & "NoBpjsKes TEXT," _
                               & "NoBpjsKet TEXT," _
                               & "StatusKawin TEXT," _
                               & "JenisIdentitas TEXT," _
                               & "Email TEXT," _
                               & "TglLahir TEXT," _
                               & "TglBergabung TEXT," _
                               & "NoIdentitas TEXT)"

        create_tblDepartemen = "CREATE TABLE IF NOT EXISTS tblDepartemen (" _
                               & "IdDepartemen TEXT PRIMARY KEY NOT NULL," _
                               & "NamaDepartemen TEXT)"

        create_tblDivisi = "CREATE TABLE IF NOT EXISTS tblDivisi (" _
                               & "IdDivisi TEXT PRIMARY KEY NOT NULL," _
                               & "NamaDivisi TEXT)"

        create_tbljabatan = "CREATE TABLE IF NOT EXISTS tblJabatan (" _
                                & "IdJabatan TEXT PRIMARY KEY NOT NULL," _
                                & "NamaJabatan TEXT)"

        create_tblAgama = "CREATE TABLE IF NOT EXISTS tblAgama (" _
                                & "IdAgama TEXT PRIMARY KEY NOT NULL," _
                                & "NamaAgama TEXT)"

        create_tblKebangsaan = "CREATE TABLE IF NOT EXISTS tblKebangsaan (" _
                                & "IdKebangsaan TEXT PRIMARY KEY NOT NULL," _
                                & "NamaKebangsaan TEXT)"

        create_tblStatusKawin = "CREATE TABLE IF NOT EXISTS tblStatusKawin (" _
                                & "IdStatusKawin TEXT PRIMARY KEY NOT NULL," _
                                & "StatusKawin TEXT)"

        create_tblJenisIdentitas = "CREATE TABLE IF NOT EXISTS tblJenisIdentitas (" _
                                & "IdJenisIdentitas TEXT PRIMARY KEY NOT NULL," _
                                & "JenisIdentitas TEXT)"


        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()

                Using cmd As New SQLiteCommand(create_tblKaryawan, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblDepartemen, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblDivisi, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tbljabatan, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblAgama, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblKebangsaan, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblStatusKawin, con)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand(create_tblJenisIdentitas, con)
                    cmd.ExecuteNonQuery()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module