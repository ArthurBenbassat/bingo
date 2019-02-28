Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spelers(3) As String
        Dim speler As String
        For teller As Integer = 0 To 3
            spelers(teller) = InputBox("Geef de naam van speler" & teller + 1)
        Next


        Label5.Text = spelers(0)
        Label6.Text = spelers(1)
        Label7.Text = spelers(2)
        Label8.Text = spelers(3)



        Label1.Text = maakKaart()
        Label2.Text = maakKaart()
        Label3.Text = maakKaart()
        Label4.Text = maakKaart()

    End Sub
    Private Function maakKaart()
        Dim kaart1(4, 4) As Integer
        Dim teller As Integer = 0
        Dim tmp As String = ""

        For teller2 As Integer = 0 To 4
            kaart1(teller, teller2) = willgetal(1, 15)

        Next
        teller = 1
        For teller2 As Integer = 0 To 4
            kaart1(teller, teller2) = willgetal(16, 30)
        Next
        teller = 2
        For teller2 As Integer = 0 To 4
            kaart1(teller, teller2) = willgetal(31, 45)
        Next
        teller = 3
        For teller2 As Integer = 0 To 4
            kaart1(teller, teller2) = willgetal(46, 60)
        Next
        teller = 4
        For teller2 As Integer = 0 To 4
            kaart1(teller, teller2) = willgetal(61, 75)
        Next
        teller = 0
        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp &= "0" & kaart1(teller, teller2) & Space(2)
            Else
                tmp &= kaart1(teller, teller2) & Space(2)
            End If
        Next
        tmp &= vbCrLf
        teller = 1
        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp &= "0" & kaart1(teller, teller2) & Space(2)
            Else
                tmp &= kaart1(teller, teller2) & Space(2)
            End If
        Next
        tmp &= vbCrLf
        teller = 2
        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp &= "0" & kaart1(teller, teller2) & Space(2)
            Else
                tmp &= kaart1(teller, teller2) & Space(2)
            End If
        Next
        tmp &= vbCrLf
        teller = 3
        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp &= "0" & kaart1(teller, teller2) & Space(2)
            Else
                tmp &= kaart1(teller, teller2) & Space(2)
            End If
        Next
        tmp &= vbCrLf
        teller = 4

        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp &= "0" & kaart1(teller, teller2) & Space(2)
            Else
                tmp &= kaart1(teller, teller2) & Space(2)
            End If
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
        Dim getallen1 As String
        Dim getallen2 As String
        Dim getallen3 As String
        Dim getallen4 As String

        getallen1 = Label1.Text
        getallen2 = Label2.Text
        getallen3 = Label3.Text
        getallen4 = Label4.Text


        getal = willgetal(1, 100)




    End Sub
End Class
