<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleType))
        Me.cbxVehicleType = New System.Windows.Forms.ComboBox()
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.btnConfirmDetails = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlVehicle = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVehicleTypeSelection = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        Me.pnlVehicle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxVehicleType
        '
        Me.cbxVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxVehicleType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxVehicleType.FormattingEnabled = True
        Me.cbxVehicleType.Items.AddRange(New Object() {"Car", "Van"})
        Me.cbxVehicleType.Location = New System.Drawing.Point(233, 96)
        Me.cbxVehicleType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxVehicleType.Name = "cbxVehicleType"
        Me.cbxVehicleType.Size = New System.Drawing.Size(277, 36)
        Me.cbxVehicleType.TabIndex = 0
        '
        'lblVehicleType
        '
        Me.lblVehicleType.AutoSize = True
        Me.lblVehicleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVehicleType.Location = New System.Drawing.Point(17, 102)
        Me.lblVehicleType.Name = "lblVehicleType"
        Me.lblVehicleType.Size = New System.Drawing.Size(133, 25)
        Me.lblVehicleType.TabIndex = 1
        Me.lblVehicleType.Text = "Vehicle Type:"
        '
        'btnConfirmDetails
        '
        Me.btnConfirmDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirmDetails.Location = New System.Drawing.Point(26, 207)
        Me.btnConfirmDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmDetails.Name = "btnConfirmDetails"
        Me.btnConfirmDetails.Size = New System.Drawing.Size(484, 47)
        Me.btnConfirmDetails.TabIndex = 4
        Me.btnConfirmDetails.Text = "Confirm Details"
        Me.btnConfirmDetails.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Location = New System.Drawing.Point(-1, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(163, 137)
        Me.pbxLogo.TabIndex = 5
        Me.pbxLogo.TabStop = False
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.btnClose)
        Me.pnlOptions.Location = New System.Drawing.Point(159, 0)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(442, 49)
        Me.pnlOptions.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(318, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 38)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlVehicle
        '
        Me.pnlVehicle.BackColor = System.Drawing.Color.Cornsilk
        Me.pnlVehicle.Controls.Add(Me.Panel1)
        Me.pnlVehicle.Controls.Add(Me.cbxVehicleType)
        Me.pnlVehicle.Controls.Add(Me.btnConfirmDetails)
        Me.pnlVehicle.Controls.Add(Me.lblVehicleType)
        Me.pnlVehicle.Location = New System.Drawing.Point(12, 166)
        Me.pnlVehicle.Name = "pnlVehicle"
        Me.pnlVehicle.Size = New System.Drawing.Size(562, 305)
        Me.pnlVehicle.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.lblVehicleTypeSelection)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 62)
        Me.Panel1.TabIndex = 5
        '
        'lblVehicleTypeSelection
        '
        Me.lblVehicleTypeSelection.AutoSize = True
        Me.lblVehicleTypeSelection.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblVehicleTypeSelection.Location = New System.Drawing.Point(3, 16)
        Me.lblVehicleTypeSelection.Name = "lblVehicleTypeSelection"
        Me.lblVehicleTypeSelection.Size = New System.Drawing.Size(285, 35)
        Me.lblVehicleTypeSelection.TabIndex = 0
        Me.lblVehicleTypeSelection.Text = "Vehicle Type Selection:"
        '
        'frmVehicleType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(601, 517)
        Me.Controls.Add(Me.pnlVehicle)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pbxLogo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVehicleType"
        Me.Text = "Vehicle Type"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlVehicle.ResumeLayout(False)
        Me.pnlVehicle.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxVehicleType As ComboBox
    Friend WithEvents lblVehicleType As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConfirmDetails As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlVehicle As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblVehicleTypeSelection As Label
End Class
