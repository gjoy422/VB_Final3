Public Class frmGuest
    Public Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNew2.Visible = True 'loads information from Portal slide'
    End Sub
    Private Sub btnExplore_Click(sender As Object, e As EventArgs) Handles btnExplore.Click
        frmInteractive.Show() 'opens Interactive page'
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        frmAccount.Show() 'opens Account page'
    End Sub

End Class