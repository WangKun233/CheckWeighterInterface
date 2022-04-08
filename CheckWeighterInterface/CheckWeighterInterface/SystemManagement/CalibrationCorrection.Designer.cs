﻿
namespace CheckWeighterInterface.SystemManagement
{
    partial class CalibrationCorrection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.tileViewColumn_NO = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_sensorValue = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_calibrationWeight = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.toggleSwitch_changeCalibrationMode = new DevExpress.XtraEditors.ToggleSwitch();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.simpleButton_changeSensorValue = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_doCalibration = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl_left = new DevExpress.XtraEditors.PanelControl();
            this.labelControl_calibrationMode1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_changeCalibrationWeight = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_confirmCountSection = new DevExpress.XtraEditors.SimpleButton();
            this.spinEdit_countSection = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl_calibrationMode2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_countSection = new DevExpress.XtraEditors.LabelControl();
            this.panelControl_right = new DevExpress.XtraEditors.PanelControl();
            this.labelControl_NO = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_calibrationDataList = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.labelControl_calibrationWeight = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_sensorValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_weightList = new DevExpress.XtraEditors.LabelControl();
            this.chartControl_calibrationGradient = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_changeCalibrationMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_left)).BeginInit();
            this.panelControl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_countSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_right)).BeginInit();
            this.panelControl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_calibrationDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_calibrationGradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_NO
            // 
            this.tileViewColumn_NO.Caption = "序号";
            this.tileViewColumn_NO.FieldName = "NO";
            this.tileViewColumn_NO.Name = "tileViewColumn_NO";
            this.tileViewColumn_NO.Visible = true;
            this.tileViewColumn_NO.VisibleIndex = 0;
            // 
            // tileViewColumn_sensorValue
            // 
            this.tileViewColumn_sensorValue.Caption = "传感器值";
            this.tileViewColumn_sensorValue.FieldName = "sensorValue";
            this.tileViewColumn_sensorValue.Name = "tileViewColumn_sensorValue";
            this.tileViewColumn_sensorValue.Visible = true;
            this.tileViewColumn_sensorValue.VisibleIndex = 1;
            // 
            // tileViewColumn_calibrationWeight
            // 
            this.tileViewColumn_calibrationWeight.Caption = "标定重量";
            this.tileViewColumn_calibrationWeight.FieldName = "calibrationWeight";
            this.tileViewColumn_calibrationWeight.Name = "tileViewColumn_calibrationWeight";
            this.tileViewColumn_calibrationWeight.Visible = true;
            this.tileViewColumn_calibrationWeight.VisibleIndex = 2;
            // 
            // toggleSwitch_changeCalibrationMode
            // 
            this.toggleSwitch_changeCalibrationMode.Location = new System.Drawing.Point(5, 454);
            this.toggleSwitch_changeCalibrationMode.Name = "toggleSwitch_changeCalibrationMode";
            this.toggleSwitch_changeCalibrationMode.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggleSwitch_changeCalibrationMode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.toggleSwitch_changeCalibrationMode.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_changeCalibrationMode.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch_changeCalibrationMode.Properties.AutoHeight = false;
            this.toggleSwitch_changeCalibrationMode.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleSwitch_changeCalibrationMode.Properties.LookAndFeel.SkinName = "Seven Classic";
            this.toggleSwitch_changeCalibrationMode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.toggleSwitch_changeCalibrationMode.Properties.OffText = "单段标定";
            this.toggleSwitch_changeCalibrationMode.Properties.OnText = "多段标定";
            this.toggleSwitch_changeCalibrationMode.Size = new System.Drawing.Size(287, 79);
            this.toggleSwitch_changeCalibrationMode.TabIndex = 59;
            this.toggleSwitch_changeCalibrationMode.Toggled += new System.EventHandler(this.toggleSwitch_changeCalibrationMode_Toggled);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // simpleButton_changeSensorValue
            // 
            this.simpleButton_changeSensorValue.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton_changeSensorValue.Appearance.Options.UseFont = true;
            this.simpleButton_changeSensorValue.AppearancePressed.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton_changeSensorValue.AppearancePressed.Options.UseFont = true;
            this.simpleButton_changeSensorValue.Location = new System.Drawing.Point(5, 202);
            this.simpleButton_changeSensorValue.LookAndFeel.SkinName = "Seven Classic";
            this.simpleButton_changeSensorValue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_changeSensorValue.Name = "simpleButton_changeSensorValue";
            this.simpleButton_changeSensorValue.Size = new System.Drawing.Size(288, 72);
            this.simpleButton_changeSensorValue.TabIndex = 64;
            this.simpleButton_changeSensorValue.Text = "修改传感器值";
            this.simpleButton_changeSensorValue.Click += new System.EventHandler(this.simpleButton_changeSensorValue_Click);
            // 
            // simpleButton_doCalibration
            // 
            this.simpleButton_doCalibration.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton_doCalibration.Appearance.Options.UseFont = true;
            this.simpleButton_doCalibration.AppearancePressed.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton_doCalibration.AppearancePressed.Options.UseFont = true;
            this.simpleButton_doCalibration.Location = new System.Drawing.Point(5, 368);
            this.simpleButton_doCalibration.LookAndFeel.SkinName = "Seven Classic";
            this.simpleButton_doCalibration.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_doCalibration.Name = "simpleButton_doCalibration";
            this.simpleButton_doCalibration.Size = new System.Drawing.Size(288, 71);
            this.simpleButton_doCalibration.TabIndex = 65;
            this.simpleButton_doCalibration.Text = "标定";
            this.simpleButton_doCalibration.Click += new System.EventHandler(this.simpleButton_doCalibration_Click);
            // 
            // panelControl_left
            // 
            this.panelControl_left.Controls.Add(this.labelControl_calibrationMode1);
            this.panelControl_left.Controls.Add(this.simpleButton_changeCalibrationWeight);
            this.panelControl_left.Controls.Add(this.simpleButton_confirmCountSection);
            this.panelControl_left.Controls.Add(this.spinEdit_countSection);
            this.panelControl_left.Controls.Add(this.labelControl_calibrationMode2);
            this.panelControl_left.Controls.Add(this.labelControl_countSection);
            this.panelControl_left.Controls.Add(this.simpleButton_doCalibration);
            this.panelControl_left.Controls.Add(this.simpleButton_changeSensorValue);
            this.panelControl_left.Controls.Add(this.toggleSwitch_changeCalibrationMode);
            this.panelControl_left.Location = new System.Drawing.Point(3, 3);
            this.panelControl_left.Name = "panelControl_left";
            this.panelControl_left.Size = new System.Drawing.Size(298, 611);
            this.panelControl_left.TabIndex = 67;
            // 
            // labelControl_calibrationMode1
            // 
            this.labelControl_calibrationMode1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl_calibrationMode1.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl_calibrationMode1.Appearance.Options.UseBackColor = true;
            this.labelControl_calibrationMode1.Appearance.Options.UseFont = true;
            this.labelControl_calibrationMode1.Appearance.Options.UseTextOptions = true;
            this.labelControl_calibrationMode1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_calibrationMode1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_calibrationMode1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_calibrationMode1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl_calibrationMode1.Location = new System.Drawing.Point(16, 5);
            this.labelControl_calibrationMode1.Name = "labelControl_calibrationMode1";
            this.labelControl_calibrationMode1.Size = new System.Drawing.Size(115, 49);
            this.labelControl_calibrationMode1.TabIndex = 72;
            this.labelControl_calibrationMode1.Text = "标定模式：";
            // 
            // simpleButton_changeCalibrationWeight
            // 
            this.simpleButton_changeCalibrationWeight.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton_changeCalibrationWeight.Appearance.Options.UseFont = true;
            this.simpleButton_changeCalibrationWeight.AppearancePressed.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton_changeCalibrationWeight.AppearancePressed.Options.UseFont = true;
            this.simpleButton_changeCalibrationWeight.Location = new System.Drawing.Point(5, 280);
            this.simpleButton_changeCalibrationWeight.LookAndFeel.SkinName = "Seven Classic";
            this.simpleButton_changeCalibrationWeight.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_changeCalibrationWeight.Name = "simpleButton_changeCalibrationWeight";
            this.simpleButton_changeCalibrationWeight.Size = new System.Drawing.Size(288, 72);
            this.simpleButton_changeCalibrationWeight.TabIndex = 71;
            this.simpleButton_changeCalibrationWeight.Text = "修改标定重量";
            this.simpleButton_changeCalibrationWeight.Click += new System.EventHandler(this.simpleButton_changeCalibrationWeight_Click);
            // 
            // simpleButton_confirmCountSection
            // 
            this.simpleButton_confirmCountSection.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton_confirmCountSection.Appearance.Options.UseFont = true;
            this.simpleButton_confirmCountSection.AppearancePressed.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.simpleButton_confirmCountSection.AppearancePressed.Options.UseFont = true;
            this.simpleButton_confirmCountSection.Enabled = false;
            this.simpleButton_confirmCountSection.Location = new System.Drawing.Point(5, 124);
            this.simpleButton_confirmCountSection.LookAndFeel.SkinName = "Seven Classic";
            this.simpleButton_confirmCountSection.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton_confirmCountSection.Name = "simpleButton_confirmCountSection";
            this.simpleButton_confirmCountSection.Size = new System.Drawing.Size(288, 72);
            this.simpleButton_confirmCountSection.TabIndex = 70;
            this.simpleButton_confirmCountSection.Text = "确认修改段数";
            this.simpleButton_confirmCountSection.Click += new System.EventHandler(this.simpleButton_confirmCountSection_Click);
            // 
            // spinEdit_countSection
            // 
            this.spinEdit_countSection.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_countSection.Enabled = false;
            this.spinEdit_countSection.Location = new System.Drawing.Point(137, 60);
            this.spinEdit_countSection.Name = "spinEdit_countSection";
            this.spinEdit_countSection.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.spinEdit_countSection.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_countSection.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit_countSection.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.spinEdit_countSection.Properties.AutoHeight = false;
            this.spinEdit_countSection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.spinEdit_countSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_countSection.Properties.IsFloatValue = false;
            this.spinEdit_countSection.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.spinEdit_countSection.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.spinEdit_countSection.Properties.Mask.EditMask = "T";
            this.spinEdit_countSection.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.spinEdit_countSection.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_countSection.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_countSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinEdit_countSection.Size = new System.Drawing.Size(155, 49);
            this.spinEdit_countSection.TabIndex = 69;
            this.spinEdit_countSection.ValueChanged += new System.EventHandler(this.spinEdit_countCalibrationSection_ValueChanged);
            // 
            // labelControl_calibrationMode2
            // 
            this.labelControl_calibrationMode2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl_calibrationMode2.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl_calibrationMode2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(152)))), ((int)(((byte)(83)))));
            this.labelControl_calibrationMode2.Appearance.Options.UseBackColor = true;
            this.labelControl_calibrationMode2.Appearance.Options.UseFont = true;
            this.labelControl_calibrationMode2.Appearance.Options.UseForeColor = true;
            this.labelControl_calibrationMode2.Appearance.Options.UseTextOptions = true;
            this.labelControl_calibrationMode2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_calibrationMode2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_calibrationMode2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_calibrationMode2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl_calibrationMode2.Location = new System.Drawing.Point(137, 5);
            this.labelControl_calibrationMode2.Name = "labelControl_calibrationMode2";
            this.labelControl_calibrationMode2.Size = new System.Drawing.Size(155, 49);
            this.labelControl_calibrationMode2.TabIndex = 68;
            this.labelControl_calibrationMode2.Text = "单段标定";
            // 
            // labelControl_countSection
            // 
            this.labelControl_countSection.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl_countSection.Appearance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl_countSection.Appearance.Options.UseBackColor = true;
            this.labelControl_countSection.Appearance.Options.UseFont = true;
            this.labelControl_countSection.Appearance.Options.UseTextOptions = true;
            this.labelControl_countSection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_countSection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_countSection.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_countSection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl_countSection.Location = new System.Drawing.Point(16, 60);
            this.labelControl_countSection.Name = "labelControl_countSection";
            this.labelControl_countSection.Size = new System.Drawing.Size(115, 49);
            this.labelControl_countSection.TabIndex = 67;
            this.labelControl_countSection.Text = "标定段数：";
            // 
            // panelControl_right
            // 
            this.panelControl_right.Controls.Add(this.chartControl_calibrationGradient);
            this.panelControl_right.Controls.Add(this.labelControl_NO);
            this.panelControl_right.Controls.Add(this.gridControl_calibrationDataList);
            this.panelControl_right.Controls.Add(this.labelControl_calibrationWeight);
            this.panelControl_right.Controls.Add(this.labelControl_sensorValue);
            this.panelControl_right.Controls.Add(this.labelControl_weightList);
            this.panelControl_right.Location = new System.Drawing.Point(307, 3);
            this.panelControl_right.Name = "panelControl_right";
            this.panelControl_right.Size = new System.Drawing.Size(714, 611);
            this.panelControl_right.TabIndex = 68;
            // 
            // labelControl_NO
            // 
            this.labelControl_NO.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl_NO.Appearance.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl_NO.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_NO.Appearance.Options.UseBackColor = true;
            this.labelControl_NO.Appearance.Options.UseFont = true;
            this.labelControl_NO.Appearance.Options.UseForeColor = true;
            this.labelControl_NO.Appearance.Options.UseTextOptions = true;
            this.labelControl_NO.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_NO.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_NO.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_NO.Location = new System.Drawing.Point(3, 53);
            this.labelControl_NO.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl_NO.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl_NO.Name = "labelControl_NO";
            this.labelControl_NO.Size = new System.Drawing.Size(157, 30);
            this.labelControl_NO.TabIndex = 71;
            this.labelControl_NO.Text = "序号";
            // 
            // gridControl_calibrationDataList
            // 
            this.gridControl_calibrationDataList.Location = new System.Drawing.Point(3, 83);
            this.gridControl_calibrationDataList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl_calibrationDataList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_calibrationDataList.MainView = this.tileView1;
            this.gridControl_calibrationDataList.Name = "gridControl_calibrationDataList";
            this.gridControl_calibrationDataList.Size = new System.Drawing.Size(708, 234);
            this.gridControl_calibrationDataList.TabIndex = 70;
            this.gridControl_calibrationDataList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            this.gridControl_calibrationDataList.Click += new System.EventHandler(this.gridControl_calibrationDataList_Click);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.ItemFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileView1.Appearance.ItemFocused.BorderColor = System.Drawing.Color.White;
            this.tileView1.Appearance.ItemFocused.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tileView1.Appearance.ItemFocused.ForeColor = System.Drawing.Color.White;
            this.tileView1.Appearance.ItemFocused.Options.UseBackColor = true;
            this.tileView1.Appearance.ItemFocused.Options.UseBorderColor = true;
            this.tileView1.Appearance.ItemFocused.Options.UseFont = true;
            this.tileView1.Appearance.ItemFocused.Options.UseForeColor = true;
            this.tileView1.Appearance.ItemNormal.BackColor = System.Drawing.Color.Gray;
            this.tileView1.Appearance.ItemNormal.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tileView1.Appearance.ItemNormal.Options.UseBackColor = true;
            this.tileView1.Appearance.ItemNormal.Options.UseFont = true;
            this.tileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_NO,
            this.tileViewColumn_sensorValue,
            this.tileViewColumn_calibrationWeight});
            this.tileView1.GridControl = this.gridControl_calibrationDataList;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(708, 40);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            tableColumnDefinition1.Length.Value = 150D;
            tableColumnDefinition2.Length.Value = 2D;
            tableColumnDefinition3.Length.Value = 277D;
            tableColumnDefinition4.Length.Value = 2D;
            tableColumnDefinition5.Length.Value = 278D;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            this.tileView1.TileColumns.Add(tableColumnDefinition5);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Column = this.tileViewColumn_NO;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "tileViewColumn_NO";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.tileViewColumn_sensorValue;
            tileViewItemElement2.ColumnIndex = 2;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "tileViewColumn_sensorValue";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.tileViewColumn_calibrationWeight;
            tileViewItemElement3.ColumnIndex = 4;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.Text = "tileViewColumn_calibrationWeight";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Appearance.Normal.BackColor = System.Drawing.Color.White;
            tileViewItemElement4.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.StretchVertical = true;
            tileViewItemElement4.Text = "tileElement_splitLine1";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Width = 1;
            tileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.White;
            tileViewItemElement5.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement5.ColumnIndex = 3;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.StretchVertical = true;
            tileViewItemElement5.Text = "tileElement_splitLine2";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Width = 1;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            // 
            // labelControl_calibrationWeight
            // 
            this.labelControl_calibrationWeight.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl_calibrationWeight.Appearance.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl_calibrationWeight.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_calibrationWeight.Appearance.Options.UseBackColor = true;
            this.labelControl_calibrationWeight.Appearance.Options.UseFont = true;
            this.labelControl_calibrationWeight.Appearance.Options.UseForeColor = true;
            this.labelControl_calibrationWeight.Appearance.Options.UseTextOptions = true;
            this.labelControl_calibrationWeight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_calibrationWeight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_calibrationWeight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_calibrationWeight.Location = new System.Drawing.Point(429, 53);
            this.labelControl_calibrationWeight.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl_calibrationWeight.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl_calibrationWeight.Name = "labelControl_calibrationWeight";
            this.labelControl_calibrationWeight.Size = new System.Drawing.Size(282, 30);
            this.labelControl_calibrationWeight.TabIndex = 69;
            this.labelControl_calibrationWeight.Text = "标定重量(kg)";
            // 
            // labelControl_sensorValue
            // 
            this.labelControl_sensorValue.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl_sensorValue.Appearance.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl_sensorValue.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_sensorValue.Appearance.Options.UseBackColor = true;
            this.labelControl_sensorValue.Appearance.Options.UseFont = true;
            this.labelControl_sensorValue.Appearance.Options.UseForeColor = true;
            this.labelControl_sensorValue.Appearance.Options.UseTextOptions = true;
            this.labelControl_sensorValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_sensorValue.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_sensorValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_sensorValue.Location = new System.Drawing.Point(161, 53);
            this.labelControl_sensorValue.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl_sensorValue.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl_sensorValue.Name = "labelControl_sensorValue";
            this.labelControl_sensorValue.Size = new System.Drawing.Size(267, 30);
            this.labelControl_sensorValue.TabIndex = 68;
            this.labelControl_sensorValue.Text = "传感器值";
            // 
            // labelControl_weightList
            // 
            this.labelControl_weightList.Appearance.BackColor = System.Drawing.Color.Gray;
            this.labelControl_weightList.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl_weightList.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_weightList.Appearance.Options.UseBackColor = true;
            this.labelControl_weightList.Appearance.Options.UseFont = true;
            this.labelControl_weightList.Appearance.Options.UseForeColor = true;
            this.labelControl_weightList.Appearance.Options.UseTextOptions = true;
            this.labelControl_weightList.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_weightList.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_weightList.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_weightList.Location = new System.Drawing.Point(3, 3);
            this.labelControl_weightList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.labelControl_weightList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl_weightList.Name = "labelControl_weightList";
            this.labelControl_weightList.Size = new System.Drawing.Size(708, 50);
            this.labelControl_weightList.TabIndex = 67;
            this.labelControl_weightList.Text = "标定数据列表";
            // 
            // chartControl_calibrationGradient
            // 
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Text = "称重数量";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0.1D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0.1D;
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            xyDiagram1.AxisY.MinorCount = 3;
            xyDiagram1.AxisY.Title.Text = "当前重量 KG";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisY.WholeRange.StartSideMargin = 0D;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chartControl_calibrationGradient.Diagram = xyDiagram1;
            this.chartControl_calibrationGradient.Legend.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl_calibrationGradient.Legend.Name = "Default Legend";
            this.chartControl_calibrationGradient.Location = new System.Drawing.Point(3, 325);
            this.chartControl_calibrationGradient.Name = "chartControl_calibrationGradient";
            series1.Name = "标定点";
            lineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            lineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            lineSeriesView1.LineMarkerOptions.Size = 5;
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.View = lineSeriesView1;
            this.chartControl_calibrationGradient.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl_calibrationGradient.Size = new System.Drawing.Size(708, 283);
            this.chartControl_calibrationGradient.TabIndex = 72;
            chartTitle1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "标定点示意图";
            this.chartControl_calibrationGradient.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // CalibrationCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl_right);
            this.Controls.Add(this.panelControl_left);
            this.Name = "CalibrationCorrection";
            this.Size = new System.Drawing.Size(1024, 617);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_changeCalibrationMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_left)).EndInit();
            this.panelControl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_countSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_right)).EndInit();
            this.panelControl_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_calibrationDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_calibrationGradient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_changeCalibrationMode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_changeSensorValue;
        private DevExpress.XtraEditors.SimpleButton simpleButton_doCalibration;
        private DevExpress.XtraEditors.PanelControl panelControl_left;
        private DevExpress.XtraEditors.PanelControl panelControl_right;
        private DevExpress.XtraEditors.LabelControl labelControl_weightList;
        private DevExpress.XtraEditors.LabelControl labelControl_calibrationWeight;
        private DevExpress.XtraEditors.LabelControl labelControl_sensorValue;
        private DevExpress.XtraEditors.LabelControl labelControl_countSection;
        private DevExpress.XtraEditors.LabelControl labelControl_calibrationMode2;
        private DevExpress.XtraEditors.SpinEdit spinEdit_countSection;
        private DevExpress.XtraEditors.SimpleButton simpleButton_confirmCountSection;
        private DevExpress.XtraEditors.SimpleButton simpleButton_changeCalibrationWeight;
        private DevExpress.XtraGrid.GridControl gridControl_calibrationDataList;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_NO;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_sensorValue;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_calibrationWeight;
        private DevExpress.XtraEditors.LabelControl labelControl_NO;
        private DevExpress.XtraEditors.LabelControl labelControl_calibrationMode1;
        private DevExpress.XtraCharts.ChartControl chartControl_calibrationGradient;
    }
}
