
Public Class frmCarSelect


    'array made of all cars 
    Dim arrCarType() As String = {"opel zafira 8 seater 2.0 litre", "ford mondeo 1.6 litre", "renault megane 1.4 litre", "opel corsa 1.2 litre", "vw polo 1.0 litre"}
    'newCar is part of vehicle Info class takes the public properties declared
    Dim newCar As VehicleInfo = New VehicleInfo
    Dim frmTerms As frmTerms = New frmTerms





    Private Sub chxChildSeat_CheckedChanged(sender As Object, e As EventArgs) Handles chxChildSeat.CheckedChanged

    End Sub

    Private Sub btnConfirmDetails_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Default values when form first opened
        msxWeeksOfRent.Text = "000"
        msxDaysOfRent.Text = "0"
        cbxCarType.SelectedItem = ""
        pnlOptions.BackColor = Color.FromArgb(120, 0, 0, 0)





    End Sub

    Public Sub btnCalculateQuote_Click(sender As Object, e As EventArgs) Handles btnCalculateQuote.Click

        'validation
        ' was "" but when the form died 
        'Dim errorMessage = "Critical Error - Investigate"
        'Changed back to empty string and now handling in catch seemed cleaner
        Dim errorMessageCar = ""
        Try

            If cbxCarType.SelectedIndex <= -1 Then
                errorMessageCar = "Please select a car"
                Throw New System.Exception("An exception has occurred.")
            End If
            If msxWeeksOfRent.Text = ("") Then
                errorMessageCar = "Please type amount of weeks"
                Throw New System.Exception("An exception has occurred.")
            End If
            If msxDaysOfRent.Text = ("") Then
                errorMessageCar = "Please enter amount of days for rent"
                Throw New System.Exception("An exception has occurred.")
            ElseIf msxDaysOfRent.Text > 6 Then
                errorMessageCar = "Sorry days can not be greater than 6"
                Throw New System.Exception("An exception has occurred.")
            End If
            If radNoToCollision.Checked = False And radYestoCollision.Checked = False Then
                errorMessageCar = "Please Select yes or no For Collision Waiver"
                Throw New System.Exception("An exception has occurred.")
            End If
            If rdNoToTheft.Checked = False And rdYesToTheft.Checked = False Then
                errorMessageCar = "Please Select Yes or No for Theft"
                Throw New System.Exception("An exception has occurred.")
            End If
            If radNoToVehicleContents.Checked And radYesToVehiclesContents.Checked = False Then
                errorMessageCar = "Please Select Yes or No for Vehicle Contents"
                Throw New System.Exception("An exception has occurred.")
            End If

            'combobox selection is put in lower case so identical with array
            newCar.strCarType = LCase(cbxCarType.SelectedItem)
            newCar.numDaysRent = newCar.calculateDay(Convert.ToInt32(msxWeeksOfRent.Text), Convert.ToInt32(msxDaysOfRent.Text))
            newCar.hasChildSeat = chxChildSeat.Checked
            newCar.hasSkiEquipment = chxSkiEquip.Checked
            newCar.hasRoofMount = chxRoofMountedLuggage.Checked
            newCar.hasInsuranceCollision = radYestoCollision.Checked
            newCar.hasInsuranceTheft = rdYesToTheft.Checked
            newCar.hasInsuranceContent = radYesToVehiclesContents.Checked

            'Declartions made
            Dim decCalculatePrice As Decimal = 0.00
            Dim decDayRate As Decimal = 0.00
            Dim decWeekRate As Decimal = 0.00
            Dim decFornightRate As Decimal = 0.00
            Dim intCountTotalCalc As Integer = newCar.numDaysRent
            Dim intCountFortnight = 0
            Dim intCountWeek = 0
            Dim intCountDay = 0


            Dim decFinalPrice = 0.00
            Dim decFinalRefund = 0.00
            Dim decVatPrice = 0.00
            Dim InsuranceVat = 0.00



            'check if which array is selected string and assign rates
            If newCar.strCarType = (arrCarType(0)) Then
                decDayRate = 63.15
                decWeekRate = 397.85
                decFornightRate = 755.92
            End If
            If newCar.strCarType = (arrCarType(1)) Then
                decDayRate = 55.3
                decWeekRate = 348.39
                decFornightRate = 661.95
            End If
            If newCar.strCarType = (arrCarType(2)) Then
                decDayRate = 49.7
                decWeekRate = 313.11
                decFornightRate = 594.91
            End If
            If newCar.strCarType = (arrCarType(3)) Then
                decDayRate = 43.25
                decWeekRate = 272.48
                decFornightRate = 517.7
            End If
            If newCar.strCarType = (arrCarType(4)) Then
                decDayRate = 37.5
                decWeekRate = 236.25
                decFornightRate = 448.9
            End If

            'fortnight block
            Dim hasFortnight As Boolean = False

            hasFortnight = If(intCountTotalCalc / 14 >= 1, True, False)
            If hasFortnight = True Then
                intCountFortnight = Math.Floor(intCountTotalCalc / 14)
                intCountTotalCalc = intCountTotalCalc - (14 * intCountFortnight)
                decFinalPrice = decFinalPrice + (intCountFortnight * decFornightRate)
                Module1.PriceAfterFort = (intCountFortnight * decFornightRate)
            End If


            'week block
            Dim hasWeek As Boolean = False
            hasWeek = If(intCountTotalCalc / 7 >= 1, True, False)
            If hasWeek Then
                'can only be 1 week realistically maybe should just change to 1 instead of using intCountWeek?
                intCountWeek = Math.Floor(intCountTotalCalc / 7)
                intCountTotalCalc = intCountTotalCalc - (7 * intCountWeek)
                decFinalPrice = decFinalPrice + (intCountWeek * decWeekRate)
                Module1.PriceAfterWeek = (intCountWeek * decWeekRate)
            End If


            'day block
            Dim hasDay As Boolean = False
            hasDay = If(intCountTotalCalc > 0, True, False)

            If hasDay = True Then
                intCountDay = intCountTotalCalc
                decFinalPrice = decFinalPrice + (intCountDay * decDayRate)

            End If
            Module1.PriceAfterDay = (intCountDay * decDayRate)
            Module1.TotalRates = decFinalPrice

            'Insurance Calculations 

            If newCar.hasInsuranceCollision Then
                decFinalPrice = decFinalPrice + (newCar.numDaysRent * 2) - 0.23 * (newCar.numDaysRent * 2)
                decVatPrice = decVatPrice + 0.23 * (newCar.numDaysRent * 2)
                Module1.CollisionInsurance = (newCar.numDaysRent * 2) - 0.23 * (newCar.numDaysRent * 2)
                Module1.list.Add("You have added insurance Collision")
            Else
                decFinalPrice = decFinalPrice + (2000) - 0.23 * (2000)
                decFinalRefund = decFinalRefund + (2000)
                decVatPrice = decVatPrice + 0.23 * (2000)
                Module1.CollisionInsurance = (2000) - 0.23 * (2000)
            End If
            If newCar.hasInsuranceContent Then
                Dim intInsuranceWeek = 0
                If hasFortnight Then
                    intInsuranceWeek = (intCountFortnight * 2)
                End If
                If hasWeek Then
                    intInsuranceWeek = intInsuranceWeek + intCountWeek
                End If

                decFinalPrice = decFinalPrice + (intInsuranceWeek * 20) + (intCountDay * 5) - 0.23 * ((intInsuranceWeek * 20) + (intCountDay * 5))
                decVatPrice = decVatPrice + 0.23 * ((intInsuranceWeek * 20) + (intCountDay * 5))
                Module1.VehicleContent = (intInsuranceWeek * 20) + (intCountDay * 5) - 0.23 * ((intInsuranceWeek * 20) + (intCountDay * 5))
            End If
            If newCar.hasInsuranceTheft Then
                decFinalPrice = decFinalPrice + (newCar.numDaysRent * 3) - 0.23 * (newCar.numDaysRent * 3)
                decVatPrice = decVatPrice + 0.23 * (newCar.numDaysRent * 3)
                Module1.InsuranceTheft = (newCar.numDaysRent * 3) - 0.23 * (newCar.numDaysRent * 3)
                'Wanted to make a text file receipt by looping list at the end(ran out of time)
                Module1.list.Add("You have added insurance Theft")
            Else
                decFinalPrice = decFinalPrice + (3000) - 0.23 * (3000)
                decFinalRefund = decFinalRefund + (3000)
                decVatPrice = decVatPrice + 0.23 * (3000)
                Module1.InsuranceTheft = (3000) - 0.23 * (3000)

            End If
            'Extras Calculations
            If newCar.hasRoofMount Then
                decFinalPrice = decFinalPrice + (44)
                Module1.RoofMountedLuggageCost = 44
            End If
            If newCar.hasSkiEquipment Then
                decFinalPrice = decFinalPrice + (78)

            End If
            If newCar.hasAdditionalDriver Then
                decFinalPrice = decFinalPrice + (newCar.numDaysRent * 7)
                Module1.AdditionalDriversCost = (newCar.numDaysRent * 7)
            End If
            If newCar.hasChildSeat Then
                decFinalPrice = decFinalPrice + (22)
                Module1.ChildSeatCost = 22

            End If



            'Add the vat

            Dim decTaxAmount = (decFinalPrice * 0.23) + decVatPrice
            Dim decPriceAfterTax = decFinalPrice + decTaxAmount
            'Variables put equal to text box contents
            txtVAT.Text = decTaxAmount.ToString("C")
            txtPriceBeforeTax.Text = decFinalPrice.ToString("C")
            txtQuotedPrice.Text = decPriceAfterTax.ToString("C")

            'gathering variables to be used in summmary form page
            Module1.PriceShown = decPriceAfterTax
            Module1.VatShown = decTaxAmount
            Module1.PriceBeforeTax = decFinalPrice







        Catch ex As Exception

            If errorMessageCar Is "" Then
                errorMessageCar = ex.Message
            End If
            MessageBox.Show(errorMessageCar, "Error")
        End Try

    End Sub

    Private Sub radNoToCollision_CheckedChanged(sender As Object, e As EventArgs) Handles radNoToCollision.CheckedChanged
        If radNoToCollision.Checked Then
            MsgBox("Warning Surcharge of €2000 will be applied")
        End If


    End Sub

    Private Sub rdNoToTheft_CheckedChanged(sender As Object, e As EventArgs) Handles rdNoToTheft.CheckedChanged
        If rdNoToTheft.Checked Then
            MsgBox("Warning Surcharge of €3000 will be applied")
        End If
    End Sub

    Private Sub chxSkiEquip_CheckedChanged(sender As Object, e As EventArgs) Handles chxSkiEquip.CheckedChanged

    End Sub

    Private Sub chxRoofMountedLuggage_CheckedChanged(sender As Object, e As EventArgs) Handles chxRoofMountedLuggage.CheckedChanged

    End Sub

    Private Sub chxAdditionalDrivers_CheckedChanged(sender As Object, e As EventArgs) Handles chxAdditionalDrivers.CheckedChanged

    End Sub

    Private Sub txtQuotedPrice_TextChanged(sender As Object, e As EventArgs) Handles txtQuotedPrice.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'so you cant move to next form without quote
        If txtQuotedPrice.Text > "" Then
            frmTerms.Show()
            Me.Hide()
        ElseIf txtQuotedPrice.Text = "" Then
            MsgBox("Please Calculate First")



        End If
    End Sub

    Private Sub lblInsurance_Click(sender As Object, e As EventArgs) Handles lblInsurance.Click

    End Sub

    Private Sub radYestoCollision_CheckedChanged(sender As Object, e As EventArgs) Handles radYestoCollision.CheckedChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears everything 
        msxWeeksOfRent.Text = ""
        msxDaysOfRent.Text = ""
        cbxCarType.SelectedItem = ""
        chxChildSeat.Checked = False
        chxAdditionalDrivers.Checked = False
        chxSkiEquip.Checked = False
        chxRoofMountedLuggage.Checked = False
        radNoToCollision.Checked = False And radYestoCollision.Checked = False
        rdNoToTheft.Checked = False And rdYesToTheft.Checked = False
        radNoToVehicleContents.Checked = False And radYesToVehiclesContents.Checked = False


    End Sub
End Class
