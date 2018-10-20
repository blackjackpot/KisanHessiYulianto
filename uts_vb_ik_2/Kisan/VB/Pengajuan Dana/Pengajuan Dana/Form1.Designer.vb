<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Bt_Hapus = New System.Windows.Forms.Button()
        Me.Bt_edit = New System.Windows.Forms.Button()
        Me.TBcekjml = New System.Windows.Forms.TextBox()
        Me.TBcekdana = New System.Windows.Forms.TextBox()
        Me.Bt_update = New System.Windows.Forms.Button()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.TBkeperluan = New System.Windows.Forms.TextBox()
        Me.CBbidang = New System.Windows.Forms.ComboBox()
        Me.TBjmlhprmintaan = New System.Windows.Forms.TextBox()
        Me.TBnamapelksana = New System.Windows.Forms.TextBox()
        Me.RBgiro = New System.Windows.Forms.RadioButton()
        Me.RBcek = New System.Windows.Forms.RadioButton()
        Me.RBtunai = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LV1 = New System.Windows.Forms.ListView()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(540, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 42
        Me.DateTimePicker1.Value = New Date(2018, 10, 12, 0, 0, 0, 0)
        '
        'Bt_Hapus
        '
        Me.Bt_Hapus.Location = New System.Drawing.Point(734, 382)
        Me.Bt_Hapus.Name = "Bt_Hapus"
        Me.Bt_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Hapus.TabIndex = 41
        Me.Bt_Hapus.Text = "HAPUS"
        Me.Bt_Hapus.UseVisualStyleBackColor = True
        '
        'Bt_edit
        '
        Me.Bt_edit.Location = New System.Drawing.Point(540, 382)
        Me.Bt_edit.Name = "Bt_edit"
        Me.Bt_edit.Size = New System.Drawing.Size(75, 23)
        Me.Bt_edit.TabIndex = 40
        Me.Bt_edit.Text = "EDIT"
        Me.Bt_edit.UseVisualStyleBackColor = True
        '
        'TBcekjml
        '
        Me.TBcekjml.Location = New System.Drawing.Point(19, 417)
        Me.TBcekjml.Name = "TBcekjml"
        Me.TBcekjml.Size = New System.Drawing.Size(100, 20)
        Me.TBcekjml.TabIndex = 38
        '
        'TBcekdana
        '
        Me.TBcekdana.Location = New System.Drawing.Point(278, 417)
        Me.TBcekdana.Name = "TBcekdana"
        Me.TBcekdana.Size = New System.Drawing.Size(100, 20)
        Me.TBcekdana.TabIndex = 37
        '
        'Bt_update
        '
        Me.Bt_update.Location = New System.Drawing.Point(302, 383)
        Me.Bt_update.Name = "Bt_update"
        Me.Bt_update.Size = New System.Drawing.Size(75, 23)
        Me.Bt_update.TabIndex = 36
        Me.Bt_update.Text = "UPDATE"
        Me.Bt_update.UseVisualStyleBackColor = True
        '
        'Bt_Add
        '
        Me.Bt_Add.Location = New System.Drawing.Point(162, 383)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Add.TabIndex = 35
        Me.Bt_Add.Text = "ADD"
        Me.Bt_Add.UseVisualStyleBackColor = True
        '
        'TBkeperluan
        '
        Me.TBkeperluan.Location = New System.Drawing.Point(162, 284)
        Me.TBkeperluan.Multiline = True
        Me.TBkeperluan.Name = "TBkeperluan"
        Me.TBkeperluan.Size = New System.Drawing.Size(216, 92)
        Me.TBkeperluan.TabIndex = 34
        '
        'CBbidang
        '
        Me.CBbidang.FormattingEnabled = True
        Me.CBbidang.Items.AddRange(New Object() {"ICT", "AKADEMIK", "CNP", "PERSONALIA", "MARKETING"})
        Me.CBbidang.Location = New System.Drawing.Point(162, 123)
        Me.CBbidang.Name = "CBbidang"
        Me.CBbidang.Size = New System.Drawing.Size(216, 21)
        Me.CBbidang.TabIndex = 33
        '
        'TBjmlhprmintaan
        '
        Me.TBjmlhprmintaan.Location = New System.Drawing.Point(162, 149)
        Me.TBjmlhprmintaan.Name = "TBjmlhprmintaan"
        Me.TBjmlhprmintaan.Size = New System.Drawing.Size(216, 20)
        Me.TBjmlhprmintaan.TabIndex = 32
        '
        'TBnamapelksana
        '
        Me.TBnamapelksana.Location = New System.Drawing.Point(162, 97)
        Me.TBnamapelksana.Name = "TBnamapelksana"
        Me.TBnamapelksana.Size = New System.Drawing.Size(216, 20)
        Me.TBnamapelksana.TabIndex = 31
        '
        'RBgiro
        '
        Me.RBgiro.AutoSize = True
        Me.RBgiro.Location = New System.Drawing.Point(162, 256)
        Me.RBgiro.Name = "RBgiro"
        Me.RBgiro.Size = New System.Drawing.Size(44, 17)
        Me.RBgiro.TabIndex = 30
        Me.RBgiro.TabStop = True
        Me.RBgiro.Text = "Giro"
        Me.RBgiro.UseVisualStyleBackColor = True
        '
        'RBcek
        '
        Me.RBcek.AutoSize = True
        Me.RBcek.Location = New System.Drawing.Point(162, 233)
        Me.RBcek.Name = "RBcek"
        Me.RBcek.Size = New System.Drawing.Size(72, 17)
        Me.RBcek.TabIndex = 29
        Me.RBcek.TabStop = True
        Me.RBcek.Text = "Cek Bank"
        Me.RBcek.UseVisualStyleBackColor = True
        '
        'RBtunai
        '
        Me.RBtunai.AutoSize = True
        Me.RBtunai.Location = New System.Drawing.Point(162, 208)
        Me.RBtunai.Name = "RBtunai"
        Me.RBtunai.Size = New System.Drawing.Size(52, 17)
        Me.RBtunai.TabIndex = 28
        Me.RBtunai.TabStop = True
        Me.RBtunai.Text = "Tunai"
        Me.RBtunai.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Keperluan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Bentuk Dana"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Jumlah Permintaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Bidang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Pelaksana"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Form Pengajuan Dana"
        '
        'LV1
        '
        Me.LV1.Location = New System.Drawing.Point(540, 98)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(274, 278)
        Me.LV1.TabIndex = 43
        Me.LV1.UseCompatibleStateImageBehavior = False
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(277, 207)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(22, 20)
        Me.TBid.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 483)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.LV1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Bt_Hapus)
        Me.Controls.Add(Me.Bt_edit)
        Me.Controls.Add(Me.TBcekjml)
        Me.Controls.Add(Me.TBcekdana)
        Me.Controls.Add(Me.Bt_update)
        Me.Controls.Add(Me.Bt_Add)
        Me.Controls.Add(Me.TBkeperluan)
        Me.Controls.Add(Me.CBbidang)
        Me.Controls.Add(Me.TBjmlhprmintaan)
        Me.Controls.Add(Me.TBnamapelksana)
        Me.Controls.Add(Me.RBgiro)
        Me.Controls.Add(Me.RBcek)
        Me.Controls.Add(Me.RBtunai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bt_Hapus As System.Windows.Forms.Button
    Friend WithEvents Bt_edit As System.Windows.Forms.Button
    Friend WithEvents TBcekjml As System.Windows.Forms.TextBox
    Friend WithEvents TBcekdana As System.Windows.Forms.TextBox
    Friend WithEvents Bt_update As System.Windows.Forms.Button
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents TBkeperluan As System.Windows.Forms.TextBox
    Friend WithEvents CBbidang As System.Windows.Forms.ComboBox
    Friend WithEvents TBjmlhprmintaan As System.Windows.Forms.TextBox
    Friend WithEvents TBnamapelksana As System.Windows.Forms.TextBox
    Friend WithEvents RBgiro As System.Windows.Forms.RadioButton
    Friend WithEvents RBcek As System.Windows.Forms.RadioButton
    Friend WithEvents RBtunai As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LV1 As System.Windows.Forms.ListView
    Friend WithEvents TBid As System.Windows.Forms.TextBox
End Class
