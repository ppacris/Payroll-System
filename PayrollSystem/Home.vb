Public Class Home
    Private Sub LabelShowAdmin()
        If lbl_Admin.Visible = False Then
            lbl_Admin.Visible = True
            Label3.Visible = False
        End If
    End Sub

    Private Sub LabelShowStaff()
        If lbl_Emp.Visible = False Then
            lbl_Emp.Visible = True
            Label3.Visible = False
        End If
    End Sub

    Private Sub LabelHide()
        ' LABEL STATUS
        lbl_Admin.Visible = False
        lbl_Emp.Visible = False
        Label5.Visible = False
        Label3.Visible = True

        ' PANEL BUTTON
        Panel_Admin.Visible = False
        Panel_Staff.Visible = False
    End Sub

    Dim activeF As Form
    Public Sub OpenChildFormInPanel(ByVal childForm As Form)
        If (Not (activeF) Is Nothing) Then
            activeF.Close()
        End If
        activeF = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Btn_Image()
        btn_Admin.BackgroundImageLayout = ImageLayout.Stretch
        btn_Admin.BackgroundImage = Image.FromFile("D:\Download\Online Class\Others\Icons\512px\admin.png")

        btn_Employee.BackgroundImageLayout = ImageLayout.Stretch
        btn_Employee.BackgroundImage = Image.FromFile("D:\Download\Online Class\Others\Icons\512px\teamwork.png")
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If (WindowState = FormWindowState.Normal) Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = "|Maintenance"
        Label5.Visible = True
        OpenChildFormInPanel(New Admin_Form2())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "|Employee Data"
        Label5.Visible = True
        OpenChildFormInPanel(New Staff_Form2())
    End Sub

    Private Sub btn_Admin_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click
        OpenChildFormInPanel(New Admin_Login())
        LabelShowAdmin()
    End Sub

    Private Sub Home_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Btn_Image()
        LabelHide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If activeF IsNot Nothing Then
            activeF.Close()
        End If
        LabelHide()
    End Sub

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        OpenChildFormInPanel(New Staff_Login())
        LabelShowStaff()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "|Modify Pay-Slip"
        Label5.Visible = True
        OpenChildFormInPanel(New Staff_Form1())
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5.Text = "|Employee Data"
        Label5.Visible = True
        OpenChildFormInPanel(New Admin_Form3())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label5.Text = "|Restore Data"
        Label5.Visible = True
        OpenChildFormInPanel(New Admin_Form4())
    End Sub
End Class
