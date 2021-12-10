<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentDetails))
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.msxCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.msxExpiryDate = New System.Windows.Forms.MaskedTextBox()
        Me.msxCVC = New System.Windows.Forms.MaskedTextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.lblCVC = New System.Windows.Forms.Label()
        Me.radMastercard = New System.Windows.Forms.RadioButton()
        Me.radVisa = New System.Windows.Forms.RadioButton()
        Me.txtQuotedPrice2 = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.btnConfirmDetails = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlPayment = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlPayment.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblPayment.Location = New System.Drawing.Point(3, 15)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(124, 35)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Payment:"
        '
        'msxCardNumber
        '
        Me.msxCardNumber.Location = New System.Drawing.Point(129, 73)
        Me.msxCardNumber.Mask = "00000000"
        Me.msxCardNumber.Name = "msxCardNumber"
        Me.msxCardNumber.Size = New System.Drawing.Size(64, 27)
        Me.msxCardNumber.TabIndex = 1
        '
        'msxExpiryDate
        '
        Me.msxExpiryDate.Location = New System.Drawing.Point(129, 142)
        Me.msxExpiryDate.Mask = "00/00"
        Me.msxExpiryDate.Name = "msxExpiryDate"
        Me.msxExpiryDate.Size = New System.Drawing.Size(38, 27)
        Me.msxExpiryDate.TabIndex = 2
        '
        'msxCVC
        '
        Me.msxCVC.Location = New System.Drawing.Point(129, 212)
        Me.msxCVC.Mask = "000"
        Me.msxCVC.Name = "msxCVC"
        Me.msxCVC.Size = New System.Drawing.Size(38, 27)
        Me.msxCVC.TabIndex = 3
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(0, 76)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(101, 20)
        Me.lblCardNumber.TabIndex = 4
        Me.lblCardNumber.Text = "Card Number:"
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Location = New System.Drawing.Point(0, 145)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(88, 20)
        Me.lblExpiryDate.TabIndex = 5
        Me.lblExpiryDate.Text = "Expiry Date:"
        '
        'lblCVC
        '
        Me.lblCVC.AutoSize = True
        Me.lblCVC.Location = New System.Drawing.Point(0, 215)
        Me.lblCVC.Name = "lblCVC"
        Me.lblCVC.Size = New System.Drawing.Size(39, 20)
        Me.lblCVC.TabIndex = 6
        Me.lblCVC.Text = "CVC:"
        '
        'radMastercard
        '
        Me.radMastercard.AutoSize = True
        Me.radMastercard.Location = New System.Drawing.Point(304, 109)
        Me.radMastercard.Name = "radMastercard"
        Me.radMastercard.Size = New System.Drawing.Size(104, 24)
        Me.radMastercard.TabIndex = 7
        Me.radMastercard.TabStop = True
        Me.radMastercard.Text = "Mastercard"
        Me.radMastercard.UseVisualStyleBackColor = True
        '
        'radVisa
        '
        Me.radVisa.AutoSize = True
        Me.radVisa.Location = New System.Drawing.Point(304, 181)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(57, 24)
        Me.radVisa.TabIndex = 8
        Me.radVisa.TabStop = True
        Me.radVisa.Text = "Visa"
        Me.radVisa.UseVisualStyleBackColor = True
        '
        'txtQuotedPrice2
        '
        Me.txtQuotedPrice2.Location = New System.Drawing.Point(129, 274)
        Me.txtQuotedPrice2.Name = "txtQuotedPrice2"
        Me.txtQuotedPrice2.ReadOnly = True
        Me.txtQuotedPrice2.Size = New System.Drawing.Size(95, 27)
        Me.txtQuotedPrice2.TabIndex = 9
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Location = New System.Drawing.Point(0, 277)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(115, 20)
        Me.lblFinalPrice.TabIndex = 10
        Me.lblFinalPrice.Text = "Price to be Paid:"
        '
        'btnConfirmDetails
        '
        Me.btnConfirmDetails.BackColor = System.Drawing.Color.Lime
        Me.btnConfirmDetails.Location = New System.Drawing.Point(0, 321)
        Me.btnConfirmDetails.Name = "btnConfirmDetails"
        Me.btnConfirmDetails.Size = New System.Drawing.Size(494, 40)
        Me.btnConfirmDetails.TabIndex = 11
        Me.btnConfirmDetails.Text = "Confirm Details"
        Me.btnConfirmDetails.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(381, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlPayment
        '
        Me.pnlPayment.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlPayment.Controls.Add(Me.lblCardNumber)
        Me.pnlPayment.Controls.Add(Me.msxCardNumber)
        Me.pnlPayment.Controls.Add(Me.btnConfirmDetails)
        Me.pnlPayment.Controls.Add(Me.lblExpiryDate)
        Me.pnlPayment.Controls.Add(Me.msxExpiryDate)
        Me.pnlPayment.Controls.Add(Me.lblFinalPrice)
        Me.pnlPayment.Controls.Add(Me.radVisa)
        Me.pnlPayment.Controls.Add(Me.msxCVC)
        Me.pnlPayment.Controls.Add(Me.radMastercard)
        Me.pnlPayment.Controls.Add(Me.txtQuotedPrice2)
        Me.pnlPayment.Controls.Add(Me.lblCVC)
        Me.pnlPayment.Location = New System.Drawing.Point(35, 96)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.Size = New System.Drawing.Size(494, 361)
        Me.pnlPayment.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.lblPayment)
        Me.Panel2.Location = New System.Drawing.Point(38, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 50)
        Me.Panel2.TabIndex = 11
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Location = New System.Drawing.Point(-2, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(138, 90)
        Me.pbxLogo.TabIndex = 16
        Me.pbxLogo.TabStop = False
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnClose)
        Me.pnlOptions.Controls.Add(Me.btnClear)
        Me.pnlOptions.Location = New System.Drawing.Point(134, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(666, 50)
        Me.pnlOptions.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(545, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 38)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmPaymentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.pnlPayment)
        Me.Name = "frmPaymentDetails"
        Me.Text = "Payment Details "
        Me.pnlPayment.ResumeLayout(False)
        Me.pnlPayment.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPayment As Label
    Friend WithEvents msxCardNumber As MaskedTextBox
    Friend WithEvents msxExpiryDate As MaskedTextBox
    Friend WithEvents msxCVC As MaskedTextBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents lblCVC As Label
    Friend WithEvents radMastercard As RadioButton
    Friend WithEvents radVisa As RadioButton
    Friend WithEvents txtQuotedPrice2 As TextBox
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents btnConfirmDetails As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnClose As Button
End Class
