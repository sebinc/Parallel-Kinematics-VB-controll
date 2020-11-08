<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form


    

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.picEdge = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunFindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixedPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicCapture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.Text_C = New System.Windows.Forms.TextBox()
        Me.Text_Z = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Y = New System.Windows.Forms.TextBox()
        Me.Text_X = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.found = New System.Windows.Forms.Label()
        Me.time_status = New System.Windows.Forms.Label()
        Me.camera_view = New System.Windows.Forms.Label()
        Me.vision_data = New System.Windows.Forms.Label()
        Me.task_status = New System.Windows.Forms.Label()
        Me.hw_status = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.col_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_radius = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_error = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mode1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mode2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mode3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer_capture = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picEdge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEdge
        '
        Me.picEdge.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picEdge.Location = New System.Drawing.Point(43, 24)
        Me.picEdge.Name = "picEdge"
        Me.picEdge.Size = New System.Drawing.Size(640, 480)
        Me.picEdge.TabIndex = 1
        Me.picEdge.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TaskToolStripMenuItem
        '
        Me.TaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CameraToolStripMenuItem, Me.EventToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem"
        Me.TaskToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.TaskToolStripMenuItem.Text = "&Task"
        Me.TaskToolStripMenuItem.ToolTipText = "Sets the functionality of the hardware"
        '
        'CameraToolStripMenuItem
        '
        Me.CameraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.CameraToolStripMenuItem.Name = "CameraToolStripMenuItem"
        Me.CameraToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CameraToolStripMenuItem.Text = "&Camera"
        Me.CameraToolStripMenuItem.ToolTipText = "startd or stops camera"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StartToolStripMenuItem.Text = "Sta&rt"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StopToolStripMenuItem.Text = "St&op"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunFindToolStripMenuItem, Me.FixedPositionToolStripMenuItem, Me.ManualToolStripMenuItem})
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EventToolStripMenuItem.Text = "Event"
        '
        'RunFindToolStripMenuItem
        '
        Me.RunFindToolStripMenuItem.Name = "RunFindToolStripMenuItem"
        Me.RunFindToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.RunFindToolStripMenuItem.Text = "Run_Find"
        '
        'FixedPositionToolStripMenuItem
        '
        Me.FixedPositionToolStripMenuItem.Name = "FixedPositionToolStripMenuItem"
        Me.FixedPositionToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.FixedPositionToolStripMenuItem.Text = "Fixed_Position"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'PicCapture
        '
        Me.PicCapture.Location = New System.Drawing.Point(458, 157)
        Me.PicCapture.Name = "PicCapture"
        Me.PicCapture.Size = New System.Drawing.Size(1, 1)
        Me.PicCapture.TabIndex = 12
        Me.PicCapture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.label11)
        Me.Panel1.Controls.Add(Me.Text_C)
        Me.Panel1.Controls.Add(Me.Text_Z)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Text_Y)
        Me.Panel1.Controls.Add(Me.Text_X)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.found)
        Me.Panel1.Controls.Add(Me.time_status)
        Me.Panel1.Controls.Add(Me.camera_view)
        Me.Panel1.Controls.Add(Me.vision_data)
        Me.Panel1.Controls.Add(Me.task_status)
        Me.Panel1.Controls.Add(Me.hw_status)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(722, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 480)
        Me.Panel1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(102, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Z"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(18, 325)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(17, 15)
        Me.label11.TabIndex = 20
        Me.label11.Text = "C"
        '
        'Text_C
        '
        Me.Text_C.Location = New System.Drawing.Point(41, 322)
        Me.Text_C.Name = "Text_C"
        Me.Text_C.Size = New System.Drawing.Size(46, 20)
        Me.Text_C.TabIndex = 19
        '
        'Text_Z
        '
        Me.Text_Z.Location = New System.Drawing.Point(121, 387)
        Me.Text_Z.Name = "Text_Z"
        Me.Text_Z.Size = New System.Drawing.Size(47, 20)
        Me.Text_Z.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 22)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Calibration"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(260, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "X"
        '
        'Text_Y
        '
        Me.Text_Y.Location = New System.Drawing.Point(192, 315)
        Me.Text_Y.Name = "Text_Y"
        Me.Text_Y.Size = New System.Drawing.Size(44, 20)
        Me.Text_Y.TabIndex = 14
        '
        'Text_X
        '
        Me.Text_X.Location = New System.Drawing.Point(121, 274)
        Me.Text_X.Name = "Text_X"
        Me.Text_X.Size = New System.Drawing.Size(47, 20)
        Me.Text_X.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(102, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "USB Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'found
        '
        Me.found.AutoSize = True
        Me.found.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.found.Location = New System.Drawing.Point(142, 200)
        Me.found.Name = "found"
        Me.found.Size = New System.Drawing.Size(15, 16)
        Me.found.TabIndex = 11
        Me.found.Text = "0"
        '
        'time_status
        '
        Me.time_status.AutoSize = True
        Me.time_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_status.Location = New System.Drawing.Point(145, 165)
        Me.time_status.Name = "time_status"
        Me.time_status.Size = New System.Drawing.Size(56, 16)
        Me.time_status.TabIndex = 10
        Me.time_status.Text = "                "
        '
        'camera_view
        '
        Me.camera_view.AutoSize = True
        Me.camera_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.camera_view.Location = New System.Drawing.Point(145, 126)
        Me.camera_view.Name = "camera_view"
        Me.camera_view.Size = New System.Drawing.Size(23, 16)
        Me.camera_view.TabIndex = 9
        Me.camera_view.Text = "All"
        '
        'vision_data
        '
        Me.vision_data.AutoSize = True
        Me.vision_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vision_data.Location = New System.Drawing.Point(145, 92)
        Me.vision_data.Name = "vision_data"
        Me.vision_data.Size = New System.Drawing.Size(86, 16)
        Me.vision_data.TabIndex = 8
        Me.vision_data.Text = "BATTERY44"
        '
        'task_status
        '
        Me.task_status.AutoSize = True
        Me.task_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task_status.Location = New System.Drawing.Point(145, 62)
        Me.task_status.Name = "task_status"
        Me.task_status.Size = New System.Drawing.Size(65, 16)
        Me.task_status.TabIndex = 7
        Me.task_status.Text = "Run_Find"
        '
        'hw_status
        '
        Me.hw_status.AutoSize = True
        Me.hw_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hw_status.Location = New System.Drawing.Point(145, 30)
        Me.hw_status.Name = "hw_status"
        Me.hw_status.Size = New System.Drawing.Size(91, 16)
        Me.hw_status.TabIndex = 6
        Me.hw_status.Text = "Disconnected"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hardware Status :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Found                       :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Time                         :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Camera View        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Vision Data           :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Event                       :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_no, Me.col_x, Me.col_y, Me.col_radius, Me.col_model, Me.col_error, Me.mode1, Me.mode2, Me.mode3})
        Me.DataGridView1.Location = New System.Drawing.Point(43, 514)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1119, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'col_no
        '
        Me.col_no.HeaderText = "#"
        Me.col_no.Name = "col_no"
        Me.col_no.Width = 150
        '
        'col_x
        '
        Me.col_x.HeaderText = "X"
        Me.col_x.Name = "col_x"
        Me.col_x.Width = 150
        '
        'col_y
        '
        Me.col_y.HeaderText = "Y"
        Me.col_y.Name = "col_y"
        Me.col_y.Width = 150
        '
        'col_radius
        '
        Me.col_radius.HeaderText = "Radius"
        Me.col_radius.Name = "col_radius"
        Me.col_radius.Width = 150
        '
        'col_model
        '
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_error
        '
        Me.col_error.HeaderText = "Error"
        Me.col_error.Name = "col_error"
        Me.col_error.Width = 150
        '
        'mode1
        '
        Me.mode1.HeaderText = "mode1"
        Me.mode1.Name = "mode1"
        '
        'mode2
        '
        Me.mode2.HeaderText = "mode2"
        Me.mode2.Name = "mode2"
        '
        'mode3
        '
        Me.mode3.HeaderText = "mode3"
        Me.mode3.Name = "mode3"
        '
        'Timer_capture
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1184, 674)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PicCapture)
        Me.Controls.Add(Me.picEdge)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "main"
        Me.Text = "Parallel Kinematics"
        CType(Me.picEdge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picEdge As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CameraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents PicCapture As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents found As System.Windows.Forms.Label
    Friend WithEvents time_status As System.Windows.Forms.Label
    Friend WithEvents camera_view As System.Windows.Forms.Label
    Friend WithEvents vision_data As System.Windows.Forms.Label
    Friend WithEvents task_status As System.Windows.Forms.Label
    Friend WithEvents hw_status As System.Windows.Forms.Label
    Friend WithEvents EventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunFindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixedPositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents col_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_x As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_y As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_radius As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_error As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mode1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mode2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mode3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer_capture As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Y As System.Windows.Forms.TextBox
    Friend WithEvents Text_X As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents Text_C As System.Windows.Forms.TextBox
    Friend WithEvents Text_Z As System.Windows.Forms.TextBox

End Class
