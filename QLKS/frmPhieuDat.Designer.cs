
namespace QLKS
{
    partial class frmPhieuDat
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
            System.Windows.Forms.Label mAPDLabel;
            System.Windows.Forms.Label sOLUONGPHONGLabel;
            System.Windows.Forms.Label nGAYBATDAUTHUELabel;
            System.Windows.Forms.Label sONGAYTHUELabel;
            System.Windows.Forms.Label nGAYLAPPHIEULabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mAPDLabel1;
            System.Windows.Forms.Label mAHPLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDat));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLKS.DS();
            this.bdsPhieuDat = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QLKS.DSTableAdapters.PHIEUDATTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.cTPHIEUDATTableAdapter = new QLKS.DSTableAdapters.CTPHIEUDATTableAdapter();
            this.gcPhieuDat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAUTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSONGAYTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAPPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPhieuDat = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTPhieuDat = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gHICHUTextBox = new System.Windows.Forms.TextBox();
            this.mAHPTextBox = new System.Windows.Forms.TextBox();
            this.txtMaPDCTPD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.nGAYLAPPHIEUDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sONGAYTHUESpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nGAYBATDAUTHUEDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sOLUONGPHONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaPD = new System.Windows.Forms.TextBox();
            this.barbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            mAPDLabel = new System.Windows.Forms.Label();
            sOLUONGPHONGLabel = new System.Windows.Forms.Label();
            nGAYBATDAUTHUELabel = new System.Windows.Forms.Label();
            sONGAYTHUELabel = new System.Windows.Forms.Label();
            nGAYLAPPHIEULabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mAPDLabel1 = new System.Windows.Forms.Label();
            mAHPLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPPHIEUDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPPHIEUDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGAYTHUESpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBATDAUTHUEDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBATDAUTHUEDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGPHONGSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPDLabel
            // 
            mAPDLabel.AutoSize = true;
            mAPDLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPDLabel.Location = new System.Drawing.Point(70, 108);
            mAPDLabel.Name = "mAPDLabel";
            mAPDLabel.Size = new System.Drawing.Size(49, 17);
            mAPDLabel.TabIndex = 0;
            mAPDLabel.Text = "MAPD:";
            // 
            // sOLUONGPHONGLabel
            // 
            sOLUONGPHONGLabel.AutoSize = true;
            sOLUONGPHONGLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGPHONGLabel.Location = new System.Drawing.Point(70, 155);
            sOLUONGPHONGLabel.Name = "sOLUONGPHONGLabel";
            sOLUONGPHONGLabel.Size = new System.Drawing.Size(120, 17);
            sOLUONGPHONGLabel.TabIndex = 2;
            sOLUONGPHONGLabel.Text = "SOLUONGPHONG:";
            // 
            // nGAYBATDAUTHUELabel
            // 
            nGAYBATDAUTHUELabel.AutoSize = true;
            nGAYBATDAUTHUELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYBATDAUTHUELabel.Location = new System.Drawing.Point(70, 199);
            nGAYBATDAUTHUELabel.Name = "nGAYBATDAUTHUELabel";
            nGAYBATDAUTHUELabel.Size = new System.Drawing.Size(132, 17);
            nGAYBATDAUTHUELabel.TabIndex = 4;
            nGAYBATDAUTHUELabel.Text = "NGAYBATDAUTHUE:";
            // 
            // sONGAYTHUELabel
            // 
            sONGAYTHUELabel.AutoSize = true;
            sONGAYTHUELabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sONGAYTHUELabel.Location = new System.Drawing.Point(70, 240);
            sONGAYTHUELabel.Name = "sONGAYTHUELabel";
            sONGAYTHUELabel.Size = new System.Drawing.Size(99, 17);
            sONGAYTHUELabel.TabIndex = 6;
            sONGAYTHUELabel.Text = "SONGAYTHUE:";
            // 
            // nGAYLAPPHIEULabel
            // 
            nGAYLAPPHIEULabel.AutoSize = true;
            nGAYLAPPHIEULabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLAPPHIEULabel.Location = new System.Drawing.Point(70, 283);
            nGAYLAPPHIEULabel.Name = "nGAYLAPPHIEULabel";
            nGAYLAPPHIEULabel.Size = new System.Drawing.Size(108, 17);
            nGAYLAPPHIEULabel.TabIndex = 8;
            nGAYLAPPHIEULabel.Text = "NGAYLAPPHIEU:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(70, 319);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 10;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(70, 360);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 12;
            mAKHLabel.Text = "MAKH:";
            // 
            // mAPDLabel1
            // 
            mAPDLabel1.AutoSize = true;
            mAPDLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPDLabel1.Location = new System.Drawing.Point(524, 108);
            mAPDLabel1.Name = "mAPDLabel1";
            mAPDLabel1.Size = new System.Drawing.Size(49, 17);
            mAPDLabel1.TabIndex = 14;
            mAPDLabel1.Text = "MAPD:";
            // 
            // mAHPLabel
            // 
            mAHPLabel.AutoSize = true;
            mAHPLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHPLabel.Location = new System.Drawing.Point(524, 157);
            mAHPLabel.Name = "mAHPLabel";
            mAHPLabel.Size = new System.Drawing.Size(48, 17);
            mAHPLabel.TabIndex = 16;
            mAHPLabel.Text = "MAHP:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gHICHULabel.Location = new System.Drawing.Point(524, 199);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(62, 17);
            gHICHULabel.TabIndex = 18;
            gHICHULabel.Text = "GHICHU:";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnThem,
            this.barbtnLuu,
            this.barbtnHuy,
            this.barButtonItem4,
            this.barbtnEdit});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // barbtnThem
            // 
            this.barbtnThem.Caption = "Thêm";
            this.barbtnThem.Id = 0;
            this.barbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnThem.ImageOptions.Image")));
            this.barbtnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnThem.ImageOptions.LargeImage")));
            this.barbtnThem.Name = "barbtnThem";
            this.barbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barbtnLuu
            // 
            this.barbtnLuu.Caption = "Lưu";
            this.barbtnLuu.Id = 1;
            this.barbtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLuu.ImageOptions.Image")));
            this.barbtnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnLuu.ImageOptions.LargeImage")));
            this.barbtnLuu.Name = "barbtnLuu";
            this.barbtnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLuu_ItemClick);
            // 
            // barbtnHuy
            // 
            this.barbtnHuy.Caption = "Hủy";
            this.barbtnHuy.Id = 2;
            this.barbtnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnHuy.ImageOptions.Image")));
            this.barbtnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnHuy.ImageOptions.LargeImage")));
            this.barbtnHuy.Name = "barbtnHuy";
            this.barbtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnHuy_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thoát";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1334, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 861);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1334, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 835);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1334, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 835);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuDat
            // 
            this.bdsPhieuDat.DataMember = "PHIEUDAT";
            this.bdsPhieuDat.DataSource = this.DS;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTDOIPHONGTableAdapter = null;
            this.tableAdapterManager.CTKHACHOTableAdapter = null;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = this.cTPHIEUDATTableAdapter;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = this.pHIEUDATTableAdapter;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.QUANLYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTPHIEUDATTableAdapter
            // 
            this.cTPHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // gcPhieuDat
            // 
            this.gcPhieuDat.DataSource = this.bdsPhieuDat;
            this.gcPhieuDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuDat.Location = new System.Drawing.Point(0, 26);
            this.gcPhieuDat.MainView = this.gridView1;
            this.gcPhieuDat.MenuManager = this.barManager1;
            this.gcPhieuDat.Name = "gcPhieuDat";
            this.gcPhieuDat.Size = new System.Drawing.Size(1334, 242);
            this.gcPhieuDat.TabIndex = 5;
            this.gcPhieuDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPD,
            this.colSOLUONGPHONG,
            this.colNGAYBATDAUTHUE,
            this.colSONGAYTHUE,
            this.colNGAYLAPPHIEU,
            this.colMANV,
            this.colMAKH});
            this.gridView1.GridControl = this.gcPhieuDat;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPD
            // 
            this.colMAPD.FieldName = "MAPD";
            this.colMAPD.MinWidth = 23;
            this.colMAPD.Name = "colMAPD";
            this.colMAPD.OptionsColumn.AllowEdit = false;
            this.colMAPD.Visible = true;
            this.colMAPD.VisibleIndex = 0;
            this.colMAPD.Width = 87;
            // 
            // colSOLUONGPHONG
            // 
            this.colSOLUONGPHONG.FieldName = "SOLUONGPHONG";
            this.colSOLUONGPHONG.MinWidth = 23;
            this.colSOLUONGPHONG.Name = "colSOLUONGPHONG";
            this.colSOLUONGPHONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONGPHONG.Visible = true;
            this.colSOLUONGPHONG.VisibleIndex = 1;
            this.colSOLUONGPHONG.Width = 87;
            // 
            // colNGAYBATDAUTHUE
            // 
            this.colNGAYBATDAUTHUE.FieldName = "NGAYBATDAUTHUE";
            this.colNGAYBATDAUTHUE.MinWidth = 23;
            this.colNGAYBATDAUTHUE.Name = "colNGAYBATDAUTHUE";
            this.colNGAYBATDAUTHUE.OptionsColumn.AllowEdit = false;
            this.colNGAYBATDAUTHUE.Visible = true;
            this.colNGAYBATDAUTHUE.VisibleIndex = 2;
            this.colNGAYBATDAUTHUE.Width = 87;
            // 
            // colSONGAYTHUE
            // 
            this.colSONGAYTHUE.FieldName = "SONGAYTHUE";
            this.colSONGAYTHUE.MinWidth = 23;
            this.colSONGAYTHUE.Name = "colSONGAYTHUE";
            this.colSONGAYTHUE.OptionsColumn.AllowEdit = false;
            this.colSONGAYTHUE.Visible = true;
            this.colSONGAYTHUE.VisibleIndex = 3;
            this.colSONGAYTHUE.Width = 87;
            // 
            // colNGAYLAPPHIEU
            // 
            this.colNGAYLAPPHIEU.FieldName = "NGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.MinWidth = 23;
            this.colNGAYLAPPHIEU.Name = "colNGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.OptionsColumn.AllowEdit = false;
            this.colNGAYLAPPHIEU.Visible = true;
            this.colNGAYLAPPHIEU.VisibleIndex = 4;
            this.colNGAYLAPPHIEU.Width = 87;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 87;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 23;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 6;
            this.colMAKH.Width = 87;
            // 
            // bdsCTPhieuDat
            // 
            this.bdsCTPhieuDat.DataMember = "CTPHIEUDAT";
            this.bdsCTPhieuDat.DataSource = this.DS;
            // 
            // gcCTPhieuDat
            // 
            this.gcCTPhieuDat.DataSource = this.bdsCTPhieuDat;
            this.gcCTPhieuDat.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcCTPhieuDat.Location = new System.Drawing.Point(895, 268);
            this.gcCTPhieuDat.MainView = this.gridView2;
            this.gcCTPhieuDat.MenuManager = this.barManager1;
            this.gcCTPhieuDat.Name = "gcCTPhieuDat";
            this.gcCTPhieuDat.Size = new System.Drawing.Size(439, 593);
            this.gcCTPhieuDat.TabIndex = 5;
            this.gcCTPhieuDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPD1,
            this.colMAHP,
            this.colGHICHU});
            this.gridView2.GridControl = this.gcCTPhieuDat;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPD1
            // 
            this.colMAPD1.FieldName = "MAPD";
            this.colMAPD1.MinWidth = 23;
            this.colMAPD1.Name = "colMAPD1";
            this.colMAPD1.OptionsColumn.AllowEdit = false;
            this.colMAPD1.Visible = true;
            this.colMAPD1.VisibleIndex = 0;
            this.colMAPD1.Width = 87;
            // 
            // colMAHP
            // 
            this.colMAHP.FieldName = "MAHP";
            this.colMAHP.MinWidth = 23;
            this.colMAHP.Name = "colMAHP";
            this.colMAHP.OptionsColumn.AllowEdit = false;
            this.colMAHP.Visible = true;
            this.colMAHP.VisibleIndex = 1;
            this.colMAHP.Width = 87;
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
            this.panelInput.Controls.Add(this.btnSaveEdit);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.gHICHUTextBox);
            this.panelInput.Controls.Add(mAHPLabel);
            this.panelInput.Controls.Add(this.mAHPTextBox);
            this.panelInput.Controls.Add(mAPDLabel1);
            this.panelInput.Controls.Add(this.txtMaPDCTPD);
            this.panelInput.Controls.Add(mAKHLabel);
            this.panelInput.Controls.Add(this.txtMaKH);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Controls.Add(nGAYLAPPHIEULabel);
            this.panelInput.Controls.Add(this.nGAYLAPPHIEUDateEdit);
            this.panelInput.Controls.Add(sONGAYTHUELabel);
            this.panelInput.Controls.Add(this.sONGAYTHUESpinEdit);
            this.panelInput.Controls.Add(nGAYBATDAUTHUELabel);
            this.panelInput.Controls.Add(this.nGAYBATDAUTHUEDateEdit);
            this.panelInput.Controls.Add(sOLUONGPHONGLabel);
            this.panelInput.Controls.Add(this.sOLUONGPHONGSpinEdit);
            this.panelInput.Controls.Add(mAPDLabel);
            this.panelInput.Controls.Add(this.txtMaPD);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 268);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(895, 593);
            this.panelInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Chi tiết phiếu đặt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Phiếu đặt";
            // 
            // gHICHUTextBox
            // 
            this.gHICHUTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gHICHUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuDat, "GHICHU", true));
            this.gHICHUTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gHICHUTextBox.Location = new System.Drawing.Point(599, 197);
            this.gHICHUTextBox.Multiline = true;
            this.gHICHUTextBox.Name = "gHICHUTextBox";
            this.gHICHUTextBox.Size = new System.Drawing.Size(245, 185);
            this.gHICHUTextBox.TabIndex = 19;
            // 
            // mAHPTextBox
            // 
            this.mAHPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mAHPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuDat, "MAHP", true));
            this.mAHPTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAHPTextBox.Location = new System.Drawing.Point(599, 153);
            this.mAHPTextBox.Name = "mAHPTextBox";
            this.mAHPTextBox.Size = new System.Drawing.Size(100, 24);
            this.mAHPTextBox.TabIndex = 17;
            // 
            // txtMaPDCTPD
            // 
            this.txtMaPDCTPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPDCTPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuDat, "MAPD", true));
            this.txtMaPDCTPD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPDCTPD.Location = new System.Drawing.Point(599, 106);
            this.txtMaPDCTPD.Name = "txtMaPDCTPD";
            this.txtMaPDCTPD.Size = new System.Drawing.Size(100, 24);
            this.txtMaPDCTPD.TabIndex = 15;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuDat, "MAKH", true));
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(221, 358);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 24);
            this.txtMaKH.TabIndex = 13;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuDat, "MANV", true));
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(221, 317);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 24);
            this.txtMaNV.TabIndex = 11;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // nGAYLAPPHIEUDateEdit
            // 
            this.nGAYLAPPHIEUDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuDat, "NGAYLAPPHIEU", true));
            this.nGAYLAPPHIEUDateEdit.EditValue = null;
            this.nGAYLAPPHIEUDateEdit.Location = new System.Drawing.Point(221, 280);
            this.nGAYLAPPHIEUDateEdit.MenuManager = this.barManager1;
            this.nGAYLAPPHIEUDateEdit.Name = "nGAYLAPPHIEUDateEdit";
            this.nGAYLAPPHIEUDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYLAPPHIEUDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYLAPPHIEUDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYLAPPHIEUDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYLAPPHIEUDateEdit.Size = new System.Drawing.Size(117, 24);
            this.nGAYLAPPHIEUDateEdit.TabIndex = 9;
            // 
            // sONGAYTHUESpinEdit
            // 
            this.sONGAYTHUESpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuDat, "SONGAYTHUE", true));
            this.sONGAYTHUESpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sONGAYTHUESpinEdit.Location = new System.Drawing.Point(221, 237);
            this.sONGAYTHUESpinEdit.MenuManager = this.barManager1;
            this.sONGAYTHUESpinEdit.Name = "sONGAYTHUESpinEdit";
            this.sONGAYTHUESpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sONGAYTHUESpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sONGAYTHUESpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sONGAYTHUESpinEdit.Size = new System.Drawing.Size(42, 24);
            this.sONGAYTHUESpinEdit.TabIndex = 7;
            // 
            // nGAYBATDAUTHUEDateEdit
            // 
            this.nGAYBATDAUTHUEDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuDat, "NGAYBATDAUTHUE", true));
            this.nGAYBATDAUTHUEDateEdit.EditValue = null;
            this.nGAYBATDAUTHUEDateEdit.Location = new System.Drawing.Point(221, 197);
            this.nGAYBATDAUTHUEDateEdit.MenuManager = this.barManager1;
            this.nGAYBATDAUTHUEDateEdit.Name = "nGAYBATDAUTHUEDateEdit";
            this.nGAYBATDAUTHUEDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYBATDAUTHUEDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYBATDAUTHUEDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYBATDAUTHUEDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYBATDAUTHUEDateEdit.Size = new System.Drawing.Size(117, 24);
            this.nGAYBATDAUTHUEDateEdit.TabIndex = 5;
            // 
            // sOLUONGPHONGSpinEdit
            // 
            this.sOLUONGPHONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuDat, "SOLUONGPHONG", true));
            this.sOLUONGPHONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGPHONGSpinEdit.Location = new System.Drawing.Point(221, 152);
            this.sOLUONGPHONGSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGPHONGSpinEdit.Name = "sOLUONGPHONGSpinEdit";
            this.sOLUONGPHONGSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOLUONGPHONGSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sOLUONGPHONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGPHONGSpinEdit.Size = new System.Drawing.Size(42, 24);
            this.sOLUONGPHONGSpinEdit.TabIndex = 3;
            // 
            // txtMaPD
            // 
            this.txtMaPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuDat, "MAPD", true));
            this.txtMaPD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPD.Location = new System.Drawing.Point(221, 106);
            this.txtMaPD.Name = "txtMaPD";
            this.txtMaPD.Size = new System.Drawing.Size(100, 24);
            this.txtMaPD.TabIndex = 1;
            this.txtMaPD.TextChanged += new System.EventHandler(this.txtMaPD_TextChanged);
            // 
            // barbtnEdit
            // 
            this.barbtnEdit.Caption = "Chỉnh sửa";
            this.barbtnEdit.Id = 4;
            this.barbtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barbtnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barbtnEdit.Name = "barbtnEdit";
            this.barbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.White;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.Location = new System.Drawing.Point(363, 459);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(134, 65);
            this.btnSaveEdit.TabIndex = 21;
            this.btnSaveEdit.Text = "Lưu chỉnh sửa";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // frmPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 861);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcCTPhieuDat);
            this.Controls.Add(this.gcPhieuDat);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuDat";
            this.Text = "frmPhieuDat";
            this.Load += new System.EventHandler(this.frmPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPPHIEUDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYLAPPHIEUDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGAYTHUESpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBATDAUTHUEDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBATDAUTHUEDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGPHONGSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barbtnThem;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barbtnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPhieuDat;
        private DS DS;
        private DSTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAUTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn colSONGAYTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAPPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DSTableAdapters.CTPHIEUDATTableAdapter cTPHIEUDATTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPhieuDat;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gHICHUTextBox;
        private System.Windows.Forms.TextBox mAHPTextBox;
        private System.Windows.Forms.TextBox txtMaPDCTPD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.DateEdit nGAYLAPPHIEUDateEdit;
        private DevExpress.XtraEditors.SpinEdit sONGAYTHUESpinEdit;
        private DevExpress.XtraEditors.DateEdit nGAYBATDAUTHUEDateEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGPHONGSpinEdit;
        private System.Windows.Forms.TextBox txtMaPD;
        private DevExpress.XtraGrid.GridControl gcCTPhieuDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHP;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraBars.BarButtonItem barbtnEdit;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}