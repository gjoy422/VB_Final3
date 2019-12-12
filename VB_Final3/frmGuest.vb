Public Class frmGuest
    Public Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNew2.Visible = True
    End Sub
    Private Sub btnExplore_Click(sender As Object, e As EventArgs) Handles btnExplore.Click
        frmInteractive.Show()
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        frmAccount.Show()
    End Sub

End Class