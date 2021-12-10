Public Class frmSummaryPage

    Private Sub frmSummaryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPriceBeforeTax.Text = Module1.PriceBeforeTax.ToString("C")
        txtVat.Text = Module1.VatShown.ToString("C")
        txtPriceAfterVat.Text = Module1.PriceShown.ToString("C")
        txtFortnightCost.Text = Module1.PriceAfterFort.ToString("C")
        txtWeekCost.Text = Module1.PriceAfterWeek.ToString("C")
        txtDayPrice.Text = Module1.PriceAfterDay.ToString("C")
        txtInsuranceCollision.Text = Module1.CollisionInsurance.ToString("C")
        txtInsuranceTheft.Text = Module1.InsuranceTheft.ToString("C")
        txtInsuanceContent.Text = Module1.VehicleContent.ToString("C")
        txtChildSeat.Text = Module1.ChildSeatCost.ToString("C")
        txtRoofMountedLuggage.Text = Module1.RoofMountedLuggageCost.ToString("C")
        txtSkiEquip.Text = Module1.SkiEquipCost.ToString("C")
        txtAdditionalDrivers.Text = Module1.AdditionalDriversCost.ToString("C")
        txtAddedRates.Text = Module1.TotalRates.ToString("C")
        txtCustomerName.Text = Module1.CustomerName
        txtPhoneNumber.Text = Module1.PhoneNumber
        txtPassportNumber.Text = Module1.PassportNumber
        txtTownCity.Text = Module1.TownCity
        txtCounty.Text = Module1.County
        txtStreetAddress.Text = Module1.StreetAddress

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblSkiEquipCost.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtPriceBeforeTax_TextChanged(sender As Object, e As EventArgs) Handles txtPriceBeforeTax.TextChanged

    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click

        Close()
    End Sub
End Class