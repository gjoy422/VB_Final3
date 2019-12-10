Public Class frmSign
    Dim decPeople As Decimal
    Dim strPromo As String
    Dim decCost As Decimal

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
        strPromo = txtPromo.Text
        decCost = decPeople * 10
        If txtPromo.Text = "DINOSAURS" Then
            decCost = decPeople * 10 * 0.85
        Else
            decCost = decPeople * 10
        End If
        If txtPromo.Text = "" Then
            MsgBox("We're sorry, but the promo code you entered is invalid. Please try again.")
        End If




    End Sub
End Class