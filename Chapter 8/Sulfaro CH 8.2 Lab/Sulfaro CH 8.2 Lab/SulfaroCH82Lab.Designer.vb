<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SulfaroCH82Lab
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
        Me.gbx821 = New System.Windows.Forms.GroupBox()
        Me.gbx822 = New System.Windows.Forms.GroupBox()
        Me.gbx823 = New System.Windows.Forms.GroupBox()
        Me.gbx824 = New System.Windows.Forms.GroupBox()
        Me.lbl821Abbreviation = New System.Windows.Forms.Label()
        Me.txt821Name = New System.Windows.Forms.TextBox()
        Me.btn821Find = New System.Windows.Forms.Button()
        Me.mtb821Abbr = New System.Windows.Forms.MaskedTextBox()
        Me.btn822CreateFile = New System.Windows.Forms.Button()
        Me.btn822DisplayFile = New System.Windows.Forms.Button()
        Me.lst822Names = New System.Windows.Forms.ListBox()
        Me.lbl823Name = New System.Windows.Forms.Label()
        Me.txt823Name = New System.Windows.Forms.TextBox()
        Me.btn823Add = New System.Windows.Forms.Button()
        Me.btn823Determine = New System.Windows.Forms.Button()
        Me.btn823Delete = New System.Windows.Forms.Button()
        Me.btn824Display = New System.Windows.Forms.Button()
        Me.gbx821.SuspendLayout()
        Me.gbx822.SuspendLayout()
        Me.gbx823.SuspendLayout()
        Me.gbx824.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx821
        '
        Me.gbx821.Controls.Add(Me.mtb821Abbr)
        Me.gbx821.Controls.Add(Me.btn821Find)
        Me.gbx821.Controls.Add(Me.txt821Name)
        Me.gbx821.Controls.Add(Me.lbl821Abbreviation)
        Me.gbx821.Location = New System.Drawing.Point(18, 18)
        Me.gbx821.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx821.Name = "gbx821"
        Me.gbx821.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx821.Size = New System.Drawing.Size(398, 309)
        Me.gbx821.TabIndex = 0
        Me.gbx821.TabStop = False
        Me.gbx821.Text = "EX 8.2.1 - US States "
        '
        'gbx822
        '
        Me.gbx822.Controls.Add(Me.lst822Names)
        Me.gbx822.Controls.Add(Me.btn822DisplayFile)
        Me.gbx822.Controls.Add(Me.btn822CreateFile)
        Me.gbx822.Location = New System.Drawing.Point(424, 18)
        Me.gbx822.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx822.Name = "gbx822"
        Me.gbx822.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx822.Size = New System.Drawing.Size(396, 309)
        Me.gbx822.TabIndex = 1
        Me.gbx822.TabStop = False
        Me.gbx822.Text = "EX 8.2.2 - Computing Pioneers"
        '
        'gbx823
        '
        Me.gbx823.Controls.Add(Me.btn823Delete)
        Me.gbx823.Controls.Add(Me.btn823Determine)
        Me.gbx823.Controls.Add(Me.btn823Add)
        Me.gbx823.Controls.Add(Me.txt823Name)
        Me.gbx823.Controls.Add(Me.lbl823Name)
        Me.gbx823.Location = New System.Drawing.Point(18, 337)
        Me.gbx823.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx823.Name = "gbx823"
        Me.gbx823.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx823.Size = New System.Drawing.Size(398, 277)
        Me.gbx823.TabIndex = 1
        Me.gbx823.TabStop = False
        Me.gbx823.Text = "EX 8.2.3 - Manage File "
        '
        'gbx824
        '
        Me.gbx824.Controls.Add(Me.btn824Display)
        Me.gbx824.Location = New System.Drawing.Point(424, 337)
        Me.gbx824.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx824.Name = "gbx824"
        Me.gbx824.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbx824.Size = New System.Drawing.Size(396, 277)
        Me.gbx824.TabIndex = 1
        Me.gbx824.TabStop = False
        Me.gbx824.Text = "EX 8.2.4 - Structured Exception Handling"
        '
        'lbl821Abbreviation
        '
        Me.lbl821Abbreviation.AutoSize = True
        Me.lbl821Abbreviation.Location = New System.Drawing.Point(37, 39)
        Me.lbl821Abbreviation.Name = "lbl821Abbreviation"
        Me.lbl821Abbreviation.Size = New System.Drawing.Size(142, 20)
        Me.lbl821Abbreviation.TabIndex = 0
        Me.lbl821Abbreviation.Text = "State abbreviation:"
        '
        'txt821Name
        '
        Me.txt821Name.Location = New System.Drawing.Point(100, 225)
        Me.txt821Name.Name = "txt821Name"
        Me.txt821Name.ReadOnly = True
        Me.txt821Name.Size = New System.Drawing.Size(136, 26)
        Me.txt821Name.TabIndex = 1
        '
        'btn821Find
        '
        Me.btn821Find.Location = New System.Drawing.Point(77, 115)
        Me.btn821Find.Name = "btn821Find"
        Me.btn821Find.Size = New System.Drawing.Size(187, 51)
        Me.btn821Find.TabIndex = 2
        Me.btn821Find.Text = "Find Name of State"
        Me.btn821Find.UseVisualStyleBackColor = True
        '
        'mtb821Abbr
        '
        Me.mtb821Abbr.Location = New System.Drawing.Point(186, 39)
        Me.mtb821Abbr.Mask = "LL"
        Me.mtb821Abbr.Name = "mtb821Abbr"
        Me.mtb821Abbr.Size = New System.Drawing.Size(50, 26)
        Me.mtb821Abbr.TabIndex = 3
        '
        'btn822CreateFile
        '
        Me.btn822CreateFile.Location = New System.Drawing.Point(20, 73)
        Me.btn822CreateFile.Name = "btn822CreateFile"
        Me.btn822CreateFile.Size = New System.Drawing.Size(157, 58)
        Me.btn822CreateFile.TabIndex = 0
        Me.btn822CreateFile.Text = "Create File"
        Me.btn822CreateFile.UseVisualStyleBackColor = True
        '
        'btn822DisplayFile
        '
        Me.btn822DisplayFile.Location = New System.Drawing.Point(20, 190)
        Me.btn822DisplayFile.Name = "btn822DisplayFile"
        Me.btn822DisplayFile.Size = New System.Drawing.Size(157, 61)
        Me.btn822DisplayFile.TabIndex = 1
        Me.btn822DisplayFile.Text = "Display File"
        Me.btn822DisplayFile.UseVisualStyleBackColor = True
        '
        'lst822Names
        '
        Me.lst822Names.FormattingEnabled = True
        Me.lst822Names.ItemHeight = 20
        Me.lst822Names.Location = New System.Drawing.Point(183, 39)
        Me.lst822Names.Name = "lst822Names"
        Me.lst822Names.Size = New System.Drawing.Size(206, 264)
        Me.lst822Names.TabIndex = 2
        '
        'lbl823Name
        '
        Me.lbl823Name.AutoSize = True
        Me.lbl823Name.Location = New System.Drawing.Point(23, 40)
        Me.lbl823Name.Name = "lbl823Name"
        Me.lbl823Name.Size = New System.Drawing.Size(55, 20)
        Me.lbl823Name.TabIndex = 0
        Me.lbl823Name.Text = "Name:"
        '
        'txt823Name
        '
        Me.txt823Name.Location = New System.Drawing.Point(85, 40)
        Me.txt823Name.Name = "txt823Name"
        Me.txt823Name.Size = New System.Drawing.Size(278, 26)
        Me.txt823Name.TabIndex = 1
        '
        'btn823Add
        '
        Me.btn823Add.Location = New System.Drawing.Point(41, 86)
        Me.btn823Add.Name = "btn823Add"
        Me.btn823Add.Size = New System.Drawing.Size(322, 42)
        Me.btn823Add.TabIndex = 2
        Me.btn823Add.Text = "Add Person to File"
        Me.btn823Add.UseVisualStyleBackColor = True
        '
        'btn823Determine
        '
        Me.btn823Determine.Location = New System.Drawing.Point(41, 152)
        Me.btn823Determine.Name = "btn823Determine"
        Me.btn823Determine.Size = New System.Drawing.Size(322, 42)
        Me.btn823Determine.TabIndex = 3
        Me.btn823Determine.Text = "Determine if Person is in File"
        Me.btn823Determine.UseVisualStyleBackColor = True
        '
        'btn823Delete
        '
        Me.btn823Delete.Location = New System.Drawing.Point(41, 216)
        Me.btn823Delete.Name = "btn823Delete"
        Me.btn823Delete.Size = New System.Drawing.Size(322, 42)
        Me.btn823Delete.TabIndex = 4
        Me.btn823Delete.Text = "Delete Person from File"
        Me.btn823Delete.UseVisualStyleBackColor = True
        '
        'btn824Display
        '
        Me.btn824Display.Location = New System.Drawing.Point(91, 128)
        Me.btn824Display.Name = "btn824Display"
        Me.btn824Display.Size = New System.Drawing.Size(252, 66)
        Me.btn824Display.TabIndex = 0
        Me.btn824Display.Text = "Display"
        Me.btn824Display.UseVisualStyleBackColor = True
        '
        'SulfaroCH82Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 632)
        Me.Controls.Add(Me.gbx822)
        Me.Controls.Add(Me.gbx823)
        Me.Controls.Add(Me.gbx824)
        Me.Controls.Add(Me.gbx821)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SulfaroCH82Lab"
        Me.Text = "Sulfaro CH 8.2 Lab"
        Me.gbx821.ResumeLayout(False)
        Me.gbx821.PerformLayout()
        Me.gbx822.ResumeLayout(False)
        Me.gbx823.ResumeLayout(False)
        Me.gbx823.PerformLayout()
        Me.gbx824.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx821 As GroupBox
    Friend WithEvents gbx822 As GroupBox
    Friend WithEvents gbx823 As GroupBox
    Friend WithEvents gbx824 As GroupBox
    Friend WithEvents mtb821Abbr As MaskedTextBox
    Friend WithEvents btn821Find As Button
    Friend WithEvents txt821Name As TextBox
    Friend WithEvents lbl821Abbreviation As Label
    Friend WithEvents lst822Names As ListBox
    Friend WithEvents btn822DisplayFile As Button
    Friend WithEvents btn822CreateFile As Button
    Friend WithEvents btn823Delete As Button
    Friend WithEvents btn823Determine As Button
    Friend WithEvents btn823Add As Button
    Friend WithEvents txt823Name As TextBox
    Friend WithEvents lbl823Name As Label
    Friend WithEvents btn824Display As Button
End Class
