Public Class frmSign
    Dim decPeople As Decimal
    Dim strPromo As String = "DINOSAURS"
    Dim decCost As Decimal
    Dim strPhrase As String
    Dim strFinal As String = "Ready to register?"


    Private Sub frmSign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmTours.chkTour.Checked = True Then
            lblSign.Text = frmTours.lblNatural.Text
        End If
        If frmTours.chkTour2.Checked = True Then
            lblSign.Text = frmTours.lblAntiquities.Text
        End If
        If frmTours.chkTour3.Checked = True Then
            lblSign.Text = frmTours.lblClassical.Text
        End If
    End Sub
    Private Sub btnCalculate_Click(system As Object, e As EventArgs) Handles btnCalculate.Click
        decPeople = txtPeople.Text
        decCost = decPeople * 10
        strPhrase = "We're sorry, but the promo code you entered is invalid. Please try again."
        If txtPromo.Text = strPromo Then
            grpList.Visible = True
            decCost = decPeople * 10 * 0.85
            lblFinal.Visible = True
            lblFinal.Text = lblSign.Text
            lblCost.Visible = True
            lblCost.Text = "The total cost for " & txtPeople.Text & " people is $" & decCost & "."
        ElseIf txtPromo.Text = "" Then
            grpList.Visible = True
                decCost = decPeople * 10
                lblFinal.Visible = True
                lblFinal.Text = lblSign.Text
                lblCost.Visible = True
            lblCost.Text = "The total cost for " & txtPeople.Text & " people is $" & decCost & "."
        ElseIf txtPromo.Text IsNot strPromo Then
            grpList.Visible = False
            MsgBox(strPhrase, , "Error")

        End If

    End Sub
    Private Sub btnRegister_Click(system As Object, e As EventArgs) Handles btnRegister.Click
        Dim vb As DialogResult = MsgBox(strFinal, MsgBoxStyle.YesNo)
        If vb = DialogResult.Yes Then
            grpFinal.Visible = True
            lblFinish.Visible = True
            grpList.Visible = False
            lblSign.Text = False
        End If
        If vb = DialogResult.No Then
            grpList.Visible = False
        End If
    End Sub


    Private Sub btnInteractive_Click(sender As Object, e As EventArgs) Handles btnInteractive.Click
        Me.Close()
        frmInteractive.Show()
    End Sub
End Class