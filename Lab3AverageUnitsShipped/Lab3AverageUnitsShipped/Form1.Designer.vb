<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsByEmployee
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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.UnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEmployeeOneDisplay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwoDisplay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThreeDisplay = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(25, 18)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(25, 51)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units: "
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(79, 51)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 22)
        Me.txtUnits.TabIndex = 2
        Me.UnitsShippedToolTip.SetToolTip(Me.txtUnits, "Enter units shipped for current day")
        '
        'txtEmployeeOneDisplay
        '
        Me.txtEmployeeOneDisplay.Location = New System.Drawing.Point(28, 113)
        Me.txtEmployeeOneDisplay.Multiline = True
        Me.txtEmployeeOneDisplay.Name = "txtEmployeeOneDisplay"
        Me.txtEmployeeOneDisplay.ReadOnly = True
        Me.txtEmployeeOneDisplay.Size = New System.Drawing.Size(151, 132)
        Me.txtEmployeeOneDisplay.TabIndex = 3
        Me.UnitsShippedToolTip.SetToolTip(Me.txtEmployeeOneDisplay, "Units shipped for Employee one")
        '
        'txtEmployeeTwoDisplay
        '
        Me.txtEmployeeTwoDisplay.Location = New System.Drawing.Point(197, 113)
        Me.txtEmployeeTwoDisplay.Multiline = True
        Me.txtEmployeeTwoDisplay.Name = "txtEmployeeTwoDisplay"
        Me.txtEmployeeTwoDisplay.ReadOnly = True
        Me.txtEmployeeTwoDisplay.Size = New System.Drawing.Size(151, 132)
        Me.txtEmployeeTwoDisplay.TabIndex = 6
        Me.UnitsShippedToolTip.SetToolTip(Me.txtEmployeeTwoDisplay, "Units shipped for Employee two")
        '
        'txtEmployeeThreeDisplay
        '
        Me.txtEmployeeThreeDisplay.Location = New System.Drawing.Point(364, 113)
        Me.txtEmployeeThreeDisplay.Multiline = True
        Me.txtEmployeeThreeDisplay.Name = "txtEmployeeThreeDisplay"
        Me.txtEmployeeThreeDisplay.ReadOnly = True
        Me.txtEmployeeThreeDisplay.Size = New System.Drawing.Size(151, 132)
        Me.txtEmployeeThreeDisplay.TabIndex = 9
        Me.UnitsShippedToolTip.SetToolTip(Me.txtEmployeeThreeDisplay, "Units shipped for Employee three")
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(28, 258)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(151, 34)
        Me.lblEmployeeOneAverage.TabIndex = 4
        Me.lblEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.AutoSize = True
        Me.lblEmployeeOne.Location = New System.Drawing.Point(61, 84)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeOne.TabIndex = 5
        Me.lblEmployeeOne.Text = "Employee 1"
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.AutoSize = True
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(230, 84)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeTwo.TabIndex = 8
        Me.lblEmployeeTwo.Text = "Employee 2"
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(197, 258)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(151, 34)
        Me.lblEmployeeTwoAverage.TabIndex = 7
        Me.lblEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.AutoSize = True
        Me.lblEmployeeThree.Location = New System.Drawing.Point(397, 84)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeThree.TabIndex = 11
        Me.lblEmployeeThree.Text = "Employee 3"
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(364, 258)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(151, 34)
        Me.lblEmployeeThreeAverage.TabIndex = 10
        Me.lblEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAverage.Location = New System.Drawing.Point(28, 305)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(487, 34)
        Me.lblTotalAverage.TabIndex = 12
        Me.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(28, 349)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(151, 33)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(197, 349)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 33)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(364, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 33)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(545, 405)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.txtEmployeeThreeDisplay)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.txtEmployeeTwoDisplay)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.txtEmployeeOneDisplay)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents UnitsShippedToolTip As ToolTip
    Friend WithEvents txtEmployeeOneDisplay As TextBox
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents txtEmployeeTwoDisplay As TextBox
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents txtEmployeeThreeDisplay As TextBox
    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
