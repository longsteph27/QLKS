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
    public partial class frmPhieuThue : Form
    {
        public frmPhieuThue()
        {
            InitializeComponent();
        }

        private void pHIEUTHUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuThue.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtMaPTCTPT.Enabled = false;
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            panelInputAll.Enabled = false;
            this.DS.EnforceConstraints = false;
            
            
            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);
            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);

            
            

        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNV.Text = Program.manv;
            panelInputAll.Enabled = true;
            barbtnLuu.Enabled = true;
            barbtnHuy.Enabled = true;
            barbtnThem.Enabled = false;
            gcPhieuThue.Enabled = false;
            gcCTPhieuThue.Enabled = false;
            bdsCTPhieuThue.AddNew();
            bdsPhieuThue.AddNew();

            txtMaPT.Focus();
        }


        private bool checkMAPT()
        {
            Program.conn.Open();
            String mapt = txtMaPT.Text;
            String maptsql = "SELECT *FROM PHIEUTHUE WHERE MAPT = '" + mapt + "'";
            SqlCommand maptcmd = new SqlCommand(maptsql, Program.conn);
            SqlDataReader PT = maptcmd.ExecuteReader();
            if (PT.Read() == true)
            {
                Program.conn.Close();
                return false;
            }
            Program.conn.Close();
            return true;
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

        private bool checkThongTin()
        {
            if (txtMaPT.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu thuê, mã phiếu thuê phải có 5 kí tự PTxxx!");
                txtMaPT.Focus();
                return false;
            }

            if (!checkMAPT())
            {
                MessageBox.Show("Mã phiếu thuê đã tồn tại, vui lòng nhập lại!");
                txtMaPT.Focus();
                return false;
            }

            if (txtMaPT.Text.Contains("PT") == false)
            {
                MessageBox.Show("Mã phiếu thuê không đúng yêu cầu, vui lòng nhập lại!");
                txtMaPT.Focus();
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
                MessageBox.Show("Mã khách hàng không tồn tại, vui lòng nhập lại mã khách hàng!");
                txtMaKH.Focus();
                return false;
            }

            if (txtMaKH.Text.Contains("KH") == false)
            {
                MessageBox.Show("Mã khách hàng không đúng yêu cầu, vui lòng nhập lại mã khách hàng!");
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
                bdsCTPhieuThue.EndEdit();
                bdsPhieuThue.EndEdit();
                pHIEUTHUETableAdapter.Update(this.DS.PHIEUTHUE);
                pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);

                
                cTPHIEUTHUETableAdapter.Update(this.DS.CTPHIEUTHUE);
                cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
                
                
                bdsCTPhieuThue.AddNew();
                bdsPhieuThue.AddNew();
                txtMaPT.Focus();
            }
            else
            {
                bdsCTPhieuThue.EndEdit();
                bdsPhieuThue.EndEdit();
                pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);
                cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
            }
            
        }


        private void nGAYDENLabel_Click(object sender, EventArgs e)
        {

        }

        private void getMaPT()
        {
            txtMaPTCTPT.Text = txtMaPT.Text;
        }

        private void mAPTTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mAPTLabel1_Click(object sender, EventArgs e)
        {

        }

        private void barbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPhieuThue.CancelEdit();
            bdsPhieuThue.CancelEdit();  
            
            barbtnHuy.Enabled = false;
            barbtnLuu.Enabled = false;
            gcPhieuThue.Enabled = true;
            gcCTPhieuThue.Enabled = true;
            panelInputAll.Enabled = false;
            barbtnThem.Enabled = true;
        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {
            if(panelInputAll.Enabled == true)
            {
                getMaPT();
            }    
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(txtMaPTCTPT.Text);
            bdsCTPhieuThue.EndEdit();
            
            cTPHIEUTHUETableAdapter.Update(this.DS.CTPHIEUTHUE);
            cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
            bdsCTPhieuThue.AddNew();
        }

        private void barbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void txtMaPTCTPT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
