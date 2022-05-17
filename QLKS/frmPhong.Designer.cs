
namespace QLKS
{
    partial class frmPhong
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
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label sOPHONGLabel;
            System.Windows.Forms.Label sOTANGLabel;
            System.Windows.Forms.Label mAHPLabel;
            System.Windows.Forms.Label tRANGTHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLKS.DS();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.bdsCTPhieuThue = new System.Windows.Forms.BindingSource(this.components);
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbMaHP = new System.Windows.Forms.ComboBox();
            this.txtSoTang = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cTPHIEUTHUETableAdapter = new QLKS.DSTableAdapters.CTPHIEUTHUETableAdapter();
            this.colMAPT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHUTHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGPHUTHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACTPT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new QLKS.DSTableAdapters.PHONGTableAdapter();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHP = new DevExpress.XtraGrid.Columns.GridColumn();
            mAPHONGLabel = new System.Windows.Forms.Label();
            sOPHONGLabel = new System.Windows.Forms.Label();
            sOTANGLabel = new System.Windows.Forms.Label();
            mAHPLabel = new System.Windows.Forms.Label();
            tRANGTHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Font = new System.Drawing.Font("Tahoma", 7.714285F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPHONGLabel.Location = new System.Drawing.Point(85, 80);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(68, 14);
            mAPHONGLabel.TabIndex = 0;
            mAPHONGLabel.Text = "MAPHONG:";
            // 
            // sOPHONGLabel
            // 
            sOPHONGLabel.AutoSize = true;
            sOPHONGLabel.Font = new System.Drawing.Font("Tahoma", 7.714285F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOPHONGLabel.Location = new System.Drawing.Point(443, 80);
            sOPHONGLabel.Name = "sOPHONGLabel";
            sOPHONGLabel.Size = new System.Drawing.Size(67, 14);
            sOPHONGLabel.TabIndex = 2;
            sOPHONGLabel.Text = "SOPHONG:";
            // 
            // sOTANGLabel
            // 
            sOTANGLabel.AutoSize = true;
            sOTANGLabel.Font = new System.Drawing.Font("Tahoma", 7.714285F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTANGLabel.Location = new System.Drawing.Point(847, 80);
            sOTANGLabel.Name = "sOTANGLabel";
            sOTANGLabel.Size = new System.Drawing.Size(59, 14);
            sOTANGLabel.TabIndex = 4;
            sOTANGLabel.Text = "SOTANG:";
            // 
            // mAHPLabel
            // 
            mAHPLabel.AutoSize = true;
            mAHPLabel.Location = new System.Drawing.Point(481, 211);
            mAHPLabel.Name = "mAHPLabel";
            mAHPLabel.Size = new System.Drawing.Size(39, 13);
            mAHPLabel.TabIndex = 10;
            mAHPLabel.Text = "MAHP:";
            // 
            // tRANGTHAILabel
            // 
            tRANGTHAILabel.AutoSize = true;
            tRANGTHAILabel.Location = new System.Drawing.Point(89, 211);
            tRANGTHAILabel.Name = "tRANGTHAILabel";
            tRANGTHAILabel.Size = new System.Drawing.Size(69, 13);
            tRANGTHAILabel.TabIndex = 11;
            tRANGTHAILabel.Text = "TRANGTHAI:";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnThem,
            this.barbtnXoa,
            this.barbtnLuu,
            this.barbtnHuy,
            this.barbtnThoat});
            this.barManager2.MainMenu = this.bar3;
            this.barManager2.MaxItemId = 5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barbtnThem
            // 
            this.barbtnThem.Caption = "Thêm";
            this.barbtnThem.Id = 0;
            this.barbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnThem.ImageOptions.Image")));
            this.barbtnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnThem.ImageOptions.LargeImage")));
            this.barbtnThem.Name = "barbtnThem";
            this.barbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnThem_ItemClick);
            // 
            // barbtnLuu
            // 
            this.barbtnLuu.Caption = "Lưu";
            this.barbtnLuu.Id = 2;
            this.barbtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLuu.ImageOptions.Image")));
            this.barbtnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnLuu.ImageOptions.LargeImage")));
            this.barbtnLuu.Name = "barbtnLuu";
            this.barbtnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLuu_ItemClick);
            // 
            // barbtnXoa
            // 
            this.barbtnXoa.Caption = "Xóa";
            this.barbtnXoa.Id = 1;
            this.barbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnXoa.ImageOptions.Image")));
            this.barbtnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnXoa.ImageOptions.LargeImage")));
            this.barbtnXoa.Name = "barbtnXoa";
            this.barbtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnXoa_ItemClick);
            // 
            // barbtnHuy
            // 
            this.barbtnHuy.Caption = "Hủy";
            this.barbtnHuy.Id = 3;
            this.barbtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnHuy.ImageOptions.Image")));
            this.barbtnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnHuy.ImageOptions.LargeImage")));
            this.barbtnHuy.Name = "barbtnHuy";
            this.barbtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnHuy_ItemClick);
            // 
            // barbtnThoat
            // 
            this.barbtnThoat.Caption = "Thoát";
            this.barbtnThoat.Id = 4;
            this.barbtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnThoat.ImageOptions.Image")));
            this.barbtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnThoat.ImageOptions.LargeImage")));
            this.barbtnThoat.Name = "barbtnThoat";
            this.barbtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1294, 26);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 813);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1294, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 26);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 787);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1294, 26);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 787);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTDOIPHONGTableAdapter = null;
            this.tableAdapterManager.CTKHACHOTableAdapter = null;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.QUANLYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(tRANGTHAILabel);
            this.panelInput.Controls.Add(this.cbTrangThai);
            this.panelInput.Controls.Add(mAHPLabel);
            this.panelInput.Controls.Add(this.cbMaHP);
            this.panelInput.Controls.Add(sOTANGLabel);
            this.panelInput.Controls.Add(this.txtSoTang);
            this.panelInput.Controls.Add(sOPHONGLabel);
            this.panelInput.Controls.Add(this.txtSoPhong);
            this.panelInput.Controls.Add(mAPHONGLabel);
            this.panelInput.Controls.Add(this.txtMaPhong);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 349);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1294, 464);
            this.panelInput.TabIndex = 6;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có khách",
            "Đặt trước",
            "Dơ",
            "Bảo trì"});
            this.cbTrangThai.Location = new System.Drawing.Point(176, 208);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(116, 25);
            this.cbTrangThai.TabIndex = 12;
            // 
            // cbMaHP
            // 
            this.cbMaHP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHP.FormattingEnabled = true;
            this.cbMaHP.Items.AddRange(new object[] {
            "HP001",
            "HP002",
            "HP003",
            "HP004"});
            this.cbMaHP.Location = new System.Drawing.Point(533, 208);
            this.cbMaHP.Name = "cbMaHP";
            this.cbMaHP.Size = new System.Drawing.Size(116, 25);
            this.cbMaHP.TabIndex = 11;
            // 
            // txtSoTang
            // 
            this.txtSoTang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTang.Location = new System.Drawing.Point(927, 75);
            this.txtSoTang.Multiline = true;
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.Size = new System.Drawing.Size(116, 29);
            this.txtSoTang.TabIndex = 5;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhong.Location = new System.Drawing.Point(533, 75);
            this.txtSoPhong.Multiline = true;
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(116, 29);
            this.txtSoPhong.TabIndex = 3;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(176, 75);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(116, 29);
            this.txtMaPhong.TabIndex = 1;
            // 
            // cTPHIEUTHUETableAdapter
            // 
            this.cTPHIEUTHUETableAdapter.ClearBeforeFill = true;
            // 
            // colMAPT1
            // 
            this.colMAPT1.FieldName = "MAPT";
            this.colMAPT1.MinWidth = 23;
            this.colMAPT1.Name = "colMAPT1";
            this.colMAPT1.Width = 87;
            // 
            // colMAPHONG1
            // 
            this.colMAPHONG1.FieldName = "MAPHONG";
            this.colMAPHONG1.MinWidth = 23;
            this.colMAPHONG1.Name = "colMAPHONG1";
            this.colMAPHONG1.Width = 87;
            // 
            // colPHUTHU1
            // 
            this.colPHUTHU1.FieldName = "PHUTHU";
            this.colPHUTHU1.MinWidth = 23;
            this.colPHUTHU1.Name = "colPHUTHU1";
            this.colPHUTHU1.Width = 87;
            // 
            // colTONGPHUTHU1
            // 
            this.colTONGPHUTHU1.FieldName = "TONGPHUTHU";
            this.colTONGPHUTHU1.MinWidth = 23;
            this.colTONGPHUTHU1.Name = "colTONGPHUTHU1";
            this.colTONGPHUTHU1.Width = 87;
            // 
            // colGHICHU1
            // 
            this.colGHICHU1.FieldName = "GHICHU";
            this.colGHICHU1.MinWidth = 23;
            this.colGHICHU1.Name = "colGHICHU1";
            this.colGHICHU1.Width = 87;
            // 
            // colMACTPT1
            // 
            this.colMACTPT1.FieldName = "MACTPT";
            this.colMACTPT1.MinWidth = 23;
            this.colMACTPT1.Name = "colMACTPT1";
            this.colMACTPT1.Width = 87;
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataMember = "PHONG";
            this.bdsPhong.DataSource = this.DS;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // gcPhong
            // 
            this.gcPhong.DataSource = this.bdsPhong;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhong.Location = new System.Drawing.Point(0, 26);
            this.gcPhong.MainView = this.gridView1;
            this.gcPhong.MenuManager = this.barManager2;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(1294, 323);
            this.gcPhong.TabIndex = 10;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONG,
            this.colSOPHONG,
            this.colSOTANG,
            this.colTRANGTHAI,
            this.colMAHP});
            this.gridView1.GridControl = this.gcPhong;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 23;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.OptionsColumn.AllowEdit = false;
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 0;
            this.colMAPHONG.Width = 87;
            // 
            // colSOPHONG
            // 
            this.colSOPHONG.FieldName = "SOPHONG";
            this.colSOPHONG.MinWidth = 23;
            this.colSOPHONG.Name = "colSOPHONG";
            this.colSOPHONG.OptionsColumn.AllowEdit = false;
            this.colSOPHONG.Visible = true;
            this.colSOPHONG.VisibleIndex = 1;
            this.colSOPHONG.Width = 87;
            // 
            // colSOTANG
            // 
            this.colSOTANG.FieldName = "SOTANG";
            this.colSOTANG.MinWidth = 23;
            this.colSOTANG.Name = "colSOTANG";
            this.colSOTANG.OptionsColumn.AllowEdit = false;
            this.colSOTANG.Visible = true;
            this.colSOTANG.VisibleIndex = 2;
            this.colSOTANG.Width = 87;
            // 
            // colTRANGTHAI
            // 
            this.colTRANGTHAI.FieldName = "TRANGTHAI";
            this.colTRANGTHAI.MinWidth = 23;
            this.colTRANGTHAI.Name = "colTRANGTHAI";
            this.colTRANGTHAI.OptionsColumn.AllowEdit = false;
            this.colTRANGTHAI.Visible = true;
            this.colTRANGTHAI.VisibleIndex = 3;
            this.colTRANGTHAI.Width = 87;
            // 
            // colMAHP
            // 
            this.colMAHP.FieldName = "MAHP";
            this.colMAHP.MinWidth = 23;
            this.colMAHP.Name = "colMAHP";
            this.colMAHP.OptionsColumn.AllowEdit = false;
            this.colMAHP.Visible = true;
            this.colMAHP.VisibleIndex = 4;
            this.colMAHP.Width = 87;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 813);
            this.Controls.Add(this.gcPhong);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barbtnThem;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barbtnXoa;
        private DevExpress.XtraBars.BarButtonItem barbtnHuy;
        private DevExpress.XtraBars.BarButtonItem barbtnThoat;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbMaHP;
        private System.Windows.Forms.BindingSource bdsCTPhieuThue;
        private DSTableAdapters.CTPHIEUTHUETableAdapter cTPHIEUTHUETableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHUTHU1;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGPHUTHU1;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACTPT1;
        private System.Windows.Forms.BindingSource bdsPhong;
        private DSTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHP;
    }
}