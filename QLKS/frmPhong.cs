using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            
            this.DS.EnforceConstraints = false;
            barbtnHuy.Enabled = false;
            panelInput.Enabled = false;
  
            this.pHONGTableAdapter.Connection = Program.conn;
            this.pHONGTableAdapter.Fill(this.DS.PHONG);
            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pHONGTableAdapter.FillBy(this.DS.PHONG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barbtnHuy.Enabled = true;
            panelInput.Enabled = true;
            gcPhong.Enabled = false;           
            barbtnThem.Enabled = false;
            barbtnXoa.Enabled = false;
            bdsPhong.AddNew();
            txtMaPhong.Focus();
        }

        private bool checkMP()
        {
            Program.conn.Open();
            String mp = txtMaPhong.Text;
            String sql = "SELECT *FROM PHONG WHERE MAPHONG = '" + mp + "'";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            SqlDataReader maPhong = cmd.ExecuteReader();
            if (maPhong.Read() == true)
            {
                Program.conn.Close();
                return false;

            }
            Program.conn.Close();
            return true;

        }

        private bool checkThongTin()
        {
            if (txtMaPhong.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phòng gồm 5 kí tự MPxxx, vui lòng nhập lại!");
                txtMaPhong.Focus();
                return false;
            }
            if (txtMaPhong.Text.Contains("MP") == false)
            {
                MessageBox.Show("Mã phòng phải được nhập theo mãu MPxxx, vui lòng nhập lại!");
                txtMaPhong.Focus();
                return false;
            }
            if (!checkMP())
            {
                MessageBox.Show("Mã phòng đã tồn tại, vui lòng nhập lại!");
                txtMaPhong.Focus();
                return false;
            }
            if (txtSoPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phòng !");
                txtSoPhong.Focus();
                return false;
            }
            if (txtSoTang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tầng !");
                txtSoTang.Focus();
                return false;
            }
            if (cbTrangThai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng!");
                txtSoTang.Focus();
                return false;
            }
            if (cbMaHP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã hạng phòng!");
                txtSoTang.Focus();
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
                bdsPhong.EndEdit();
                pHONGTableAdapter.Update(this.DS.PHONG);
                pHONGTableAdapter.Fill(this.DS.PHONG);
                bdsPhong.AddNew();
                txtMaPhong.Focus();
            }
            else
            {
                bdsPhong.EndEdit();
                pHONGTableAdapter.Fill(this.DS.PHONG);
            }
        }

        private void barbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhong.CancelEdit();
            barbtnHuy.Enabled = false;
            gcPhong.Enabled = true;
            panelInput.Enabled = false;
            barbtnXoa.Enabled = true;
            barbtnThem.Enabled = true;
        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPhieuThue.Count > 0)
            {
                MessageBox.Show("Để bảo vệ dữ liệu, phòng đã từng được sử dụng nên không thể xóa!");
                return;
            }

            // kiem tra 
            // hoi co thuc su muon xoa hay k
            DialogResult save = MessageBox.Show("Bạn có muốn xóa hay không?", "Xóa", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                bdsPhong.RemoveCurrent();
                pHONGTableAdapter.Update(DS.PHONG);
                pHONGTableAdapter.Fill(DS.PHONG);
            }
            return;
        }

        private void barbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
