<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarSelect))
        Me.cbxCarType = New System.Windows.Forms.ComboBox()
        Me.lblSelectCarType = New System.Windows.Forms.Label()
        Me.msxWeeksOfRent = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumberOfWeeksRent = New System.Windows.Forms.Label()
        Me.lblExtrasForCar = New System.Windows.Forms.Label()
        Me.radYestoCollision = New System.Windows.Forms.RadioButton()
        Me.radNoToCollision = New System.Windows.Forms.RadioButton()
        Me.radYesToTheft = New System.Windows.Forms.RadioButton()
        Me.radNoToTheft = New System.Windows.Forms.RadioButton()
        Me.radYesToVehiclesContents = New System.Windows.Forms.RadioButton()
        Me.radNoToVehicleContents = New System.Windows.Forms.RadioButton()
        Me.lblPriceQuote = New System.Windows.Forms.Label()
        Me.txtQuotedPrice = New System.Windows.Forms.TextBox()
        Me.chxChildSeat = New System.Windows.Forms.CheckBox()
        Me.chxSkiEquip = New System.Windows.Forms.CheckBox()
        Me.chxRoofMountedLuggage = New System.Windows.Forms.CheckBox()
        Me.chxAdditionalDrivers = New System.Windows.Forms.CheckBox()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.gpxCollisionWaiver = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gpxTheft = New System.Windows.Forms.GroupBox()
        Me.rdYesToTheft = New System.Windows.Forms.RadioButton()
        Me.rdNoToTheft = New System.Windows.Forms.RadioButton()
        Me.gpxVehicleContents = New System.Windows.Forms.GroupBox()
        Me.gpxCarExtras = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnCalculateQuote = New System.Windows.Forms.Button()
        Me.lblNoOfDaysRent = New System.Windows.Forms.Label()
        Me.msxDaysOfRent = New System.Windows.Forms.MaskedTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtPriceBeforeTax = New System.Windows.Forms.TextBox()
        Me.lblPriceBeforeTax = New System.Windows.Forms.Label()
        Me.lblPleaseSelectCar = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GpcCarPrices = New System.Windows.Forms.GroupBox()
        Me.lblOpelZaifraFortnightRate = New System.Windows.Forms.Label()
        Me.lblOpelZaifraWeekRate = New System.Windows.Forms.Label()
        Me.lblOpelZaifraDayRate = New System.Windows.Forms.Label()
        Me.lblFordFortnightRate = New System.Windows.Forms.Label()
        Me.lblFordWeekRate = New System.Windows.Forms.Label()
        Me.lblFordDayRate = New System.Windows.Forms.Label()
        Me.lblRenaultFortnightRate = New System.Windows.Forms.Label()
        Me.lblRenaultWeekRate = New System.Windows.Forms.Label()
        Me.lblRenaultDayRate = New System.Windows.Forms.Label()
        Me.lblOpelFortnightRate = New System.Windows.Forms.Label()
        Me.lblOpelWeekRate = New System.Windows.Forms.Label()
        Me.lblOpelDayRate = New System.Windows.Forms.Label()
        Me.lblVFortnightRate = New System.Windows.Forms.Label()
        Me.lblVWWeekRate = New System.Windows.Forms.Label()
        Me.lblVwDayRate = New System.Windows.Forms.Label()
        Me.lblFortnightRate = New System.Windows.Forms.Label()
        Me.lblWeekRate = New System.Windows.Forms.Label()
        Me.lblDayRate = New System.Windows.Forms.Label()
        Me.lblOpelZaifra = New System.Windows.Forms.Label()
        Me.lblFordMondeo = New System.Windows.Forms.Label()
        Me.lblRenaultMegane = New System.Windows.Forms.Label()
        Me.lblOpelCorsa = New System.Windows.Forms.Label()
        Me.lblVWPolo = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlCarSelect = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblQuotePrice = New System.Windows.Forms.Label()
        Me.gpxCollisionWaiver.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpxTheft.SuspendLayout()
        Me.gpxVehicleContents.SuspendLayout()
        Me.gpxCarExtras.SuspendLayout()
        Me.GpcCarPrices.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCarSelect.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxCarType
        '
        Me.cbxCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCarType.FormattingEnabled = True
        Me.cbxCarType.Items.AddRange(New Object() {"VW Polo 1.0 Litre", "Opel Corsa 1.2 Litre", "Renault Megane 1.4 Litre", "Ford Mondeo 1.6 Litre", "Opel Zafira 8 Seater 2.0 Litre"})
        Me.cbxCarType.Location = New System.Drawing.Point(222, 272)
        Me.cbxCarType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxCarType.Name = "cbxCarType"
        Me.cbxCarType.Size = New System.Drawing.Size(158, 28)
        Me.cbxCarType.TabIndex = 0
        '
        'lblSelectCarType
        '
        Me.lblSelectCarType.AutoSize = True
        Me.lblSelectCarType.Location = New System.Drawing.Point(20, 275)
        Me.lblSelectCarType.Name = "lblSelectCarType"
        Me.lblSelectCarType.Size = New System.Drawing.Size(136, 20)
        Me.lblSelectCarType.TabIndex = 1
        Me.lblSelectCarType.Text = "Please Select a Car:"
        '
        'msxWeeksOfRent
        '
        Me.msxWeeksOfRent.Location = New System.Drawing.Point(222, 315)
        Me.msxWeeksOfRent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxWeeksOfRent.Mask = "000"
        Me.msxWeeksOfRent.Name = "msxWeeksOfRent"
        Me.msxWeeksOfRent.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msxWeeksOfRent.Size = New System.Drawing.Size(47, 27)
        Me.msxWeeksOfRent.TabIndex = 2
        '
        'lblNumberOfWeeksRent
        '
        Me.lblNumberOfWeeksRent.AutoSize = True
        Me.lblNumberOfWeeksRent.Location = New System.Drawing.Point(20, 318)
        Me.lblNumberOfWeeksRent.Name = "lblNumberOfWeeksRent"
        Me.lblNumberOfWeeksRent.Size = New System.Drawing.Size(180, 20)
        Me.lblNumberOfWeeksRent.TabIndex = 3
        Me.lblNumberOfWeeksRent.Text = "Number of weeks to Rent:"
        '
        'lblExtrasForCar
        '
        Me.lblExtrasForCar.AutoSize = True
        Me.lblExtrasForCar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblExtrasForCar.Location = New System.Drawing.Point(3, 10)
        Me.lblExtrasForCar.Name = "lblExtrasForCar"
        Me.lblExtrasForCar.Size = New System.Drawing.Size(271, 35)
        Me.lblExtrasForCar.TabIndex = 5
        Me.lblExtrasForCar.Text = "Optional Extras for Car:"
        '
        'radYestoCollision
        '
        Me.radYestoCollision.AutoSize = True
        Me.radYestoCollision.Location = New System.Drawing.Point(7, 22)
        Me.radYestoCollision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radYestoCollision.Name = "radYestoCollision"
        Me.radYestoCollision.Size = New System.Drawing.Size(51, 24)
        Me.radYestoCollision.TabIndex = 6
        Me.radYestoCollision.TabStop = True
        Me.radYestoCollision.Text = "Yes"
        Me.radYestoCollision.UseVisualStyleBackColor = True
        '
        'radNoToCollision
        '
        Me.radNoToCollision.AutoSize = True
        Me.radNoToCollision.Location = New System.Drawing.Point(91, 22)
        Me.radNoToCollision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radNoToCollision.Name = "radNoToCollision"
        Me.radNoToCollision.Size = New System.Drawing.Size(50, 24)
        Me.radNoToCollision.TabIndex = 7
        Me.radNoToCollision.Text = "No"
        Me.radNoToCollision.UseVisualStyleBackColor = True
        '
        'radYesToTheft
        '
        Me.radYesToTheft.AutoSize = True
        Me.radYesToTheft.Location = New System.Drawing.Point(7, 29)
        Me.radYesToTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radYesToTheft.Name = "radYesToTheft"
        Me.radYesToTheft.Size = New System.Drawing.Size(51, 24)
        Me.radYesToTheft.TabIndex = 10
        Me.radYesToTheft.TabStop = True
        Me.radYesToTheft.Text = "Yes"
        Me.radYesToTheft.UseVisualStyleBackColor = True
        '
        'radNoToTheft
        '
        Me.radNoToTheft.AutoSize = True
        Me.radNoToTheft.Location = New System.Drawing.Point(78, 29)
        Me.radNoToTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radNoToTheft.Name = "radNoToTheft"
        Me.radNoToTheft.Size = New System.Drawing.Size(50, 24)
        Me.radNoToTheft.TabIndex = 11
        Me.radNoToTheft.Text = "No"
        Me.radNoToTheft.UseVisualStyleBackColor = True
        '
        'radYesToVehiclesContents
        '
        Me.radYesToVehiclesContents.AutoSize = True
        Me.radYesToVehiclesContents.Location = New System.Drawing.Point(7, 23)
        Me.radYesToVehiclesContents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radYesToVehiclesContents.Name = "radYesToVehiclesContents"
        Me.radYesToVehiclesContents.Size = New System.Drawing.Size(51, 24)
        Me.radYesToVehiclesContents.TabIndex = 13
        Me.radYesToVehiclesContents.TabStop = True
        Me.radYesToVehiclesContents.Text = "Yes"
        Me.radYesToVehiclesContents.UseVisualStyleBackColor = True
        '
        'radNoToVehicleContents
        '
        Me.radNoToVehicleContents.AutoSize = True
        Me.radNoToVehicleContents.Location = New System.Drawing.Point(85, 23)
        Me.radNoToVehicleContents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radNoToVehicleContents.Name = "radNoToVehicleContents"
        Me.radNoToVehicleContents.Size = New System.Drawing.Size(50, 24)
        Me.radNoToVehicleContents.TabIndex = 14
        Me.radNoToVehicleContents.Text = "No"
        Me.radNoToVehicleContents.UseVisualStyleBackColor = True
        '
        'lblPriceQuote
        '
        Me.lblPriceQuote.AutoSize = True
        Me.lblPriceQuote.Location = New System.Drawing.Point(0, 230)
        Me.lblPriceQuote.Name = "lblPriceQuote"
        Me.lblPriceQuote.Size = New System.Drawing.Size(89, 20)
        Me.lblPriceQuote.TabIndex = 16
        Me.lblPriceQuote.Text = "Price Quote:"
        '
        'txtQuotedPrice
        '
        Me.txtQuotedPrice.Location = New System.Drawing.Point(199, 227)
        Me.txtQuotedPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuotedPrice.Name = "txtQuotedPrice"
        Me.txtQuotedPrice.ReadOnly = True
        Me.txtQuotedPrice.Size = New System.Drawing.Size(267, 27)
        Me.txtQuotedPrice.TabIndex = 17
        '
        'chxChildSeat
        '
        Me.chxChildSeat.AutoSize = True
        Me.chxChildSeat.Location = New System.Drawing.Point(31, 29)
        Me.chxChildSeat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxChildSeat.Name = "chxChildSeat"
        Me.chxChildSeat.Size = New System.Drawing.Size(136, 24)
        Me.chxChildSeat.TabIndex = 18
        Me.chxChildSeat.Text = "Child Seat (€22)"
        Me.chxChildSeat.UseVisualStyleBackColor = True
        '
        'chxSkiEquip
        '
        Me.chxSkiEquip.AutoSize = True
        Me.chxSkiEquip.Location = New System.Drawing.Point(31, 63)
        Me.chxSkiEquip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxSkiEquip.Name = "chxSkiEquip"
        Me.chxSkiEquip.Size = New System.Drawing.Size(164, 24)
        Me.chxSkiEquip.TabIndex = 19
        Me.chxSkiEquip.Text = "Ski Equipment (€78)"
        Me.chxSkiEquip.UseVisualStyleBackColor = True
        '
        'chxRoofMountedLuggage
        '
        Me.chxRoofMountedLuggage.AutoSize = True
        Me.chxRoofMountedLuggage.Location = New System.Drawing.Point(31, 93)
        Me.chxRoofMountedLuggage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxRoofMountedLuggage.Name = "chxRoofMountedLuggage"
        Me.chxRoofMountedLuggage.Size = New System.Drawing.Size(227, 24)
        Me.chxRoofMountedLuggage.TabIndex = 20
        Me.chxRoofMountedLuggage.Text = "Roof Mounted Luggage (€44)"
        Me.chxRoofMountedLuggage.UseVisualStyleBackColor = True
        '
        'chxAdditionalDrivers
        '
        Me.chxAdditionalDrivers.AutoSize = True
        Me.chxAdditionalDrivers.Location = New System.Drawing.Point(31, 129)
        Me.chxAdditionalDrivers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxAdditionalDrivers.Name = "chxAdditionalDrivers"
        Me.chxAdditionalDrivers.Size = New System.Drawing.Size(237, 24)
        Me.chxAdditionalDrivers.TabIndex = 21
        Me.chxAdditionalDrivers.Text = "Additional Drivers (€7 per Day)"
        Me.chxAdditionalDrivers.UseVisualStyleBackColor = True
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblInsurance.Location = New System.Drawing.Point(3, 4)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(127, 35)
        Me.lblInsurance.TabIndex = 22
        Me.lblInsurance.Text = "Insurance:"
        '
        'gpxCollisionWaiver
        '
        Me.gpxCollisionWaiver.Controls.Add(Me.GroupBox2)
        Me.gpxCollisionWaiver.Controls.Add(Me.radNoToCollision)
        Me.gpxCollisionWaiver.Controls.Add(Me.radYestoCollision)
        Me.gpxCollisionWaiver.Location = New System.Drawing.Point(57, 92)
        Me.gpxCollisionWaiver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxCollisionWaiver.Name = "gpxCollisionWaiver"
        Me.gpxCollisionWaiver.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxCollisionWaiver.Size = New System.Drawing.Size(150, 54)
        Me.gpxCollisionWaiver.TabIndex = 23
        Me.gpxCollisionWaiver.TabStop = False
        Me.gpxCollisionWaiver.Text = "Collision Waiver"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radNoToTheft)
        Me.GroupBox2.Controls.Add(Me.radYesToTheft)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 61)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(131, 73)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'gpxTheft
        '
        Me.gpxTheft.Controls.Add(Me.rdYesToTheft)
        Me.gpxTheft.Controls.Add(Me.rdNoToTheft)
        Me.gpxTheft.Location = New System.Drawing.Point(57, 182)
        Me.gpxTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxTheft.Name = "gpxTheft"
        Me.gpxTheft.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxTheft.Size = New System.Drawing.Size(150, 56)
        Me.gpxTheft.TabIndex = 24
        Me.gpxTheft.TabStop = False
        Me.gpxTheft.Text = "Theft"
        '
        'rdYesToTheft
        '
        Me.rdYesToTheft.AutoSize = True
        Me.rdYesToTheft.Location = New System.Drawing.Point(6, 20)
        Me.rdYesToTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdYesToTheft.Name = "rdYesToTheft"
        Me.rdYesToTheft.Size = New System.Drawing.Size(51, 24)
        Me.rdYesToTheft.TabIndex = 1
        Me.rdYesToTheft.TabStop = True
        Me.rdYesToTheft.Text = "Yes"
        Me.rdYesToTheft.UseVisualStyleBackColor = True
        '
        'rdNoToTheft
        '
        Me.rdNoToTheft.AutoSize = True
        Me.rdNoToTheft.Location = New System.Drawing.Point(90, 19)
        Me.rdNoToTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdNoToTheft.Name = "rdNoToTheft"
        Me.rdNoToTheft.Size = New System.Drawing.Size(50, 24)
        Me.rdNoToTheft.TabIndex = 0
        Me.rdNoToTheft.TabStop = True
        Me.rdNoToTheft.Text = "No"
        Me.rdNoToTheft.UseVisualStyleBackColor = True
        '
        'gpxVehicleContents
        '
        Me.gpxVehicleContents.Controls.Add(Me.radNoToVehicleContents)
        Me.gpxVehicleContents.Controls.Add(Me.radYesToVehiclesContents)
        Me.gpxVehicleContents.Location = New System.Drawing.Point(57, 282)
        Me.gpxVehicleContents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVehicleContents.Name = "gpxVehicleContents"
        Me.gpxVehicleContents.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVehicleContents.Size = New System.Drawing.Size(150, 56)
        Me.gpxVehicleContents.TabIndex = 25
        Me.gpxVehicleContents.TabStop = False
        Me.gpxVehicleContents.Text = "Vehicle Contents"
        '
        'gpxCarExtras
        '
        Me.gpxCarExtras.Controls.Add(Me.chxChildSeat)
        Me.gpxCarExtras.Controls.Add(Me.chxSkiEquip)
        Me.gpxCarExtras.Controls.Add(Me.chxRoofMountedLuggage)
        Me.gpxCarExtras.Controls.Add(Me.chxAdditionalDrivers)
        Me.gpxCarExtras.Location = New System.Drawing.Point(16, 75)
        Me.gpxCarExtras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxCarExtras.Name = "gpxCarExtras"
        Me.gpxCarExtras.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxCarExtras.Size = New System.Drawing.Size(273, 203)
        Me.gpxCarExtras.TabIndex = 26
        Me.gpxCarExtras.TabStop = False
        Me.gpxCarExtras.Text = "Car Extras"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(3, 180)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(34, 20)
        Me.lblTax.TabIndex = 27
        Me.lblTax.Text = "VAT"
        '
        'btnCalculateQuote
        '
        Me.btnCalculateQuote.BackColor = System.Drawing.Color.Azure
        Me.btnCalculateQuote.Location = New System.Drawing.Point(0, 70)
        Me.btnCalculateQuote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculateQuote.Name = "btnCalculateQuote"
        Me.btnCalculateQuote.Size = New System.Drawing.Size(529, 42)
        Me.btnCalculateQuote.TabIndex = 28
        Me.btnCalculateQuote.Text = "Calculate"
        Me.btnCalculateQuote.UseVisualStyleBackColor = False
        '
        'lblNoOfDaysRent
        '
        Me.lblNoOfDaysRent.AutoSize = True
        Me.lblNoOfDaysRent.Location = New System.Drawing.Point(20, 353)
        Me.lblNoOfDaysRent.Name = "lblNoOfDaysRent"
        Me.lblNoOfDaysRent.Size = New System.Drawing.Size(172, 20)
        Me.lblNoOfDaysRent.TabIndex = 29
        Me.lblNoOfDaysRent.Text = "Number of Days to Rent:"
        '
        'msxDaysOfRent
        '
        Me.msxDaysOfRent.Location = New System.Drawing.Point(222, 350)
        Me.msxDaysOfRent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxDaysOfRent.Mask = "0"
        Me.msxDaysOfRent.Name = "msxDaysOfRent"
        Me.msxDaysOfRent.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msxDaysOfRent.Size = New System.Drawing.Size(47, 27)
        Me.msxDaysOfRent.TabIndex = 30
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(199, 177)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(267, 27)
        Me.txtVAT.TabIndex = 31
        '
        'txtPriceBeforeTax
        '
        Me.txtPriceBeforeTax.Location = New System.Drawing.Point(199, 125)
        Me.txtPriceBeforeTax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceBeforeTax.Name = "txtPriceBeforeTax"
        Me.txtPriceBeforeTax.ReadOnly = True
        Me.txtPriceBeforeTax.Size = New System.Drawing.Size(267, 27)
        Me.txtPriceBeforeTax.TabIndex = 32
        '
        'lblPriceBeforeTax
        '
        Me.lblPriceBeforeTax.AutoSize = True
        Me.lblPriceBeforeTax.Location = New System.Drawing.Point(3, 128)
        Me.lblPriceBeforeTax.Name = "lblPriceBeforeTax"
        Me.lblPriceBeforeTax.Size = New System.Drawing.Size(117, 20)
        Me.lblPriceBeforeTax.TabIndex = 33
        Me.lblPriceBeforeTax.Text = "Price Before Tax:"
        '
        'lblPleaseSelectCar
        '
        Me.lblPleaseSelectCar.AutoSize = True
        Me.lblPleaseSelectCar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblPleaseSelectCar.Location = New System.Drawing.Point(11, 4)
        Me.lblPleaseSelectCar.Name = "lblPleaseSelectCar"
        Me.lblPleaseSelectCar.Size = New System.Drawing.Size(226, 35)
        Me.lblPleaseSelectCar.TabIndex = 34
        Me.lblPleaseSelectCar.Text = "Please Select a Car:"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(478, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 38)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'GpcCarPrices
        '
        Me.GpcCarPrices.Controls.Add(Me.lblOpelZaifraFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelZaifraWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelZaifraDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblFordFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblFordWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblFordDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblRenaultFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblRenaultWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblRenaultDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblVFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblVWWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblVwDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblFortnightRate)
        Me.GpcCarPrices.Controls.Add(Me.lblWeekRate)
        Me.GpcCarPrices.Controls.Add(Me.lblDayRate)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelZaifra)
        Me.GpcCarPrices.Controls.Add(Me.lblFordMondeo)
        Me.GpcCarPrices.Controls.Add(Me.lblRenaultMegane)
        Me.GpcCarPrices.Controls.Add(Me.lblOpelCorsa)
        Me.GpcCarPrices.Controls.Add(Me.lblVWPolo)
        Me.GpcCarPrices.Location = New System.Drawing.Point(14, 59)
        Me.GpcCarPrices.Name = "GpcCarPrices"
        Me.GpcCarPrices.Size = New System.Drawing.Size(504, 194)
        Me.GpcCarPrices.TabIndex = 36
        Me.GpcCarPrices.TabStop = False
        Me.GpcCarPrices.Text = "Car Prices"
        '
        'lblOpelZaifraFortnightRate
        '
        Me.lblOpelZaifraFortnightRate.AutoSize = True
        Me.lblOpelZaifraFortnightRate.Location = New System.Drawing.Point(374, 163)
        Me.lblOpelZaifraFortnightRate.Name = "lblOpelZaifraFortnightRate"
        Me.lblOpelZaifraFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelZaifraFortnightRate.TabIndex = 22
        Me.lblOpelZaifraFortnightRate.Text = " €755.92"
        '
        'lblOpelZaifraWeekRate
        '
        Me.lblOpelZaifraWeekRate.AutoSize = True
        Me.lblOpelZaifraWeekRate.Location = New System.Drawing.Point(276, 163)
        Me.lblOpelZaifraWeekRate.Name = "lblOpelZaifraWeekRate"
        Me.lblOpelZaifraWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelZaifraWeekRate.TabIndex = 21
        Me.lblOpelZaifraWeekRate.Text = " €397.85"
        '
        'lblOpelZaifraDayRate
        '
        Me.lblOpelZaifraDayRate.AutoSize = True
        Me.lblOpelZaifraDayRate.Location = New System.Drawing.Point(180, 163)
        Me.lblOpelZaifraDayRate.Name = "lblOpelZaifraDayRate"
        Me.lblOpelZaifraDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblOpelZaifraDayRate.TabIndex = 20
        Me.lblOpelZaifraDayRate.Text = " €63.15"
        '
        'lblFordFortnightRate
        '
        Me.lblFordFortnightRate.AutoSize = True
        Me.lblFordFortnightRate.Location = New System.Drawing.Point(374, 135)
        Me.lblFordFortnightRate.Name = "lblFordFortnightRate"
        Me.lblFordFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordFortnightRate.TabIndex = 19
        Me.lblFordFortnightRate.Text = " €661.95"
        '
        'lblFordWeekRate
        '
        Me.lblFordWeekRate.AutoSize = True
        Me.lblFordWeekRate.Location = New System.Drawing.Point(276, 135)
        Me.lblFordWeekRate.Name = "lblFordWeekRate"
        Me.lblFordWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordWeekRate.TabIndex = 18
        Me.lblFordWeekRate.Text = " €348.39"
        '
        'lblFordDayRate
        '
        Me.lblFordDayRate.AutoSize = True
        Me.lblFordDayRate.Location = New System.Drawing.Point(180, 135)
        Me.lblFordDayRate.Name = "lblFordDayRate"
        Me.lblFordDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblFordDayRate.TabIndex = 17
        Me.lblFordDayRate.Text = " €55.30"
        '
        'lblRenaultFortnightRate
        '
        Me.lblRenaultFortnightRate.AutoSize = True
        Me.lblRenaultFortnightRate.Location = New System.Drawing.Point(374, 101)
        Me.lblRenaultFortnightRate.Name = "lblRenaultFortnightRate"
        Me.lblRenaultFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblRenaultFortnightRate.TabIndex = 16
        Me.lblRenaultFortnightRate.Text = " €594.91"
        '
        'lblRenaultWeekRate
        '
        Me.lblRenaultWeekRate.AutoSize = True
        Me.lblRenaultWeekRate.Location = New System.Drawing.Point(276, 101)
        Me.lblRenaultWeekRate.Name = "lblRenaultWeekRate"
        Me.lblRenaultWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblRenaultWeekRate.TabIndex = 15
        Me.lblRenaultWeekRate.Text = " €313.11"
        '
        'lblRenaultDayRate
        '
        Me.lblRenaultDayRate.AutoSize = True
        Me.lblRenaultDayRate.Location = New System.Drawing.Point(180, 101)
        Me.lblRenaultDayRate.Name = "lblRenaultDayRate"
        Me.lblRenaultDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblRenaultDayRate.TabIndex = 14
        Me.lblRenaultDayRate.Text = " €49.70"
        '
        'lblOpelFortnightRate
        '
        Me.lblOpelFortnightRate.AutoSize = True
        Me.lblOpelFortnightRate.Location = New System.Drawing.Point(374, 67)
        Me.lblOpelFortnightRate.Name = "lblOpelFortnightRate"
        Me.lblOpelFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelFortnightRate.TabIndex = 13
        Me.lblOpelFortnightRate.Text = " €517.70"
        '
        'lblOpelWeekRate
        '
        Me.lblOpelWeekRate.AutoSize = True
        Me.lblOpelWeekRate.Location = New System.Drawing.Point(276, 67)
        Me.lblOpelWeekRate.Name = "lblOpelWeekRate"
        Me.lblOpelWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelWeekRate.TabIndex = 12
        Me.lblOpelWeekRate.Text = " €272.48"
        '
        'lblOpelDayRate
        '
        Me.lblOpelDayRate.AutoSize = True
        Me.lblOpelDayRate.Location = New System.Drawing.Point(180, 67)
        Me.lblOpelDayRate.Name = "lblOpelDayRate"
        Me.lblOpelDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblOpelDayRate.TabIndex = 11
        Me.lblOpelDayRate.Text = " €43.25"
        '
        'lblVFortnightRate
        '
        Me.lblVFortnightRate.AutoSize = True
        Me.lblVFortnightRate.Location = New System.Drawing.Point(374, 33)
        Me.lblVFortnightRate.Name = "lblVFortnightRate"
        Me.lblVFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblVFortnightRate.TabIndex = 10
        Me.lblVFortnightRate.Text = " €448.90"
        '
        'lblVWWeekRate
        '
        Me.lblVWWeekRate.AutoSize = True
        Me.lblVWWeekRate.Location = New System.Drawing.Point(276, 33)
        Me.lblVWWeekRate.Name = "lblVWWeekRate"
        Me.lblVWWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblVWWeekRate.TabIndex = 9
        Me.lblVWWeekRate.Text = " €236.25"
        '
        'lblVwDayRate
        '
        Me.lblVwDayRate.AutoSize = True
        Me.lblVwDayRate.Location = New System.Drawing.Point(180, 33)
        Me.lblVwDayRate.Name = "lblVwDayRate"
        Me.lblVwDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblVwDayRate.TabIndex = 8
        Me.lblVwDayRate.Text = " €37.50"
        '
        'lblFortnightRate
        '
        Me.lblFortnightRate.AutoSize = True
        Me.lblFortnightRate.Location = New System.Drawing.Point(374, 14)
        Me.lblFortnightRate.Name = "lblFortnightRate"
        Me.lblFortnightRate.Size = New System.Drawing.Size(114, 20)
        Me.lblFortnightRate.TabIndex = 7
        Me.lblFortnightRate.Text = "Fortnightly Rate"
        '
        'lblWeekRate
        '
        Me.lblWeekRate.AutoSize = True
        Me.lblWeekRate.Location = New System.Drawing.Point(276, 14)
        Me.lblWeekRate.Name = "lblWeekRate"
        Me.lblWeekRate.Size = New System.Drawing.Size(90, 20)
        Me.lblWeekRate.TabIndex = 6
        Me.lblWeekRate.Text = "Weekly Rate"
        '
        'lblDayRate
        '
        Me.lblDayRate.AutoSize = True
        Me.lblDayRate.Location = New System.Drawing.Point(180, 13)
        Me.lblDayRate.Name = "lblDayRate"
        Me.lblDayRate.Size = New System.Drawing.Size(69, 20)
        Me.lblDayRate.TabIndex = 5
        Me.lblDayRate.Text = "Day Rate"
        '
        'lblOpelZaifra
        '
        Me.lblOpelZaifra.AutoSize = True
        Me.lblOpelZaifra.Location = New System.Drawing.Point(6, 163)
        Me.lblOpelZaifra.Name = "lblOpelZaifra"
        Me.lblOpelZaifra.Size = New System.Drawing.Size(179, 25)
        Me.lblOpelZaifra.TabIndex = 4
        Me.lblOpelZaifra.Text = "Opel Zaifra 8 Seater 2.0ltr"
        Me.lblOpelZaifra.UseCompatibleTextRendering = True
        '
        'lblFordMondeo
        '
        Me.lblFordMondeo.AutoSize = True
        Me.lblFordMondeo.Location = New System.Drawing.Point(6, 135)
        Me.lblFordMondeo.Name = "lblFordMondeo"
        Me.lblFordMondeo.Size = New System.Drawing.Size(136, 20)
        Me.lblFordMondeo.TabIndex = 3
        Me.lblFordMondeo.Text = "Ford Mondeo 1.6ltr"
        Me.lblFordMondeo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRenaultMegane
        '
        Me.lblRenaultMegane.AutoSize = True
        Me.lblRenaultMegane.Location = New System.Drawing.Point(6, 101)
        Me.lblRenaultMegane.Name = "lblRenaultMegane"
        Me.lblRenaultMegane.Size = New System.Drawing.Size(154, 20)
        Me.lblRenaultMegane.TabIndex = 2
        Me.lblRenaultMegane.Text = "Renault Megane 1.4ltr"
        '
        'lblOpelCorsa
        '
        Me.lblOpelCorsa.AutoSize = True
        Me.lblOpelCorsa.Location = New System.Drawing.Point(6, 67)
        Me.lblOpelCorsa.Name = "lblOpelCorsa"
        Me.lblOpelCorsa.Size = New System.Drawing.Size(119, 20)
        Me.lblOpelCorsa.TabIndex = 1
        Me.lblOpelCorsa.Text = "Opel Corsa 1.2ltr"
        '
        'lblVWPolo
        '
        Me.lblVWPolo.AutoSize = True
        Me.lblVWPolo.Location = New System.Drawing.Point(6, 33)
        Me.lblVWPolo.Name = "lblVWPolo"
        Me.lblVWPolo.Size = New System.Drawing.Size(91, 20)
        Me.lblVWPolo.TabIndex = 0
        Me.lblVWPolo.Text = "VW Polo 1ltr"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(291, 0)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 38)
        Me.btnClear.TabIndex = 37
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.gpxCollisionWaiver)
        Me.Panel1.Controls.Add(Me.gpxTheft)
        Me.Panel1.Controls.Add(Me.gpxVehicleContents)
        Me.Panel1.Location = New System.Drawing.Point(552, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 396)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.lblInsurance)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 52)
        Me.Panel2.TabIndex = 39
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnClose)
        Me.pnlOptions.Controls.Add(Me.btnClear)
        Me.pnlOptions.Controls.Add(Me.btnNext)
        Me.pnlOptions.Location = New System.Drawing.Point(150, 1)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(765, 38)
        Me.pnlOptions.TabIndex = 39
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(649, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 38)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Location = New System.Drawing.Point(-2, 1)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(156, 97)
        Me.pbxLogo.TabIndex = 40
        Me.pbxLogo.TabStop = False
        '
        'pnlCarSelect
        '
        Me.pnlCarSelect.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlCarSelect.Controls.Add(Me.Panel5)
        Me.pnlCarSelect.Controls.Add(Me.GpcCarPrices)
        Me.pnlCarSelect.Controls.Add(Me.cbxCarType)
        Me.pnlCarSelect.Controls.Add(Me.lblSelectCarType)
        Me.pnlCarSelect.Controls.Add(Me.msxWeeksOfRent)
        Me.pnlCarSelect.Controls.Add(Me.lblNumberOfWeeksRent)
        Me.pnlCarSelect.Controls.Add(Me.msxDaysOfRent)
        Me.pnlCarSelect.Controls.Add(Me.lblNoOfDaysRent)
        Me.pnlCarSelect.Location = New System.Drawing.Point(-2, 107)
        Me.pnlCarSelect.Name = "pnlCarSelect"
        Me.pnlCarSelect.Size = New System.Drawing.Size(531, 396)
        Me.pnlCarSelect.TabIndex = 41
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Azure
        Me.Panel5.Controls.Add(Me.lblPleaseSelectCar)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(531, 52)
        Me.Panel5.TabIndex = 42
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel6.Controls.Add(Me.gpxCarExtras)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(9, 512)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(357, 320)
        Me.Panel6.TabIndex = 42
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Azure
        Me.Panel7.Controls.Add(Me.lblExtrasForCar)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(357, 55)
        Me.Panel7.TabIndex = 43
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.txtQuotedPrice)
        Me.Panel8.Controls.Add(Me.txtVAT)
        Me.Panel8.Controls.Add(Me.txtPriceBeforeTax)
        Me.Panel8.Controls.Add(Me.lblPriceQuote)
        Me.Panel8.Controls.Add(Me.lblTax)
        Me.Panel8.Controls.Add(Me.lblPriceBeforeTax)
        Me.Panel8.Controls.Add(Me.btnCalculateQuote)
        Me.Panel8.Location = New System.Drawing.Point(386, 512)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(549, 320)
        Me.Panel8.TabIndex = 44
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Azure
        Me.Panel9.Controls.Add(Me.lblQuotePrice)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(529, 55)
        Me.Panel9.TabIndex = 34
        '
        'lblQuotePrice
        '
        Me.lblQuotePrice.AutoSize = True
        Me.lblQuotePrice.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblQuotePrice.Location = New System.Drawing.Point(0, 10)
        Me.lblQuotePrice.Name = "lblQuotePrice"
        Me.lblQuotePrice.Size = New System.Drawing.Size(160, 35)
        Me.lblQuotePrice.TabIndex = 0
        Me.lblQuotePrice.Text = "Price Quote:"
        '
        'frmCarSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(914, 840)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.pnlCarSelect)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.pnlOptions)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCarSelect"
        Me.Text = "Car Select"
        Me.gpxCollisionWaiver.ResumeLayout(False)
        Me.gpxCollisionWaiver.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpxTheft.ResumeLayout(False)
        Me.gpxTheft.PerformLayout()
        Me.gpxVehicleContents.ResumeLayout(False)
        Me.gpxVehicleContents.PerformLayout()
        Me.gpxCarExtras.ResumeLayout(False)
        Me.gpxCarExtras.PerformLayout()
        Me.GpcCarPrices.ResumeLayout(False)
        Me.GpcCarPrices.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCarSelect.ResumeLayout(False)
        Me.pnlCarSelect.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxCarType As ComboBox
    Friend WithEvents lblSelectCarType As Label
    Friend WithEvents msxWeeksOfRent As MaskedTextBox
    Friend WithEvents lblNumberOfWeeksRent As Label
    Friend WithEvents lblExtrasForCar As Label
    Friend WithEvents radYestoCollision As RadioButton
    Friend WithEvents radNoToCollision As RadioButton
    Friend WithEvents radYesToTheft As RadioButton
    Friend WithEvents radNoToTheft As RadioButton
    Friend WithEvents radYesToVehiclesContents As RadioButton
    Friend WithEvents radNoToVehicleContents As RadioButton
    Friend WithEvents lblPriceQuote As Label
    Friend WithEvents txtQuotedPrice As TextBox
    Friend WithEvents chxChildSeat As CheckBox
    Friend WithEvents chxSkiEquip As CheckBox
    Friend WithEvents chxRoofMountedLuggage As CheckBox
    Friend WithEvents chxAdditionalDrivers As CheckBox
    Friend WithEvents lblInsurance As Label
    Friend WithEvents gpxCollisionWaiver As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gpxTheft As GroupBox
    Friend WithEvents rdYesToTheft As RadioButton
    Friend WithEvents rdNoToTheft As RadioButton
    Friend WithEvents gpxVehicleContents As GroupBox
    Friend WithEvents gpxCarExtras As GroupBox
    Friend WithEvents lblTax As Label
    Friend WithEvents btnCalculateQuote As Button
    Friend WithEvents lblNoOfDaysRent As Label
    Friend WithEvents msxDaysOfRent As MaskedTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtPriceBeforeTax As TextBox
    Friend WithEvents lblPriceBeforeTax As Label
    Friend WithEvents lblPleaseSelectCar As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents GpcCarPrices As GroupBox
    Friend WithEvents lblFortnightRate As Label
    Friend WithEvents lblWeekRate As Label
    Friend WithEvents lblDayRate As Label
    Friend WithEvents lblOpelZaifra As Label
    Friend WithEvents lblFordMondeo As Label
    Friend WithEvents lblRenaultMegane As Label
    Friend WithEvents lblOpelCorsa As Label
    Friend WithEvents lblVWPolo As Label
    Friend WithEvents lblOpelZaifraFortnightRate As Label
    Friend WithEvents lblOpelZaifraWeekRate As Label
    Friend WithEvents lblOpelZaifraDayRate As Label
    Friend WithEvents lblFordFortnightRate As Label
    Friend WithEvents lblFordWeekRate As Label
    Friend WithEvents lblFordDayRate As Label
    Friend WithEvents lblRenaultFortnightRate As Label
    Friend WithEvents lblRenaultWeekRate As Label
    Friend WithEvents lblRenaultDayRate As Label
    Friend WithEvents lblOpelFortnightRate As Label
    Friend WithEvents lblOpelWeekRate As Label
    Friend WithEvents lblOpelDayRate As Label
    Friend WithEvents lblVFortnightRate As Label
    Friend WithEvents lblVWWeekRate As Label
    Friend WithEvents lblVwDayRate As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlCarSelect As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblQuotePrice As Label
End Class
