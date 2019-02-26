Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kleur() As String = {"rood", "oranje", "geel", "groen", "blauw", "indigo", "violet"}
        Dim getal As Integer = "1"



        For i As Integer = 0 To 5
            getal = willgetal(0, 6)
            MessageBox.Show("U favoriete kleur is :" & kleur(getal))
        Next

    End Sub
    Public Function willgetal(ByVal ondergrens As Integer, ByVal bovengrens As Integer) As Integer
        Dim will As Integer
        Randomize()
        will = CInt(Int((bovengrens - ondergrens + 1) * Rnd() + ondergrens))
        Return will
    End Function
End Class
