<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.grpEmployeeDetails = New System.Windows.Forms.GroupBox()
        Me.txtEmpSurname = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.radCasual = New System.Windows.Forms.RadioButton()
        Me.radFullTime = New System.Windows.Forms.RadioButton()
        Me.btnCalcPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpEmployeeDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEmployeeDetails
        '
        Me.grpEmployeeDetails.Controls.Add(Me.txtEmpSurname)
        Me.grpEmployeeDetails.Controls.Add(Me.txtEmpName)
        Me.grpEmployeeDetails.Controls.Add(Me.txtEmpNo)
        Me.grpEmployeeDetails.Controls.Add(Me.Label3)
        Me.grpEmployeeDetails.Controls.Add(Me.Label2)
        Me.grpEmployeeDetails.Controls.Add(Me.Label1)
        Me.grpEmployeeDetails.Location = New System.Drawing.Point(13, 13)
        Me.grpEmployeeDetails.Name = "grpEmployeeDetails"
        Me.grpEmployeeDetails.Size = New System.Drawing.Size(363, 115)
        Me.grpEmployeeDetails.TabIndex = 0
        Me.grpEmployeeDetails.TabStop = False
        Me.grpEmployeeDetails.Text = "Employee Details:"
        '
        'txtEmpSurname
        '
        Me.txtEmpSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpSurname.Location = New System.Drawing.Point(109, 76)
        Me.txtEmpSurname.Name = "txtEmpSurname"
        Me.txtEmpSurname.Size = New System.Drawing.Size(150, 20)
        Me.txtEmpSurname.TabIndex = 5
        '
        'txtEmpName
        '
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Location = New System.Drawing.Point(109, 50)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(150, 20)
        Me.txtEmpName.TabIndex = 4
        '
        'txtEmpNo
        '
        Me.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpNo.Location = New System.Drawing.Point(109, 24)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHoursWorked)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPayment)
        Me.GroupBox1.Controls.Add(Me.lblPay)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.lblSalary)
        Me.GroupBox1.Controls.Add(Me.radCasual)
        Me.GroupBox1.Controls.Add(Me.radFullTime)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll:"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoursWorked.Enabled = False
        Me.txtHoursWorked.Location = New System.Drawing.Point(302, 48)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(47, 20)
        Me.txtHoursWorked.TabIndex = 7
        Me.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hours Worked:"
        '
        'lblPayment
        '
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(124, 77)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(135, 23)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPay
        '
        Me.lblPay.Location = New System.Drawing.Point(10, 82)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(107, 13)
        Me.lblPay.TabIndex = 4
        Me.lblPay.Text = "Monthly Salary:"
        Me.lblPay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Location = New System.Drawing.Point(123, 49)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(86, 20)
        Me.txtSalary.TabIndex = 3
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSalary
        '
        Me.lblSalary.Location = New System.Drawing.Point(10, 51)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(107, 13)
        Me.lblSalary.TabIndex = 2
        Me.lblSalary.Text = "Annual Salary:"
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'radCasual
        '
        Me.radCasual.AutoSize = True
        Me.radCasual.Location = New System.Drawing.Point(201, 19)
        Me.radCasual.Name = "radCasual"
        Me.radCasual.Size = New System.Drawing.Size(106, 17)
        Me.radCasual.TabIndex = 1
        Me.radCasual.Text = "Casual Employee"
        Me.radCasual.UseVisualStyleBackColor = True
        '
        'radFullTime
        '
        Me.radFullTime.AutoSize = True
        Me.radFullTime.Checked = True
        Me.radFullTime.Location = New System.Drawing.Point(73, 19)
        Me.radFullTime.Name = "radFullTime"
        Me.radFullTime.Size = New System.Drawing.Size(109, 17)
        Me.radFullTime.TabIndex = 0
        Me.radFullTime.TabStop = True
        Me.radFullTime.Text = "Fulltime Employee"
        Me.radFullTime.UseVisualStyleBackColor = True
        '
        'btnCalcPay
        '
        Me.btnCalcPay.Location = New System.Drawing.Point(13, 253)
        Me.btnCalcPay.Name = "btnCalcPay"
        Me.btnCalcPay.Size = New System.Drawing.Size(105, 23)
        Me.btnCalcPay.TabIndex = 2
        Me.btnCalcPay.Text = "&Process Payment"
        Me.btnCalcPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(142, 253)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 253)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 283)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcPay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpEmployeeDetails)
        Me.Name = "frmEmployee"
        Me.Text = "ABC Company Payroll System"
        Me.grpEmployeeDetails.ResumeLayout(False)
        Me.grpEmployeeDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEmployeeDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCasual As System.Windows.Forms.RadioButton
    Friend WithEvents radFullTime As System.Windows.Forms.RadioButton
    Friend WithEvents lblPay As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents btnCalcPay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
