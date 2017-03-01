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
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtSupplies = New System.Windows.Forms.TextBox()
        Me.lblSupplyCost = New System.Windows.Forms.Label()
        Me.lblHoursLabor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(155, 101)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(311, 26)
        Me.txtCustomer.TabIndex = 0
        Me.txtCustomer.Text = "John Doe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer"
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 20
        Me.lstBill.Location = New System.Drawing.Point(78, 290)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(404, 184)
        Me.lstBill.TabIndex = 4
        '
        'btnBill
        '
        Me.btnBill.Location = New System.Drawing.Point(314, 154)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(152, 112)
        Me.btnBill.TabIndex = 3
        Me.btnBill.Text = "Display Bill"
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(155, 154)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(116, 26)
        Me.txtHours.TabIndex = 1
        '
        'txtSupplies
        '
        Me.txtSupplies.Location = New System.Drawing.Point(155, 214)
        Me.txtSupplies.Name = "txtSupplies"
        Me.txtSupplies.Size = New System.Drawing.Size(116, 26)
        Me.txtSupplies.TabIndex = 2
        '
        'lblSupplyCost
        '
        Me.lblSupplyCost.Location = New System.Drawing.Point(34, 214)
        Me.lblSupplyCost.Name = "lblSupplyCost"
        Me.lblSupplyCost.Size = New System.Drawing.Size(115, 52)
        Me.lblSupplyCost.TabIndex = 6
        Me.lblSupplyCost.Text = "Cost of parts and supplies:"
        '
        'lblHoursLabor
        '
        Me.lblHoursLabor.AutoSize = True
        Me.lblHoursLabor.Location = New System.Drawing.Point(34, 157)
        Me.lblHoursLabor.Name = "lblHoursLabor"
        Me.lblHoursLabor.Size = New System.Drawing.Size(115, 20)
        Me.lblHoursLabor.TabIndex = 7
        Me.lblHoursLabor.Text = "Hours of Labor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 516)
        Me.Controls.Add(Me.lblHoursLabor)
        Me.Controls.Add(Me.lblSupplyCost)
        Me.Controls.Add(Me.txtSupplies)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstBill As ListBox
    Friend WithEvents btnBill As Button
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtSupplies As TextBox
    Friend WithEvents lblSupplyCost As Label
    Friend WithEvents lblHoursLabor As Label
End Class
