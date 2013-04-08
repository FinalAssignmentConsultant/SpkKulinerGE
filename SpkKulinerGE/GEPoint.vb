Public Class GEPoint
    Private lat As Double
    Private lon As Double
    Private R As Double = 6371
    Sub New(ByVal koordinat As String)
        Dim latlon As String() = koordinat.Split(",")
        lat = latlon(1)
        lon = latlon(0)
    End Sub
    Public Overrides Function toString() As String
        Return "LAT: " & lat & "," & lon
    End Function
    Public Function findDistance(ByVal p1 As GEPoint) As Double 'untuk mengembalikan jarak titik p1 ke pusat pencarian (lat dan lon): dalam km.

        Dim dLat As Double = DegreeToRadian(lat - p1.lat)
        Dim dLon As Double = DegreeToRadian(lon - p1.lon)
        Dim a As Double = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + _
                Math.Cos(DegreeToRadian(p1.lat)) * _
                Math.Cos(DegreeToRadian(lat)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
        Dim d = R * c
        Return d
    End Function
End Class
