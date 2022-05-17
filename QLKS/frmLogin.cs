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
    
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
            
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Program.conn.Open();
                String tk = txtUserName.Text;
                String mk = txtPassword.Text;
                String sql = "select *from NHANVIEN WHERE MANV = '"+tk+"' AND MATKHAU = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, Program.conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    new frmMain(dta.GetString(10), dta.GetString(0)).Show();
                    this.Close();
                    Program.conn.Close();
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
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
