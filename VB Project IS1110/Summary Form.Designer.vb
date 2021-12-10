<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummaryPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummaryPage))
        Me.gpxPaymentDetails = New System.Windows.Forms.GroupBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.txtAddedRates = New System.Windows.Forms.TextBox()
        Me.lblPriceBeforeTax = New System.Windows.Forms.Label()
        Me.lblInsuranceContent = New System.Windows.Forms.Label()
        Me.lblInsuranceTheft = New System.Windows.Forms.Label()
        Me.lblInsuranceCollision = New System.Windows.Forms.Label()
        Me.lblAdditionalDrivers = New System.Windows.Forms.Label()
        Me.lblRoofMountedLuggage = New System.Windows.Forms.Label()
        Me.lblSkiEquipCost = New System.Windows.Forms.Label()
        Me.LblChildSeatCost = New System.Windows.Forms.Label()
        Me.lblAddedRates = New System.Windows.Forms.Label()
        Me.txtAdditionalDrivers = New System.Windows.Forms.TextBox()
        Me.txtChildSeat = New System.Windows.Forms.TextBox()
        Me.txtRoofMountedLuggage = New System.Windows.Forms.TextBox()
        Me.txtSkiEquip = New System.Windows.Forms.TextBox()
        Me.txtInsuranceCollision = New System.Windows.Forms.TextBox()
        Me.txtInsuranceTheft = New System.Windows.Forms.TextBox()
        Me.txtInsuanceContent = New System.Windows.Forms.TextBox()
        Me.txtFortnightCost = New System.Windows.Forms.TextBox()
        Me.txtWeekCost = New System.Windows.Forms.TextBox()
        Me.txtDayPrice = New System.Windows.Forms.TextBox()
        Me.lblFortnightCost = New System.Windows.Forms.Label()
        Me.lblWeekCost = New System.Windows.Forms.Label()
        Me.lblDayCost = New System.Windows.Forms.Label()
        Me.txtPriceAfterVat = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtPriceBeforeTax = New System.Windows.Forms.TextBox()
        Me.gpxCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.txtPassportNumber = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.PnlCustomerBox = New System.Windows.Forms.Panel()
        Me.pnlCustomerDetails = New System.Windows.Forms.Panel()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.pnlPaymentBox = New System.Windows.Forms.Panel()
        Me.pnlPaymentDetails = New System.Windows.Forms.Panel()
        Me.lblPaymentDetails = New System.Windows.Forms.Label()
        Me.gpxPaymentDetails.SuspendLayout()
        Me.gpxCustomerDetails.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        Me.PnlCustomerBox.SuspendLayout()
        Me.pnlCustomerDetails.SuspendLayout()
        Me.pnlPaymentBox.SuspendLayout()
        Me.pnlPaymentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpxPaymentDetails
        '
        Me.gpxPaymentDetails.BackColor = System.Drawing.Color.Cornsilk
        Me.gpxPaymentDetails.Controls.Add(Me.lblTotalPrice)
        Me.gpxPaymentDetails.Controls.Add(Me.lblVAT)
        Me.gpxPaymentDetails.Controls.Add(Me.txtAddedRates)
        Me.gpxPaymentDetails.Controls.Add(Me.lblPriceBeforeTax)
        Me.gpxPaymentDetails.Controls.Add(Me.lblInsuranceContent)
        Me.gpxPaymentDetails.Controls.Add(Me.lblInsuranceTheft)
        Me.gpxPaymentDetails.Controls.Add(Me.lblInsuranceCollision)
        Me.gpxPaymentDetails.Controls.Add(Me.lblAdditionalDrivers)
        Me.gpxPaymentDetails.Controls.Add(Me.lblRoofMountedLuggage)
        Me.gpxPaymentDetails.Controls.Add(Me.lblSkiEquipCost)
        Me.gpxPaymentDetails.Controls.Add(Me.LblChildSeatCost)
        Me.gpxPaymentDetails.Controls.Add(Me.lblAddedRates)
        Me.gpxPaymentDetails.Controls.Add(Me.txtAdditionalDrivers)
        Me.gpxPaymentDetails.Controls.Add(Me.txtChildSeat)
        Me.gpxPaymentDetails.Controls.Add(Me.txtRoofMountedLuggage)
        Me.gpxPaymentDetails.Controls.Add(Me.txtSkiEquip)
        Me.gpxPaymentDetails.Controls.Add(Me.txtInsuranceCollision)
        Me.gpxPaymentDetails.Controls.Add(Me.txtInsuranceTheft)
        Me.gpxPaymentDetails.Controls.Add(Me.txtInsuanceContent)
        Me.gpxPaymentDetails.Controls.Add(Me.txtFortnightCost)
        Me.gpxPaymentDetails.Controls.Add(Me.txtWeekCost)
        Me.gpxPaymentDetails.Controls.Add(Me.txtDayPrice)
        Me.gpxPaymentDetails.Controls.Add(Me.lblFortnightCost)
        Me.gpxPaymentDetails.Controls.Add(Me.lblWeekCost)
        Me.gpxPaymentDetails.Controls.Add(Me.lblDayCost)
        Me.gpxPaymentDetails.Controls.Add(Me.txtPriceAfterVat)
        Me.gpxPaymentDetails.Controls.Add(Me.txtVat)
        Me.gpxPaymentDetails.Controls.Add(Me.txtPriceBeforeTax)
        Me.gpxPaymentDetails.Location = New System.Drawing.Point(19, 75)
        Me.gpxPaymentDetails.Name = "gpxPaymentDetails"
        Me.gpxPaymentDetails.Size = New System.Drawing.Size(469, 714)
        Me.gpxPaymentDetails.TabIndex = 0
        Me.gpxPaymentDetails.TabStop = False
        Me.gpxPaymentDetails.Text = "Payment Details "
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPrice.Location = New System.Drawing.Point(19, 666)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(72, 20)
        Me.lblTotalPrice.TabIndex = 29
        Me.lblTotalPrice.Text = "Subtotal:"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Location = New System.Drawing.Point(19, 580)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(34, 20)
        Me.lblVAT.TabIndex = 28
        Me.lblVAT.Text = "VAT"
        '
        'txtAddedRates
        '
        Me.txtAddedRates.Location = New System.Drawing.Point(218, 174)
        Me.txtAddedRates.Name = "txtAddedRates"
        Me.txtAddedRates.ReadOnly = True
        Me.txtAddedRates.Size = New System.Drawing.Size(220, 27)
        Me.txtAddedRates.TabIndex = 26
        '
        'lblPriceBeforeTax
        '
        Me.lblPriceBeforeTax.AutoSize = True
        Me.lblPriceBeforeTax.Location = New System.Drawing.Point(19, 534)
        Me.lblPriceBeforeTax.Name = "lblPriceBeforeTax"
        Me.lblPriceBeforeTax.Size = New System.Drawing.Size(114, 20)
        Me.lblPriceBeforeTax.TabIndex = 25
        Me.lblPriceBeforeTax.Text = "Price Before Tax"
        '
        'lblInsuranceContent
        '
        Me.lblInsuranceContent.AutoSize = True
        Me.lblInsuranceContent.Location = New System.Drawing.Point(19, 490)
        Me.lblInsuranceContent.Name = "lblInsuranceContent"
        Me.lblInsuranceContent.Size = New System.Drawing.Size(182, 20)
        Me.lblInsuranceContent.TabIndex = 24
        Me.lblInsuranceContent.Text = "Vehicle Content Insurance "
        '
        'lblInsuranceTheft
        '
        Me.lblInsuranceTheft.AutoSize = True
        Me.lblInsuranceTheft.Location = New System.Drawing.Point(19, 445)
        Me.lblInsuranceTheft.Name = "lblInsuranceTheft"
        Me.lblInsuranceTheft.Size = New System.Drawing.Size(109, 20)
        Me.lblInsuranceTheft.TabIndex = 23
        Me.lblInsuranceTheft.Text = "Theft Insurance"
        '
        'lblInsuranceCollision
        '
        Me.lblInsuranceCollision.AutoSize = True
        Me.lblInsuranceCollision.Location = New System.Drawing.Point(19, 401)
        Me.lblInsuranceCollision.Name = "lblInsuranceCollision"
        Me.lblInsuranceCollision.Size = New System.Drawing.Size(177, 20)
        Me.lblInsuranceCollision.TabIndex = 22
        Me.lblInsuranceCollision.Text = "Collison Insurance Waiver"
        '
        'lblAdditionalDrivers
        '
        Me.lblAdditionalDrivers.AutoSize = True
        Me.lblAdditionalDrivers.Location = New System.Drawing.Point(19, 358)
        Me.lblAdditionalDrivers.Name = "lblAdditionalDrivers"
        Me.lblAdditionalDrivers.Size = New System.Drawing.Size(175, 20)
        Me.lblAdditionalDrivers.TabIndex = 20
        Me.lblAdditionalDrivers.Text = "Additional Drives Charge"
        '
        'lblRoofMountedLuggage
        '
        Me.lblRoofMountedLuggage.AutoSize = True
        Me.lblRoofMountedLuggage.Location = New System.Drawing.Point(19, 316)
        Me.lblRoofMountedLuggage.Name = "lblRoofMountedLuggage"
        Me.lblRoofMountedLuggage.Size = New System.Drawing.Size(167, 20)
        Me.lblRoofMountedLuggage.TabIndex = 19
        Me.lblRoofMountedLuggage.Text = "Roof Mounted Luggage"
        '
        'lblSkiEquipCost
        '
        Me.lblSkiEquipCost.AutoSize = True
        Me.lblSkiEquipCost.Location = New System.Drawing.Point(19, 271)
        Me.lblSkiEquipCost.Name = "lblSkiEquipCost"
        Me.lblSkiEquipCost.Size = New System.Drawing.Size(104, 20)
        Me.lblSkiEquipCost.TabIndex = 18
        Me.lblSkiEquipCost.Text = "Ski Equipment"
        '
        'LblChildSeatCost
        '
        Me.LblChildSeatCost.AutoSize = True
        Me.LblChildSeatCost.Location = New System.Drawing.Point(19, 225)
        Me.LblChildSeatCost.Name = "LblChildSeatCost"
        Me.LblChildSeatCost.Size = New System.Drawing.Size(76, 20)
        Me.LblChildSeatCost.TabIndex = 17
        Me.LblChildSeatCost.Text = "Child Seat"
        '
        'lblAddedRates
        '
        Me.lblAddedRates.AutoSize = True
        Me.lblAddedRates.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddedRates.Location = New System.Drawing.Point(19, 181)
        Me.lblAddedRates.Name = "lblAddedRates"
        Me.lblAddedRates.Size = New System.Drawing.Size(106, 20)
        Me.lblAddedRates.TabIndex = 16
        Me.lblAddedRates.Text = "Total of Rates"
        '
        'txtAdditionalDrivers
        '
        Me.txtAdditionalDrivers.Location = New System.Drawing.Point(218, 351)
        Me.txtAdditionalDrivers.Name = "txtAdditionalDrivers"
        Me.txtAdditionalDrivers.ReadOnly = True
        Me.txtAdditionalDrivers.Size = New System.Drawing.Size(220, 27)
        Me.txtAdditionalDrivers.TabIndex = 15
        '
        'txtChildSeat
        '
        Me.txtChildSeat.Location = New System.Drawing.Point(218, 218)
        Me.txtChildSeat.Name = "txtChildSeat"
        Me.txtChildSeat.ReadOnly = True
        Me.txtChildSeat.Size = New System.Drawing.Size(220, 27)
        Me.txtChildSeat.TabIndex = 14
        '
        'txtRoofMountedLuggage
        '
        Me.txtRoofMountedLuggage.Location = New System.Drawing.Point(218, 309)
        Me.txtRoofMountedLuggage.Name = "txtRoofMountedLuggage"
        Me.txtRoofMountedLuggage.ReadOnly = True
        Me.txtRoofMountedLuggage.Size = New System.Drawing.Size(220, 27)
        Me.txtRoofMountedLuggage.TabIndex = 13
        '
        'txtSkiEquip
        '
        Me.txtSkiEquip.Location = New System.Drawing.Point(218, 264)
        Me.txtSkiEquip.Name = "txtSkiEquip"
        Me.txtSkiEquip.ReadOnly = True
        Me.txtSkiEquip.Size = New System.Drawing.Size(220, 27)
        Me.txtSkiEquip.TabIndex = 12
        '
        'txtInsuranceCollision
        '
        Me.txtInsuranceCollision.Location = New System.Drawing.Point(218, 394)
        Me.txtInsuranceCollision.Name = "txtInsuranceCollision"
        Me.txtInsuranceCollision.ReadOnly = True
        Me.txtInsuranceCollision.Size = New System.Drawing.Size(220, 27)
        Me.txtInsuranceCollision.TabIndex = 11
        '
        'txtInsuranceTheft
        '
        Me.txtInsuranceTheft.Location = New System.Drawing.Point(218, 438)
        Me.txtInsuranceTheft.Name = "txtInsuranceTheft"
        Me.txtInsuranceTheft.ReadOnly = True
        Me.txtInsuranceTheft.Size = New System.Drawing.Size(220, 27)
        Me.txtInsuranceTheft.TabIndex = 10
        '
        'txtInsuanceContent
        '
        Me.txtInsuanceContent.Location = New System.Drawing.Point(218, 483)
        Me.txtInsuanceContent.Name = "txtInsuanceContent"
        Me.txtInsuanceContent.ReadOnly = True
        Me.txtInsuanceContent.Size = New System.Drawing.Size(220, 27)
        Me.txtInsuanceContent.TabIndex = 9
        '
        'txtFortnightCost
        '
        Me.txtFortnightCost.Location = New System.Drawing.Point(218, 43)
        Me.txtFortnightCost.Name = "txtFortnightCost"
        Me.txtFortnightCost.ReadOnly = True
        Me.txtFortnightCost.Size = New System.Drawing.Size(220, 27)
        Me.txtFortnightCost.TabIndex = 8
        '
        'txtWeekCost
        '
        Me.txtWeekCost.Location = New System.Drawing.Point(218, 87)
        Me.txtWeekCost.Name = "txtWeekCost"
        Me.txtWeekCost.ReadOnly = True
        Me.txtWeekCost.Size = New System.Drawing.Size(220, 27)
        Me.txtWeekCost.TabIndex = 7
        '
        'txtDayPrice
        '
        Me.txtDayPrice.Location = New System.Drawing.Point(218, 131)
        Me.txtDayPrice.Name = "txtDayPrice"
        Me.txtDayPrice.ReadOnly = True
        Me.txtDayPrice.Size = New System.Drawing.Size(220, 27)
        Me.txtDayPrice.TabIndex = 6
        '
        'lblFortnightCost
        '
        Me.lblFortnightCost.AutoSize = True
        Me.lblFortnightCost.Location = New System.Drawing.Point(19, 46)
        Me.lblFortnightCost.Name = "lblFortnightCost"
        Me.lblFortnightCost.Size = New System.Drawing.Size(102, 20)
        Me.lblFortnightCost.TabIndex = 5
        Me.lblFortnightCost.Text = "Fortnight Cost"
        '
        'lblWeekCost
        '
        Me.lblWeekCost.AutoSize = True
        Me.lblWeekCost.Location = New System.Drawing.Point(19, 94)
        Me.lblWeekCost.Name = "lblWeekCost"
        Me.lblWeekCost.Size = New System.Drawing.Size(89, 20)
        Me.lblWeekCost.TabIndex = 4
        Me.lblWeekCost.Text = "Weekly Cost"
        '
        'lblDayCost
        '
        Me.lblDayCost.AutoSize = True
        Me.lblDayCost.Location = New System.Drawing.Point(19, 138)
        Me.lblDayCost.Name = "lblDayCost"
        Me.lblDayCost.Size = New System.Drawing.Size(68, 20)
        Me.lblDayCost.TabIndex = 3
        Me.lblDayCost.Text = "Day Cost"
        '
        'txtPriceAfterVat
        '
        Me.txtPriceAfterVat.Location = New System.Drawing.Point(218, 659)
        Me.txtPriceAfterVat.Name = "txtPriceAfterVat"
        Me.txtPriceAfterVat.ReadOnly = True
        Me.txtPriceAfterVat.Size = New System.Drawing.Size(220, 27)
        Me.txtPriceAfterVat.TabIndex = 2
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(218, 573)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(220, 27)
        Me.txtVat.TabIndex = 1
        '
        'txtPriceBeforeTax
        '
        Me.txtPriceBeforeTax.Location = New System.Drawing.Point(218, 527)
        Me.txtPriceBeforeTax.Name = "txtPriceBeforeTax"
        Me.txtPriceBeforeTax.ReadOnly = True
        Me.txtPriceBeforeTax.Size = New System.Drawing.Size(220, 27)
        Me.txtPriceBeforeTax.TabIndex = 0
        '
        'gpxCustomerDetails
        '
        Me.gpxCustomerDetails.BackColor = System.Drawing.Color.Cornsilk
        Me.gpxCustomerDetails.Controls.Add(Me.lblCounty)
        Me.gpxCustomerDetails.Controls.Add(Me.lblTownCity)
        Me.gpxCustomerDetails.Controls.Add(Me.lblPassportNumber)
        Me.gpxCustomerDetails.Controls.Add(Me.lblStreetAddress)
        Me.gpxCustomerDetails.Controls.Add(Me.lblPhoneNumber)
        Me.gpxCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.gpxCustomerDetails.Controls.Add(Me.txtCounty)
        Me.gpxCustomerDetails.Controls.Add(Me.txtTownCity)
        Me.gpxCustomerDetails.Controls.Add(Me.txtPassportNumber)
        Me.gpxCustomerDetails.Controls.Add(Me.txtStreetAddress)
        Me.gpxCustomerDetails.Controls.Add(Me.txtPhoneNumber)
        Me.gpxCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.gpxCustomerDetails.Location = New System.Drawing.Point(20, 75)
        Me.gpxCustomerDetails.Name = "gpxCustomerDetails"
        Me.gpxCustomerDetails.Size = New System.Drawing.Size(309, 362)
        Me.gpxCustomerDetails.TabIndex = 1
        Me.gpxCustomerDetails.TabStop = False
        Me.gpxCustomerDetails.Text = "Customer Details"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(6, 303)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(55, 20)
        Me.lblCounty.TabIndex = 11
        Me.lblCounty.Text = "County"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Location = New System.Drawing.Point(6, 241)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(75, 20)
        Me.lblTownCity.TabIndex = 10
        Me.lblTownCity.Text = "Town/City"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Location = New System.Drawing.Point(6, 189)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(122, 20)
        Me.lblPassportNumber.TabIndex = 9
        Me.lblPassportNumber.Text = "Passport Number"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(6, 141)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(105, 20)
        Me.lblStreetAddress.TabIndex = 8
        Me.lblStreetAddress.Text = "Street Address"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(6, 90)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(108, 20)
        Me.lblPhoneNumber.TabIndex = 7
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(6, 33)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(116, 20)
        Me.lblCustomerName.TabIndex = 6
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(136, 300)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.ReadOnly = True
        Me.txtCounty.Size = New System.Drawing.Size(154, 27)
        Me.txtCounty.TabIndex = 5
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(136, 238)
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.ReadOnly = True
        Me.txtTownCity.Size = New System.Drawing.Size(154, 27)
        Me.txtTownCity.TabIndex = 4
        '
        'txtPassportNumber
        '
        Me.txtPassportNumber.Location = New System.Drawing.Point(136, 186)
        Me.txtPassportNumber.Name = "txtPassportNumber"
        Me.txtPassportNumber.ReadOnly = True
        Me.txtPassportNumber.Size = New System.Drawing.Size(154, 27)
        Me.txtPassportNumber.TabIndex = 3
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(136, 138)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.ReadOnly = True
        Me.txtStreetAddress.Size = New System.Drawing.Size(154, 27)
        Me.txtStreetAddress.TabIndex = 2
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(136, 87)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(154, 27)
        Me.txtPhoneNumber.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(136, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(154, 27)
        Me.txtCustomerName.TabIndex = 0
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Location = New System.Drawing.Point(1, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(162, 114)
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnClose)
        Me.pnlOptions.Controls.Add(Me.btnOkay)
        Me.pnlOptions.Location = New System.Drawing.Point(160, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(771, 44)
        Me.pnlOptions.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(659, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 44)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(464, 0)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(109, 44)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'PnlCustomerBox
        '
        Me.PnlCustomerBox.BackColor = System.Drawing.Color.Cornsilk
        Me.PnlCustomerBox.Controls.Add(Me.gpxCustomerDetails)
        Me.PnlCustomerBox.Location = New System.Drawing.Point(12, 165)
        Me.PnlCustomerBox.Name = "PnlCustomerBox"
        Me.PnlCustomerBox.Size = New System.Drawing.Size(354, 457)
        Me.PnlCustomerBox.TabIndex = 4
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.BackColor = System.Drawing.Color.Azure
        Me.pnlCustomerDetails.Controls.Add(Me.lblCustomerDetails)
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(12, 165)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(354, 69)
        Me.pnlCustomerDetails.TabIndex = 2
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(3, 17)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(223, 35)
        Me.lblCustomerDetails.TabIndex = 0
        Me.lblCustomerDetails.Text = "Customer Details:"
        '
        'pnlPaymentBox
        '
        Me.pnlPaymentBox.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlPaymentBox.Controls.Add(Me.gpxPaymentDetails)
        Me.pnlPaymentBox.Location = New System.Drawing.Point(387, 165)
        Me.pnlPaymentBox.Name = "pnlPaymentBox"
        Me.pnlPaymentBox.Size = New System.Drawing.Size(508, 793)
        Me.pnlPaymentBox.TabIndex = 5
        '
        'pnlPaymentDetails
        '
        Me.pnlPaymentDetails.BackColor = System.Drawing.Color.Azure
        Me.pnlPaymentDetails.Controls.Add(Me.lblPaymentDetails)
        Me.pnlPaymentDetails.Location = New System.Drawing.Point(387, 165)
        Me.pnlPaymentDetails.Name = "pnlPaymentDetails"
        Me.pnlPaymentDetails.Size = New System.Drawing.Size(508, 69)
        Me.pnlPaymentDetails.TabIndex = 1
        '
        'lblPaymentDetails
        '
        Me.lblPaymentDetails.AutoSize = True
        Me.lblPaymentDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblPaymentDetails.Location = New System.Drawing.Point(19, 17)
        Me.lblPaymentDetails.Name = "lblPaymentDetails"
        Me.lblPaymentDetails.Size = New System.Drawing.Size(211, 35)
        Me.lblPaymentDetails.TabIndex = 0
        Me.lblPaymentDetails.Text = "Payment Details:"
        '
        'frmSummaryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(932, 944)
        Me.Controls.Add(Me.pnlPaymentDetails)
        Me.Controls.Add(Me.pnlPaymentBox)
        Me.Controls.Add(Me.pnlCustomerDetails)
        Me.Controls.Add(Me.PnlCustomerBox)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "frmSummaryPage"
        Me.Text = "Summary Page"
        Me.gpxPaymentDetails.ResumeLayout(False)
        Me.gpxPaymentDetails.PerformLayout()
        Me.gpxCustomerDetails.ResumeLayout(False)
        Me.gpxCustomerDetails.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        Me.PnlCustomerBox.ResumeLayout(False)
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.PerformLayout()
        Me.pnlPaymentBox.ResumeLayout(False)
        Me.pnlPaymentDetails.ResumeLayout(False)
        Me.pnlPaymentDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpxPaymentDetails As GroupBox
    Friend WithEvents lblFortnightCost As Label
    Friend WithEvents lblWeekCost As Label
    Friend WithEvents lblDayCost As Label
    Friend WithEvents txtPriceAfterVat As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtPriceBeforeTax As TextBox
    Friend WithEvents txtFortnightCost As TextBox
    Friend WithEvents txtWeekCost As TextBox
    Friend WithEvents txtDayPrice As TextBox
    Friend WithEvents txtInsuranceCollision As TextBox
    Friend WithEvents txtInsuranceTheft As TextBox
    Friend WithEvents txtInsuanceContent As TextBox
    Friend WithEvents txtChildSeat As TextBox
    Friend WithEvents txtRoofMountedLuggage As TextBox
    Friend WithEvents txtSkiEquip As TextBox
    Friend WithEvents txtAdditionalDrivers As TextBox
    Friend WithEvents lblPriceBeforeTax As Label
    Friend WithEvents lblInsuranceContent As Label
    Friend WithEvents lblInsuranceTheft As Label
    Friend WithEvents lblInsuranceCollision As Label
    Friend WithEvents lblAdditionalDrivers As Label
    Friend WithEvents lblRoofMountedLuggage As Label
    Friend WithEvents lblSkiEquipCost As Label
    Friend WithEvents LblChildSeatCost As Label
    Friend WithEvents lblAddedRates As Label
    Friend WithEvents txtAddedRates As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents gpxCustomerDetails As GroupBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblTownCity As Label
    Friend WithEvents lblPassportNumber As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents txtPassportNumber As TextBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents PnlCustomerBox As Panel
    Friend WithEvents pnlCustomerDetails As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents pnlPaymentBox As Panel
    Friend WithEvents pnlPaymentDetails As Panel
    Friend WithEvents lblPaymentDetails As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOkay As Button
End Class
