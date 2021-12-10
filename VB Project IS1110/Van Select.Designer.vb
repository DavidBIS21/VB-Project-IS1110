<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVanSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVanSelect))
        Me.lblVanExtras = New System.Windows.Forms.Label()
        Me.gpxVanExtras = New System.Windows.Forms.GroupBox()
        Me.chxVanAdditionalDrivers = New System.Windows.Forms.CheckBox()
        Me.chxNissan4x4RoofMountedLuggage = New System.Windows.Forms.CheckBox()
        Me.chxNissan4x4SkiEquip = New System.Windows.Forms.CheckBox()
        Me.lblVanInsurance = New System.Windows.Forms.Label()
        Me.gpxVanCollisionWaiver = New System.Windows.Forms.GroupBox()
        Me.radVanCollisionNo = New System.Windows.Forms.RadioButton()
        Me.radVanYesCollision = New System.Windows.Forms.RadioButton()
        Me.gpxVanTheft = New System.Windows.Forms.GroupBox()
        Me.radVanNoTheft = New System.Windows.Forms.RadioButton()
        Me.radVanYesTheft = New System.Windows.Forms.RadioButton()
        Me.gpxVanVehicleContents = New System.Windows.Forms.GroupBox()
        Me.radVanVehicleContentsNo = New System.Windows.Forms.RadioButton()
        Me.radVanVehicleContentsYes = New System.Windows.Forms.RadioButton()
        Me.txtVanBeforeTax = New System.Windows.Forms.TextBox()
        Me.txtVanVat = New System.Windows.Forms.TextBox()
        Me.txtQuotedPrice = New System.Windows.Forms.TextBox()
        Me.lblVanPriceBeforeVat = New System.Windows.Forms.Label()
        Me.lblVanVat = New System.Windows.Forms.Label()
        Me.lblVanTotal = New System.Windows.Forms.Label()
        Me.btnVanCalculate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.msxVanDaysOfRent = New System.Windows.Forms.MaskedTextBox()
        Me.lblNoOfDaysOfRent = New System.Windows.Forms.Label()
        Me.msxVanWeeksOfRent = New System.Windows.Forms.MaskedTextBox()
        Me.lblVanWeek = New System.Windows.Forms.Label()
        Me.lblVanType = New System.Windows.Forms.Label()
        Me.cbxVanType = New System.Windows.Forms.ComboBox()
        Me.gpxVanPrices = New System.Windows.Forms.GroupBox()
        Me.lblNissanFortnightRate = New System.Windows.Forms.Label()
        Me.lblNissanWeekRate = New System.Windows.Forms.Label()
        Me.lblNissanDayRate = New System.Windows.Forms.Label()
        Me.lblMercedesFortnightRate = New System.Windows.Forms.Label()
        Me.lblMercedesWeekRate = New System.Windows.Forms.Label()
        Me.lblMercedesDayRate = New System.Windows.Forms.Label()
        Me.lblFordBusFortnightRate = New System.Windows.Forms.Label()
        Me.lblFordBusWeekRate = New System.Windows.Forms.Label()
        Me.lblFordBusDayRate = New System.Windows.Forms.Label()
        Me.lblFordFortnightRate = New System.Windows.Forms.Label()
        Me.lblFordWeekRate = New System.Windows.Forms.Label()
        Me.lblFordDayRate = New System.Windows.Forms.Label()
        Me.lblToyotaFortnightRate = New System.Windows.Forms.Label()
        Me.lblToyotaWeekRate = New System.Windows.Forms.Label()
        Me.lblToyotaDayRate = New System.Windows.Forms.Label()
        Me.lblOpelFortnightRate = New System.Windows.Forms.Label()
        Me.lblOpelWeekRate = New System.Windows.Forms.Label()
        Me.lblOpelDayRate = New System.Windows.Forms.Label()
        Me.lblFortnightRate = New System.Windows.Forms.Label()
        Me.lblWeekRate = New System.Windows.Forms.Label()
        Me.LblDayRate = New System.Windows.Forms.Label()
        Me.lblNissanPatrol4x4 = New System.Windows.Forms.Label()
        Me.lblMercedesRunner = New System.Windows.Forms.Label()
        Me.lblFordTransitMiniBus = New System.Windows.Forms.Label()
        Me.lblFordTransit = New System.Windows.Forms.Label()
        Me.lblToyotaHiace = New System.Windows.Forms.Label()
        Me.lblOpelCorsa = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblVanChoose = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblQuotePrice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gpxVanExtras.SuspendLayout()
        Me.gpxVanCollisionWaiver.SuspendLayout()
        Me.gpxVanTheft.SuspendLayout()
        Me.gpxVanVehicleContents.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.gpxVanPrices.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVanExtras
        '
        Me.lblVanExtras.AutoSize = True
        Me.lblVanExtras.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblVanExtras.Location = New System.Drawing.Point(14, 15)
        Me.lblVanExtras.Name = "lblVanExtras"
        Me.lblVanExtras.Size = New System.Drawing.Size(133, 35)
        Me.lblVanExtras.TabIndex = 4
        Me.lblVanExtras.Text = "Van Extras:"
        '
        'gpxVanExtras
        '
        Me.gpxVanExtras.Controls.Add(Me.chxVanAdditionalDrivers)
        Me.gpxVanExtras.Controls.Add(Me.chxNissan4x4RoofMountedLuggage)
        Me.gpxVanExtras.Controls.Add(Me.chxNissan4x4SkiEquip)
        Me.gpxVanExtras.Location = New System.Drawing.Point(16, 82)
        Me.gpxVanExtras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanExtras.Name = "gpxVanExtras"
        Me.gpxVanExtras.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanExtras.Size = New System.Drawing.Size(372, 175)
        Me.gpxVanExtras.TabIndex = 5
        Me.gpxVanExtras.TabStop = False
        Me.gpxVanExtras.Text = "Van Extras "
        '
        'chxVanAdditionalDrivers
        '
        Me.chxVanAdditionalDrivers.AutoSize = True
        Me.chxVanAdditionalDrivers.Location = New System.Drawing.Point(39, 141)
        Me.chxVanAdditionalDrivers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxVanAdditionalDrivers.Name = "chxVanAdditionalDrivers"
        Me.chxVanAdditionalDrivers.Size = New System.Drawing.Size(237, 24)
        Me.chxVanAdditionalDrivers.TabIndex = 2
        Me.chxVanAdditionalDrivers.Text = "Additional Drivers (€7 per Day)"
        Me.chxVanAdditionalDrivers.UseVisualStyleBackColor = True
        '
        'chxNissan4x4RoofMountedLuggage
        '
        Me.chxNissan4x4RoofMountedLuggage.AutoSize = True
        Me.chxNissan4x4RoofMountedLuggage.Location = New System.Drawing.Point(39, 93)
        Me.chxNissan4x4RoofMountedLuggage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxNissan4x4RoofMountedLuggage.Name = "chxNissan4x4RoofMountedLuggage"
        Me.chxNissan4x4RoofMountedLuggage.Size = New System.Drawing.Size(328, 24)
        Me.chxNissan4x4RoofMountedLuggage.TabIndex = 1
        Me.chxNissan4x4RoofMountedLuggage.Text = "Roof Mounted Luggage for Nissan 4x4  (€44)"
        Me.chxNissan4x4RoofMountedLuggage.UseVisualStyleBackColor = True
        '
        'chxNissan4x4SkiEquip
        '
        Me.chxNissan4x4SkiEquip.AutoSize = True
        Me.chxNissan4x4SkiEquip.Location = New System.Drawing.Point(39, 45)
        Me.chxNissan4x4SkiEquip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chxNissan4x4SkiEquip.Name = "chxNissan4x4SkiEquip"
        Me.chxNissan4x4SkiEquip.Size = New System.Drawing.Size(253, 24)
        Me.chxNissan4x4SkiEquip.TabIndex = 0
        Me.chxNissan4x4SkiEquip.Text = "Ski Equipped for Nissan 4x4 (€78)"
        Me.chxNissan4x4SkiEquip.UseVisualStyleBackColor = True
        '
        'lblVanInsurance
        '
        Me.lblVanInsurance.AutoSize = True
        Me.lblVanInsurance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblVanInsurance.Location = New System.Drawing.Point(3, 13)
        Me.lblVanInsurance.Name = "lblVanInsurance"
        Me.lblVanInsurance.Size = New System.Drawing.Size(127, 35)
        Me.lblVanInsurance.TabIndex = 6
        Me.lblVanInsurance.Text = "Insurance:"
        '
        'gpxVanCollisionWaiver
        '
        Me.gpxVanCollisionWaiver.Controls.Add(Me.radVanCollisionNo)
        Me.gpxVanCollisionWaiver.Controls.Add(Me.radVanYesCollision)
        Me.gpxVanCollisionWaiver.Location = New System.Drawing.Point(77, 115)
        Me.gpxVanCollisionWaiver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanCollisionWaiver.Name = "gpxVanCollisionWaiver"
        Me.gpxVanCollisionWaiver.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanCollisionWaiver.Size = New System.Drawing.Size(162, 64)
        Me.gpxVanCollisionWaiver.TabIndex = 7
        Me.gpxVanCollisionWaiver.TabStop = False
        Me.gpxVanCollisionWaiver.Text = "Collision Waiver"
        '
        'radVanCollisionNo
        '
        Me.radVanCollisionNo.AutoSize = True
        Me.radVanCollisionNo.Location = New System.Drawing.Point(81, 29)
        Me.radVanCollisionNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanCollisionNo.Name = "radVanCollisionNo"
        Me.radVanCollisionNo.Size = New System.Drawing.Size(50, 24)
        Me.radVanCollisionNo.TabIndex = 1
        Me.radVanCollisionNo.TabStop = True
        Me.radVanCollisionNo.Text = "No"
        Me.radVanCollisionNo.UseVisualStyleBackColor = True
        '
        'radVanYesCollision
        '
        Me.radVanYesCollision.AutoSize = True
        Me.radVanYesCollision.Location = New System.Drawing.Point(10, 31)
        Me.radVanYesCollision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanYesCollision.Name = "radVanYesCollision"
        Me.radVanYesCollision.Size = New System.Drawing.Size(51, 24)
        Me.radVanYesCollision.TabIndex = 0
        Me.radVanYesCollision.TabStop = True
        Me.radVanYesCollision.Text = "Yes"
        Me.radVanYesCollision.UseVisualStyleBackColor = True
        '
        'gpxVanTheft
        '
        Me.gpxVanTheft.Controls.Add(Me.radVanNoTheft)
        Me.gpxVanTheft.Controls.Add(Me.radVanYesTheft)
        Me.gpxVanTheft.Location = New System.Drawing.Point(77, 226)
        Me.gpxVanTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanTheft.Name = "gpxVanTheft"
        Me.gpxVanTheft.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanTheft.Size = New System.Drawing.Size(162, 61)
        Me.gpxVanTheft.TabIndex = 8
        Me.gpxVanTheft.TabStop = False
        Me.gpxVanTheft.Text = "Theft"
        '
        'radVanNoTheft
        '
        Me.radVanNoTheft.AutoSize = True
        Me.radVanNoTheft.Location = New System.Drawing.Point(81, 28)
        Me.radVanNoTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanNoTheft.Name = "radVanNoTheft"
        Me.radVanNoTheft.Size = New System.Drawing.Size(50, 24)
        Me.radVanNoTheft.TabIndex = 1
        Me.radVanNoTheft.TabStop = True
        Me.radVanNoTheft.Text = "No"
        Me.radVanNoTheft.UseVisualStyleBackColor = True
        '
        'radVanYesTheft
        '
        Me.radVanYesTheft.AutoSize = True
        Me.radVanYesTheft.Location = New System.Drawing.Point(15, 28)
        Me.radVanYesTheft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanYesTheft.Name = "radVanYesTheft"
        Me.radVanYesTheft.Size = New System.Drawing.Size(51, 24)
        Me.radVanYesTheft.TabIndex = 0
        Me.radVanYesTheft.TabStop = True
        Me.radVanYesTheft.Text = "Yes"
        Me.radVanYesTheft.UseVisualStyleBackColor = True
        '
        'gpxVanVehicleContents
        '
        Me.gpxVanVehicleContents.Controls.Add(Me.radVanVehicleContentsNo)
        Me.gpxVanVehicleContents.Controls.Add(Me.radVanVehicleContentsYes)
        Me.gpxVanVehicleContents.Location = New System.Drawing.Point(77, 326)
        Me.gpxVanVehicleContents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanVehicleContents.Name = "gpxVanVehicleContents"
        Me.gpxVanVehicleContents.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpxVanVehicleContents.Size = New System.Drawing.Size(162, 68)
        Me.gpxVanVehicleContents.TabIndex = 9
        Me.gpxVanVehicleContents.TabStop = False
        Me.gpxVanVehicleContents.Text = "Vehicle Contents "
        '
        'radVanVehicleContentsNo
        '
        Me.radVanVehicleContentsNo.AutoSize = True
        Me.radVanVehicleContentsNo.Location = New System.Drawing.Point(81, 29)
        Me.radVanVehicleContentsNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanVehicleContentsNo.Name = "radVanVehicleContentsNo"
        Me.radVanVehicleContentsNo.Size = New System.Drawing.Size(50, 24)
        Me.radVanVehicleContentsNo.TabIndex = 1
        Me.radVanVehicleContentsNo.TabStop = True
        Me.radVanVehicleContentsNo.Text = "No"
        Me.radVanVehicleContentsNo.UseVisualStyleBackColor = True
        '
        'radVanVehicleContentsYes
        '
        Me.radVanVehicleContentsYes.AutoSize = True
        Me.radVanVehicleContentsYes.Location = New System.Drawing.Point(10, 29)
        Me.radVanVehicleContentsYes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radVanVehicleContentsYes.Name = "radVanVehicleContentsYes"
        Me.radVanVehicleContentsYes.Size = New System.Drawing.Size(51, 24)
        Me.radVanVehicleContentsYes.TabIndex = 0
        Me.radVanVehicleContentsYes.TabStop = True
        Me.radVanVehicleContentsYes.Text = "Yes"
        Me.radVanVehicleContentsYes.UseVisualStyleBackColor = True
        '
        'txtVanBeforeTax
        '
        Me.txtVanBeforeTax.Location = New System.Drawing.Point(253, 155)
        Me.txtVanBeforeTax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVanBeforeTax.Name = "txtVanBeforeTax"
        Me.txtVanBeforeTax.ReadOnly = True
        Me.txtVanBeforeTax.Size = New System.Drawing.Size(227, 27)
        Me.txtVanBeforeTax.TabIndex = 10
        '
        'txtVanVat
        '
        Me.txtVanVat.Location = New System.Drawing.Point(253, 201)
        Me.txtVanVat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVanVat.Name = "txtVanVat"
        Me.txtVanVat.ReadOnly = True
        Me.txtVanVat.Size = New System.Drawing.Size(229, 27)
        Me.txtVanVat.TabIndex = 11
        '
        'txtQuotedPrice
        '
        Me.txtQuotedPrice.Location = New System.Drawing.Point(253, 248)
        Me.txtQuotedPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuotedPrice.Name = "txtQuotedPrice"
        Me.txtQuotedPrice.ReadOnly = True
        Me.txtQuotedPrice.Size = New System.Drawing.Size(229, 27)
        Me.txtQuotedPrice.TabIndex = 12
        '
        'lblVanPriceBeforeVat
        '
        Me.lblVanPriceBeforeVat.AutoSize = True
        Me.lblVanPriceBeforeVat.Location = New System.Drawing.Point(0, 158)
        Me.lblVanPriceBeforeVat.Name = "lblVanPriceBeforeVat"
        Me.lblVanPriceBeforeVat.Size = New System.Drawing.Size(117, 20)
        Me.lblVanPriceBeforeVat.TabIndex = 13
        Me.lblVanPriceBeforeVat.Text = "Price Before Vat:"
        '
        'lblVanVat
        '
        Me.lblVanVat.AutoSize = True
        Me.lblVanVat.Location = New System.Drawing.Point(3, 204)
        Me.lblVanVat.Name = "lblVanVat"
        Me.lblVanVat.Size = New System.Drawing.Size(37, 20)
        Me.lblVanVat.TabIndex = 14
        Me.lblVanVat.Text = "VAT:"
        '
        'lblVanTotal
        '
        Me.lblVanTotal.AutoSize = True
        Me.lblVanTotal.Location = New System.Drawing.Point(3, 251)
        Me.lblVanTotal.Name = "lblVanTotal"
        Me.lblVanTotal.Size = New System.Drawing.Size(139, 20)
        Me.lblVanTotal.TabIndex = 15
        Me.lblVanTotal.Text = "Total Including VAT:"
        '
        'btnVanCalculate
        '
        Me.btnVanCalculate.Location = New System.Drawing.Point(0, 82)
        Me.btnVanCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVanCalculate.Name = "btnVanCalculate"
        Me.btnVanCalculate.Size = New System.Drawing.Size(479, 46)
        Me.btnVanCalculate.TabIndex = 16
        Me.btnVanCalculate.Text = "Calculate"
        Me.btnVanCalculate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(318, 7)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(139, 42)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(521, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 42)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel3.Controls.Add(Me.gpxVanExtras)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 569)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(415, 310)
        Me.Panel3.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Controls.Add(Me.lblVanExtras)
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(413, 63)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel5.Controls.Add(Me.btnVanCalculate)
        Me.Panel5.Controls.Add(Me.txtVanBeforeTax)
        Me.Panel5.Controls.Add(Me.lblVanPriceBeforeVat)
        Me.Panel5.Controls.Add(Me.txtVanVat)
        Me.Panel5.Controls.Add(Me.lblVanVat)
        Me.Panel5.Controls.Add(Me.txtQuotedPrice)
        Me.Panel5.Controls.Add(Me.lblVanTotal)
        Me.Panel5.Location = New System.Drawing.Point(477, 569)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(482, 310)
        Me.Panel5.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.gpxVanCollisionWaiver)
        Me.Panel6.Controls.Add(Me.gpxVanTheft)
        Me.Panel6.Controls.Add(Me.gpxVanVehicleContents)
        Me.Panel6.Location = New System.Drawing.Point(630, 104)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(327, 459)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Azure
        Me.Panel7.Controls.Add(Me.lblVanInsurance)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(329, 63)
        Me.Panel7.TabIndex = 27
        '
        'msxVanDaysOfRent
        '
        Me.msxVanDaysOfRent.Location = New System.Drawing.Point(232, 418)
        Me.msxVanDaysOfRent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxVanDaysOfRent.Mask = "0"
        Me.msxVanDaysOfRent.Name = "msxVanDaysOfRent"
        Me.msxVanDaysOfRent.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msxVanDaysOfRent.Size = New System.Drawing.Size(49, 27)
        Me.msxVanDaysOfRent.TabIndex = 2
        '
        'lblNoOfDaysOfRent
        '
        Me.lblNoOfDaysOfRent.AutoSize = True
        Me.lblNoOfDaysOfRent.Location = New System.Drawing.Point(14, 421)
        Me.lblNoOfDaysOfRent.Name = "lblNoOfDaysOfRent"
        Me.lblNoOfDaysOfRent.Size = New System.Drawing.Size(181, 20)
        Me.lblNoOfDaysOfRent.TabIndex = 3
        Me.lblNoOfDaysOfRent.Text = "Number of Days for Rent: "
        '
        'msxVanWeeksOfRent
        '
        Me.msxVanWeeksOfRent.Location = New System.Drawing.Point(232, 374)
        Me.msxVanWeeksOfRent.Mask = "000"
        Me.msxVanWeeksOfRent.Name = "msxVanWeeksOfRent"
        Me.msxVanWeeksOfRent.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msxVanWeeksOfRent.Size = New System.Drawing.Size(49, 27)
        Me.msxVanWeeksOfRent.TabIndex = 18
        '
        'lblVanWeek
        '
        Me.lblVanWeek.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.lblVanWeek.AutoSize = True
        Me.lblVanWeek.Location = New System.Drawing.Point(14, 377)
        Me.lblVanWeek.Name = "lblVanWeek"
        Me.lblVanWeek.Size = New System.Drawing.Size(187, 20)
        Me.lblVanWeek.TabIndex = 19
        Me.lblVanWeek.Text = "Number of Weeks for Rent:"
        '
        'lblVanType
        '
        Me.lblVanType.AutoSize = True
        Me.lblVanType.Location = New System.Drawing.Point(14, 329)
        Me.lblVanType.Name = "lblVanType"
        Me.lblVanType.Size = New System.Drawing.Size(69, 20)
        Me.lblVanType.TabIndex = 1
        Me.lblVanType.Text = "Van type:"
        '
        'cbxVanType
        '
        Me.cbxVanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxVanType.FormattingEnabled = True
        Me.cbxVanType.Items.AddRange(New Object() {"Opel Corsa Van", "Toyota  Hiace", "Ford Transit", "Ford Transit Minibus (26 seater)", "Mercedes Runner", "Nissan Patrol 4X4"})
        Me.cbxVanType.Location = New System.Drawing.Point(232, 326)
        Me.cbxVanType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxVanType.Name = "cbxVanType"
        Me.cbxVanType.Size = New System.Drawing.Size(143, 28)
        Me.cbxVanType.TabIndex = 0
        '
        'gpxVanPrices
        '
        Me.gpxVanPrices.Controls.Add(Me.lblNissanFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblNissanWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblNissanDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblMercedesFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblMercedesWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblMercedesDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordBusFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordBusWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordBusDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFordDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblToyotaFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblToyotaWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblToyotaDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblOpelFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblOpelWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.lblOpelDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblFortnightRate)
        Me.gpxVanPrices.Controls.Add(Me.lblWeekRate)
        Me.gpxVanPrices.Controls.Add(Me.LblDayRate)
        Me.gpxVanPrices.Controls.Add(Me.lblNissanPatrol4x4)
        Me.gpxVanPrices.Controls.Add(Me.lblMercedesRunner)
        Me.gpxVanPrices.Controls.Add(Me.lblFordTransitMiniBus)
        Me.gpxVanPrices.Controls.Add(Me.lblFordTransit)
        Me.gpxVanPrices.Controls.Add(Me.lblToyotaHiace)
        Me.gpxVanPrices.Controls.Add(Me.lblOpelCorsa)
        Me.gpxVanPrices.Location = New System.Drawing.Point(3, 60)
        Me.gpxVanPrices.Name = "gpxVanPrices"
        Me.gpxVanPrices.Size = New System.Drawing.Size(564, 236)
        Me.gpxVanPrices.TabIndex = 21
        Me.gpxVanPrices.TabStop = False
        Me.gpxVanPrices.Text = "Van Prices"
        '
        'lblNissanFortnightRate
        '
        Me.lblNissanFortnightRate.AutoSize = True
        Me.lblNissanFortnightRate.Location = New System.Drawing.Point(436, 204)
        Me.lblNissanFortnightRate.Name = "lblNissanFortnightRate"
        Me.lblNissanFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblNissanFortnightRate.TabIndex = 26
        Me.lblNissanFortnightRate.Text = " €943.24"
        '
        'lblNissanWeekRate
        '
        Me.lblNissanWeekRate.AutoSize = True
        Me.lblNissanWeekRate.Location = New System.Drawing.Point(349, 204)
        Me.lblNissanWeekRate.Name = "lblNissanWeekRate"
        Me.lblNissanWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblNissanWeekRate.TabIndex = 25
        Me.lblNissanWeekRate.Text = " €496.44"
        '
        'lblNissanDayRate
        '
        Me.lblNissanDayRate.AutoSize = True
        Me.lblNissanDayRate.Location = New System.Drawing.Point(251, 204)
        Me.lblNissanDayRate.Name = "lblNissanDayRate"
        Me.lblNissanDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblNissanDayRate.TabIndex = 24
        Me.lblNissanDayRate.Text = " €78.80"
        '
        'lblMercedesFortnightRate
        '
        Me.lblMercedesFortnightRate.AutoSize = True
        Me.lblMercedesFortnightRate.Location = New System.Drawing.Point(436, 166)
        Me.lblMercedesFortnightRate.Name = "lblMercedesFortnightRate"
        Me.lblMercedesFortnightRate.Size = New System.Drawing.Size(72, 20)
        Me.lblMercedesFortnightRate.TabIndex = 23
        Me.lblMercedesFortnightRate.Text = " €1072.51"
        '
        'lblMercedesWeekRate
        '
        Me.lblMercedesWeekRate.AutoSize = True
        Me.lblMercedesWeekRate.Location = New System.Drawing.Point(349, 166)
        Me.lblMercedesWeekRate.Name = "lblMercedesWeekRate"
        Me.lblMercedesWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblMercedesWeekRate.TabIndex = 22
        Me.lblMercedesWeekRate.Text = " €564.48"
        '
        'lblMercedesDayRate
        '
        Me.lblMercedesDayRate.AutoSize = True
        Me.lblMercedesDayRate.Location = New System.Drawing.Point(251, 166)
        Me.lblMercedesDayRate.Name = "lblMercedesDayRate"
        Me.lblMercedesDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblMercedesDayRate.TabIndex = 21
        Me.lblMercedesDayRate.Text = " €89.60"
        '
        'lblFordBusFortnightRate
        '
        Me.lblFordBusFortnightRate.AutoSize = True
        Me.lblFordBusFortnightRate.Location = New System.Drawing.Point(436, 128)
        Me.lblFordBusFortnightRate.Name = "lblFordBusFortnightRate"
        Me.lblFordBusFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordBusFortnightRate.TabIndex = 20
        Me.lblFordBusFortnightRate.Text = " €824.73"
        '
        'lblFordBusWeekRate
        '
        Me.lblFordBusWeekRate.AutoSize = True
        Me.lblFordBusWeekRate.Location = New System.Drawing.Point(349, 128)
        Me.lblFordBusWeekRate.Name = "lblFordBusWeekRate"
        Me.lblFordBusWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordBusWeekRate.TabIndex = 19
        Me.lblFordBusWeekRate.Text = " €434.07"
        '
        'lblFordBusDayRate
        '
        Me.lblFordBusDayRate.AutoSize = True
        Me.lblFordBusDayRate.Location = New System.Drawing.Point(251, 128)
        Me.lblFordBusDayRate.Name = "lblFordBusDayRate"
        Me.lblFordBusDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblFordBusDayRate.TabIndex = 18
        Me.lblFordBusDayRate.Text = " €68.90"
        '
        'lblFordFortnightRate
        '
        Me.lblFordFortnightRate.AutoSize = True
        Me.lblFordFortnightRate.Location = New System.Drawing.Point(436, 99)
        Me.lblFordFortnightRate.Name = "lblFordFortnightRate"
        Me.lblFordFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordFortnightRate.TabIndex = 17
        Me.lblFordFortnightRate.Text = " €782.84"
        '
        'lblFordWeekRate
        '
        Me.lblFordWeekRate.AutoSize = True
        Me.lblFordWeekRate.Location = New System.Drawing.Point(349, 99)
        Me.lblFordWeekRate.Name = "lblFordWeekRate"
        Me.lblFordWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblFordWeekRate.TabIndex = 16
        Me.lblFordWeekRate.Text = " €412.02"
        '
        'lblFordDayRate
        '
        Me.lblFordDayRate.AutoSize = True
        Me.lblFordDayRate.Location = New System.Drawing.Point(251, 99)
        Me.lblFordDayRate.Name = "lblFordDayRate"
        Me.lblFordDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblFordDayRate.TabIndex = 15
        Me.lblFordDayRate.Text = " €65.40"
        '
        'lblToyotaFortnightRate
        '
        Me.lblToyotaFortnightRate.AutoSize = True
        Me.lblToyotaFortnightRate.Location = New System.Drawing.Point(436, 67)
        Me.lblToyotaFortnightRate.Name = "lblToyotaFortnightRate"
        Me.lblToyotaFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblToyotaFortnightRate.TabIndex = 14
        Me.lblToyotaFortnightRate.Text = " €477.60"
        '
        'lblToyotaWeekRate
        '
        Me.lblToyotaWeekRate.AutoSize = True
        Me.lblToyotaWeekRate.Location = New System.Drawing.Point(349, 67)
        Me.lblToyotaWeekRate.Name = "lblToyotaWeekRate"
        Me.lblToyotaWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblToyotaWeekRate.TabIndex = 13
        Me.lblToyotaWeekRate.Text = " €251.37"
        '
        'lblToyotaDayRate
        '
        Me.lblToyotaDayRate.AutoSize = True
        Me.lblToyotaDayRate.Location = New System.Drawing.Point(251, 67)
        Me.lblToyotaDayRate.Name = "lblToyotaDayRate"
        Me.lblToyotaDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblToyotaDayRate.TabIndex = 12
        Me.lblToyotaDayRate.Text = " €39.90"
        '
        'lblOpelFortnightRate
        '
        Me.lblOpelFortnightRate.AutoSize = True
        Me.lblOpelFortnightRate.Location = New System.Drawing.Point(436, 35)
        Me.lblOpelFortnightRate.Name = "lblOpelFortnightRate"
        Me.lblOpelFortnightRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelFortnightRate.TabIndex = 11
        Me.lblOpelFortnightRate.Text = " €420.15"
        '
        'lblOpelWeekRate
        '
        Me.lblOpelWeekRate.AutoSize = True
        Me.lblOpelWeekRate.Location = New System.Drawing.Point(349, 35)
        Me.lblOpelWeekRate.Name = "lblOpelWeekRate"
        Me.lblOpelWeekRate.Size = New System.Drawing.Size(64, 20)
        Me.lblOpelWeekRate.TabIndex = 10
        Me.lblOpelWeekRate.Text = " €221.13"
        '
        'lblOpelDayRate
        '
        Me.lblOpelDayRate.AutoSize = True
        Me.lblOpelDayRate.Location = New System.Drawing.Point(251, 35)
        Me.lblOpelDayRate.Name = "lblOpelDayRate"
        Me.lblOpelDayRate.Size = New System.Drawing.Size(56, 20)
        Me.lblOpelDayRate.TabIndex = 9
        Me.lblOpelDayRate.Text = " €35.10"
        '
        'lblFortnightRate
        '
        Me.lblFortnightRate.AutoSize = True
        Me.lblFortnightRate.Location = New System.Drawing.Point(436, 13)
        Me.lblFortnightRate.Name = "lblFortnightRate"
        Me.lblFortnightRate.Size = New System.Drawing.Size(114, 20)
        Me.lblFortnightRate.TabIndex = 8
        Me.lblFortnightRate.Text = "Fortnightly Rate"
        '
        'lblWeekRate
        '
        Me.lblWeekRate.AutoSize = True
        Me.lblWeekRate.Location = New System.Drawing.Point(340, 13)
        Me.lblWeekRate.Name = "lblWeekRate"
        Me.lblWeekRate.Size = New System.Drawing.Size(90, 20)
        Me.lblWeekRate.TabIndex = 7
        Me.lblWeekRate.Text = "Weekly Rate"
        '
        'LblDayRate
        '
        Me.LblDayRate.AutoSize = True
        Me.LblDayRate.Location = New System.Drawing.Point(251, 13)
        Me.LblDayRate.Name = "LblDayRate"
        Me.LblDayRate.Size = New System.Drawing.Size(69, 20)
        Me.LblDayRate.TabIndex = 6
        Me.LblDayRate.Text = "Day Rate"
        '
        'lblNissanPatrol4x4
        '
        Me.lblNissanPatrol4x4.AutoSize = True
        Me.lblNissanPatrol4x4.Location = New System.Drawing.Point(11, 204)
        Me.lblNissanPatrol4x4.Name = "lblNissanPatrol4x4"
        Me.lblNissanPatrol4x4.Size = New System.Drawing.Size(123, 20)
        Me.lblNissanPatrol4x4.TabIndex = 5
        Me.lblNissanPatrol4x4.Text = "Nissan Patrol 4X4"
        '
        'lblMercedesRunner
        '
        Me.lblMercedesRunner.AutoSize = True
        Me.lblMercedesRunner.Location = New System.Drawing.Point(11, 166)
        Me.lblMercedesRunner.Name = "lblMercedesRunner"
        Me.lblMercedesRunner.Size = New System.Drawing.Size(123, 20)
        Me.lblMercedesRunner.TabIndex = 4
        Me.lblMercedesRunner.Text = "Mercedes Runner"
        '
        'lblFordTransitMiniBus
        '
        Me.lblFordTransitMiniBus.AutoSize = True
        Me.lblFordTransitMiniBus.Location = New System.Drawing.Point(11, 128)
        Me.lblFordTransitMiniBus.Name = "lblFordTransitMiniBus"
        Me.lblFordTransitMiniBus.Size = New System.Drawing.Size(220, 20)
        Me.lblFordTransitMiniBus.TabIndex = 3
        Me.lblFordTransitMiniBus.Text = "Ford Transit mini Bus (26 seater)"
        '
        'lblFordTransit
        '
        Me.lblFordTransit.AutoSize = True
        Me.lblFordTransit.Location = New System.Drawing.Point(11, 99)
        Me.lblFordTransit.Name = "lblFordTransit"
        Me.lblFordTransit.Size = New System.Drawing.Size(86, 20)
        Me.lblFordTransit.TabIndex = 2
        Me.lblFordTransit.Text = "Ford Transit"
        '
        'lblToyotaHiace
        '
        Me.lblToyotaHiace.AutoSize = True
        Me.lblToyotaHiace.Location = New System.Drawing.Point(11, 67)
        Me.lblToyotaHiace.Name = "lblToyotaHiace"
        Me.lblToyotaHiace.Size = New System.Drawing.Size(96, 20)
        Me.lblToyotaHiace.TabIndex = 1
        Me.lblToyotaHiace.Text = "Toyota Hiace"
        '
        'lblOpelCorsa
        '
        Me.lblOpelCorsa.AutoSize = True
        Me.lblOpelCorsa.Location = New System.Drawing.Point(11, 35)
        Me.lblOpelCorsa.Name = "lblOpelCorsa"
        Me.lblOpelCorsa.Size = New System.Drawing.Size(110, 20)
        Me.lblOpelCorsa.TabIndex = 0
        Me.lblOpelCorsa.Text = "Opel Corsa Van"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.lblVanChoose)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 62)
        Me.Panel2.TabIndex = 24
        '
        'lblVanChoose
        '
        Me.lblVanChoose.AutoSize = True
        Me.lblVanChoose.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblVanChoose.Location = New System.Drawing.Point(17, 12)
        Me.lblVanChoose.Name = "lblVanChoose"
        Me.lblVanChoose.Size = New System.Drawing.Size(230, 35)
        Me.lblVanChoose.TabIndex = 17
        Me.lblVanChoose.Text = "Please Select a Van:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.gpxVanPrices)
        Me.Panel1.Controls.Add(Me.cbxVanType)
        Me.Panel1.Controls.Add(Me.lblVanType)
        Me.Panel1.Controls.Add(Me.lblVanWeek)
        Me.Panel1.Controls.Add(Me.msxVanWeeksOfRent)
        Me.Panel1.Controls.Add(Me.lblNoOfDaysOfRent)
        Me.Panel1.Controls.Add(Me.msxVanDaysOfRent)
        Me.Panel1.Location = New System.Drawing.Point(12, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 459)
        Me.Panel1.TabIndex = 23
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Azure
        Me.Panel8.Controls.Add(Me.lblQuotePrice)
        Me.Panel8.Location = New System.Drawing.Point(479, 569)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(477, 56)
        Me.Panel8.TabIndex = 17
        '
        'lblQuotePrice
        '
        Me.lblQuotePrice.AutoSize = True
        Me.lblQuotePrice.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblQuotePrice.Location = New System.Drawing.Point(3, 15)
        Me.lblQuotePrice.Name = "lblQuotePrice"
        Me.lblQuotePrice.Size = New System.Drawing.Size(160, 35)
        Me.lblQuotePrice.TabIndex = 0
        Me.lblQuotePrice.Text = "Price Quote:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 91)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnClose)
        Me.Panel9.Controls.Add(Me.btnClear)
        Me.Panel9.Controls.Add(Me.btnNext)
        Me.Panel9.Location = New System.Drawing.Point(133, -6)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(838, 52)
        Me.Panel9.TabIndex = 28
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(717, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 39)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmVanSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(971, 891)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVanSelect"
        Me.Text = "Van Selection"
        Me.gpxVanExtras.ResumeLayout(False)
        Me.gpxVanExtras.PerformLayout()
        Me.gpxVanCollisionWaiver.ResumeLayout(False)
        Me.gpxVanCollisionWaiver.PerformLayout()
        Me.gpxVanTheft.ResumeLayout(False)
        Me.gpxVanTheft.PerformLayout()
        Me.gpxVanVehicleContents.ResumeLayout(False)
        Me.gpxVanVehicleContents.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.gpxVanPrices.ResumeLayout(False)
        Me.gpxVanPrices.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblVanExtras As Label
    Friend WithEvents gpxVanExtras As GroupBox
    Friend WithEvents chxVanAdditionalDrivers As CheckBox
    Friend WithEvents chxNissan4x4RoofMountedLuggage As CheckBox
    Friend WithEvents chxNissan4x4SkiEquip As CheckBox
    Friend WithEvents lblVanInsurance As Label
    Friend WithEvents gpxVanCollisionWaiver As GroupBox
    Friend WithEvents radVanCollisionNo As RadioButton
    Friend WithEvents radVanYesCollision As RadioButton
    Friend WithEvents gpxVanTheft As GroupBox
    Friend WithEvents radVanNoTheft As RadioButton
    Friend WithEvents radVanYesTheft As RadioButton
    Friend WithEvents gpxVanVehicleContents As GroupBox
    Friend WithEvents radVanVehicleContentsYes As RadioButton
    Friend WithEvents radVanVehicleContentsNo As RadioButton
    Friend WithEvents txtVanBeforeTax As TextBox
    Friend WithEvents txtVanVat As TextBox
    Friend WithEvents txtQuotedPrice As TextBox
    Friend WithEvents lblVanPriceBeforeVat As Label
    Friend WithEvents lblVanVat As Label
    Friend WithEvents lblVanTotal As Label
    Friend WithEvents btnVanCalculate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblQuotePrice As Label
    Friend WithEvents msxVanDaysOfRent As MaskedTextBox
    Friend WithEvents lblNoOfDaysOfRent As Label
    Friend WithEvents msxVanWeeksOfRent As MaskedTextBox
    Friend WithEvents lblVanWeek As Label
    Friend WithEvents lblVanType As Label
    Friend WithEvents cbxVanType As ComboBox
    Friend WithEvents gpxVanPrices As GroupBox
    Friend WithEvents lblNissanFortnightRate As Label
    Friend WithEvents lblNissanWeekRate As Label
    Friend WithEvents lblNissanDayRate As Label
    Friend WithEvents lblMercedesFortnightRate As Label
    Friend WithEvents lblMercedesWeekRate As Label
    Friend WithEvents lblMercedesDayRate As Label
    Friend WithEvents lblFordBusFortnightRate As Label
    Friend WithEvents lblFordBusWeekRate As Label
    Friend WithEvents lblFordBusDayRate As Label
    Friend WithEvents lblFordFortnightRate As Label
    Friend WithEvents lblFordWeekRate As Label
    Friend WithEvents lblFordDayRate As Label
    Friend WithEvents lblToyotaFortnightRate As Label
    Friend WithEvents lblToyotaWeekRate As Label
    Friend WithEvents lblToyotaDayRate As Label
    Friend WithEvents lblOpelFortnightRate As Label
    Friend WithEvents lblOpelWeekRate As Label
    Friend WithEvents lblOpelDayRate As Label
    Friend WithEvents lblFortnightRate As Label
    Friend WithEvents lblWeekRate As Label
    Friend WithEvents LblDayRate As Label
    Friend WithEvents lblNissanPatrol4x4 As Label
    Friend WithEvents lblMercedesRunner As Label
    Friend WithEvents lblFordTransitMiniBus As Label
    Friend WithEvents lblFordTransit As Label
    Friend WithEvents lblToyotaHiace As Label
    Friend WithEvents lblOpelCorsa As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblVanChoose As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnClose As Button
End Class
