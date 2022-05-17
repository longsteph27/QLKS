
namespace QLKS
{
    partial class frmDichVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            System.Windows.Forms.Label mADVLabel;
            System.Windows.Forms.Label tENDICHVULabel;
            System.Windows.Forms.Label gIALabel;
            System.Windows.Forms.Label mADVLabel1;
            System.Windows.Forms.Label mACTPTLabel;
            System.Windows.Forms.Label gHICHULabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLKS.DS();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTableAdapter = new QLKS.DSTableAdapters.DICHVUTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDICHVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTDICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDICHVUTableAdapter = new QLKS.DSTableAdapters.CTDICHVUTableAdapter();
            this.gcCTDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACTPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.mADVTextBox = new System.Windows.Forms.TextBox();
            this.tENDICHVUTextBox = new System.Windows.Forms.TextBox();
            this.gIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mADVTextBox1 = new System.Windows.Forms.TextBox();
            this.mACTPTTextBox = new System.Windows.Forms.TextBox();
            this.gHICHUTextBox = new System.Windows.Forms.TextBox();
            mADVLabel = new System.Windows.Forms.Label();
            tENDICHVULabel = new System.Windows.Forms.Label();
            gIALabel = new System.Windows.Forms.Label();
            mADVLabel1 = new System.Windows.Forms.Label();
            mACTPTLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIASpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1306, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 734);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1306, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 708);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1306, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 708);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lưu";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Hủy";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.DS;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = this.cTDICHVUTableAdapter;
            this.tableAdapterManager.CTDOIPHONGTableAdapter = null;
            this.tableAdapterManager.CTKHACHOTableAdapter = null;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = this.dICHVUTableAdapter;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.QUANLYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDichVu
            // 
            this.gcDichVu.DataSource = this.dICHVUBindingSource;
            this.gcDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDichVu.Location = new System.Drawing.Point(0, 26);
            this.gcDichVu.MainView = this.gridView1;
            this.gcDichVu.MenuManager = this.barManager1;
            this.gcDichVu.Name = "gcDichVu";
            this.gcDichVu.Size = new System.Drawing.Size(1306, 220);
            this.gcDichVu.TabIndex = 5;
            this.gcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADV,
            this.colTENDICHVU,
            this.colGIA});
            this.gridView1.GridControl = this.gcDichVu;
            this.gridView1.Name = "gridView1";
            // 
            // colMADV
            // 
            this.colMADV.FieldName = "MADV";
            this.colMADV.MinWidth = 23;
            this.colMADV.Name = "colMADV";
            this.colMADV.OptionsColumn.AllowEdit = false;
            this.colMADV.Visible = true;
            this.colMADV.VisibleIndex = 0;
            this.colMADV.Width = 87;
            // 
            // colTENDICHVU
            // 
            this.colTENDICHVU.FieldName = "TENDICHVU";
            this.colTENDICHVU.MinWidth = 23;
            this.colTENDICHVU.Name = "colTENDICHVU";
            this.colTENDICHVU.OptionsColumn.AllowEdit = false;
            this.colTENDICHVU.Visible = true;
            this.colTENDICHVU.VisibleIndex = 1;
            this.colTENDICHVU.Width = 87;
            // 
            // colGIA
            // 
            this.colGIA.FieldName = "GIA";
            this.colGIA.MinWidth = 23;
            this.colGIA.Name = "colGIA";
            this.colGIA.OptionsColumn.AllowEdit = false;
            this.colGIA.Visible = true;
            this.colGIA.VisibleIndex = 2;
            this.colGIA.Width = 87;
            // 
            // cTDICHVUBindingSource
            // 
            this.cTDICHVUBindingSource.DataMember = "CTDICHVU";
            this.cTDICHVUBindingSource.DataSource = this.DS;
            // 
            // cTDICHVUTableAdapter
            // 
            this.cTDICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDichVu
            // 
            this.gcCTDichVu.DataSource = this.cTDICHVUBindingSource;
            this.gcCTDichVu.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcCTDichVu.Location = new System.Drawing.Point(842, 246);
            this.gcCTDichVu.MainView = this.gridView2;
            this.gcCTDichVu.MenuManager = this.barManager1;
            this.gcCTDichVu.Name = "gcCTDichVu";
            this.gcCTDichVu.Size = new System.Drawing.Size(464, 488);
            this.gcCTDichVu.TabIndex = 6;
            this.gcCTDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADV1,
            this.colMACTPT,
            this.colGHICHU});
            this.gridView2.GridControl = this.gcCTDichVu;
            this.gridView2.Name = "gridView2";
            // 
            // colMADV1
            // 
            this.colMADV1.FieldName = "MADV";
            this.colMADV1.MinWidth = 23;
            this.colMADV1.Name = "colMADV1";
            this.colMADV1.OptionsColumn.AllowEdit = false;
            this.colMADV1.Visible = true;
            this.colMADV1.VisibleIndex = 0;
            this.colMADV1.Width = 87;
            // 
            // colMACTPT
            // 
            this.colMACTPT.FieldName = "MACTPT";
            this.colMACTPT.MinWidth = 23;
            this.colMACTPT.Name = "colMACTPT";
            this.colMACTPT.OptionsColumn.AllowEdit = false;
            this.colMACTPT.Visible = true;
            this.colMACTPT.VisibleIndex = 1;
            this.colMACTPT.Width = 87;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 23;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.AllowEdit = false;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 2;
            this.colGHICHU.Width = 87;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.gHICHUTextBox);
            this.panelInput.Controls.Add(mACTPTLabel);
            this.panelInput.Controls.Add(this.mACTPTTextBox);
            this.panelInput.Controls.Add(mADVLabel1);
            this.panelInput.Controls.Add(this.mADVTextBox1);
            this.panelInput.Controls.Add(gIALabel);
            this.panelInput.Controls.Add(this.gIASpinEdit);
            this.panelInput.Controls.Add(tENDICHVULabel);
            this.panelInput.Controls.Add(this.tENDICHVUTextBox);
            this.panelInput.Controls.Add(mADVLabel);
            this.panelInput.Controls.Add(this.mADVTextBox);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 246);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(842, 488);
            this.panelInput.TabIndex = 7;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // mADVLabel
            // 
            mADVLabel.AutoSize = true;
            mADVLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mADVLabel.Location = new System.Drawing.Point(78, 151);
            mADVLabel.Name = "mADVLabel";
            mADVLabel.Size = new System.Drawing.Size(49, 17);
            mADVLabel.TabIndex = 0;
            mADVLabel.Text = "MADV:";
            mADVLabel.Click += new System.EventHandler(this.mADVLabel_Click);
            // 
            // mADVTextBox
            // 
            this.mADVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mADVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICHVUBindingSource, "MADV", true));
            this.mADVTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mADVTextBox.Location = new System.Drawing.Point(174, 149);
            this.mADVTextBox.Name = "mADVTextBox";
            this.mADVTextBox.Size = new System.Drawing.Size(100, 24);
            this.mADVTextBox.TabIndex = 1;
            // 
            // tENDICHVULabel
            // 
            tENDICHVULabel.AutoSize = true;
            tENDICHVULabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENDICHVULabel.Location = new System.Drawing.Point(78, 198);
            tENDICHVULabel.Name = "tENDICHVULabel";
            tENDICHVULabel.Size = new System.Drawing.Size(87, 17);
            tENDICHVULabel.TabIndex = 2;
            tENDICHVULabel.Text = "TENDICHVU:";
            // 
            // tENDICHVUTextBox
            // 
            this.tENDICHVUTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tENDICHVUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dICHVUBindingSource, "TENDICHVU", true));
            this.tENDICHVUTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENDICHVUTextBox.Location = new System.Drawing.Point(174, 195);
            this.tENDICHVUTextBox.Name = "tENDICHVUTextBox";
            this.tENDICHVUTextBox.Size = new System.Drawing.Size(234, 24);
            this.tENDICHVUTextBox.TabIndex = 3;
            // 
            // gIALabel
            // 
            gIALabel.AutoSize = true;
            gIALabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gIALabel.Location = new System.Drawing.Point(78, 246);
            gIALabel.Name = "gIALabel";
            gIALabel.Size = new System.Drawing.Size(34, 17);
            gIALabel.TabIndex = 4;
            gIALabel.Text = "GIA:";
            // 
            // gIASpinEdit
            // 
            this.gIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dICHVUBindingSource, "GIA", true));
            this.gIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gIASpinEdit.Location = new System.Drawing.Point(174, 243);
            this.gIASpinEdit.MenuManager = this.barManager1;
            this.gIASpinEdit.Name = "gIASpinEdit";
            this.gIASpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gIASpinEdit.Properties.Appearance.Options.UseFont = true;
            this.gIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gIASpinEdit.Size = new System.Drawing.Size(117, 24);
            this.gIASpinEdit.TabIndex = 5;
            // 
            // mADVLabel1
            // 
            mADVLabel1.AutoSize = true;
            mADVLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mADVLabel1.Location = new System.Drawing.Point(534, 151);
            mADVLabel1.Name = "mADVLabel1";
            mADVLabel1.Size = new System.Drawing.Size(49, 17);
            mADVLabel1.TabIndex = 6;
            mADVLabel1.Text = "MADV:";
            // 
            // mADVTextBox1
            // 
            this.mADVTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mADVTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDICHVUBindingSource, "MADV", true));
            this.mADVTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mADVTextBox1.Location = new System.Drawing.Point(605, 149);
            this.mADVTextBox1.Name = "mADVTextBox1";
            this.mADVTextBox1.Size = new System.Drawing.Size(100, 24);
            this.mADVTextBox1.TabIndex = 7;
            // 
            // mACTPTLabel
            // 
            mACTPTLabel.AutoSize = true;
            mACTPTLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACTPTLabel.Location = new System.Drawing.Point(534, 198);
            mACTPTLabel.Name = "mACTPTLabel";
            mACTPTLabel.Size = new System.Drawing.Size(64, 17);
            mACTPTLabel.TabIndex = 8;
            mACTPTLabel.Text = "MACTPT:";
            // 
            // mACTPTTextBox
            // 
            this.mACTPTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mACTPTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDICHVUBindingSource, "MACTPT", true));
            this.mACTPTTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mACTPTTextBox.Location = new System.Drawing.Point(605, 195);
            this.mACTPTTextBox.Name = "mACTPTTextBox";
            this.mACTPTTextBox.Size = new System.Drawing.Size(100, 24);
            this.mACTPTTextBox.TabIndex = 9;
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gHICHULabel.Location = new System.Drawing.Point(534, 245);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(62, 17);
            gHICHULabel.TabIndex = 10;
            gHICHULabel.Text = "GHICHU:";
            // 
            // gHICHUTextBox
            // 
            this.gHICHUTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gHICHUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDICHVUBindingSource, "GHICHU", true));
            this.gHICHUTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gHICHUTextBox.Location = new System.Drawing.Point(605, 243);
            this.gHICHUTextBox.Multiline = true;
            this.gHICHUTextBox.Name = "gHICHUTextBox";
            this.gHICHUTextBox.Size = new System.Drawing.Size(187, 165);
            this.gHICHUTextBox.TabIndex = 11;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 734);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcCTDichVu);
            this.Controls.Add(this.gcDichVu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIASpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private DS DS;
        private DSTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDICHVU;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA;
        private DSTableAdapters.CTDICHVUTableAdapter cTDICHVUTableAdapter;
        private System.Windows.Forms.BindingSource cTDICHVUBindingSource;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.TextBox gHICHUTextBox;
        private System.Windows.Forms.TextBox mACTPTTextBox;
        private System.Windows.Forms.TextBox mADVTextBox1;
        private DevExpress.XtraEditors.SpinEdit gIASpinEdit;
        private System.Windows.Forms.TextBox tENDICHVUTextBox;
        private System.Windows.Forms.TextBox mADVTextBox;
        private DevExpress.XtraGrid.GridControl gcCTDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMADV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACTPT;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
    }
}