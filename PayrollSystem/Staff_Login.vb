Imports System.Data.OleDb
Public Class Staff_Login
    Private Access As New DBControl
    Private Sub LabelHide()
        ' LABEL STATUS
        Home.lbl_Admin.Visible = False
        Home.lbl_Emp.Visible = False
        Home.Label5.Visible = False
        Home.Label3.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("Enter Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' // Establish connection to MS Access DATABASE
        If Access.DBCon.State = ConnectionState.Closed Then Access.DBCon.Open()

        Dim DBCmd As New OleDbCommand("SELECT * FROM Admin_Staff " &
                                      "WHERE [Username] = @username AND [Password] = @password ", Access.DBCon)
        DBCmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = TextBox1.Text
        DBCmd.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = TextBox2.Text

        Dim count = Convert.ToInt32(DBCmd.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Log in Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Home.Panel_Staff.Visible = True
            Home.OpenChildFormInPanel(New Roadmap_Form())
        Else
            MessageBox.Show("Invalid User or Password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LabelHide()
    End Sub

    Private Sub Staff_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Staff_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class