<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKupci
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
        Dim KupacIdLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim KbrLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKupci))
        Me.KupacBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.KupacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorzalDataSet = New Borzal.BorzalDataSet()
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
        Me.KupacBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NazivTextBox = New System.Windows.Forms.TextBox()
        Me.MestoTextBox = New System.Windows.Forms.TextBox()
        Me.AdresaTextBox = New System.Windows.Forms.TextBox()
        Me.KbrTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gr1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.KupacTableAdapter = New Borzal.BorzalDataSetTableAdapters.KupacTableAdapter()
        Me.TableAdapterManager = New Borzal.BorzalDataSetTableAdapters.TableAdapterManager()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        KupacIdLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        MestoLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        KbrLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.KupacBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KupacBindingNavigator.SuspendLayout()
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KupacIdLabel
        '
        KupacIdLabel.AutoSize = True
        KupacIdLabel.Location = New System.Drawing.Point(15, 122)
        KupacIdLabel.Name = "KupacIdLabel"
        KupacIdLabel.Size = New System.Drawing.Size(53, 13)
        KupacIdLabel.TabIndex = 1
        KupacIdLabel.Text = "Kupac Id:"
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.Location = New System.Drawing.Point(15, 148)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(37, 13)
        NazivLabel.TabIndex = 3
        NazivLabel.Text = "Naziv:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(15, 174)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(39, 13)
        MestoLabel.TabIndex = 5
        MestoLabel.Text = "Mesto:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(15, 200)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 7
        AdresaLabel.Text = "Adresa:"
        '
        'KbrLabel
        '
        KbrLabel.AutoSize = True
        KbrLabel.Location = New System.Drawing.Point(15, 226)
        KbrLabel.Name = "KbrLabel"
        KbrLabel.Size = New System.Drawing.Size(25, 13)
        KbrLabel.TabIndex = 9
        KbrLabel.Text = "kbr:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(15, 252)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 11
        TelefonLabel.Text = "Telefon:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Label2.Location = New System.Drawing.Point(12, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(103, 31)
        Label2.TabIndex = 14
        Label2.Text = "KUPCI"
        '
        'KupacBindingNavigator
        '
        Me.KupacBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KupacBindingNavigator.BindingSource = Me.KupacBindingSource
        Me.KupacBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KupacBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KupacBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KupacBindingNavigatorSaveItem})
        Me.KupacBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KupacBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KupacBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KupacBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KupacBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KupacBindingNavigator.Name = "KupacBindingNavigator"
        Me.KupacBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KupacBindingNavigator.Size = New System.Drawing.Size(311, 25)
        Me.KupacBindingNavigator.TabIndex = 0
        Me.KupacBindingNavigator.Text = "BindingNavigator1"
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
        'KupacBindingSource
        '
        Me.KupacBindingSource.DataMember = "Kupac"
        Me.KupacBindingSource.DataSource = Me.BorzalDataSet
        '
        'BorzalDataSet
        '
        Me.BorzalDataSet.DataSetName = "BorzalDataSet"
        Me.BorzalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'KupacBindingNavigatorSaveItem
        '
        Me.KupacBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KupacBindingNavigatorSaveItem.Image = CType(resources.GetObject("KupacBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KupacBindingNavigatorSaveItem.Name = "KupacBindingNavigatorSaveItem"
        Me.KupacBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KupacBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazivTextBox
        '
        Me.NazivTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "Naziv", True))
        Me.NazivTextBox.Location = New System.Drawing.Point(74, 145)
        Me.NazivTextBox.Name = "NazivTextBox"
        Me.NazivTextBox.Size = New System.Drawing.Size(178, 20)
        Me.NazivTextBox.TabIndex = 0
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "Mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(74, 171)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(178, 20)
        Me.MestoTextBox.TabIndex = 1
        '
        'AdresaTextBox
        '
        Me.AdresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "Adresa", True))
        Me.AdresaTextBox.Location = New System.Drawing.Point(74, 197)
        Me.AdresaTextBox.Name = "AdresaTextBox"
        Me.AdresaTextBox.Size = New System.Drawing.Size(178, 20)
        Me.AdresaTextBox.TabIndex = 2
        '
        'KbrTextBox
        '
        Me.KbrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "kbr", True))
        Me.KbrTextBox.Location = New System.Drawing.Point(74, 223)
        Me.KbrTextBox.Name = "KbrTextBox"
        Me.KbrTextBox.Size = New System.Drawing.Size(40, 20)
        Me.KbrTextBox.TabIndex = 3
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "Telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(74, 249)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TelefonTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.KupacBindingSource, "KupacId", True))
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KupacBindingSource, "KupacId", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Label1.Location = New System.Drawing.Point(75, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'gr1
        '
        Me.gr1.ContainerControl = Me
        '
        'KupacTableAdapter
        '
        Me.KupacTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KupacTableAdapter = Me.KupacTableAdapter
        Me.TableAdapterManager.ProizvodTableAdapter = Nothing
        Me.TableAdapterManager.RacunTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Borzal.BorzalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmKupci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(311, 305)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(KupacIdLabel)
        Me.Controls.Add(NazivLabel)
        Me.Controls.Add(Me.NazivTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(AdresaLabel)
        Me.Controls.Add(Me.AdresaTextBox)
        Me.Controls.Add(KbrLabel)
        Me.Controls.Add(Me.KbrTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Me.KupacBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmKupci"
        Me.Text = "KUPCI"
        CType(Me.KupacBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KupacBindingNavigator.ResumeLayout(False)
        Me.KupacBindingNavigator.PerformLayout()
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorzalDataSet As Borzal.BorzalDataSet
    Friend WithEvents KupacBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KupacTableAdapter As Borzal.BorzalDataSetTableAdapters.KupacTableAdapter
    Friend WithEvents TableAdapterManager As Borzal.BorzalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KupacBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents KupacBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazivTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KbrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gr1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
