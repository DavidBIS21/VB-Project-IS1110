<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTerms))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblTermsAndConditions = New System.Windows.Forms.Label()
        Me.chxTermsAndConditions = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 73)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(635, 375)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'lblTermsAndConditions
        '
        Me.lblTermsAndConditions.AutoSize = True
        Me.lblTermsAndConditions.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTermsAndConditions.Location = New System.Drawing.Point(256, 21)
        Me.lblTermsAndConditions.Name = "lblTermsAndConditions"
        Me.lblTermsAndConditions.Size = New System.Drawing.Size(269, 35)
        Me.lblTermsAndConditions.TabIndex = 1
        Me.lblTermsAndConditions.Text = "Terms and Conditions"
        '
        'chxTermsAndConditions
        '
        Me.chxTermsAndConditions.AutoSize = True
        Me.chxTermsAndConditions.Location = New System.Drawing.Point(96, 463)
        Me.chxTermsAndConditions.Name = "chxTermsAndConditions"
        Me.chxTermsAndConditions.Size = New System.Drawing.Size(378, 24)
        Me.chxTermsAndConditions.TabIndex = 2
        Me.chxTermsAndConditions.Text = " I Have Read and Agree to the Terms and Conditions"
        Me.chxTermsAndConditions.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(674, 463)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(94, 29)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmTerms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 499)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chxTermsAndConditions)
        Me.Controls.Add(Me.lblTermsAndConditions)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "frmTerms"
        Me.Text = "Terms and Conditions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblTermsAndConditions As Label
    Friend WithEvents chxTermsAndConditions As CheckBox
    Friend WithEvents btnNext As Button
End Class
