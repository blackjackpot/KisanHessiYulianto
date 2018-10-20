Imports System.Data.SqlClient
Public Class TPenyewaan
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String


    Private Sub BTsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsimpan.Click

        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim cekStok As Boolean = False
        Dim t As String = FormatDateTime(Now, DateFormat.ShortDate)
        Call OpenKoneksi()
        Try
            Dim query_id As String = "SELECT MAX(RequestID)+1 AS MXID FROM Kendaraan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "INSERT INTO Kendaraan (RequestId,NameRequestor,RequestorID,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & TBnama.Text & "','" & TBid.Text & "','" & TBunit.Text & "','" & t & "','" & TBintruc.Text & "','" & TBtujuan.Text & "','" & TBkelas.Text & "','" & CBkendaraan.Text & "','" & TBtlpn.Text & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            LV1.Clear()
            Buang()
            Muncul()


            MsgBox("Data pengajuan '" + TBnama.Text + "' Berhasil Tersimpan")
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Muncul()
         Dim cmd As SqlCommand
        Dim dr As SqlDataReader


        LV1.View = View.Details
        LV1.Columns.Add("No", 50)
        LV1.Columns.Add("Nama Of Requestor", 100)
        LV1.Columns.Add("Unit From", 75)
        LV1.Columns.Add("UnitTo", 70)
        LV1.Columns.Add("Request Date", 100)
        LV1.Columns.Add("Transportation", 150)



        Call OpenKoneksi()
        Dim query_id As String = "select * from Kendaraan"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            LV1.Items.Add(dr("RequestID"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("Unit"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("DateIssue"))
            LV1.Items(LV1.Items.Count - 1).SubItems.Add(dr("Transportation"))



        Loop
        dr.Close()
        Call CloseKoneksi()

    End Sub

    Private Sub Buang()
       TBnama.Text = ""
        TBunit.Text = ""
        CBkendaraan.Text = ""
        TBtujuan.Text = ""

    End Sub



    Private Sub LV1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV1.SelectedIndexChanged
        BTedit.Enabled = True
    End Sub

    Private Sub BTedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTedit.Click
         Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idorg As String


        Try
            idorg = LV1.SelectedItems(0).Text
            Call OpenKoneksi()
            Dim query As String = "select * from Kendaraan where RequestID='" + idorg + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()

            TBid.Text = dr("RequestID")
            TBnama.Text = dr("NameRequestor")
            TBunit.Text = dr("Unit")
            TBtujuan.Text = dr("UnitDestination")
            CBkendaraan.Text = dr("Transportation")

            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub



    Private Sub BThapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BThapus.Click
        Dim Idorg As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            Idorg = LV1.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from Kendaraan where RequestID='" + Idorg + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()
            MsgBox("Data Berhasil di Buang")
            LV1.Clear()
            Muncul()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

   
    Private Sub BTupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTupdate.Click
        Dim t As String = Format(Now, "MM/dd/yy")
        Try
            Call OpenKoneksi()
            query_gl = "UPDATE Kendaraan SET NameRequestor = '" & TBnama.Text & "',Unit ='" & TBunit.Text & "',UnitDestination = '" & TBtujuan.Text & "',DateIssue = '" & t & "',Transportation = '" & CBkendaraan.Text & "' WHERE RequestID = '" & TBid.Text & "'"
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
