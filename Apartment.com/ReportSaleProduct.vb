Public Class ReportSaleProduct

    Public _id As String = ""
    Private Sub ReportSaleProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport
    End Sub
End Class