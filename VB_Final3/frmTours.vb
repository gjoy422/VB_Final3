Public Class frmTours


    Private Sub frmTours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIntro.Text = frmPortal.txtGuest.Text + " , schedule a tour."
    End Sub
    Private Sub cldTour_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles cldTour.DateSelected

        If e.Start > cldTour.TodayDate Then
            lblTitle.Text = frmPortal.txtGuest.Text + ", these are the events on " & e.Start.ToShortDateString() & ". 
Please select ONE tour. 
All tours are scheduled to begin at 4 p.m. est."
            lblNatural.Text = frmPortal.txtGuest.Text + ", you selected for the Natural History Tour on " & e.Start.ToShortDateString & "."
            lblAntiquities.Text = frmPortal.txtGuest.Text + ", you selected the Antiquities Tour on " & e.Start.ToShortDateString & "."
            lblClassical.Text = frmPortal.txtGuest.Text + ", you selected Classical History Tour on " & e.Start.ToShortDateString & "."
            chkTour.Visible = True
            chkTour2.Visible = True
            chkTour3.Visible = True
            chkTour.Text = "Natural History Tour"
            chkTour2.Text = "Antiquities Tour"
            chkTour3.Text = "Classical Wing Tour"
            If chkTour.Checked = True Then
                frmNatural.Show()

            End If
        Else chkTour.Visible = True
            lblTitle.Text = frmPortal.txtGuest.Text + ", these are the events on " & e.Start.ToShortDateString() & ". "
            chkTour.Text = "There are no tours available on this date."
            chkTour2.Visible = False
            chkTour3.Visible = False
        End If




    End Sub


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If chkTour.Checked = True Then

        End If
        frmSign.Show()

    End Sub
End Class