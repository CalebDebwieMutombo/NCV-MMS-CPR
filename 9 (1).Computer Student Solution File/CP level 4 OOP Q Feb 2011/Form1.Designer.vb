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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtDiskSize = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtProductNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMonthInstallment = New System.Windows.Forms.Label()
        Me.radLaptop = New System.Windows.Forms.RadioButton()
        Me.radPersonalComputer = New System.Windows.Forms.RadioButton()
        Me.radMainFrame = New System.Windows.Forms.RadioButton()
        Me.btnCalc_Installment = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostPrice)
        Me.GroupBox1.Controls.Add(Me.txtDiskSize)
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.txtProductNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Details"
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(110, 99)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPrice.TabIndex = 4
        '
        'txtDiskSize
        '
        Me.txtDiskSize.Location = New System.Drawing.Point(110, 73)
        Me.txtDiskSize.Name = "txtDiskSize"
        Me.txtDiskSize.Size = New System.Drawing.Size(100, 20)
        Me.txtDiskSize.TabIndex = 3
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(110, 47)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 2
        '
        'txtProductNum
        '
        Me.txtProductNum.Location = New System.Drawing.Point(110, 20)
        Me.txtProductNum.Name = "txtProductNum"
        Me.txtProductNum.Size = New System.Drawing.Size(189, 20)
        Me.txtProductNum.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cost Prize"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Disk Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Colour"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(351, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 65)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Monthly Installment and Description of product"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthInstallment
        '
        Me.lblMonthInstallment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthInstallment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthInstallment.Location = New System.Drawing.Point(184, 163)
        Me.lblMonthInstallment.Name = "lblMonthInstallment"
        Me.lblMonthInstallment.Size = New System.Drawing.Size(267, 65)
        Me.lblMonthInstallment.TabIndex = 4
        Me.lblMonthInstallment.Text = "lblMonthInstallment"
        Me.lblMonthInstallment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radLaptop
        '
        Me.radLaptop.AutoSize = True
        Me.radLaptop.Checked = True
        Me.radLaptop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLaptop.Location = New System.Drawing.Point(65, 244)
        Me.radLaptop.Name = "radLaptop"
        Me.radLaptop.Size = New System.Drawing.Size(69, 19)
        Me.radLaptop.TabIndex = 5
        Me.radLaptop.TabStop = True
        Me.radLaptop.Text = "Laptop"
        Me.radLaptop.UseVisualStyleBackColor = True
        '
        'radPersonalComputer
        '
        Me.radPersonalComputer.AutoSize = True
        Me.radPersonalComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPersonalComputer.Location = New System.Drawing.Point(165, 244)
        Me.radPersonalComputer.Name = "radPersonalComputer"
        Me.radPersonalComputer.Size = New System.Drawing.Size(148, 19)
        Me.radPersonalComputer.TabIndex = 6
        Me.radPersonalComputer.Text = "Personal Computer"
        Me.radPersonalComputer.UseVisualStyleBackColor = True
        '
        'radMainFrame
        '
        Me.radMainFrame.AutoSize = True
        Me.radMainFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMainFrame.Location = New System.Drawing.Point(319, 246)
        Me.radMainFrame.Name = "radMainFrame"
        Me.radMainFrame.Size = New System.Drawing.Size(94, 19)
        Me.radMainFrame.TabIndex = 7
        Me.radMainFrame.Text = "Mainframe"
        Me.radMainFrame.UseVisualStyleBackColor = True
        '
        'btnCalc_Installment
        '
        Me.btnCalc_Installment.Image = CType(resources.GetObject("btnCalc_Installment.Image"), System.Drawing.Image)
        Me.btnCalc_Installment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalc_Installment.Location = New System.Drawing.Point(27, 275)
        Me.btnCalc_Installment.Name = "btnCalc_Installment"
        Me.btnCalc_Installment.Size = New System.Drawing.Size(131, 60)
        Me.btnCalc_Installment.TabIndex = 8
        Me.btnCalc_Installment.Text = "Calculate Installment"
        Me.btnCalc_Installment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnCalc_Installment, "Calculate Installment")
        Me.btnCalc_Installment.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Location = New System.Drawing.Point(328, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 41)
        Me.btnClear.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all fields")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Location = New System.Drawing.Point(393, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 41)
        Me.btnExit.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 347)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc_Installment)
        Me.Controls.Add(Me.radMainFrame)
        Me.Controls.Add(Me.radPersonalComputer)
        Me.Controls.Add(Me.radLaptop)
        Me.Controls.Add(Me.lblMonthInstallment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Computer Sales: Exam Number:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskSize As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtProductNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMonthInstallment As System.Windows.Forms.Label
    Friend WithEvents radLaptop As System.Windows.Forms.RadioButton
    Friend WithEvents radPersonalComputer As System.Windows.Forms.RadioButton
    Friend WithEvents radMainFrame As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalc_Installment As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
