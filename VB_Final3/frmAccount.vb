Public Class frmAccount
    Public Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInstruct.Text = frmPortal.txtGuest.Text + ", fill in the following information to set up your account."
        txtLastname.Select()
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        grpAccount.Visible = False
        lblFinal.Visible = True
        btnPortal.Visible = True
        'inputs information'
    End Sub
    Private Sub btnPortal_Click(sender As Object, e As EventArgs) Handles btnPortal.Click
        Me.Close() 'closes the window'
        frmPortal.Show() 'opens the Portal page'
    End Sub




End Class