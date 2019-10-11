Imports System.Data.Odbc
Public Class Client
    Public cnx As Odbc.OdbcConnection
    Public cmd As Odbc.OdbcCommand
    Public cmd2 As Odbc.OdbcCommand
    Public dr As Odbc.OdbcDataReader
    Public dt As DataTable


    Sub autonuber()
        Dim r As New Random

        Dim ner As Object = r.Next(9999 + 1)
        Dim autoID As Single
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()

        cmd = New OdbcCommand("select count(*) as NumClt  from Client", cnx)
        dr = cmd.ExecuteReader
        While dr.Read
            autoID = Val(dr.Item("NumClt").ToString) + 1
        End While
        Select Case Len(Trim(autoID))
            Case 1 : NumClt.Text = "11" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 2 : NumClt.Text = "22" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 3 : NumClt.Text = "33" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 4 : NumClt.Text = "44" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 5 : NumClt.Text = "55" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 6 : NumClt.Text = "66" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 7 : NumClt.Text = "77" + Trim(Str(autoID)) + Format(Now, "dMy") + ner
            Case 8 : NumClt.Text = "88" + Trim(Str(autoID)) + Format(Now, "dMy") + ner


        End Select

    End Sub

    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        'cnx.Open()

    


       

        If nom.Text = "" Then
            MsgBox("Entrer Le client Nom")
            Return
       
        End If

        If IsNumeric(nom.Text) Then
            MsgBox("Le Nom N'est pas un valeur Numeric")
            Return

        End If

        If prenom.Text = "" Then
            MsgBox("Entrer Le client Prenom")
            Return
       
        End If

        If IsNumeric(prenom.Text) Then
            MsgBox("Le Prenom N'est pas un valeur Numeric")
            Return

        End If
        If cin.Text = "" Then
            MsgBox("Entrer Le client CIN")
            Return
      
        End If
        If IsNumeric(cin.Text) Then
            MsgBox("Le CIN N'est pas un valeur Numeric")
            Return

        End If
        If email.Text = "" Then
            MsgBox("Entrer Le client Email")
            Return
        End If

        If IsNumeric(email.Text) Then
            MsgBox("L' email N'est pas un valeur Numeric")
            Return

        End If
        If tele.Text = "" Then
            MsgBox("Entrer Le Numero Telephone")
            Return
        End If
        If Not IsNumeric(tele.Text) Then
            MsgBox("Le Numero Telephone N'est pas un valeur textual ")
            Return
        End If



        '  cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        'cnx.Open()



        cmd2 = New OdbcCommand("insert into Client values (?, ?, ?, ?, ?, ?)", cnx)

        cmd2.Parameters.AddWithValue("@1", NumClt.Text)
        cmd2.Parameters.AddWithValue("@2", nom.Text)
        cmd2.Parameters.AddWithValue("@3", prenom.Text)
        cmd2.Parameters.AddWithValue("@4", cin.Text)
        cmd2.Parameters.AddWithValue("@5", email.Text)
        cmd2.Parameters.AddWithValue("@6", tele.Text)
        cmd2.ExecuteNonQuery()

        cnx.Close()

        AjouterRes.NumClt.Text = NumClt.Text
        AjouterRes.nom.Text = nom.Text
        AjouterRes.prenom.Text = prenom.Text
        AjouterRes.cin.Text = cin.Text
        AjouterRes.email.Text = email.Text
        AjouterRes.tele.Text = tele.Text
        Me.Hide()
        AjouterRes.Show()



    End Sub

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autonuber()
        nom.Select()


    End Sub

    Private Sub Client_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        Me.Dispose()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ExctingClient.Show()
        Me.Hide()

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()

        Me.Dispose()
    End Sub
End Class