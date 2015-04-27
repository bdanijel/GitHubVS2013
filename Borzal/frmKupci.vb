Public Class frmKupci
    Private myTextBoxArray As TextBox()

    Sub ValidateNumeric(ctlControl As Control)
        Dim ErrorProvider1 As ErrorProvider
        Try
            If Not IsNumeric(ctlControl.Text) Then
                'Postavi grešku.
                ErrorProvider1.SetError(ctlControl, "Molim Vas unesite broj.")
            Else
                'Očisti grešku.
                ErrorProvider1.SetError(ctlControl, "")
            End If
        Catch
            'Obrada grešaka
            UnhandledExceptionHandler()
        End Try
    End Sub

    Sub ValidateNotBlank(ctlControl As Control)
        Try
            If String.IsNullOrEmpty(ctlControl.Text) Then
                'postavi grešku
                ErrorProvider1.SetError(ctlControl, "Molim Vas da unesete vrednost u polje")
            Else
                'Očisti grešku
                ErrorProvider1.SetError(ctlControl, "")
            End If
        Catch
            'obrada grešaka.
            UnhandledExceptionHandler()
        End Try
    End Sub





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
        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
            ProcessTabKey(True)
        End If
        If e.KeyCode = Keys.Up Then
            e.SuppressKeyPress = True
            SendKeys.Send("+{tab}")
            'e.KeyCode = Keys.Shift And e.KeyCode = Keys.Tab
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub NazivTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NazivTextBox.Validating
        'If String.IsNullOrEmpty(NazivTextBox.Text) Then
        '    gr1.SetError(NazivTextBox, "Unesite nešto!!")
        '    gr1.SetError(MestoTextBox, "nešto drugo...")
        'Else
        '    gr1.Clear()
        '    ' ne skida grešku sa mesta
        'End If
        Try
            ValidateNotBlank(NazivTextBox)
        Catch
            UnhandledExceptionHandler()
        End Try

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