Imports System.Windows.Forms

Public Class PengaturanNilaiKriteria

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DaftarKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetDani.Kelompok_Makanan' table. You can move, or remove it, as needed.
        Me.Kelompok_MakananTableAdapter.Fill(Me.DataSetDani.Kelompok_Makanan)
        'TODO: This line of code loads data into the 'DataSetDani.KonfigurasiKriteria' table. You can move, or remove it, as needed.
        Me.KonfigurasiKriteriaTableAdapter.Fill(Me.DataSetDani.KonfigurasiKriteria)
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

    End Sub

    Private Sub Jenis_MakananBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jenis_MakananBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Jenis_MakananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)

        Me.Validate()
        Me.KonfigurasiKriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.Validate()
        Me.Waktu_BukaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Me.Validate()
        Me.KhasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        Me.Validate()
        Me.SuasanaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton28.Click
        Me.Validate()
        Me.FasilitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton35.Click
        Me.Validate()
        Me.KonfigurasiKriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub

    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton29.Click
        Me.Validate()
        Me.KonfigurasiKriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDani)
    End Sub
End Class
