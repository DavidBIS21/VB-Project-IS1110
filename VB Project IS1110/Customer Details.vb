Public Class frmCustomerDetails
    Dim frmVehicleType As frmVehicleType = New frmVehicleType


    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxCustomerName.MaskInputRejected
        msxCustomerName.Focus()

        msxCustomerName.SelectionStart = 0
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxPhoneNumber.MaskInputRejected
        msxPhoneNumber.Focus()

        msxPhoneNumber.SelectionStart = 0
    End Sub

    Private Sub btnConfirmDetails_Click(sender As Object, e As EventArgs) Handles btnConfirmDetails.Click
        Dim errorMessageCustomer = ""


        Try

            If msxCustomerName.Text = "" Then
                errorMessageCustomer = "Please Enter Your Name"
                Throw New System.Exception("An exception has occured")
            End If
            If msxPhoneNumber.Text = "" Then
                errorMessageCustomer = "Please Enter Your Phone Number"
                Throw New System.Exception("An exception has occured")

            End If
            If msxPassportNumber.Text = "" Then
                errorMessageCustomer = "Please Enter a Passport Number"
                Throw New System.Exception("An exception has occured")
            End If
            If msxStreetAddress.Text = "" Then
                errorMessageCustomer = ("Please Enter a Street Address")
                Throw New System.Exception("An exception has occured")
            End If
            If msxTownCity.Text = "" Then
                errorMessageCustomer = ("Please Enter a Town")
                Throw New System.Exception("An exception has occured")
            End If
            If msxCounty.Text = "" Then
                errorMessageCustomer = ("Please Enter a County")
                Throw New System.Exception("An exception has occured")

            End If

            Dim CharLimit As Integer = 7
            Dim CharLoop As Integer = 0
            Dim IsValid = True
            'made for each to check each character in password text field to validate it 
            'iterates through each "item" as a character to check if valid
            For Each item As Char In msxPassportNumber.Text
                'set limit here for checking passports characters
                If CharLoop < CharLimit Then

                    If IsNumeric(item) = False Then
                        IsValid = False
                    End If
                Else
                    If Char.IsLetter(item) = False Then
                        IsValid = False
                    End If
                End If
                If IsValid = False Then
                    errorMessageCustomer = ("Please Enter a Valid Password please , must be 7 numbers followed by a Letter")
                    Throw New System.Exception("An exception has occured") 'test git commit
                End If
                CharLoop = CharLoop + 1
            Next




        Catch exC As Exception
            If errorMessageCustomer Is "" Then
                errorMessageCustomer = exC.Message
            End If
            MessageBox.Show(errorMessageCustomer, "Error")
        End Try
        Module1.CustomerName = msxCustomerName.Text
        Module1.PhoneNumber = msxPhoneNumber.Text
        Module1.PassportNumber = msxPassportNumber.Text
        Module1.StreetAddress = msxStreetAddress.Text
        Module1.TownCity = msxTownCity.Text
        Module1.County = msxCounty.Text

        'if exception not caught then open the vehicle type form
        If errorMessageCustomer = "" Then
            frmVehicleType.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub btnCustomerDetailsClear_Click(sender As Object, e As EventArgs) Handles btnCustomerDetailsClear.Click
        msxCustomerName.Text = ""
        msxPassportNumber.Text = ""
        msxCounty.Text = ""
        msxStreetAddress.Text = ""
        msxTownCity.Text = ""
        msxPhoneNumber.Text = ""
    End Sub

    Private Sub frmCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlOptions.BackColor = Color.FromArgb(120, 0, 0, 0)



        lblCounty.BackColor = Color.Transparent
        lblCustomerName.BackColor = Color.Transparent
        lblCustomerDetails.BackColor = Color.Transparent
        lblPassportNumber.BackColor = Color.Transparent
        lblPhoneNumber.BackColor = Color.Transparent
        lblTownCity.BackColor = Color.Transparent
        lblStreetAddress.BackColor = Color.Transparent







    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub msxStreetAddress_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxStreetAddress.MaskInputRejected
        'Attempted to fix the problem of the cursor not starting on the left of the box

        msxStreetAddress.Focus()

        msxStreetAddress.SelectionStart = 0
    End Sub

    Private Sub msxPassportNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxPassportNumber.MaskInputRejected
        msxPassportNumber.Focus()
        msxPassportNumber.SelectionStart = 0
    End Sub

    Private Sub msxTownCity_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxTownCity.MaskInputRejected
        msxTownCity.Focus()

        msxTownCity.SelectionStart = 0
    End Sub

    Private Sub msxCounty_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msxCounty.MaskInputRejected
        msxCounty.Focus()

        msxCounty.SelectionStart = 0
    End Sub
End Class