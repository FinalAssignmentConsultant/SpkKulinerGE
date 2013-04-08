Public Class ClassResto
    Private sNamaResto As String = ""
    Private sJenisMakanan As String = ""
    Private sWaktuBuka As String = ""
    Private sKhas As String = ""
    Private nBudget As Integer = 0
    Private sSuasana As String = ""
    Private sLokasi As String = ""
    Private nSkor As Double = 0
    Private nBuka As Integer = 0
    Private nTutup As Integer = 0
    Private sNamaMakanan As String = ""
    Private sKoordinat As String = ""
    Private sKelompokMakanan As String = ""
    Public Property NamaMakanan() As String
        Get
            Return sNamaMakanan
        End Get
        Set(ByVal value As String)
            sNamaMakanan = value
        End Set
    End Property
    Public Property Koordinat() As String
        Get
            Return sKoordinat
        End Get
        Set(ByVal value As String)
            sKoordinat = value
        End Set
    End Property
    Public Property NamaResto() As String
        Get
            Return sNamaResto
        End Get
        Set(ByVal value As String)
            sNamaResto = value
        End Set
    End Property
    Public Property JenisMakanan() As String
        Get
            Return sJenisMakanan
        End Get
        Set(ByVal value As String)
            sJenisMakanan = value
        End Set
    End Property
    Public Property WaktuBuka() As String
        Get
            Return sWaktuBuka
        End Get
        Set(ByVal value As String)
            sWaktuBuka = value
        End Set
    End Property
    Public Property Khas() As String
        Get
            Return sKhas
        End Get
        Set(ByVal value As String)
            sKhas = value
        End Set
    End Property
    Public Property Budget() As Integer
        Get
            Return nBudget
        End Get
        Set(ByVal value As Integer)
            nBudget = value
        End Set
    End Property
    Public Property Skor() As Double
        Get
            Return nSkor
        End Get
        Set(ByVal value As Double)
            nSkor = value
        End Set
    End Property
    Public Property Suasana() As String
        Get
            Return sSuasana
        End Get
        Set(ByVal value As String)
            sSuasana = value
        End Set
    End Property
    Public Property Lokasi() As String
        Get
            Return sLokasi
        End Get
        Set(ByVal value As String)
            sLokasi = value
        End Set
    End Property
    Public Property Buka() As Integer
        Get
            Return nBuka
        End Get
        Set(ByVal value As Integer)
            nBuka = value
        End Set
    End Property
    Public Property Tutup() As Integer
        Get
            Return nTutup
        End Get
        Set(ByVal value As Integer)
            nTutup = value
        End Set
    End Property
    Public Property KelompokMakanan() As String
        Get
            Return sKelompokMakanan
        End Get
        Set(ByVal value As String)
            sKelompokMakanan = value
        End Set
    End Property
    Sub New(ByVal vNamaResto As String, ByVal vJenisMakanan As String, ByVal vWaktuBuka As String, _
            ByVal vKhas As String, ByVal vBudget As Integer, ByVal vSuasana As String, ByVal vLokasi As String, ByVal vBuka As Integer, ByVal vTutup As Integer, ByVal vNamaMakanan As String, ByVal vKoordinat As String, ByVal vKelompokMakanan As String)

        NamaResto = vNamaResto
        JenisMakanan = vJenisMakanan
        WaktuBuka = vWaktuBuka
        Khas = vKhas
        Budget = vBudget
        Suasana = vSuasana
        Lokasi = vLokasi
        Buka = vBuka
        Tutup = vTutup
        NamaMakanan = vNamaMakanan
        Koordinat = vKoordinat
        KelompokMakanan = vKelompokMakanan
    End Sub
End Class
