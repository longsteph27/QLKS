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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Program.manv;
            txtOldPass.Focus();
        }

        private void DoiMatKhau()
        {
            String newPass = txtNewPass.Text;
            String tk = txtUserName.Text;
            String mk = txtOldPass.Text;
            String confirmPass = txtConfirmPass.Text;
            Program.conn.Open();
            String sqlSet = "UPDATE NHANVIEN SET MATKHAU = '" + newPass + "' WHERE MANV = '" + tk + "'";
            SqlCommand UD = new SqlCommand(sqlSet, Program.conn);
            UD.ExecuteNonQuery();
            MessageBox.Show("Thay đổi thành công!");
            Program.conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Program.conn.Open();
                String newPass = txtNewPass.Text;
                String tk = txtUserName.Text;
                String mk = txtOldPass.Text;
                String confirmPass = txtConfirmPass.Text;

                String sql = "select * from NHANVIEN WHERE MANV = '"+tk+"' AND MATKHAU = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, Program.conn);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    Program.conn.Close();
                    if ( confirmPass== newPass)
                    {
                        DoiMatKhau();                      
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp");
                        txtNewPass.Focus();                       
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác, vui lòng nhập lại!");
                    txtUserName.Focus();
                    Program.conn.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
