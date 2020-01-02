Public Class frmAntiquities
    Dim intChoice As Integer
    Public Sub frmAntiquities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblAntiquities.Visible = True
        lblAntiquities.Text = frmPortal.txtGuest.Text + ", explore the interface by clicking on the drop-down menu. "
    End Sub
    Private Sub cboSelect_SelectedIndex_(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        intChoice = cboSelect.SelectedIndex
        Select Case intChoice
            Case 0 'if viewer selects egyptian exhibit, the display will show a matching photograph'
                lblEgyptian.Visible = True
                picEgyptian.Visible = True
                lblGreeks.Visible = False
                picGreek.Visible = False
                lblRoman.Visible = False
                picRoman.Visible = False
                lblAntiquities.Visible = False

            Case 1 'if viewer selects greek exhibit, the display will show a matching photograph'
                lblGreeks.Visible = True
                picGreek.Visible = True
                lblRoman.Visible = False
                picRoman.Visible = False
                lblEgyptian.Visible = False
                picEgyptian.Visible = False
                lblAntiquities.Visible = False
            Case 2 'if viewer selects roman exhibit, the display will show a matching photograph'
                lblRoman.Visible = True
                picRoman.Visible = True
                lblGreeks.Visible = False
                picGreek.Visible = False
                lblEgyptian.Visible = False
                picEgyptian.Visible = False
                lblAntiquities.Visible = False

        End Select
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close() 'closes window'
        frmInteractive.Show() 'directs user back to Interactive page'
    End Sub

End Class