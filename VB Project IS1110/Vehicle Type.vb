Public Class frmVehicleType
    'declaring variables in combobox and declaring forms 
    Dim add1 As String = "Car"
    Dim add2 As String = "Van"
    Dim frmCarSelect As frmCarSelect = New frmCarSelect
    Dim frmVanSelect As frmVanSelect = New frmVanSelect
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVehicleType.SelectedIndexChanged

    End Sub

    Private Sub btnConfirmDetails_Click(sender As Object, e As EventArgs) Handles btnConfirmDetails.Click
        'Depending on which one is selected the relevant next form will open
        If cbxVehicleType.SelectedItem = "Car" Then
            frmCarSelect.Show()
            Me.Hide()

        ElseIf cbxVehicleType.SelectedItem = "Van" Then
            frmVanSelect.Show()
            Me.Hide()

        Else MsgBox("Please select one of the Options")


        End If
    End Sub

    Private Sub frmVehicleType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Decoration
        pnlVehicle.BackColor = Color.FromArgb(120, 0, 0, 0)
        pnlOptions.BackColor = Color.FromArgb(120, 0, 0, 0)

        lblVehicleType.BackColor = Color.Transparent


        lblVehicleType.ForeColor = Color.White

    End Sub
End Class