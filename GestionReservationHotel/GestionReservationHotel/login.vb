
Imports System.Data.Odbc
Public Class login
    Public cnx As Odbc.OdbcConnection
    Public cmd As Odbc.OdbcCommand
    Public dr As Odbc.OdbcDataReader
    Public dt As DataTable
    Public drag As Boolean
    Public mousex As String
    Public mousey As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Entrer le Nom d'utilisateur")

            Return
        End If
        If TextBox2.Text = "" Then
            MsgBox("Enter le motpass")
            Return

        End If
        cnx = New OdbcConnection("FIL=Ms Access; DSN=hotel")
        cnx.Open()
        cmd = New OdbcCommand("Select user From login where user like '%" & TextBox1.Text & "%'and password like '%" & TextBox2.Text & "%'", cnx)


        ' cmd = New OdbcCommand("Select password From login where password like '%" & TextBox2.Text & "%'", cnx)
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Login Faild")
        Else
            'MessageBox.Show("Login Successfully")
            Me.Hide()
            Form1.Show()

        End If

    End Sub


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TextBox3.Visible = False
        'Label3.Visible = False
        'Button4.Visible = False
        'Button5.Visible = False

    End Sub
    Private Sub login_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub login_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub login_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button1.Visible = False
        ' TextBox3.Visible = True
        ' Label3.Visible = True
        'Button4.Visible = True
        'Button3.Visible = False
        'Button5.Visible = True

        'Button3.Text = "Confirmé"


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' TextBox3.Visible = False
        'Button1.Visible = True
        ' Label3.Visible = False
        'Button4.Visible = False
        'Button3.Visible = True
        'Button5.Visible = False


        ' Button3.Text = "Creér un Compte"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        createCompte.Show()
        Me.Hide()

    End Sub
End Class