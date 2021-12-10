<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerDetails))
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.msxCustomerName = New System.Windows.Forms.MaskedTextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.msxPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.msxTownCity = New System.Windows.Forms.MaskedTextBox()
        Me.msxCounty = New System.Windows.Forms.MaskedTextBox()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.btnConfirmDetails = New System.Windows.Forms.Button()
        Me.msxStreetAddress = New System.Windows.Forms.MaskedTextBox()
        Me.msxPassportNumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnCustomerDetailsClear = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlCustomerDetails = New System.Windows.Forms.Panel()
        Me.pnlCustomer = New System.Windows.Forms.Panel()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        Me.pnlCustomerDetails.SuspendLayout()
        Me.pnlCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.BackColor = System.Drawing.Color.Azure
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(235, 16)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(223, 35)
        Me.lblCustomerDetails.TabIndex = 0
        Me.lblCustomerDetails.Text = "Customer Details:"
        '
        'msxCustomerName
        '
        Me.msxCustomerName.Location = New System.Drawing.Point(145, 115)
        Me.msxCustomerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxCustomerName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.msxCustomerName.Name = "msxCustomerName"
        Me.msxCustomerName.Size = New System.Drawing.Size(180, 30)
        Me.msxCustomerName.TabIndex = 1
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(3, 120)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(136, 20)
        Me.lblCustomerName.TabIndex = 2
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'msxPhoneNumber
        '
        Me.msxPhoneNumber.Location = New System.Drawing.Point(145, 171)
        Me.msxPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxPhoneNumber.Mask = "(999) 000-0000"
        Me.msxPhoneNumber.Name = "msxPhoneNumber"
        Me.msxPhoneNumber.Size = New System.Drawing.Size(180, 30)
        Me.msxPhoneNumber.TabIndex = 3
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(3, 174)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(125, 20)
        Me.lblPhoneNumber.TabIndex = 4
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassportNumber.Location = New System.Drawing.Point(370, 120)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(145, 20)
        Me.lblPassportNumber.TabIndex = 6
        Me.lblPassportNumber.Text = "Passport Number:"
        '
        'msxTownCity
        '
        Me.msxTownCity.Location = New System.Drawing.Point(533, 171)
        Me.msxTownCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxTownCity.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.msxTownCity.Name = "msxTownCity"
        Me.msxTownCity.Size = New System.Drawing.Size(180, 30)
        Me.msxTownCity.TabIndex = 8
        '
        'msxCounty
        '
        Me.msxCounty.Location = New System.Drawing.Point(533, 231)
        Me.msxCounty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxCounty.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.msxCounty.Name = "msxCounty"
        Me.msxCounty.Size = New System.Drawing.Size(180, 30)
        Me.msxCounty.TabIndex = 9
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStreetAddress.Location = New System.Drawing.Point(0, 234)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(126, 20)
        Me.lblStreetAddress.TabIndex = 10
        Me.lblStreetAddress.Text = "Street Address:"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTownCity.Location = New System.Drawing.Point(370, 174)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(88, 20)
        Me.lblTownCity.TabIndex = 11
        Me.lblTownCity.Text = "Town/City:"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCounty.Location = New System.Drawing.Point(370, 234)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(66, 20)
        Me.lblCounty.TabIndex = 12
        Me.lblCounty.Text = "County:"
        '
        'btnConfirmDetails
        '
        Me.btnConfirmDetails.BackColor = System.Drawing.Color.Lime
        Me.btnConfirmDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirmDetails.Location = New System.Drawing.Point(0, 316)
        Me.btnConfirmDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmDetails.Name = "btnConfirmDetails"
        Me.btnConfirmDetails.Size = New System.Drawing.Size(726, 59)
        Me.btnConfirmDetails.TabIndex = 13
        Me.btnConfirmDetails.Text = "Cofirm Details"
        Me.btnConfirmDetails.UseVisualStyleBackColor = False
        '
        'msxStreetAddress
        '
        Me.msxStreetAddress.Location = New System.Drawing.Point(145, 231)
        Me.msxStreetAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxStreetAddress.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
        Me.msxStreetAddress.Name = "msxStreetAddress"
        Me.msxStreetAddress.Size = New System.Drawing.Size(180, 30)
        Me.msxStreetAddress.TabIndex = 14
        '
        'msxPassportNumber
        '
        Me.msxPassportNumber.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.msxPassportNumber.Location = New System.Drawing.Point(533, 117)
        Me.msxPassportNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.msxPassportNumber.Mask = "CCCCCCCC"
        Me.msxPassportNumber.Name = "msxPassportNumber"
        Me.msxPassportNumber.Size = New System.Drawing.Size(180, 30)
        Me.msxPassportNumber.TabIndex = 15
        '
        'btnCustomerDetailsClear
        '
        Me.btnCustomerDetailsClear.BackColor = System.Drawing.Color.White
        Me.btnCustomerDetailsClear.Location = New System.Drawing.Point(555, 0)
        Me.btnCustomerDetailsClear.Name = "btnCustomerDetailsClear"
        Me.btnCustomerDetailsClear.Size = New System.Drawing.Size(173, 43)
        Me.btnCustomerDetailsClear.TabIndex = 16
        Me.btnCustomerDetailsClear.Text = "Clear"
        Me.btnCustomerDetailsClear.UseVisualStyleBackColor = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Location = New System.Drawing.Point(-2, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(189, 145)
        Me.pbxLogo.TabIndex = 17
        Me.pbxLogo.TabStop = False
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnClose)
        Me.pnlOptions.Controls.Add(Me.btnCustomerDetailsClear)
        Me.pnlOptions.Location = New System.Drawing.Point(183, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(731, 47)
        Me.pnlOptions.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(378, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(151, 43)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlCustomerDetails.Controls.Add(Me.pnlCustomer)
        Me.pnlCustomerDetails.Controls.Add(Me.msxStreetAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.msxTownCity)
        Me.pnlCustomerDetails.Controls.Add(Me.msxCounty)
        Me.pnlCustomerDetails.Controls.Add(Me.btnConfirmDetails)
        Me.pnlCustomerDetails.Controls.Add(Me.msxPassportNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.lblStreetAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.lblTownCity)
        Me.pnlCustomerDetails.Controls.Add(Me.lblPassportNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.lblCounty)
        Me.pnlCustomerDetails.Controls.Add(Me.msxPhoneNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.lblPhoneNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.msxCustomerName)
        Me.pnlCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.pnlCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(144, 172)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(726, 375)
        Me.pnlCustomerDetails.TabIndex = 19
        '
        'pnlCustomer
        '
        Me.pnlCustomer.BackColor = System.Drawing.Color.Azure
        Me.pnlCustomer.Controls.Add(Me.lblCustomerDetails)
        Me.pnlCustomer.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomer.Name = "pnlCustomer"
        Me.pnlCustomer.Size = New System.Drawing.Size(726, 69)
        Me.pnlCustomer.TabIndex = 16
        '
        'frmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.pnlCustomerDetails)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pbxLogo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCustomerDetails"
        Me.Text = "Customer Details"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.PerformLayout()
        Me.pnlCustomer.ResumeLayout(False)
        Me.pnlCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents msxCustomerName As MaskedTextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents msxPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblPassportNumber As Label
    Friend WithEvents msxTownCity As MaskedTextBox
    Friend WithEvents msxCounty As MaskedTextBox
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblTownCity As Label
    Friend WithEvents lblCounty As Label
    Friend WithEvents btnConfirmDetails As Button
    Friend WithEvents msxStreetAddress As MaskedTextBox
    Friend WithEvents msxPassportNumber As MaskedTextBox
    Friend WithEvents btnCustomerDetailsClear As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlCustomerDetails As Panel
    Friend WithEvents pnlCustomer As Panel
End Class
