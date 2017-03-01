<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhone
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
        Me.lblInstuctions = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblDirectories = New System.Windows.Forms.Label()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.lblCurrentDirectory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.mtbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstuctions
        '
        Me.lblInstuctions.Location = New System.Drawing.Point(35, 39)
        Me.lblInstuctions.Name = "lblInstuctions"
        Me.lblInstuctions.Size = New System.Drawing.Size(347, 56)
        Me.lblInstuctions.TabIndex = 0
        Me.lblInstuctions.Text = "Click on one of the existing phone directories below to make it the current phone" &
    " directory."
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(416, 39)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(377, 41)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create a New Phone Directory"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblDirectories
        '
        Me.lblDirectories.AutoSize = True
        Me.lblDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectories.Location = New System.Drawing.Point(62, 117)
        Me.lblDirectories.Name = "lblDirectories"
        Me.lblDirectories.Size = New System.Drawing.Size(183, 25)
        Me.lblDirectories.TabIndex = 2
        Me.lblDirectories.Text = "Phone Directories"
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 20
        Me.lstFiles.Location = New System.Drawing.Point(39, 171)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(238, 124)
        Me.lstFiles.TabIndex = 3
        '
        'lblCurrentDirectory
        '
        Me.lblCurrentDirectory.AutoSize = True
        Me.lblCurrentDirectory.Location = New System.Drawing.Point(324, 147)
        Me.lblCurrentDirectory.Name = "lblCurrentDirectory"
        Me.lblCurrentDirectory.Size = New System.Drawing.Size(179, 20)
        Me.lblCurrentDirectory.TabIndex = 4
        Me.lblCurrentDirectory.Text = "Current phone directory:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(324, 217)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(324, 285)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(117, 20)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone number:"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(510, 147)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.ReadOnly = True
        Me.txtDirectory.Size = New System.Drawing.Size(283, 26)
        Me.txtDirectory.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(386, 210)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(407, 26)
        Me.txtName.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(39, 337)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(238, 80)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add a Listing to the Current Phone Directory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(39, 464)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(238, 80)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "Remove a Listing from the Current Phone Directory"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(39, 584)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(238, 80)
        Me.btnDisplay.TabIndex = 12
        Me.btnDisplay.Text = "Display the Listings in the Current Phone Directory"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(328, 337)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.RowTemplate.Height = 28
        Me.dgvOutput.Size = New System.Drawing.Size(465, 327)
        Me.dgvOutput.TabIndex = 13
        '
        'mtbPhoneNumber
        '
        Me.mtbPhoneNumber.Location = New System.Drawing.Point(448, 282)
        Me.mtbPhoneNumber.Mask = "(999) 000-0000"
        Me.mtbPhoneNumber.Name = "mtbPhoneNumber"
        Me.mtbPhoneNumber.Size = New System.Drawing.Size(345, 26)
        Me.mtbPhoneNumber.TabIndex = 14
        '
        'frmPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 700)
        Me.Controls.Add(Me.mtbPhoneNumber)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCurrentDirectory)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.lblDirectories)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblInstuctions)
        Me.Name = "frmPhone"
        Me.Text = "Sulfaro's Create and Maintain Telephone Directories"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstuctions As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblDirectories As Label
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents lblCurrentDirectory As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents mtbPhoneNumber As MaskedTextBox
End Class
