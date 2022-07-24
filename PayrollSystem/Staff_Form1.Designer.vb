<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Form1
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim GrossAmountLabel As System.Windows.Forms.Label
        Dim BasicLabel As System.Windows.Forms.Label
        Dim TotalDeductionLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.Btn_Compute = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Textbox_NetPay = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Textbox_GrossPay = New System.Windows.Forms.TextBox()
        Me.Textbox_BasicPay = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReceipt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Textbox_SSS = New System.Windows.Forms.TextBox()
        Me.Textbox_Philhealth = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Textbox_TotalDeduc = New System.Windows.Forms.TextBox()
        Me.Textbox_PagIbig = New System.Windows.Forms.TextBox()
        Me.Textbox_Tax = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Label9 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        GrossAmountLabel = New System.Windows.Forms.Label()
        BasicLabel = New System.Windows.Forms.Label()
        TotalDeductionLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label9.Location = New System.Drawing.Point(226, 25)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(47, 21)
        Label9.TabIndex = 57
        Label9.Text = "/day"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Label6.Location = New System.Drawing.Point(7, 17)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 19)
        Label6.TabIndex = 10
        Label6.Text = "Net Pay:"
        '
        'GrossAmountLabel
        '
        GrossAmountLabel.AutoSize = True
        GrossAmountLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrossAmountLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        GrossAmountLabel.Location = New System.Drawing.Point(7, 17)
        GrossAmountLabel.Name = "GrossAmountLabel"
        GrossAmountLabel.Size = New System.Drawing.Size(86, 19)
        GrossAmountLabel.TabIndex = 10
        GrossAmountLabel.Text = "Gross Pay:"
        '
        'BasicLabel
        '
        BasicLabel.AutoSize = True
        BasicLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        BasicLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        BasicLabel.Location = New System.Drawing.Point(18, 25)
        BasicLabel.Name = "BasicLabel"
        BasicLabel.Size = New System.Drawing.Size(85, 21)
        BasicLabel.TabIndex = 6
        BasicLabel.Text = "Basic Pay:"
        '
        'TotalDeductionLabel
        '
        TotalDeductionLabel.AutoSize = True
        TotalDeductionLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalDeductionLabel.ForeColor = System.Drawing.Color.Red
        TotalDeductionLabel.Location = New System.Drawing.Point(6, 19)
        TotalDeductionLabel.Name = "TotalDeductionLabel"
        TotalDeductionLabel.Size = New System.Drawing.Size(159, 23)
        TotalDeductionLabel.TabIndex = 46
        TotalDeductionLabel.Text = "Total Deduction:"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label3.Location = New System.Drawing.Point(105, 69)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(38, 21)
        Label3.TabIndex = 54
        Label3.Text = "SSS:"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label4.Location = New System.Drawing.Point(53, 102)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(90, 21)
        Label4.TabIndex = 56
        Label4.Text = "Philhealth:"
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label5.Location = New System.Drawing.Point(65, 135)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(78, 21)
        Label5.TabIndex = 58
        Label5.Text = "Pag-ibig:"
        '
        'Label7
        '
        Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label7.Location = New System.Drawing.Point(6, 36)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(138, 21)
        Label7.TabIndex = 12
        Label7.Text = "Withholding Tax:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(744, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "Search ID:"
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TextBox14.Location = New System.Drawing.Point(833, 8)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(201, 27)
        Me.TextBox14.TabIndex = 245
        '
        'Btn_Print
        '
        Me.Btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Print.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Print.FlatAppearance.BorderSize = 0
        Me.Btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen
        Me.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Print.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Print.Image = CType(resources.GetObject("Btn_Print.Image"), System.Drawing.Image)
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.Location = New System.Drawing.Point(943, 526)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Btn_Print.Size = New System.Drawing.Size(93, 40)
        Me.Btn_Print.TabIndex = 244
        Me.Btn_Print.Text = "  Print"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Print.UseVisualStyleBackColor = False
        '
        'Btn_Compute
        '
        Me.Btn_Compute.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Compute.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Btn_Compute.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_Compute.Location = New System.Drawing.Point(19, 536)
        Me.Btn_Compute.Name = "Btn_Compute"
        Me.Btn_Compute.Size = New System.Drawing.Size(112, 40)
        Me.Btn_Compute.TabIndex = 243
        Me.Btn_Compute.Text = "COMPUTE"
        Me.Btn_Compute.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Save.BackColor = System.Drawing.Color.YellowGreen
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Save.Image = CType(resources.GetObject("Btn_Save.Image"), System.Drawing.Image)
        Me.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Save.Location = New System.Drawing.Point(336, 527)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(132, 40)
        Me.Btn_Save.TabIndex = 241
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Label9)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Textbox_BasicPay)
        Me.GroupBox4.Controls.Add(BasicLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 367)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 163)
        Me.GroupBox4.TabIndex = 240
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Textbox_NetPay)
        Me.GroupBox6.Controls.Add(Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(22, 104)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(251, 45)
        Me.GroupBox6.TabIndex = 56
        Me.GroupBox6.TabStop = False
        '
        'Textbox_NetPay
        '
        Me.Textbox_NetPay.Cursor = System.Windows.Forms.Cursors.No
        Me.Textbox_NetPay.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_NetPay.Location = New System.Drawing.Point(85, 14)
        Me.Textbox_NetPay.Name = "Textbox_NetPay"
        Me.Textbox_NetPay.ReadOnly = True
        Me.Textbox_NetPay.Size = New System.Drawing.Size(159, 27)
        Me.Textbox_NetPay.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Textbox_GrossPay)
        Me.GroupBox3.Controls.Add(GrossAmountLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 45)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Textbox_GrossPay
        '
        Me.Textbox_GrossPay.Cursor = System.Windows.Forms.Cursors.No
        Me.Textbox_GrossPay.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_GrossPay.Location = New System.Drawing.Point(99, 14)
        Me.Textbox_GrossPay.Name = "Textbox_GrossPay"
        Me.Textbox_GrossPay.ReadOnly = True
        Me.Textbox_GrossPay.Size = New System.Drawing.Size(145, 27)
        Me.Textbox_GrossPay.TabIndex = 11
        '
        'Textbox_BasicPay
        '
        Me.Textbox_BasicPay.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_BasicPay.Location = New System.Drawing.Point(109, 22)
        Me.Textbox_BasicPay.Name = "Textbox_BasicPay"
        Me.Textbox_BasicPay.Size = New System.Drawing.Size(115, 27)
        Me.Textbox_BasicPay.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(336, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(702, 508)
        Me.TabControl1.TabIndex = 239
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 474)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(691, 479)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReceipt)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 474)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReceipt
        '
        Me.txtReceipt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReceipt.Location = New System.Drawing.Point(0, 0)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.Size = New System.Drawing.Size(694, 482)
        Me.txtReceipt.TabIndex = 0
        Me.txtReceipt.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Textbox_SSS)
        Me.GroupBox2.Controls.Add(Me.Textbox_Philhealth)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Me.Textbox_PagIbig)
        Me.GroupBox2.Controls.Add(Me.Textbox_Tax)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 231)
        Me.GroupBox2.TabIndex = 238
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deduction"
        '
        'Textbox_SSS
        '
        Me.Textbox_SSS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_SSS.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_SSS.ForeColor = System.Drawing.Color.Red
        Me.Textbox_SSS.Location = New System.Drawing.Point(149, 66)
        Me.Textbox_SSS.Name = "Textbox_SSS"
        Me.Textbox_SSS.Size = New System.Drawing.Size(144, 27)
        Me.Textbox_SSS.TabIndex = 55
        '
        'Textbox_Philhealth
        '
        Me.Textbox_Philhealth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_Philhealth.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_Philhealth.ForeColor = System.Drawing.Color.Red
        Me.Textbox_Philhealth.Location = New System.Drawing.Point(149, 99)
        Me.Textbox_Philhealth.Name = "Textbox_Philhealth"
        Me.Textbox_Philhealth.Size = New System.Drawing.Size(144, 27)
        Me.Textbox_Philhealth.TabIndex = 57
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.Textbox_TotalDeduc)
        Me.GroupBox5.Controls.Add(TotalDeductionLabel)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 162)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(292, 56)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        '
        'Textbox_TotalDeduc
        '
        Me.Textbox_TotalDeduc.Cursor = System.Windows.Forms.Cursors.No
        Me.Textbox_TotalDeduc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_TotalDeduc.Location = New System.Drawing.Point(171, 19)
        Me.Textbox_TotalDeduc.Name = "Textbox_TotalDeduc"
        Me.Textbox_TotalDeduc.ReadOnly = True
        Me.Textbox_TotalDeduc.Size = New System.Drawing.Size(109, 27)
        Me.Textbox_TotalDeduc.TabIndex = 47
        '
        'Textbox_PagIbig
        '
        Me.Textbox_PagIbig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_PagIbig.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_PagIbig.ForeColor = System.Drawing.Color.Red
        Me.Textbox_PagIbig.Location = New System.Drawing.Point(149, 132)
        Me.Textbox_PagIbig.Name = "Textbox_PagIbig"
        Me.Textbox_PagIbig.Size = New System.Drawing.Size(144, 27)
        Me.Textbox_PagIbig.TabIndex = 59
        '
        'Textbox_Tax
        '
        Me.Textbox_Tax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_Tax.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Textbox_Tax.ForeColor = System.Drawing.Color.Red
        Me.Textbox_Tax.Location = New System.Drawing.Point(149, 33)
        Me.Textbox_Tax.Name = "Textbox_Tax"
        Me.Textbox_Tax.Size = New System.Drawing.Size(144, 27)
        Me.Textbox_Tax.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 102)
        Me.GroupBox1.TabIndex = 237
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Info"
        '
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(181, 27)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Employee ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(111, 27)
        Me.TextBox1.TabIndex = 1
        '
        'Staff_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 647)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.Btn_Compute)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Staff_Form1"
        Me.Text = "Staff_Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Btn_Print As Button
    Friend WithEvents Btn_Compute As Button
    Public WithEvents Btn_Save As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Textbox_NetPay As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Textbox_GrossPay As TextBox
    Friend WithEvents Textbox_BasicPay As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtReceipt As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Textbox_SSS As TextBox
    Friend WithEvents Textbox_Philhealth As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Textbox_TotalDeduc As TextBox
    Friend WithEvents Textbox_PagIbig As TextBox
    Friend WithEvents Textbox_Tax As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
