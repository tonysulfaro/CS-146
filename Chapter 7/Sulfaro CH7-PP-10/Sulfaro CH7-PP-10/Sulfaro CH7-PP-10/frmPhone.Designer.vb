<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhone
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnPound = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btn9WXYZ = New System.Windows.Forms.Button()
        Me.btn8TUV = New System.Windows.Forms.Button()
        Me.btn7PQRS = New System.Windows.Forms.Button()
        Me.btn6MNO = New System.Windows.Forms.Button()
        Me.btn5JKL = New System.Windows.Forms.Button()
        Me.btn4GHI = New System.Windows.Forms.Button()
        Me.btn3DEF = New System.Windows.Forms.Button()
        Me.btn2ABC = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnGetInstructions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewPerson = New System.Windows.Forms.Button()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.dgvDirectory = New System.Windows.Forms.DataGridView()
        Me.mtbCode = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvDirectory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(22, 218)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 62)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnPound
        '
        Me.btnPound.Location = New System.Drawing.Point(292, 483)
        Me.btnPound.Name = "btnPound"
        Me.btnPound.Size = New System.Drawing.Size(100, 62)
        Me.btnPound.TabIndex = 2
        Me.btnPound.Text = "#"
        Me.btnPound.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(154, 483)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(100, 62)
        Me.btn0.TabIndex = 3
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(22, 483)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(100, 62)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "*"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btn9WXYZ
        '
        Me.btn9WXYZ.Location = New System.Drawing.Point(292, 397)
        Me.btn9WXYZ.Name = "btn9WXYZ"
        Me.btn9WXYZ.Size = New System.Drawing.Size(100, 62)
        Me.btn9WXYZ.TabIndex = 5
        Me.btn9WXYZ.Text = "9 WXYZ"
        Me.btn9WXYZ.UseVisualStyleBackColor = True
        '
        'btn8TUV
        '
        Me.btn8TUV.Location = New System.Drawing.Point(154, 397)
        Me.btn8TUV.Name = "btn8TUV"
        Me.btn8TUV.Size = New System.Drawing.Size(100, 62)
        Me.btn8TUV.TabIndex = 6
        Me.btn8TUV.Text = "8 TUV"
        Me.btn8TUV.UseVisualStyleBackColor = True
        '
        'btn7PQRS
        '
        Me.btn7PQRS.Location = New System.Drawing.Point(22, 397)
        Me.btn7PQRS.Name = "btn7PQRS"
        Me.btn7PQRS.Size = New System.Drawing.Size(100, 62)
        Me.btn7PQRS.TabIndex = 7
        Me.btn7PQRS.Text = "7 PQRS"
        Me.btn7PQRS.UseVisualStyleBackColor = True
        '
        'btn6MNO
        '
        Me.btn6MNO.Location = New System.Drawing.Point(292, 306)
        Me.btn6MNO.Name = "btn6MNO"
        Me.btn6MNO.Size = New System.Drawing.Size(100, 62)
        Me.btn6MNO.TabIndex = 8
        Me.btn6MNO.Text = "6 MNO"
        Me.btn6MNO.UseVisualStyleBackColor = True
        '
        'btn5JKL
        '
        Me.btn5JKL.Location = New System.Drawing.Point(154, 306)
        Me.btn5JKL.Name = "btn5JKL"
        Me.btn5JKL.Size = New System.Drawing.Size(100, 62)
        Me.btn5JKL.TabIndex = 9
        Me.btn5JKL.Text = "5 JKL"
        Me.btn5JKL.UseVisualStyleBackColor = True
        '
        'btn4GHI
        '
        Me.btn4GHI.Location = New System.Drawing.Point(22, 306)
        Me.btn4GHI.Name = "btn4GHI"
        Me.btn4GHI.Size = New System.Drawing.Size(100, 62)
        Me.btn4GHI.TabIndex = 10
        Me.btn4GHI.Text = "4 GHI"
        Me.btn4GHI.UseVisualStyleBackColor = True
        '
        'btn3DEF
        '
        Me.btn3DEF.Location = New System.Drawing.Point(292, 218)
        Me.btn3DEF.Name = "btn3DEF"
        Me.btn3DEF.Size = New System.Drawing.Size(100, 62)
        Me.btn3DEF.TabIndex = 11
        Me.btn3DEF.Text = "3 DEF"
        Me.btn3DEF.UseVisualStyleBackColor = True
        '
        'btn2ABC
        '
        Me.btn2ABC.Location = New System.Drawing.Point(154, 218)
        Me.btn2ABC.Name = "btn2ABC"
        Me.btn2ABC.Size = New System.Drawing.Size(100, 62)
        Me.btn2ABC.TabIndex = 12
        Me.btn2ABC.Text = "2 ABC"
        Me.btn2ABC.UseVisualStyleBackColor = True
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(63, 600)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(139, 20)
        Me.lblCode.TabIndex = 13
        Me.lblCode.Text = "Push-button code:"
        '
        'btnGetInstructions
        '
        Me.btnGetInstructions.Location = New System.Drawing.Point(423, 28)
        Me.btnGetInstructions.Name = "btnGetInstructions"
        Me.btnGetInstructions.Size = New System.Drawing.Size(232, 49)
        Me.btnGetInstructions.TabIndex = 15
        Me.btnGetInstructions.Text = "Get Instructions"
        Me.btnGetInstructions.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(732, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(232, 49)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit the Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewPerson
        '
        Me.btnNewPerson.Location = New System.Drawing.Point(423, 571)
        Me.btnNewPerson.Name = "btnNewPerson"
        Me.btnNewPerson.Size = New System.Drawing.Size(232, 49)
        Me.btnNewPerson.TabIndex = 17
        Me.btnNewPerson.Text = "Look Up Another Person"
        Me.btnNewPerson.UseVisualStyleBackColor = True
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Location = New System.Drawing.Point(732, 571)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(232, 49)
        Me.btnDisplayAll.TabIndex = 18
        Me.btnDisplayAll.Text = "Display Directory"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'dgvDirectory
        '
        Me.dgvDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDirectory.Location = New System.Drawing.Point(423, 137)
        Me.dgvDirectory.Name = "dgvDirectory"
        Me.dgvDirectory.RowHeadersVisible = False
        Me.dgvDirectory.RowTemplate.Height = 28
        Me.dgvDirectory.Size = New System.Drawing.Size(542, 394)
        Me.dgvDirectory.TabIndex = 19
        '
        'mtbCode
        '
        Me.mtbCode.Location = New System.Drawing.Point(208, 600)
        Me.mtbCode.Mask = "&&&&"
        Me.mtbCode.Name = "mtbCode"
        Me.mtbCode.ReadOnly = True
        Me.mtbCode.Size = New System.Drawing.Size(54, 26)
        Me.mtbCode.TabIndex = 20
        '
        'frmPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 659)
        Me.Controls.Add(Me.mtbCode)
        Me.Controls.Add(Me.dgvDirectory)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Controls.Add(Me.btnNewPerson)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetInstructions)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.btn2ABC)
        Me.Controls.Add(Me.btn3DEF)
        Me.Controls.Add(Me.btn4GHI)
        Me.Controls.Add(Me.btn5JKL)
        Me.Controls.Add(Me.btn6MNO)
        Me.Controls.Add(Me.btn7PQRS)
        Me.Controls.Add(Me.btn8TUV)
        Me.Controls.Add(Me.btn9WXYZ)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnPound)
        Me.Controls.Add(Me.btn1)
        Me.Name = "frmPhone"
        Me.Text = "Sulfaro's User-Operated Driectory Assistance"
        CType(Me.dgvDirectory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btnPound As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btn9WXYZ As Button
    Friend WithEvents btn8TUV As Button
    Friend WithEvents btn7PQRS As Button
    Friend WithEvents btn6MNO As Button
    Friend WithEvents btn5JKL As Button
    Friend WithEvents btn4GHI As Button
    Friend WithEvents btn3DEF As Button
    Friend WithEvents btn2ABC As Button
    Friend WithEvents lblCode As Label
    Friend WithEvents btnGetInstructions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNewPerson As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents dgvDirectory As DataGridView
    Friend WithEvents mtbCode As MaskedTextBox
End Class
