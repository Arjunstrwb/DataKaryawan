Imports System.Data.SQLite
Imports System.IO
Imports Data_Master_Karyawan

Public Class MasterKaryawan
    Dim dirPath As String = Application.StartupPath & "\db"
    Dim dirPhoto As String = Application.StartupPath & "\Photo"
    Dim datakaryawanDb As String = "datakaryawan.db"
    Dim connectionString As String = "Data Source={0};Version=3;"
    Dim isEdit As Boolean = False
    Private _connectionString As String = String.Format(connectionString, dirPath & "\" & datakaryawanDb)

    Private Sub MasterKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtJabatan As New DataTable
        Dim dtDepartemen As New DataTable
        Dim dtDivisi As New DataTable
        Dim dtPerkawinan As New DataTable
        Dim dtJenisIden As New DataTable
        Dim dtJenisKel As New DataTable
        Dim dtAgama As New DataTable
        Dim dtKebangsaan As New DataTable

        Using con As New SQLiteConnection(_connectionString)
            con.Open()

            Using cmd As New SQLiteCommand("SELECT * FROM tblKaryawan", con)
                Dim data As SQLiteDataReader = cmd.ExecuteReader()
                Using data
                    While (data.Read())
                        cmbCari.Items.Add(data("Nik") & ", " & data("Nama_Karyawan"))
                    End While
                End Using
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblDepartemen", con)
                data.Fill(dtDepartemen)
                cmbDepartemen.DataSource = dtDepartemen
                cmbDepartemen.ValueMember = "IdDepartemen"
                cmbDepartemen.DisplayMember = "NamaDepartemen"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblDivisi", con)
                data.Fill(dtDivisi)
                cmbDivisi.DataSource = dtDivisi
                cmbDivisi.ValueMember = "IdDivisi"
                cmbDivisi.DisplayMember = "NamaDivisi"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblJabatan", con)
                data.Fill(dtJabatan)
                cmbJabatan.DataSource = dtJabatan
                cmbJabatan.ValueMember = "IdJabatan"
                cmbJabatan.DisplayMember = "NamaJabatan"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblAgama", con)
                data.Fill(dtAgama)
                cmbAgama.DataSource = dtAgama
                cmbAgama.ValueMember = "IdAgama"
                cmbAgama.DisplayMember = "NamaAgama"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblKebangsaan", con)
                data.Fill(dtKebangsaan)
                cmbKebangsaan.DataSource = dtKebangsaan
                cmbKebangsaan.ValueMember = "IdKebangsaan"
                cmbKebangsaan.DisplayMember = "NamaKebangsaan"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblStatusKawin", con)
                data.Fill(dtPerkawinan)
                cmbStatusKawin.DataSource = dtPerkawinan
                cmbStatusKawin.ValueMember = "IdStatusKawin"
                cmbStatusKawin.DisplayMember = "StatusKawin"
            End Using

            Using data As New SQLiteDataAdapter("SELECT * FROM tblJenisIdentitas", con)
                data.Fill(dtJenisIden)
                cmbJenisIdentitas.DataSource = dtJenisIden
                cmbJenisIdentitas.ValueMember = "IdJenisIdentitas"
                cmbJenisIdentitas.DisplayMember = "JenisIdentitas"
            End Using
        End Using
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        connectionString = String.Format(connectionString, dirPath & "\" & datakaryawanDb)
        Dim qrystr As String

        If txtNik.Text = "" Then
            MessageBox.Show("NIK Harus Di Isi")
            txtNik.Focus()
            Exit Sub

        End If

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Try
                If isEdit Then
                    editDataKaryawan()
                Else
                    Using cmd As New SQLiteCommand(con)
                        qrystr = "INSERT INTO tblKaryawan ([Nik], 
                                    [Nama_Karyawan], 
                                    [Departemen], 
                                    [Divisi], 
                                    [Jabatan], 
                                    [Agama], 
                                    [Kebangsaan], 
                                    [JenisKelamin], 
                                    [NoRekening], 
                                    [NoBpjsKes], 
                                    [NoBpjsKet], 
                                    [StatusKawin],
                                    [Email],
                                    [JenisIdentitas],
                                    [tglLahir],
                                    [tglBergabung],
                                    [NoIdentitas])
                            VALUES ('" + txtNik.Text + "',
                                '" + txtNama.Text + "',
                                '" + cmbDepartemen.SelectedValue + "',
                                '" + cmbDivisi.SelectedValue + "',
                                '" + cmbJabatan.SelectedValue + "',
                                '" + cmbAgama.SelectedValue + "',
                                '" + cmbKebangsaan.SelectedValue + "',
                                '" + cmbJenisKelamin.Text + "',
                                '" + txtRekening.Text + "',
                                '" + txtBpjsKes.Text + "',
                                '" + txtBpjsKet.Text + "',
                                '" + cmbStatusKawin.SelectedValue + "',
                                '" + txtEmail.Text + "',
                                '" + cmbJenisIdentitas.SelectedValue + "',
                                '" + txtTanggalLahir.Text + "',
                                '" + txtTanggalBergabung.Text + "',
                                '" + txtNoIdentitas.Text + "')"
                        cmd.CommandText = qrystr
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Data Berhasil di Simpan", "Simpan data karyawan")
                    End Using
                End If


                btnTambah.Enabled = True
                btnSimpan.Enabled = False
                btnUbah.Enabled = True
                txtNik.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
    End Sub

    Private Sub editDataKaryawan()
        Dim qrystr As String

        Using con As New SQLiteConnection(_connectionString)
            con.Open()
            Try
                Using cmd As New SQLiteCommand(con)
                    qrystr = "UPDATE tblKaryawan SET[Nama_Karyawan]='" + txtNama.Text + "',
                    [Departemen]='" + cmbDepartemen.SelectedValue + "',
                    [Divisi]='" + cmbDivisi.SelectedValue + "',
                    [Jabatan]='" + cmbJabatan.SelectedValue + "',
                    [Agama]='" + cmbAgama.SelectedValue + "',
                    [Kebangsaan]='" + cmbKebangsaan.SelectedValue + "',
                    [JenisKelamin]='" + cmbJenisKelamin.Text + "',
                    [NoRekening]='" + txtRekening.Text + "',
                    [NoBpjsKes]='" + txtBpjsKes.Text + "',
                    [NoBpjsKet]='" + txtBpjsKet.Text + "',
                    [StatusKawin]='" + cmbStatusKawin.SelectedValue + "',
                    [JenisIdentitas]='" + cmbJenisIdentitas.SelectedValue + "',
                    [tglLahir]='" + txtTanggalLahir.Text + "',
                    [tglBergabung]='" + txtTanggalBergabung.Text + "'
                    WHERE([Nik] ='" + txtNik.Text + "')"
                    cmd.CommandText = qrystr
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Data Berhasil di Simpan", "Simpan Data Karyawan")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            isEdit = False
        End Using
    End Sub


    Private Sub cmbCari_DropDown(sender As Object, e As EventArgs) Handles cmbCari.DropDown
        Using con As New SQLiteConnection(_connectionString)
            con.Open()
            cmbCari.Items.Clear()

            Using cmd As New SQLiteCommand("SELECT * FROM tblKaryawan", con)
                Dim emp As SQLiteDataReader = cmd.ExecuteReader()
                Using emp
                    While (emp.Read())
                        cmbCari.Items.Add(emp("Nik") & ", " & emp("Nama_Karyawan"))
                    End While
                End Using

            End Using
        End Using
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        txtNik.Enabled = True
        btnSimpan.Enabled = True
        ClearTextBox(Me)
        btnTambah.Enabled = False
        btnUbah.Enabled = False
        btnKeluar.Enabled = True
    End Sub

    Private Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Len(txtNik.Text) > 0 Then
            isEdit = True
            btnSimpan.Enabled = True
            btnUbah.Enabled = False
        End If
    End Sub

    Private Sub cmbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCari.KeyPress
        cmbCari.DroppedDown = True
        If (Char.IsControl(e.KeyChar)) Then Return

        Dim str As String = cmbCari.Text.Substring(0, cmbCari.SelectionStart) + e.KeyChar
        Dim index As Integer = cmbCari.FindStringExact(str)

        If index = -1 Then
            index = cmbCari.FindString(str)
        End If

        cmbCari.SelectedIndex = index
        cmbCari.SelectionStart = str.Length
        cmbCari.SelectionLength = cmbCari.Text.Length - cmbCari.SelectionStart
        e.Handled = True

    End Sub

    Private Sub cmbCari_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbCari.KeyUp
        Dim nik As String

        If e.KeyCode = Keys.Enter Then
            nik = Getnik(cmbCari.Text)
            Try
                GetEmployeeData(nik)
                btnUbah.Enabled = True
                SetPicture(nik)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Function Getnik(param As String) As String
        Dim emp As Byte
        Dim empStr As String

        emp = InStr(1, param, ",")
        empStr = Strings.Left(param, emp - 1)
        Return empStr
    End Function

    Private Sub GetEmployeeData(nik As String)
        Dim qrystr As String

        Using con As New SQLiteConnection(_connectionString)
            con.Open()


            qrystr = "SELECT tblKaryawan.*, tblDepartemen.NamaDepartemen as depNama, tblDivisi.NamaDivisi as divNama, tblJabatan.NamaJabatan as jabNama, tblAgama.NamaAgama as agNama, tblKebangsaan.NamaKebangsaan as kebNama, tblStatusKawin.StatusKawin as stsKawin, tblJenisIdentitas.JenisIdentitas as jnsIdentitas " _
                & " FROM (((((((tblKaryawan LEFT JOIN tblDepartemen ON tblKaryawan.Departemen = tblDepartemen.IdDepartemen)" _
                & " LEFT JOIN tblDivisi ON tblKaryawan.Divisi = tblDivisi.IdDivisi)" _
                & " LEFT JOIN tblJabatan ON tblKaryawan.Jabatan = tblJabatan.IdJabatan)" _
                & " LEFT JOIN tblAgama ON tblKaryawan.Agama = tblAgama.IdAgama)" _
                & " LEFT JOIN tblKebangsaan ON tblKaryawan.Kebangsaan = tblKebangsaan.IdKebangsaan)" _
                & " LEFT JOIN tblStatusKawin ON tblKaryawan.StatusKawin = tblStatusKawin.IdStatusKawin)" _
                & " LEFT JOIN tblJenisIdentitas ON tblKaryawan.JenisIdentitas = tblJenisIdentitas.IdJenisIdentitas)" _
                & " WHERE (tblKaryawan.Nik = '" & nik & "')"

            Using cmd As New SQLiteCommand(qrystr, con)
                Dim emp As SQLiteDataReader = cmd.ExecuteReader()
                Using emp
                    While (emp.Read())
                        txtNik.Text = emp("nik")
                        txtNama.Text = emp("Nama_Karyawan")
                        cmbDepartemen.Text = IIf(IsDBNull(emp("depNama")), "", emp("depNama"))
                        cmbDivisi.Text = IIf(IsDBNull(emp("divNama")), "", emp("divNama"))
                        cmbJabatan.Text = IIf(IsDBNull(emp("jabNama")), "", emp("jabNama"))
                        cmbAgama.Text = IIf(IsDBNull(emp("agNama")), "", emp("agNama"))
                        cmbKebangsaan.Text = IIf(IsDBNull(emp("KebNama")), "", emp("KebNama"))
                        cmbJenisKelamin.Text = emp("JenisKelamin")
                        txtRekening.Text = emp("NoRekening")
                        txtBpjsKes.Text = emp("NoBpjsKes")
                        txtBpjsKet.Text = emp("NoBpjsKet")
                        cmbStatusKawin.Text = IIf(IsDBNull(emp("stsKawin")), "", emp("stsKawin"))
                        cmbJenisIdentitas.Text = IIf(IsDBNull(emp("jnsIdentitas")), "", emp("jnsIdentitas"))
                        txtNoIdentitas.Text = emp("NoIdentitas")
                        txtEmail.Text = emp("Email")
                        txtTanggalLahir.Text = emp("tglLahir")
                        txtTanggalBergabung.Text = emp("tglBergabung")
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnBatalkan_Click(sender As Object, e As EventArgs) Handles btnBatalkan.Click
        txtNik.Enabled = False
        btnBatalkan.Enabled = True
        ClearTextBox(Me)
        btnTambah.Enabled = True
        btnUbah.Enabled = False
        btnSimpan.Enabled = False
    End Sub

    Private Sub btnKeluar_Click_1(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim nik As String

        If Len(cmbCari.Text) > 0 Then
            nik = Getnik(cmbCari.Text)
            GetEmployeeData(nik)
            SetPicture(nik)
        End If

    End Sub

    Private Sub SetPicture(nik As String)

        If Not Directory.Exists(dirPhoto) Then
            Directory.CreateDirectory(dirPhoto)
        End If

        If Not File.Exists(dirPhoto + "\" + nik + ".jgp") Then
            pictEmp.Image = Image.FromFile(dirPhoto + "\Avatar.png")
        Else
            pictEmp.Image = Image.FromFile(dirPhoto + "\" + nik + ".jgp")
        End If
    End Sub

End Class