Imports System.Data.Odbc
Public Class ChamberStatus

    Public cnx As System.Data.Odbc.OdbcConnection
    Public cmd As System.Data.Odbc.OdbcCommand
    Public cmd2 As System.Data.Odbc.OdbcCommand
    Public cmd3 As System.Data.Odbc.OdbcCommand
    Public dr As System.Data.Odbc.OdbcDataReader

    Public dt As DataTable
    Public t, index, a As String

    Dim selectedRow As DataGridViewRow

    Private Sub Afficher(ByVal x As Integer)
        Label2.Text = dt.Rows(a).Item(0)
        Label3.Text = dt.Rows(a).Item(1)
        Label4.Text = dt.Rows(a).Item(2)
        Label5.Text = dt.Rows(a).Item(3)
        Label6.Text = dt.Rows(a).Item(4)
        Label7.Text = dt.Rows(a).Item(5)



    End Sub
    Private Sub Clientshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OdbcDataAdapter
        da = New OdbcDataAdapter("select DISTINCT * from [ChamberStatus]", cnx)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        cnx.Close()

    End Sub
    Private Sub Clientinfo()

        'Dim ds As New DataSet
        'Dim dt As New DataTable
        ' ds.Tables.Add(dt)
        'Dim da As New OdbcDataAdapter
        ' da = New OdbcDataAdapter("SELECT Reservation.NumRes, Client.Nom, Client.Prenom, Client.CIN, Client.Email, Client.Tel FROM Reservation INNER JOIN Client ON Reservation.NumClt = Client.NumClt where NumRes like '" & TextBox1.Text & "'", cnx)
        'da.Fill(dt)
        ' DataGridView2.DataSource = dt.DefaultView
        'cnx.Close()

        a = 0
        cnx.Open()
        cmd = New OdbcCommand("SELECT Reservation.NumRes, Client.Nom, Client.Prenom, Client.CIN, Client.Email, Client.Tel FROM Reservation INNER JOIN Client ON Reservation.NumClt = Client.NumClt where NumRes like '" & TextBox1.Text & "'", cnx)
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        Afficher(a)
        cnx.Close()
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True



    End Sub
    Private Sub ChamberStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False

        Button2.Visible = False

        TextBox1.Visible = False
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()

        Clientshow()
        cnx.Open()
        cmd = New OdbcCommand("select Count(NumRes) from Reservation", cnx)
        dr = cmd.ExecuteReader()
        dt = New DataTable
        dt.Load(dr)
        hello.Text = dt.Rows(0).Item(0)
        cnx.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Dispose()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

        
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)

            TextBox1.Text = selectedRow.Cells(1).Value.ToString()

        Catch ex As Exception
        End Try

        '  Try


        'Dim index As Integer
        'index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        ' selectedRow = DataGridView2.Rows(index)
        ' TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        ' NumRes.Text = 
        'TextBox1.Text = selectedRow.Cells(1).Value.ToString()
        ' prenom.Text = selectedRow.Cells(2).Value.ToString()
        'cin.Text = selectedRow.Cells(3).Value.ToString()
        'email.Text = selectedRow.Cells(4).Value.ToString()
        ' tele.Text = selectedRow.Cells(5).Value.ToString()
        'tele.Text = selectedRow.Cells(6).Value.ToString()
        ' Catch ex As Exception

        'End Try
        'DtReservation()
        'End Sub
        Clientinfo()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cnx.Open()

        Dim REP As String
        REP = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "delete")
        If REP = 6 Then
            

            cmd3 = New OdbcCommand("delete from DetailReservation where NumCham like '" & selectedRow.Cells(0).Value.ToString() & "'", cnx)
            cmd2 = New OdbcCommand("delete from Reservation where NumRes like '" & selectedRow.Cells(1).Value.ToString() & "'", cnx)
            cmd3.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()

            MsgBox("Bien Sup", MsgBoxStyle.Information, "Done")
            Me.ChamberStatus_Load("0", New System.EventArgs)


        End If

        cnx.Close()
    End Sub

   
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

 
    

    Private Sub find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles find.Click
        If findzone.Text = "" Then
            MsgBox("La Zone de Rechercher Vide!", MsgBoxStyle.Exclamation)
            Return

        End If
        If Not IsNumeric(findzone.Text) Then
            MsgBox("SVP Entrer Le N° du Chamber", MsgBoxStyle.Information)
            Return
        End If
        If Val(findzone.Text) > 30 Or Val(findzone.Text) <= 0 Then
            MsgBox("SVP Entrer un N° du Chamber Valide", MsgBoxStyle.Information)
            Return
        End If





        cnx.Open()

        'cmd = New OdbcCommand("Select * From Client where Nom like '" & findzone.Text & "'", cnx)
        cmd2 = New OdbcCommand("Select DISTINCT * From [ChamberStatus] where NumCham like '" & findzone.Text & "'", cnx)
        'dr = cmd.ExecuteReader
        dr = cmd2.ExecuteReader()

        dt = New DataTable
        'dt.Load(dr)
        dt.Load(dr)

        DataGridView1.DataSource = dt
        ' MsgBox("bien trouver")
        If dt.Rows.Count = 0 Then
            MsgBox("La Chamber est Vide", MsgBoxStyle.Information)

            Clientshow()

        Else
            MsgBox("La Chamber Bien Trouver", MsgBoxStyle.Information)
            ' Me.Hide()
            'Form1.Show()

        End If
        cnx.Close()
    End Sub
End Class