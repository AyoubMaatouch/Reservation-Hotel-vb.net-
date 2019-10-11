Public Class resInformation

    Private Sub resInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NomPrenom.Text = AjouterRes.nom.Text + " " + AjouterRes.prenom.Text

        If AjouterRes.sngl.Checked = True Then
            chamtype.Text = "Single"
        End If
        If AjouterRes.dble.Checked = True Then
            chamtype.Text = "Double"
        End If
        If AjouterRes.dlx.Checked = True Then
            chamtype.Text = "Single"
        End If

        Period.Text = AjouterRes.jour.Text + " Jour"
        datereservation.Text = AjouterRes.DateRes.Value
        datedepart.Text = AjouterRes.DateDeprt.Value
        ChamReserve.Text = AjouterRes.ComboBox1.Text
        total.Text = AjouterRes.total.Text + " $"


        If AjouterRes.trans.Checked = True Then
            transport.Text = "✓"
            transcheck.Visible = True
            transNocheck.Visible = False

        Else
            transport.Text = ""
            transNocheck.Visible = True
            transcheck.Visible = False

        End If



        If AjouterRes.food.Checked = True Then

            food.Text = "✓"
            Foodcheck.Visible = True
            foodnockeck.Visible = False
        Else
            food.Text = ""
            foodnockeck.Visible = True
            Foodcheck.Visible = False

        End If

        If AjouterRes.vip.Checked = True Then

            vip.Text = "✓"
            vipcheck.Visible = True
            vipnocheck.Visible = False

        Else
            vip.Text = ""
            vipnocheck.Visible = True
            vipcheck.Visible = False
        End If




    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Form1.Show()

        Me.Dispose()
        AjouterRes.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Application.Exit()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myReport As New CryRecut
        myReport.Load("CryRecut.rpt")
        myReport.SetParameterValue("Test", total.Text)
        'myReport.SetParameterValue("NumRecut", AjouterRes.NumClt.Text)
        myReport.SetParameterValue("Nom", NomPrenom.Text)
        myReport.SetParameterValue("ResPer", Period.Text)
        myReport.SetParameterValue("dateRes", datereservation.Text)
        myReport.SetParameterValue("dateDep", datedepart.Text)
        myReport.SetParameterValue("ChamRes", ChamReserve.Text)
        myReport.SetParameterValue("ChamType", chamtype.Text)
        myReport.SetParameterValue("vip", vip.Text)
        myReport.SetParameterValue("transport", transport.Text)
        myReport.SetParameterValue("food", food.Text)
        recutPrint.CrystalReportViewer1.ReportSource = myReport
        recutPrint.Show()

    End Sub
End Class