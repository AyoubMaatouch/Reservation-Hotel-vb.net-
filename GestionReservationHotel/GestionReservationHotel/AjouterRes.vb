

Imports System.Data.Odbc
Public Class AjouterRes
    Public cnx As Odbc.OdbcConnection
    Public cmd As Odbc.OdbcCommand
    Public dr As Odbc.OdbcDataReader
    Public dt As DataTable
    Public dr2 As Odbc.OdbcDataReader
    Public dr3 As Odbc.OdbcDataReader
    Public dt2 As New DataTable
    Public dt3 As New DataTable
    Public cmd2 As Odbc.OdbcCommand
    Public cmd3 As Odbc.OdbcCommand
    Public cmd4 As Odbc.OdbcCommand

    Public chamb As String
    Public P, v, T, F As String

    Sub autonuber()
        Dim autoID As Single
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()

        cmd = New OdbcCommand("select count(*) as NumClt  from Client", cnx)
        dr = cmd.ExecuteReader
        While dr.Read
            autoID = Val(dr.Item("NumClt").ToString) + 1
        End While
        Select Case Len(Trim(autoID))
            Case 1 : NumRes.Text = "R" + "11" + Trim(Str(autoID)) + Format(Now, "dMy") + "77"
            Case 2 : NumRes.Text = "R" + "22" + Trim(Str(autoID)) + Format(Now, "dMy") + "78"
            Case 3 : NumRes.Text = "R" + "33" + Trim(Str(autoID)) + Format(Now, "dMy") + "99"
            Case 4 : NumRes.Text = "R" + "44" + Trim(Str(autoID)) + Format(Now, "dMy") + "22"
            Case 5 : NumRes.Text = "R" + "55" + Trim(Str(autoID)) + Format(Now, "dMy") + "25"
            Case 6 : NumRes.Text = "R" + "66" + Trim(Str(autoID)) + Format(Now, "dMy") + "45"
            Case 7 : NumRes.Text = "R" + "77" + Trim(Str(autoID)) + Format(Now, "dMy") + "96"
            Case 8 : NumRes.Text = "R" + "88" + Trim(Str(autoID)) + Format(Now, "dMy") + "73"


        End Select

    End Sub

    Private Sub AjouterReservation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub
    Private Sub annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles annuler.Click
        Me.Dispose()
        Form1.Show()

    End Sub
    Private Sub NumClt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumClt.TextChanged
        Dim r As New Random

        Dim ner As Object = r.Next(9999 + 1)
        codeGen.Text = ner


        NumRes.Text = "R" + NumClt.Text + codeGen.Text


    End Sub

    Private Sub AjouterReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        edtClt.Visible = False
        '  autonuber()
        codeGen.Visible = False
        edtClt.Visible = False
        ajouter.Enabled = False
    End Sub
    Private Sub home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retour.Click
        Form1.Show()
        Me.Dispose()


    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()

        cmd = New OdbcCommand("select PrixCham from Chamber where NumCham like '" & ComboBox1.Text & "'", cnx)

        dr = cmd.ExecuteReader
        If (dr.Read()) = True Then
            prix.Text = (dr("PrixCham"))
        End If

        cnx.Close()

    End Sub

    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click


        cnx.Open()


        cmd3 = New OdbcCommand("select * from DetailReservation where NumCham like '" & ComboBox1.Text & "'", cnx)
        dr = cmd3.ExecuteReader

        If (dr.Read()) = True Then
            MsgBox("Chambre Deja Reserver")
            Return

        End If









        ' cmd = New OdbcCommand("insert into Client values (?, ?, ?, ?, ?, ?)", cnx)

        '  cmd.Parameters.AddWithValue("@1", NumClt.Text)
        '   cmd.Parameters.AddWithValue("@2", nom.Text)
        '   cmd.Parameters.AddWithValue("@3", prenom.Text)
        '    cmd.Parameters.AddWithValue("@4", cin.Text)
        '  cmd.Parameters.AddWithValue("@5", email.Text)
        ' cmd.Parameters.AddWithValue("@6", tele.Text)
        '  cmd.ExecuteNonQuery()
        cmd2 = New OdbcCommand("insert into Reservation values (?, ?, ?, ?)", cnx)
        cmd2.Parameters.AddWithValue("@1", NumRes.Text)
        cmd2.Parameters.AddWithValue("@2", NumClt.Text)
        cmd2.Parameters.AddWithValue("@3", DateRes.Value)
        cmd2.Parameters.AddWithValue("@4", DateDeprt.Value)
        cmd2.ExecuteNonQuery()








        If trans.Checked = True Then


            cmd4 = New OdbcCommand("insert into DetailReservation values (?, ?, ?)", cnx)
            cmd4.Parameters.AddWithValue("@1", NumRes.Text)
            cmd4.Parameters.AddWithValue("@2", ComboBox1.Text)
            cmd4.Parameters.AddWithValue("@3", "1")
            cmd4.ExecuteNonQuery()
        End If
        If food.Checked = True Then


            cmd4 = New OdbcCommand("insert into DetailReservation values (?, ?, ?)", cnx)
            cmd4.Parameters.AddWithValue("@1", NumRes.Text)
            cmd4.Parameters.AddWithValue("@2", ComboBox1.Text)
            cmd4.Parameters.AddWithValue("@3", "2")
            cmd4.ExecuteNonQuery()
        End If
        If vip.Checked = True Then


            cmd4 = New OdbcCommand("insert into DetailReservation values (?, ?, ?)", cnx)
            cmd4.Parameters.AddWithValue("@1", NumRes.Text)
            cmd4.Parameters.AddWithValue("@2", ComboBox1.Text)
            cmd4.Parameters.AddWithValue("@3", "3")
            cmd4.ExecuteNonQuery()
        End If

        resInformation.Show()


        'MsgBox("bien ajouter", MsgBoxStyle.OkOnly, "message")
        NumClt.Clear()
        nom.Clear()
        prenom.Clear()
        cin.Clear()
        email.Clear()
        tele.Clear()
        NumRes.Clear()
        cnx.Close()



        Me.AjouterReservation_Load("0", New System.EventArgs)

        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        If prix.Text = "" Then
            MsgBox("SVP Vouler Choisir un Chamber", MsgBoxStyle.Information)
            Return
        Else

            cnx.Open()
            cmd3 = New OdbcCommand("select Services.PrixSer from Services ", cnx)
            dr3 = cmd3.ExecuteReader
            dt3 = New DataTable
            dt3.Load(dr3)
            cnx.Close()
        End If
    End Sub

    Private Sub trans_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trans.CheckedChanged
        If trans.Checked = True Then
            T = "20"
        Else
            T = "0"
            ''  cnx.Close()
            ' total.Text = (Val(prix.Text) * jour.Text) + Val(P) + Val(v) + Val(F) + Val(T)

        End If

    End Sub



    Private Sub food_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles food.CheckedChanged
        If food.Checked = True Then
            F = "40"
        Else
            F = "0"
            ' cnx.Close()
            ' total.Text = (Val(prix.Text) * jour.Text) + Val(P) + Val(v) + Val(F) + Val(T)
        End If
    End Sub

    Private Sub vip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vip.CheckedChanged
        If vip.Checked = True Then
            v = "50"
        Else
            v = "0"
            'cnx.Close()
            '  total.Text = (Val(prix.Text) * jour.Text) + Val(P) + Val(v) + Val(F) + Val(T)
        End If
    End Sub



    Private Sub DateDeprt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDeprt.ValueChanged
        jour.Text = (DateDeprt.Value - DateRes.Value).TotalDays.ToString("#")

    End Sub

    Private Sub TTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTL.Click

        If jour.Text = "" Then
            MsgBox("Sélectionner la periode de reservation", MsgBoxStyle.Information)
            Return
        End If


        If DateRes.Value < Date.Today Then
            MsgBox("vous ne pouvez pas choisir une date qui a été passée", MsgBoxStyle.Exclamation)
            Return
        End If
        If DateDeprt.Value <= Date.Today Then
            MsgBox("Choisissez une date de départ plus récente.", MsgBoxStyle.Exclamation)
            Return
        Else
            total.Text = Val(prix.Text * jour.Text) + Val(v) + Val(F) + Val(T)

        End If
        ajouter.Enabled = True
    End Sub


    Private Sub edtClt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtClt.Click

        Client.NumClt.Text = NumClt.Text
        Client.nom.Text = nom.Text
        Client.prenom.Text = prenom.Text
        Client.cin.Text = cin.Text
        Client.email.Text = email.Text
        Client.tele.Text = tele.Text

        Client.Show()
        Me.Hide()



    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()

        If dble.Checked = True Then
            cmd = New OdbcCommand("Select Chamber.NumCham from Chamber Where typeCham like 'Double' ", cnx)
            dr2 = cmd.ExecuteReader
            dt2 = New DataTable
            dt2.Load(dr2)
            ComboBox1.DataSource = dt2
            ComboBox1.DisplayMember = "NumCham"
            cnx.Close()
            sg.Visible = False
            dx.Visible = False

        End If

        If sngl.Checked = True Then
            cmd = New OdbcCommand("Select Chamber.NumCham from Chamber Where typeCham like 'Single' ", cnx)
            dr2 = cmd.ExecuteReader
            dt2 = New DataTable
            dt2.Load(dr2)
            ComboBox1.DataSource = dt2
            ComboBox1.DisplayMember = "NumCham"
            cnx.Close()
            dx.Visible = False
            db.Visible = False

        End If

        If dlx.Checked = True Then
            cmd = New OdbcCommand("Select Chamber.NumCham from Chamber Where typeCham like 'Deluxe' ", cnx)
            dr2 = cmd.ExecuteReader
            dt2 = New DataTable
            dt2.Load(dr2)
            ComboBox1.DataSource = dt2
            ComboBox1.DisplayMember = "NumCham"
            cnx.Close()
            db.Visible = False
            sg.Visible = False
        End If






    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Application.Exit()
        Me.Dispose()

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter





    End Sub

    Private Sub sngl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sngl.CheckedChanged
        If sngl.Checked = True Then
            sg.Visible = True
            dx.Visible = False
            db.Visible = False
        End If

    End Sub

    Private Sub dble_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dble.CheckedChanged
        If dble.Checked = True Then


            sg.Visible = False
            dx.Visible = False
            db.Visible = True

        End If
    End Sub

    Private Sub dlx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dlx.CheckedChanged
        If dlx.Checked = True Then

            sg.Visible = False
            dx.Visible = True
            db.Visible = False
        End If
    End Sub

    Private Sub codeGen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codeGen.TextChanged

    End Sub
End Class