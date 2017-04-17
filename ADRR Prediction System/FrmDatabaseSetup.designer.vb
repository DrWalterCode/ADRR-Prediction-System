<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabaseSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatabaseSetup))
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtport = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbodatabase = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.txthost = New DevExpress.XtraEditors.TextEdit()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox11.SuspendLayout
        CType(Me.txtport.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbodatabase.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtpassword.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtuser.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txthost.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.txtport)
        Me.groupBox11.Controls.Add(Me.Label3)
        Me.groupBox11.Controls.Add(Me.SimpleButton1)
        Me.groupBox11.Controls.Add(Me.CheckEdit1)
        Me.groupBox11.Controls.Add(Me.cbodatabase)
        Me.groupBox11.Controls.Add(Me.txtpassword)
        Me.groupBox11.Controls.Add(Me.Label1)
        Me.groupBox11.Controls.Add(Me.Label2)
        Me.groupBox11.Controls.Add(Me.txtuser)
        Me.groupBox11.Controls.Add(Me.txthost)
        Me.groupBox11.Controls.Add(Me.label38)
        Me.groupBox11.Controls.Add(Me.label37)
        Me.groupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.groupBox11.Location = New System.Drawing.Point(190, 12)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(263, 201)
        Me.groupBox11.TabIndex = 15
        Me.groupBox11.TabStop = false
        Me.groupBox11.Text = "Connection Details"
        '
        'txtport
        '
        Me.txtport.EditValue = "3306"
        Me.txtport.Location = New System.Drawing.Point(106, 15)
        Me.txtport.Name = "txtport"
        Me.txtport.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtport.Properties.Appearance.Options.UseBackColor = true
        Me.txtport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtport.Properties.Mask.BeepOnError = true
        Me.txtport.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtport.Properties.Mask.ShowPlaceHolders = false
        Me.txtport.Size = New System.Drawing.Size(151, 20)
        Me.txtport.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Port"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(170, 163)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 29)
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.TabStop = false
        Me.SimpleButton1.Text = "&SAVE"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(10, 168)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Don't Show on Start_Up"
        Me.CheckEdit1.Size = New System.Drawing.Size(134, 19)
        Me.CheckEdit1.TabIndex = 24
        '
        'cbodatabase
        '
        Me.cbodatabase.Location = New System.Drawing.Point(107, 123)
        Me.cbodatabase.Name = "cbodatabase"
        Me.cbodatabase.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbodatabase.Properties.Appearance.Options.UseBackColor = true
        Me.cbodatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbodatabase.Properties.Sorted = true
        Me.cbodatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbodatabase.Size = New System.Drawing.Size(151, 20)
        Me.cbodatabase.TabIndex = 23
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(107, 97)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtpassword.Properties.Appearance.Options.UseBackColor = true
        Me.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtpassword.Properties.Mask.BeepOnError = true
        Me.txtpassword.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtpassword.Properties.Mask.ShowPlaceHolders = false
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(151, 20)
        Me.txtpassword.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(107, 69)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtuser.Properties.Appearance.Options.UseBackColor = true
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtuser.Properties.Mask.BeepOnError = true
        Me.txtuser.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtuser.Properties.Mask.ShowPlaceHolders = false
        Me.txtuser.Size = New System.Drawing.Size(151, 20)
        Me.txtuser.TabIndex = 1
        '
        'txthost
        '
        Me.txthost.Location = New System.Drawing.Point(106, 42)
        Me.txthost.Name = "txthost"
        Me.txthost.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txthost.Properties.Appearance.Options.UseBackColor = true
        Me.txthost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txthost.Properties.Mask.BeepOnError = true
        Me.txthost.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txthost.Properties.Mask.ShowPlaceHolders = false
        Me.txthost.Size = New System.Drawing.Size(151, 20)
        Me.txthost.TabIndex = 0
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label38.Location = New System.Drawing.Point(7, 76)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(29, 13)
        Me.label38.TabIndex = 17
        Me.label38.Text = "User"
        '
        'label37
        '
        Me.label37.AutoSize = true
        Me.label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label37.Location = New System.Drawing.Point(7, 49)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(29, 13)
        Me.label37.TabIndex = 15
        Me.label37.Text = "Host"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ADRR_Prediction_System.My.Resources.Resources.ZimMOH
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'FrmDatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 216)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupBox11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmDatabaseSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Set-Up"
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        CType(Me.txtport.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbodatabase.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtpassword.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtuser.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txthost.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents groupBox11 As GroupBox
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthost As DevExpress.XtraEditors.TextEdit
    Private WithEvents label38 As Label
    Private WithEvents label37 As Label
    Friend WithEvents cbodatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtport As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label3 As Label
End Class
