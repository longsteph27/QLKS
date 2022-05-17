using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
           
            this.DS.EnforceConstraints = false;
            this.kHACHHANGTableAdapter.Connection = Program.conn;
            this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            btnSaveEdit.Visible = false;
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            panelInput.Enabled = false;
        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barbtnEdit.Enabled = false;
            barbtnXoa.Enabled = false;
            
            panelInput.Enabled = true;
            barbtnLuu.Enabled = true;
            barbtnHuy.Enabled = true;
            gcKhachHang.Enabled = false;
            barbtnThem.Enabled = false;
            bdsKhachHang.AddNew();
            txtMaKH.Focus();

        }

        private bool checkMAKH()
        {
            Program.conn.Open();
            String mskh = txtMaKH.Text;
            String makhsql = "SELECT *FROM KHACHHANG WHERE MAKH = '" + mskh + "'";
            SqlCommand makhcmd = new SqlCommand(makhsql, Program.conn);
            SqlDataReader KH = makhcmd.ExecuteReader();
            if (KH.Read() == true)
            {
                Program.conn.Close();
                return false;
            }
            Program.conn.Close();
            return true;
        }

        private bool checkMSTHUE()
        {
            Program.conn.Open();
            String msthue = txtMaSoThue.Text;
            String sql = "SELECT *FROM KHACHHANG WHERE MASOTHUE = '" + msthue + "'";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            SqlDataReader thue = cmd.ExecuteReader();
            if (thue.Read() == true)
            {
                Program.conn.Close();
                return false;

            }
            Program.conn.Close();
            return true;

        }



        private bool checkThongTin()
        {

            if (txtMaKH.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng, mã khách hàng phải có 5 kí tự KHxxx!");

                txtMaKH.Focus();
                return false;
            }

            if (!checkMAKH())
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, vui lòng nhập lại mã khách hàng!");
                txtMaKH.Focus();
                return false;
            }

            if (txtMaKH.Text.Contains("KH") == false)
            {
                MessageBox.Show("Mã khách hàng không đúng yêu cầu, vui lòng nhập lại mã khách hàng!");
                txtMaKH.Focus();
                return false;
            }

            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Họ !");
                txtHo.Focus();
                return false;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Tên !");
                txtTen.Focus();
                return false;
            }
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Vui lòng nhập SDT !");
                txtSDT.Focus();
                return false;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email !");
                txtEmail.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ !");
                txtDiaChi.Focus();
                return false;
            }
            if (txtMaSoThue.Text.Trim().Length != 6)
            {
                MessageBox.Show("Vui lòng nhập mã số thuế theo VATxxx!");
                txtMaSoThue.Focus();
                return false;
            }
            if (txtMaSoThue.Text.Contains("VAT") != true)
            {
                MessageBox.Show("Mã số thuế không đúng yêu cầu, vui lòng nhập lại!");
                txtMaSoThue.Focus();
                return false;
            }
            if (!checkMSTHUE())
            {
                MessageBox.Show("Mã số thuế đã tồn tại, vui lòng nhập lại!");
                txtMaSoThue.Focus();
                return false;
            }

            return true;


        }


        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkThongTin())
            {
                return;
            }


            DialogResult save = MessageBox.Show("Bạn có muốn lưu hay không?", "Lưu", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                bdsKhachHang.EndEdit();
                kHACHHANGTableAdapter.Update(this.DS.KHACHHANG);
                kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
                bdsKhachHang.AddNew();
                txtMaKH.Focus();
            }
            else
            {
                bdsKhachHang.EndEdit();
                kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            }


        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barbtnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barbtnXoa.Enabled = false;
            barbtnLuu.Enabled = false;
            btnSaveEdit.Visible = true;
            btnSaveEdit.Enabled = true;
            panelInput.Enabled = true;
            barbtnHuy.Enabled = true;
            barbtnThem.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Bạn có muốn lưu chỉnh sửa không?", "Lưu chỉnh sửa", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                bdsKhachHang.EndEdit();
                kHACHHANGTableAdapter.Update(this.DS.KHACHHANG);
                kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            }
            return;

        }

        private void barbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhachHang.CancelEdit();
            barbtnHuy.Enabled = false;
            panelInput.Enabled = false;
            gcKhachHang.Enabled = true;
            barbtnXoa.Enabled = true;
            btnSaveEdit.Visible = false;
            barbtnEdit.Enabled = true;
            btnSaveEdit.Enabled = false;
            
            barbtnThem.Enabled = true;
            barbtnLuu.Enabled = false;
            
            txtMaKH.Enabled = true;
        }

        private void barbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
