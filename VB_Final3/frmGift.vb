Public Class frmGift
    Dim strMirror As String = "Mirror"
    Dim strGlass As String = "Glass"
    Dim strMug As String = "Mug"
    Dim strDinosaur As String = "Dinosaur"
    Dim strJournal As String = "Journal"
    Dim strBookmarks As String = "Bookmarks"
    Dim question As String = "Add to cart?"
    Dim style = MsgBoxStyle.YesNo

    Private Sub frmGift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.Text = frmPortal.txtGuest.Text + " 's Shopping Cart"
    End Sub

    Private Sub radMirror_CheckedChanged(sender As Object, e As EventArgs) Handles radMirror.CheckedChanged
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strMirror)
        End If
    End Sub

    Private Sub radGlass_Checked(sender As Object, e As EventArgs) Handles radGlass.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strGlass)

        End If
        'ggjg
    End Sub
    Private Sub radMug_Checked(sender As Object, e As EventArgs) Handles radMug.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strMug)
        End If
    End Sub
    Private Sub radDinosaur_Checked(sender As Object, e As EventArgs) Handles radDinosaur.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strDinosaur)
        End If
    End Sub
    Private Sub radJournal_Checked(sender As Object, e As EventArgs) Handles radJournal.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strJournal)
        End If
    End Sub
    Private Sub radBookmarks_Checked(sender As Object, e As EventArgs) Handles radBookmarks.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strBookmarks)
        End If
    End Sub
    Private Sub btnReturn_Checked(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        frmInteractive.Show()
    End Sub

End Class