Module BorzalModul
    Dim greska As Object
    Dim polje As Object
    Dim dg As Integer
    Dim gg As Integer
    Dim ErrorProvider1 As ErrorProvider

    Sub UnhandledExceptionHandler()
        MsgBox("An error occured. Error Number: " & Err.Number & " Description: " & Err.Description & " Source: " & Err.Source)
    End Sub
    Function od_do(polje As String, dg As Integer, gg As Integer) As Boolean
        'provera vrednosti od - do
        od_do = True
        If Val(polje) >= dg And Val(polje) <= gg Then
            polje = 0
            greska = 0
        Else
            MsgBox("Dozvoljene vrednosti su: " & dg & "-" & gg)
            od_do = False
        End If
    End Function
    Public Function DanOK(MesecZaProveru As Integer, DanZaProveru As Integer, GodZaProveru As Integer) As Boolean

        'provera da li je dan ok (MESEC, DAN, GODINA)

        Select Case MesecZaProveru
            Case 1, 3, 5, 7, 8, 10, 12
                If DanZaProveru >= 1 And DanZaProveru <= 31 Then
                    DanOK = True
                Else
                    DanOK = False
                End If
            Case 4, 6, 9, 11
                If DanZaProveru >= 1 And DanZaProveru <= 30 Then
                    DanOK = True
                Else
                    DanOK = False
                End If
            Case 2
                If GodZaProveru Mod 4 = 0 Then
                    If DanZaProveru >= 1 And DanZaProveru <= 29 Then
                        DanOK = True
                    Else
                        DanOK = False
                    End If
                Else
                    If DanZaProveru >= 1 And DanZaProveru <= 28 Then
                        DanOK = True
                    Else
                        DanOK = False
                    End If
                End If
        End Select
    End Function
    Sub ValidateNumeric(ByVal ctlControl As Control)
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
    Sub ValidateNotBlank(ByVal ctlControl As Control)

        Try
            If ctlControl.Text = "" Then
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
End Module
