<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarResto
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
        Dim Nama_RestoLabel As System.Windows.Forms.Label
        Dim Jenis_MakananLabel As System.Windows.Forms.Label
        Dim KhasLabel As System.Windows.Forms.Label
        Dim SuasanaLabel As System.Windows.Forms.Label
        Dim KoordinatLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Nama_MakananLabel As System.Windows.Forms.Label
        Dim BukaLabel As System.Windows.Forms.Label
        Dim TutupLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarResto))
        Me.OK_Button = New System.Windows.Forms.Button
        Me.RestoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.RestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetDani = New SpkKulinerGE.DataSetDani
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
        Me.RestoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.RestoDataGridView = New System.Windows.Forms.DataGridView
        Me.RestoTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.RestoTableAdapter
        Me.TableAdapterManager = New SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
        Me.Jenis_MakananTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
        Me.KhasTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
        Me.SuasanaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
        Me.Waktu_BukaTableAdapter = New SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
        Me.Nama_RestoTextBox = New System.Windows.Forms.TextBox
        Me.Jenis_MakananComboBox = New System.Windows.Forms.ComboBox
        Me.JenisMakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KhasComboBox = New System.Windows.Forms.ComboBox
        Me.KhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuasanaComboBox = New System.Windows.Forms.ComboBox
        Me.SuasanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WaktuBukaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KoordinatTextBox = New System.Windows.Forms.TextBox
        Me.KhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HargaTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_MakananTextBox = New System.Windows.Forms.TextBox
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaRestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JenisMakananDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KecamatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelurahanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukaComboBox = New System.Windows.Forms.ComboBox
        Me.TutupComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTentukanLokasi = New System.Windows.Forms.Button
        Me.FasilitasCheckedListBox = New System.Windows.Forms.CheckedListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NamaRestoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JenisMakananDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaMakananDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KhasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SuasanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KoordinatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Nama_RestoLabel = New System.Windows.Forms.Label
        Jenis_MakananLabel = New System.Windows.Forms.Label
        KhasLabel = New System.Windows.Forms.Label
        SuasanaLabel = New System.Windows.Forms.Label
        KoordinatLabel = New System.Windows.Forms.Label
        HargaLabel = New System.Windows.Forms.Label
        AlamatLabel = New System.Windows.Forms.Label
        Nama_MakananLabel = New System.Windows.Forms.Label
        BukaLabel = New System.Windows.Forms.Label
        TutupLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.RestoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RestoBindingNavigator.SuspendLayout()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktuBukaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KecamatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelurahanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nama_RestoLabel
        '
        Nama_RestoLabel.AutoSize = True
        Nama_RestoLabel.Location = New System.Drawing.Point(18, 53)
        Nama_RestoLabel.Name = "Nama_RestoLabel"
        Nama_RestoLabel.Size = New System.Drawing.Size(69, 13)
        Nama_RestoLabel.TabIndex = 3
        Nama_RestoLabel.Text = "Nama Resto:"
        '
        'Jenis_MakananLabel
        '
        Jenis_MakananLabel.AutoSize = True
        Jenis_MakananLabel.Location = New System.Drawing.Point(18, 79)
        Jenis_MakananLabel.Name = "Jenis_MakananLabel"
        Jenis_MakananLabel.Size = New System.Drawing.Size(82, 13)
        Jenis_MakananLabel.TabIndex = 5
        Jenis_MakananLabel.Text = "Jenis Makanan:"
        '
        'KhasLabel
        '
        KhasLabel.AutoSize = True
        KhasLabel.Location = New System.Drawing.Point(18, 185)
        KhasLabel.Name = "KhasLabel"
        KhasLabel.Size = New System.Drawing.Size(34, 13)
        KhasLabel.TabIndex = 7
        KhasLabel.Text = "Khas:"
        '
        'SuasanaLabel
        '
        SuasanaLabel.AutoSize = True
        SuasanaLabel.Location = New System.Drawing.Point(18, 235)
        SuasanaLabel.Name = "SuasanaLabel"
        SuasanaLabel.Size = New System.Drawing.Size(52, 13)
        SuasanaLabel.TabIndex = 9
        SuasanaLabel.Text = "Suasana:"
        '
        'KoordinatLabel
        '
        KoordinatLabel.AutoSize = True
        KoordinatLabel.Location = New System.Drawing.Point(296, 53)
        KoordinatLabel.Name = "KoordinatLabel"
        KoordinatLabel.Size = New System.Drawing.Size(55, 13)
        KoordinatLabel.TabIndex = 13
        KoordinatLabel.Text = "Koordinat:"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(18, 209)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(39, 13)
        HargaLabel.TabIndex = 15
        HargaLabel.Text = "Harga:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(296, 109)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 20
        AlamatLabel.Text = "Alamat:"
        '
        'Nama_MakananLabel
        '
        Nama_MakananLabel.AutoSize = True
        Nama_MakananLabel.Location = New System.Drawing.Point(18, 106)
        Nama_MakananLabel.Name = "Nama_MakananLabel"
        Nama_MakananLabel.Size = New System.Drawing.Size(86, 13)
        Nama_MakananLabel.TabIndex = 22
        Nama_MakananLabel.Text = "Nama Makanan:"
        '
        'BukaLabel
        '
        BukaLabel.AutoSize = True
        BukaLabel.Location = New System.Drawing.Point(105, 132)
        BukaLabel.Name = "BukaLabel"
        BukaLabel.Size = New System.Drawing.Size(35, 13)
        BukaLabel.TabIndex = 27
        BukaLabel.Text = "Buka:"
        '
        'TutupLabel
        '
        TutupLabel.AutoSize = True
        TutupLabel.Location = New System.Drawing.Point(105, 161)
        TutupLabel.Name = "TutupLabel"
        TutupLabel.Size = New System.Drawing.Size(38, 13)
        TutupLabel.TabIndex = 29
        TutupLabel.Text = "Tutup:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(583, 50)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 65
        Label2.Text = "Fasilitas:"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(734, 395)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Tutup"
        '
        'RestoBindingNavigator
        '
        Me.RestoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RestoBindingNavigator.BindingSource = Me.RestoBindingSource
        Me.RestoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RestoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RestoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RestoBindingNavigatorSaveItem})
        Me.RestoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RestoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RestoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RestoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RestoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RestoBindingNavigator.Name = "RestoBindingNavigator"
        Me.RestoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RestoBindingNavigator.Size = New System.Drawing.Size(816, 25)
        Me.RestoBindingNavigator.TabIndex = 1
        Me.RestoBindingNavigator.Text = "BindingNavigator1"
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
        'RestoBindingSource
        '
        Me.RestoBindingSource.DataMember = "Resto"
        Me.RestoBindingSource.DataSource = Me.DataSetDani
        '
        'DataSetDani
        '
        Me.DataSetDani.DataSetName = "DataSetDani"
        Me.DataSetDani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'RestoBindingNavigatorSaveItem
        '
        Me.RestoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RestoBindingNavigatorSaveItem.Image = CType(resources.GetObject("RestoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RestoBindingNavigatorSaveItem.Name = "RestoBindingNavigatorSaveItem"
        Me.RestoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RestoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RestoDataGridView
        '
        Me.RestoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestoDataGridView.AutoGenerateColumns = False
        Me.RestoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaRestoDataGridViewTextBoxColumn1, Me.JenisMakananDataGridViewTextBoxColumn1, Me.NamaMakananDataGridViewTextBoxColumn, Me.KhasDataGridViewTextBoxColumn, Me.SuasanaDataGridViewTextBoxColumn, Me.KoordinatDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn})
        Me.RestoDataGridView.DataSource = Me.RestoBindingSource
        Me.RestoDataGridView.Location = New System.Drawing.Point(12, 259)
        Me.RestoDataGridView.Name = "RestoDataGridView"
        Me.RestoDataGridView.ReadOnly = True
        Me.RestoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RestoDataGridView.Size = New System.Drawing.Size(789, 124)
        Me.RestoDataGridView.TabIndex = 2
        '
        'RestoTableAdapter
        '
        Me.RestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FasilitasTableAdapter = Nothing
        Me.TableAdapterManager.Jenis_MakananTableAdapter = Me.Jenis_MakananTableAdapter
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
        'Jenis_MakananTableAdapter
        '
        Me.Jenis_MakananTableAdapter.ClearBeforeFill = True
        '
        'KhasTableAdapter
        '
        Me.KhasTableAdapter.ClearBeforeFill = True
        '
        'SuasanaTableAdapter
        '
        Me.SuasanaTableAdapter.ClearBeforeFill = True
        '
        'Waktu_BukaTableAdapter
        '
        Me.Waktu_BukaTableAdapter.ClearBeforeFill = True
        '
        'Nama_RestoTextBox
        '
        Me.Nama_RestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Nama Resto", True))
        Me.Nama_RestoTextBox.Location = New System.Drawing.Point(106, 50)
        Me.Nama_RestoTextBox.Name = "Nama_RestoTextBox"
        Me.Nama_RestoTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Nama_RestoTextBox.TabIndex = 4
        '
        'Jenis_MakananComboBox
        '
        Me.Jenis_MakananComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Jenis Makanan", True))
        Me.Jenis_MakananComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RestoBindingSource, "Jenis Makanan", True))
        Me.Jenis_MakananComboBox.DataSource = Me.JenisMakananBindingSource
        Me.Jenis_MakananComboBox.DisplayMember = "Jenis Makanan"
        Me.Jenis_MakananComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jenis_MakananComboBox.FormattingEnabled = True
        Me.Jenis_MakananComboBox.Location = New System.Drawing.Point(106, 76)
        Me.Jenis_MakananComboBox.Name = "Jenis_MakananComboBox"
        Me.Jenis_MakananComboBox.Size = New System.Drawing.Size(161, 21)
        Me.Jenis_MakananComboBox.TabIndex = 6
        Me.Jenis_MakananComboBox.ValueMember = "Jenis Makanan"
        '
        'JenisMakananBindingSource
        '
        Me.JenisMakananBindingSource.DataMember = "Jenis Makanan"
        Me.JenisMakananBindingSource.DataSource = Me.DataSetDani
        '
        'KhasComboBox
        '
        Me.KhasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Khas", True))
        Me.KhasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RestoBindingSource, "Khas", True))
        Me.KhasComboBox.DataSource = Me.KhasBindingSource
        Me.KhasComboBox.DisplayMember = "Khas"
        Me.KhasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KhasComboBox.FormattingEnabled = True
        Me.KhasComboBox.Location = New System.Drawing.Point(106, 182)
        Me.KhasComboBox.Name = "KhasComboBox"
        Me.KhasComboBox.Size = New System.Drawing.Size(161, 21)
        Me.KhasComboBox.TabIndex = 8
        Me.KhasComboBox.ValueMember = "Khas"
        '
        'KhasBindingSource
        '
        Me.KhasBindingSource.DataMember = "Khas"
        Me.KhasBindingSource.DataSource = Me.DataSetDani
        '
        'SuasanaComboBox
        '
        Me.SuasanaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Suasana", True))
        Me.SuasanaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RestoBindingSource, "Suasana", True))
        Me.SuasanaComboBox.DataSource = Me.SuasanaBindingSource
        Me.SuasanaComboBox.DisplayMember = "Suasana"
        Me.SuasanaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SuasanaComboBox.FormattingEnabled = True
        Me.SuasanaComboBox.Location = New System.Drawing.Point(106, 232)
        Me.SuasanaComboBox.Name = "SuasanaComboBox"
        Me.SuasanaComboBox.Size = New System.Drawing.Size(161, 21)
        Me.SuasanaComboBox.TabIndex = 10
        Me.SuasanaComboBox.ValueMember = "Suasana"
        '
        'SuasanaBindingSource
        '
        Me.SuasanaBindingSource.DataMember = "Suasana"
        Me.SuasanaBindingSource.DataSource = Me.DataSetDani
        '
        'WaktuBukaBindingSource
        '
        Me.WaktuBukaBindingSource.DataMember = "Waktu Buka"
        Me.WaktuBukaBindingSource.DataSource = Me.DataSetDani
        '
        'KoordinatTextBox
        '
        Me.KoordinatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Koordinat", True))
        Me.KoordinatTextBox.Location = New System.Drawing.Point(372, 50)
        Me.KoordinatTextBox.Name = "KoordinatTextBox"
        Me.KoordinatTextBox.Size = New System.Drawing.Size(188, 20)
        Me.KoordinatTextBox.TabIndex = 14
        '
        'KhasBindingSource1
        '
        Me.KhasBindingSource1.DataMember = "Khas"
        Me.KhasBindingSource1.DataSource = Me.DataSetDani
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Harga", True))
        Me.HargaTextBox.Location = New System.Drawing.Point(106, 206)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(161, 20)
        Me.HargaTextBox.TabIndex = 16
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(372, 109)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(188, 70)
        Me.AlamatTextBox.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama Resto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Resto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Jenis Makanan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jenis Makanan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Nama_MakananTextBox
        '
        Me.Nama_MakananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Nama Makanan", True))
        Me.Nama_MakananTextBox.Location = New System.Drawing.Point(106, 103)
        Me.Nama_MakananTextBox.Name = "Nama_MakananTextBox"
        Me.Nama_MakananTextBox.Size = New System.Drawing.Size(161, 20)
        Me.Nama_MakananTextBox.TabIndex = 23
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaRestoDataGridViewTextBoxColumn
        '
        Me.NamaRestoDataGridViewTextBoxColumn.DataPropertyName = "Nama Resto"
        Me.NamaRestoDataGridViewTextBoxColumn.HeaderText = "Nama Resto"
        Me.NamaRestoDataGridViewTextBoxColumn.Name = "NamaRestoDataGridViewTextBoxColumn"
        '
        'JenisMakananDataGridViewTextBoxColumn
        '
        Me.JenisMakananDataGridViewTextBoxColumn.DataPropertyName = "Jenis Makanan"
        Me.JenisMakananDataGridViewTextBoxColumn.HeaderText = "Jenis Makanan"
        Me.JenisMakananDataGridViewTextBoxColumn.Name = "JenisMakananDataGridViewTextBoxColumn"
        '
        'KecamatanBindingSource
        '
        Me.KecamatanBindingSource.DataMember = "Kecamatan"
        Me.KecamatanBindingSource.DataSource = Me.DataSetDani
        '
        'KelurahanBindingSource
        '
        Me.KelurahanBindingSource.DataMember = "Kelurahan"
        Me.KelurahanBindingSource.DataSource = Me.DataSetDani
        '
        'BukaComboBox
        '
        Me.BukaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Buka", True))
        Me.BukaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BukaComboBox.FormattingEnabled = True
        Me.BukaComboBox.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.BukaComboBox.Location = New System.Drawing.Point(146, 129)
        Me.BukaComboBox.Name = "BukaComboBox"
        Me.BukaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BukaComboBox.TabIndex = 28
        '
        'TutupComboBox
        '
        Me.TutupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "Tutup", True))
        Me.TutupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TutupComboBox.FormattingEnabled = True
        Me.TutupComboBox.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.TutupComboBox.Location = New System.Drawing.Point(146, 158)
        Me.TutupComboBox.Name = "TutupComboBox"
        Me.TutupComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TutupComboBox.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Jam"
        '
        'btnTentukanLokasi
        '
        Me.btnTentukanLokasi.Location = New System.Drawing.Point(372, 76)
        Me.btnTentukanLokasi.Name = "btnTentukanLokasi"
        Me.btnTentukanLokasi.Size = New System.Drawing.Size(112, 23)
        Me.btnTentukanLokasi.TabIndex = 32
        Me.btnTentukanLokasi.Text = "&Tentukan Koordinat"
        Me.btnTentukanLokasi.UseVisualStyleBackColor = True
        '
        'FasilitasCheckedListBox
        '
        Me.FasilitasCheckedListBox.CheckOnClick = True
        Me.FasilitasCheckedListBox.ColumnWidth = 100
        Me.FasilitasCheckedListBox.FormattingEnabled = True
        Me.FasilitasCheckedListBox.Location = New System.Drawing.Point(586, 66)
        Me.FasilitasCheckedListBox.MultiColumn = True
        Me.FasilitasCheckedListBox.Name = "FasilitasCheckedListBox"
        Me.FasilitasCheckedListBox.Size = New System.Drawing.Size(146, 169)
        Me.FasilitasCheckedListBox.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NamaRestoDataGridViewTextBoxColumn1
        '
        Me.NamaRestoDataGridViewTextBoxColumn1.DataPropertyName = "Nama Resto"
        Me.NamaRestoDataGridViewTextBoxColumn1.HeaderText = "Nama Resto"
        Me.NamaRestoDataGridViewTextBoxColumn1.Name = "NamaRestoDataGridViewTextBoxColumn1"
        Me.NamaRestoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'JenisMakananDataGridViewTextBoxColumn1
        '
        Me.JenisMakananDataGridViewTextBoxColumn1.DataPropertyName = "Jenis Makanan"
        Me.JenisMakananDataGridViewTextBoxColumn1.HeaderText = "Jenis Makanan"
        Me.JenisMakananDataGridViewTextBoxColumn1.Name = "JenisMakananDataGridViewTextBoxColumn1"
        Me.JenisMakananDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamaMakananDataGridViewTextBoxColumn
        '
        Me.NamaMakananDataGridViewTextBoxColumn.DataPropertyName = "Nama Makanan"
        Me.NamaMakananDataGridViewTextBoxColumn.HeaderText = "Nama Makanan"
        Me.NamaMakananDataGridViewTextBoxColumn.Name = "NamaMakananDataGridViewTextBoxColumn"
        Me.NamaMakananDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KhasDataGridViewTextBoxColumn
        '
        Me.KhasDataGridViewTextBoxColumn.DataPropertyName = "Khas"
        Me.KhasDataGridViewTextBoxColumn.HeaderText = "Khas"
        Me.KhasDataGridViewTextBoxColumn.Name = "KhasDataGridViewTextBoxColumn"
        Me.KhasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuasanaDataGridViewTextBoxColumn
        '
        Me.SuasanaDataGridViewTextBoxColumn.DataPropertyName = "Suasana"
        Me.SuasanaDataGridViewTextBoxColumn.HeaderText = "Suasana"
        Me.SuasanaDataGridViewTextBoxColumn.Name = "SuasanaDataGridViewTextBoxColumn"
        Me.SuasanaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KoordinatDataGridViewTextBoxColumn
        '
        Me.KoordinatDataGridViewTextBoxColumn.DataPropertyName = "Koordinat"
        Me.KoordinatDataGridViewTextBoxColumn.HeaderText = "Koordinat"
        Me.KoordinatDataGridViewTextBoxColumn.Name = "KoordinatDataGridViewTextBoxColumn"
        Me.KoordinatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DaftarResto
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 430)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.FasilitasCheckedListBox)
        Me.Controls.Add(Me.btnTentukanLokasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(TutupLabel)
        Me.Controls.Add(Me.TutupComboBox)
        Me.Controls.Add(BukaLabel)
        Me.Controls.Add(Me.BukaComboBox)
        Me.Controls.Add(Nama_MakananLabel)
        Me.Controls.Add(Me.Nama_MakananTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(HargaLabel)
        Me.Controls.Add(Me.HargaTextBox)
        Me.Controls.Add(KoordinatLabel)
        Me.Controls.Add(Me.KoordinatTextBox)
        Me.Controls.Add(SuasanaLabel)
        Me.Controls.Add(Me.SuasanaComboBox)
        Me.Controls.Add(KhasLabel)
        Me.Controls.Add(Me.KhasComboBox)
        Me.Controls.Add(Jenis_MakananLabel)
        Me.Controls.Add(Me.Jenis_MakananComboBox)
        Me.Controls.Add(Nama_RestoLabel)
        Me.Controls.Add(Me.Nama_RestoTextBox)
        Me.Controls.Add(Me.RestoDataGridView)
        Me.Controls.Add(Me.RestoBindingNavigator)
        Me.Name = "DaftarResto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Resto"
        CType(Me.RestoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RestoBindingNavigator.ResumeLayout(False)
        Me.RestoBindingNavigator.PerformLayout()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuasanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktuBukaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        '        CType(Me.KecamatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '       CType(Me.KelurahanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents DataSetDani As SpkKulinerGE.DataSetDani
    Friend WithEvents RestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RestoTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.RestoTableAdapter
    Friend WithEvents TableAdapterManager As SpkKulinerGE.DataSetDaniTableAdapters.TableAdapterManager
    Friend WithEvents RestoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RestoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RestoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nama_RestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jenis_MakananComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KhasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SuasanaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KoordinatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jenis_MakananTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Jenis_MakananTableAdapter
    Friend WithEvents JenisMakananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KhasTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KhasTableAdapter
    Friend WithEvents KhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuasanaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.SuasanaTableAdapter
    Friend WithEvents KhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SuasanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Waktu_BukaTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.Waktu_BukaTableAdapter
    Friend WithEvents WaktuBukaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_MakananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaRestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisMakananDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents KecamatanTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KecamatanTableAdapter
    Friend WithEvents KecamatanBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents KelurahanTableAdapter As SpkKulinerGE.DataSetDaniTableAdapters.KelurahanTableAdapter
    Friend WithEvents KelurahanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BukaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TutupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTentukanLokasi As System.Windows.Forms.Button
    Friend WithEvents FasilitasCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NamaRestoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisMakananDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaMakananDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KhasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuasanaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KoordinatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
