Public Class frmOpen
    Public Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNew.Visible = True

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If radNatural.Checked = True Then
            lblNatural.Visible = True
            btnOpen.Visible = False
            btnClose.Visible = True
            monCal.Visible = False
            RichTextBox.Visible = False
            grpPortal.Visible = False
        End If
        If radPersonal.Checked = True Then
            lblPersonal.Visible = True
            btnOpen.Visible = False
            btnClose.Visible = True
            monCal.Visible = False
            RichTextBox.Visible = False
            grpPortal.Visible = False
        End If
        If radPromotions.Checked = True Then
            lblPromotions.Visible = True
            btnOpen.Visible = False
            btnClose.Visible = True
            monCal.Visible = False
            RichTextBox.Visible = False
            grpPortal.Visible = False
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        lblPromotions.Visible = False
        lblPersonal.Visible = False
        lblNatural.Visible = False
        btnOpen.Visible = True
        monCal.Visible = True
        RichTextBox.Visible = True
        grpPortal.Visible = True
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, e As EventArgs) Handles btnUpdate.Click
        Dim str As String
        str = ""
        If chkUnavailable.Checked = True Then
            lblEmployee.Visible = True
            lblEmployee.Text = frmPortal.txtLogin.Text + " is unavailable."
        End If

        If chkAll.Checked = True Then
            lblEmployee.Visible = True
            lblEmployee.Text = frmPortal.txtLogin.Text + " is available on all floors."
        End If

        If chkClassical.Checked = True Then
            str = chkClassical.Text
            str &= ""
            lblEmployee.Text = frmPortal.txtLogin.Text + " is available on/at: " & str & " (s)."
        End If
        If chkNatural.Checked = True Then
            str &= chkNatural.Text
            str &= ""
            lblEmployee.Text = frmPortal.txtLogin.Text + " is available on/at: " & str & " (s)."
        End If
        If chkGift.Checked = True Then
            str &= chkGift.Text
            str &= ""
            lblEmployee.Text = frmPortal.txtLogin.Text + " is available on/at: " & str & " (s)."
        End If
        If chkAntiquities.Checked = True Then
            str &= chkAntiquities.Text
            str &= ""
            lblEmployee.Text = frmPortal.txtLogin.Text + " is available on/at:  " & str & " (s)."
        End If

    End Sub
    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPersonal.Click

    End Sub

    Private Sub lblNatural_Click(sender As Object, e As EventArgs) Handles lblNatural.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged

    End Sub
End Class