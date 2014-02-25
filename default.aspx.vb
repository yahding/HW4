
Partial Class _default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'specify constant valus
        Const lowTaxRate As Integer = 18
        Const highTaxRate As Integer = 22

        'set condition
        If tbHoursWage.Text = "" Then
            Me.lbNetResult.Text = ""
            MsgBox("Please enter your hourly wage", MsgBoxStyle.Information, "Error Detected in Input")
        ElseIf tbHoursWorked.Text = "" Then
            Me.lbNetResult.Text = ""
            MsgBox("Please enter how many hours you worked", MsgBoxStyle.Information, "Error Detected in Input")
        ElseIf tbPreTax.Text = "" Then
            Me.lbNetResult.Text = ""
            MsgBox("Please enter the pretax deduction", MsgBoxStyle.Information, "Error Detected in Input")
        ElseIf tbAfterTax.Text = "" Then
            Me.lbNetResult.Text = ""
            MsgBox("Please fill up all the textbox", MsgBoxStyle.Information, "Error Detected in Input")

        Else
            'create variables to hold the values entered by the user
            Dim hw As Decimal = tbHoursWage.Text
            Dim hr As Decimal = tbHoursWorked.Text
            Dim preTaxDed As Decimal = tbPreTax.Text
            Dim afterTaxDed As Decimal = tbAfterTax.Text

            Dim totalWage As Decimal
            totalWage = hw * hr
            Dim netResult As Decimal
            'calculate the net pay result for the user
            If totalWage > 500 Then
                netResult = (totalWage - preTaxDed) * (1 - highTaxRate / 100) - afterTaxDed
            Else
                netResult = (totalWage - preTaxDed) * (1 - lowTaxRate / 100) - afterTaxDed
            End If
            'checking result
            If netResult <= 0 Then
                Me.lbNetResult.Text = ""
                MsgBox("Please check your input since your net wage is either less or equal to 0", _
                                       MsgBoxStyle.Information, "Error Detected in Input")
            Else
                'display the result in the results label web control
                lbNetResult.Text = " Your net pay in this week is $ " & netResult.ToString("#,####.##")
            End If
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear textbox for user
        Me.tbAfterTax.Text = ""
        Me.tbHoursWage.Text = ""
        Me.tbPreTax.Text = ""
        Me.tbHoursWorked.Text = ""
        Me.lbNetResult.Text = ""
    End Sub
End Class
