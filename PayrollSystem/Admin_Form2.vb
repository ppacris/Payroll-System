Public Class Admin_Form3
    Private Access As New DBControl
    Private Sub ClearTextbox()
        TextBox14.Clear()
        If TextBox14.Text = Nothing Then
            Label8.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
            Label6.Text = ""
            Label7.Text = ""
            Label14.Text = ""
            Label9.Text = ""
            Label10.Text = ""
        End If
    End Sub

    Private Sub RefreshGrid()
        Access.ExecQuery("SELECT * FROM Employee_PayRoll ORDER BY EmployeeID ASC")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Private Sub Admin_Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Admin_Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        ' FAIL IF NO USER SELECTED
        If String.IsNullOrEmpty(Label1.Text) Then Exit Sub

        ' ADD PARAMETERS - ORDER MATTERS !!!
        Access.AddParam("@EmployeeID", Label1.Text)
        Access.AddParam("@Full_Name", Label2.Text)
        Access.AddParam("@Tax", Label3.Text)
        Access.AddParam("@SSS", Label4.Text)
        Access.AddParam("@Philhealth", Label5.Text)
        Access.AddParam("@PagIbig", Label6.Text)
        Access.AddParam("@Total_Deduction", Label7.Text)
        Access.AddParam("@Basic_Pay", Label8.Text)
        Access.AddParam("@Gross_Pay", Label9.Text)
        Access.AddParam("@Net_Pay", Label10.Text)

        ' RUN COMMAND
        Access.ExecQuery("INSERT INTO Deleted_EmpData ([EmployeeID],[Full_Name],[Tax],[SSS],[Philhealth],[PagIbig],[Total_Deduction],[Basic_Pay],[Gross_Pay],[Net_Pay]) " &
                         "VALUES ([EmployeeID],[Full_Name],[Tax],[SSS],[Philhealth],[PagIbig],[Total_Deduction],[Basic_Pay],[Gross_Pay],[Net_Pay]); ")

        ' CONFIRM DELETE
        If MsgBox("Are you sure that you want to delete the selected user?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        ' DELETE SELECTED USER
        Access.AddParam("@EmployeeID", Label1.Text)
        Access.ExecQuery("DELETE FROM Employee_Payroll WHERE EmployeeID=@EmployeeID")


        ' UPDATE & FETCH DATAGRIDVIEW
        RefreshGrid()
    End Sub
End Class