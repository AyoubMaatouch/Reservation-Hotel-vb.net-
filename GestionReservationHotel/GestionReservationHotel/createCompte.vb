Imports System.Data.Odbc
Public Class createCompte
    Public cnx As Odbc.OdbcConnection
    Public cmd As Odbc.OdbcCommand
    Public dr As Odbc.OdbcDataReader
    Public dt As DataTable
    Public drag As Boolean
    Public mousex As String
    Public mousey As String
    Private Sub createCompte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Entrer un nom d'utilisateur", MsgBoxStyle.Information)
            Return
        End If

        If IsNumeric(TextBox1.Text) = True Then
            MsgBox("Le nom d'utilisateur ne peut pas être une valeur numérique", MsgBoxStyle.Information)
            Return
        End If


        If TextBox2.Text = "" Then
            MsgBox("La zone de mot de passe est vide", MsgBoxStyle.Information)
            Return
        End If
        If TextBox3.Text = "" Then
            MsgBox("SVP Confirmer le mot de passe", MsgBoxStyle.Information)
            Return
        End If
        If TextBox4.Text = "" Then
            MsgBox("SVP Entrer la clé", MsgBoxStyle.Information)
            Return
        End If
        If TextBox4.Text = "hotel" Then



            If TextBox2.Text = TextBox3.Text Then


                cnx = New OdbcConnection("FIL=MS Access; DSN=hotel")
                cnx.Open()

                cmd = New OdbcCommand("insert into login values(?, ?)", cnx)

                cmd.Parameters.AddWithValue("@1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@2", TextBox2.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Le Compte a bien Ajouter", MsgBoxStyle.Information)

                cnx.Close()
                Me.Hide()
                login.Show()

                'Login_Load("0", New System.EventArgs)

                ''Connect.Visible = True
                'Annul.Visible = True
                ' CreatC.Visible = True
                'z1.Focus()
                'z1.Text = ""
                'z2.Text = ""
            Else
                MsgBox("le mot de passe ne correspond pas")
                'Return
                ' z2.Focus()
                ' z3.Text = ""
                'z2.Text = ""
                'TextBox1.Text = ""
            End If
        Else
            MsgBox("le clé ne correspond pas", MsgBoxStyle.Information)

        End If

        ' ' Else
        ' MsgBox("Clé incorrect")

        'TextBox4.Focus()

        'TextBox4.Text = ""
        ' Return
        ' End If
        ' End If
        ' End If
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        login.Show()

        Me.Hide()
    End Sub
End Class