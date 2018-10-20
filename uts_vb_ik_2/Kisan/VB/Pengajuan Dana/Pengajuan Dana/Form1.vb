Imports System.Data.SqlClient
Public Class Form1
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Bt_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Add.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim cekStok As Boolean = False

        Call OpenKoneksi()
        Try
            Dim query_id As String = "SELECT MAX(no_id)+1 AS MXID FROM permohonan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "INSERT INTO permohonan (no_id,nama_pengajuan,bidang,jumlah_permintaan,bentuk_dana,keperluan,tanggal) VALUES (" & uid & ",'" & TBnamapelksana.Text & "','" & CBbidang.Text & "','" & TBjmlhprmintaan.Text & "','" & TBcekdana.Text & "','" & TBkeperluan.Text & "','" & DateTimePicker1.Value & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            LV1.Clear()
            Buang()
            Muncul()


            MsgBox("Data pengajuan '" + TBnamapelksana.Text + "' Berhasil Tersimpan")
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub RBtunai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtunai.CheckedChanged
        TBcekdana.Text = "Tunai"
    End Sub

    Private Sub RBcek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBcek.CheckedChanged
        TBcekdana.Text = "Cek Bank"
    End Sub

    Private Sub RBgiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBgiro.CheckedChanged
        TBcekdana.Text = "Giro"
    End Sub

    Private Sub Muncul()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader


        LV1.View = View.Details
        LV1.Columns.Add("No", 50)
        LV1.Columns.Add("Nama Pelaksana", 300)
        LV1.Columns.Add("Bidang", 150)
        LV1.Columns.Add("Jumlah Permintaan", 200)
        LV1.Columns.Add("Bentuk Dana", 200)
        LV1.Columns.Add("Keperluan", 200)



        Call OpenKoneksi()
        Dim query_id As String = "select * from permohonan"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            LV1.Items.Add(dr("no_id"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("nama_pengajuan"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("bidang"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("jumlah_permintaan"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("bentuk_dana"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("keperluan"))



        Loop
        dr.Close()
        Call CloseKoneksi()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Muncul()
        TBid.Visible = True





    End Sub

    Private Sub Buang()
        TBnamapelksana.Text = ""
        TBkeperluan.Text = ""
        CBbidang.Text = ""
        TBjmlhprmintaan.Text = ""
        TBcekdana.Text = ""
        RBtunai.Checked = False
        RBcek.Checked = False
        RBgiro.Checked = False

    End Sub



    Private Sub LV1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV1.SelectedIndexChanged
        Bt_edit.Enabled = True
    End Sub

    Private Sub Bt_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_edit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idorg As String


        Try
            idorg = LV1.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "select * from permohonan where no_id='" + idorg + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()

            TBid.Text = dr("no_id")
            TBnamapelksana.Text = dr("nama_pengajuan")
            CBbidang.Text = dr("bidang")
            TBjmlhprmintaan.Text = dr("jumlah_permintaan")
            TBkeperluan.Text = dr("keperluan")
            TBcekdana.Text = dr("bentuk_dana")



            If TBcekdana.Text = "Tunai" Then
                RBtunai.Checked = True
            ElseIf TBcekdana.Text = "Cek Bank" Then
                RBtunai.Checked = True
            ElseIf TBcekdana.Text = "Giro" Then
                RBgiro.Checked = True
            End If
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub



    Private Sub Bt_Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Hapus.Click
        Dim Idorg As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            Idorg = LV1.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from permohonan where no_id='" + Idorg + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            MsgBox("data berhasil di hapus")
            LV1.Clear()
            Muncul()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Bt_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_update.Click

        Try
            Call OpenKoneksi()
            query_gl = "UPDATE permohonan SET nama_pengajuan = '" & TBnamapelksana.Text & "',bidang ='" & CBbidang.Text & "',jumlah_permintaan = '" & TBjmlhprmintaan.Text & "',bentuk_dana = '" & TBcekdana.Text & "',keperluan = '" & TBkeperluan.Text & "' WHERE no_id = '" & TBid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            Buang()
            LV1.Clear()
            Muncul()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
