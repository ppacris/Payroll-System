Public Class Staff_Form1
    Private Access As New DBControl
    Private Sub ClearTextbox()
        TextBox14.Clear()
        If TextBox14.Text = Nothing Then
            TextBox1.Clear()
            TextBox2.Clear()
            Textbox_Tax.Clear()
            Textbox_SSS.Clear()
            Textbox_Philhealth.Clear()
            Textbox_PagIbig.Clear()
            Textbox_TotalDeduc.Clear()
            Textbox_BasicPay.Clear()
            Textbox_GrossPay.Clear()
            Textbox_NetPay.Clear()
        End If
    End Sub

    Private Sub RefreshGrid()
        Access.ExecQuery("SELECT * FROM Employee_PayRoll ORDER BY EmployeeID ASC")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Private Sub UpdateRecord()
        ' FAIL IF NO USER SELECTED
        If String.IsNullOrEmpty(TextBox1.Text) Then Exit Sub

        ' ADD PARAMETERS - ORDER MATTERS !!!
        Access.AddParam("@Full_Name", TextBox2.Text)
        Access.AddParam("@Tax", Textbox_Tax.Text)
        Access.AddParam("@SSS", Textbox_SSS.Text)
        Access.AddParam("@Philhealth", Textbox_Philhealth.Text)
        Access.AddParam("@PagIbig", Textbox_PagIbig.Text)
        Access.AddParam("@Total_Deduction", Textbox_TotalDeduc.Text)
        Access.AddParam("@Basic_Pay", Textbox_BasicPay.Text)
        Access.AddParam("@Gross_Pay", Textbox_GrossPay.Text)
        Access.AddParam("@Net_Pay", Textbox_NetPay.Text)
        Access.AddParam("@EmployeeID", TextBox1.Text)

        ' RUN COMMAND
        Access.ExecQuery("UPDATE Employee_PayRoll " &
                         "SET Full_Name=@Full_Name,Tax=@Tax,SSS=@SSS,Philhealth=@Philhealth,PagIbig=@PagIbig,Total_Deduction=@Total_Deduction,Basic_Pay=@Basic_Pay,Gross_Pay=@Gross_Pay,Net_Pay=@Net_Pay " &
                         "WHERE EmployeeID=@EmployeeID")

        ' UPDATE & FETCH DATAGRIDVIEW
        RefreshGrid()
    End Sub
    Private Sub Staff_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            TextBox1.Text = Employee_Payroll.Rows(0)(0).ToString()
            TextBox2.Text = Employee_Payroll.Rows(0)(1).ToString()
            Textbox_Tax.Text = Employee_Payroll.Rows(0)(2).ToString()
            Textbox_SSS.Text = Employee_Payroll.Rows(0)(3).ToString()
            Textbox_Philhealth.Text = Employee_Payroll.Rows(0)(4).ToString()
            Textbox_PagIbig.Text = Employee_Payroll.Rows(0)(5).ToString()
            Textbox_TotalDeduc.Text = Employee_Payroll.Rows(0)(6).ToString()
            Textbox_BasicPay.Text = Employee_Payroll.Rows(0)(7).ToString()
            Textbox_GrossPay.Text = Employee_Payroll.Rows(0)(8).ToString()
            Textbox_NetPay.Text = Employee_Payroll.Rows(0)(9).ToString()
        Else
            MessageBox.Show("No Data Found!")
            ClearTextbox()
        End If
    End Sub

    Private Sub Btn_Compute_Click(sender As Object, e As EventArgs) Handles Btn_Compute.Click
        Try
            'Total Deduction Ammount
            Textbox_TotalDeduc.Text = Val(Textbox_Tax.Text) + Val(Textbox_SSS.Text) + Val(Textbox_Philhealth.Text) + Val(Textbox_PagIbig.Text)
            'Gross Pay Ammount
            Textbox_GrossPay.Text = Val(Textbox_BasicPay.Text) * 26
            'Net Pay Ammount
            Textbox_NetPay.Text = Val(Textbox_GrossPay.Text) - Val(Textbox_TotalDeduc.Text)
            MessageBox.Show("Successfully Computed")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        UpdateRecord()
        ClearTextbox()
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

        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "PAY-SLIP" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Employee ID: " + vbTab & TextBox1.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("Employee Name: " + vbTab & TextBox2.Text + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText("Basic Salary: " + vbTab & Textbox_BasicPay.Text + vbNewLine)
        txtReceipt.AppendText("Gross Amount: " + vbTab & Textbox_GrossPay.Text + vbNewLine)

        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)

        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("[Deductions]" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Withholding Tax: " + vbTab + vbTab & Textbox_Tax.Text + vbNewLine)
        txtReceipt.AppendText("SSS: " + vbTab + vbTab + vbTab & Textbox_SSS.Text + vbNewLine)
        txtReceipt.AppendText("PhilHealth: " + vbTab + vbTab & Textbox_Philhealth.Text + vbNewLine)
        txtReceipt.AppendText("Pag-Ibig: " + vbTab + vbTab & Textbox_PagIbig.Text + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Total Deductions: " + vbTab & Textbox_TotalDeduc.Text + vbTab + vbTab & "Net Amount: " & "  " & Textbox_NetPay.Text + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab & "Date: " + Today & vbTab + vbTab + vbTab + vbTab + vbTab & "Time: " & TimeOfDay + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText(vbTab + "Recieve by:" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + "   __________________" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab & "          " & TextBox2.Text + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + "                Employee" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("                                       Need Help?            Contact Us: PAC.Enterprise@gmail.com                                       " + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + Home.PictureBox2.Text + vbNewLine)
        PrintPreviewDialog1.ShowDialog()

        ' CLEAR TEXTBOX
        ClearTextbox()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Home.PictureBox2.Image, 90, 100, Home.PictureBox2.Width - 25, Home.PictureBox2.Height - 25)
    End Sub

    Private Sub Staff_Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub
End Class