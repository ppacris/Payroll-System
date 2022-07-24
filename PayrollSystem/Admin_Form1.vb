Public Class Admin_Form2
    Private Access As New DBControl
    Private Sub ClearTextbox()
        TextBox14.Clear()
        If TextBox14.Text = Nothing Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Refresh()
        End If
    End Sub
    Private Sub UpdateRecord()
        ' FAIL IF NO USER SELECTED
        If String.IsNullOrEmpty(TextBox1.Text) Then Exit Sub

        ' ADD PARAMETERS - ORDER MATTERS !!!
        Access.AddParam("@Full_Name", TextBox2.Text)
        Access.AddParam("@Address", TextBox3.Text)
        Access.AddParam("@Contact_Number", TextBox4.Text)
        Access.AddParam("@Email", TextBox5.Text)
        Access.AddParam("@Position", TextBox6.Text)
        Access.AddParam("@Date_of_Birth", TextBox7.Text)
        Access.AddParam("@EmployeeID", TextBox1.Text)

        ' RUN COMMAND
        Access.ExecQuery("UPDATE Employee_Info " &
                         "SET [Full_Name]=@Full_Name,[Address]=@Address,[Contact_Number]=@Contact_Number,[Email]=@Email,[Position]=@Position,[Date_of_Birth]=@Date_of_Birth " &
                         "WHERE EmployeeID=@EmployeeID")

        ' ADD PARAMETERS - ORDER MATTERS !!!
        Access.AddParam("@Full_Name", TextBox2.Text)
        Access.AddParam("@EmployeeID", TextBox1.Text)

        ' RUN COMMAND
        Access.ExecQuery("UPDATE Employee_PayRoll " &
                         "SET [Full_Name]=@Full_Name " &
                         "WHERE EmployeeID=@EmployeeID")

        ' UPDATE & FETCH DATAGRIDVIEW
        Access.ExecQuery("SELECT * FROM Employee_Info")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, Font, Brushes.Black, 140, 140)
    End Sub

    Private Sub Admin_Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Access.ExecQuery("SELECT * FROM Employee_Info")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Access.AddParam("@EmployeeID", TextBox1.Text)
        Access.AddParam("@Full_Name", TextBox2.Text)
        Access.AddParam("@Address", TextBox3.Text)
        Access.AddParam("@Contact_Number", TextBox4.Text)
        Access.AddParam("@Email", TextBox5.Text)
        Access.AddParam("@Position", TextBox6.Text)
        Access.AddParam("@Date_of_Birth", TextBox7.Text)

        Access.ExecQuery("INSERT INTO Employee_Info ([EmployeeID],[Full_Name],[Address],[Contact_Number],[Email],[Position],[Date_of_Birth]) " &
                         "VALUES ([@EmployeeID],[@Full_Name],[@Address],[@Contact_Number],[@Email],[@Position],[@Date_of_Birth]); ")


        Access.AddParam("@EmployeeID", TextBox1.Text)
        Access.AddParam("@Full_Name", TextBox2.Text)

        Access.ExecQuery("INSERT INTO Employee_PayRoll(EmployeeID,Full_Name) " &
                         "VALUES (@EmployeeID,@Full_Name); ")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' UPDATE & FETCH DATAGRIDVIEW
        Access.ExecQuery("SELECT * FROM Employee_Info")
        DataGridView1.DataSource = Access.DBDT

        ' MESSAGE SHOW & CLEAR TEXTBOXES
        MessageBox.Show("Successfully Added")
        ClearTextbox()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Access.AddParam("@EmployeeID", "%" & TextBox14.Text & "%")
        Access.ExecQuery("SELECT [EmployeeID],[Full_Name],[Address],[Contact_Number],[Email],[Position],[Date_of_Birth] " &
                         "FROM Employee_Info " &
                         "WHERE EmployeeID LIKE @EmployeeID ")

        ' REPORT & ABORT ON ERRORS
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        DataGridView1.DataSource = Access.DBDT

        Dim Employee_Info = Access.DBDT
        If Employee_Info.Rows.Count() > 0 Then
            TextBox1.Text = Employee_Info.Rows(0)(0).ToString()
            TextBox2.Text = Employee_Info.Rows(0)(1).ToString()
            TextBox3.Text = Employee_Info.Rows(0)(2).ToString()
            TextBox4.Text = Employee_Info.Rows(0)(3).ToString()
            TextBox5.Text = Employee_Info.Rows(0)(4).ToString()
            TextBox6.Text = Employee_Info.Rows(0)(5).ToString()
            TextBox7.Text = Employee_Info.Rows(0)(6).ToString()
        Else
            MessageBox.Show("No Data Found!")
            ClearTextbox()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        UpdateRecord()
        ClearTextbox()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText("---[Employee Info]---" + vbNewLine)

        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Employee ID: " + vbTab & "|" & TextBox1.Text + vbTab + vbNewLine)
        txtReceipt.AppendText("Employee Name: " + vbTab & "|" & TextBox2.Text + vbTab + vbNewLine)
        txtReceipt.AppendText("Address: " + vbTab + vbTab & "|" & TextBox3.Text + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("Contact Number: " + vbTab & "|" & TextBox4.Text + vbTab + vbNewLine)
        txtReceipt.AppendText("Email: " + vbTab + vbTab & "|" & TextBox5.Text + vbTab + vbNewLine)
        txtReceipt.AppendText("Position: " + vbTab + vbTab & "|" & TextBox6.Text + vbTab + vbNewLine)
        txtReceipt.AppendText("Date of Birth: " + vbTab & "|" & TextBox7.Text + vbTab + vbNewLine)
        PrintPreviewDialog1.ShowDialog()

        ' CLEAR TEXTBOX
        ClearTextbox()
    End Sub

    Private Sub Admin_Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class