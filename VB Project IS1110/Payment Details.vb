
Public Class frmPaymentDetails
    Dim frmSummaryPage As frmSummaryPage = New frmSummaryPage



    Private Sub frmPaymentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'code module1 was made with variable priceshown which its scope is declared in module1
        txtQuotedPrice2.Text = Module1.PriceShown.ToString("C")
        pnlOptions.BackColor = Color.FromArgb(120, 0, 0, 0)
        msxCardNumber.Focus()

        msxCardNumber.SelectionStart = 0
    End Sub

    Private Sub btnConfirmDetails_Click(sender As Object, e As EventArgs) Handles btnConfirmDetails.Click
        'Validation with try and catch
        Dim ErrorMessage = ""
        Try
            If msxCardNumber.Text = "" Then
                ErrorMessage = "Please Enter Card Details"
                Throw New System.Exception("An Exception has Occured")
            End If


            If msxCVC.Text = "" Then
                ErrorMessage = "Please Enter CVC"
                Throw New System.Exception("An Exception has Occured")
            End If

            If msxExpiryDate.Text = "" Then
                ErrorMessage = "Please Enter an Expiry Date"
                Throw New System.Exception("An Exception has Occured")

            End If
            If radMastercard.Checked = False And radVisa.Checked = False Then
                ErrorMessage = "Please Either check Yes or No for Card Option"
                Throw New System.Exception("An Exception has Occured")
            End If

        Catch exP As Exception
            If ErrorMessage Is "" Then
                ErrorMessage = exP.Message
            End If
            MessageBox.Show(ErrorMessage, "Error")

        End Try
        'next form is opened if the error message is empty stirng 
        If ErrorMessage = "" Then
            frmSummaryPage.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub txtQuotedPrice_TextChanged(sender As Object, e As EventArgs) Handles txtQuotedPrice2.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLear button sets all text boxs to empty strings and puts bothe radio buttons to off
        msxCardNumber.Text = ""
        msxCVC.Text = ""
        msxExpiryDate.Text = ""
        radMastercard.Checked = False And radVisa.Checked = False



    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'clsoes programme
        Close()
    End Sub

    Private Sub msxCardNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxCardNumber.MaskInputRejected
        msxCardNumber.Focus()

        msxCardNumber.SelectionStart = 0
    End Sub
End Class