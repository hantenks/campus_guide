<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampusTour
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CampusTour))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.RichTextBox()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serp = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sac = New System.Windows.Forms.Label()
        Me.hostel = New System.Windows.Forms.Label()
        Me.acad = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.Label()
        Me.hospital = New System.Windows.Forms.Label()
        Me.guesthouse = New System.Windows.Forms.Label()
        Me.kv = New System.Windows.Forms.Label()
        Me.cc = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.audi = New System.Windows.Forms.Label()
        Me.guestlake = New System.Windows.Forms.Label()
        Me.mainGate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.description)
        Me.SplitContainer1.Panel1.Controls.Add(Me.image)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.serp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sac)
        Me.SplitContainer1.Panel2.Controls.Add(Me.hostel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.acad)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.hospital)
        Me.SplitContainer1.Panel2.Controls.Add(Me.guesthouse)
        Me.SplitContainer1.Panel2.Controls.Add(Me.kv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.admin)
        Me.SplitContainer1.Panel2.Controls.Add(Me.audi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.guestlake)
        Me.SplitContainer1.Panel2.Controls.Add(Me.mainGate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1223, 733)
        Me.SplitContainer1.SplitterDistance = 418
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Tan
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 32)
        Me.Label2.TabIndex = 4
        '
        'description
        '
        Me.description.BackColor = System.Drawing.Color.Tan
        Me.description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.description.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.ForeColor = System.Drawing.SystemColors.WindowText
        Me.description.Location = New System.Drawing.Point(42, 467)
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.description.Size = New System.Drawing.Size(309, 225)
        Me.description.TabIndex = 1
        Me.description.Text = " IIT Guwahati Campus Explorer" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'image
        '
        Me.image.Image = Global.campusmap.My.Resources.Resources.iitg_large
        Me.image.Location = New System.Drawing.Point(42, 94)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(300, 300)
        Me.image.TabIndex = 0
        Me.image.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Campus Explorer"
        '
        'serp
        '
        Me.serp.BackColor = System.Drawing.Color.Transparent
        Me.serp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.serp.Location = New System.Drawing.Point(379, 144)
        Me.serp.Name = "serp"
        Me.serp.Size = New System.Drawing.Size(33, 22)
        Me.serp.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.campusmap.My.Resources.Resources._1421199215_location_alt_512
        Me.PictureBox2.Location = New System.Drawing.Point(465, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.campusmap.My.Resources.Resources.treasure_map11
        Me.Button3.Location = New System.Drawing.Point(629, 517)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 100)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Start Tour"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sac
        '
        Me.sac.Location = New System.Drawing.Point(411, 291)
        Me.sac.Name = "sac"
        Me.sac.Size = New System.Drawing.Size(80, 35)
        Me.sac.TabIndex = 4
        '
        'hostel
        '
        Me.hostel.Location = New System.Drawing.Point(480, 401)
        Me.hostel.Name = "hostel"
        Me.hostel.Size = New System.Drawing.Size(74, 57)
        Me.hostel.TabIndex = 3
        '
        'acad
        '
        Me.acad.Location = New System.Drawing.Point(300, 433)
        Me.acad.Name = "acad"
        Me.acad.Size = New System.Drawing.Size(73, 112)
        Me.acad.TabIndex = 2
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.Transparent
        Me.tc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tc.Location = New System.Drawing.Point(611, 272)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(32, 54)
        Me.tc.TabIndex = 0
        '
        'hospital
        '
        Me.hospital.BackColor = System.Drawing.Color.Transparent
        Me.hospital.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hospital.Location = New System.Drawing.Point(463, 168)
        Me.hospital.Name = "hospital"
        Me.hospital.Size = New System.Drawing.Size(29, 24)
        Me.hospital.TabIndex = 0
        '
        'guesthouse
        '
        Me.guesthouse.BackColor = System.Drawing.Color.Transparent
        Me.guesthouse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.guesthouse.Location = New System.Drawing.Point(411, 187)
        Me.guesthouse.Name = "guesthouse"
        Me.guesthouse.Size = New System.Drawing.Size(29, 24)
        Me.guesthouse.TabIndex = 0
        '
        'kv
        '
        Me.kv.BackColor = System.Drawing.Color.Transparent
        Me.kv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kv.Location = New System.Drawing.Point(438, 467)
        Me.kv.Name = "kv"
        Me.kv.Size = New System.Drawing.Size(43, 78)
        Me.kv.TabIndex = 0
        '
        'cc
        '
        Me.cc.BackColor = System.Drawing.Color.Transparent
        Me.cc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cc.Location = New System.Drawing.Point(368, 401)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(24, 19)
        Me.cc.TabIndex = 0
        '
        'admin
        '
        Me.admin.BackColor = System.Drawing.Color.Transparent
        Me.admin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.admin.Location = New System.Drawing.Point(327, 365)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(24, 19)
        Me.admin.TabIndex = 0
        '
        'audi
        '
        Me.audi.BackColor = System.Drawing.Color.Transparent
        Me.audi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.audi.Location = New System.Drawing.Point(379, 342)
        Me.audi.Name = "audi"
        Me.audi.Size = New System.Drawing.Size(13, 24)
        Me.audi.TabIndex = 0
        '
        'guestlake
        '
        Me.guestlake.BackColor = System.Drawing.Color.Transparent
        Me.guestlake.ForeColor = System.Drawing.SystemColors.ControlText
        Me.guestlake.Location = New System.Drawing.Point(453, 231)
        Me.guestlake.Name = "guestlake"
        Me.guestlake.Size = New System.Drawing.Size(52, 40)
        Me.guestlake.TabIndex = 0
        '
        'mainGate
        '
        Me.mainGate.BackColor = System.Drawing.Color.Transparent
        Me.mainGate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainGate.Location = New System.Drawing.Point(211, 178)
        Me.mainGate.Name = "mainGate"
        Me.mainGate.Size = New System.Drawing.Size(36, 24)
        Me.mainGate.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.campusmap.My.Resources.Resources.campMap
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(826, 733)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 711)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1223, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'CampusTour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.campusmap.My.Resources.Resources.treasure_map12
        Me.ClientSize = New System.Drawing.Size(1223, 733)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CampusTour"
        Me.Text = "Campus Explorer: Campus Tour"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents guestlake As System.Windows.Forms.Label
    Friend WithEvents guesthouse As System.Windows.Forms.Label
    Friend WithEvents tc As System.Windows.Forms.Label
    Friend WithEvents hospital As System.Windows.Forms.Label
    Friend WithEvents kv As System.Windows.Forms.Label
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents audi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cc As System.Windows.Forms.Label
    Friend WithEvents mainGate As System.Windows.Forms.Label
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents description As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents acad As System.Windows.Forms.Label
    Friend WithEvents sac As System.Windows.Forms.Label
    Friend WithEvents hostel As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents serp As System.Windows.Forms.Label

End Class
