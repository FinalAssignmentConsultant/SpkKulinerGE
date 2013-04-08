<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim Jenis_MakananLabel As System.Windows.Forms.Label
        Dim FasilitasLabel As System.Windows.Forms.Label
        Dim SuasanaLabel1 As System.Windows.Forms.Label
        Dim KhasLabel1 As System.Windows.Forms.Label
        Dim Waktu_BukaLabel1 As System.Windows.Forms.Label
        Dim TujuanLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.AxGEPluginX1 = New AxGEPluginProj1.AxGEPluginX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTotal = New System.Windows.Forms.TextBox
        Me.waktu_bukaComboBox = New System.Windows.Forms.DateTimePicker
        Me.ButtonPusat = New System.Windows.Forms.Button
        Me.BudgetTextBox = New System.Windows.Forms.NumericUpDown
        Me.LokasiBobot = New System.Windows.Forms.NumericUpDown
        Me.FasilitasBobot = New System.Windows.Forms.NumericUpDown
        Me.FasilitasCheckedListBox = New System.Windows.Forms.CheckedListBox
        Me.LokasiCheckBox = New System.Windows.Forms.CheckBox
        Me.FasilitasCheckBox = New System.Windows.Forms.CheckBox
        Me.SuasanaCheckBox = New System.Windows.Forms.CheckBox
        Me.BudgetCheckBox = New System.Windows.Forms.CheckBox
        Me.KhasCheckBox = New System.Windows.Forms.CheckBox
        Me.WaktuBukaCheckBox = New System.Windows.Forms.CheckBox
        Me.JenisMakananCheckBox = New System.Windows.Forms.CheckBox
        Me.BudgetBobot = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonCari = New System.Windows.Forms.Button
        Me.Jenis_MakananComboBox = New System.Windows.Forms.ComboBox
        Me.JenisMakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetDani = New SpkKulinerGE.DataSetDani
        Me.SuasanaComboBox = New System.Windows.Forms.ComboBox
        Me.SuasanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KhasComboBox = New System.Windows.Forms.ComboBox
        Me.KhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuasanaBobot = New System.Windows.Forms.NumericUpDown
        Me.KhasBobot = New System.Windows.Forms.NumericUpDown
        Me.WaktuBukaBobot = New System.Windows.Forms.NumericUpDown
        Me.JenisMakananBobot = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.WaktuBukaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FasilitasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetDani1 = New SpkKulinerGE.DataSetDani
        Me.FasilitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jenis_MakananTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
        Me.Waktu_BukaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
        Me.KhasTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
        Me.SuasanaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
        Me.FasilitasTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.FasilitasTableAdapter
        Me.TableAdapterManager = New SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
        Me.RestoTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.RestoTableAdapter
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BatasMaks = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.JumlahPencarianLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaResto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassRestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerMouse = New System.Windows.Forms.Timer(Me.components)
        Me.RestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPenentuanLokasiResto = New System.Windows.Forms.Label
        Me.btnPenentuanLokasiResto = New System.Windows.Forms.Button
        Me.TimerBobot = New System.Windows.Forms.Timer(Me.components)
        Jenis_MakananLabel = New System.Windows.Forms.Label
        FasilitasLabel = New System.Windows.Forms.Label
        SuasanaLabel1 = New System.Windows.Forms.Label
        KhasLabel1 = New System.Windows.Forms.Label
        Waktu_BukaLabel1 = New System.Windows.Forms.Label
        TujuanLabel = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.AxGEPluginX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BudgetTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LokasiBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasilitasBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuasanaBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhasBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktuBukaBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMakananBobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktuBukaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasilitasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDani1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasilitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BatasMaks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassRestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jenis_MakananLabel
        '
        Jenis_MakananLabel.AutoSize = True
        Jenis_MakananLabel.Location = New System.Drawing.Point(34, 39)
        Jenis_MakananLabel.Name = "Jenis_MakananLabel"
        Jenis_MakananLabel.Size = New System.Drawing.Size(82, 13)
        Jenis_MakananLabel.TabIndex = 45
        Jenis_MakananLabel.Text = "Jenis Makanan:"
        '
        'FasilitasLabel
        '
        FasilitasLabel.AutoSize = True
        FasilitasLabel.Location = New System.Drawing.Point(34, 171)
        FasilitasLabel.Name = "FasilitasLabel"
        FasilitasLabel.Size = New System.Drawing.Size(47, 13)
        FasilitasLabel.TabIndex = 40
        FasilitasLabel.Text = "Fasilitas:"
        '
        'SuasanaLabel1
        '
        SuasanaLabel1.AutoSize = True
        SuasanaLabel1.Location = New System.Drawing.Point(34, 143)
        SuasanaLabel1.Name = "SuasanaLabel1"
        SuasanaLabel1.Size = New System.Drawing.Size(52, 13)
        SuasanaLabel1.TabIndex = 38
        SuasanaLabel1.Text = "Suasana:"
        '
        'KhasLabel1
        '
        KhasLabel1.AutoSize = True
        KhasLabel1.Location = New System.Drawing.Point(34, 91)
        KhasLabel1.Name = "KhasLabel1"
        KhasLabel1.Size = New System.Drawing.Size(34, 13)
        KhasLabel1.TabIndex = 36
        KhasLabel1.Text = "Khas:"
        '
        'Waktu_BukaLabel1
        '
        Waktu_BukaLabel1.AutoSize = True
        Waktu_BukaLabel1.Location = New System.Drawing.Point(34, 66)
        Waktu_BukaLabel1.Name = "Waktu_BukaLabel1"
        Waktu_BukaLabel1.Size = New System.Drawing.Size(70, 13)
        Waktu_BukaLabel1.TabIndex = 35
        Waktu_BukaLabel1.Text = "Waktu Buka:"
        '
        'TujuanLabel
        '
        TujuanLabel.AutoSize = True
        TujuanLabel.Location = New System.Drawing.Point(34, 372)
        TujuanLabel.Name = "TujuanLabel"
        TujuanLabel.Size = New System.Drawing.Size(41, 13)
        TujuanLabel.TabIndex = 53
        TujuanLabel.Text = "Lokasi:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(119, 343)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(81, 13)
        Label5.TabIndex = 76
        Label5.Text = "Bobot Fasilitas :"
        '
        'AxGEPluginX1
        '
        Me.AxGEPluginX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxGEPluginX1.Location = New System.Drawing.Point(12, 46)
        Me.AxGEPluginX1.Name = "AxGEPluginX1"
        Me.AxGEPluginX1.OcxState = CType(resources.GetObject("AxGEPluginX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGEPluginX1.Size = New System.Drawing.Size(479, 447)
        Me.AxGEPluginX1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.waktu_bukaComboBox)
        Me.GroupBox1.Controls.Add(Me.ButtonPusat)
        Me.GroupBox1.Controls.Add(Me.BudgetTextBox)
        Me.GroupBox1.Controls.Add(Me.LokasiBobot)
        Me.GroupBox1.Controls.Add(Me.FasilitasBobot)
        Me.GroupBox1.Controls.Add(Me.FasilitasCheckedListBox)
        Me.GroupBox1.Controls.Add(Me.LokasiCheckBox)
        Me.GroupBox1.Controls.Add(Me.FasilitasCheckBox)
        Me.GroupBox1.Controls.Add(Me.SuasanaCheckBox)
        Me.GroupBox1.Controls.Add(Me.BudgetCheckBox)
        Me.GroupBox1.Controls.Add(Me.KhasCheckBox)
        Me.GroupBox1.Controls.Add(Me.WaktuBukaCheckBox)
        Me.GroupBox1.Controls.Add(Me.JenisMakananCheckBox)
        Me.GroupBox1.Controls.Add(Me.BudgetBobot)
        Me.GroupBox1.Controls.Add(TujuanLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ButtonCari)
        Me.GroupBox1.Controls.Add(Jenis_MakananLabel)
        Me.GroupBox1.Controls.Add(Me.Jenis_MakananComboBox)
        Me.GroupBox1.Controls.Add(FasilitasLabel)
        Me.GroupBox1.Controls.Add(SuasanaLabel1)
        Me.GroupBox1.Controls.Add(Me.SuasanaComboBox)
        Me.GroupBox1.Controls.Add(KhasLabel1)
        Me.GroupBox1.Controls.Add(Me.KhasComboBox)
        Me.GroupBox1.Controls.Add(Waktu_BukaLabel1)
        Me.GroupBox1.Controls.Add(Me.SuasanaBobot)
        Me.GroupBox1.Controls.Add(Me.KhasBobot)
        Me.GroupBox1.Controls.Add(Me.WaktuBukaBobot)
        Me.GroupBox1.Controls.Add(Me.JenisMakananBobot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 428)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Resto Kuliner"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(272, 171)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 20)
        Me.lblTotal.TabIndex = 77
        '
        'waktu_bukaComboBox
        '
        Me.waktu_bukaComboBox.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.waktu_bukaComboBox.Location = New System.Drawing.Point(120, 66)
        Me.waktu_bukaComboBox.Name = "waktu_bukaComboBox"
        Me.waktu_bukaComboBox.ShowUpDown = True
        Me.waktu_bukaComboBox.Size = New System.Drawing.Size(146, 20)
        Me.waktu_bukaComboBox.TabIndex = 75
        '
        'ButtonPusat
        '
        Me.ButtonPusat.Location = New System.Drawing.Point(120, 367)
        Me.ButtonPusat.Name = "ButtonPusat"
        Me.ButtonPusat.Size = New System.Drawing.Size(146, 23)
        Me.ButtonPusat.TabIndex = 69
        Me.ButtonPusat.Text = "Ambil Pusat Lokasi"
        Me.ButtonPusat.UseVisualStyleBackColor = True
        '
        'BudgetTextBox
        '
        Me.BudgetTextBox.Location = New System.Drawing.Point(122, 117)
        Me.BudgetTextBox.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.BudgetTextBox.Name = "BudgetTextBox"
        Me.BudgetTextBox.Size = New System.Drawing.Size(144, 20)
        Me.BudgetTextBox.TabIndex = 67
        Me.BudgetTextBox.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'LokasiBobot
        '
        Me.LokasiBobot.Location = New System.Drawing.Point(272, 367)
        Me.LokasiBobot.Name = "LokasiBobot"
        Me.LokasiBobot.Size = New System.Drawing.Size(52, 20)
        Me.LokasiBobot.TabIndex = 65
        '
        'FasilitasBobot
        '
        Me.FasilitasBobot.Location = New System.Drawing.Point(214, 341)
        Me.FasilitasBobot.Name = "FasilitasBobot"
        Me.FasilitasBobot.Size = New System.Drawing.Size(52, 20)
        Me.FasilitasBobot.TabIndex = 64
        '
        'FasilitasCheckedListBox
        '
        Me.FasilitasCheckedListBox.ColumnWidth = 100
        Me.FasilitasCheckedListBox.FormattingEnabled = True
        Me.FasilitasCheckedListBox.Location = New System.Drawing.Point(120, 171)
        Me.FasilitasCheckedListBox.MultiColumn = True
        Me.FasilitasCheckedListBox.Name = "FasilitasCheckedListBox"
        Me.FasilitasCheckedListBox.Size = New System.Drawing.Size(146, 169)
        Me.FasilitasCheckedListBox.TabIndex = 63
        '
        'LokasiCheckBox
        '
        Me.LokasiCheckBox.AutoSize = True
        Me.LokasiCheckBox.Location = New System.Drawing.Point(11, 373)
        Me.LokasiCheckBox.Name = "LokasiCheckBox"
        Me.LokasiCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.LokasiCheckBox.TabIndex = 62
        Me.LokasiCheckBox.UseVisualStyleBackColor = True
        '
        'FasilitasCheckBox
        '
        Me.FasilitasCheckBox.AutoSize = True
        Me.FasilitasCheckBox.Location = New System.Drawing.Point(11, 171)
        Me.FasilitasCheckBox.Name = "FasilitasCheckBox"
        Me.FasilitasCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.FasilitasCheckBox.TabIndex = 61
        Me.FasilitasCheckBox.UseVisualStyleBackColor = True
        '
        'SuasanaCheckBox
        '
        Me.SuasanaCheckBox.AutoSize = True
        Me.SuasanaCheckBox.Location = New System.Drawing.Point(12, 143)
        Me.SuasanaCheckBox.Name = "SuasanaCheckBox"
        Me.SuasanaCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.SuasanaCheckBox.TabIndex = 60
        Me.SuasanaCheckBox.UseVisualStyleBackColor = True
        '
        'BudgetCheckBox
        '
        Me.BudgetCheckBox.AutoSize = True
        Me.BudgetCheckBox.Location = New System.Drawing.Point(11, 117)
        Me.BudgetCheckBox.Name = "BudgetCheckBox"
        Me.BudgetCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.BudgetCheckBox.TabIndex = 59
        Me.BudgetCheckBox.UseVisualStyleBackColor = True
        '
        'KhasCheckBox
        '
        Me.KhasCheckBox.AutoSize = True
        Me.KhasCheckBox.Location = New System.Drawing.Point(11, 91)
        Me.KhasCheckBox.Name = "KhasCheckBox"
        Me.KhasCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.KhasCheckBox.TabIndex = 58
        Me.KhasCheckBox.UseVisualStyleBackColor = True
        '
        'WaktuBukaCheckBox
        '
        Me.WaktuBukaCheckBox.AutoSize = True
        Me.WaktuBukaCheckBox.Location = New System.Drawing.Point(11, 66)
        Me.WaktuBukaCheckBox.Name = "WaktuBukaCheckBox"
        Me.WaktuBukaCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.WaktuBukaCheckBox.TabIndex = 57
        Me.WaktuBukaCheckBox.UseVisualStyleBackColor = True
        '
        'JenisMakananCheckBox
        '
        Me.JenisMakananCheckBox.AutoSize = True
        Me.JenisMakananCheckBox.Location = New System.Drawing.Point(11, 39)
        Me.JenisMakananCheckBox.Name = "JenisMakananCheckBox"
        Me.JenisMakananCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.JenisMakananCheckBox.TabIndex = 56
        Me.JenisMakananCheckBox.UseVisualStyleBackColor = True
        '
        'BudgetBobot
        '
        Me.BudgetBobot.Location = New System.Drawing.Point(272, 117)
        Me.BudgetBobot.Name = "BudgetBobot"
        Me.BudgetBobot.Size = New System.Drawing.Size(52, 20)
        Me.BudgetBobot.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Bobot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Kriteria Pencarian"
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(12, 399)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari.TabIndex = 47
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'Jenis_MakananComboBox
        '
        Me.Jenis_MakananComboBox.DataSource = Me.JenisMakananBindingSource
        Me.Jenis_MakananComboBox.DisplayMember = "Jenis Makanan"
        Me.Jenis_MakananComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jenis_MakananComboBox.FormattingEnabled = True
        Me.Jenis_MakananComboBox.Location = New System.Drawing.Point(120, 39)
        Me.Jenis_MakananComboBox.Name = "Jenis_MakananComboBox"
        Me.Jenis_MakananComboBox.Size = New System.Drawing.Size(146, 21)
        Me.Jenis_MakananComboBox.TabIndex = 46
        Me.Jenis_MakananComboBox.ValueMember = "Jenis Makanan"
        '
        'JenisMakananBindingSource
        '
        Me.JenisMakananBindingSource.DataMember = "Jenis Makanan"
        Me.JenisMakananBindingSource.DataSource = Me.DataSetDani
        '
        'DataSetDani
        '
        Me.DataSetDani.DataSetName = "DataSetDani"
        Me.DataSetDani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuasanaComboBox
        '
        Me.SuasanaComboBox.DataSource = Me.SuasanaBindingSource
        Me.SuasanaComboBox.DisplayMember = "Suasana"
        Me.SuasanaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SuasanaComboBox.FormattingEnabled = True
        Me.SuasanaComboBox.Location = New System.Drawing.Point(121, 143)
        Me.SuasanaComboBox.Name = "SuasanaComboBox"
        Me.SuasanaComboBox.Size = New System.Drawing.Size(145, 21)
        Me.SuasanaComboBox.TabIndex = 41
        Me.SuasanaComboBox.ValueMember = "Suasana"
        '
        'SuasanaBindingSource
        '
        Me.SuasanaBindingSource.DataMember = "Suasana"
        Me.SuasanaBindingSource.DataSource = Me.DataSetDani
        '
        'KhasComboBox
        '
        Me.KhasComboBox.DataSource = Me.KhasBindingSource
        Me.KhasComboBox.DisplayMember = "Khas"
        Me.KhasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KhasComboBox.FormattingEnabled = True
        Me.KhasComboBox.Location = New System.Drawing.Point(121, 91)
        Me.KhasComboBox.Name = "KhasComboBox"
        Me.KhasComboBox.Size = New System.Drawing.Size(145, 21)
        Me.KhasComboBox.TabIndex = 39
        Me.KhasComboBox.ValueMember = "Khas"
        '
        'KhasBindingSource
        '
        Me.KhasBindingSource.DataMember = "Khas"
        Me.KhasBindingSource.DataSource = Me.DataSetDani
        '
        'SuasanaBobot
        '
        Me.SuasanaBobot.Location = New System.Drawing.Point(272, 143)
        Me.SuasanaBobot.Name = "SuasanaBobot"
        Me.SuasanaBobot.Size = New System.Drawing.Size(52, 20)
        Me.SuasanaBobot.TabIndex = 32
        '
        'KhasBobot
        '
        Me.KhasBobot.Location = New System.Drawing.Point(272, 91)
        Me.KhasBobot.Name = "KhasBobot"
        Me.KhasBobot.Size = New System.Drawing.Size(52, 20)
        Me.KhasBobot.TabIndex = 30
        '
        'WaktuBukaBobot
        '
        Me.WaktuBukaBobot.Location = New System.Drawing.Point(272, 66)
        Me.WaktuBukaBobot.Name = "WaktuBukaBobot"
        Me.WaktuBukaBobot.Size = New System.Drawing.Size(52, 20)
        Me.WaktuBukaBobot.TabIndex = 29
        '
        'JenisMakananBobot
        '
        Me.JenisMakananBobot.Location = New System.Drawing.Point(272, 39)
        Me.JenisMakananBobot.Name = "JenisMakananBobot"
        Me.JenisMakananBobot.Size = New System.Drawing.Size(52, 20)
        Me.JenisMakananBobot.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Budget:"
        '
        'WaktuBukaBindingSource
        '
        Me.WaktuBukaBindingSource.DataMember = "Waktu Buka"
        Me.WaktuBukaBindingSource.DataSource = Me.DataSetDani
        '
        'FasilitasBindingSource1
        '
        Me.FasilitasBindingSource1.DataMember = "Fasilitas"
        Me.FasilitasBindingSource1.DataSource = Me.DataSetDani
        '
        'DataSetDani1
        '
        Me.DataSetDani1.DataSetName = "DataSetDani"
        Me.DataSetDani1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FasilitasBindingSource
        '
        Me.FasilitasBindingSource.DataMember = "Fasilitas"
        Me.FasilitasBindingSource.DataSource = Me.DataSetDani
        '
        'Jenis_MakananTableAdapter
        '
        Me.Jenis_MakananTableAdapter.ClearBeforeFill = True
        '
        'Waktu_BukaTableAdapter
        '
        Me.Waktu_BukaTableAdapter.ClearBeforeFill = True
        '
        'KhasTableAdapter
        '
        Me.KhasTableAdapter.ClearBeforeFill = True
        '
        'SuasanaTableAdapter
        '
        Me.SuasanaTableAdapter.ClearBeforeFill = True
        '
        'FasilitasTableAdapter
        '
        Me.FasilitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FasilitasTableAdapter = Me.FasilitasTableAdapter
        Me.TableAdapterManager.Jenis_MakananTableAdapter = Me.Jenis_MakananTableAdapter
        Me.TableAdapterManager.Kelompok_MakananTableAdapter = Nothing
        Me.TableAdapterManager.KhasTableAdapter = Me.KhasTableAdapter
        Me.TableAdapterManager.KonfigurasiKriteriaTableAdapter = Nothing
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.PemakaiTableAdapter = Nothing
        Me.TableAdapterManager.RestoFasilitasTableAdapter = Nothing
        Me.TableAdapterManager.RestoTableAdapter = Me.RestoTableAdapter
        Me.TableAdapterManager.SuasanaTableAdapter = Me.SuasanaTableAdapter
        Me.TableAdapterManager.UpdateOrder = SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Waktu_BukaTableAdapter = Me.Waktu_BukaTableAdapter
        '
        'RestoTableAdapter
        '
        Me.RestoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(873, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.RestoToolStripMenuItem, Me.KriteriaToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'RestoToolStripMenuItem
        '
        Me.RestoToolStripMenuItem.Name = "RestoToolStripMenuItem"
        Me.RestoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RestoToolStripMenuItem.Text = "&Resto"
        '
        'KriteriaToolStripMenuItem
        '
        Me.KriteriaToolStripMenuItem.Name = "KriteriaToolStripMenuItem"
        Me.KriteriaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KriteriaToolStripMenuItem.Text = "&Kriteria dan Nilai"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(510, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(351, 466)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(343, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pencarian Resto Kuliner"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BatasMaks)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.JumlahPencarianLabel)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 506)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(849, 204)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hasil Pencarian"
        '
        'BatasMaks
        '
        Me.BatasMaks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BatasMaks.Location = New System.Drawing.Point(800, 18)
        Me.BatasMaks.Name = "BatasMaks"
        Me.BatasMaks.Size = New System.Drawing.Size(39, 20)
        Me.BatasMaks.TabIndex = 4
        Me.BatasMaks.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(733, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Batas Maks"
        '
        'JumlahPencarianLabel
        '
        Me.JumlahPencarianLabel.AutoSize = True
        Me.JumlahPencarianLabel.Location = New System.Drawing.Point(57, 25)
        Me.JumlahPencarianLabel.Name = "JumlahPencarianLabel"
        Me.JumlahPencarianLabel.Size = New System.Drawing.Size(10, 13)
        Me.JumlahPencarianLabel.TabIndex = 2
        Me.JumlahPencarianLabel.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jumlah"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.NamaResto})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 44)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(831, 154)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'NamaResto
        '
        Me.NamaResto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaResto.HeaderText = "Nama Resto"
        Me.NamaResto.Name = "NamaResto"
        Me.NamaResto.ReadOnly = True
        '
        'ClassRestoBindingSource
        '
        Me.ClassRestoBindingSource.DataSource = GetType(SpkKulinerGE.ClassResto)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'timerMouse
        '
        '
        'RestoBindingSource
        '
        Me.RestoBindingSource.DataMember = "Resto"
        Me.RestoBindingSource.DataSource = Me.DataSetDani
        '
        'lblPenentuanLokasiResto
        '
        Me.lblPenentuanLokasiResto.AutoSize = True
        Me.lblPenentuanLokasiResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenentuanLokasiResto.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPenentuanLokasiResto.Location = New System.Drawing.Point(12, 30)
        Me.lblPenentuanLokasiResto.Name = "lblPenentuanLokasiResto"
        Me.lblPenentuanLokasiResto.Size = New System.Drawing.Size(146, 13)
        Me.lblPenentuanLokasiResto.TabIndex = 8
        Me.lblPenentuanLokasiResto.Text = "Penentuan Lokasi Resto"
        Me.lblPenentuanLokasiResto.Visible = False
        '
        'btnPenentuanLokasiResto
        '
        Me.btnPenentuanLokasiResto.Location = New System.Drawing.Point(164, 25)
        Me.btnPenentuanLokasiResto.Name = "btnPenentuanLokasiResto"
        Me.btnPenentuanLokasiResto.Size = New System.Drawing.Size(75, 23)
        Me.btnPenentuanLokasiResto.TabIndex = 9
        Me.btnPenentuanLokasiResto.Text = "OK"
        Me.btnPenentuanLokasiResto.UseVisualStyleBackColor = True
        Me.btnPenentuanLokasiResto.Visible = False
        '
        'TimerBobot
        '
        Me.TimerBobot.Enabled = True
        Me.TimerBobot.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 722)
        Me.Controls.Add(Me.btnPenentuanLokasiResto)
        Me.Controls.Add(Me.lblPenentuanLokasiResto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AxGEPluginX1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPK KULINER Dengan Visualisasi Geografi"
        CType(Me.AxGEPluginX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BudgetTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LokasiBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasilitasBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuasanaBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhasBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktuBukaBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMakananBobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktuBukaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasilitasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDani1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasilitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BatasMaks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassRestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxGEPluginX1 As AxGEPluginProj1.AxGEPluginX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Jenis_MakananComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SuasanaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KhasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SuasanaBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents KhasBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents WaktuBukaBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents JenisMakananBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSetDani As SpkKulinerGE.DataSetDani
    Friend WithEvents JenisMakananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Jenis_MakananTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
    Friend WithEvents WaktuBukaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Waktu_BukaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
    Friend WithEvents KhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KhasTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
    Friend WithEvents SuasanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuasanaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
    Friend WithEvents FasilitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FasilitasTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.FasilitasTableAdapter
    Friend WithEvents FasilitasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem



    Friend WithEvents DataSetDani1 As SpkKulinerGE.DataSetDani

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BudgetBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents FasilitasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SuasanaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BudgetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents KhasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WaktuBukaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents JenisMakananCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LokasiCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FasilitasCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents FasilitasBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents LokasiBobot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BudgetTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClassRestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaResto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BatasMaks As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents JumlahPencarianLabel As System.Windows.Forms.Label
    Friend WithEvents KriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timerMouse As System.Windows.Forms.Timer
    Friend WithEvents ButtonPusat As System.Windows.Forms.Button
    Friend WithEvents RestoTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.RestoTableAdapter
    Friend WithEvents RestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblPenentuanLokasiResto As System.Windows.Forms.Label
    Friend WithEvents btnPenentuanLokasiResto As System.Windows.Forms.Button
    Friend WithEvents TimerBobot As System.Windows.Forms.Timer
    Friend WithEvents waktu_bukaComboBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.TextBox

End Class
