Public Class frmOther
    Public Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInstruct.Text = frmPortal.txtGuest.Text + ", click the 'Select' bar to view options."
        picLogo.Visible = True
    End Sub
    Private Sub cboOther_SelectedIndex(sender As Object, e As EventArgs) Handles cboOther.SelectedIndexChanged
        Dim intCase = cboOther.SelectedIndex
        Select Case intCase
            Case 0
                grpCustomer.Visible = True
                grpComplaint.Visible = False
                grpManager.Visible = False
                grpAccounts.Visible = False
            Case 1
                grpComplaint.Visible = True
                grpManager.Visible = False
                grpAccounts.Visible = False
                grpCustomer.Visible = False
            Case 2
                grpAccounts.Visible = True
                grpManager.Visible = False
                grpComplaint.Visible = False
                grpCustomer.Visible = False
            Case 3
                grpManager.Visible = True
                grpAccounts.Visible = False
                grpComplaint.Visible = False
                grpCustomer.Visible = False
        End Select
    End Sub
    Private Sub btnSend_Click(Sender As Object, e As EventArgs) Handles btnSend.Click
        Dim strComplaint As String = txtComplaint.Text
        txtComplaint.Clear()
        Complaints.Items.Add(strComplaint)

    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Me.Close()
        frmAccount.Show()
    End Sub
End Class