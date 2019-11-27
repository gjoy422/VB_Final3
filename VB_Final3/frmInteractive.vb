Public Class frmInteractive
    Public Sub frmInteractive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInteractive.Visible = True
        lblInteractive.Text = frmPortal.txtGuest.Text + ",explore the interface by selecting a location. "
    End Sub

    Private Sub picAntiquities_Click(sender As Object, e As EventArgs) Handles picAntiquities.Click
        frmAntiquities.Show()
    End Sub
    Private Sub picNatural_Click(sender As Object, e As EventArgs) Handles picNatural.Click
        frmNatural.Show
    End Sub
    Private Sub picClassical_Click(sender As Object, e As EventArgs) Handles picClassical.Click
        frmClassical.Show
    End Sub
    Private Sub picGift_Show(sender As Object, e As EventArgs) Handles picGift.Click
        frmGift.Show
    End Sub
    Private Sub picTour_Click(sender As Object, e As EventArgs) Handles picTour.Click
        frmTours.Show
    End Sub
    Private Sub picOther_Click(sender As Object, e As EventArgs) Handles picOther.Click
        frmOther.Show
    End Sub
End Class