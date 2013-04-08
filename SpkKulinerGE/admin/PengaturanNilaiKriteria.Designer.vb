<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengaturanNilaiKriteria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Nilai_Untuk_Budget_Sd_HargaLabel As System.Windows.Forms.Label
        Dim Range_HargaLabel As System.Windows.Forms.Label
        Dim Selisih_NilaiLabel As System.Windows.Forms.Label
        Dim Selisih_Nilai_RadiusLabel As System.Windows.Forms.Label
        Dim Nilai_KM_1Label As System.Windows.Forms.Label
        Dim Nilai_Untuk_Jenis_Makanan_SamaLabel As System.Windows.Forms.Label
        Dim Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel As System.Windows.Forms.Label
        Dim Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel As System.Windows.Forms.Label
        Dim Nama_Kelompok_MakananLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PengaturanNilaiKriteria))
        Me.OK_Button = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox = New System.Windows.Forms.TextBox
        Me.KonfigurasiKriteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetDani = New SpkKulinerGE.DataSetDani
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox = New System.Windows.Forms.TextBox
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox = New System.Windows.Forms.TextBox
        Me.Jenis_MakananBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Jenis_MakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Jenis_MakananBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Jenis_MakananDataGridView = New System.Windows.Forms.DataGridView
        Me.Kelompok_MakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Waktu_BukaBindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Waktu_BukaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.Waktu_BukaDataGridView = New System.Windows.Forms.DataGridView
        Me.Jam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.KhasBindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.KhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton
        Me.KhasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.KonfigurasiKriteriaBindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton35 = New System.Windows.Forms.ToolStripButton
        Me.Selisih_NilaiTextBox = New System.Windows.Forms.TextBox
        Me.Range_HargaTextBox = New System.Windows.Forms.TextBox
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.SuasanaBindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton
        Me.SuasanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton
        Me.SuasanaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.FasilitasBindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton
        Me.FasilitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton27 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton28 = New System.Windows.Forms.ToolStripButton
        Me.FasilitasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.Nilai_KM_1NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton
        Me.Selisih_Nilai_RadiusNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton34 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton36 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton37 = New System.Windows.Forms.ToolStripButton
        Me.Nama_Kelompok_MakananTextBox = New System.Windows.Forms.TextBox
        Me.Kelompok_MakananDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jenis_MakananTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
        Me.TableAdapterManager = New SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
        Me.FasilitasTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.FasilitasTableAdapter
        Me.Kelompok_MakananTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Kelompok_MakananTableAdapter
        Me.KhasTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
        Me.KonfigurasiKriteriaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.KonfigurasiKriteriaTableAdapter
        Me.SuasanaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
        Me.Waktu_BukaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Nilai_Untuk_Budget_Sd_HargaLabel = New System.Windows.Forms.Label
        Range_HargaLabel = New System.Windows.Forms.Label
        Selisih_NilaiLabel = New System.Windows.Forms.Label
        Selisih_Nilai_RadiusLabel = New System.Windows.Forms.Label
        Nilai_KM_1Label = New System.Windows.Forms.Label
        Nilai_Untuk_Jenis_Makanan_SamaLabel = New System.Windows.Forms.Label
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel = New System.Windows.Forms.Label
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel = New System.Windows.Forms.Label
        Nama_Kelompok_MakananLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.KonfigurasiKriteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jenis_MakananBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Jenis_MakananBindingNavigator.SuspendLayout()
        CType(Me.Jenis_MakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jenis_MakananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kelompok_MakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Waktu_BukaBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Waktu_BukaBindingNavigator1.SuspendLayout()
        CType(Me.Waktu_BukaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waktu_BukaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.KhasBindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KhasBindingNavigator2.SuspendLayout()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.KonfigurasiKriteriaBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KonfigurasiKriteriaBindingNavigator1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SuasanaBindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuasanaBindingNavigator3.SuspendLayout()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuasanaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.FasilitasBindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FasilitasBindingNavigator4.SuspendLayout()
        CType(Me.FasilitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasilitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.Nilai_KM_1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Selisih_Nilai_RadiusNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Kelompok_MakananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nilai_Untuk_Budget_Sd_HargaLabel
        '
        Nilai_Untuk_Budget_Sd_HargaLabel.AutoSize = True
        Nilai_Untuk_Budget_Sd_HargaLabel.Location = New System.Drawing.Point(46, 39)
        Nilai_Untuk_Budget_Sd_HargaLabel.Name = "Nilai_Untuk_Budget_Sd_HargaLabel"
        Nilai_Untuk_Budget_Sd_HargaLabel.Size = New System.Drawing.Size(147, 13)
        Nilai_Untuk_Budget_Sd_HargaLabel.TabIndex = 0
        Nilai_Untuk_Budget_Sd_HargaLabel.Text = "Nilai Untuk Budget Sd Harga:"
        '
        'Range_HargaLabel
        '
        Range_HargaLabel.AutoSize = True
        Range_HargaLabel.Location = New System.Drawing.Point(46, 68)
        Range_HargaLabel.Name = "Range_HargaLabel"
        Range_HargaLabel.Size = New System.Drawing.Size(74, 13)
        Range_HargaLabel.TabIndex = 2
        Range_HargaLabel.Text = "Range Harga:"
        '
        'Selisih_NilaiLabel
        '
        Selisih_NilaiLabel.AutoSize = True
        Selisih_NilaiLabel.Location = New System.Drawing.Point(46, 94)
        Selisih_NilaiLabel.Name = "Selisih_NilaiLabel"
        Selisih_NilaiLabel.Size = New System.Drawing.Size(63, 13)
        Selisih_NilaiLabel.TabIndex = 4
        Selisih_NilaiLabel.Text = "Selisih Nilai:"
        '
        'Selisih_Nilai_RadiusLabel
        '
        Selisih_Nilai_RadiusLabel.AutoSize = True
        Selisih_Nilai_RadiusLabel.Location = New System.Drawing.Point(28, 65)
        Selisih_Nilai_RadiusLabel.Name = "Selisih_Nilai_RadiusLabel"
        Selisih_Nilai_RadiusLabel.Size = New System.Drawing.Size(118, 13)
        Selisih_Nilai_RadiusLabel.TabIndex = 2
        Selisih_Nilai_RadiusLabel.Text = "Selisih Nilai Radius/km:"
        '
        'Nilai_KM_1Label
        '
        Nilai_KM_1Label.AutoSize = True
        Nilai_KM_1Label.Location = New System.Drawing.Point(28, 42)
        Nilai_KM_1Label.Name = "Nilai_KM_1Label"
        Nilai_KM_1Label.Size = New System.Drawing.Size(143, 13)
        Nilai_KM_1Label.TabIndex = 7
        Nilai_KM_1Label.Text = "Nilai 1 KM pertama/terdekat:"
        '
        'Nilai_Untuk_Jenis_Makanan_SamaLabel
        '
        Nilai_Untuk_Jenis_Makanan_SamaLabel.AutoSize = True
        Nilai_Untuk_Jenis_Makanan_SamaLabel.Location = New System.Drawing.Point(6, 37)
        Nilai_Untuk_Jenis_Makanan_SamaLabel.Name = "Nilai_Untuk_Jenis_Makanan_SamaLabel"
        Nilai_Untuk_Jenis_Makanan_SamaLabel.Size = New System.Drawing.Size(167, 13)
        Nilai_Untuk_Jenis_Makanan_SamaLabel.TabIndex = 2
        Nilai_Untuk_Jenis_Makanan_SamaLabel.Text = "Nilai Untuk Jenis Makanan Sama:"
        '
        'Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel
        '
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.AutoSize = True
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.Location = New System.Drawing.Point(6, 61)
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.Name = "Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel"
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.Size = New System.Drawing.Size(212, 13)
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.TabIndex = 4
        Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel.Text = "Nilai Untuk Jenis Makanan Satu Kelompok:"
        '
        'Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel
        '
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.AutoSize = True
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.Location = New System.Drawing.Point(8, 83)
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.Name = "Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel"
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.Size = New System.Drawing.Size(210, 13)
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.TabIndex = 6
        Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel.Text = "Nilai Untuk Jenis Makanan Lain Kelompok:"
        '
        'Nama_Kelompok_MakananLabel
        '
        Nama_Kelompok_MakananLabel.AutoSize = True
        Nama_Kelompok_MakananLabel.Location = New System.Drawing.Point(6, 61)
        Nama_Kelompok_MakananLabel.Name = "Nama_Kelompok_MakananLabel"
        Nama_Kelompok_MakananLabel.Size = New System.Drawing.Size(136, 13)
        Nama_Kelompok_MakananLabel.TabIndex = 1
        Nama_Kelompok_MakananLabel.Text = "Nama Kelompok Makanan:"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(536, 345)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Tutup"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(12, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 310)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Nilai_Untuk_Jenis_Makanan_Lain_KelompokLabel)
        Me.TabPage1.Controls.Add(Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox)
        Me.TabPage1.Controls.Add(Nilai_Untuk_Jenis_Makanan_Satu_KelompokLabel)
        Me.TabPage1.Controls.Add(Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox)
        Me.TabPage1.Controls.Add(Nilai_Untuk_Jenis_Makanan_SamaLabel)
        Me.TabPage1.Controls.Add(Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox)
        Me.TabPage1.Controls.Add(Me.Jenis_MakananBindingNavigator)
        Me.TabPage1.Controls.Add(Me.Jenis_MakananDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Jenis Makanan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox
        '
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Nilai Untuk Jenis Makanan Lain Kelompok", True))
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox.Location = New System.Drawing.Point(224, 80)
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox.Name = "Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox"
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox.TabIndex = 7
        '
        'KonfigurasiKriteriaBindingSource
        '
        Me.KonfigurasiKriteriaBindingSource.DataMember = "KonfigurasiKriteria"
        Me.KonfigurasiKriteriaBindingSource.DataSource = Me.DataSetDani
        '
        'DataSetDani
        '
        Me.DataSetDani.DataSetName = "DataSetDani"
        Me.DataSetDani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox
        '
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Nilai Untuk Jenis Makanan Satu Kelompok", True))
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox.Location = New System.Drawing.Point(224, 54)
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox.Name = "Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox"
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox.TabIndex = 5
        '
        'Nilai_Untuk_Jenis_Makanan_SamaTextBox
        '
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Nilai Untuk Jenis Makanan Sama", True))
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox.Location = New System.Drawing.Point(224, 31)
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox.Name = "Nilai_Untuk_Jenis_Makanan_SamaTextBox"
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nilai_Untuk_Jenis_Makanan_SamaTextBox.TabIndex = 3
        '
        'Jenis_MakananBindingNavigator
        '
        Me.Jenis_MakananBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Jenis_MakananBindingNavigator.BindingSource = Me.Jenis_MakananBindingSource
        Me.Jenis_MakananBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Jenis_MakananBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Jenis_MakananBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Jenis_MakananBindingNavigatorSaveItem})
        Me.Jenis_MakananBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.Jenis_MakananBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Jenis_MakananBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Jenis_MakananBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Jenis_MakananBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Jenis_MakananBindingNavigator.Name = "Jenis_MakananBindingNavigator"
        Me.Jenis_MakananBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Jenis_MakananBindingNavigator.Size = New System.Drawing.Size(577, 25)
        Me.Jenis_MakananBindingNavigator.TabIndex = 2
        Me.Jenis_MakananBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Jenis_MakananBindingSource
        '
        Me.Jenis_MakananBindingSource.DataMember = "Jenis Makanan"
        Me.Jenis_MakananBindingSource.DataSource = Me.DataSetDani
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Jenis_MakananBindingNavigatorSaveItem
        '
        Me.Jenis_MakananBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Jenis_MakananBindingNavigatorSaveItem.Image = CType(resources.GetObject("Jenis_MakananBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Jenis_MakananBindingNavigatorSaveItem.Name = "Jenis_MakananBindingNavigatorSaveItem"
        Me.Jenis_MakananBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Jenis_MakananBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Jenis_MakananDataGridView
        '
        Me.Jenis_MakananDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Jenis_MakananDataGridView.AutoGenerateColumns = False
        Me.Jenis_MakananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Jenis_MakananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1})
        Me.Jenis_MakananDataGridView.DataSource = Me.Jenis_MakananBindingSource
        Me.Jenis_MakananDataGridView.Location = New System.Drawing.Point(6, 115)
        Me.Jenis_MakananDataGridView.Name = "Jenis_MakananDataGridView"
        Me.Jenis_MakananDataGridView.Size = New System.Drawing.Size(571, 163)
        Me.Jenis_MakananDataGridView.TabIndex = 0
        '
        'Kelompok_MakananBindingSource
        '
        Me.Kelompok_MakananBindingSource.DataMember = "Kelompok Makanan"
        Me.Kelompok_MakananBindingSource.DataSource = Me.DataSetDani
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Waktu_BukaBindingNavigator1)
        Me.TabPage4.Controls.Add(Me.Waktu_BukaDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(583, 284)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Waktu Buka"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Waktu_BukaBindingNavigator1
        '
        Me.Waktu_BukaBindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.Waktu_BukaBindingNavigator1.BindingSource = Me.Waktu_BukaBindingSource
        Me.Waktu_BukaBindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.Waktu_BukaBindingNavigator1.DeleteItem = Me.ToolStripButton2
        Me.Waktu_BukaBindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.Waktu_BukaBindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.Waktu_BukaBindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.Waktu_BukaBindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.Waktu_BukaBindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.Waktu_BukaBindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.Waktu_BukaBindingNavigator1.Name = "Waktu_BukaBindingNavigator1"
        Me.Waktu_BukaBindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.Waktu_BukaBindingNavigator1.Size = New System.Drawing.Size(583, 25)
        Me.Waktu_BukaBindingNavigator1.TabIndex = 3
        Me.Waktu_BukaBindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'Waktu_BukaBindingSource
        '
        Me.Waktu_BukaBindingSource.DataMember = "Waktu Buka"
        Me.Waktu_BukaBindingSource.DataSource = Me.DataSetDani
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'Waktu_BukaDataGridView
        '
        Me.Waktu_BukaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waktu_BukaDataGridView.AutoGenerateColumns = False
        Me.Waktu_BukaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Waktu_BukaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Jam, Me.DataGridViewTextBoxColumn4})
        Me.Waktu_BukaDataGridView.DataSource = Me.Waktu_BukaBindingSource
        Me.Waktu_BukaDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Waktu_BukaDataGridView.Name = "Waktu_BukaDataGridView"
        Me.Waktu_BukaDataGridView.Size = New System.Drawing.Size(577, 253)
        Me.Waktu_BukaDataGridView.TabIndex = 0
        '
        'Jam
        '
        Me.Jam.DataPropertyName = "Jam"
        Me.Jam.HeaderText = "Jam"
        Me.Jam.Name = "Jam"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nilai"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nilai"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.KhasBindingNavigator2)
        Me.TabPage2.Controls.Add(Me.KhasDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Khas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'KhasBindingNavigator2
        '
        Me.KhasBindingNavigator2.AddNewItem = Me.ToolStripButton8
        Me.KhasBindingNavigator2.BindingSource = Me.KhasBindingSource
        Me.KhasBindingNavigator2.CountItem = Me.ToolStripLabel2
        Me.KhasBindingNavigator2.DeleteItem = Me.ToolStripButton9
        Me.KhasBindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton14})
        Me.KhasBindingNavigator2.Location = New System.Drawing.Point(3, 3)
        Me.KhasBindingNavigator2.MoveFirstItem = Me.ToolStripButton10
        Me.KhasBindingNavigator2.MoveLastItem = Me.ToolStripButton13
        Me.KhasBindingNavigator2.MoveNextItem = Me.ToolStripButton12
        Me.KhasBindingNavigator2.MovePreviousItem = Me.ToolStripButton11
        Me.KhasBindingNavigator2.Name = "KhasBindingNavigator2"
        Me.KhasBindingNavigator2.PositionItem = Me.ToolStripTextBox2
        Me.KhasBindingNavigator2.Size = New System.Drawing.Size(577, 25)
        Me.KhasBindingNavigator2.TabIndex = 4
        Me.KhasBindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Add new"
        '
        'KhasBindingSource
        '
        Me.KhasBindingSource.DataMember = "Khas"
        Me.KhasBindingSource.DataSource = Me.DataSetDani
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Delete"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move first"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move next"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Save Data"
        '
        'KhasDataGridView
        '
        Me.KhasDataGridView.AutoGenerateColumns = False
        Me.KhasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KhasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.KhasDataGridView.DataSource = Me.KhasBindingSource
        Me.KhasDataGridView.Location = New System.Drawing.Point(6, 31)
        Me.KhasDataGridView.Name = "KhasDataGridView"
        Me.KhasDataGridView.Size = New System.Drawing.Size(571, 247)
        Me.KhasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Khas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Khas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 400
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nilai"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nilai"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.KonfigurasiKriteriaBindingNavigator1)
        Me.TabPage6.Controls.Add(Selisih_NilaiLabel)
        Me.TabPage6.Controls.Add(Me.Selisih_NilaiTextBox)
        Me.TabPage6.Controls.Add(Range_HargaLabel)
        Me.TabPage6.Controls.Add(Me.Range_HargaTextBox)
        Me.TabPage6.Controls.Add(Nilai_Untuk_Budget_Sd_HargaLabel)
        Me.TabPage6.Controls.Add(Me.Nilai_Untuk_Budget_Sd_HargaTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(583, 284)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Budget"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'KonfigurasiKriteriaBindingNavigator1
        '
        Me.KonfigurasiKriteriaBindingNavigator1.AddNewItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.BindingSource = Me.KhasBindingSource
        Me.KonfigurasiKriteriaBindingNavigator1.CountItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.DeleteItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton35})
        Me.KonfigurasiKriteriaBindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.KonfigurasiKriteriaBindingNavigator1.MoveFirstItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.MoveLastItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.MoveNextItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.MovePreviousItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.Name = "KonfigurasiKriteriaBindingNavigator1"
        Me.KonfigurasiKriteriaBindingNavigator1.PositionItem = Nothing
        Me.KonfigurasiKriteriaBindingNavigator1.Size = New System.Drawing.Size(583, 25)
        Me.KonfigurasiKriteriaBindingNavigator1.TabIndex = 6
        Me.KonfigurasiKriteriaBindingNavigator1.Text = "BindingNavigator2"
        '
        'ToolStripButton35
        '
        Me.ToolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton35.Image = CType(resources.GetObject("ToolStripButton35.Image"), System.Drawing.Image)
        Me.ToolStripButton35.Name = "ToolStripButton35"
        Me.ToolStripButton35.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton35.Text = "Save Data"
        '
        'Selisih_NilaiTextBox
        '
        Me.Selisih_NilaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Selisih Nilai", True))
        Me.Selisih_NilaiTextBox.Location = New System.Drawing.Point(218, 94)
        Me.Selisih_NilaiTextBox.Name = "Selisih_NilaiTextBox"
        Me.Selisih_NilaiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Selisih_NilaiTextBox.TabIndex = 5
        '
        'Range_HargaTextBox
        '
        Me.Range_HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Range Harga", True))
        Me.Range_HargaTextBox.Location = New System.Drawing.Point(218, 68)
        Me.Range_HargaTextBox.Name = "Range_HargaTextBox"
        Me.Range_HargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Range_HargaTextBox.TabIndex = 3
        '
        'Nilai_Untuk_Budget_Sd_HargaTextBox
        '
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurasiKriteriaBindingSource, "Nilai Untuk Budget Sd Harga", True))
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox.Location = New System.Drawing.Point(218, 39)
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox.Name = "Nilai_Untuk_Budget_Sd_HargaTextBox"
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nilai_Untuk_Budget_Sd_HargaTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.SuasanaBindingNavigator3)
        Me.TabPage3.Controls.Add(Me.SuasanaDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(583, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Suasana"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SuasanaBindingNavigator3
        '
        Me.SuasanaBindingNavigator3.AddNewItem = Me.ToolStripButton15
        Me.SuasanaBindingNavigator3.BindingSource = Me.SuasanaBindingSource
        Me.SuasanaBindingNavigator3.CountItem = Me.ToolStripLabel3
        Me.SuasanaBindingNavigator3.DeleteItem = Me.ToolStripButton16
        Me.SuasanaBindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton17, Me.ToolStripButton18, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton19, Me.ToolStripButton20, Me.ToolStripSeparator9, Me.ToolStripButton15, Me.ToolStripButton16, Me.ToolStripButton21})
        Me.SuasanaBindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.SuasanaBindingNavigator3.MoveFirstItem = Me.ToolStripButton17
        Me.SuasanaBindingNavigator3.MoveLastItem = Me.ToolStripButton20
        Me.SuasanaBindingNavigator3.MoveNextItem = Me.ToolStripButton19
        Me.SuasanaBindingNavigator3.MovePreviousItem = Me.ToolStripButton18
        Me.SuasanaBindingNavigator3.Name = "SuasanaBindingNavigator3"
        Me.SuasanaBindingNavigator3.PositionItem = Me.ToolStripTextBox3
        Me.SuasanaBindingNavigator3.Size = New System.Drawing.Size(583, 25)
        Me.SuasanaBindingNavigator3.TabIndex = 5
        Me.SuasanaBindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Add new"
        '
        'SuasanaBindingSource
        '
        Me.SuasanaBindingSource.DataMember = "Suasana"
        Me.SuasanaBindingSource.DataSource = Me.DataSetDani
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Delete"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move first"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Move next"
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "Save Data"
        '
        'SuasanaDataGridView
        '
        Me.SuasanaDataGridView.AutoGenerateColumns = False
        Me.SuasanaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuasanaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SuasanaDataGridView.DataSource = Me.SuasanaBindingSource
        Me.SuasanaDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.SuasanaDataGridView.Name = "SuasanaDataGridView"
        Me.SuasanaDataGridView.Size = New System.Drawing.Size(577, 207)
        Me.SuasanaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Suasana"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Suasana"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 400
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nilai"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nilai"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.FasilitasBindingNavigator4)
        Me.TabPage5.Controls.Add(Me.FasilitasDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(583, 284)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Fasilitas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'FasilitasBindingNavigator4
        '
        Me.FasilitasBindingNavigator4.AddNewItem = Me.ToolStripButton22
        Me.FasilitasBindingNavigator4.BindingSource = Me.FasilitasBindingSource
        Me.FasilitasBindingNavigator4.CountItem = Me.ToolStripLabel4
        Me.FasilitasBindingNavigator4.DeleteItem = Me.ToolStripButton23
        Me.FasilitasBindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton24, Me.ToolStripButton25, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton26, Me.ToolStripButton27, Me.ToolStripSeparator12, Me.ToolStripButton22, Me.ToolStripButton23, Me.ToolStripButton28})
        Me.FasilitasBindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.FasilitasBindingNavigator4.MoveFirstItem = Me.ToolStripButton24
        Me.FasilitasBindingNavigator4.MoveLastItem = Me.ToolStripButton27
        Me.FasilitasBindingNavigator4.MoveNextItem = Me.ToolStripButton26
        Me.FasilitasBindingNavigator4.MovePreviousItem = Me.ToolStripButton25
        Me.FasilitasBindingNavigator4.Name = "FasilitasBindingNavigator4"
        Me.FasilitasBindingNavigator4.PositionItem = Me.ToolStripTextBox4
        Me.FasilitasBindingNavigator4.Size = New System.Drawing.Size(583, 25)
        Me.FasilitasBindingNavigator4.TabIndex = 6
        Me.FasilitasBindingNavigator4.Text = "BindingNavigator4"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Add new"
        '
        'FasilitasBindingSource
        '
        Me.FasilitasBindingSource.DataMember = "Fasilitas"
        Me.FasilitasBindingSource.DataSource = Me.DataSetDani
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Delete"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Move first"
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Current position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "Move next"
        '
        'ToolStripButton27
        '
        Me.ToolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton27.Image = CType(resources.GetObject("ToolStripButton27.Image"), System.Drawing.Image)
        Me.ToolStripButton27.Name = "ToolStripButton27"
        Me.ToolStripButton27.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton27.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton27.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton28
        '
        Me.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton28.Image = CType(resources.GetObject("ToolStripButton28.Image"), System.Drawing.Image)
        Me.ToolStripButton28.Name = "ToolStripButton28"
        Me.ToolStripButton28.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton28.Text = "Save Data"
        '
        'FasilitasDataGridView
        '
        Me.FasilitasDataGridView.AutoGenerateColumns = False
        Me.FasilitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FasilitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.FasilitasDataGridView.DataSource = Me.FasilitasBindingSource
        Me.FasilitasDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.FasilitasDataGridView.Name = "FasilitasDataGridView"
        Me.FasilitasDataGridView.Size = New System.Drawing.Size(577, 207)
        Me.FasilitasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fasilitas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fasilitas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 400
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nilai"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nilai"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Nilai_KM_1NumericUpDown)
        Me.TabPage7.Controls.Add(Nilai_KM_1Label)
        Me.TabPage7.Controls.Add(Me.BindingNavigator1)
        Me.TabPage7.Controls.Add(Selisih_Nilai_RadiusLabel)
        Me.TabPage7.Controls.Add(Me.Selisih_Nilai_RadiusNumericUpDown)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(583, 284)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Lokasi"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Nilai_KM_1NumericUpDown
        '
        Me.Nilai_KM_1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KonfigurasiKriteriaBindingSource, "Nilai KM 1", True))
        Me.Nilai_KM_1NumericUpDown.Location = New System.Drawing.Point(177, 39)
        Me.Nilai_KM_1NumericUpDown.Name = "Nilai_KM_1NumericUpDown"
        Me.Nilai_KM_1NumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Nilai_KM_1NumericUpDown.TabIndex = 8
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.KhasBindingSource
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton29})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(583, 25)
        Me.BindingNavigator1.TabIndex = 7
        Me.BindingNavigator1.Text = "BindingNavigator2"
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton29.Text = "Save Data"
        '
        'Selisih_Nilai_RadiusNumericUpDown
        '
        Me.Selisih_Nilai_RadiusNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KonfigurasiKriteriaBindingSource, "Selisih Nilai Radius", True))
        Me.Selisih_Nilai_RadiusNumericUpDown.Location = New System.Drawing.Point(177, 65)
        Me.Selisih_Nilai_RadiusNumericUpDown.Name = "Selisih_Nilai_RadiusNumericUpDown"
        Me.Selisih_Nilai_RadiusNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Selisih_Nilai_RadiusNumericUpDown.TabIndex = 3
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.Controls.Add(Me.BindingNavigator2)
        Me.TabPage8.Controls.Add(Nama_Kelompok_MakananLabel)
        Me.TabPage8.Controls.Add(Me.Nama_Kelompok_MakananTextBox)
        Me.TabPage8.Controls.Add(Me.Kelompok_MakananDataGridView)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(583, 284)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Kelompok Makanan"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton30
        Me.BindingNavigator2.BindingSource = Me.Kelompok_MakananBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel5
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton31
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton32, Me.ToolStripButton33, Me.ToolStripSeparator13, Me.ToolStripTextBox5, Me.ToolStripLabel5, Me.ToolStripSeparator14, Me.ToolStripButton34, Me.ToolStripButton36, Me.ToolStripSeparator15, Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripButton37})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton32
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton36
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton34
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton33
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox5
        Me.BindingNavigator2.Size = New System.Drawing.Size(577, 25)
        Me.BindingNavigator2.TabIndex = 7
        Me.BindingNavigator2.Text = "BindingNavigator4"
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton30.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton30.Text = "Add new"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel5.Text = "of {0}"
        Me.ToolStripLabel5.ToolTipText = "Total number of items"
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton31.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton31.Text = "Delete"
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton32.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton32.Text = "Move first"
        '
        'ToolStripButton33
        '
        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton33.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton33.Text = "Move previous"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Position"
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Current position"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton34
        '
        Me.ToolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton34.Image = CType(resources.GetObject("ToolStripButton34.Image"), System.Drawing.Image)
        Me.ToolStripButton34.Name = "ToolStripButton34"
        Me.ToolStripButton34.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton34.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton34.Text = "Move next"
        '
        'ToolStripButton36
        '
        Me.ToolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton36.Image = CType(resources.GetObject("ToolStripButton36.Image"), System.Drawing.Image)
        Me.ToolStripButton36.Name = "ToolStripButton36"
        Me.ToolStripButton36.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton36.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton36.Text = "Move last"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton37
        '
        Me.ToolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton37.Image = CType(resources.GetObject("ToolStripButton37.Image"), System.Drawing.Image)
        Me.ToolStripButton37.Name = "ToolStripButton37"
        Me.ToolStripButton37.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton37.Text = "Save Data"
        '
        'Nama_Kelompok_MakananTextBox
        '
        Me.Nama_Kelompok_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Kelompok_MakananBindingSource, "Nama Kelompok Makanan", True))
        Me.Nama_Kelompok_MakananTextBox.Location = New System.Drawing.Point(148, 58)
        Me.Nama_Kelompok_MakananTextBox.Name = "Nama_Kelompok_MakananTextBox"
        Me.Nama_Kelompok_MakananTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Nama_Kelompok_MakananTextBox.TabIndex = 2
        '
        'Kelompok_MakananDataGridView
        '
        Me.Kelompok_MakananDataGridView.AutoGenerateColumns = False
        Me.Kelompok_MakananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Kelompok_MakananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12})
        Me.Kelompok_MakananDataGridView.DataSource = Me.Kelompok_MakananBindingSource
        Me.Kelompok_MakananDataGridView.Location = New System.Drawing.Point(6, 84)
        Me.Kelompok_MakananDataGridView.Name = "Kelompok_MakananDataGridView"
        Me.Kelompok_MakananDataGridView.Size = New System.Drawing.Size(571, 197)
        Me.Kelompok_MakananDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Nama Kelompok Makanan"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nama Kelompok Makanan"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Jenis_MakananTableAdapter
        '
        Me.Jenis_MakananTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FasilitasTableAdapter = Me.FasilitasTableAdapter
        Me.TableAdapterManager.Jenis_MakananTableAdapter = Me.Jenis_MakananTableAdapter
        Me.TableAdapterManager.Kelompok_MakananTableAdapter = Me.Kelompok_MakananTableAdapter
        Me.TableAdapterManager.KhasTableAdapter = Me.KhasTableAdapter
        Me.TableAdapterManager.KonfigurasiKriteriaTableAdapter = Me.KonfigurasiKriteriaTableAdapter
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.RestoFasilitasTableAdapter = Nothing
        Me.TableAdapterManager.RestoTableAdapter = Nothing
        Me.TableAdapterManager.SuasanaTableAdapter = Me.SuasanaTableAdapter
        Me.TableAdapterManager.UpdateOrder = SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Waktu_BukaTableAdapter = Me.Waktu_BukaTableAdapter
        '
        'FasilitasTableAdapter
        '
        Me.FasilitasTableAdapter.ClearBeforeFill = True
        '
        'Kelompok_MakananTableAdapter
        '
        Me.Kelompok_MakananTableAdapter.ClearBeforeFill = True
        '
        'KhasTableAdapter
        '
        Me.KhasTableAdapter.ClearBeforeFill = True
        '
        'KonfigurasiKriteriaTableAdapter
        '
        Me.KonfigurasiKriteriaTableAdapter.ClearBeforeFill = True
        '
        'SuasanaTableAdapter
        '
        Me.SuasanaTableAdapter.ClearBeforeFill = True
        '
        'Waktu_BukaTableAdapter
        '
        Me.Waktu_BukaTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Jenis Makanan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Jenis Makanan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Nama Kelompok Makanan"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.Kelompok_MakananBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "Nama Kelompok Makanan"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Kelompok Makanan"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ValueMember = "Nama Kelompok Makanan"
        '
        'PengaturanNilaiKriteria
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 380)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PengaturanNilaiKriteria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengaturan Nilai dan Kriteria Resto Kuliner"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.KonfigurasiKriteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jenis_MakananBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Jenis_MakananBindingNavigator.ResumeLayout(False)
        Me.Jenis_MakananBindingNavigator.PerformLayout()
        CType(Me.Jenis_MakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jenis_MakananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kelompok_MakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Waktu_BukaBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Waktu_BukaBindingNavigator1.ResumeLayout(False)
        Me.Waktu_BukaBindingNavigator1.PerformLayout()
        CType(Me.Waktu_BukaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waktu_BukaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.KhasBindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KhasBindingNavigator2.ResumeLayout(False)
        Me.KhasBindingNavigator2.PerformLayout()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.KonfigurasiKriteriaBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KonfigurasiKriteriaBindingNavigator1.ResumeLayout(False)
        Me.KonfigurasiKriteriaBindingNavigator1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.SuasanaBindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuasanaBindingNavigator3.ResumeLayout(False)
        Me.SuasanaBindingNavigator3.PerformLayout()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuasanaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.FasilitasBindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FasilitasBindingNavigator4.ResumeLayout(False)
        Me.FasilitasBindingNavigator4.PerformLayout()
        CType(Me.FasilitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasilitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.Nilai_KM_1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Selisih_Nilai_RadiusNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Kelompok_MakananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents DataSetDani As SpkKulinerGE.DataSetDani
    Friend WithEvents Jenis_MakananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Jenis_MakananTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
    Friend WithEvents TableAdapterManager As SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Jenis_MakananBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Jenis_MakananBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Jenis_MakananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Waktu_BukaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
    Friend WithEvents Waktu_BukaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Waktu_BukaBindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Waktu_BukaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KhasTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
    Friend WithEvents KhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KhasBindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents KhasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuasanaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
    Friend WithEvents SuasanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuasanaBindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SuasanaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FasilitasTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.FasilitasTableAdapter
    Friend WithEvents FasilitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FasilitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FasilitasBindingNavigator4 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton25 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton26 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton27 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton28 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KonfigurasiKriteriaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KonfigurasiKriteriaTableAdapter
    Friend WithEvents KonfigurasiKriteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KonfigurasiKriteriaBindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton35 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Selisih_NilaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Range_HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nilai_Untuk_Budget_Sd_HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton29 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Selisih_Nilai_RadiusNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Jam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nilai_KM_1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nilai_Untuk_Jenis_Makanan_Lain_KelompokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nilai_Untuk_Jenis_Makanan_Satu_KelompokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nilai_Untuk_Jenis_Makanan_SamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Kelompok_MakananTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Kelompok_MakananTableAdapter
    Friend WithEvents Kelompok_MakananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nama_Kelompok_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kelompok_MakananDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton30 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton31 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton32 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton33 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton34 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton36 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton37 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
