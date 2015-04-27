Module BorzalModul
    Dim greska As Object
    Dim polje As Object
    Dim dg As Integer
    Dim gg As Integer

    Sub UnhandledExceptionHandler()
        MsgBox("An error occured. Error Number: " & Err.Number & " Description: " & Err.Description & " Source: " & Err.Source)
    End Sub
    Function od_do(polje As String, dg, gg As Integer) As Boolean

        od_do = True

        If Val(polje) >= dg And Val(polje) <= gg Then

            polje = 0

            greska = 0

        Else

            MsgBox("Dozvoljene vrednosti su: " & dg & "-" & gg)

            od_do = False

        End If

    End Function
End Module
