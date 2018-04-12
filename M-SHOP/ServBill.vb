Public Class ServBill

    Private Sub ServBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.stock' table. You can move, or remove it, as needed.
        Me.stockTableAdapter.Fill(Me.StockDataSet.stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class