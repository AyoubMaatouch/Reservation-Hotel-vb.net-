Imports System.Data.Odbc
Public Class ExctingClient
    Public cnx As System.Data.Odbc.OdbcConnection
    Public cmd As System.Data.Odbc.OdbcCommand
    Public dr As System.Data.Odbc.OdbcDataReader
    Public dt As DataTable
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
    Private Sub ExctingClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnx = New OdbcConnection("FIL =MS Access; DSN=hotel")
        cnx.Open()
        Clientshow()
    End Sub

    Private Sub Choisir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

       
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            AjouterRes.NumClt.Text = selectedRow.Cells(0).Value.ToString()
            AjouterRes.nom.Text = selectedRow.Cells(1).Value.ToString()
            AjouterRes.prenom.Text = selectedRow.Cells(2).Value.ToString()
            AjouterRes.cin.Text = selectedRow.Cells(3).Value.ToString()
            AjouterRes.email.Text = selectedRow.Cells(4).Value.ToString()
            AjouterRes.tele.Text = selectedRow.Cells(5).Value.ToString()
            AjouterRes.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        If TextBox1.Text = "" Then
            MsgBox("Entrer Le CIN de client")
            Return

        End If
        If IsNumeric(TextBox1.Text) Then
            MsgBox("Le CIN n'est pas un valeur Numeric", MsgBoxStyle.Information)
            Return
        End If


        cnx.Open()

        cmd = New OdbcCommand("Select * From Client where CIN like '" & TextBox1.Text & "'", cnx)
        dr = cmd.ExecuteReader

        dt = New DataTable
        dt.Load(dr)


        DataGridView1.DataSource = dt
        MsgBox("bien trouver")
        cnx.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Client.Show()
        Me.Hide()

    End Sub
End Class