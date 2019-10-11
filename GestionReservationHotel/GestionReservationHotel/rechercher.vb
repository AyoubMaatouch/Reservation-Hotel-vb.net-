Imports System.Data.Odbc
Public Class rechercher
    Public cnx As System.Data.Odbc.OdbcConnection
    Public cmd As System.Data.Odbc.OdbcCommand
    Public cmd2 As System.Data.Odbc.OdbcCommand
    Public cmd3 As System.Data.Odbc.OdbcCommand
    Public dr As System.Data.Odbc.OdbcDataReader
    Public dr2 As System.Data.Odbc.OdbcDataReader
    Public dt As DataTable
    Public dt2 As DataTable
    Public dt3 As DataTable
    Public t, index As String
    Public drag As Boolean
    Public mousex As String
    Public mousey As String


    Private Sub Clientshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OdbcDataAdapter
        da = New OdbcDataAdapter("select * from Client", cnx)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        cnx.Close()

    End Sub
    Private Sub Reservation()
        Dim ds As New DataSet
        Dim dt2 As New DataTable
        ds.Tables.Add(dt2)
        Dim da As New OdbcDataAdapter
        da = New OdbcDataAdapter("select * from Reservation where NumClt like '" & NumClt.Text & "'", cnx)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2.DefaultView
        cnx.Close()

    End Sub
    Private Sub DtReservation()
        Dim ds As New DataSet
        Dim dt3 As New DataTable
        ds.Tables.Add(dt3)
        Dim da As New OdbcDataAdapter
        'da = New OdbcDataAdapter("SELECT Reservation.NumClt, DetailReservation.NumRes, DetailReservation.NumCham, DetailReservation.NumSer FROM Reservation, DetailReservation where NumClt like '" & NumClt.Text & "'", cnx)
        da = New OdbcDataAdapter("SELECT DetailReservation.NumRes, DetailReservation.NumCham, Services.TypeSer FROM Services INNER JOIN DetailReservation ON Services.NumSer = DetailReservation.NumSer where NumRes like '" & TextBox1.Text & "'", cnx)
        da.Fill(dt3)
        DataGridView3.DataSource = dt3.DefaultView
        cnx.Close()

    End Sub

    Private Sub rechercher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()
        Clientshow()
        cnx.Open()
        cmd = New OdbcCommand("select Count(NumClt) from Client", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable
        dt.Load(dr)
        value.Text = dt.Rows(0).Item(0)


    End Sub


    Private Sub find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find.Click
        If findzone.Text = "" Then
            MsgBox("La Zone de Rechercher Vide!", MsgBoxStyle.Exclamation)
            Return

        End If
        If IsNumeric(findzone.Text) Then
            MsgBox("Le CIN n'est pas un valeur Numeric", MsgBoxStyle.Information)
            Return
        End If


        cnx.Open()

        'cmd = New OdbcCommand("Select * From Client where Nom like '" & findzone.Text & "'", cnx)
        cmd2 = New OdbcCommand("Select * From Client where CIN like '" & findzone.Text & "'", cnx)
        'dr = cmd.ExecuteReader
        dr2 = cmd2.ExecuteReader()

        dt = New DataTable
        'dt.Load(dr)
        dt.Load(dr2)

        DataGridView1.DataSource = dt
        ' MsgBox("bien trouver")
        If dt.Rows.Count = 0 Then
            MsgBox("Le Client ne pas exciter", MsgBoxStyle.Information)

            Clientshow()

        Else
            MsgBox("Le Client Bien Trouver", MsgBoxStyle.Information)
            ' Me.Hide()
            'Form1.Show()

        End If
        cnx.Close()


    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

       
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            NumClt.Text = selectedRow.Cells(0).Value.ToString()
            ' NumRes.Text = 
            nom.Text = selectedRow.Cells(1).Value.ToString()
            prenom.Text = selectedRow.Cells(2).Value.ToString()
            cin.Text = selectedRow.Cells(3).Value.ToString()
            email.Text = selectedRow.Cells(4).Value.ToString()
            tele.Text = selectedRow.Cells(5).Value.ToString()
            'tele.Text = selectedRow.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try
        Reservation()

    End Sub
    Private Sub modfier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modfier.Click
        If NumClt.Text = "" Then
            MsgBox("SVP Sélectionner Le client qui vous voulez modifier", MsgBoxStyle.Information)
            Return
        End If

        If nom.Text = "" Then
            MsgBox("Entrer Le client Nom")
            Return

        End If

        If IsNumeric(nom.Text) Then
            MsgBox("vous ne pouvez pas modifier Le Nom avec une valeur numérique")
            Return

        End If

        If prenom.Text = "" Then
            MsgBox("Entrer Le client Prenom")
            Return

        End If

        If IsNumeric(prenom.Text) Then
            MsgBox("vous ne pouvez pas modifier Le Prénom avec une valeur numérique")
            Return

        End If
        If cin.Text = "" Then
            MsgBox("Entrer Le client CIN")
            Return

        End If
        If IsNumeric(cin.Text) Then
            MsgBox("vous ne pouvez pas modifier Le CIN avec une valeur numérique")
            Return

        End If
        If email.Text = "" Then
            MsgBox("Entrer Le client Email")
            Return
        End If

        If IsNumeric(email.Text) Then
            MsgBox("vous ne pouvez pas modifier L'email avec une valeur numérique")
            Return

        End If
        If tele.Text = "" Then
            MsgBox("Entrer Le Numero  N°Télé")
            Return
        End If
        If Not IsNumeric(tele.Text) Then
            MsgBox("vous ne pouvez pas modifier Le N°Télé avec une valeur textual ")
            Return
        End If



        cnx.Open()
        cmd = New OdbcCommand("update Client set Nom=?, Prenom=?, CIN=?, Email=?, Tel=? where NumClt=?", cnx)

        cmd.Parameters.AddWithValue("@2", nom.Text)
        cmd.Parameters.AddWithValue("@3", prenom.Text)
        cmd.Parameters.AddWithValue("@4", cin.Text)
        cmd.Parameters.AddWithValue("@5", email.Text)
        cmd.Parameters.AddWithValue("@6", tele.Text)
        cmd.Parameters.AddWithValue("@1", NumClt.Text)

        cmd.ExecuteNonQuery()
        MsgBox("Les Donnes bien Modifier", MsgBoxStyle.Information)
        Me.rechercher_Load("0", New System.EventArgs)
        cnx.Close()

    End Sub
    Private Sub rechercher_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub retour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retour.Click
        Me.Dispose()
        Form1.Show()

    End Sub

    Private Sub sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sup.Click
        If NumClt.Text = "" Then
            MsgBox("SVP Sélectionner Le client qui vous voulez supprimer", MsgBoxStyle.Information)
            Return
        End If


        cnx.Open()

        Dim REP As String
        REP = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "delete")
        If REP = 6 Then


            cmd2 = New OdbcCommand("delete from Reservation where NumClt like '" & NumClt.Text & "'", cnx)
            ' cmd3 = New OdbcCommand("delete from DetailReservation where NumRes like '" & NumRes.Text & "'", cnx)
            cmd = New OdbcCommand("delete from Client where NumClt like '" & NumClt.Text & "'", cnx)
            'cmd3.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()

            cmd.ExecuteNonQuery()

            MsgBox("Bien Sup", MsgBoxStyle.Information, "Done")
            Me.rechercher_Load("0", New System.EventArgs)

            DtReservation()
            Clientshow()
            Reservation()
        End If
        



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        t = e.RowIndex

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub rechercher_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub rechercher_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub rechercher_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try


            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView2.Rows(index)
            TextBox1.Text = selectedRow.Cells(0).Value.ToString()
            ' NumRes.Text = 
            'TextBox1.Text = selectedRow.Cells(1).Value.ToString()
            ' prenom.Text = selectedRow.Cells(2).Value.ToString()
            'cin.Text = selectedRow.Cells(3).Value.ToString()
            'email.Text = selectedRow.Cells(4).Value.ToString()
            ' tele.Text = selectedRow.Cells(5).Value.ToString()
            'tele.Text = selectedRow.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try
        DtReservation()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    




    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NumClt.Text = "" Then
            MsgBox("La Zone de Numero de Client est Vide", MsgBoxStyle.Information)
            Return

        End If

        Dim Cr As New CrClt
        Cr.Load("CrClt.rpt")
        Cr.SetParameterValue("NumClt", NumClt.Text)
        CltInfoPrinting.CrystalReportViewer1.ReportSource = Cr
        CltInfoPrinting.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Cr As New CrToutClt
        Cr.Load("CrToutClt.rpt")
        'Cr.SetParameterValue("NumClt", NumClt.Text)
        ToutCltPrint.CrystalReportViewer1.ReportSource = Cr
        ToutCltPrint.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("SVP Selectioner la Reservation ", MsgBoxStyle.Information)
            Return

        End If

        Dim Cr As New CrResDet
        Cr.Load("CrResDet.rpt")
        Cr.SetParameterValue("Nero", TextBox1.Text)
        dtResPrint.CrystalReportViewer1.ReportSource = Cr
        dtResPrint.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If NumClt.Text = "" Then
            MsgBox("SVP Selectioner la Reservation ", MsgBoxStyle.Information)
            Return

        End If

        Dim Cr As New CrCltDt
        Cr.Load("CrCltDt.rpt")
        Cr.SetParameterValue("NumCltDt", NumClt.Text)
        CltWithDt.CrystalReportViewer1.ReportSource = Cr
        CltWithDt.Show()

    End Sub
End Class