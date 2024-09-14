Public Class Form1
    Const Whitewine_price = 120
    Const Redwine_price = 150
    Const Beer_price = 70
    Const cTaxrate = 0.12
    Dim Subtotal As Double
    Dim Total As Double

    Private Sub ckTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckTotal.Click
        Dim ccost As Double
        Dim cQuantity As Double
        Dim cTax As Double
        Dim cItemAmount As Double

        If radWW.Checked = True Then
            ccost = Whitewine_price
        ElseIf radRW.Checked = True Then
            ccost = Redwine_price
        ElseIf radBeer.Checked = True Then
            ccost = Beer_price
        Else
            MsgBox("Please select a drink", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If

        If IsNumeric(txtQuantity.Text) Then
            cQuantity = Val(txtQuantity.Text)
            cItemAmount = ccost * cQuantity
            Subtotal = Subtotal + cItemAmount
            If CheckBox1.Checked = True Then
                cTax = cWineTax(Subtotal)
            End If
            Total = Subtotal + cTax
            lblItemAmount.Text = cItemAmount
            lblSubTotal.Text = Subtotal
            lblTax.Text = cTax
            lblTotal.Text = Total
        Else
            MsgBox("Enter a number value into quantity", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Function cWineTax(ByVal cItemAmount As Double) As Double
        Return cItemAmount * cTaxrate
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtQuantity.Text = ""
        lblItemAmount.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
        Subtotal = 0
        Total = 0
        radWW.Checked = False
        radRW.Checked = False
        radBeer.Checked = False
        CheckBox1.Checked = False
    End Sub
End Class
