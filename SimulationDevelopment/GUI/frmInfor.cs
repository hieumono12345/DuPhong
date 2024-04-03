using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationDevelopment.GUI
{
    public partial class frmInfor : DevExpress.XtraEditors.XtraForm
    {
        public frmInfor()
        {
            InitializeComponent();
            //this.Size = new System.Drawing.Size(604, 425);
            this.Location = new System.Drawing.Point(1200, 85);

            // Vô hiệu hóa khả năng di chuyển form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MouseClick += MainForm_MouseClick;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem click có xảy ra ngoài form không
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                // Sự kiện click ngoài form đã xảy ra
                MessageBox.Show("Clicked outside the form!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit form
            this.Close();            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}