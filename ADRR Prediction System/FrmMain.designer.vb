<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.timeIn = New System.Windows.Forms.TextBox()
        Me.dateIn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem8 = New DevExpress.XtraEditors.TileItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.DigitalBackgroundLayerComponent1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DigitalGauge1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TileControl1
        '
        Me.TileControl1.AllowDragTilesBetweenGroups = false
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Firebrick
        Me.TileControl1.AppearanceItem.Normal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = true
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = true
        Me.TileControl1.AppearanceItem.Normal.Options.UseForeColor = true
        Me.TileControl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.ItemSize = 100
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 11
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(280, 632)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Items.Add(Me.TileItem2)
        Me.TileGroup2.Items.Add(Me.TileItem7)
        Me.TileGroup2.Items.Add(Me.TileItem5)
        Me.TileGroup2.Items.Add(Me.TileItem8)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1686, 24)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel5.Location = New System.Drawing.Point(791, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 833)
        Me.Panel5.TabIndex = 316
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Location = New System.Drawing.Point(603, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(682, 85)
        Me.Panel4.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(17, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 7)
        Me.Label19.TabIndex = 304
        Me.Label19.Text = "Label19"
        '
        'GaugeControl1
        '
        Me.GaugeControl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(67, 29)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(148, 46)
        Me.GaugeControl1.TabIndex = 306
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(361.7375!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style22
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblUsername.Location = New System.Drawing.Point(102, 123)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.ReadOnly = true
        Me.lblUsername.Size = New System.Drawing.Size(103, 18)
        Me.lblUsername.TabIndex = 299
        Me.lblUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label6.Location = New System.Drawing.Point(12, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 12)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "TIME LOGGED IN:"
        '
        'timeIn
        '
        Me.timeIn.BackColor = System.Drawing.Color.White
        Me.timeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.timeIn.Location = New System.Drawing.Point(102, 81)
        Me.timeIn.Name = "timeIn"
        Me.timeIn.ReadOnly = true
        Me.timeIn.Size = New System.Drawing.Size(103, 18)
        Me.timeIn.TabIndex = 294
        Me.timeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dateIn
        '
        Me.dateIn.BackColor = System.Drawing.Color.White
        Me.dateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dateIn.Location = New System.Drawing.Point(102, 102)
        Me.dateIn.Name = "dateIn"
        Me.dateIn.ReadOnly = true
        Me.dateIn.Size = New System.Drawing.Size(103, 18)
        Me.dateIn.TabIndex = 295
        Me.dateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 12)
        Me.Label5.TabIndex = 298
        Me.Label5.Text = "DATE LOGGED IN :"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label7.Location = New System.Drawing.Point(12, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 296
        Me.Label7.Text = "USERNAME :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.TileControl1)
        Me.Panel1.Location = New System.Drawing.Point(523, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 632)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Panel3.Location = New System.Drawing.Point(534, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 833)
        Me.Panel3.TabIndex = 316
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(102,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Panel6.Location = New System.Drawing.Point(788, 22)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 833)
        Me.Panel6.TabIndex = 316
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = false
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 673)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 68)
        Me.StatusStrip1.TabIndex = 317
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 63)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(523, 63)
        Me.ToolStripStatusLabel4.Text = ".                                                                                "& _ 
    "                                                                                "& _ 
    "           "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(229, 63)
        Me.ToolStripStatusLabel1.Text = "Antiretroviral Drug Resistance Rate Prediction System"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(158, 63)
        Me.ToolStripStatusLabel2.Text = "Copyright © 2017.  All rights reserved"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(377, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 318
        Me.PictureBox3.TabStop = false
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E9EFF3")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0F89B8")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 136, 34)
        Me.DigitalGauge1.DigitCount = 7
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge1.Text = "00.000"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleButton1.Appearance.Options.UseBackColor = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1290, 25)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 29)
        Me.SimpleButton1.TabIndex = 308
        Me.SimpleButton1.TabStop = false
        '
        'TileItem1
        '
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"),System.Drawing.Image)
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.Text = "NURSES"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem1.Elements.Add(TileItemElement1)
        Me.TileItem1.Id = 2
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'TileItem2
        '
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"),System.Drawing.Image)
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.Text = "DOCTORS"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem2.Elements.Add(TileItemElement2)
        Me.TileItem2.Id = 3
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem7
        '
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"),System.Drawing.Image)
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement3.Text = "SYSTEM REPORTS"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem7.Elements.Add(TileItemElement3)
        Me.TileItem7.Id = 9
        Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem7.Name = "TileItem7"
        '
        'TileItem5
        '
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"),System.Drawing.Image)
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement4.Text = "KNOWLEDGE BASE"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem5.Elements.Add(TileItemElement4)
        Me.TileItem5.Id = 7
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem5.Name = "TileItem5"
        '
        'TileItem8
        '
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"),System.Drawing.Image)
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement5.Text = "ADMINISTRATION"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileItem8.Elements.Add(TileItemElement5)
        Me.TileItem8.Id = 10
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem8.Name = "TileItem8"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 227)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(450, 313)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(776, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(574, 425)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 314
        Me.PictureBox1.TabStop = false
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.timeIn)
        Me.Controls.Add(Me.dateIn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANTIRETROVIRAL DRUG RESISTANCE RATE PREDICTION SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        CType(Me.DigitalBackgroundLayerComponent1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DigitalGauge1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents timeIn As TextBox
    Friend WithEvents dateIn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label19 As Label
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents TileItem7 As DevExpress.XtraEditors.TileItem
    Friend WithEvents lblUsername As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents PictureBox3 As PictureBox
End Class
