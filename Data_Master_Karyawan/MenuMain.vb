Public Class MenuMain
    Private Sub MenuMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create_sqlite_database()
    End Sub

    Private Sub btnMasKar_Click(sender As Object, e As EventArgs) Handles btnTentang.Click
        MasterKaryawan.MdiParent = Me
        MasterKaryawan.Show()
    End Sub

    Private Sub btnJabatan_Click(sender As Object, e As EventArgs) Handles btnJabatan.Click
        Jabatan.MdiParent = Me
        Jabatan.Show()
    End Sub

    Private Sub btnDivisi_Click(sender As Object, e As EventArgs) Handles btnDivisi.Click
        Divisi.MdiParent = Me
        Divisi.Show()
    End Sub

    Private Sub btnAgama_Click(sender As Object, e As EventArgs) Handles btnAgama.Click
        Agama.MdiParent = Me
        Agama.Show()
    End Sub

    Private Sub btnKebangsaan_Click(sender As Object, e As EventArgs) Handles btnKebangsaan.Click
        Kebangsaan.MdiParent = Me
        Kebangsaan.Show()
    End Sub

    Private Sub btnJenisIdentitas_Click(sender As Object, e As EventArgs) Handles btnJenisIdentitas.Click
        JenisIdentitas.MdiParent = Me
        JenisIdentitas.Show()
    End Sub

    Private Sub btnTentang_Click(sender As Object, e As EventArgs) Handles btnMasKar.Click
        Tentang.MdiParent = Me
        Tentang.Show()
    End Sub

    Private Sub btnDepartemen_Click_1(sender As Object, e As EventArgs) Handles btnDepartemen.Click
        Departemen.MdiParent = Me
        Departemen.Show()
    End Sub

    Private Sub RibbonButton2_Click(sender As Object, e As EventArgs) Handles RibbonButton2.Click, btnKeluar.Click
        Environment.Exit(1)
    End Sub

    Private Sub RibbonButton3_Click(sender As Object, e As EventArgs) Handles RibbonButton3.Click
        StatusPerkawinan.MdiParent = Me
        StatusPerkawinan.Show()
    End Sub
End Class