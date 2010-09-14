Public Class FrmMain

    Private Sub btnDisplayAccountSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAccountSummary.Click

        'Declare Variables
        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\Data.txt")
        Dim strName As String = ""
        Dim strAccountNumber As String = ""
        Dim dblPastDue As Double = 0
        Dim dblPayments As Double = 0
        Dim dblPurchases As Double = 0
        Dim fmtStr As String = "{0,-10}{1,15}{2,15}{3,15}{4,15}{5,15}"

        'Read text Document
        strName = sr.ReadLine
        dblPastDue = sr.ReadLine
        dblPayments = sr.ReadLine
        dblPurchases = sr.ReadLine

        'Delare Variables and Process Calculations
        Dim dblNewBalance As Double = (dblPastDue - dblPayments)
        Dim dblFinanceChargers As Double = (dblNewBalance * 1.015) - dblNewBalance
        Dim dblCurrentBalance As Double = (dblNewBalance + dblPurchases + dblFinanceChargers)

        'Output
        lstAccountSummary.Items.Clear()
        lstAccountSummary.Items.Add(String.Format(fmtStr, "Account", "Past Due", "", "", "Finance", "Current"))
        lstAccountSummary.Items.Add(String.Format(fmtStr, "Number", "Amount", "Payments", "Purchases", "Changes", "Amt Due"))
        lstAccountSummary.Items.Add(String.Format(fmtStr, strName, FormatCurrency(dblPastDue, 2), FormatCurrency(dblPayments, 2), FormatCurrency(dblPurchases, 2), FormatCurrency(dblFinanceChargers, 2), FormatCurrency(dblCurrentBalance, 2)))

    End Sub
End Class
