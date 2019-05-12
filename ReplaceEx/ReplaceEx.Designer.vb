<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReplaceEx
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pSetting = New DevComponents.DotNetBar.ExpandablePanel()
        Me.btnSrcPath = New DevComponents.DotNetBar.ButtonX()
        Me.txtFileExt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSrcPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPattern = New DevComponents.DotNetBar.LabelX()
        Me.lblSrcPath = New DevComponents.DotNetBar.LabelX()
        Me.pScriptContainer = New DevComponents.DotNetBar.PanelEx()
        Me.dgvScript = New Control.CusDataGridView()
        Me.pCmd = New DevComponents.DotNetBar.PanelEx()
        Me.btnReplace = New DevComponents.DotNetBar.ButtonX()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BalloonTip1 = New DevComponents.DotNetBar.BalloonTip()
        Me.ctmScript = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pSetting.SuspendLayout()
        Me.pScriptContainer.SuspendLayout()
        CType(Me.dgvScript, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCmd.SuspendLayout()
        Me.ctmScript.SuspendLayout()
        Me.SuspendLayout()
        '
        'pSetting
        '
        Me.pSetting.CanvasColor = System.Drawing.SystemColors.Control
        Me.pSetting.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pSetting.Controls.Add(Me.btnSrcPath)
        Me.pSetting.Controls.Add(Me.txtFileExt)
        Me.pSetting.Controls.Add(Me.txtSrcPath)
        Me.pSetting.Controls.Add(Me.lblPattern)
        Me.pSetting.Controls.Add(Me.lblSrcPath)
        Me.pSetting.DisabledBackColor = System.Drawing.Color.Empty
        Me.pSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSetting.HideControlsWhenCollapsed = True
        Me.pSetting.Location = New System.Drawing.Point(0, 0)
        Me.pSetting.Name = "pSetting"
        Me.pSetting.Size = New System.Drawing.Size(784, 85)
        Me.pSetting.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pSetting.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pSetting.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pSetting.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pSetting.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.pSetting.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.pSetting.Style.GradientAngle = 90
        Me.pSetting.TabIndex = 5
        Me.pSetting.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.pSetting.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pSetting.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pSetting.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.pSetting.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pSetting.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pSetting.TitleStyle.GradientAngle = 90
        Me.pSetting.TitleText = "Setting"
        '
        'btnSrcPath
        '
        Me.btnSrcPath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSrcPath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSrcPath.Location = New System.Drawing.Point(477, 32)
        Me.btnSrcPath.Name = "btnSrcPath"
        Me.btnSrcPath.Size = New System.Drawing.Size(53, 20)
        Me.btnSrcPath.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnSrcPath.TabIndex = 6
        Me.btnSrcPath.Text = "Browse"
        '
        'txtFileExt
        '
        Me.BalloonTip1.SetBalloonCaption(Me.txtFileExt, Nothing)
        Me.BalloonTip1.SetBalloonText(Me.txtFileExt, "The search string to match against the names of files. ex: *.vb OR *.vbproj")
        '
        '
        '
        Me.txtFileExt.Border.Class = "TextBoxBorder"
        Me.txtFileExt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFileExt.Location = New System.Drawing.Point(80, 57)
        Me.txtFileExt.Name = "txtFileExt"
        Me.txtFileExt.PreventEnterBeep = True
        Me.txtFileExt.Size = New System.Drawing.Size(391, 20)
        Me.txtFileExt.TabIndex = 5
        Me.txtFileExt.Text = "*.vb"
        Me.txtFileExt.WatermarkText = "*.vb, *.sql, *.cs"
        '
        'txtSrcPath
        '
        '
        '
        '
        Me.txtSrcPath.Border.Class = "TextBoxBorder"
        Me.txtSrcPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSrcPath.Location = New System.Drawing.Point(80, 32)
        Me.txtSrcPath.Name = "txtSrcPath"
        Me.txtSrcPath.PreventEnterBeep = True
        Me.txtSrcPath.Size = New System.Drawing.Size(391, 20)
        Me.txtSrcPath.TabIndex = 5
        '
        'lblPattern
        '
        Me.lblPattern.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblPattern.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPattern.Location = New System.Drawing.Point(8, 54)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(66, 23)
        Me.lblPattern.TabIndex = 4
        Me.lblPattern.Text = "Patterns"
        '
        'lblSrcPath
        '
        Me.lblSrcPath.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblSrcPath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSrcPath.Location = New System.Drawing.Point(8, 29)
        Me.lblSrcPath.Name = "lblSrcPath"
        Me.lblSrcPath.Size = New System.Drawing.Size(66, 23)
        Me.lblSrcPath.TabIndex = 4
        Me.lblSrcPath.Text = "Source Path"
        '
        'pScriptContainer
        '
        Me.pScriptContainer.CanvasColor = System.Drawing.SystemColors.Control
        Me.pScriptContainer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pScriptContainer.Controls.Add(Me.dgvScript)
        Me.pScriptContainer.DisabledBackColor = System.Drawing.Color.Empty
        Me.pScriptContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pScriptContainer.Location = New System.Drawing.Point(0, 85)
        Me.pScriptContainer.Name = "pScriptContainer"
        Me.pScriptContainer.Size = New System.Drawing.Size(784, 434)
        Me.pScriptContainer.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pScriptContainer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pScriptContainer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pScriptContainer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pScriptContainer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pScriptContainer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pScriptContainer.Style.GradientAngle = 90
        Me.pScriptContainer.TabIndex = 9
        '
        'dgvScript
        '
        Me.dgvScript.AllowUserToAddRows = False
        Me.dgvScript.AllowUserToDeleteRows = False
        Me.dgvScript.AllowUserToResizeRows = False
        Me.dgvScript.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvScript.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvScript.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScript.ContextMenuStrip = Me.ctmScript
        Me.dgvScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvScript.Location = New System.Drawing.Point(0, 0)
        Me.dgvScript.MaxCols = 0
        Me.dgvScript.MaxRows = 0
        Me.dgvScript.Name = "dgvScript"
        Me.dgvScript.ReadOnly = True
        Me.dgvScript.RowHeight = 21
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgvScript.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvScript.Size = New System.Drawing.Size(784, 434)
        Me.dgvScript.TabIndex = 3
        Me.dgvScript.VisibleCols = 0
        '
        'pCmd
        '
        Me.pCmd.CanvasColor = System.Drawing.SystemColors.Control
        Me.pCmd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pCmd.Controls.Add(Me.btnReplace)
        Me.pCmd.DisabledBackColor = System.Drawing.Color.Empty
        Me.pCmd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pCmd.Location = New System.Drawing.Point(0, 519)
        Me.pCmd.Name = "pCmd"
        Me.pCmd.Size = New System.Drawing.Size(784, 42)
        Me.pCmd.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pCmd.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pCmd.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pCmd.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pCmd.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pCmd.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pCmd.Style.GradientAngle = 90
        Me.pCmd.TabIndex = 13
        '
        'btnReplace
        '
        Me.btnReplace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReplace.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReplace.Location = New System.Drawing.Point(719, 10)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(53, 20)
        Me.btnReplace.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        '
        'ctmScript
        '
        Me.ctmScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ctmScript.Name = "ctmScript"
        Me.ctmScript.Size = New System.Drawing.Size(181, 92)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReloadToolStripMenuItem.Text = "Load"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ReplaceEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pScriptContainer)
        Me.Controls.Add(Me.pCmd)
        Me.Controls.Add(Me.pSetting)
        Me.Name = "ReplaceEx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReplaceEx"
        Me.pSetting.ResumeLayout(False)
        Me.pScriptContainer.ResumeLayout(False)
        CType(Me.dgvScript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCmd.ResumeLayout(False)
        Me.ctmScript.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pSetting As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents pScriptContainer As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pCmd As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblSrcPath As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSrcPath As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSrcPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnReplace As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtFileExt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPattern As DevComponents.DotNetBar.LabelX
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BalloonTip1 As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents dgvScript As Control.CusDataGridView
    Friend WithEvents ctmScript As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
