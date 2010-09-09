Public Class FrmMain

    Private Sub btnDisplayAccountSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAccountSummary.Click

        Dim readerVar As IO.StreamReader = IO.File.OpenText("Data.txt")
        Dim strName As String = ""
        Dim strAccountNumber As String = ""
        Dim dblPastDue As Double = 0
        Dim dblPayments As Double = 0
        Dim dblPurchases As Double = 0
        Dim dblFinanceChargers As Double = (dblPastDue - dblPayments) / 1.5 / 100
        Dim dblCurrentBalance As Double = dblPastDue - dblPayments + dblPurchases + dblFinanceChargers


    End Sub
End Class
