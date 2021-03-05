<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMain))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnMasKar = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.btnDepartClick = New System.Windows.Forms.RibbonPanel()
        Me.btnDepartemen = New System.Windows.Forms.RibbonButton()
        Me.btnJabatanClick = New System.Windows.Forms.RibbonPanel()
        Me.btnJabatan = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.btnDivisiClick = New System.Windows.Forms.RibbonPanel()
        Me.btnDivisi = New System.Windows.Forms.RibbonButton()
        Me.btnAgamaClick = New System.Windows.Forms.RibbonPanel()
        Me.btnAgama = New System.Windows.Forms.RibbonButton()
        Me.btnKebangsaanClick = New System.Windows.Forms.RibbonPanel()
        Me.btnKebangsaan = New System.Windows.Forms.RibbonButton()
        Me.btnJenisIdentitasClick = New System.Windows.Forms.RibbonPanel()
        Me.btnJenisIdentitas = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.btnTentangClick = New System.Windows.Forms.RibbonPanel()
        Me.btnTentang = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.btnKeluar = New System.Windows.Forms.RibbonButton()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1038, 165)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Text = "d"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab1.Text = "Tentang"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Image = CType(resources.GetObject("RibbonPanel1.Image"), System.Drawing.Image)
        Me.RibbonPanel1.Items.Add(Me.btnMasKar)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = "Tentang"
        '
        'btnMasKar
        '
        Me.btnMasKar.Image = CType(resources.GetObject("btnMasKar.Image"), System.Drawing.Image)
        Me.btnMasKar.LargeImage = CType(resources.GetObject("btnMasKar.LargeImage"), System.Drawing.Image)
        Me.btnMasKar.Name = "btnMasKar"
        Me.btnMasKar.SmallImage = CType(resources.GetObject("btnMasKar.SmallImage"), System.Drawing.Image)
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Panels.Add(Me.btnDepartClick)
        Me.RibbonTab2.Panels.Add(Me.btnJabatanClick)
        Me.RibbonTab2.Panels.Add(Me.btnDivisiClick)
        Me.RibbonTab2.Panels.Add(Me.btnAgamaClick)
        Me.RibbonTab2.Panels.Add(Me.btnKebangsaanClick)
        Me.RibbonTab2.Panels.Add(Me.btnJenisIdentitasClick)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab2.Text = "Statik Data"
        '
        'btnDepartClick
        '
        Me.btnDepartClick.Items.Add(Me.btnDepartemen)
        Me.btnDepartClick.Name = "btnDepartClick"
        Me.btnDepartClick.Text = "Departemen"
        '
        'btnDepartemen
        '
        Me.btnDepartemen.Image = CType(resources.GetObject("btnDepartemen.Image"), System.Drawing.Image)
        Me.btnDepartemen.LargeImage = CType(resources.GetObject("btnDepartemen.LargeImage"), System.Drawing.Image)
        Me.btnDepartemen.Name = "btnDepartemen"
        Me.btnDepartemen.SmallImage = CType(resources.GetObject("btnDepartemen.SmallImage"), System.Drawing.Image)
        Me.btnDepartemen.Text = ""
        '
        'btnJabatanClick
        '
        Me.btnJabatanClick.Items.Add(Me.btnJabatan)
        Me.btnJabatanClick.Name = "btnJabatanClick"
        Me.btnJabatanClick.Text = "Jabatan"
        '
        'btnJabatan
        '
        Me.btnJabatan.DropDownItems.Add(Me.RibbonButton1)
        Me.btnJabatan.Image = CType(resources.GetObject("btnJabatan.Image"), System.Drawing.Image)
        Me.btnJabatan.LargeImage = CType(resources.GetObject("btnJabatan.LargeImage"), System.Drawing.Image)
        Me.btnJabatan.Name = "btnJabatan"
        Me.btnJabatan.SmallImage = CType(resources.GetObject("btnJabatan.SmallImage"), System.Drawing.Image)
        Me.btnJabatan.Text = ""
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'btnDivisiClick
        '
        Me.btnDivisiClick.Items.Add(Me.btnDivisi)
        Me.btnDivisiClick.Name = "btnDivisiClick"
        Me.btnDivisiClick.Text = "Divisi"
        '
        'btnDivisi
        '
        Me.btnDivisi.Image = CType(resources.GetObject("btnDivisi.Image"), System.Drawing.Image)
        Me.btnDivisi.LargeImage = CType(resources.GetObject("btnDivisi.LargeImage"), System.Drawing.Image)
        Me.btnDivisi.Name = "btnDivisi"
        Me.btnDivisi.SmallImage = CType(resources.GetObject("btnDivisi.SmallImage"), System.Drawing.Image)
        Me.btnDivisi.Text = ""
        '
        'btnAgamaClick
        '
        Me.btnAgamaClick.Items.Add(Me.btnAgama)
        Me.btnAgamaClick.Name = "btnAgamaClick"
        Me.btnAgamaClick.Text = "Agama"
        '
        'btnAgama
        '
        Me.btnAgama.Image = CType(resources.GetObject("btnAgama.Image"), System.Drawing.Image)
        Me.btnAgama.LargeImage = CType(resources.GetObject("btnAgama.LargeImage"), System.Drawing.Image)
        Me.btnAgama.Name = "btnAgama"
        Me.btnAgama.SmallImage = CType(resources.GetObject("btnAgama.SmallImage"), System.Drawing.Image)
        Me.btnAgama.Text = ""
        '
        'btnKebangsaanClick
        '
        Me.btnKebangsaanClick.Items.Add(Me.btnKebangsaan)
        Me.btnKebangsaanClick.Name = "btnKebangsaanClick"
        Me.btnKebangsaanClick.Text = "Kebangsaan"
        '
        'btnKebangsaan
        '
        Me.btnKebangsaan.Image = CType(resources.GetObject("btnKebangsaan.Image"), System.Drawing.Image)
        Me.btnKebangsaan.LargeImage = CType(resources.GetObject("btnKebangsaan.LargeImage"), System.Drawing.Image)
        Me.btnKebangsaan.Name = "btnKebangsaan"
        Me.btnKebangsaan.SmallImage = CType(resources.GetObject("btnKebangsaan.SmallImage"), System.Drawing.Image)
        Me.btnKebangsaan.Text = ""
        '
        'btnJenisIdentitasClick
        '
        Me.btnJenisIdentitasClick.Items.Add(Me.btnJenisIdentitas)
        Me.btnJenisIdentitasClick.Name = "btnJenisIdentitasClick"
        Me.btnJenisIdentitasClick.Text = "Jenis Identitas"
        '
        'btnJenisIdentitas
        '
        Me.btnJenisIdentitas.Image = CType(resources.GetObject("btnJenisIdentitas.Image"), System.Drawing.Image)
        Me.btnJenisIdentitas.LargeImage = CType(resources.GetObject("btnJenisIdentitas.LargeImage"), System.Drawing.Image)
        Me.btnJenisIdentitas.Name = "btnJenisIdentitas"
        Me.btnJenisIdentitas.SmallImage = CType(resources.GetObject("btnJenisIdentitas.SmallImage"), System.Drawing.Image)
        Me.btnJenisIdentitas.Text = ""
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.RibbonButton3)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Text = "Status Perkawinan"
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.LargeImage = CType(resources.GetObject("RibbonButton3.LargeImage"), System.Drawing.Image)
        Me.RibbonButton3.Name = "RibbonButton3"
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = ""
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Panels.Add(Me.btnTentangClick)
        Me.RibbonTab3.Text = "Master"
        '
        'btnTentangClick
        '
        Me.btnTentangClick.Items.Add(Me.btnTentang)
        Me.btnTentangClick.Name = "btnTentangClick"
        Me.btnTentangClick.Text = "Master"
        '
        'btnTentang
        '
        Me.btnTentang.Image = CType(resources.GetObject("btnTentang.Image"), System.Drawing.Image)
        Me.btnTentang.LargeImage = CType(resources.GetObject("btnTentang.LargeImage"), System.Drawing.Image)
        Me.btnTentang.Name = "btnTentang"
        Me.btnTentang.SmallImage = CType(resources.GetObject("btnTentang.SmallImage"), System.Drawing.Image)
        Me.btnTentang.Text = ""
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.LargeImage = CType(resources.GetObject("RibbonButton2.LargeImage"), System.Drawing.Image)
        Me.RibbonButton2.Name = "RibbonButton2"
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = ""
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.RibbonButton2)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = "Keluar"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.btnKeluar)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Text = "Keluar"
        '
        'btnKeluar
        '
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.LargeImage = CType(resources.GetObject("btnKeluar.LargeImage"), System.Drawing.Image)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.SmallImage = CType(resources.GetObject("btnKeluar.SmallImage"), System.Drawing.Image)
        Me.btnKeluar.Text = ""
        '
        'MenuMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.Ribbon1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Entry Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents btnDepartClick As RibbonPanel
    Friend WithEvents btnJabatanClick As RibbonPanel
    Friend WithEvents btnDivisiClick As RibbonPanel
    Friend WithEvents btnAgamaClick As RibbonPanel
    Friend WithEvents btnKebangsaanClick As RibbonPanel
    Friend WithEvents btnJenisIdentitasClick As RibbonPanel
    Friend WithEvents RibbonTab3 As RibbonTab
    Friend WithEvents btnTentangClick As RibbonPanel
    Friend WithEvents btnMasKar As RibbonButton
    Friend WithEvents btnJabatan As RibbonButton
    Friend WithEvents btnDivisi As RibbonButton
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents btnAgama As RibbonButton
    Friend WithEvents btnKebangsaan As RibbonButton
    Friend WithEvents btnJenisIdentitas As RibbonButton
    Friend WithEvents btnDepartemen As RibbonButton
    Friend WithEvents btnTentang As RibbonButton
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents RibbonButton3 As RibbonButton
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents btnKeluar As RibbonButton
End Class
