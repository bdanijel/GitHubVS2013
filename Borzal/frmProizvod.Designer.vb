<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProizvod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProizvod))
        Dim ProizvodIdLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Me.BorzalDataSet = New Borzal.BorzalDataSet()
        Me.ProizvodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProizvodTableAdapter = New Borzal.BorzalDataSetTableAdapters.ProizvodTableAdapter()
        Me.TableAdapterManager = New Borzal.BorzalDataSetTableAdapters.TableAdapterManager()
        Me.ProizvodBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProizvodBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProizvodIdTextBox = New System.Windows.Forms.TextBox()
        Me.NazivTextBox = New System.Windows.Forms.TextBox()
        ProizvodIdLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProizvodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProizvodBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProizvodBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorzalDataSet
        '
        Me.BorzalDataSet.DataSetName = "BorzalDataSet"
        Me.BorzalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProizvodBindingSource
        '
        Me.ProizvodBindingSource.DataMember = "Proizvod"
        Me.ProizvodBindingSource.DataSource = Me.BorzalDataSet
        '
        'ProizvodTableAdapter
        '
        Me.ProizvodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KupacTableAdapter = Nothing
        Me.TableAdapterManager.ProizvodTableAdapter = Me.ProizvodTableAdapter
        Me.TableAdapterManager.RacunTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Borzal.BorzalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProizvodBindingNavigator
        '
        Me.ProizvodBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProizvodBindingNavigator.BindingSource = Me.ProizvodBindingSource
        Me.ProizvodBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProizvodBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProizvodBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProizvodBindingNavigatorSaveItem})
        Me.ProizvodBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProizvodBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProizvodBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProizvodBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProizvodBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProizvodBindingNavigator.Name = "ProizvodBindingNavigator"
        Me.ProizvodBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProizvodBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.ProizvodBindingNavigator.TabIndex = 0
        Me.ProizvodBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProizvodBindingNavigatorSaveItem
        '
        Me.ProizvodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProizvodBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProizvodBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProizvodBindingNavigatorSaveItem.Name = "ProizvodBindingNavigatorSaveItem"
        Me.ProizvodBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProizvodBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProizvodIdLabel
        '
        ProizvodIdLabel.AutoSize = True
        ProizvodIdLabel.Location = New System.Drawing.Point(72, 52)
        ProizvodIdLabel.Name = "ProizvodIdLabel"
        ProizvodIdLabel.Size = New System.Drawing.Size(63, 13)
        ProizvodIdLabel.TabIndex = 1
        ProizvodIdLabel.Text = "Proizvod Id:"
        '
        'ProizvodIdTextBox
        '
        Me.ProizvodIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProizvodBindingSource, "ProizvodId", True))
        Me.ProizvodIdTextBox.Location = New System.Drawing.Point(141, 49)
        Me.ProizvodIdTextBox.Name = "ProizvodIdTextBox"
        Me.ProizvodIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProizvodIdTextBox.TabIndex = 2
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.Location = New System.Drawing.Point(72, 78)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(37, 13)
        NazivLabel.TabIndex = 3
        NazivLabel.Text = "Naziv:"
        '
        'NazivTextBox
        '
        Me.NazivTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProizvodBindingSource, "Naziv", True))
        Me.NazivTextBox.Location = New System.Drawing.Point(141, 75)
        Me.NazivTextBox.Name = "NazivTextBox"
        Me.NazivTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NazivTextBox.TabIndex = 4
        '
        'frmProizvod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(ProizvodIdLabel)
        Me.Controls.Add(Me.ProizvodIdTextBox)
        Me.Controls.Add(NazivLabel)
        Me.Controls.Add(Me.NazivTextBox)
        Me.Controls.Add(Me.ProizvodBindingNavigator)
        Me.Name = "frmProizvod"
        Me.Text = "PROIZVOD"
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProizvodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProizvodBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProizvodBindingNavigator.ResumeLayout(False)
        Me.ProizvodBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorzalDataSet As Borzal.BorzalDataSet
    Friend WithEvents ProizvodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProizvodTableAdapter As Borzal.BorzalDataSetTableAdapters.ProizvodTableAdapter
    Friend WithEvents TableAdapterManager As Borzal.BorzalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProizvodBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProizvodBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProizvodIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazivTextBox As System.Windows.Forms.TextBox
End Class
