Public Class frmKupci
    Private myTextBoxArray As TextBox()




    Private Sub KupacBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KupacBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KupacBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BorzalDataSet)

    End Sub

    Private Sub frmKupci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BorzalDataSet.Kupac' table. You can move, or remove it, as needed.
        Me.KupacTableAdapter.Fill(Me.BorzalDataSet.Kupac)
        ' xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        myTextBoxArray = {NazivTextBox, MestoTextBox, AdresaTextBox, KbrTextBox, TelefonTextBox}





    End Sub
    Private Sub nazivtextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles NazivTextBox.KeyDown, MestoTextBox.KeyDown, AdresaTextBox.KeyDown, KbrTextBox.KeyDown, TelefonTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ProcessTabKey(True)
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub NazivTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NazivTextBox.Validating
        If String.IsNullOrEmpty(NazivTextBox.Text) Then
            gr1.SetError(NazivTextBox, "Unesite nešto!!")
            gr1.SetError(MestoTextBox, "nešto drugo...")
        Else
            gr1.Clear()
            ' ne skida grešku sa mesta
        End If

    End Sub

    Private Sub KbrTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles KbrTextBox.Validating
        If Not IsNumeric(KbrTextBox.Text) Then
            gr1.SetError(KbrTextBox, "Unesite broj")
        Else
            gr1.Clear()
        End If
    End Sub

    Private Sub MestoTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MestoTextBox.Validating
        If String.IsNullOrEmpty(MestoTextBox.Text) Then
            gr1.SetError(MestoTextBox, "unesi nešto..")
            ' Return
        Else
            gr1.SetError(MestoTextBox, "")
        End If
    End Sub
End Class