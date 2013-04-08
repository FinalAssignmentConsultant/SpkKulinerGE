Imports System.Data.Odbc

Module ModuleAplikasi
    Public Pemakai As String
    Public IdPemakai As Integer
    Public Peran As String = ""

    Public PUBLIC_Folder As String
    Public con As Odbc.OdbcConnection = New Odbc.OdbcConnection("dsn=dani")

    Public Function DegreeToRadian(ByVal degree As Double) As Double
        Return (Math.PI / 180) * degree
    End Function

    Public Function RadianToDegree(ByVal radian As Double) As Double
        Return (180 / Math.PI) * radian
    End Function
End Module
