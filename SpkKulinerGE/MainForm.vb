Imports EARTHLib
Imports System.Data.Odbc
Imports System.IO

Public Class MainForm
    Private ar As ArrayList
    Private hitAr As SortedList
    Private sortedHit As ArrayList
    Private daftarKriteria As ArrayList
    Private fasilitasSkor As New SortedList(10)
    Private NilaiUntukBudgetSdHarga As Integer
    Private RangeHargaBudget As Integer
    Private SelisihNilaiBudget As Integer
    Private RentangRadius As Integer
    Private SelisihNilaiRadius As Integer
    Private NilaiKm1 As Integer
    Private p As PointOnTerrainGE
    Private pResto As PointOnTerrainGE
    Private penentuanLokasi As Boolean = False
    Private bPenentuanLokasiResto As Boolean
    'Private maksimalSkor As Integer
    Private maksimalSkor As Single
    'kelompok makanan
    Private NilaiUntukJenisMakananSama As String
    Private NilaiUntukJenisMakananSatuKelompok As String
    Private NilaiUntukJenisMakananLainKelompok As String

    Public Property PenentuanLokasiResto() As Boolean
        Get
            Return bPenentuanLokasiResto
        End Get
        Set(ByVal value As Boolean)
            If value Then
                lblPenentuanLokasiResto.Visible = True
                btnPenentuanLokasiResto.Visible = True
            Else
                lblPenentuanLokasiResto.Visible = False
                btnPenentuanLokasiResto.Visible = False
            End If
            bPenentuanLokasiResto = value
        End Set
    End Property

    Private Enum EnumJenisKriteria
        JenisMakanan
        WaktuBuka
        Khas
        Budget
        Suasana
        Fasilitas
        Lokasi
    End Enum
    Private Function cariFitur(ByVal f As FeatureGE, ByVal fitur As String) As Integer
        Dim c As FeatureCollectionGE
        Dim i As Integer

        c = f.GetChildren()
        For i = 1 To c.Count

            If c(i).Name = fitur Then

                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub managerLayer(ByVal Checked As Boolean, ByVal layerName As String, ByVal kmlName As String)
        Dim ifitur As Integer
        If Checked Then
            ifitur = cariFitur(AxGEPluginX1.ApplicationGE.GetMyPlaces(), layerName)
            If ifitur = -1 Then
                AxGEPluginX1.ApplicationGE.OpenKmlFile(kmlName, 1)
            Else

                AxGEPluginX1.ApplicationGE.GetMyPlaces().GetChildren(ifitur).Visibility = True
                AxGEPluginX1.ApplicationGE.GetMyPlaces().GetChildren(ifitur).Highlight()
            End If
        Else

            ifitur = cariFitur(AxGEPluginX1.ApplicationGE.GetMyPlaces(), layerName)
            AxGEPluginX1.ApplicationGE.GetMyPlaces().GetChildren(ifitur).Visibility = False
        End If
    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        sesuaikanPeran()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSetDani.Resto' table. You can move, or remove it, as needed.
        Me.RestoTableAdapter.Fill(Me.DataSetDani.Resto)
        'TODO: This line of code loads data into the 'DataSetDani.Tujuan' table. You can move, or remove it, as needed.
        'Me.TujuanTableAdapter.Fill(Me.DataSetDani.Tujuan)
        'TODO: This line of code loads data into the 'DataSetDani.Lokasi' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSetDani.Fasilitas' table. You can move, or remove it, as needed.
        Me.FasilitasTableAdapter.Fill(Me.DataSetDani.Fasilitas)
        'TODO: This line of code loads data into the 'DataSetDani.Suasana' table. You can move, or remove it, as needed.
        Me.SuasanaTableAdapter.Fill(Me.DataSetDani.Suasana)
        'TODO: This line of code loads data into the 'DataSetDani.Khas' table. You can move, or remove it, as needed.
        Me.KhasTableAdapter.Fill(Me.DataSetDani.Khas)
        'TODO: This line of code loads data into the 'DataSetDani.Waktu_Buka' table. You can move, or remove it, as needed.
        Me.Waktu_BukaTableAdapter.Fill(Me.DataSetDani.Waktu_Buka)
        'TODO: This line of code loads data into the 'DataSetDani.Jenis_Makanan' table. You can move, or remove it, as needed.
        Me.Jenis_MakananTableAdapter.Fill(Me.DataSetDani.Jenis_Makanan)

        If con.State = ConnectionState.Closed Then con.Open()
        Dim sql As String
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader


        sql = "select fasilitas from fasilitas order by fasilitas"
        cmd = New OdbcCommand(sql, con)
        dr = cmd.ExecuteReader
        FasilitasCheckedListBox.Items.Clear()
        fasilitasSkor.Clear()
        While dr.Read
            FasilitasCheckedListBox.Items.Add(dr.GetString(0))
            fasilitasSkor.Add(dr.GetString(0), 0)
        End While
        dr.Close()
        cmd.Dispose()


        CheckBoxFasilitas_CheckedChanged(Nothing, Nothing)
        CheckBoxJenisMakanan_CheckedChanged(Nothing, Nothing)
        CheckBoxKhas_CheckedChanged(Nothing, Nothing)
        CheckBoxMaksimumBudget_CheckedChanged(Nothing, Nothing)
        CheckBoxSuasana_CheckedChanged(Nothing, Nothing)
        CheckBoxWaktuBuka_CheckedChanged(Nothing, Nothing)
        CheckBoxTujuan_CheckedChanged(Nothing, Nothing)
        '        Waktu_BukaComboBox.SelectedIndex = 0


    End Sub
    Private Function AmbilNilaiKriteria(ByVal JenisKriteria As EnumJenisKriteria, ByVal Value As String) As Integer
        Dim sql As String = ""
        Select Case JenisKriteria
            'pakai kelompok makanan Case EnumJenisKriteria.JenisMakanan
            '   sql = "select nilai from [jenis makanan] where [jenis makanan]='" & Value & "'"
            Case EnumJenisKriteria.WaktuBuka
                sql = "select nilai from [waktu buka] where [jam]=" & Value
            Case EnumJenisKriteria.Khas
                sql = "select nilai from [khas] where [khas]='" & Value & "'"
            Case EnumJenisKriteria.Suasana
                sql = "select nilai from [suasana] where [suasana]='" & Value & "'"
            Case EnumJenisKriteria.Fasilitas
                sql = "select nilai from [fasilitas] where [fasilitas]='" & Value & "'"
        End Select

        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            If IsDBNull(dr.GetInt32(0)) Then
                Return 0
            Else
                Return dr.GetInt32(0)
            End If

        Else
            Return 0
        End If
        dr.Close()
        cmd.Dispose()
    End Function
    Private Function AmbilNilaiKriteriaLokasi(ByVal PointPusat As GEPoint, ByVal PointResto As GEPoint) As Double
        Dim distance As Double = PointPusat.findDistance(PointResto) 'fungsi ini kembaliannya 1,2,3,4.... dlm km
        Dim selisih As Double = distance - 1 'untuk tau selisih, tinggal kurangi -1 pada hasil distance itu....
        'If selisih < 0 Then selisih = 0
        selisih = Math.Ceiling(selisih)
        Dim nilai As Double = NilaiKm1 - (Math.Abs(selisih) * SelisihNilaiRadius) 'rumus berkurang 10 untuk setiap 1 km
        Return nilai
    End Function
    Private Function AmbilNilaiKriteriaBudget(ByVal expected As Integer, ByVal budget As Integer) As Integer
        If expected <= budget Then
            Return NilaiUntukBudgetSdHarga
            '        ElseIf expected < budget Then
            '           Return NilaiUntukBudgetSdHarga '+ ((budget - expected) / RangeHargaBudget)
        ElseIf expected > budget Then
            Return NilaiUntukBudgetSdHarga - ((budget - expected) / RangeHargaBudget)
        End If
    End Function
    Private Sub hitungSkorHitKriteria(ByVal ob As ClassResto, ByVal Checked As Boolean, ByVal Expected As String, ByVal Value As String, ByVal Bobot As Integer, ByVal JenisKriteria As EnumJenisKriteria)
        Dim obHit As ClassResto
        Dim Nilai As Integer
        If Checked Then
            If UCase(Expected) = UCase(Value) Then
                If hitAr.Item(ob.NamaResto) Is Nothing Then
                    hitAr.Add(ob.NamaResto, ob)
                End If
                obHit = hitAr.Item(ob.NamaResto)
                Nilai = AmbilNilaiKriteria(JenisKriteria, Value)
                obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)

                'obHit.Skor = maksimalSkor / 100
                '            obHit.Skor = (obHit.Skor + Bobot * Nilai) / (maksimalSkor * 100)
            End If
        End If
    End Sub
    Private Sub hitungSkorHitKriteriaJenisMakanan(ByVal ob As ClassResto, ByVal Checked As Boolean, ByVal Expected As String, ByVal Value As String, ByVal Bobot As Integer, ByVal JenisKriteria As EnumJenisKriteria, ByVal JenisMakanan As String)
        Dim obHit As ClassResto
        Dim Nilai As Integer
        If Checked Then
            Dim sql As String = "SELECT [Kelompok Makanan].[Nama Kelompok Makanan] FROM [Kelompok Makanan] INNER JOIN [Jenis Makanan] ON [Kelompok Makanan].[Nama Kelompok Makanan] = [Jenis Makanan].[Nama Kelompok Makanan] WHERE ((([Jenis Makanan].[Jenis Makanan])='" & Value & "'))"
            Dim cmd As OdbcCommand
            Dim dr As OdbcDataReader


            cmd = New OdbcCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Value = dr.GetString(0)
            Else
                Value = ""
            End If
            dr.Close()
            cmd.Dispose()



            If UCase(Expected) = UCase(Value) Then
                If hitAr.Item(ob.NamaResto) Is Nothing Then
                    hitAr.Add(ob.NamaResto, ob)
                End If
                obHit = hitAr.Item(ob.NamaResto)
                'setelah pakai kelompok makanan Nilai = AmbilNilaiKriteria(JenisKriteria, Value)
                'bobot = 100 jika sama, 80 jika satu kelompok dan 0 jika tidak satu kelompok
                If obHit.JenisMakanan = JenisMakanan Then
                    Nilai = NilaiUntukJenisMakananSama
                ElseIf obHit.KelompokMakanan = Expected Then
                    Nilai = NilaiUntukJenisMakananSatuKelompok
                Else
                    Nilai = NilaiUntukJenisMakananLainKelompok
                End If

                obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)

                'obHit.Skor = maksimalSkor / 100
                '            obHit.Skor = (obHit.Skor + Bobot * Nilai) / (maksimalSkor * 100)
            End If
        End If
    End Sub
    Private Sub hitungSkorHitKriteriaWaktu(ByVal ob As ClassResto, ByVal Checked As Boolean, ByVal Buka As Integer, ByVal Tutup As Integer, ByVal Value As Integer, ByVal Bobot As Integer, ByVal JenisKriteria As EnumJenisKriteria)
        Dim obHit As ClassResto
        Dim Nilai As Integer
        If Checked Then
            If Value >= Buka And Value <= Tutup Then
                If hitAr.Item(ob.NamaResto) Is Nothing Then
                    hitAr.Add(ob.NamaResto, ob)
                End If
                obHit = hitAr.Item(ob.NamaResto)
                Nilai = AmbilNilaiKriteria(JenisKriteria, Value)

                'obHit.Skor = (obHit.Skor + Bobot * Nilai) / maksimalSkor '* 100
                'obHit.Skor = maksimalSkor / 100
                obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)
            End If
        End If
    End Sub
    Private Sub hitungSkorHitLokasi(ByVal ob As ClassResto, ByVal Checked As Boolean, ByVal Bobot As Integer, ByVal JenisKriteria As EnumJenisKriteria)
        Dim obHit As ClassResto
        Dim Nilai As Double
        If Checked Then
            If hitAr.Item(ob.NamaResto) Is Nothing Then
                hitAr.Add(ob.NamaResto, ob)
            End If
            obHit = hitAr.Item(ob.NamaResto)
            Dim pusatPencarianGE As New GEPoint(p.Longitude & "," & p.Latitude)
            Dim tujuanGE As New GEPoint(ob.Koordinat)
            Nilai = AmbilNilaiKriteriaLokasi(pusatPencarianGE, tujuanGE) '* Bobot 'LokasiBobot.Value  'dikembangkan dari data spasial GE : lokasinya, ke pusat pencarian
            obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)
        End If
    End Sub
    Private Sub hitungSkorHitBudget(ByVal ob As ClassResto, ByVal Checked As Boolean, ByVal Expected As Integer, ByVal Value As Integer, ByVal Bobot As Integer, ByVal JenisKriteria As EnumJenisKriteria)
        Dim obHit As ClassResto
        Dim Nilai As Integer
        If Checked Then
            If Expected <= Value Then
                If hitAr.Item(ob.NamaResto) Is Nothing Then
                    hitAr.Add(ob.NamaResto, ob)
                End If
                obHit = hitAr.Item(ob.NamaResto)
                Nilai = AmbilNilaiKriteriaBudget(Expected, Value) 'dikembangkan dari data spasial GE
                'obHit.Skor = (obHit.Skor + Bobot * Nilai) / maksimalSkor '* 100
                
                'obHit.Skor = maksimalSkor / 100
                obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)
            End If
        End If
    End Sub
    Private Function hitungSkorHitFasilitas(ByVal ob As ClassResto) As Integer
        Dim i As Integer
        Dim sql As String = ""
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        Dim obHit As ClassResto
        Dim Nilai As Integer
        Dim Bobot As Integer

        If FasilitasCheckBox.Checked Then
            'Dim bobotSemua As Double

            'bobotSemua = FasilitasBobot.Value / FasilitasCheckedListBox.CheckedItems.Count
            'For i = 0 To fasilitasSkor.Count - 1
            '    fasilitasSkor.SetByIndex(i, bobotSemua)
            'Next
            For i = 0 To fasilitasSkor.Count - 1
                If FasilitasCheckedListBox.GetItemChecked(i) Then

                    sql = "SELECT Fasilitas.Nilai FROM Fasilitas INNER JOIN (Resto INNER JOIN RestoFasilitas ON Resto.ID = RestoFasilitas.[Nama Resto]) ON Fasilitas.Fasilitas = RestoFasilitas.Fasilitas WHERE (((Resto.[Nama Resto])='" & ob.NamaResto & "') AND ((RestoFasilitas.Fasilitas)='" & fasilitasSkor.GetKey(i) & "'))"
                    cmd = New OdbcCommand(sql, con)
                    dr = cmd.ExecuteReader


                    If dr.Read Then
                        If hitAr.Item(ob.NamaResto) Is Nothing Then
                            hitAr.Add(ob.NamaResto, ob)
                        End If
                        obHit = hitAr.Item(ob.NamaResto)

                        Nilai = dr.GetValue(0)
                        Bobot = fasilitasSkor.GetByIndex(i)
                        'obHit.Skor = (obHit.Skor + (Bobot * Nilai)) / maksimalSkor '* 100
                        'obHit.Skor = maksimalSkor / 100
                        obHit.Skor = (obHit.Skor + Bobot * Nilai) '/ (maksimalSkor * 100)
                    Else
                        Bobot = 0
                        Nilai = 0
                    End If

                    dr.Close()
                    cmd.Dispose()
                End If
            Next
        End If
    End Function
    Private Function ambilNilaiKonfigurasiKriteria() As Integer
        Dim sql As String = "SELECT KonfigurasiKriteria.[Nilai Untuk Budget Sd Harga], KonfigurasiKriteria.[Range Harga], KonfigurasiKriteria.[Selisih Nilai], KonfigurasiKriteria.[Rentang Radius (m)], KonfigurasiKriteria.[Selisih Nilai Radius], KonfigurasiKriteria.[Nilai KM 1], KonfigurasiKriteria.[Nilai Untuk Jenis Makanan Sama], KonfigurasiKriteria.[Nilai Untuk Jenis Makanan Satu Kelompok], KonfigurasiKriteria.[Nilai Untuk Jenis Makanan Lain Kelompok] FROM KonfigurasiKriteria"
        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        'persiapan jika mencari berdasarkan budget
        NilaiUntukBudgetSdHarga = 0
        RangeHargaBudget = 0
        SelisihNilaiBudget = 0

        'persiapan jika mencari berdasarkan lokasi
        RentangRadius = 0
        SelisihNilaiRadius = 0

        'persiapan nilai standar untuk jenis makanan
        NilaiUntukJenisMakananSama = 100
        NilaiUntukJenisMakananSatuKelompok = 80
        NilaiUntukJenisMakananLainKelompok = 0

        If dr.Read Then
            'persiapan jika mencari berdasarkan budget
            NilaiUntukBudgetSdHarga = dr.GetValue(0)
            RangeHargaBudget = dr.GetValue(1)
            SelisihNilaiBudget = dr.GetValue(2)

            'persiapan jika mencari berdasarkan lokasi
            RentangRadius = dr.GetValue(3)
            SelisihNilaiRadius = dr.GetValue(4)
            NilaiKm1 = dr.GetValue(5)

            'kelompok makanan
            NilaiUntukJenisMakananSama = dr.GetValue(6)
            NilaiUntukJenisMakananSatuKelompok = dr.GetValue(7)
            NilaiUntukJenisMakananLainKelompok = dr.GetValue(8)

        End If

        cmd.Dispose()
    End Function
    Private Function konversiWaktu(ByVal d As DateTimePicker) As Integer
        If d.Value.Minute <= 30 Then
            Return d.Value.Hour
        Else
            Dim i As Integer = d.Value.Hour + 1
            If i >= 24 Then Return i - 24 Else Return i
        End If



    End Function
    Private Sub ButtonCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCari.Click
        timerMouse.Enabled = False
        TimerBobot.Enabled = False
        Dim i As Integer = 0
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader

        While i <= 1
            If ar Is Nothing Then
                ar = New ArrayList(100)
                managerLayer(True, "rumah_makan.shp", "c:\rumah_makan.kml")
                'Dim sql As String = "select [nama resto],[jenis makanan],[waktu buka],khas,harga,suasana,lokasi,[nama makanan],buka,tutup,koordinat from resto order by [nama resto]"
                Dim sql As String = "SELECT resto.[nama resto], resto.[jenis makanan], resto.[waktu buka], resto.khas, resto.harga, resto.suasana, resto.lokasi, resto.[nama makanan], resto.buka, resto.tutup, resto.koordinat, [Kelompok Makanan].[Nama Kelompok Makanan] FROM [Kelompok Makanan] INNER JOIN ([Jenis Makanan] INNER JOIN resto ON [Jenis Makanan].[Jenis Makanan] = resto.[Jenis Makanan]) ON [Kelompok Makanan].[Nama Kelompok Makanan] = [Jenis Makanan].[Nama Kelompok Makanan] ORDER BY resto.[nama resto]"

                cmd = New OdbcCommand(sql, con)
                dr = cmd.ExecuteReader


                Dim NamaResto As String
                Dim JenisMakanan As String
                Dim WaktuBuka As String
                Dim Khas As String
                Dim Harga As Integer
                Dim Suasana As String
                Dim Lokasi As String
                Dim Buka As Integer
                Dim Tutup As Integer
                Dim NamaMakanan As String
                Dim Koordinat As String
                Dim KelompokMakanan As String

                While dr.Read
                    If dr.IsDBNull(0) Then NamaResto = "" Else NamaResto = dr.GetString(0)
                    If dr.IsDBNull(1) Then JenisMakanan = "" Else JenisMakanan = dr.GetString(1)
                    If dr.IsDBNull(2) Then WaktuBuka = "" Else WaktuBuka = dr.GetString(2) '
                    If dr.IsDBNull(3) Then Khas = "" Else Khas = dr.GetString(3)
                    If dr.IsDBNull(4) Then Harga = 0 Else Harga = dr.GetInt32(4)
                    If dr.IsDBNull(5) Then Suasana = "" Else Suasana = dr.GetString(5)
                    If dr.IsDBNull(6) Then Lokasi = "" Else Lokasi = dr.GetString(6)
                    If dr.IsDBNull(7) Then NamaMakanan = "" Else NamaMakanan = dr.GetString(7)
                    If dr.IsDBNull(8) Then Buka = 0 Else Buka = dr.GetInt32(8)
                    If dr.IsDBNull(9) Then Tutup = 0 Else Tutup = dr.GetInt32(9)
                    If dr.IsDBNull(10) Then Koordinat = "" Else Koordinat = dr.GetString(10)
                    If dr.IsDBNull(11) Then KelompokMakanan = "" Else KelompokMakanan = dr.GetString(11)

                    'TODO : TAMBAHKAN NAMA MAKANAN DI CLASSRESTO
                    ar.Add(New ClassResto(NamaResto, _
                                          JenisMakanan, _
                                          WaktuBuka, _
                                          Khas, _
                                          Harga, _
                                          Suasana, _
                                          Lokasi, Buka, Tutup, NamaMakanan, Koordinat, KelompokMakanan))
                End While

                dr.Close()
                cmd.Dispose()
            End If
            Debug.Print("Jumlah array " & ar.Count)
            'ok, ambil dari basisdata konfigurasi kriteria


            Dim nTotalBobot As Integer = TotalBobotDanSkorMaksimal()
            If nTotalBobot = 0 Then
                MessageBox.Show("Anda belum memilih kriteria pencarian. Silahkan pilih salah satu kriteria", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If nTotalBobot < 100 Then
                MessageBox.Show("Total bobot pencarian = " & nTotalBobot & "%, kurang sebesar " & 100 - nTotalBobot & "%." & vbCrLf & "Silahkan perbaiki kembali sampai mencapai 100%", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If nTotalBobot > 100 Then
                MessageBox.Show("Total bobot pencarian = " & nTotalBobot & "%, lebih sebesar " & nTotalBobot - 100 & "%." & vbCrLf & "Silahkan perbaiki kembali sampai mencapai 100%", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'INI YG BERUBAH TIAP KALI KITA HIT
            hitAr = New SortedList(100)
            Dim ob As ClassResto

            'NORMALKAN
            For Each ob In ar
                ob.Skor = 0
            Next


            Dim waktukonversi As Integer
            If WaktuBukaCheckBox.Checked Then
                waktukonversi = konversiWaktu(waktu_bukaComboBox)
            End If

            Dim ii As Integer

            'hitung skor masing2 resto
            For ii = 0 To ar.Count - 1
                '                For Each ob In ar
                ob = ar(ii)
                Debug.Print("bisa???")
                'ambil kelompok makanan dulu
                hitungSkorHitKriteriaJenisMakanan(ob, JenisMakananCheckBox.Checked, ob.KelompokMakanan, Jenis_MakananComboBox.Text, JenisMakananBobot.Value, EnumJenisKriteria.JenisMakanan, Jenis_MakananComboBox.Text)
                hitungSkorHitKriteria(ob, KhasCheckBox.Checked, ob.Khas, KhasComboBox.Text, KhasBobot.Value, EnumJenisKriteria.Khas)
                hitungSkorHitKriteriaWaktu(ob, WaktuBukaCheckBox.Checked, ob.Buka, ob.Tutup, waktukonversi, WaktuBukaBobot.Value, EnumJenisKriteria.WaktuBuka)
                hitungSkorHitBudget(ob, BudgetCheckBox.Checked, ob.Budget, BudgetTextBox.Value, BudgetBobot.Value, EnumJenisKriteria.Budget)
                hitungSkorHitKriteria(ob, SuasanaCheckBox.Checked, ob.Suasana, SuasanaComboBox.Text, SuasanaBobot.Value, EnumJenisKriteria.Suasana)
                hitungSkorHitLokasi(ob, LokasiCheckBox.Checked, LokasiBobot.Value, EnumJenisKriteria.Lokasi)
                hitungSkorHitFasilitas(ob)
            Next
            BatasMaks.Value = hitAr.Count
            setupGrid() '--> SET NAMA KOLOM PADA TABEL !!!
            fillGrid()

            JumlahPencarianLabel.Text = hitAr.Count
            i = i + 1

        End While
        timerMouse.Enabled = True
        TimerBobot.Enabled = True
    End Sub
    Private Sub Sort(ByVal s As SortedList)

    End Sub
    Private Sub fillGrid()
        Dim i As Integer
        Dim j As Integer = 0
        Dim s As String = ""
        Dim ss As String = ""
        Dim ob As ClassResto


        With DataGridView1
            Dim batas As Integer = BatasMaks.Value

            If hitAr.Count < batas Then
                batas = hitAr.Count
                .RowCount = batas
            ElseIf hitAr.Count = 0 Then
                .RowCount = 0
            Else
                .RowCount = batas
            End If

            For i = 0 To batas - 1
                ob = hitAr.GetByIndex(i)
                If ob.Skor > 0 Then
                    'If ob.Skor = 0 Then Continue For
                    '.Rows(i).Cells(0).Value = i + 1
                    .Rows(i).Cells(0).Value = ob.NamaResto
                    j = 1
                    For Each s In daftarKriteria
                        If s = "Jenis Makanan" Then
                            ss = ob.JenisMakanan
                        ElseIf s = "Waktu Buka" Then
                            ss = ob.Buka & " sd " & ob.Tutup
                        ElseIf s = "Khas" Then
                            ss = ob.Khas
                        ElseIf s = "Budget" Then
                            ss = CStr(ob.Budget)
                        ElseIf s = "Suasana" Then
                            ss = ob.Suasana
                        ElseIf s = "Lokasi" Then
                            ss = ob.Lokasi
                        ElseIf s = "Fasilitas" Then
                            Dim sql As String = "SELECT Fasilitas.Fasilitas FROM Resto INNER JOIN (Fasilitas INNER JOIN RestoFasilitas ON Fasilitas.Fasilitas = RestoFasilitas.Fasilitas) ON Resto.ID = RestoFasilitas.[Nama Resto] WHERE (((Resto.[Nama Resto])='" & ob.NamaResto & "'))"
                            Dim cmd As New OdbcCommand(sql, con)
                            Dim dr As OdbcDataReader = cmd.ExecuteReader
                            Dim f As String = ""
                            If dr.HasRows Then
                                While dr.Read
                                    f = f & dr.GetString(0) & ","
                                End While
                                f = f.Substring(0, f.Length - 1)

                            Else
                                f = "Tidak tersedia"
                            End If
                            dr.Close()
                            cmd.Dispose()
                            ss = f

                        End If
                        .Rows(i).Cells(j).Value = ss
                        j = j + 1
                    Next
                    .Rows(i).Cells(j).Value = CInt(ob.Skor / (maksimalSkor)) 'FormatPercent(ob.Skor, 2)
                End If

            Next
            .Sort(.Columns(.ColumnCount - 1), System.ComponentModel.ListSortDirection.Descending)
            If .RowCount > 0 Then .Rows(0).Selected = True

        End With
    End Sub
    Private Sub setupGrid()
        Dim s As String
        Dim i As Integer
        With DataGridView1
            .Columns.Clear()
            .ColumnCount = daftarKriteria.Count + 2 'nama resto dan skor
            '.Columns(0).Name = "No."
            '.Columns(0).Width = 50
            .Columns(0).Name = "Nama Resto"
            i = 1
            For Each s In daftarKriteria
                .Columns(i).Name = s
                i = i + 1
            Next
            .Columns(i).Name = "Ranking (persen)"
        End With
    End Sub
    Private Function TotalBobotDanSkorMaksimal() As Integer
        Dim nTotalBobot As Integer = 0
        'Dim f As DictionaryEntry
        ambilNilaiKonfigurasiKriteria()
        maksimalSkor = 0
        daftarKriteria = New ArrayList(7)
        If JenisMakananCheckBox.Checked Then
            nTotalBobot = nTotalBobot + JenisMakananBobot.Value
            'maksimalSkor = maksimalSkor + JenisMakananBobot.Value * AmbilNilaiKriteria(EnumJenisKriteria.JenisMakanan, Jenis_MakananComboBox.Text)
            'sebelum kelompok makanan maksimalSkor = maksimalSkor + (JenisMakananBobot.Value / 100) * AmbilNilaiKriteria(EnumJenisKriteria.JenisMakanan, Jenis_MakananComboBox.Text)
            maksimalSkor = maksimalSkor + (JenisMakananBobot.Value / 100) * NilaiUntukJenisMakananSama  'AmbilNilaiKriteria(EnumJenisKriteria.JenisMakanan, Jenis_MakananComboBox.Text)
            daftarKriteria.Add("Jenis Makanan")
        End If

        If WaktuBukaCheckBox.Checked Then
            nTotalBobot = nTotalBobot + WaktuBukaBobot.Value
            'maksimalSkor = maksimalSkor + WaktuBukaBobot.Value * AmbilNilaiKriteria(EnumJenisKriteria.WaktuBuka, Waktu_BukaComboBox.Text)
            maksimalSkor = maksimalSkor + (WaktuBukaBobot.Value / 100) * AmbilNilaiKriteria(EnumJenisKriteria.WaktuBuka, konversiWaktu(waktu_bukaComboBox))
            daftarKriteria.Add("Waktu Buka")
        End If

        If KhasCheckBox.Checked Then
            nTotalBobot = nTotalBobot + KhasBobot.Value
            'maksimalSkor = maksimalSkor + WaktuBukaBobot.Value * AmbilNilaiKriteria(EnumJenisKriteria.WaktuBuka, Waktu_BukaComboBox.Text)
            maksimalSkor = maksimalSkor + (KhasBobot.Value / 100) * AmbilNilaiKriteria(EnumJenisKriteria.Khas, KhasComboBox.Text)
            daftarKriteria.Add("Khas")
        End If

        If BudgetCheckBox.Checked Then
            nTotalBobot = nTotalBobot + BudgetBobot.Value
            'maksimalSkor = maksimalSkor + NilaiUntukBudgetSdHarga * BudgetBobot.Value
            maksimalSkor = maksimalSkor + NilaiUntukBudgetSdHarga * (BudgetBobot.Value / 100)
            daftarKriteria.Add("Budget")
        End If

        If SuasanaCheckBox.Checked Then
            nTotalBobot = nTotalBobot + SuasanaBobot.Value
            'maksimalSkor = maksimalSkor + SuasanaBobot.Value * AmbilNilaiKriteria(EnumJenisKriteria.Suasana, SuasanaComboBox.Text)
            maksimalSkor = maksimalSkor + (SuasanaBobot.Value / 100) * AmbilNilaiKriteria(EnumJenisKriteria.Suasana, SuasanaComboBox.Text)
            daftarKriteria.Add("Suasana")
        End If

        If LokasiCheckBox.Checked Then
            nTotalBobot = nTotalBobot + LokasiBobot.Value
            maksimalSkor = maksimalSkor + (NilaiKm1 * LokasiBobot.Value / 100)
            daftarKriteria.Add("Lokasi")
        End If

        Dim i As Integer = 0
        Dim sql As String
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        Dim totalBobotFasilitas As Integer = 0
        If FasilitasCheckBox.Checked Then
            daftarKriteria.Add("Fasilitas")
            For i = 0 To fasilitasSkor.Count - 1
                If FasilitasCheckedListBox.GetItemChecked(i) Then
                    sql = "SELECT Nilai FROM Fasilitas Where Fasilitas='" & FasilitasCheckedListBox.Items(i).ToString & "'"
                    cmd = New OdbcCommand(sql, con)
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        nTotalBobot = nTotalBobot + fasilitasSkor.GetByIndex(i)
                        maksimalSkor = maksimalSkor + fasilitasSkor.GetByIndex(i) * dr.GetInt32(0) / 100
                    End If
                End If
            Next
        End If
        'nTotalBobot = maksimalSkor
        Text = maksimalSkor
        Return nTotalBobot
    End Function
    Private Sub RestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoToolStripMenuItem.Click
        DaftarResto.ShowDialog()
        ar = Nothing
        MainForm_Load(Nothing, Nothing)
    End Sub
    Private Sub sesuaikanPeran()
        LoginToolStripMenuItem.Enabled = True
        RestoToolStripMenuItem.Enabled = False
        KriteriaToolStripMenuItem.Enabled = False
        'ToolHapus.Enabled = False
        'ToolTambah.Enabled = False
        'ToolUbah.Enabled = False
        If Peran = "Administrator" Then
            LoginToolStripMenuItem.Text = "&Logout"
            RestoToolStripMenuItem.Enabled = True
            KriteriaToolStripMenuItem.Enabled = True
            'ToolHapus.Enabled = True
            'ToolTambah.Enabled = True
            'ToolUbah.Enabled = True
        End If
    End Sub
    Public Sub Logout()
        Peran = "Guest"
        sesuaikanPeran()
        LoginToolStripMenuItem.Text = "&Login"
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "&Login" Then
            LoginForm.ShowDialog()
            If Peran.ToUpper.Equals("ADMINISTRATOR") Then
                'MenuAdmin.Show()
            End If
        Else
            Logout()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub CheckBoxJenisMakanan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisMakananCheckBox.CheckedChanged
        If JenisMakananCheckBox.Checked Then
            Jenis_MakananComboBox.Enabled = True
            JenisMakananBobot.Enabled = True
        Else
            Jenis_MakananComboBox.Enabled = False
            JenisMakananBobot.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxWaktuBuka_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaktuBukaCheckBox.CheckedChanged
        If WaktuBukaCheckBox.Checked Then
            Waktu_BukaComboBox.Enabled = True
            WaktuBukaBobot.Enabled = True
        Else
            Waktu_BukaComboBox.Enabled = False
            WaktuBukaBobot.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxKhas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KhasCheckBox.CheckedChanged
        If KhasCheckBox.Checked Then
            KhasComboBox.Enabled = True
            KhasBobot.Enabled = True
        Else
            KhasComboBox.Enabled = False
            KhasBobot.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxMaksimumBudget_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BudgetCheckBox.CheckedChanged
        If BudgetCheckBox.Checked Then
            BudgetTextBox.Enabled = True
            BudgetBobot.Enabled = True
        Else
            BudgetTextBox.Enabled = False
            BudgetBobot.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxSuasana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuasanaCheckBox.CheckedChanged
        If SuasanaCheckBox.Checked Then
            SuasanaComboBox.Enabled = True
            SuasanaBobot.Enabled = True
        Else
            SuasanaComboBox.Enabled = False
            SuasanaBobot.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxFasilitas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FasilitasCheckBox.CheckedChanged
        If FasilitasCheckBox.Checked Then
            FasilitasCheckedListBox.Enabled = True
            FasilitasBobot.Enabled = True
        Else
            FasilitasCheckedListBox.Enabled = False
            FasilitasBobot.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxTujuan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LokasiCheckBox.CheckedChanged
        If LokasiCheckBox.Checked Then
            LokasiBobot.Enabled = True
            ButtonPusat.Enabled = True
            'penentuanLokasi = True
            'MessageBox.Show("Tekan Tombol ENTER jika sudah menemukan lokasi yang diinginkan", "Penentuan Lokasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Cursor = Cursors.Cross
        Else
            ButtonPusat.Enabled = False
            FasilitasCheckedListBox.Enabled = False
            LokasiBobot.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        timerMouse.Enabled = True
    End Sub
    Public Function SaveTextToFile(ByVal strData As String, _
  ByVal FullPath As String, _
    Optional ByVal ErrInfo As String = "") As Boolean


        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try


            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function


    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Dim namaResto As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim sql As String = "select [nama resto],koordinat from resto where [nama resto]='" & namaResto & "'"
        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        '        Me.Text = sql
        If Not dr.HasRows Then
            MessageBox.Show("Data Resto ini tidak ada", "Fly To", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        dr.Read()

        If dr.IsDBNull(1) Then
            MessageBox.Show("Koordinat Data Resto ini belum tersedia. Silahkan coba pada data resto yang lain", "Fly To", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        flyTo(dr.GetString(0), dr.GetString(1))


    End Sub
    Private Sub FlyTo(ByVal nama As String, ByVal koordinat As String)
        Dim flyTo As String = "<kml xmlns=""http://earth.google.com/kml/2.1""><Document><name>" & nama & "</name><Folder><name>Search</name><Placemark><name>" & nama & "</name><Style id=""style""><IconStyle><scale>1.06364</scale><Icon><href>http://maps.google.com/mapfiles/kml/pal2/icon2.png</href></Icon></IconStyle><LabelStyle><color>ff00ffff</color><scale>0.9</scale></LabelStyle></Style><styleUrl>#style</styleUrl><Point><coordinates>" & koordinat & "</coordinates></Point></Placemark></Folder></Document></kml>"
        SaveTextToFile(flyTo, "c:\resto.kml")
        AxGEPluginX1.openFile("c:\resto.kml")
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FasilitasCheckedListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FasilitasCheckedListBox.SelectedIndexChanged
        FasilitasBobot.Value = fasilitasSkor.GetByIndex(FasilitasCheckedListBox.SelectedIndex)
    End Sub

    Private Sub FasilitasCheckedListBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FasilitasCheckedListBox.SelectedValueChanged
        FasilitasBobot.Value = fasilitasSkor(FasilitasCheckedListBox.Items(FasilitasCheckedListBox.SelectedIndex))
    End Sub

    Private Sub FasilitasBobot_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FasilitasBobot.ValueChanged
        fasilitasSkor(FasilitasCheckedListBox.Items(FasilitasCheckedListBox.SelectedIndex)) = FasilitasBobot.Value
    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        PengaturanNilaiKriteria.ShowDialog()
        MainForm_Load(Nothing, Nothing)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerMouse.Tick
        'Dim px As Integer
        'Dim py As Integer
        'px = 0
        'py = 0
        p = AxGEPluginX1.ApplicationGE.GetPointOnTerrainFromScreenCoords(0, 0)
        'Debug.Print(p.Altitude & "," & p.Longitude)
        'pnlAtas.Visible = Not pnlAtas.Visible
    End Sub

    Private Sub MainForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If penentuanLokasi Then
            If e.KeyCode = Keys.Enter Then
                'penentuanLokasi = False
                'FlyTo("Pusat Pencarian", p.Longitude & "," & p.Latitude)
                'Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    
    Private Sub ButtonPusat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPusat.Click
        'penentuanLokasi = False
        timerMouse.Enabled = False
        FlyTo("Pusat Pencarian", p.Longitude & "," & p.Latitude)
        'MessageBox.Show(p.Longitude & "," & p.Latitude)
        timerMouse.Enabled = True
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPenentuanLokasiResto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenentuanLokasiResto.Click
        pResto = AxGEPluginX1.ApplicationGE.GetPointOnTerrainFromScreenCoords(0, 0)
        DaftarResto.LokasiResto = pResto
        DaftarResto.Visible = True

    End Sub

    Private Sub TimerBobot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBobot.Tick
        Dim i As Integer
        Dim total As Integer
        total = 0
        For i = 0 To fasilitasSkor.Count - 1
            If FasilitasCheckedListBox.GetItemChecked(i) Then total = fasilitasSkor.GetByIndex(i) + total
        Next
        lblTotal.Text = total
    End Sub

    
End Class
