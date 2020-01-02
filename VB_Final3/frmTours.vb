Public Class frmTours


    Private Sub frmTours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIntro.Text = frmPortal.txtGuest.Text + " , schedule a tour." 'inputs data from Portal page'
    End Sub
    Private Sub cldTour_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles cldTour.DateSelected

        If e.Start > cldTour.TodayDate Then 'if the selected date is greater than today's date, then tour options will show'
            lblTitle.Text = frmPortal.txtGuest.Text + ", these are the events on " & e.Start.ToShortDateString() & ". 
Please select ONE tour. 
All tours are scheduled to begin at 4 p.m. est."
            lblNatural.Text = frmPortal.txtGuest.Text + ", you selected the Natural History Tour on " & e.Start.ToShortDateString & "."
            'displays if respective tour is chosen'
            lblAntiquities.Text = frmPortal.txtGuest.Text + ", you selected the Antiquities Tour on " & e.Start.ToShortDateString & "."
            'displays if respective tour is chosen'
            lblClassical.Text = frmPortal.txtGuest.Text + ", you selected Classical History Tour on " & e.Start.ToShortDateString & "."
            'displays if respective tour is chosen'

            chkTour.Visible = True
            chkTour2.Visible = True
            chkTour3.Visible = True
            chkTour.Text = "Natural History Tour"
            chkTour2.Text = "Antiquities Tour"
            chkTour3.Text = "Classical Wing Tour"
            btnSelect.Visible = True


        Else chkTour.Visible = True
            lblTitle.Text = frmPortal.txtGuest.Text + ", these are the events on " & e.Start.ToShortDateString() & ". "
            'if the selected date has already passed, no tour dates will show'
            chkTour.Text = "There are no tours available on this date."
            chkTour2.Visible = False
            chkTour3.Visible = False
        End If




    End Sub


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If chkTour.Checked = True Then

        End If
        Me.Close() 'closes window'
        frmSign.Show() 'opens Sign Up page'

    End Sub
End Class