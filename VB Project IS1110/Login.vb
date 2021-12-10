
'IS1110 Group Project
'David Corcoran(118442512) , Brian Daly(121418354) and Kieran Griffin(121765775) In Group 

Public Class form1


    Public eChecker As Integer = 0
    Dim frmCustomerDetails As frmCustomerDetails = New frmCustomerDetails

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Try
            Dim strUsername As String = txtUsername.Text
            Dim strPassword As String = txtPassword.Text
            'do unti the user either gets it right or wrong 5 times 
            Do Until (eChecker > 4)
                eChecker += 1
                If strUsername = "admin" And strPassword = "admin" Then
                    frmCustomerDetails.Show()
                    Me.Hide()
                    Exit Do
                Else

                    'should I clear the username if that is right. Those it let hacker know the username is potentially correct if I don't?
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                    MessageBox.Show("Incorrect Credential, Error count is now " & eChecker)
                    Exit Do
                End If

            Loop
            If eChecker > 4 Then
                MessageBox.Show("Maximum Number of Errors (5) reached, the system will now close")
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            'Had the stack trace here aswell but was overkill and didnt get it
            'MessageBox.Show(ex.Message + " " + ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form decoration
        pnlRentACar.BackColor = Color.FromArgb(120, 0, 0, 0)
        pnlOptions.BackColor = Color.FromArgb(120, 0, 0, 0)

        lblPassword.BackColor = Color.Transparent
        lblUsername.BackColor = Color.Transparent
        lblWelcome.BackColor = Color.Transparent

        lblWelcome.ForeColor = Color.White
        lblUsername.ForeColor = Color.White
        lblPassword.ForeColor = Color.White


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""

    End Sub
End Class
