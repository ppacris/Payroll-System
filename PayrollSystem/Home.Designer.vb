<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_Staff = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel_Admin = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Emp = New System.Windows.Forms.Label()
        Me.lbl_Admin = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Employee = New System.Windows.Forms.Button()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel_Staff.SuspendLayout()
        Me.Panel_Admin.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel_Staff)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Panel_Admin)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 718)
        Me.Panel1.TabIndex = 1
        '
        'Panel_Staff
        '
        Me.Panel_Staff.Controls.Add(Me.Button1)
        Me.Panel_Staff.Controls.Add(Me.Button2)
        Me.Panel_Staff.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Staff.Location = New System.Drawing.Point(0, 382)
        Me.Panel_Staff.Name = "Panel_Staff"
        Me.Panel_Staff.Size = New System.Drawing.Size(208, 166)
        Me.Panel_Staff.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 81)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Employee Data"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 81)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = " Modify Pay-Slip"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 688)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(208, 30)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "  Logout"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel_Admin
        '
        Me.Panel_Admin.Controls.Add(Me.Button6)
        Me.Panel_Admin.Controls.Add(Me.Button4)
        Me.Panel_Admin.Controls.Add(Me.Button3)
        Me.Panel_Admin.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Admin.Location = New System.Drawing.Point(0, 135)
        Me.Panel_Admin.Name = "Panel_Admin"
        Me.Panel_Admin.Size = New System.Drawing.Size(208, 247)
        Me.Panel_Admin.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(208, 81)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Maintenance"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(208, 103)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbl_Emp)
        Me.Panel2.Controls.Add(Me.lbl_Admin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 32)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Home"
        '
        'lbl_Emp
        '
        Me.lbl_Emp.AutoSize = True
        Me.lbl_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Emp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Emp.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Emp.Name = "lbl_Emp"
        Me.lbl_Emp.Size = New System.Drawing.Size(86, 21)
        Me.lbl_Emp.TabIndex = 6
        Me.lbl_Emp.Text = "User: Staff"
        '
        'lbl_Admin
        '
        Me.lbl_Admin.AutoSize = True
        Me.lbl_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Admin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_Admin.Location = New System.Drawing.Point(3, 4)
        Me.lbl_Admin.Name = "lbl_Admin"
        Me.lbl_Admin.Size = New System.Drawing.Size(102, 21)
        Me.lbl_Admin.TabIndex = 5
        Me.lbl_Admin.Text = "User: Admin"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnMaximize)
        Me.Panel3.Controls.Add(Me.btnMinimize)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(208, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1070, 32)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "|"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1042, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 10
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Location = New System.Drawing.Point(1011, 4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(25, 25)
        Me.btnMaximize.TabIndex = 9
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(980, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'panelChildForm
        '
        Me.panelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.panelChildForm.Controls.Add(Me.PictureBox2)
        Me.panelChildForm.Controls.Add(Me.Label2)
        Me.panelChildForm.Controls.Add(Me.Label1)
        Me.panelChildForm.Controls.Add(Me.btn_Employee)
        Me.panelChildForm.Controls.Add(Me.btn_Admin)
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.Location = New System.Drawing.Point(208, 32)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1070, 686)
        Me.panelChildForm.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(392, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(696, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Staff"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(301, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin"
        '
        'btn_Employee
        '
        Me.btn_Employee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Employee.BackColor = System.Drawing.Color.White
        Me.btn_Employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Employee.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Employee.Location = New System.Drawing.Point(630, 210)
        Me.btn_Employee.Name = "btn_Employee"
        Me.btn_Employee.Size = New System.Drawing.Size(201, 220)
        Me.btn_Employee.TabIndex = 2
        Me.btn_Employee.UseVisualStyleBackColor = False
        '
        'btn_Admin
        '
        Me.btn_Admin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Admin.BackColor = System.Drawing.Color.White
        Me.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Admin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Admin.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_Admin.Location = New System.Drawing.Point(267, 210)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(201, 220)
        Me.btn_Admin.TabIndex = 1
        Me.btn_Admin.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(208, 81)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = " Employee Data"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Yellow
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 162)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(208, 81)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Restore Data"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Staff.ResumeLayout(False)
        Me.Panel_Admin.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelChildForm.ResumeLayout(False)
        Me.panelChildForm.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_Staff As Panel
    Public WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel_Admin As Panel
    Public WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_Emp As Label
    Friend WithEvents lbl_Admin As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Employee As Button
    Friend WithEvents btn_Admin As Button
    Public WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Public WithEvents Button4 As Button
    Public WithEvents Button6 As Button
End Class
