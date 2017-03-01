<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCH434
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
        Me.gbxEX441 = New System.Windows.Forms.GroupBox()
        Me.txtDaysEX441 = New System.Windows.Forms.TextBox()
        Me.btnDetermineEX441 = New System.Windows.Forms.Button()
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.gbxEX443 = New System.Windows.Forms.GroupBox()
        Me.txtFeeEX443 = New System.Windows.Forms.TextBox()
        Me.lblFeeEX443 = New System.Windows.Forms.Label()
        Me.gbxAgeEX443 = New System.Windows.Forms.GroupBox()
        Me.radSeniorEX443 = New System.Windows.Forms.RadioButton()
        Me.radAdultEX443 = New System.Windows.Forms.RadioButton()
        Me.radMinorEX443 = New System.Windows.Forms.RadioButton()
        Me.radChildEX443 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxBenifitsEX444 = New System.Windows.Forms.GroupBox()
        Me.lblTotalEX444 = New System.Windows.Forms.Label()
        Me.txtTotalEX444 = New System.Windows.Forms.TextBox()
        Me.btnCostEX444 = New System.Windows.Forms.Button()
        Me.chkMedicalEX444 = New System.Windows.Forms.CheckBox()
        Me.chkVisionEX444 = New System.Windows.Forms.CheckBox()
        Me.chkDentalEX444 = New System.Windows.Forms.CheckBox()
        Me.chkDrugsEX444 = New System.Windows.Forms.CheckBox()
        Me.gbxOlympicPlaceEX431 = New System.Windows.Forms.GroupBox()
        Me.txtOutcomeEX431 = New System.Windows.Forms.TextBox()
        Me.txtPositionEX431 = New System.Windows.Forms.TextBox()
        Me.lblPositionEX431 = New System.Windows.Forms.Label()
        Me.btnEvaluateEX431 = New System.Windows.Forms.Button()
        Me.gbxCountDaysEX433 = New System.Windows.Forms.GroupBox()
        Me.mtbYearEX433 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbMonthEX433 = New System.Windows.Forms.MaskedTextBox()
        Me.txtOutputEX433 = New System.Windows.Forms.TextBox()
        Me.btnDetermineEX433 = New System.Windows.Forms.Button()
        Me.lblYearEX433 = New System.Windows.Forms.Label()
        Me.lblMonthEX433 = New System.Windows.Forms.Label()
        Me.gbxAnalyzeEX435 = New System.Windows.Forms.GroupBox()
        Me.txtResultEX435 = New System.Windows.Forms.TextBox()
        Me.btnAnalyzeEX435 = New System.Windows.Forms.Button()
        Me.txtStringEX435 = New System.Windows.Forms.TextBox()
        Me.lblEnterEX435 = New System.Windows.Forms.Label()
        Me.gbxEX441.SuspendLayout()
        Me.gbxEX443.SuspendLayout()
        Me.gbxAgeEX443.SuspendLayout()
        Me.gbxBenifitsEX444.SuspendLayout()
        Me.gbxOlympicPlaceEX431.SuspendLayout()
        Me.gbxCountDaysEX433.SuspendLayout()
        Me.gbxAnalyzeEX435.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxEX441
        '
        Me.gbxEX441.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxEX441.Controls.Add(Me.txtDaysEX441)
        Me.gbxEX441.Controls.Add(Me.btnDetermineEX441)
        Me.gbxEX441.Controls.Add(Me.lstMonths)
        Me.gbxEX441.Location = New System.Drawing.Point(18, 340)
        Me.gbxEX441.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxEX441.Name = "gbxEX441"
        Me.gbxEX441.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxEX441.Size = New System.Drawing.Size(304, 294)
        Me.gbxEX441.TabIndex = 0
        Me.gbxEX441.TabStop = False
        Me.gbxEX441.Text = "EX 4.4.1 - Number of Days"
        '
        'txtDaysEX441
        '
        Me.txtDaysEX441.Location = New System.Drawing.Point(150, 187)
        Me.txtDaysEX441.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDaysEX441.Name = "txtDaysEX441"
        Me.txtDaysEX441.ReadOnly = True
        Me.txtDaysEX441.Size = New System.Drawing.Size(116, 26)
        Me.txtDaysEX441.TabIndex = 2
        '
        'btnDetermineEX441
        '
        Me.btnDetermineEX441.Location = New System.Drawing.Point(150, 34)
        Me.btnDetermineEX441.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDetermineEX441.Name = "btnDetermineEX441"
        Me.btnDetermineEX441.Size = New System.Drawing.Size(118, 91)
        Me.btnDetermineEX441.TabIndex = 1
        Me.btnDetermineEX441.Text = "Determine the Number of Days"
        Me.btnDetermineEX441.UseVisualStyleBackColor = True
        '
        'lstMonths
        '
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.ItemHeight = 20
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(9, 29)
        Me.lstMonths.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(109, 244)
        Me.lstMonths.TabIndex = 0
        '
        'gbxEX443
        '
        Me.gbxEX443.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxEX443.Controls.Add(Me.txtFeeEX443)
        Me.gbxEX443.Controls.Add(Me.lblFeeEX443)
        Me.gbxEX443.Controls.Add(Me.gbxAgeEX443)
        Me.gbxEX443.Controls.Add(Me.Button1)
        Me.gbxEX443.Location = New System.Drawing.Point(330, 340)
        Me.gbxEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxEX443.Name = "gbxEX443"
        Me.gbxEX443.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxEX443.Size = New System.Drawing.Size(304, 297)
        Me.gbxEX443.TabIndex = 1
        Me.gbxEX443.TabStop = False
        Me.gbxEX443.Text = "EX 4.4.3 - Admissions Fee"
        '
        'txtFeeEX443
        '
        Me.txtFeeEX443.Location = New System.Drawing.Point(213, 181)
        Me.txtFeeEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFeeEX443.Name = "txtFeeEX443"
        Me.txtFeeEX443.ReadOnly = True
        Me.txtFeeEX443.Size = New System.Drawing.Size(60, 26)
        Me.txtFeeEX443.TabIndex = 3
        '
        'lblFeeEX443
        '
        Me.lblFeeEX443.AutoSize = True
        Me.lblFeeEX443.Location = New System.Drawing.Point(162, 187)
        Me.lblFeeEX443.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeeEX443.Name = "lblFeeEX443"
        Me.lblFeeEX443.Size = New System.Drawing.Size(41, 20)
        Me.lblFeeEX443.TabIndex = 2
        Me.lblFeeEX443.Text = "Fee:"
        '
        'gbxAgeEX443
        '
        Me.gbxAgeEX443.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gbxAgeEX443.Controls.Add(Me.radSeniorEX443)
        Me.gbxAgeEX443.Controls.Add(Me.radAdultEX443)
        Me.gbxAgeEX443.Controls.Add(Me.radMinorEX443)
        Me.gbxAgeEX443.Controls.Add(Me.radChildEX443)
        Me.gbxAgeEX443.Location = New System.Drawing.Point(10, 49)
        Me.gbxAgeEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxAgeEX443.Name = "gbxAgeEX443"
        Me.gbxAgeEX443.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxAgeEX443.Size = New System.Drawing.Size(142, 180)
        Me.gbxAgeEX443.TabIndex = 1
        Me.gbxAgeEX443.TabStop = False
        Me.gbxAgeEX443.Text = "Age"
        '
        'radSeniorEX443
        '
        Me.radSeniorEX443.AutoSize = True
        Me.radSeniorEX443.Location = New System.Drawing.Point(10, 140)
        Me.radSeniorEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radSeniorEX443.Name = "radSeniorEX443"
        Me.radSeniorEX443.Size = New System.Drawing.Size(118, 24)
        Me.radSeniorEX443.TabIndex = 3
        Me.radSeniorEX443.TabStop = True
        Me.radSeniorEX443.Text = "senior (65+)"
        Me.radSeniorEX443.UseVisualStyleBackColor = True
        '
        'radAdultEX443
        '
        Me.radAdultEX443.AutoSize = True
        Me.radAdultEX443.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.radAdultEX443.Location = New System.Drawing.Point(9, 105)
        Me.radAdultEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radAdultEX443.Name = "radAdultEX443"
        Me.radAdultEX443.Size = New System.Drawing.Size(124, 24)
        Me.radAdultEX443.TabIndex = 2
        Me.radAdultEX443.TabStop = True
        Me.radAdultEX443.Text = "adult (18-64)"
        Me.radAdultEX443.UseVisualStyleBackColor = False
        '
        'radMinorEX443
        '
        Me.radMinorEX443.AutoSize = True
        Me.radMinorEX443.Location = New System.Drawing.Point(9, 69)
        Me.radMinorEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radMinorEX443.Name = "radMinorEX443"
        Me.radMinorEX443.Size = New System.Drawing.Size(119, 24)
        Me.radMinorEX443.TabIndex = 1
        Me.radMinorEX443.TabStop = True
        Me.radMinorEX443.Text = "minor (6-17)"
        Me.radMinorEX443.UseVisualStyleBackColor = True
        '
        'radChildEX443
        '
        Me.radChildEX443.AutoSize = True
        Me.radChildEX443.Location = New System.Drawing.Point(10, 34)
        Me.radChildEX443.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radChildEX443.Name = "radChildEX443"
        Me.radChildEX443.Size = New System.Drawing.Size(105, 24)
        Me.radChildEX443.TabIndex = 0
        Me.radChildEX443.TabStop = True
        Me.radChildEX443.Text = "Child (< 6)"
        Me.radChildEX443.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Determine Fee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxBenifitsEX444
        '
        Me.gbxBenifitsEX444.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxBenifitsEX444.Controls.Add(Me.lblTotalEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.txtTotalEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.btnCostEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.chkMedicalEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.chkVisionEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.chkDentalEX444)
        Me.gbxBenifitsEX444.Controls.Add(Me.chkDrugsEX444)
        Me.gbxBenifitsEX444.Location = New System.Drawing.Point(644, 340)
        Me.gbxBenifitsEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxBenifitsEX444.Name = "gbxBenifitsEX444"
        Me.gbxBenifitsEX444.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxBenifitsEX444.Size = New System.Drawing.Size(362, 294)
        Me.gbxBenifitsEX444.TabIndex = 2
        Me.gbxBenifitsEX444.TabStop = False
        Me.gbxBenifitsEX444.Text = "EX 4.4.4 - Benefits"
        '
        'lblTotalEX444
        '
        Me.lblTotalEX444.AutoSize = True
        Me.lblTotalEX444.Location = New System.Drawing.Point(9, 240)
        Me.lblTotalEX444.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalEX444.Name = "lblTotalEX444"
        Me.lblTotalEX444.Size = New System.Drawing.Size(144, 20)
        Me.lblTotalEX444.TabIndex = 6
        Me.lblTotalEX444.Text = "Total Monthly Cost:"
        '
        'txtTotalEX444
        '
        Me.txtTotalEX444.Location = New System.Drawing.Point(166, 235)
        Me.txtTotalEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalEX444.Name = "txtTotalEX444"
        Me.txtTotalEX444.ReadOnly = True
        Me.txtTotalEX444.Size = New System.Drawing.Size(127, 26)
        Me.txtTotalEX444.TabIndex = 5
        '
        'btnCostEX444
        '
        Me.btnCostEX444.Location = New System.Drawing.Point(10, 189)
        Me.btnCostEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCostEX444.Name = "btnCostEX444"
        Me.btnCostEX444.Size = New System.Drawing.Size(285, 35)
        Me.btnCostEX444.TabIndex = 4
        Me.btnCostEX444.Text = "Determine Total Monthly Cost"
        Me.btnCostEX444.UseVisualStyleBackColor = True
        '
        'chkMedicalEX444
        '
        Me.chkMedicalEX444.AutoSize = True
        Me.chkMedicalEX444.Location = New System.Drawing.Point(10, 154)
        Me.chkMedicalEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMedicalEX444.Name = "chkMedicalEX444"
        Me.chkMedicalEX444.Size = New System.Drawing.Size(187, 24)
        Me.chkMedicalEX444.TabIndex = 3
        Me.chkMedicalEX444.Text = "Medical Plan ($55.52)"
        Me.chkMedicalEX444.UseVisualStyleBackColor = True
        '
        'chkVisionEX444
        '
        Me.chkVisionEX444.AutoSize = True
        Me.chkVisionEX444.Location = New System.Drawing.Point(10, 118)
        Me.chkVisionEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkVisionEX444.Name = "chkVisionEX444"
        Me.chkVisionEX444.Size = New System.Drawing.Size(167, 24)
        Me.chkVisionEX444.TabIndex = 2
        Me.chkVisionEX444.Text = "Vision Plan ($2.25)"
        Me.chkVisionEX444.UseVisualStyleBackColor = True
        '
        'chkDentalEX444
        '
        Me.chkDentalEX444.AutoSize = True
        Me.chkDentalEX444.Location = New System.Drawing.Point(10, 83)
        Me.chkDentalEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDentalEX444.Name = "chkDentalEX444"
        Me.chkDentalEX444.Size = New System.Drawing.Size(180, 24)
        Me.chkDentalEX444.TabIndex = 1
        Me.chkDentalEX444.Text = "Dental Plan ($10.81)"
        Me.chkDentalEX444.UseVisualStyleBackColor = True
        '
        'chkDrugsEX444
        '
        Me.chkDrugsEX444.AutoSize = True
        Me.chkDrugsEX444.Location = New System.Drawing.Point(10, 48)
        Me.chkDrugsEX444.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDrugsEX444.Name = "chkDrugsEX444"
        Me.chkDrugsEX444.Size = New System.Drawing.Size(255, 24)
        Me.chkDrugsEX444.TabIndex = 0
        Me.chkDrugsEX444.Text = "Perscription Drug Plan ($39.15)"
        Me.chkDrugsEX444.UseVisualStyleBackColor = True
        '
        'gbxOlympicPlaceEX431
        '
        Me.gbxOlympicPlaceEX431.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxOlympicPlaceEX431.Controls.Add(Me.txtOutcomeEX431)
        Me.gbxOlympicPlaceEX431.Controls.Add(Me.txtPositionEX431)
        Me.gbxOlympicPlaceEX431.Controls.Add(Me.lblPositionEX431)
        Me.gbxOlympicPlaceEX431.Controls.Add(Me.btnEvaluateEX431)
        Me.gbxOlympicPlaceEX431.Location = New System.Drawing.Point(18, 18)
        Me.gbxOlympicPlaceEX431.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxOlympicPlaceEX431.Name = "gbxOlympicPlaceEX431"
        Me.gbxOlympicPlaceEX431.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxOlympicPlaceEX431.Size = New System.Drawing.Size(303, 312)
        Me.gbxOlympicPlaceEX431.TabIndex = 3
        Me.gbxOlympicPlaceEX431.TabStop = False
        Me.gbxOlympicPlaceEX431.Text = "EX 4.3.1 - Olympics"
        '
        'txtOutcomeEX431
        '
        Me.txtOutcomeEX431.Location = New System.Drawing.Point(66, 249)
        Me.txtOutcomeEX431.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutcomeEX431.Name = "txtOutcomeEX431"
        Me.txtOutcomeEX431.ReadOnly = True
        Me.txtOutcomeEX431.Size = New System.Drawing.Size(148, 26)
        Me.txtOutcomeEX431.TabIndex = 3
        '
        'txtPositionEX431
        '
        Me.txtPositionEX431.Location = New System.Drawing.Point(118, 105)
        Me.txtPositionEX431.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPositionEX431.Name = "txtPositionEX431"
        Me.txtPositionEX431.Size = New System.Drawing.Size(148, 26)
        Me.txtPositionEX431.TabIndex = 2
        '
        'lblPositionEX431
        '
        Me.lblPositionEX431.Location = New System.Drawing.Point(30, 88)
        Me.lblPositionEX431.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionEX431.Name = "lblPositionEX431"
        Me.lblPositionEX431.Size = New System.Drawing.Size(124, 66)
        Me.lblPositionEX431.TabIndex = 1
        Me.lblPositionEX431.Text = "Finishing Position: (1,2,3...)"
        '
        'btnEvaluateEX431
        '
        Me.btnEvaluateEX431.Location = New System.Drawing.Point(84, 158)
        Me.btnEvaluateEX431.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEvaluateEX431.Name = "btnEvaluateEX431"
        Me.btnEvaluateEX431.Size = New System.Drawing.Size(112, 35)
        Me.btnEvaluateEX431.TabIndex = 0
        Me.btnEvaluateEX431.Text = "Evaluate"
        Me.btnEvaluateEX431.UseVisualStyleBackColor = True
        '
        'gbxCountDaysEX433
        '
        Me.gbxCountDaysEX433.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxCountDaysEX433.Controls.Add(Me.mtbYearEX433)
        Me.gbxCountDaysEX433.Controls.Add(Me.mtbMonthEX433)
        Me.gbxCountDaysEX433.Controls.Add(Me.txtOutputEX433)
        Me.gbxCountDaysEX433.Controls.Add(Me.btnDetermineEX433)
        Me.gbxCountDaysEX433.Controls.Add(Me.lblYearEX433)
        Me.gbxCountDaysEX433.Controls.Add(Me.lblMonthEX433)
        Me.gbxCountDaysEX433.Location = New System.Drawing.Point(330, 18)
        Me.gbxCountDaysEX433.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxCountDaysEX433.Name = "gbxCountDaysEX433"
        Me.gbxCountDaysEX433.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxCountDaysEX433.Size = New System.Drawing.Size(304, 312)
        Me.gbxCountDaysEX433.TabIndex = 0
        Me.gbxCountDaysEX433.TabStop = False
        Me.gbxCountDaysEX433.Text = "EX 4.3.3 - Count Days"
        '
        'mtbYearEX433
        '
        Me.mtbYearEX433.Location = New System.Drawing.Point(166, 88)
        Me.mtbYearEX433.Mask = "0000"
        Me.mtbYearEX433.Name = "mtbYearEX433"
        Me.mtbYearEX433.Size = New System.Drawing.Size(50, 26)
        Me.mtbYearEX433.TabIndex = 5
        '
        'mtbMonthEX433
        '
        Me.mtbMonthEX433.Location = New System.Drawing.Point(166, 43)
        Me.mtbMonthEX433.Mask = "00"
        Me.mtbMonthEX433.Name = "mtbMonthEX433"
        Me.mtbMonthEX433.Size = New System.Drawing.Size(37, 26)
        Me.mtbMonthEX433.TabIndex = 4
        '
        'txtOutputEX433
        '
        Me.txtOutputEX433.Location = New System.Drawing.Point(32, 249)
        Me.txtOutputEX433.Name = "txtOutputEX433"
        Me.txtOutputEX433.ReadOnly = True
        Me.txtOutputEX433.Size = New System.Drawing.Size(241, 26)
        Me.txtOutputEX433.TabIndex = 3
        '
        'btnDetermineEX433
        '
        Me.btnDetermineEX433.Location = New System.Drawing.Point(78, 135)
        Me.btnDetermineEX433.Name = "btnDetermineEX433"
        Me.btnDetermineEX433.Size = New System.Drawing.Size(153, 81)
        Me.btnDetermineEX433.TabIndex = 2
        Me.btnDetermineEX433.Text = "Determine Number of Days in Month"
        Me.btnDetermineEX433.UseVisualStyleBackColor = True
        '
        'lblYearEX433
        '
        Me.lblYearEX433.AutoSize = True
        Me.lblYearEX433.Location = New System.Drawing.Point(113, 88)
        Me.lblYearEX433.Name = "lblYearEX433"
        Me.lblYearEX433.Size = New System.Drawing.Size(47, 20)
        Me.lblYearEX433.TabIndex = 1
        Me.lblYearEX433.Text = "Year:"
        '
        'lblMonthEX433
        '
        Me.lblMonthEX433.AutoSize = True
        Me.lblMonthEX433.Location = New System.Drawing.Point(48, 46)
        Me.lblMonthEX433.Name = "lblMonthEX433"
        Me.lblMonthEX433.Size = New System.Drawing.Size(112, 20)
        Me.lblMonthEX433.TabIndex = 0
        Me.lblMonthEX433.Text = "Month (1 - 12):"
        '
        'gbxAnalyzeEX435
        '
        Me.gbxAnalyzeEX435.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbxAnalyzeEX435.Controls.Add(Me.txtResultEX435)
        Me.gbxAnalyzeEX435.Controls.Add(Me.btnAnalyzeEX435)
        Me.gbxAnalyzeEX435.Controls.Add(Me.txtStringEX435)
        Me.gbxAnalyzeEX435.Controls.Add(Me.lblEnterEX435)
        Me.gbxAnalyzeEX435.Location = New System.Drawing.Point(644, 18)
        Me.gbxAnalyzeEX435.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxAnalyzeEX435.Name = "gbxAnalyzeEX435"
        Me.gbxAnalyzeEX435.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxAnalyzeEX435.Size = New System.Drawing.Size(362, 312)
        Me.gbxAnalyzeEX435.TabIndex = 0
        Me.gbxAnalyzeEX435.TabStop = False
        Me.gbxAnalyzeEX435.Text = "EX 4.3.5 - Analyze First Character"
        '
        'txtResultEX435
        '
        Me.txtResultEX435.Location = New System.Drawing.Point(20, 249)
        Me.txtResultEX435.Name = "txtResultEX435"
        Me.txtResultEX435.ReadOnly = True
        Me.txtResultEX435.Size = New System.Drawing.Size(334, 26)
        Me.txtResultEX435.TabIndex = 3
        '
        'btnAnalyzeEX435
        '
        Me.btnAnalyzeEX435.Location = New System.Drawing.Point(112, 155)
        Me.btnAnalyzeEX435.Name = "btnAnalyzeEX435"
        Me.btnAnalyzeEX435.Size = New System.Drawing.Size(163, 41)
        Me.btnAnalyzeEX435.TabIndex = 2
        Me.btnAnalyzeEX435.Text = "Analyze"
        Me.btnAnalyzeEX435.UseVisualStyleBackColor = True
        '
        'txtStringEX435
        '
        Me.txtStringEX435.Location = New System.Drawing.Point(124, 88)
        Me.txtStringEX435.Name = "txtStringEX435"
        Me.txtStringEX435.Size = New System.Drawing.Size(230, 26)
        Me.txtStringEX435.TabIndex = 1
        '
        'lblEnterEX435
        '
        Me.lblEnterEX435.AutoSize = True
        Me.lblEnterEX435.Location = New System.Drawing.Point(7, 88)
        Me.lblEnterEX435.Name = "lblEnterEX435"
        Me.lblEnterEX435.Size = New System.Drawing.Size(111, 20)
        Me.lblEnterEX435.TabIndex = 0
        Me.lblEnterEX435.Text = "Enter a String:"
        '
        'frmCH434
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 655)
        Me.Controls.Add(Me.gbxCountDaysEX433)
        Me.Controls.Add(Me.gbxAnalyzeEX435)
        Me.Controls.Add(Me.gbxOlympicPlaceEX431)
        Me.Controls.Add(Me.gbxBenifitsEX444)
        Me.Controls.Add(Me.gbxEX443)
        Me.Controls.Add(Me.gbxEX441)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCH434"
        Me.Text = "Sulfaro CH 4.3-4 Lab"
        Me.gbxEX441.ResumeLayout(False)
        Me.gbxEX441.PerformLayout()
        Me.gbxEX443.ResumeLayout(False)
        Me.gbxEX443.PerformLayout()
        Me.gbxAgeEX443.ResumeLayout(False)
        Me.gbxAgeEX443.PerformLayout()
        Me.gbxBenifitsEX444.ResumeLayout(False)
        Me.gbxBenifitsEX444.PerformLayout()
        Me.gbxOlympicPlaceEX431.ResumeLayout(False)
        Me.gbxOlympicPlaceEX431.PerformLayout()
        Me.gbxCountDaysEX433.ResumeLayout(False)
        Me.gbxCountDaysEX433.PerformLayout()
        Me.gbxAnalyzeEX435.ResumeLayout(False)
        Me.gbxAnalyzeEX435.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxEX441 As GroupBox
    Friend WithEvents txtDaysEX441 As TextBox
    Friend WithEvents btnDetermineEX441 As Button
    Friend WithEvents lstMonths As ListBox
    Friend WithEvents gbxEX443 As GroupBox
    Friend WithEvents txtFeeEX443 As TextBox
    Friend WithEvents lblFeeEX443 As Label
    Friend WithEvents gbxAgeEX443 As GroupBox
    Friend WithEvents radSeniorEX443 As RadioButton
    Friend WithEvents radAdultEX443 As RadioButton
    Friend WithEvents radMinorEX443 As RadioButton
    Friend WithEvents radChildEX443 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents gbxBenifitsEX444 As GroupBox
    Friend WithEvents btnCostEX444 As Button
    Friend WithEvents chkMedicalEX444 As CheckBox
    Friend WithEvents chkVisionEX444 As CheckBox
    Friend WithEvents chkDentalEX444 As CheckBox
    Friend WithEvents chkDrugsEX444 As CheckBox
    Friend WithEvents txtTotalEX444 As TextBox
    Friend WithEvents lblTotalEX444 As Label
    Friend WithEvents gbxOlympicPlaceEX431 As GroupBox
    Friend WithEvents gbxCountDaysEX433 As GroupBox
    Friend WithEvents gbxAnalyzeEX435 As GroupBox
    Friend WithEvents btnEvaluateEX431 As Button
    Friend WithEvents txtOutcomeEX431 As TextBox
    Friend WithEvents txtPositionEX431 As TextBox
    Friend WithEvents lblPositionEX431 As Label
    Friend WithEvents mtbYearEX433 As MaskedTextBox
    Friend WithEvents mtbMonthEX433 As MaskedTextBox
    Friend WithEvents txtOutputEX433 As TextBox
    Friend WithEvents btnDetermineEX433 As Button
    Friend WithEvents lblYearEX433 As Label
    Friend WithEvents lblMonthEX433 As Label
    Friend WithEvents txtResultEX435 As TextBox
    Friend WithEvents btnAnalyzeEX435 As Button
    Friend WithEvents txtStringEX435 As TextBox
    Friend WithEvents lblEnterEX435 As Label
End Class
