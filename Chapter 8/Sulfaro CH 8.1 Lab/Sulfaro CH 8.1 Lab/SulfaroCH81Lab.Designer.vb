<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SulfaroCH81Lab
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
        Me.gbx811 = New System.Windows.Forms.GroupBox()
        Me.lst811After = New System.Windows.Forms.ListBox()
        Me.lst811Before = New System.Windows.Forms.ListBox()
        Me.btn811Sort = New System.Windows.Forms.Button()
        Me.gbx812 = New System.Windows.Forms.GroupBox()
        Me.btn812Sort = New System.Windows.Forms.Button()
        Me.dgv812Output = New System.Windows.Forms.DataGridView()
        Me.gbx815 = New System.Windows.Forms.GroupBox()
        Me.btn815Except = New System.Windows.Forms.Button()
        Me.btn815Intersect = New System.Windows.Forms.Button()
        Me.btn815Union = New System.Windows.Forms.Button()
        Me.btn815Concat = New System.Windows.Forms.Button()
        Me.gbx819 = New System.Windows.Forms.GroupBox()
        Me.btn819Select = New System.Windows.Forms.Button()
        Me.lst819Output = New System.Windows.Forms.ListBox()
        Me.lst815Concat = New System.Windows.Forms.ListBox()
        Me.lst815Union = New System.Windows.Forms.ListBox()
        Me.lst815Inter = New System.Windows.Forms.ListBox()
        Me.lst815Except = New System.Windows.Forms.ListBox()
        Me.ofd819Select = New System.Windows.Forms.OpenFileDialog()
        Me.gbx811.SuspendLayout()
        Me.gbx812.SuspendLayout()
        CType(Me.dgv812Output, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx815.SuspendLayout()
        Me.gbx819.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx811
        '
        Me.gbx811.Controls.Add(Me.lst811After)
        Me.gbx811.Controls.Add(Me.lst811Before)
        Me.gbx811.Controls.Add(Me.btn811Sort)
        Me.gbx811.Location = New System.Drawing.Point(20, 18)
        Me.gbx811.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx811.Name = "gbx811"
        Me.gbx811.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx811.Size = New System.Drawing.Size(534, 433)
        Me.gbx811.TabIndex = 0
        Me.gbx811.TabStop = False
        Me.gbx811.Text = "EX 8.1.1 - US Presidents"
        '
        'lst811After
        '
        Me.lst811After.FormattingEnabled = True
        Me.lst811After.ItemHeight = 20
        Me.lst811After.Location = New System.Drawing.Point(279, 109)
        Me.lst811After.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst811After.Name = "lst811After"
        Me.lst811After.Size = New System.Drawing.Size(244, 304)
        Me.lst811After.TabIndex = 2
        '
        'lst811Before
        '
        Me.lst811Before.FormattingEnabled = True
        Me.lst811Before.ItemHeight = 20
        Me.lst811Before.Location = New System.Drawing.Point(9, 109)
        Me.lst811Before.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst811Before.Name = "lst811Before"
        Me.lst811Before.Size = New System.Drawing.Size(235, 304)
        Me.lst811Before.TabIndex = 1
        '
        'btn811Sort
        '
        Me.btn811Sort.Location = New System.Drawing.Point(117, 29)
        Me.btn811Sort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn811Sort.Name = "btn811Sort"
        Me.btn811Sort.Size = New System.Drawing.Size(279, 52)
        Me.btn811Sort.TabIndex = 0
        Me.btn811Sort.Text = "Sort the File AgeAtInauguration.txt"
        Me.btn811Sort.UseVisualStyleBackColor = True
        '
        'gbx812
        '
        Me.gbx812.Controls.Add(Me.btn812Sort)
        Me.gbx812.Controls.Add(Me.dgv812Output)
        Me.gbx812.Location = New System.Drawing.Point(224, 461)
        Me.gbx812.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx812.Name = "gbx812"
        Me.gbx812.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx812.Size = New System.Drawing.Size(346, 392)
        Me.gbx812.TabIndex = 1
        Me.gbx812.TabStop = False
        Me.gbx812.Text = "EX 8.1.2 - US Presidents"
        '
        'btn812Sort
        '
        Me.btn812Sort.Location = New System.Drawing.Point(42, 29)
        Me.btn812Sort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn812Sort.Name = "btn812Sort"
        Me.btn812Sort.Size = New System.Drawing.Size(248, 52)
        Me.btn812Sort.TabIndex = 1
        Me.btn812Sort.Text = "Sort the File AgeAtInaug.txt"
        Me.btn812Sort.UseVisualStyleBackColor = True
        '
        'dgv812Output
        '
        Me.dgv812Output.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv812Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv812Output.Location = New System.Drawing.Point(10, 91)
        Me.dgv812Output.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv812Output.Name = "dgv812Output"
        Me.dgv812Output.RowHeadersVisible = False
        Me.dgv812Output.Size = New System.Drawing.Size(328, 290)
        Me.dgv812Output.TabIndex = 0
        '
        'gbx815
        '
        Me.gbx815.Controls.Add(Me.btn815Except)
        Me.gbx815.Controls.Add(Me.btn815Intersect)
        Me.gbx815.Controls.Add(Me.btn815Union)
        Me.gbx815.Controls.Add(Me.btn815Concat)
        Me.gbx815.Location = New System.Drawing.Point(570, 18)
        Me.gbx815.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx815.Name = "gbx815"
        Me.gbx815.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx815.Size = New System.Drawing.Size(580, 258)
        Me.gbx815.TabIndex = 1
        Me.gbx815.TabStop = False
        Me.gbx815.Text = "EX 8.1.5 - Files"
        '
        'btn815Except
        '
        Me.btn815Except.Location = New System.Drawing.Point(9, 195)
        Me.btn815Except.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn815Except.Name = "btn815Except"
        Me.btn815Except.Size = New System.Drawing.Size(563, 46)
        Me.btn815Except.TabIndex = 3
        Me.btn815Except.Text = "Delete the Items int he Second File from the First File"
        Me.btn815Except.UseVisualStyleBackColor = True
        '
        'btn815Intersect
        '
        Me.btn815Intersect.Location = New System.Drawing.Point(9, 140)
        Me.btn815Intersect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn815Intersect.Name = "btn815Intersect"
        Me.btn815Intersect.Size = New System.Drawing.Size(563, 46)
        Me.btn815Intersect.TabIndex = 2
        Me.btn815Intersect.Text = "Find the Intersection of the Two Files"
        Me.btn815Intersect.UseVisualStyleBackColor = True
        '
        'btn815Union
        '
        Me.btn815Union.Location = New System.Drawing.Point(9, 85)
        Me.btn815Union.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn815Union.Name = "btn815Union"
        Me.btn815Union.Size = New System.Drawing.Size(563, 46)
        Me.btn815Union.TabIndex = 1
        Me.btn815Union.Text = "Concatenate the Two Files (without Repetitions)"
        Me.btn815Union.UseVisualStyleBackColor = True
        '
        'btn815Concat
        '
        Me.btn815Concat.Location = New System.Drawing.Point(9, 29)
        Me.btn815Concat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn815Concat.Name = "btn815Concat"
        Me.btn815Concat.Size = New System.Drawing.Size(563, 46)
        Me.btn815Concat.TabIndex = 0
        Me.btn815Concat.Text = "Concatenate the Two Files (with Repetitions)"
        Me.btn815Concat.UseVisualStyleBackColor = True
        '
        'gbx819
        '
        Me.gbx819.Controls.Add(Me.btn819Select)
        Me.gbx819.Controls.Add(Me.lst819Output)
        Me.gbx819.Location = New System.Drawing.Point(579, 595)
        Me.gbx819.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx819.Name = "gbx819"
        Me.gbx819.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx819.Size = New System.Drawing.Size(571, 258)
        Me.gbx819.TabIndex = 1
        Me.gbx819.TabStop = False
        Me.gbx819.Text = "EX 8.1.9 - Display a File"
        '
        'btn819Select
        '
        Me.btn819Select.Location = New System.Drawing.Point(19, 91)
        Me.btn819Select.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn819Select.Name = "btn819Select"
        Me.btn819Select.Size = New System.Drawing.Size(206, 52)
        Me.btn819Select.TabIndex = 1
        Me.btn819Select.Text = "Select a Text File"
        Me.btn819Select.UseVisualStyleBackColor = True
        '
        'lst819Output
        '
        Me.lst819Output.FormattingEnabled = True
        Me.lst819Output.ItemHeight = 20
        Me.lst819Output.Location = New System.Drawing.Point(237, 29)
        Me.lst819Output.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst819Output.Name = "lst819Output"
        Me.lst819Output.Size = New System.Drawing.Size(326, 224)
        Me.lst819Output.TabIndex = 0
        '
        'lst815Concat
        '
        Me.lst815Concat.FormattingEnabled = True
        Me.lst815Concat.ItemHeight = 20
        Me.lst815Concat.Location = New System.Drawing.Point(578, 286)
        Me.lst815Concat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst815Concat.Name = "lst815Concat"
        Me.lst815Concat.Size = New System.Drawing.Size(278, 144)
        Me.lst815Concat.TabIndex = 2
        '
        'lst815Union
        '
        Me.lst815Union.FormattingEnabled = True
        Me.lst815Union.ItemHeight = 20
        Me.lst815Union.Location = New System.Drawing.Point(864, 286)
        Me.lst815Union.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst815Union.Name = "lst815Union"
        Me.lst815Union.Size = New System.Drawing.Size(286, 144)
        Me.lst815Union.TabIndex = 4
        '
        'lst815Inter
        '
        Me.lst815Inter.FormattingEnabled = True
        Me.lst815Inter.ItemHeight = 20
        Me.lst815Inter.Location = New System.Drawing.Point(578, 441)
        Me.lst815Inter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst815Inter.Name = "lst815Inter"
        Me.lst815Inter.Size = New System.Drawing.Size(278, 144)
        Me.lst815Inter.TabIndex = 6
        '
        'lst815Except
        '
        Me.lst815Except.FormattingEnabled = True
        Me.lst815Except.ItemHeight = 20
        Me.lst815Except.Location = New System.Drawing.Point(864, 441)
        Me.lst815Except.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst815Except.Name = "lst815Except"
        Me.lst815Except.Size = New System.Drawing.Size(286, 144)
        Me.lst815Except.TabIndex = 8
        '
        'ofd819Select
        '
        Me.ofd819Select.Filter = "Text Documents (*.txt)|*.txt"
        '
        'SulfaroCH81Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 867)
        Me.Controls.Add(Me.lst815Except)
        Me.Controls.Add(Me.lst815Inter)
        Me.Controls.Add(Me.lst815Union)
        Me.Controls.Add(Me.lst815Concat)
        Me.Controls.Add(Me.gbx812)
        Me.Controls.Add(Me.gbx815)
        Me.Controls.Add(Me.gbx819)
        Me.Controls.Add(Me.gbx811)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SulfaroCH81Lab"
        Me.Text = "Sulfaro CH 8.1 Lab"
        Me.gbx811.ResumeLayout(False)
        Me.gbx812.ResumeLayout(False)
        CType(Me.dgv812Output, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx815.ResumeLayout(False)
        Me.gbx819.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx811 As GroupBox
    Friend WithEvents lst811After As ListBox
    Friend WithEvents lst811Before As ListBox
    Friend WithEvents btn811Sort As Button
    Friend WithEvents gbx812 As GroupBox
    Friend WithEvents gbx815 As GroupBox
    Friend WithEvents gbx819 As GroupBox
    Friend WithEvents btn812Sort As Button
    Friend WithEvents dgv812Output As DataGridView
    Friend WithEvents btn815Except As Button
    Friend WithEvents btn815Intersect As Button
    Friend WithEvents btn815Union As Button
    Friend WithEvents btn815Concat As Button
    Friend WithEvents lst819Output As ListBox
    Friend WithEvents btn819Select As Button
    Friend WithEvents lst815Concat As ListBox
    Friend WithEvents lst815Union As ListBox
    Friend WithEvents lst815Inter As ListBox
    Friend WithEvents lst815Except As ListBox
    Friend WithEvents ofd819Select As OpenFileDialog
End Class
