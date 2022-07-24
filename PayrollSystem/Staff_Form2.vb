Public Class Staff_Form2
    Private Access As New DBControl
    Private Sub ClearTextbox()
        TextBox14.Clear()
        If TextBox14.Text = Nothing Then
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = ""
        End If
    End Sub

    Private Sub RefreshGrid()
        Access.ExecQuery("SELECT * FROM Employee_PayRoll ORDER BY EmployeeID ASC")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Home.PictureBox2.Image, 90, 100, Home.PictureBox2.Width - 25, Home.PictureBox2.Height - 25)
    End Sub

    Private Sub Admin_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        txtReceipt.Text = ""
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab & "EMPLOYEE PAY-SLIP INFO" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Employee ID: " + vbTab & Label1.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("Employee Name: " + vbTab & Label2.Text + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText("Basic Salary: " + vbTab & Label8.Text + vbNewLine)
        txtReceipt.AppendText("Gross Amount: " + vbTab & Label9.Text + vbNewLine)

        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)

        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("[Deductions]" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Withholding Tax: " + vbTab + vbTab & Label3.Text + vbNewLine)
        txtReceipt.AppendText("SSS: " + vbTab + vbTab + vbTab & Label4.Text + vbNewLine)
        txtReceipt.AppendText("PhilHealth: " + vbTab + vbTab & Label5.Text + vbNewLine)
        txtReceipt.AppendText("Pag-Ibig: " + vbTab + vbTab & Label6.Text + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Total Deductions: " + vbTab & Label7.Text + vbTab + vbTab & "Net Amount: " & "  " & Label10.Text + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab & "Date: " + Today & vbTab + vbTab + vbTab + vbTab + vbTab & "Time: " & TimeOfDay + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText(vbTab + "Recieve by:" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + "   __________________" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab & "          " & Label2.Text + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + "                Employee" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("                                                              PAC.Enterprise@gmail.com                                       " + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + Home.PictureBox2.Text + vbNewLine)
        PrintPreviewDialog1.ShowDialog()

        ' CLEAR FIELD
        ClearTextbox()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Access.AddParam("@EmployeeID", "%" & TextBox14.Text & "%")
        Access.ExecQuery("SELECT EmployeeID, Full_Name, Tax, SSS, Philhealth, PagIbig, Total_Deduction, Basic_Pay, Gross_Pay, Net_Pay " &
                         "FROM Employee_PayRoll " &
                         "WHERE EmployeeID LIKE @EmployeeID")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        DataGridView1.DataSource = Access.DBDT

        Dim Employee_Payroll = Access.DBDT
        If Employee_Payroll.Rows.Count() > 0 Then
            Label1.Text = Employee_Payroll.Rows(0)(0).ToString()
            Label2.Text = Employee_Payroll.Rows(0)(1).ToString()
            Label3.Text = Employee_Payroll.Rows(0)(2).ToString()
            Label4.Text = Employee_Payroll.Rows(0)(3).ToString()
            Label5.Text = Employee_Payroll.Rows(0)(4).ToString()
            Label6.Text = Employee_Payroll.Rows(0)(5).ToString()
            Label7.Text = Employee_Payroll.Rows(0)(6).ToString()
            Label8.Text = Employee_Payroll.Rows(0)(7).ToString()
            Label9.Text = Employee_Payroll.Rows(0)(8).ToString()
            Label10.Text = Employee_Payroll.Rows(0)(9).ToString()
        Else
            MessageBox.Show("No Data Found!")
            ClearTextbox()
        End If
    End Sub

    Private Sub Admin_Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub
End Class