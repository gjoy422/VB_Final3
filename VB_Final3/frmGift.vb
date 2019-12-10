Public Class frmGift
    Dim strMirror As String = "Mirror: $9.99"
    Dim strGlass As String = "Glass: $9.99"
    Dim strMug As String = "Mug: $4.57"
    Dim strDinosaur As String = "Dinosaur: $8.35"
    Dim strJournal As String = "Journal: $6.99"
    Dim strBookmarks As String = "Bookmarks: $7.75"
    Dim question As String = "Add to cart?"
    Dim style = MsgBoxStyle.YesNo
    Dim decSales As Decimal = 0
    Dim decTotal As Decimal = 0
    Dim decMirror = 9.99
    Dim decGlass = 9.99
    Dim decMug = 4.57
    Dim decDinosaur = 8.35
    Dim decJournal = 6.99
    Dim decBookmarks = 7.75



    Private Sub frmGift_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.Text = frmPortal.txtGuest.Text + " 's Shopping Cart"
    End Sub

    Private Sub radMirror_CheckedChanged(sender As Object, e As EventArgs) Handles radMirror.CheckedChanged
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strMirror)
            lblTotal.Text = decMirror
        End If

    End Sub

    Private Sub radGlass_Checked(sender As Object, e As EventArgs) Handles radGlass.Click
        Dim varResult
        varResult = MsgBox(question, style, "Cart")
        If varResult = MsgBoxResult.Yes Then
            lstCart.Items.Add(strGlass)


        End If
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

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged

    End Sub
End Class