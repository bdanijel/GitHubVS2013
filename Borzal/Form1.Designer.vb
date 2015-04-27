<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.KupacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorzalDataSet = New Borzal.BorzalDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DfadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DfaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FdfToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DfdfdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.FsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.KupacTableAdapter = New Borzal.BorzalDataSetTableAdapters.KupacTableAdapter()
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(110, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DfadToolStripMenuItem, Me.FsdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DfadToolStripMenuItem
        '
        Me.DfadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DfaToolStripMenuItem, Me.FadToolStripMenuItem, Me.ToolStripSeparator1, Me.FdfToolStripMenuItem1, Me.ToolStripTextBox1, Me.DfdfdfToolStripMenuItem, Me.ToolStripComboBox1})
        Me.DfadToolStripMenuItem.Name = "DfadToolStripMenuItem"
        Me.DfadToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DfadToolStripMenuItem.Text = "dfad"
        '
        'DfaToolStripMenuItem
        '
        Me.DfaToolStripMenuItem.Name = "DfaToolStripMenuItem"
        Me.DfaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DfaToolStripMenuItem.Text = "dfa"
        '
        'FadToolStripMenuItem
        '
        Me.FadToolStripMenuItem.Name = "FadToolStripMenuItem"
        Me.FadToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.FadToolStripMenuItem.Text = "fad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'FdfToolStripMenuItem1
        '
        Me.FdfToolStripMenuItem1.Name = "FdfToolStripMenuItem1"
        Me.FdfToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.FdfToolStripMenuItem1.Text = "fdf"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'DfdfdfToolStripMenuItem
        '
        Me.DfdfdfToolStripMenuItem.Name = "DfdfdfToolStripMenuItem"
        Me.DfdfdfToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DfdfdfToolStripMenuItem.Text = "dfdfdf"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'FsdToolStripMenuItem
        '
        Me.FsdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FdfToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.FsdToolStripMenuItem.Name = "FsdToolStripMenuItem"
        Me.FsdToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FsdToolStripMenuItem.Text = "fsd"
        '
        'FdfToolStripMenuItem
        '
        Me.FdfToolStripMenuItem.Name = "FdfToolStripMenuItem"
        Me.FdfToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FdfToolStripMenuItem.Text = "fdf"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "23"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "443"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 442)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(905, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.KupacBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Borzal.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(216, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(677, 414)
        Me.ReportViewer1.TabIndex = 5
        '
        'KupacTableAdapter
        '
        Me.KupacTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 464)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.KupacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorzalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DfadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DfaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FdfToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DfdfdfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FdfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KupacBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BorzalDataSet As Borzal.BorzalDataSet
    Friend WithEvents KupacTableAdapter As Borzal.BorzalDataSetTableAdapters.KupacTableAdapter
End Class
