Public Class frmRacun
   
    Private Sub RacunBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RacunBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.RacunBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BorzalDataSet)
        Catch
            'pozivamo funkciju za obradu greške!!! 
            UnhandledExceptionHandler()
        End Try


    End Sub

    Private Sub frmRacun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BorzalDataSet.Proizvod' table. You can move, or remove it, as needed.
        Me.ProizvodTableAdapter.Fill(Me.BorzalDataSet.Proizvod)
        'TODO: This line of code loads data into the 'BorzalDataSet.Kupac' table. You can move, or remove it, as needed.
        Me.KupacTableAdapter.Fill(Me.BorzalDataSet.Kupac)
        'TODO: This line of code loads data into the 'BorzalDataSet.Racun' table. You can move, or remove it, as needed.
        Me.RacunTableAdapter.Fill(Me.BorzalDataSet.Racun)

    End Sub
End Class