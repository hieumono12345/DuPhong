using Microsoft.Win32;
using SimulationDevelopment.DAO;
using SimulationDevelopment.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DevExpress.Skins.SolidColorHelper;

namespace SimulationDevelopment.GUI
{
    public partial class ucDigitalMapManagement : UserControl
    {
        public ucDigitalMapManagement()
        {
            InitializeComponent();
            load();
            btnDetail.Click += BtnDetail_Click;
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            
            // Biding dữ liệu từ gridview vào các textbox
            txtKichThuoc.Text = gridView1.GetFocusedRowCellValue("KichThuoc").ToString();
            txtMoTa.Text = gridView1.GetFocusedRowCellValue("MoTa").ToString();
            txtTenBanDo.Text = gridView1.GetFocusedRowCellValue("TenBanDo").ToString();
            txtToaDo.Text = gridView1.GetFocusedRowCellValue("ToaDo").ToString();
            txtFilePath.Text = gridView1.GetFocusedRowCellValue("FilePath").ToString();
            string filePath = gridView1.GetFocusedRowCellValue("FilePathImg").ToString();
            // Nếu filePath rỗng thì không hiển thị ảnh
            if (filePath == "")
            {
                pictureBoxMap.Image = null;
                return;
            }   
            
            byte[] imageBytes = File.ReadAllBytes(filePath);
            using (var ms = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(ms);
                pictureBoxMap.Image = image;
            }
        }

        void load()
        {
            gcDigitalMap.DataSource= DigitalMapDAO.Instance.getAllDigitaMap();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = "c:\\"; // Đường dẫn mặc định khi mở hộp thoại
            xtraOpenFileDialog1.Filter = "Tất cả các tệp tin (*.*)|*.*"; // Bộ lọc tệp tin
            xtraOpenFileDialog1.FilterIndex = 1; // Chỉ định bộ lọc mặc định

            // Nếu không chọn file thì không làm gì cả
            if (xtraOpenFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filePath = xtraOpenFileDialog1.FileName;
            // Sử dụng đường dẫn tệp tin ở đây
            txtFilePath.Text = filePath;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = "C:\\Users\\PC\\Desktop\\"; // Đường dẫn mặc định khi mở hộp thoại
            xtraOpenFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"; // Bộ lọc tệp tin C:\Users\PC\Desktop
            xtraOpenFileDialog1.FilterIndex = 1; // Chỉ định bộ lọc mặc định

            // Nếu không chọn file thì không làm gì cả
            if (xtraOpenFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
                
            }

            string filePath = xtraOpenFileDialog1.FileName;
            // Chuyển đổi ảnh sang dạng mảng byte
            byte[] imageBytes = File.ReadAllBytes(filePath);

            // Hiển thị ảnh
            using (var ms = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(ms);
                pictureBoxMap.Image = image;
            }
        }
    }
}
