Public Class frmPortal
    Inherits System.Windows.Forms.Form
    Dim strLogin As String
    Dim strGuest As String

    Public Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        strLogin = txtLogin.Text
        strGuest = txtGuest.Text

        If txtLogin.Text = "" Then
            lblNew.Visible = False
        Else
            frmOpen.Show()
            strLogin = txtLogin.Text
            frmOpen.lblNew.Text = "Welcome back " & txtLogin.Text & "!"
        End If
        If txtGuest.Text = "" Then
            lblNew2.Visible = False
        Else
            frmGuest.Show()
            strGuest = txtGuest.Text
            frmGuest.lblNew2.Text = "Welcome " & txtGuest.Text & "!"
        End If
    End Sub

    Private Sub lblNew2_Click(sender As Object, e As EventArgs) Handles lblNew2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



