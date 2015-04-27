Public Class frmProizvod

    Private Sub ProizvodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProizvodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProizvodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BorzalDataSet)

    End Sub

    Private Sub frmProizvod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BorzalDataSet.Proizvod' table. You can move, or remove it, as needed.
        Me.ProizvodTableAdapter.Fill(Me.BorzalDataSet.Proizvod)

    End Sub
End Class