Public Class frmTerms
    Dim frmPaymentDetails As frmPaymentDetails = New frmPaymentDetails
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim ErrorMessage = ""
        Try

            If chxTermsAndConditions.Checked = False Then
                ErrorMessage = "Please Check the Terms and Conditions Box"
                Throw New System.Exception("An Exception has Occureed")

            End If
        Catch ex As Exception
            If ErrorMessage Is "" Then
                ErrorMessage = ex.Message
            End If
            MessageBox.Show(ErrorMessage, "Error")
        End Try
        If chxTermsAndConditions.Checked = True Then

            frmPaymentDetails.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub frmTerms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class