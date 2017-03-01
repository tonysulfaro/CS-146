<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCH22Lab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtCityStateZip = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnWriteData = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 45)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(70, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityStateZip.Location = New System.Drawing.Point(12, 155)
        Me.lblCityStateZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(142, 34)
        Me.lblCityStateZip.TabIndex = 1
        Me.lblCityStateZip.Text = "City, State, Zip:"
        '
        'lblAdress
        '
        Me.lblAdress.AutoSize = True
        Me.lblAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdress.Location = New System.Drawing.Point(21, 97)
        Me.lblAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(80, 25)
        Me.lblAdress.TabIndex = 2
        Me.lblAdress.Text = "Adress:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(21, 200)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(75, 25)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(102, 38)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(367, 26)
        Me.txtName.TabIndex = 0
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(108, 95)
        Me.txtAdress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(361, 26)
        Me.txtAdress.TabIndex = 1
        '
        'txtCityStateZip
        '
        Me.txtCityStateZip.Location = New System.Drawing.Point(164, 149)
        Me.txtCityStateZip.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCityStateZip.Name = "txtCityStateZip"
        Me.txtCityStateZip.Size = New System.Drawing.Size(306, 26)
        Me.txtCityStateZip.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(102, 200)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(367, 26)
        Me.txtPhone.TabIndex = 3
        '
        'btnWriteData
        '
        Me.btnWriteData.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWriteData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteData.Location = New System.Drawing.Point(164, 271)
        Me.btnWriteData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnWriteData.Name = "btnWriteData"
        Me.btnWriteData.Size = New System.Drawing.Size(226, 83)
        Me.btnWriteData.TabIndex = 4
        Me.btnWriteData.Text = "Process the Data into a File"
        Me.btnWriteData.UseVisualStyleBackColor = False
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(26, 383)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(472, 164)
        Me.lstOutput.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(26, 608)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(472, 26)
        Me.txtOutput.TabIndex = 6
        Me.txtOutput.Text = "Output Data"
        '
        'frmCH22Lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(550, 678)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnWriteData)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtCityStateZip)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCH22Lab"
        Me.Text = "Sulfaro CH2.2 Lab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblCityStateZip As Label
    Friend WithEvents lblAdress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtCityStateZip As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnWriteData As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents txtOutput As TextBox
End Class
