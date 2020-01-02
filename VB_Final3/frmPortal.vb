Public Class frmPortal
    Inherits System.Windows.Forms.Form
    Dim strLogin As String
    Dim strGuest As String

    Public Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        strLogin = txtLogin.Text 'employee login'
        strGuest = txtGuest.Text 'guest login'

        If txtLogin.Text = "" Then 'if employee login is empty, nothing happens'
            lblNew.Visible = False
        Else
            frmOpen.Show() 'if employee login is filled, employee portal opens'
            strLogin = txtLogin.Text
            frmOpen.lblNew.Text = "Welcome back " & txtLogin.Text & "!"
        End If
        If txtGuest.Text = "" Then 'if guest login is empty, nothing happens'
            lblNew2.Visible = False
        Else
            frmGuest.Show() 'if guest login is filled, employee portal opens'
            strGuest = txtGuest.Text
            frmGuest.lblNew2.Text = "Welcome " & txtGuest.Text & "!"
        End If
    End Sub


End Class



