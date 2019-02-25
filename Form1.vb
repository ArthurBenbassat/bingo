Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Label1.Text = tmp


        Dim kaart2(4, 4) As Integer
        teller = 0
        Dim tmp2 As String = ""

        For teller2 As Integer = 0 To 4
            kaart2(teller, teller2) = willgetal(1, 15)
        Next
        teller = 1
        For teller2 As Integer = 0 To 4
            kaart2(teller, teller2) = willgetal(16, 30)
        Next
        teller = 2
        For teller2 As Integer = 0 To 4
            kaart2(teller, teller2) = willgetal(31, 45)
        Next
        teller = 3
        For teller2 As Integer = 0 To 4
            kaart2(teller, teller2) = willgetal(46, 60)
        Next
        teller = 4
        For teller2 As Integer = 0 To 4
            kaart2(teller, teller2) = willgetal(61, 75)
        Next


        teller = 0
        For teller2 As Integer = 0 To 4
            If kaart2(teller, teller2) < 10 Then
                tmp2 &= "0" & kaart2(teller, teller2) & Space(2)
            Else
                tmp2 &= kaart2(teller, teller2) & Space(2)
            End If
        Next
        tmp2 &= vbCrLf
        teller = 1
        For teller2 As Integer = 0 To 4
            If kaart2(teller, teller2) < 10 Then
                tmp2 &= "0" & kaart2(teller, teller2) & Space(2)
            Else
                tmp2 &= kaart2(teller, teller2) & Space(2)
            End If
        Next
        tmp2 &= vbCrLf
        teller = 2
        For teller2 As Integer = 0 To 4
            If kaart2(teller, teller2) < 10 Then
                tmp2 &= "0" & kaart2(teller, teller2) & Space(2)
            Else
                tmp2 &= kaart2(teller, teller2) & Space(2)
            End If
        Next
        tmp2 &= vbCrLf
        teller = 3
        For teller2 As Integer = 0 To 4
            If kaart2(teller, teller2) < 10 Then
                tmp2 &= "0" & kaart2(teller, teller2) & Space(2)
            Else
                tmp2 &= kaart2(teller, teller2) & Space(2)
            End If
        Next
        tmp2 &= vbCrLf
        teller = 4
        For teller2 As Integer = 0 To 4
            If kaart2(teller, teller2) < 10 Then
                tmp2 &= "0" & kaart2(teller, teller2) & Space(2)
            Else
                tmp2 &= kaart2(teller, teller2) & Space(2)
            End If
        Next
        Label2.Text = tmp2



        Dim kaart3(4, 4) As Integer
        teller = 0
        Dim tmp3 As String = ""

        For teller2 As Integer = 0 To 4
            kaart3(teller, teller2) = willgetal(1, 15)
        Next
        teller = 1
        For teller2 As Integer = 0 To 4
            kaart3(teller, teller2) = willgetal(16, 30)
        Next
        teller = 2
        For teller2 As Integer = 0 To 4
            kaart3(teller, teller2) = willgetal(31, 45)
        Next
        teller = 3
        For teller2 As Integer = 0 To 4
            kaart3(teller, teller2) = willgetal(46, 60)
        Next
        teller = 4
        For teller2 As Integer = 0 To 4
            kaart3(teller, teller2) = willgetal(61, 75)
        Next


        teller = 0
        For teller2 As Integer = 0 To 4
            If kaart3(teller, teller2) < 10 Then
                tmp3 &= "0" & kaart3(teller, teller2) & Space(2)
            Else
                tmp3 &= kaart3(teller, teller2) & Space(2)
            End If
        Next
        tmp3 &= vbCrLf
        teller = 1
        For teller2 As Integer = 0 To 4
            If kaart3(teller, teller2) < 10 Then
                tmp3 &= "0" & kaart3(teller, teller2) & Space(2)
            Else
                tmp3 &= kaart3(teller, teller2) & Space(2)
            End If
        Next
        tmp3 &= vbCrLf
        teller = 2
        For teller2 As Integer = 0 To 4
            If kaart3(teller, teller2) < 10 Then
                tmp3 &= "0" & kaart3(teller, teller2) & Space(2)
            Else
                tmp3 &= kaart3(teller, teller2) & Space(2)
            End If
        Next
        tmp3 &= vbCrLf
        teller = 3
        For teller2 As Integer = 0 To 4
            If kaart3(teller, teller2) < 10 Then
                tmp3 &= "0" & kaart3(teller, teller2) & Space(2)
            Else
                tmp3 &= kaart3(teller, teller2) & Space(2)
            End If
        Next
        tmp3 &= vbCrLf
        teller = 4
        For teller2 As Integer = 0 To 4
            If kaart1(teller, teller2) < 10 Then
                tmp3 &= "0" & kaart3(teller, teller2) & Space(2)
            Else
                tmp3 &= kaart3(teller, teller2) & Space(2)
            End If
        Next
        Label3.Text = tmp3



        Dim kaart4(4, 4) As Integer
        teller = 0
        Dim tmp4 As String = ""

        For teller2 As Integer = 0 To 4
            kaart4(teller, teller2) = willgetal(1, 15)
        Next
        teller = 1
        For teller2 As Integer = 0 To 4
            kaart4(teller, teller2) = willgetal(16, 30)
        Next
        teller = 2
        For teller2 As Integer = 0 To 4
            kaart4(teller, teller2) = willgetal(31, 45)
        Next
        teller = 3
        For teller2 As Integer = 0 To 4
            kaart4(teller, teller2) = willgetal(46, 60)
        Next
        teller = 4
        For teller2 As Integer = 0 To 4
            kaart4(teller, teller2) = willgetal(61, 75)
        Next


        teller = 0
        For teller2 As Integer = 0 To 4
            If kaart4(teller, teller2) < 10 Then
                tmp4 &= "0" & kaart4(teller, teller2) & Space(2)
            Else
                tmp4 &= kaart4(teller, teller2) & Space(2)
            End If
        Next
        tmp4 &= vbCrLf
        teller = 1
        For teller2 As Integer = 0 To 4
            If kaart4(teller, teller2) < 10 Then
                tmp4 &= "0" & kaart4(teller, teller2) & Space(2)
            Else
                tmp4 &= kaart4(teller, teller2) & Space(2)
            End If
        Next
        tmp4 &= vbCrLf
        teller = 2
        For teller2 As Integer = 0 To 4
            If kaart4(teller, teller2) < 10 Then
                tmp4 &= "0" & kaart4(teller, teller2) & Space(2)
            Else
                tmp4 &= kaart4(teller, teller2) & Space(2)
            End If
        Next
        tmp4 &= vbCrLf
        teller = 3
        For teller2 As Integer = 0 To 4
            If kaart4(teller, teller2) < 10 Then
                tmp4 &= "0" & kaart4(teller, teller2) & Space(2)
            Else
                tmp4 &= kaart4(teller, teller2) & Space(2)
            End If
        Next
        tmp4 &= vbCrLf
        teller = 4
        For teller2 As Integer = 0 To 4
            If kaart4(teller, teller2) < 10 Then
                tmp4 &= "0" & kaart4(teller, teller2) & Space(2)
            Else
                tmp4 &= kaart4(teller, teller2) & Space(2)
            End If
        Next
        Label4.Text = tmp4
    End Sub
    Public Function willgetal(ByVal ondergrens As Integer, ByVal bovengrens As Integer) As Integer
        Dim will As Integer
        Randomize()
        will = CInt(Int((bovengrens - ondergrens + 1) * Rnd() + ondergrens))
        Return will
    End Function
End Class
