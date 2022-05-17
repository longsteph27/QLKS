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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            btnSaveEdit.Visible = false;
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            this.DS.EnforceConstraints = false;
            this.nHANVIENTableAdapter.Connection = Program.conn;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            this.hOADONTableAdapter.Connection = Program.conn;
            this.hOADONTableAdapter.Fill(this.DS.HOADON);
            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);           
            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);
            panelInput.Enabled = false;
        }

        private void nGAYSINHDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkPhai.SelectedIndex = 1;
            barbtnEdit.Enabled = false;
            barbtnXoa.Enabled = false;
            panelInput.Enabled = true;
            barbtnLuu.Enabled = true;
            barbtnHuy.Enabled = true;
            gcNhanVien.Enabled = false;
            barbtnThem.Enabled = false;
            bdsNhanVien.AddNew();
            
            txtMaNV.Focus();
        }

        private bool checkMABP()
        {
            Program.conn.Open();
            String mabp = txtMaBP.Text;
            String mabpsql = "SELECT *FROM BOPHAN WHERE MABP = '" + mabp + "'";
            SqlCommand mabpcmd = new SqlCommand(mabpsql, Program.conn);
            SqlDataReader BP = mabpcmd.ExecuteReader();
            if (BP.Read() == true)
            {
                Program.conn.Close();
                return true;
            }
            Program.conn.Close();
            return false;
        }

        private bool checkThongTin()
        {

            if (txtMaNV.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên, mã nhân viên phải có 5 kí tự KHxxx!");

                txtMaNV.Focus();
                return false;
            }

            if (txtMaNV.Text.Contains("NV") == false)
            {
                MessageBox.Show("Mã nhân viên không đúng yêu cầu, vui lòng nhập lại theo NVxxx!");
                txtMaNV.Focus();
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
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                txtDiaChi.Focus();
                return false;
            }
            if (txtMaBP.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã bộ phận theo BPxxx!");
                txtMaBP.Focus();
                return false;
            }
            if (txtMaBP.Text.Contains("BP") != true)
            {
                MessageBox.Show("Mã bộ phận không đúng yêu cầu, vui lòng nhập theo BPxxx!");
                txtMaBP.Focus();
                return false;
            }
            if (!checkMABP())
            {
                MessageBox.Show("Mã bộ phận không tồn tại, vui lòng nhập lại!");
                txtMaBP.Focus();
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
                bdsNhanVien.EndEdit();
                nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
                nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                bdsNhanVien.AddNew();
                txtMaNV.Focus();
            }
            else
            {
                bdsNhanVien.EndEdit();
                nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
        }

        private void barbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barbtnXoa.Enabled = false;
            barbtnLuu.Enabled = false;
            btnSaveEdit.Visible = true;
            btnSaveEdit.Enabled = true;
            panelInput.Enabled = true;
            barbtnHuy.Enabled = true;
            barbtnThem.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void barbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            gcNhanVien.Enabled = true;
            panelInput.Enabled = false;
            barbtnXoa.Enabled = true;
            btnSaveEdit.Visible = false;
            barbtnEdit.Enabled = true;
            
            btnSaveEdit.Enabled = false;
            barbtnHuy.Enabled = false;
            barbtnThem.Enabled = true;
            barbtnLuu.Enabled = false;
            
            barbtnEdit.Enabled = true;
            txtMaNV.Enabled = true;
        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsPhieuDat.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu đặt không thể xóa");
                return;
            }    
            if(bdsPhieuThue.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu thuê không thể xóa");
                return;
            }
            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập hóa đơn không thể xóa");
                return;
            }
            // kiem tra 
            // hoi co thuc su muon xoa hay k
            DialogResult save = MessageBox.Show("Bạn có muốn xóa hay không?", "Xóa", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                bdsNhanVien.RemoveCurrent();
                nHANVIENTableAdapter.Update(DS.NHANVIEN);
                nHANVIENTableAdapter.Fill(DS.NHANVIEN);
            }
            return;
        }

        private void barbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void pHAIRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
