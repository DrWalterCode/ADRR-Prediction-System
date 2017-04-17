<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim IndicatorState1 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState2 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState3 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState4 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.StateIndicatorGauge1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
        Me.StateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NavigationPane1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NavigationPane1.SuspendLayout
        CType(Me.NavigationFrame1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NavigationFrame1.SuspendLayout
        CType(Me.StateIndicatorGauge1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StateIndicatorComponent1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(274, 29)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'NavigationPane1
        '
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Location = New System.Drawing.Point(270, 111)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(300, 150)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage2
        Me.NavigationPane1.Size = New System.Drawing.Size(300, 150)
        Me.NavigationPane1.TabIndex = 1
        Me.NavigationPane1.Text = "NavigationPane1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "NavigationPage1"
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(57, 0)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "NavigationPage2"
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(185, 90)
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage3)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage4)
        Me.NavigationFrame1.Location = New System.Drawing.Point(39, 87)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage3, Me.NavigationPage4})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage4
        Me.NavigationFrame1.Size = New System.Drawing.Size(300, 150)
        Me.NavigationFrame1.TabIndex = 2
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "NavigationPage3"
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(300, 150)
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "NavigationPage4"
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(300, 150)
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.StateIndicatorGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(39, 12)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(260, 260)
        Me.GaugeControl1.TabIndex = 3
        '
        'StateIndicatorGauge1
        '
        Me.StateIndicatorGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
        Me.StateIndicatorGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() {Me.StateIndicatorComponent1})
        Me.StateIndicatorGauge1.Name = "StateIndicatorGauge1"
        '
        'StateIndicatorComponent1
        '
        Me.StateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124!, 124!)
        Me.StateIndicatorComponent1.Name = "stateIndicatorComponent1"
        Me.StateIndicatorComponent1.Size = New System.Drawing.SizeF(200!, 200!)
        Me.StateIndicatorComponent1.StateIndex = 3
        IndicatorState1.Name = "State1"
        IndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1
        IndicatorState2.Name = "State2"
        IndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2
        IndicatorState3.Name = "State3"
        IndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3
        IndicatorState4.Name = "State4"
        IndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4
        Me.StateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {IndicatorState1, IndicatorState2, IndicatorState3, IndicatorState4})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NavigationPane1,System.ComponentModel.ISupportInitialize).EndInit
        Me.NavigationPane1.ResumeLayout(false)
        CType(Me.NavigationFrame1,System.ComponentModel.ISupportInitialize).EndInit
        Me.NavigationFrame1.ResumeLayout(false)
        CType(Me.StateIndicatorGauge1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StateIndicatorComponent1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents StateIndicatorGauge1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
    Private WithEvents StateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
    Friend WithEvents Button1 As Button
End Class
