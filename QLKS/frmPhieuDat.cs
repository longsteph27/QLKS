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
    public partial class frmPhieuDat : Form
    {
        public frmPhieuDat()
        {
            InitializeComponent();
        }

        private void pHIEUDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuDat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuDat_Load(object sender, EventArgs e)
        {
            btnSaveEdit.Visible = false;
            txtMaNV.Enabled = false;
            txtMaPDCTPD.Enabled = false;
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            panelInput.Enabled = false;
            this.DS.EnforceConstraints = false;
            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);
            this.cTPHIEUDATTableAdapter.Connection = Program.conn;
            this.cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNV.Text = Program.manv;
            panelInput.Enabled = true;
            barbtnLuu.Enabled = true;
            barbtnHuy.Enabled = true;
            barbtnThem.Enabled = false;
            gcPhieuDat.Enabled = false;
            gcCTPhieuDat.Enabled = false;
            bdsCTPhieuDat.AddNew();
            bdsPhieuDat.AddNew();
            txtMaPD.Focus();
        }

        private bool checkMAPD()
        {
            Program.conn.Open();
            String mapd = txtMaPD.Text;
            String mapdsql = "SELECT *FROM PHIEUDAT WHERE MAPD = '" + mapd + "'";
            SqlCommand mapdcmd = new SqlCommand(mapdsql, Program.conn);
            SqlDataReader PD = mapdcmd.ExecuteReader();
            if (PD.Read() == true)
            {
                Program.conn.Close();
                return false;
            }
            Program.conn.Close();
            return true;
        }

        private bool checkMANV()
        {
            Program.conn.Open();
            String manv = txtMaNV.Text;
            String manvsql = "SELECT *FROM NHANVIEN WHERE MANV = '" + manv + "'";
            SqlCommand manvcmd = new SqlCommand(manvsql, Program.conn);
            SqlDataReader NV = manvcmd.ExecuteReader();
            if (NV.Read() == true)
            {
                Program.conn.Close();
                return true;
            }
            Program.conn.Close();
            return false;
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
                return true;
            }
            Program.conn.Close();
            return false;
        }

        private bool checkThongTin()
        {
            if (txtMaPD.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt, mã phiếu đặt phải có 5 kí tự PDxxx!");
                txtMaPD.Focus();
                return false;
            }

            if (!checkMAPD())
            {
                MessageBox.Show("Mã phiếu đặt đã tồn tại, vui lòng nhập lại mã phiếu đặt!");
                txtMaPD.Focus();
                return false;
            }

            if (txtMaPD.Text.Contains("PD") == false)
            {
                MessageBox.Show("Mã phiếu đặt không đúng yêu cầu, vui lòng nhập lại!");
                txtMaPD.Focus();
                return false;
            }

            if (txtMaNV.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên, mã nhân viên phải có 5 kí tự NVxxx!");

                txtMaNV.Focus();
                return false;
            }

            if (!checkMANV())
            {
                MessageBox.Show("Mã nhân viên không tồn tại, vui lòng nhập lại mã nhân viên!");
                txtMaNV.Focus();
                return false;
            }

            if (txtMaNV.Text.Contains("NV") == false)
            {
                MessageBox.Show("Mã nhân viên không đúng yêu cầu, vui lòng nhập lại mã nhân viên!");
                txtMaNV.Focus();
                return false;
            }

            if (txtMaKH.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng, mã khách hàng phải có 5 kí tự KHxxx!");

                txtMaKH.Focus();
                return false;
            }

            if (!checkMAKH())
            {
                MessageBox.Show("Mã khách hàng không tồn tại, vui lòng nhập lại!");
                txtMaKH.Focus();
                return false;
            }

            if (txtMaKH.Text.Contains("KH") == false)
            {
                MessageBox.Show("Mã khách hàng không đúng yêu cầu, vui lòng nhập lại!");
                txtMaKH.Focus();
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
                bdsCTPhieuDat.EndEdit();
                bdsPhieuDat.EndEdit();
                pHIEUDATTableAdapter.Update(this.DS.PHIEUDAT);
                pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);


                cTPHIEUDATTableAdapter.Update(this.DS.CTPHIEUDAT);
                cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);


                bdsCTPhieuDat.AddNew();
                bdsPhieuDat.AddNew();
                txtMaPD.Focus();
            }
            else
            {
                bdsCTPhieuDat.EndEdit();
                bdsPhieuDat.EndEdit();
                pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);
                cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);
            }
        }

        private void barbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPhieuDat.CancelEdit();
            bdsPhieuDat.CancelEdit();

            btnSaveEdit.Visible = false;
            txtMaKH.Enabled = true;
            txtMaPD.Enabled = true;
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            gcPhieuDat.Enabled = true;
            gcCTPhieuDat.Enabled = true;
            panelInput.Enabled = false;
            barbtnThem.Enabled = true;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void getMaPD()
        {
            txtMaPDCTPD.Text = txtMaPD.Text;
        }
        private void txtMaPD_TextChanged(object sender, EventArgs e)
        {
            if(panelInput.Enabled == true)
            {
                getMaPD();
            }    
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaPDCTPD.Enabled = false;
            barbtnLuu.Enabled = false;
            btnSaveEdit.Visible = true;
            btnSaveEdit.Enabled = true;
            panelInput.Enabled = true;
            barbtnHuy.Enabled = true;
            barbtnThem.Enabled = false;
            txtMaPD.Enabled = false;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if(!checkQuyenEdit())
            {
                MessageBox.Show("Không thể chỉnh sửa!");
                return;
            }    
            DialogResult save = MessageBox.Show("Bạn có muốn lưu chỉnh sửa không?", "Lưu chỉnh sửa", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                bdsCTPhieuDat.EndEdit();
                bdsPhieuDat.EndEdit();
                pHIEUDATTableAdapter.Update(this.DS.PHIEUDAT);
                pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);

                cTPHIEUDATTableAdapter.Update(this.DS.CTPHIEUDAT);
                cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);
            }
            return;
        }

        private bool checkQuyenEdit()
        {
            if (txtMaNV.Text != Program.manv)
            {
                
                return false;
            }
            return true;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
