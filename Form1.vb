Public Class Form1
    Dim k1(4, 4), k2(4, 4), k3(4, 4), k4(4, 4) As Integer
    Dim spelers(3) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For teller As Integer = 0 To 3
            spelers(teller) = InputBox("Geef de naam van speler" & teller + 1)
        Next

        Label5.Text = spelers(0)
        Label6.Text = spelers(1)
        Label7.Text = spelers(2)
        Label8.Text = spelers(3)

        maakKaart(k1)
        maakKaart(k2)
        maakKaart(k3)
        maakKaart(k4)

        Label1.Text = maakKaart(k1)
        Label2.Text = maakKaart(k2)
        Label3.Text = maakKaart(k3)
        Label4.Text = maakKaart(k4)

    End Sub
    Public Function maakKaart(ByRef kaart1(,) As Integer) As String

        Dim teller, teller2, teller3, teller4, teller5 As Integer
        Dim tmp As String = ""
        Dim uniek As Boolean
        Dim getal As Integer
        teller3 = 1

        For teller = 0 To kaart1.GetUpperBound(0)
            For teller2 = 0 To kaart1.GetUpperBound(1)
                teller5 = 0
                uniek = False
                Do Until uniek = True
                    getal = CInt(Int(Rnd() * 15) + teller3)
                    For teller4 = 0 To kaart1.GetUpperBound(1)
                        If getal <> kaart1(teller, teller4) Then
                            teller5 += 1
                        End If
                        If teller5 = 5 Then
                            uniek = True
                        End If
                    Next
                Loop
                kaart1(teller, teller2) = getal
            Next
            teller3 += 15
        Next

        For teller = 0 To 4
            For teller2 = 0 To 4
                If kaart1(teller, teller2) < 10 Then
                    tmp &= "0" & kaart1(teller, teller2) & Space(2)
                Else
                    tmp &= kaart1(teller, teller2) & Space(2)
                End If
            Next
            tmp &= vbCrLf

        Next

        Return tmp
    End Function

    Public Function willgetal(ByVal ondergrens As Integer, ByVal bovengrens As Integer) As Integer
        Dim will As Integer
        Randomize()
        will = CInt(Int((bovengrens - ondergrens + 1) * Rnd() + ondergrens))
        Return will
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getal As Integer




        getal = willgetal(1, 100)

        MessageBox.Show("Het getal is: " & getal)

        For teller = 0 To 4
            For teller2 = 0 To 4
                If getal = k1(teller, teller2) Then
                    MessageBox.Show("Speler " & spelers(0) & " heeft een nummer")
                    k1(teller, teller2) = "00"
                End If
                If getal = k2(teller, teller2) Then
                    MessageBox.Show("Speler " & spelers(1) & " heeft een nummer")
                    k2(teller, teller2) = "00"
                End If
                If getal = k3(teller, teller2) Then
                    MessageBox.Show("Speler " & spelers(2) & " heeft een nummer")
                    k3(teller, teller2) = "00"
                End If
                If getal = k4(teller, teller2) Then
                    MessageBox.Show("Speler " & spelers(3) & " heeft een nummer")
                    k4(teller, teller2) = "00"
                End If
            Next
        Next


    End Sub
End Class
