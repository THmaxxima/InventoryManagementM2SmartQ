﻿Namespace PopupForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_IVM_Popup_Material_Info
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IVM_Popup_Material_Info))
            Me.GridMatInfo = New DevExpress.XtraGrid.GridControl()
            Me.GridViewMatInfo = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.GridMatInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridViewMatInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridMatInfo
            '
            Me.GridMatInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.GridMatInfo.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.GridMatInfo.EmbeddedNavigator.Buttons.Edit.Visible = False
            Me.GridMatInfo.Location = New System.Drawing.Point(0, 0)
            Me.GridMatInfo.MainView = Me.GridViewMatInfo
            Me.GridMatInfo.Name = "GridMatInfo"
            Me.GridMatInfo.Size = New System.Drawing.Size(797, 301)
            Me.GridMatInfo.TabIndex = 0
            Me.GridMatInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMatInfo})
            '
            'GridViewMatInfo
            '
            Me.GridViewMatInfo.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aqua
            Me.GridViewMatInfo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.GridViewMatInfo.Appearance.FocusedRow.BorderColor = System.Drawing.Color.White
            Me.GridViewMatInfo.Appearance.FocusedRow.Options.UseBackColor = True
            Me.GridViewMatInfo.Appearance.FocusedRow.Options.UseBorderColor = True
            Me.GridViewMatInfo.Appearance.FooterPanel.BackColor = System.Drawing.SystemColors.Highlight
            Me.GridViewMatInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Aqua
            Me.GridViewMatInfo.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridViewMatInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Yellow
            Me.GridViewMatInfo.Appearance.FooterPanel.Options.UseBackColor = True
            Me.GridViewMatInfo.Appearance.FooterPanel.Options.UseBorderColor = True
            Me.GridViewMatInfo.Appearance.FooterPanel.Options.UseFont = True
            Me.GridViewMatInfo.Appearance.FooterPanel.Options.UseForeColor = True
            Me.GridViewMatInfo.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.Highlight
            Me.GridViewMatInfo.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridViewMatInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Yellow
            Me.GridViewMatInfo.Appearance.HeaderPanel.Options.UseBackColor = True
            Me.GridViewMatInfo.Appearance.HeaderPanel.Options.UseFont = True
            Me.GridViewMatInfo.Appearance.HeaderPanel.Options.UseForeColor = True
            Me.GridViewMatInfo.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.GridViewMatInfo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridViewMatInfo.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridViewMatInfo.Appearance.Row.ForeColor = System.Drawing.Color.Blue
            Me.GridViewMatInfo.Appearance.Row.Options.UseFont = True
            Me.GridViewMatInfo.Appearance.Row.Options.UseForeColor = True
            Me.GridViewMatInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.GridViewMatInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn3, Me.GridColumn4})
            Me.GridViewMatInfo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.GridViewMatInfo.GridControl = Me.GridMatInfo
            Me.GridViewMatInfo.Name = "GridViewMatInfo"
            Me.GridViewMatInfo.OptionsBehavior.ReadOnly = True
            Me.GridViewMatInfo.OptionsCustomization.AllowFilter = False
            Me.GridViewMatInfo.OptionsCustomization.AllowQuickHideColumns = False
            Me.GridViewMatInfo.OptionsCustomization.AllowSort = False
            Me.GridViewMatInfo.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic
            Me.GridViewMatInfo.OptionsDetail.ShowDetailTabs = False
            Me.GridViewMatInfo.OptionsFind.AllowFindPanel = False
            Me.GridViewMatInfo.OptionsFind.ShowClearButton = False
            Me.GridViewMatInfo.OptionsFind.ShowFindButton = False
            Me.GridViewMatInfo.OptionsLayout.Columns.AddNewColumns = False
            Me.GridViewMatInfo.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridViewMatInfo.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.GridViewMatInfo.OptionsSelection.UseIndicatorForSelection = False
            Me.GridViewMatInfo.OptionsView.RowAutoHeight = True
            Me.GridViewMatInfo.OptionsView.ShowDetailButtons = False
            Me.GridViewMatInfo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.GridViewMatInfo.OptionsView.ShowFooter = True
            Me.GridViewMatInfo.OptionsView.ShowGroupExpandCollapseButtons = False
            Me.GridViewMatInfo.OptionsView.ShowGroupPanel = False
            Me.GridViewMatInfo.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.GridViewMatInfo.OptionsView.ShowIndicator = False
            Me.GridViewMatInfo.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.GridViewMatInfo.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.GridViewMatInfo.PaintStyleName = "Web"
            '
            'GridColumn1
            '
            Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.GridColumn1.Caption = "พื้นที่"
            Me.GridColumn1.FieldName = "StorageName"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.OptionsColumn.AllowEdit = False
            Me.GridColumn1.OptionsColumn.AllowFocus = False
            Me.GridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.GridColumn1.OptionsColumn.AllowIncrementalSearch = False
            Me.GridColumn1.OptionsColumn.ShowInExpressionEditor = False
            Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "StorageName", "รวม")})
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            Me.GridColumn1.Width = 177
            '
            'GridColumn2
            '
            Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.GridColumn2.Caption = "วัตถุดิบ"
            Me.GridColumn2.FieldName = "MaterialName"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaterialName", "{0} รายการ")})
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            Me.GridColumn2.Width = 283
            '
            'GridColumn5
            '
            Me.GridColumn5.Caption = "อายุ"
            Me.GridColumn5.FieldName = "AgeDay"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 2
            Me.GridColumn5.Width = 100
            '
            'GridColumn3
            '
            Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn3.Caption = "น้ำหนัก"
            Me.GridColumn3.DisplayFormat.FormatString = "0.000"
            Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn3.FieldName = "WeightADT"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WeightADT", "{0:0.000}")})
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 3
            Me.GridColumn3.Width = 180
            '
            'GridColumn4
            '
            Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
            Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn4.Caption = "Bale"
            Me.GridColumn4.FieldName = "Quantity"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0}")})
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 4
            Me.GridColumn4.Width = 140
            '
            'btnClose
            '
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(665, 312)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(121, 52)
            Me.btnClose.TabIndex = 36
            Me.btnClose.Text = "Close"
            '
            'frm_IVM_Popup_Material_Info
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(797, 371)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.GridMatInfo)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_IVM_Popup_Material_Info"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "รายละเอียด : วัตถุดิบ ในพื้นที่ "
            CType(Me.GridMatInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridViewMatInfo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents GridMatInfo As DevExpress.XtraGrid.GridControl
        Private WithEvents GridViewMatInfo As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    End Class

End Namespace