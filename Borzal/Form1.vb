Public Class Form1

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BorzalDataSet.Kupac' table. You can move, or remove it, as needed.
        Me.KupacTableAdapter.Fill(Me.BorzalDataSet.Kupac)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class