<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepair
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Customer Name: "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hours of Labor:"
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(21, 75)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(69, 34)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Cost of parts and supplies:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(96, 15)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(157, 20)
        Me.txtCustomer.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(96, 45)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(59, 20)
        Me.txtHours.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(96, 80)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(59, 20)
        Me.txtCost.TabIndex = 2
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(12, 131)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(241, 88)
        Me.lstOutput.TabIndex = 6
        Me.lstOutput.TabStop = False
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(278, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(107, 52)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(278, 92)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(107, 52)
        Me.btnNewCustomer.TabIndex = 4
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnExitProgram
        '
        Me.btnExitProgram.Location = New System.Drawing.Point(278, 167)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(107, 52)
        Me.btnExitProgram.TabIndex = 5
        Me.btnExitProgram.Text = "Exit"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        '
        'frmRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 236)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmRepair"
        Me.Text = "Sulfaro's A-1 Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents btnExitProgram As Button
End Class
