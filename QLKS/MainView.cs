using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public void hienThiChucNang()
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmMain()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        public frmMain(String bophan, String manv)
        {
            Program.bophan = bophan;
            Program.manv = manv;
            InitializeComponent();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            new frmLogIn().Show();
            this.Hide();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            this.CenterToScreen();
            
            ribThongKe.Visible = false;
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.bophan != "BP008")
            {
                MessageBox.Show("Không có quyền truy cập!");
                return;
            }
            if(Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }

            Form frm = CheckExists(typeof(frmPhong));

            if (frm != null)
            {
                frm.Activate();
               
            }
            else
            {
                frmPhong f = new frmPhong();
                f.MdiParent = this;
                f.Show();
               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.bophan == "BP005")
            {
            Form frm = CheckExists(typeof(frmKhachHang));

            if (frm != null)
            {
                frm.Activate();
                return;
                }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
                return;
                }

            }
            if (Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }

            MessageBox.Show("Không có quyền truy cập!");
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.bophan == "BP005")
            {
            Form frm = CheckExists(typeof(frmPhieuThue));

            if (frm != null)
            {
                frm.Activate();
                return;
                }
            else
            {
                frmPhieuThue f = new frmPhieuThue();
                f.MdiParent = this;
                f.Show();
                return;
            }

            }
            if (Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }

            MessageBox.Show("Không có quyền truy cập!");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.bophan == "BP001" || Program.bophan == "BP008")
            {
                Form frm = CheckExists(typeof(frmNhanVien));

                if (frm != null)
                {
                    frm.Activate();
                    return;
                }
                else
                {
                    frmNhanVien f = new frmNhanVien();
                    f.MdiParent = this;
                    f.Show();
                    return;
                }
            }

            if(Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }    

            MessageBox.Show("Không có quyền truy cập!");

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.bophan == "BP005")
            {
            Form frm = CheckExists(typeof(frmPhieuDat));

            if (frm != null)
            {
                frm.Activate();
                return;
                }
            else
            {
                frmPhieuDat f = new frmPhieuDat();
                f.MdiParent = this;
                f.Show();
                return;
                }

            }
            if (Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }

            MessageBox.Show("Không có quyền truy cập!");
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.bophan == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }
            new frmDoiMatKhau().Show();

        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.manv == "")
            {
                MessageBox.Show("Chưa đăng nhập!");
                return;
            }

            Program.bophan = "";
            Program.manv = "";
            MessageBox.Show("Đăng xuất thành công!");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
