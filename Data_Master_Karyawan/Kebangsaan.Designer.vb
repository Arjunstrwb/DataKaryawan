﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kebangsaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtGridKeb = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdKebangsaan = New System.Windows.Forms.TextBox()
        Me.txtKebangsaan = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridKeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(346, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 154)
        Me.Panel2.TabIndex = 3
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Location = New System.Drawing.Point(346, 169)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Location = New System.Drawing.Point(346, 124)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 3
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUbah.Location = New System.Drawing.Point(346, 80)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Location = New System.Drawing.Point(346, 38)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtGridKeb)
        Me.Panel1.Location = New System.Drawing.Point(449, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 207)
        Me.Panel1.TabIndex = 2
        '
        'dtGridKeb
        '
        Me.dtGridKeb.AllowUserToAddRows = False
        Me.dtGridKeb.AllowUserToDeleteRows = False
        Me.dtGridKeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridKeb.Location = New System.Drawing.Point(3, 3)
        Me.dtGridKeb.Name = "dtGridKeb"
        Me.dtGridKeb.ReadOnly = True
        Me.dtGridKeb.Size = New System.Drawing.Size(442, 199)
        Me.dtGridKeb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Kebangsaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kebangsaan"
        '
        'txtIdKebangsaan
        '
        Me.txtIdKebangsaan.Location = New System.Drawing.Point(140, 61)
        Me.txtIdKebangsaan.Name = "txtIdKebangsaan"
        Me.txtIdKebangsaan.Size = New System.Drawing.Size(175, 20)
        Me.txtIdKebangsaan.TabIndex = 7
        '
        'txtKebangsaan
        '
        Me.txtKebangsaan.Location = New System.Drawing.Point(140, 148)
        Me.txtKebangsaan.Name = "txtKebangsaan"
        Me.txtKebangsaan.Size = New System.Drawing.Size(175, 20)
        Me.txtKebangsaan.TabIndex = 8
        '
        'Kebangsaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(911, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKebangsaan)
        Me.Controls.Add(Me.txtIdKebangsaan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Kebangsaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kebangsaan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtGridKeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtGridKeb As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdKebangsaan As TextBox
    Friend WithEvents txtKebangsaan As TextBox
End Class
