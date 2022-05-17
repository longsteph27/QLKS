using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void dICHVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICHVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;
            this.dICHVUTableAdapter.Connection = Program.conn;
            this.cTDICHVUTableAdapter.Fill(this.DS.CTDICHVU);
            this.cTDICHVUTableAdapter.Connection = Program.conn;
            this.dICHVUTableAdapter.Fill(this.DS.DICHVU);

        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mADVLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
