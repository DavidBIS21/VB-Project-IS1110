Public Class frmVanSelect
    'array with van types in it 
    Dim arrVantype() As String = {"opel corsa van", "toyota  hiace", "ford transit", "ford transit minibus (26 seater)", "mercedes runner", "nissan patrol 4x4"}
    'calls public properties from vehicleinfo class
    Dim newVan As VehicleInfo = New VehicleInfo

    Dim frmTerms As frmTerms = New frmTerms
    Private Sub lblVanPriceBeforeVat_Click(sender As Object, e As EventArgs) Handles lblVanPriceBeforeVat.Click

    End Sub

    Private Sub btnVanCalculate_Click(sender As Object, e As EventArgs) Handles btnVanCalculate.Click
        'validation done through try and catch
        Dim errorMessageVan = ""
        Try
            If cbxVanType.SelectedIndex <= -1 Then
                errorMessageVan = "Please Select a Van"
                Throw New System.Exception("An exception has occurred.")
            End If
            If msxVanWeeksOfRent.Text = "" Then
                errorMessageVan = "Please Enter Weeks"
                Throw New System.Exception("An exception has occurred.")

            End If
            If msxVanDaysOfRent.Text > 6 Then
                errorMessageVan = "Please enter days less than 7"
                Throw New System.Exception("An exception has occurred.")
            End If
            If radVanCollisionNo.Checked = False And radVanYesCollision.Checked = False Then
                errorMessageVan = "Please Either Select Yes or No for Collision"
                Throw New System.Exception("An exception has occurred.")
            End If
            If radVanNoTheft.Checked = False And radVanYesTheft.Checked = False Then
                errorMessageVan = "Please Either Select Yes or No for Theft"
                Throw New System.Exception("An exception has occurred.")
            End If
            If radVanVehicleContentsNo.Checked = False And radVanVehicleContentsYes.Checked = False Then
                errorMessageVan = "Please Either Select Yes or No for Vehicle Contents"
                Throw New System.Exception("An exception has occurred.")
            End If

        Catch exV As Exception

            If errorMessageVan Is "" Then
                errorMessageVan = exV.Message
            End If
            MessageBox.Show(errorMessageVan, "Error")
        End Try
        'uses the vehiclinfo class public properties and Lcase compare lower case of combo box to array
        newVan.strVanType = LCase(cbxVanType.SelectedItem)
        newVan.numDaysRent = newVan.calculateDay(Convert.ToInt32(msxVanWeeksOfRent.Text), Convert.ToInt32(msxVanDaysOfRent.Text))
        newVan.hasSkiEquipment = chxNissan4x4SkiEquip.Checked
        newVan.hasRoofMount = chxNissan4x4RoofMountedLuggage.Checked
        newVan.hasInsuranceCollision = radVanYesCollision.Checked
        newVan.hasInsuranceTheft = radVanYesTheft.Checked
        newVan.hasInsuranceContent = radVanVehicleContentsYes.Checked


        'declaring variables
        Dim decCalculatePrice As Decimal = 0.00
        Dim decDayRate As Decimal = 0.00
        Dim decWeekRate As Decimal = 0.00
        Dim decFornightRate As Decimal = 0.00
        Dim intCountTotalCalc As Integer = newVan.numDaysRent
        Dim intCountFortnight = 0
        Dim intCountWeek = 0
        Dim intCountDay = 0

        Dim decFinalPrice = 0.00
        Dim decFinalRefund = 0.00
        Dim decVatPrice = 0.00
        Dim InsuranceVat = 0.00

        'assigning rates depending on which van picked
        If newVan.strVanType = (arrVantype(0)) Then
            decDayRate = 35.1
            decWeekRate = 221.13
            decFornightRate = 420.15
        End If
        If newVan.strVanType = (arrVantype(1)) Then
            decDayRate = 39.9
            decWeekRate = 251.37
            decFornightRate = 477.6
        End If
        If newVan.strVanType = (arrVantype(2)) Then
            decDayRate = 65.4
            decWeekRate = 412.02
            decFornightRate = 782.84
        End If
        If newVan.strVanType = (arrVantype(3)) Then
            decDayRate = 68.9
            decWeekRate = 434.07
            decFornightRate = 824.73
        End If
        If newVan.strVanType = (arrVantype(4)) Then
            decDayRate = 89.6
            decWeekRate = 564.48
            decFornightRate = 1072.51
        End If
        If newVan.strVanType = (arrVantype(5)) Then
            decDayRate = 78.8
            decWeekRate = 496.44
            decFornightRate = 943.24
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

        'Insurance block
        If newVan.hasInsuranceCollision Then
            decFinalPrice = decFinalPrice + (newVan.numDaysRent * 2) - 0.23 * (newVan.numDaysRent * 2)
            decVatPrice = decVatPrice + 0.23 * (newVan.numDaysRent * 2)
            Module1.CollisionInsurance = (newVan.numDaysRent * 2) - 0.23 * (newVan.numDaysRent * 2)
        Else
            decFinalPrice = decFinalPrice + (2000) - 0.23 * (2000)
            decFinalRefund = decFinalRefund + (2000)
            decVatPrice = decVatPrice + 0.23 * (2000)
            Module1.CollisionInsurance = (2000) - 0.23 * (2000)
            'might make an invoice if i have time
        End If
        If newVan.hasInsuranceContent Then
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
        If newVan.hasInsuranceTheft Then
            decFinalPrice = decFinalPrice + (newVan.numDaysRent * 3) - 0.23 * (newVan.numDaysRent * 3)
            decVatPrice = decVatPrice + 0.23 * (newVan.numDaysRent * 3)
            Module1.InsuranceTheft = (newVan.numDaysRent * 3) - 0.23 * (newVan.numDaysRent * 3)

        Else
            decFinalPrice = decFinalPrice + (3000) - 0.23 * (3000)
            decFinalRefund = decFinalRefund + (3000)
            decVatPrice = decVatPrice + 0.23 * (3000)
            Module1.InsuranceTheft = (3000) - 0.23 * (3000)

        End If
        'Extras block
        If newVan.hasAdditionalDriver Then
            decFinalPrice = decFinalPrice + (newVan.numDaysRent * 7)
            Module1.PriceAfterDay = (intCountDay * decDayRate)
            Module1.TotalRates = decFinalPrice
        End If

        If newVan.hasRoofMount Then
            decFinalPrice = decFinalPrice + (44)
            Module1.RoofMountedLuggageCost = 44
        End If


        If newVan.hasSkiEquipment Then
            decFinalPrice = decFinalPrice + (78)
            Module1.SkiEquipCost = 78
        End If






        'Add the vat

        Dim decTaxAmount = (decFinalPrice * 0.23) + decVatPrice
        Dim decPriceAfterTax = decFinalPrice + decTaxAmount
        'final values of calculation
        txtVanVat.Text = decTaxAmount.ToString("C")
        txtVanBeforeTax.Text = decFinalPrice.ToString("C")
        txtQuotedPrice.Text = decPriceAfterTax.ToString("C")

        'gathering variables to be used in summmary form page
        Module1.PriceShown = decPriceAfterTax
        Module1.VatShown = decTaxAmount
        Module1.PriceBeforeTax = decFinalPrice


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'default values set
        msxVanWeeksOfRent.Text = "000"
        msxVanDaysOfRent.Text = "0"
        cbxVanType.SelectedItem = "Opel Corsa Van"
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next only works if button calculate pressed so cant advance without a quote
        If txtQuotedPrice.Text > "" Then
            frmTerms.Show()
            Me.Hide()
        ElseIf txtQuotedPrice.Text = "" Then
            MsgBox("Please Calculate First")

        End If



    End Sub

    Private Sub radVanCollisionNo_CheckedChanged(sender As Object, e As EventArgs) Handles radVanCollisionNo.CheckedChanged
        If radVanCollisionNo.Checked Then
            MsgBox("Warning Surcharge of €2000 will be applied")
        End If
    End Sub

    Private Sub radVanNoTheft_CheckedChanged(sender As Object, e As EventArgs) Handles radVanNoTheft.CheckedChanged
        If radVanNoTheft.Checked Then
            MsgBox("Warning Surcharge of €3000 will be applied")
        End If
    End Sub

    Private Sub lblVanInsurance_Click(sender As Object, e As EventArgs) Handles lblVanInsurance.Click

    End Sub

    Private Sub btnVanCalculate_Click_1(sender As Object, e As EventArgs) Handles btnVanCalculate.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblFordTransitMiniBus.Click

    End Sub

    Private Sub chxNissan4x4RoofMountedLuggage_CheckedChanged(sender As Object, e As EventArgs) Handles chxNissan4x4RoofMountedLuggage.CheckedChanged
        'statement that means only Nissan can have roof mounted luggage
        If cbxVanType.SelectedItem = "Nissan Patrol 4X4" Then
            chxNissan4x4RoofMountedLuggage.Checked = True Or False
        Else
            chxNissan4x4RoofMountedLuggage.Checked = False
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all masked text boxs and clears radio buttons and the checkboxs
        msxVanDaysOfRent.Text = ""
        msxVanWeeksOfRent.Text = ""
        cbxVanType.SelectedItem = ""
        chxVanAdditionalDrivers.Checked = False
        chxNissan4x4SkiEquip.Checked = False
        chxNissan4x4RoofMountedLuggage.Checked = False
        radVanCollisionNo.Checked = False And radVanYesCollision.Checked = False
        radVanNoTheft.Checked = False And radVanYesTheft.Checked = False
        radVanVehicleContentsNo.Checked = False And radVanVehicleContentsYes.Checked = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub chxNissan4x4SkiEquip_CheckedChanged(sender As Object, e As EventArgs) Handles chxNissan4x4SkiEquip.CheckedChanged
        If cbxVanType.SelectedItem = "Nissan Patrol 4X4" Then
            chxNissan4x4SkiEquip.Checked = True Or False
        Else
            chxNissan4x4SkiEquip.Checked = False
        End If
    End Sub

    Private Sub chxVanAdditionalDrivers_CheckedChanged(sender As Object, e As EventArgs) Handles chxVanAdditionalDrivers.CheckedChanged

    End Sub
End Class