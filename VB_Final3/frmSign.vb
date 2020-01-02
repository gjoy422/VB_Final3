Public Class frmSign
    Dim decPeople As Decimal
    Dim strPromo As String = "DINOSAURS" 'PROMO code'
    Dim decCost As Decimal
    Dim strPhrase As String
    Dim strFinal As String = "Ready to register?" 'final message'


    Private Sub frmSign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtPeople.Select()

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
        decPeople = txtPeople.Text 'number of people entered'
        decCost = decPeople * 10 'number of people * 10'
        strPhrase = "We're sorry, but the promo code you entered is invalid. Please try again."
        If txtPromo.Text = strPromo Then 'if correct promo code is used, users receive 15% discount'
            grpList.Visible = True
            decCost = decPeople * 10 * 0.85
            lblFinal.Visible = True
            lblFinal.Text = lblSign.Text
            lblCost.Visible = True
            lblCost.Text = "The total cost for " & txtPeople.Text & " people is $" & decCost & "."
        ElseIf txtPromo.Text = "" Then 'if no promo code is entered, user is charged full price'
            grpList.Visible = True
            decCost = decPeople * 10
            lblFinal.Visible = True
            lblFinal.Text = lblSign.Text
            lblCost.Visible = True
            lblCost.Text = "The total cost for " & txtPeople.Text & " people is $" & decCost & "."
        ElseIf txtPromo.Text IsNot strPromo Then 'if incorrect promo code entered, eerror message is displayed'
            grpList.Visible = False
            txtPeople.Select()
            txtPromo.Clear()
            MsgBox(strPhrase, , "Error")

        End If

    End Sub
    Private Sub btnRegister_Click(system As Object, e As EventArgs) Handles btnRegister.Click
        Dim vb As DialogResult = MsgBox(strFinal, MsgBoxStyle.YesNo)
        If vb = DialogResult.Yes Then 'if user selects yes, a new screen is shown'
            grpFinal.Visible = True
            lblFinish.Visible = True 'shows final price'
            grpList.Visible = False
            lblSign.Text = False
        End If
        If vb = DialogResult.No Then 'if user selects no, nothing is shown'
            grpList.Visible = False
            txtPeople.Select()
        End If
    End Sub


    Private Sub btnInteractive_Click(sender As Object, e As EventArgs) Handles btnInteractive.Click
        Me.Close() 'closes form'
        frmInteractive.Show() 'opens Interactive page'
    End Sub
End Class