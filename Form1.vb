Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getallen(5) As Integer
        Dim gemiddelde As Decimal
        Dim tmp As String = ""

        For teller As Integer = 0 To getallen.GetUpperBound(0)
            Try
                getallen(teller) = InputBox("Geef een getal: ")
            Catch ex As Exception
                MessageBox.Show("Voer een getal in")
                teller += 1
            End Try

        Next

        For teller As Integer = 0 To 5

            tmp &= getallen(teller) & Space(1)

        Next

        For teller As Integer = 0 To 5
            gemiddelde += getallen(teller)
        Next

        gemiddelde = gemiddelde / 6

        MessageBox.Show(tmp & vbCrLf & "Dit is het gemiddelde is " & gemiddelde)
    End Sub
End Class
