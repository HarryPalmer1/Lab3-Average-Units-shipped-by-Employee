'Program name: Average Units By Employee
'Date: Feb 22, 2019
'Author: Harry Palmer
'Student #: 100558528
'Description: Takes user inputted units shipped for 7 days, for each of 3 employees. Outputs error messages for wrong input or out of range input. After 
'             7 days of units shipped have been entered, the average for the current employee is calculated and displayed. After all 3 employees have all 7 days
'             days completed, the total overall average is calculated and displayed. The user can also reset the entire form and exit the program with buttons.
'
Option Strict On

Public Class frmAverageUnitsByEmployee

    'CONSTANT DECLARATION
    Dim MINIMUM_UNITS As Integer = 0
    Dim MAXIMUM_UNITS As Integer = 1000
    Dim MAXIMUM_DAYS As Integer = 7
    Dim MAXIMUM_EMPLOYEES As Integer = 3

    'VARIABLE DECLARATION
    Dim averageOne As Double = 0.0
    Dim averageTwo As Double = 0.0
    Dim averageThree As Double = 0.0
    Dim totalAverage As Double = 0.0


    Dim userInput As String


    Dim days As Integer = 1
    Dim employeeCounter As Integer = 1
    Dim arrayCounter As Integer
    Dim unitsShipped As Integer

    'ARRAY DECLARATION
    Dim unitsShippedArray(MAXIMUM_DAYS + 1, MAXIMUM_EMPLOYEES + 1) As Integer

    Function Validation(ByVal userInput As String, ByRef unitsShipped As Integer) As Integer
        userInput = txtUnits.Text
        If (Integer.TryParse(userInput, unitsShipped)) Then
            If (unitsShipped < MINIMUM_UNITS Or unitsShipped > MAXIMUM_UNITS) Then
                'Out of range error
                MessageBox.Show("Please ensure the units entered is between " & MINIMUM_UNITS.ToString() & " and " & MAXIMUM_DAYS.ToString() & "!")
                days -= 1
                txtUnits.Focus()
            Else
                If (employeeCounter <= MAXIMUM_EMPLOYEES) Then 'If in range
                    unitsShippedArray(days - 1, employeeCounter - 1) = unitsShipped

                    If employeeCounter = 1 Then 'EMPLOYEE ONE
                        'Make sure the current employee tag is bolded
                        lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, System.Drawing.FontStyle.Bold)

                        'Print current units shipped to the textbox
                        txtEmployeeOneDisplay.Text += unitsShippedArray(days - 1, employeeCounter - 1).ToString() & vbCrLf
                        'Increment days
                        lblDay.Text = "Day " & days + 1
                        days += 1

                        'If all 7 days are completed
                        If (days > MAXIMUM_DAYS) Then
                            'Loop through the array and calculate average
                            For arrayCounter = 1 To MAXIMUM_DAYS
                                averageOne += unitsShippedArray(arrayCounter - 1, employeeCounter - 1)
                            Next
                            averageOne = averageOne / MAXIMUM_DAYS
                            'Add current average to total average
                            totalAverage += averageOne
                            lblEmployeeOneAverage.Text = "Average: " & Math.Round(averageOne, 2).ToString()
                            employeeCounter = 2
                            days = 1
                            lblDay.Text = "Day " & days
                        End If

                    ElseIf employeeCounter = 2 Then  'EMPLOYEE TWO
                        lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, System.Drawing.FontStyle.Bold)
                        lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, System.Drawing.FontStyle.Regular)

                        'Print current units shipped to the textbox
                        txtEmployeeTwoDisplay.Text += unitsShippedArray(days - 1, employeeCounter - 1).ToString() & vbCrLf
                        'Increment days
                        lblDay.Text = "Day " & days + 1
                        days += 1
                        'If all 7 days are completed
                        If (days > MAXIMUM_DAYS) Then
                            'Loop through the array and calculate average
                            For arrayCounter = 1 To MAXIMUM_DAYS
                                averageTwo += unitsShippedArray(arrayCounter - 1, employeeCounter - 1)
                            Next
                            averageTwo = averageTwo / MAXIMUM_DAYS
                            'Add current average to total average
                            totalAverage += averageTwo
                            lblEmployeeTwoAverage.Text = "Average: " & Math.Round(averageTwo, 2).ToString()
                            employeeCounter = 3
                            days = 1
                            lblDay.Text = "Day " & days
                        End If

                    ElseIf employeeCounter = 3 Then 'EMPLOYEE THREE
                        'Make sure the current employee tag is bolded
                        lblEmployeeTwo.Font = New Font(lblEmployeeOne.Font, System.Drawing.FontStyle.Regular)
                        lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, System.Drawing.FontStyle.Bold)

                        'Print current units shipped to the textbox
                        txtEmployeeThreeDisplay.Text += unitsShippedArray(days - 1, employeeCounter - 1).ToString() & vbCrLf
                        'Increment days
                        lblDay.Text = "Day " & days + 1
                        days += 1
                        'If all 7 days are completed
                        If (days > MAXIMUM_DAYS) Then
                            'Loop through the array and calculate average
                            For arrayCounter = 1 To MAXIMUM_DAYS
                                averageThree += unitsShippedArray(arrayCounter - 1, employeeCounter - 1)
                            Next
                            averageThree = averageThree / MAXIMUM_DAYS
                            'Add current average to total average
                            totalAverage += averageThree
                            'Calculate and display total averages
                            totalAverage = totalAverage / MAXIMUM_EMPLOYEES
                            lblEmployeeThreeAverage.Text = "Average: " & Math.Round(averageThree, 2).ToString()
                            lblTotalAverage.Text = "Average per day: " & Math.Round(totalAverage, 2).ToString()
                            employeeCounter = 4
                            lblDay.Text = "Done"
                        End If

                    End If
                End If
            End If
        Else
            'Inproper entry error
            MessageBox.Show("Please ensure the units entered is a whole number!")
            days -= 1
            txtUnits.Focus()
        End If
        Return unitsShipped
    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Call function for inputting units shipped
        Validation(userInput, unitsShipped)
        txtUnits.Clear()
        txtUnits.Focus()

        'If all 3 employees units shipped have been entered, disable controls
        If employeeCounter > MAXIMUM_EMPLOYEES Then
            btnEnter.Enabled = False
            txtUnits.ReadOnly = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'RESET BUTTON

        'Reset data for Employee One
        txtEmployeeOneDisplay.Clear()

        'Reset data for Employee One
        txtEmployeeTwoDisplay.Clear()

        'Reset data for Employee One
        txtEmployeeThreeDisplay.Clear()

        'Reset data for entry 
        txtUnits.Clear()
        txtUnits.Focus()

        'Reset day label
        days = 1

        'Reset averages
        averageOne = 0.0
        averageTwo = 0.0
        averageThree = 0.0
        totalAverage = 0.0
        lblEmployeeOneAverage.ResetText()
        lblEmployeeTwoAverage.ResetText()
        lblEmployeeThreeAverage.ResetText()
        lblTotalAverage.ResetText()

        'Reset employee
        employeeCounter = 1
        days = 1
        lblDay.Text = "Day " & days

        'Re enable controls
        btnEnter.Enabled = True
        txtUnits.ReadOnly = False

        'Unbold all labels
        lblEmployeeOne.Font = New Font(lblEmployeeTwo.Font, System.Drawing.FontStyle.Regular)
        lblEmployeeTwo.Font = New Font(lblEmployeeOne.Font, System.Drawing.FontStyle.Regular)
        lblEmployeeThree.Font = New Font(lblEmployeeOne.Font, System.Drawing.FontStyle.Regular)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()  'Exit the form
    End Sub

End Class
