Public Class frmInteractive
    Public Sub frmInteractive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInteractive.Visible = True
        lblInteractive.Text = frmPortal.txtGuest.Text + ",explore the interface by selecting a location. "
        'loads information from Portal slide'
    End Sub

    Private Sub picAntiquities_Click(sender As Object, e As EventArgs) Handles picAntiquities.Click
        frmAntiquities.Show() 'opens Antiquities page'
    End Sub
    Private Sub picNatural_Click(sender As Object, e As EventArgs) Handles picNatural.Click
        frmArchaeology.Show()  'opens Archaeology page'
    End Sub
    Private Sub picClassical_Click(sender As Object, e As EventArgs) Handles picClassical.Click
        frmNaturalHistory.Show() 'opens Natural History page'
    End Sub
    Private Sub picGift_Show(sender As Object, e As EventArgs) Handles picGift.Click
        frmGift.Show() 'opens Gift shop page'
    End Sub
    Private Sub picTour_Click(sender As Object, e As EventArgs) Handles picTour.Click
        frmTours.Show() 'opens Tours page'
    End Sub
    Private Sub picOther_Click(sender As Object, e As EventArgs) Handles picOther.Click
        frmOther.Show() 'opens Other page'
    End Sub
End Class