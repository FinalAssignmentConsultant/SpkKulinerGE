Imports System.Windows.Forms
Imports EARTHLib
Imports System.Data.Odbc

Public Class DaftarResto
    Public LokasiResto As PointOnTerrainGE
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RestoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)

    End Sub

    Private Sub DaftarResto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If MainForm.PenentuanLokasiResto Then
            MainForm.PenentuanLokasiResto = False
            Me.KoordinatTextBox.Text = LokasiResto.Longitude & "," & LokasiResto.Latitude
        End If
    End Sub

    Private Sub DaftarResto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        Dim Sql As String = "select fasilitas from fasilitas order by fasilitas"
        cmd = New OdbcCommand(Sql, con)
        dr = cmd.ExecuteReader
        FasilitasCheckedListBox.Items.Clear()
        ' fasilitasSkor.Clear()
        While dr.Read
            FasilitasCheckedListBox.Items.Add(dr.GetString(0))
            '    fasilitasSkor.Add(dr.GetString(0), 0)
        End While
        dr.Close()
        cmd.Dispose()

        'TODO: This line of code loads data into the 'DataSetDani.Kelurahan' table. You can move, or remove it, as needed.
        'Me.KelurahanTableAdapter.Fill(Me.DataSetDani.Kelurahan)
        'TODO: This line of code loads data into the 'DataSetDani.Kecamatan' table. You can move, or remove it, as needed.
        'Me.KecamatanTableAdapter.Fill(Me.DataSetDani.Kecamatan)
        'TODO: This line of code loads data into the 'DataSetDani.Waktu_Buka' table. You can move, or remove it, as needed.
        Me.Waktu_BukaTableAdapter.Fill(Me.DataSetDani.Waktu_Buka)
        'TODO: This line of code loads data into the 'DataSetDani.Suasana' table. You can move, or remove it, as needed.
        Me.SuasanaTableAdapter.Fill(Me.DataSetDani.Suasana)
        'TODO: This line of code loads data into the 'DataSetDani.Khas' table. You can move, or remove it, as needed.
        Me.KhasTableAdapter.Fill(Me.DataSetDani.Khas)
        'TODO: This line of code loads data into the 'DataSetDani.Jenis_Makanan' table. You can move, or remove it, as needed.
        Me.Jenis_MakananTableAdapter.Fill(Me.DataSetDani.Jenis_Makanan)
        'TODO: This line of code loads data into the 'DataSetDani.Resto' table. You can move, or remove it, as needed.
        Me.RestoTableAdapter.Fill(Me.DataSetDani.Resto)

       

       
    End Sub

    Private Sub btnTentukanLokasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentukanLokasi.Click
        MainForm.PenentuanLokasiResto = True
        'RestoBindingNavigatorSaveItem_Click(Nothing, Nothing)
        Visible = False
        MainForm.Focus()
    End Sub

    Private Sub RestoBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles RestoBindingSource.BindingComplete
        For i = 0 To FasilitasCheckedListBox.Items.Count - 1
            FasilitasCheckedListBox.SetItemChecked(i, False)
        Next

    End Sub
    Private Sub fillResto()
        Dim NamaResto As String = Nama_RestoTextBox.Text
        Dim Fasilitas As String
        Dim cmd As OdbcCommand
        Dim dr As OdbcDataReader
        Dim i As Integer
        Dim Sql As String

        For i = 0 To FasilitasCheckedListBox.Items.Count - 1
            Fasilitas = FasilitasCheckedListBox.Items(i)

            Sql = "SELECT Fasilitas.Nilai,Fasilitas.Fasilitas FROM Fasilitas INNER JOIN (Resto INNER JOIN RestoFasilitas ON Resto.ID = RestoFasilitas.[Nama Resto]) ON Fasilitas.Fasilitas = RestoFasilitas.Fasilitas WHERE (((Resto.[Nama Resto])='" & NamaResto & "') AND ((RestoFasilitas.Fasilitas)='" & Fasilitas & "'))"


            cmd = New OdbcCommand(Sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                FasilitasCheckedListBox.SetItemChecked(i, True)
            End If
        Next
    End Sub
  

    Private Sub FasilitasCheckedListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FasilitasCheckedListBox.SelectedIndexChanged
        Dim fasilitas As String
        Dim sql As String
        Dim NamaResto As String = Nama_RestoTextBox.Text
        Dim iNamaResto As Integer

        sql = "select id from resto where [nama resto]='" & NamaResto & "'"
        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        iNamaResto = dr.GetInt32(0)



        fasilitas = FasilitasCheckedListBox.Text
        sql = "delete from RestoFasilitas where [Nama Resto]=" & iNamaResto & " and Fasilitas='" & fasilitas & "'"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        If FasilitasCheckedListBox.GetItemChecked(FasilitasCheckedListBox.SelectedIndex) Then
            sql = "insert into RestoFasilitas([Nama Resto],Fasilitas)values(" & iNamaResto & ",'" & fasilitas & "')"
            cmd.Dispose()
            cmd = New OdbcCommand(sql, con)
            cmd.ExecuteNonQuery()
        End If


    End Sub

    Private Sub RestoBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoBindingNavigator.RefreshItems
        fillResto()
    End Sub
End Class
