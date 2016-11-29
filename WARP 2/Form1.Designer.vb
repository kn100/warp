<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warp2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Warp2))
        Me.LvwVideoList = New System.Windows.Forms.ListView()
        Me.Videoname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Datecreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filepath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVidDown = New System.Windows.Forms.Button()
        Me.btnVidUp = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tboCustomName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TbsBitrate = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboCompress = New System.Windows.Forms.CheckBox()
        Me.cboQual = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSpeed = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudNumberOfVideos = New System.Windows.Forms.NumericUpDown()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnBrowseForClose = New System.Windows.Forms.Button()
        Me.cboEnableClose = New System.Windows.Forms.CheckBox()
        Me.btnBrowseForIntro = New System.Windows.Forms.Button()
        Me.cboEnableIntro = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.cboEnableMultirend = New System.Windows.Forms.CheckBox()
        Me.Renderqueue = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSetSave = New System.Windows.Forms.Button()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.tboOnShutDown = New System.Windows.Forms.CheckBox()
        Me.tboOnEmptyQueue = New System.Windows.Forms.CheckBox()
        Me.tboOnFinishPart = New System.Windows.Forms.CheckBox()
        Me.lvwRenderList = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMinimiseUI = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnStartRender = New System.Windows.Forms.Button()
        Me.BtnRemoveVideo = New System.Windows.Forms.Button()
        Me.BtnAddVideo = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbsBitrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudNumberOfVideos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Renderqueue.SuspendLayout()
        Me.SuspendLayout()
        '
        'LvwVideoList
        '
        Me.LvwVideoList.AllowDrop = True
        Me.LvwVideoList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvwVideoList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Videoname, Me.Datecreated, Me.Filepath})
        Me.LvwVideoList.FullRowSelect = True
        Me.LvwVideoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvwVideoList.Location = New System.Drawing.Point(3, 2)
        Me.LvwVideoList.Name = "LvwVideoList"
        Me.LvwVideoList.Size = New System.Drawing.Size(565, 206)
        Me.LvwVideoList.TabIndex = 1
        Me.LvwVideoList.UseCompatibleStateImageBehavior = False
        Me.LvwVideoList.View = System.Windows.Forms.View.Details
        '
        'Videoname
        '
        Me.Videoname.Text = "Video name"
        Me.Videoname.Width = 366
        '
        'Datecreated
        '
        Me.Datecreated.Text = "Date created"
        Me.Datecreated.Width = 138
        '
        'Filepath
        '
        Me.Filepath.Text = "File path"
        Me.Filepath.Width = 0
        '
        'btnVidDown
        '
        Me.btnVidDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVidDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVidDown.ForeColor = System.Drawing.Color.Black
        Me.btnVidDown.Location = New System.Drawing.Point(571, 106)
        Me.btnVidDown.Name = "btnVidDown"
        Me.btnVidDown.Size = New System.Drawing.Size(25, 52)
        Me.btnVidDown.TabIndex = 38
        Me.btnVidDown.Text = "▼"
        Me.btnVidDown.UseVisualStyleBackColor = True
        '
        'btnVidUp
        '
        Me.btnVidUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVidUp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVidUp.ForeColor = System.Drawing.Color.Black
        Me.btnVidUp.Location = New System.Drawing.Point(571, 48)
        Me.btnVidUp.Name = "btnVidUp"
        Me.btnVidUp.Size = New System.Drawing.Size(25, 52)
        Me.btnVidUp.TabIndex = 37
        Me.btnVidUp.Text = "▲"
        Me.btnVidUp.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.Renderqueue)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(3, 209)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(525, 116)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(567, 135)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tboCustomName)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.TbsBitrate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.tboCompress)
        Me.TabPage1.Controls.Add(Me.cboQual)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboSpeed)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(559, 109)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Video/Audio settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Enter a name for this render job"
        '
        'tboCustomName
        '
        Me.tboCustomName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboCustomName.Location = New System.Drawing.Point(243, 76)
        Me.tboCustomName.Name = "tboCustomName"
        Me.tboCustomName.Size = New System.Drawing.Size(216, 20)
        Me.tboCustomName.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(283, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(301, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "kb/s"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(519, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "192"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(471, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "160"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(424, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "128"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(380, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "96"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(333, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "64"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(288, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 13)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Bitrate"
        '
        'TbsBitrate
        '
        Me.TbsBitrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbsBitrate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TbsBitrate.Location = New System.Drawing.Point(328, 31)
        Me.TbsBitrate.Maximum = 4
        Me.TbsBitrate.Name = "TbsBitrate"
        Me.TbsBitrate.Size = New System.Drawing.Size(216, 45)
        Me.TbsBitrate.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(296, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Compress audio"
        '
        'tboCompress
        '
        Me.tboCompress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboCompress.AutoSize = True
        Me.tboCompress.Checked = True
        Me.tboCompress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tboCompress.Location = New System.Drawing.Point(380, 11)
        Me.tboCompress.Name = "tboCompress"
        Me.tboCompress.Size = New System.Drawing.Size(15, 14)
        Me.tboCompress.TabIndex = 23
        Me.tboCompress.UseVisualStyleBackColor = True
        '
        'cboQual
        '
        Me.cboQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQual.FormattingEnabled = True
        Me.cboQual.Items.AddRange(New Object() {"Extremely low", "Low ", "Medium*", "High ", "Very high"})
        Me.cboQual.Location = New System.Drawing.Point(90, 6)
        Me.cboQual.Name = "cboQual"
        Me.cboQual.Size = New System.Drawing.Size(147, 21)
        Me.cboQual.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Compression"
        '
        'cboSpeed
        '
        Me.cboSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpeed.FormattingEnabled = True
        Me.cboSpeed.Items.AddRange(New Object() {"Very high", "High*", "Medium", "Low", "Very Low"})
        Me.cboSpeed.Location = New System.Drawing.Point(90, 42)
        Me.cboSpeed.Name = "cboSpeed"
        Me.cboSpeed.Size = New System.Drawing.Size(147, 21)
        Me.cboSpeed.TabIndex = 9
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.nudNumberOfVideos)
        Me.TabPage3.Controls.Add(Me.lblClose)
        Me.TabPage3.Controls.Add(Me.btnBrowseForClose)
        Me.TabPage3.Controls.Add(Me.cboEnableClose)
        Me.TabPage3.Controls.Add(Me.btnBrowseForIntro)
        Me.TabPage3.Controls.Add(Me.cboEnableIntro)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.lblIntro)
        Me.TabPage3.Controls.Add(Me.cboEnableMultirend)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(559, 109)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Multirend auto partitioning settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Run intro/closer through WARP before selecting it here!"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Number of videos to split on"
        '
        'nudNumberOfVideos
        '
        Me.nudNumberOfVideos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nudNumberOfVideos.Location = New System.Drawing.Point(46, 42)
        Me.nudNumberOfVideos.Name = "nudNumberOfVideos"
        Me.nudNumberOfVideos.Size = New System.Drawing.Size(39, 20)
        Me.nudNumberOfVideos.TabIndex = 21
        '
        'lblClose
        '
        Me.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblClose.AutoSize = True
        Me.lblClose.Location = New System.Drawing.Point(197, 85)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(93, 13)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "No video selected"
        '
        'btnBrowseForClose
        '
        Me.btnBrowseForClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowseForClose.Location = New System.Drawing.Point(85, 84)
        Me.btnBrowseForClose.Name = "btnBrowseForClose"
        Me.btnBrowseForClose.Size = New System.Drawing.Size(106, 19)
        Me.btnBrowseForClose.TabIndex = 5
        Me.btnBrowseForClose.Text = "Browse for video"
        Me.btnBrowseForClose.UseVisualStyleBackColor = True
        '
        'cboEnableClose
        '
        Me.cboEnableClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEnableClose.AutoSize = True
        Me.cboEnableClose.Location = New System.Drawing.Point(33, 85)
        Me.cboEnableClose.Name = "cboEnableClose"
        Me.cboEnableClose.Size = New System.Drawing.Size(55, 17)
        Me.cboEnableClose.TabIndex = 4
        Me.cboEnableClose.Text = "Closer"
        Me.cboEnableClose.UseVisualStyleBackColor = True
        '
        'btnBrowseForIntro
        '
        Me.btnBrowseForIntro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowseForIntro.Location = New System.Drawing.Point(85, 65)
        Me.btnBrowseForIntro.Name = "btnBrowseForIntro"
        Me.btnBrowseForIntro.Size = New System.Drawing.Size(106, 19)
        Me.btnBrowseForIntro.TabIndex = 2
        Me.btnBrowseForIntro.Text = "Browse for video"
        Me.btnBrowseForIntro.UseVisualStyleBackColor = True
        '
        'cboEnableIntro
        '
        Me.cboEnableIntro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEnableIntro.AutoSize = True
        Me.cboEnableIntro.Location = New System.Drawing.Point(33, 67)
        Me.cboEnableIntro.Name = "cboEnableIntro"
        Me.cboEnableIntro.Size = New System.Drawing.Size(47, 17)
        Me.cboEnableIntro.TabIndex = 1
        Me.cboEnableIntro.Text = "Intro"
        Me.cboEnableIntro.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(43, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(475, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Multirend allows you to render a large amount of content into parts ready for upl" & _
    "oad."
        '
        'lblIntro
        '
        Me.lblIntro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(197, 68)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(93, 13)
        Me.lblIntro.TabIndex = 3
        Me.lblIntro.Text = "No video selected"
        '
        'cboEnableMultirend
        '
        Me.cboEnableMultirend.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEnableMultirend.AutoSize = True
        Me.cboEnableMultirend.Location = New System.Drawing.Point(34, 19)
        Me.cboEnableMultirend.Name = "cboEnableMultirend"
        Me.cboEnableMultirend.Size = New System.Drawing.Size(105, 17)
        Me.cboEnableMultirend.TabIndex = 22
        Me.cboEnableMultirend.Text = "Enable Multirend"
        Me.cboEnableMultirend.UseVisualStyleBackColor = True
        '
        'Renderqueue
        '
        Me.Renderqueue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Renderqueue.Controls.Add(Me.CheckBox1)
        Me.Renderqueue.Controls.Add(Me.RichTextBox1)
        Me.Renderqueue.Controls.Add(Me.Label8)
        Me.Renderqueue.Controls.Add(Me.btnSetSave)
        Me.Renderqueue.Controls.Add(Me.lblSave)
        Me.Renderqueue.Controls.Add(Me.tboOnShutDown)
        Me.Renderqueue.Controls.Add(Me.tboOnEmptyQueue)
        Me.Renderqueue.Controls.Add(Me.tboOnFinishPart)
        Me.Renderqueue.Location = New System.Drawing.Point(4, 22)
        Me.Renderqueue.Name = "Renderqueue"
        Me.Renderqueue.Padding = New System.Windows.Forms.Padding(3)
        Me.Renderqueue.Size = New System.Drawing.Size(559, 109)
        Me.Renderqueue.TabIndex = 3
        Me.Renderqueue.Text = "Renderqueue settings"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(206, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Enable debug"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(304, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(252, 103)
        Me.RichTextBox1.TabIndex = 45
        Me.RichTextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Set save path"
        '
        'btnSetSave
        '
        Me.btnSetSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSetSave.Location = New System.Drawing.Point(102, 75)
        Me.btnSetSave.Name = "btnSetSave"
        Me.btnSetSave.Size = New System.Drawing.Size(106, 19)
        Me.btnSetSave.TabIndex = 11
        Me.btnSetSave.Text = "Browse for video"
        Me.btnSetSave.UseVisualStyleBackColor = True
        '
        'lblSave
        '
        Me.lblSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSave.AutoSize = True
        Me.lblSave.Location = New System.Drawing.Point(214, 78)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(75, 13)
        Me.lblSave.TabIndex = 12
        Me.lblSave.Text = "Select a folder"
        '
        'tboOnShutDown
        '
        Me.tboOnShutDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboOnShutDown.AutoSize = True
        Me.tboOnShutDown.Location = New System.Drawing.Point(58, 52)
        Me.tboOnShutDown.Name = "tboOnShutDown"
        Me.tboOnShutDown.Size = New System.Drawing.Size(142, 17)
        Me.tboOnShutDown.TabIndex = 10
        Me.tboOnShutDown.Text = "Shut down computer too"
        Me.tboOnShutDown.UseVisualStyleBackColor = True
        '
        'tboOnEmptyQueue
        '
        Me.tboOnEmptyQueue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboOnEmptyQueue.AutoSize = True
        Me.tboOnEmptyQueue.Location = New System.Drawing.Point(58, 35)
        Me.tboOnEmptyQueue.Name = "tboOnEmptyQueue"
        Me.tboOnEmptyQueue.Size = New System.Drawing.Size(145, 17)
        Me.tboOnEmptyQueue.TabIndex = 9
        Me.tboOnEmptyQueue.Text = "Sound when all complete"
        Me.tboOnEmptyQueue.UseVisualStyleBackColor = True
        '
        'tboOnFinishPart
        '
        Me.tboOnFinishPart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboOnFinishPart.AutoSize = True
        Me.tboOnFinishPart.Location = New System.Drawing.Point(58, 17)
        Me.tboOnFinishPart.Name = "tboOnFinishPart"
        Me.tboOnFinishPart.Size = New System.Drawing.Size(123, 17)
        Me.tboOnFinishPart.TabIndex = 8
        Me.tboOnFinishPart.Text = "Sound at end of part"
        Me.tboOnFinishPart.UseVisualStyleBackColor = True
        '
        'lvwRenderList
        '
        Me.lvwRenderList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwRenderList.BackColor = System.Drawing.Color.White
        Me.lvwRenderList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwRenderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader14, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.lvwRenderList.FullRowSelect = True
        Me.lvwRenderList.Location = New System.Drawing.Point(6, 371)
        Me.lvwRenderList.MultiSelect = False
        Me.lvwRenderList.Name = "lvwRenderList"
        Me.lvwRenderList.Size = New System.Drawing.Size(593, 238)
        Me.lvwRenderList.TabIndex = 41
        Me.lvwRenderList.UseCompatibleStateImageBehavior = False
        Me.lvwRenderList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.DisplayIndex = 1
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 299
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.DisplayIndex = 0
        Me.ColumnHeader12.Text = "Part"
        Me.ColumnHeader12.Width = 35
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.DisplayIndex = 6
        Me.ColumnHeader14.Text = "Info"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 2
        Me.ColumnHeader4.Text = "Duration"
        Me.ColumnHeader4.Width = 81
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 3
        Me.ColumnHeader5.Text = "Number of frames"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 4
        Me.ColumnHeader6.Text = "ETA"
        Me.ColumnHeader6.Width = 68
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 5
        Me.ColumnHeader7.Text = "%"
        Me.ColumnHeader7.Width = 51
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Quality"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Compression"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "compresslevel"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "IntroFpath"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "CloseFPath"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "NumOfParts"
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "FilesIncluded"
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Compress Audio Enabled"
        Me.ColumnHeader18.Width = 0
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "IntroEnabled"
        Me.ColumnHeader19.Width = 0
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "CloseEnabled"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "SavePath"
        Me.ColumnHeader21.Width = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Render jobs"
        '
        'btnMinimiseUI
        '
        Me.btnMinimiseUI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimiseUI.Location = New System.Drawing.Point(574, 610)
        Me.btnMinimiseUI.Name = "btnMinimiseUI"
        Me.btnMinimiseUI.Size = New System.Drawing.Size(25, 24)
        Me.btnMinimiseUI.TabIndex = 43
        Me.btnMinimiseUI.Text = "1"
        Me.btnMinimiseUI.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'btnStartRender
        '
        Me.btnStartRender.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartRender.Image = CType(resources.GetObject("btnStartRender.Image"), System.Drawing.Image)
        Me.btnStartRender.Location = New System.Drawing.Point(571, 227)
        Me.btnStartRender.Name = "btnStartRender"
        Me.btnStartRender.Size = New System.Drawing.Size(25, 116)
        Me.btnStartRender.TabIndex = 40
        Me.btnStartRender.UseVisualStyleBackColor = True
        '
        'BtnRemoveVideo
        '
        Me.BtnRemoveVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemoveVideo.Image = CType(resources.GetObject("BtnRemoveVideo.Image"), System.Drawing.Image)
        Me.BtnRemoveVideo.Location = New System.Drawing.Point(571, 168)
        Me.BtnRemoveVideo.Name = "BtnRemoveVideo"
        Me.BtnRemoveVideo.Size = New System.Drawing.Size(25, 41)
        Me.BtnRemoveVideo.TabIndex = 3
        Me.BtnRemoveVideo.UseVisualStyleBackColor = True
        '
        'BtnAddVideo
        '
        Me.BtnAddVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddVideo.Image = CType(resources.GetObject("BtnAddVideo.Image"), System.Drawing.Image)
        Me.BtnAddVideo.Location = New System.Drawing.Point(571, 2)
        Me.BtnAddVideo.Name = "BtnAddVideo"
        Me.BtnAddVideo.Size = New System.Drawing.Size(25, 39)
        Me.BtnAddVideo.TabIndex = 2
        Me.BtnAddVideo.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 623)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(593, 11)
        Me.ProgressBar1.TabIndex = 46
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(492, 344)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel jobs"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(7, 609)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(38, 13)
        Me.lblStatus.TabIndex = 48
        Me.lblStatus.Text = "Ready"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(434, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Warp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 633)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnMinimiseUI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvwRenderList)
        Me.Controls.Add(Me.btnStartRender)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnVidDown)
        Me.Controls.Add(Me.btnVidUp)
        Me.Controls.Add(Me.BtnRemoveVideo)
        Me.Controls.Add(Me.BtnAddVideo)
        Me.Controls.Add(Me.LvwVideoList)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Warp2"
        Me.Text = "Warp2 Build 7"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbsBitrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.nudNumberOfVideos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Renderqueue.ResumeLayout(False)
        Me.Renderqueue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LvwVideoList As System.Windows.Forms.ListView
    Friend WithEvents Videoname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Datecreated As System.Windows.Forms.ColumnHeader
    Friend WithEvents Filepath As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnAddVideo As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveVideo As System.Windows.Forms.Button
    Friend WithEvents btnVidDown As System.Windows.Forms.Button
    Friend WithEvents btnVidUp As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TbsBitrate As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tboCompress As System.Windows.Forms.CheckBox
    Friend WithEvents cboQual As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cboEnableMultirend As System.Windows.Forms.CheckBox
    Friend WithEvents nudNumberOfVideos As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForClose As System.Windows.Forms.Button
    Friend WithEvents cboEnableClose As System.Windows.Forms.CheckBox
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForIntro As System.Windows.Forms.Button
    Friend WithEvents cboEnableIntro As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnStartRender As System.Windows.Forms.Button
    Friend WithEvents lvwRenderList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMinimiseUI As System.Windows.Forms.Button
    Friend WithEvents Renderqueue As System.Windows.Forms.TabPage
    Friend WithEvents tboOnShutDown As System.Windows.Forms.CheckBox
    Friend WithEvents tboOnEmptyQueue As System.Windows.Forms.CheckBox
    Friend WithEvents tboOnFinishPart As System.Windows.Forms.CheckBox
    Friend WithEvents tboCustomName As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSetSave As System.Windows.Forms.Button
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
