<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRacun
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
        Me.components = New System.ComponentModel.Container()
        Dim BrojRacunaLabel As System.Windows.Forms.Label
        Dim GodinaLabel As System.Windows.Forms.Label
        Dim KupacIDLabel As System.Windows.Forms.Label
        Dim ProizvodIDLabel As System.Windows.Forms.Label
        Dim DatumLabel As System.Windows.Forms.Label
        Dim KolicinaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRacun))
        Me.BorzalDataSet = New Borzal.BorzalDataSet()
        Me.RacunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RacunTableAdapter = New Borzal.BorzalDataSetTableAdapters.RacunTableAdapter()
        Me.TableAdapterManager = New Borzal.BorzalDataSetTableAdapters.TableAdapterManager()
        Me.KupacTableAdapter = New Borzal.BorzalDataSetTableAdapters.KupacTableAdapter()
        Me.ProizvodTableAdapter = New Borzal.BorzalDataSetTableAdapters.ProizvodTableAdapter()
        Me.RacunBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RacunBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BrojRacunaTextBox = New System.Windows.Forms.TextBox()
        Me.GodinaTextBox = New System.Windows.Forms.TextBox()
        Me.DatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.KupacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProizvodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KolicinaTextBox = New System.Windows.Forms.TextBox()
        BrojRacunaLabel = New System.Windows.Forms.Label()
        GodinaLabel = New System.Windows.Forms.Label()
        KupacIDLabel = New System.Windows.Forms.Label()
        ProizvodIDLabel = New System.Windows.Forms.Label()
        DatumLabel = New System.Windows.Forms.Label()
        KolicinaLabel = New System.Windows.Forms.Label()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RacunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RacunBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RacunBindingNavigator.SuspendLayout()
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProizvodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrojRacunaLabel
        '
        BrojRacunaLabel.AutoSize = True
        BrojRacunaLabel.Location = New System.Drawing.Point(95, 80)
        BrojRacunaLabel.Name = "BrojRacunaLabel"
        BrojRacunaLabel.Size = New System.Drawing.Size(69, 13)
        BrojRacunaLabel.TabIndex = 1
        BrojRacunaLabel.Text = "Broj Racuna:"
        '
        'GodinaLabel
        '
        GodinaLabel.AutoSize = True
        GodinaLabel.Location = New System.Drawing.Point(95, 113)
        GodinaLabel.Name = "GodinaLabel"
        GodinaLabel.Size = New System.Drawing.Size(44, 13)
        GodinaLabel.TabIndex = 3
        GodinaLabel.Text = "Godina:"
        '
        'KupacIDLabel
        '
        KupacIDLabel.AutoSize = True
        KupacIDLabel.Location = New System.Drawing.Point(95, 147)
        KupacIDLabel.Name = "KupacIDLabel"
        KupacIDLabel.Size = New System.Drawing.Size(55, 13)
        KupacIDLabel.TabIndex = 5
        KupacIDLabel.Text = "Kupac ID:"
        '
        'ProizvodIDLabel
        '
        ProizvodIDLabel.AutoSize = True
        ProizvodIDLabel.Location = New System.Drawing.Point(95, 181)
        ProizvodIDLabel.Name = "ProizvodIDLabel"
        ProizvodIDLabel.Size = New System.Drawing.Size(65, 13)
        ProizvodIDLabel.TabIndex = 7
        ProizvodIDLabel.Text = "Proizvod ID:"
        '
        'DatumLabel
        '
        DatumLabel.AutoSize = True
        DatumLabel.Location = New System.Drawing.Point(95, 243)
        DatumLabel.Name = "DatumLabel"
        DatumLabel.Size = New System.Drawing.Size(41, 13)
        DatumLabel.TabIndex = 9
        DatumLabel.Text = "Datum:"
        '
        'KolicinaLabel
        '
        KolicinaLabel.AutoSize = True
        KolicinaLabel.Location = New System.Drawing.Point(95, 217)
        KolicinaLabel.Name = "KolicinaLabel"
        KolicinaLabel.Size = New System.Drawing.Size(47, 13)
        KolicinaLabel.TabIndex = 11
        KolicinaLabel.Text = "Kolicina:"
        '
        'BorzalDataSet
        '
        Me.BorzalDataSet.DataSetName = "BorzalDataSet"
        Me.BorzalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RacunBindingSource
        '
        Me.RacunBindingSource.DataMember = "Racun"
        Me.RacunBindingSource.DataSource = Me.BorzalDataSet
        '
        'RacunTableAdapter
        '
        Me.RacunTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KupacTableAdapter = Me.KupacTableAdapter
        Me.TableAdapterManager.ProizvodTableAdapter = Me.ProizvodTableAdapter
        Me.TableAdapterManager.RacunTableAdapter = Me.RacunTableAdapter
        Me.TableAdapterManager.UpdateOrder = Borzal.BorzalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KupacTableAdapter
        '
        Me.KupacTableAdapter.ClearBeforeFill = True
        '
        'ProizvodTableAdapter
        '
        Me.ProizvodTableAdapter.ClearBeforeFill = True
        '
        'RacunBindingNavigator
        '
        Me.RacunBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RacunBindingNavigator.BindingSource = Me.RacunBindingSource
        Me.RacunBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RacunBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RacunBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RacunBindingNavigatorSaveItem})
        Me.RacunBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RacunBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RacunBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RacunBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RacunBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RacunBindingNavigator.Name = "RacunBindingNavigator"
        Me.RacunBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RacunBindingNavigator.Size = New System.Drawing.Size(791, 25)
        Me.RacunBindingNavigator.TabIndex = 0
        Me.RacunBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        'RacunBindingNavigatorSaveItem
        '
        Me.RacunBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RacunBindingNavigatorSaveItem.Image = CType(resources.GetObject("RacunBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RacunBindingNavigatorSaveItem.Name = "RacunBindingNavigatorSaveItem"
        Me.RacunBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RacunBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BrojRacunaTextBox
        '
        Me.BrojRacunaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RacunBindingSource, "BrojRacuna", True))
        Me.BrojRacunaTextBox.Location = New System.Drawing.Point(170, 80)
        Me.BrojRacunaTextBox.Name = "BrojRacunaTextBox"
        Me.BrojRacunaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BrojRacunaTextBox.TabIndex = 0
        '
        'GodinaTextBox
        '
        Me.GodinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RacunBindingSource, "Godina", True))
        Me.GodinaTextBox.Location = New System.Drawing.Point(170, 113)
        Me.GodinaTextBox.Name = "GodinaTextBox"
        Me.GodinaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GodinaTextBox.TabIndex = 1
        '
        'DatumDateTimePicker
        '
        Me.DatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RacunBindingSource, "Datum", True))
        Me.DatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RacunBindingSource, "Datum", True))
        Me.DatumDateTimePicker.Location = New System.Drawing.Point(170, 243)
        Me.DatumDateTimePicker.Name = "DatumDateTimePicker"
        Me.DatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumDateTimePicker.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RacunBindingSource, "KupacID", True))
        Me.ComboBox1.DataSource = Me.KupacBindingSource
        Me.ComboBox1.DisplayMember = "Naziv"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(170, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "KupacId"
        '
        'KupacBindingSource
        '
        Me.KupacBindingSource.DataMember = "Kupac"
        Me.KupacBindingSource.DataSource = Me.BorzalDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RacunBindingSource, "ProizvodID", True))
        Me.ComboBox2.DataSource = Me.ProizvodBindingSource
        Me.ComboBox2.DisplayMember = "Naziv"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(170, 180)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "ProizvodId"
        '
        'ProizvodBindingSource
        '
        Me.ProizvodBindingSource.DataMember = "Proizvod"
        Me.ProizvodBindingSource.DataSource = Me.BorzalDataSet
        '
        'KolicinaTextBox
        '
        Me.KolicinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RacunBindingSource, "Kolicina", True))
        Me.KolicinaTextBox.Location = New System.Drawing.Point(170, 217)
        Me.KolicinaTextBox.Name = "KolicinaTextBox"
        Me.KolicinaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KolicinaTextBox.TabIndex = 4
        '
        'frmRacun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 520)
        Me.Controls.Add(KolicinaLabel)
        Me.Controls.Add(Me.KolicinaTextBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(BrojRacunaLabel)
        Me.Controls.Add(Me.BrojRacunaTextBox)
        Me.Controls.Add(GodinaLabel)
        Me.Controls.Add(Me.GodinaTextBox)
        Me.Controls.Add(KupacIDLabel)
        Me.Controls.Add(ProizvodIDLabel)
        Me.Controls.Add(DatumLabel)
        Me.Controls.Add(Me.DatumDateTimePicker)
        Me.Controls.Add(Me.RacunBindingNavigator)
        Me.Name = "frmRacun"
        Me.Text = "RAČUN"
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RacunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RacunBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RacunBindingNavigator.ResumeLayout(False)
        Me.RacunBindingNavigator.PerformLayout()
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProizvodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorzalDataSet As Borzal.BorzalDataSet
    Friend WithEvents RacunBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RacunTableAdapter As Borzal.BorzalDataSetTableAdapters.RacunTableAdapter
    Friend WithEvents TableAdapterManager As Borzal.BorzalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RacunBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RacunBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrojRacunaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GodinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents KupacTableAdapter As Borzal.BorzalDataSetTableAdapters.KupacTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents KupacBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProizvodTableAdapter As Borzal.BorzalDataSetTableAdapters.ProizvodTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ProizvodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KolicinaTextBox As System.Windows.Forms.TextBox
End Class
