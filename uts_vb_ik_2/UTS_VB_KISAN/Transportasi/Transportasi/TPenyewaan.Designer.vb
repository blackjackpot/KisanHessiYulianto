<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPenyewaan
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
        Me.BThapus = New System.Windows.Forms.Button()
        Me.BTedit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LV1 = New System.Windows.Forms.ListView()
        Me.BTsimpan = New System.Windows.Forms.Button()
        Me.TBtlpn = New System.Windows.Forms.TextBox()
        Me.CBkendaraan = New System.Windows.Forms.ComboBox()
        Me.TBkelas = New System.Windows.Forms.TextBox()
        Me.TBtujuan = New System.Windows.Forms.TextBox()
        Me.TBintruc = New System.Windows.Forms.TextBox()
        Me.TBunit = New System.Windows.Forms.TextBox()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.TBnama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTupdate = New System.Windows.Forms.Button()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BThapus
        '
        Me.BThapus.Location = New System.Drawing.Point(975, 298)
        Me.BThapus.Name = "BThapus"
        Me.BThapus.Size = New System.Drawing.Size(75, 23)
        Me.BThapus.TabIndex = 47
        Me.BThapus.Text = "Delete"
        Me.BThapus.UseVisualStyleBackColor = True
        '
        'BTedit
        '
        Me.BTedit.Location = New System.Drawing.Point(692, 298)
        Me.BTedit.Name = "BTedit"
        Me.BTedit.Size = New System.Drawing.Size(75, 23)
        Me.BTedit.TabIndex = 46
        Me.BTedit.Text = "Edit"
        Me.BTedit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(821, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Request List"
        '
        'LV1
        '
        Me.LV1.Location = New System.Drawing.Point(692, 96)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(358, 196)
        Me.LV1.TabIndex = 44
        Me.LV1.UseCompatibleStateImageBehavior = False
        '
        'BTsimpan
        '
        Me.BTsimpan.Location = New System.Drawing.Point(216, 298)
        Me.BTsimpan.Name = "BTsimpan"
        Me.BTsimpan.Size = New System.Drawing.Size(164, 23)
        Me.BTsimpan.TabIndex = 43
        Me.BTsimpan.Text = "Send Request"
        Me.BTsimpan.UseVisualStyleBackColor = True
        '
        'TBtlpn
        '
        Me.TBtlpn.Location = New System.Drawing.Point(480, 157)
        Me.TBtlpn.Name = "TBtlpn"
        Me.TBtlpn.Size = New System.Drawing.Size(162, 20)
        Me.TBtlpn.TabIndex = 42
        '
        'CBkendaraan
        '
        Me.CBkendaraan.FormattingEnabled = True
        Me.CBkendaraan.Items.AddRange(New Object() {"Pick UP", "Box", "Blind Van", "Truck", "BTT", "Forklift", "Other"})
        Me.CBkendaraan.Location = New System.Drawing.Point(480, 130)
        Me.CBkendaraan.Name = "CBkendaraan"
        Me.CBkendaraan.Size = New System.Drawing.Size(98, 21)
        Me.CBkendaraan.TabIndex = 41
        '
        'TBkelas
        '
        Me.TBkelas.Location = New System.Drawing.Point(480, 104)
        Me.TBkelas.Name = "TBkelas"
        Me.TBkelas.Size = New System.Drawing.Size(162, 20)
        Me.TBkelas.TabIndex = 40
        '
        'TBtujuan
        '
        Me.TBtujuan.Location = New System.Drawing.Point(480, 78)
        Me.TBtujuan.Name = "TBtujuan"
        Me.TBtujuan.Size = New System.Drawing.Size(162, 20)
        Me.TBtujuan.TabIndex = 39
        '
        'TBintruc
        '
        Me.TBintruc.Location = New System.Drawing.Point(131, 183)
        Me.TBintruc.Multiline = True
        Me.TBintruc.Name = "TBintruc"
        Me.TBintruc.Size = New System.Drawing.Size(511, 110)
        Me.TBintruc.TabIndex = 38
        '
        'TBunit
        '
        Me.TBunit.Location = New System.Drawing.Point(131, 131)
        Me.TBunit.Name = "TBunit"
        Me.TBunit.Size = New System.Drawing.Size(183, 20)
        Me.TBunit.TabIndex = 36
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(131, 105)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(183, 20)
        Me.TBid.TabIndex = 35
        '
        'TBnama
        '
        Me.TBnama.Location = New System.Drawing.Point(131, 79)
        Me.TBnama.Name = "TBnama"
        Me.TBnama.Size = New System.Drawing.Size(183, 20)
        Me.TBnama.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Ext. Phone/Hp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Transportation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "A/C Reg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "to Unit/Destination"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Instructions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Date of Issue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ID Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Name of Requestor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Transportation Request Form"
        '
        'BTupdate
        '
        Me.BTupdate.Location = New System.Drawing.Point(449, 299)
        Me.BTupdate.Name = "BTupdate"
        Me.BTupdate.Size = New System.Drawing.Size(75, 23)
        Me.BTupdate.TabIndex = 48
        Me.BTupdate.Text = "Update"
        Me.BTupdate.UseVisualStyleBackColor = True
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(584, 128)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(58, 20)
        Me.TB1.TabIndex = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(183, 20)
        Me.DateTimePicker1.TabIndex = 50
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(36, 217)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(8, 20)
        Me.TB2.TabIndex = 52
        '
        'TPenyewaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 355)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.BTupdate)
        Me.Controls.Add(Me.BThapus)
        Me.Controls.Add(Me.BTedit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LV1)
        Me.Controls.Add(Me.BTsimpan)
        Me.Controls.Add(Me.TBtlpn)
        Me.Controls.Add(Me.CBkendaraan)
        Me.Controls.Add(Me.TBkelas)
        Me.Controls.Add(Me.TBtujuan)
        Me.Controls.Add(Me.TBintruc)
        Me.Controls.Add(Me.TBunit)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.TBnama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TPenyewaan"
        Me.Text = "TPenyewaan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BThapus As System.Windows.Forms.Button
    Friend WithEvents BTedit As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LV1 As System.Windows.Forms.ListView
    Friend WithEvents BTsimpan As System.Windows.Forms.Button
    Friend WithEvents TBtlpn As System.Windows.Forms.TextBox
    Friend WithEvents CBkendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents TBkelas As System.Windows.Forms.TextBox
    Friend WithEvents TBtujuan As System.Windows.Forms.TextBox
    Friend WithEvents TBintruc As System.Windows.Forms.TextBox
    Friend WithEvents TBunit As System.Windows.Forms.TextBox
    Friend WithEvents TBid As System.Windows.Forms.TextBox
    Friend WithEvents TBnama As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTupdate As System.Windows.Forms.Button
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
End Class
