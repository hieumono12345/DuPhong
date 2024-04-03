using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimulationDevelopment.GUI;
using SimulationDevelopment.DAO;
using SimulationDevelopment.DTO;

namespace SimulationDevelopment
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Khởi tạo các usercontrol rỗng cho các chức năng ở menu
        ucBattleMap BattleMap;
        ucDigitalMapManagement DigitalMapManagement;
        ucUserInformationcs UserInformationcs;
        ucChangePassword ChangePassword;
        ucUserManagement UserManagement;
        ucUserRightsManagement UserRightsManagement;

        // Mở digital map management ở menu
        private void digitalMapManagement_Click(object sender, EventArgs e)
        {
            //nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (DigitalMapManagement == null)
            {
                DigitalMapManagement = new ucDigitalMapManagement();
                DigitalMapManagement.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(DigitalMapManagement);
                DigitalMapManagement.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                DigitalMapManagement.BringToFront();
            }
        }

        private void battleMap_Click(object sender, EventArgs e)
        {
            //nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (BattleMap == null)
            {
                BattleMap = new ucBattleMap();
                BattleMap.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(BattleMap);
                BattleMap.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                BattleMap.BringToFront();
            }

        }

        private void userInformation_Click(object sender, EventArgs e)
        {
            //nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (UserInformationcs == null)
            {
                UserInformationcs = new ucUserInformationcs();
                UserInformationcs.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(UserInformationcs);
                UserInformationcs.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                UserInformationcs.BringToFront();
            }
        }
        
        private void changePassword_Click(object sender, EventArgs e)
        {
            // nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (ChangePassword == null)
            {
                ChangePassword = new ucChangePassword();
                ChangePassword.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(ChangePassword);
                ChangePassword.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                ChangePassword.BringToFront();
            }
        }

        private void userManagement_Click(object sender, EventArgs e)
        {
            // nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (UserManagement == null)
            {
                UserManagement = new ucUserManagement();
                UserManagement.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(UserManagement);
                UserManagement.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                UserManagement.BringToFront();
            }
        }

        private void userRightsManagement_Click(object sender, EventArgs e)
        {
            // nếu chưa có usercontrol nào thì tạo mới và add vào form
            if (UserRightsManagement == null)
            {
                UserRightsManagement = new ucUserRightsManagement();
                UserRightsManagement.Dock = DockStyle.Fill;
                fluentDesignFormContainer.Controls.Add(UserRightsManagement);
                UserRightsManagement.BringToFront();
            }
            // nếu đã có usercontrol thì đưa lên trước
            else
            {
                UserRightsManagement.BringToFront();
            }
        }

        // Khi nhấn nút Thông tin người dùng
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfor infor = new frmInfor();
            infor.ShowDialog();
            ///show a
   

        }
    }
}
