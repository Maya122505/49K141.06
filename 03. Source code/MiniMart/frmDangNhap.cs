using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WINMART
{

    public partial class frmDANGNHAP : Form
    {
        bool hienMK;
        public frmDANGNHAP()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string sAdmin = this.txtTenDN.Text;
            string sPass = this.txtMK.Text;

            //Kiểm tra trước khi nhập dữ liệu
            string Check = "True";
            if (sAdmin == "")
            {
                labelCheckTenDN.Visible = true;
                Check = "Thiếu TT";
            }
            if (sPass == "")
            {
                labelCheckMK.Visible = true;
                Check = "Thiếu TT";
            }
            //Nếu thiếu thông tin thì dừng hoạt động
            if (Check == "Thiếu TT")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sConnect = $"Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=False;User ID={sAdmin};Password={sPass};Encrypt=True;Trust Server Certificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(sConnect))
                {
                    conn.Open(); // thử kết nối
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    this.Hide();
                    frmTrangChu.ShowDialog();  // hiện form3 ở dạng modal
                    this.Show();         // hiện lại form2 sau khi form3 đóng
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDANGNHAP_Load(object sender, EventArgs e)
        {
            //Ẩn các nút check và hiện mật khẩu
            labelCheckTenDN.Visible = false;
            labelCheckMK.Visible = false;
            btnHienMK.Visible = false;  
        }
        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            //Hiển mật khẩu dưới dạng ẩn
            txtMK.UseSystemPasswordChar = true;
            //Hiện nút để hiện mật khẩu
            btnHienMK.Visible = true;
            //Gán hiện mật khẩu bằng false
            hienMK = false;

        }
        private void btnHienMK_Click(object sender, EventArgs e)
        {
            if (hienMK)
            {
                // Ẩn mật khẩu
                txtMK.UseSystemPasswordChar = true;
                btnHienMK.Text = "🙈"; // Hoặc đổi icon về con mắt đóng
                hienMK = false;
            }
            else
            {
                // Hiện mật khẩu
                txtMK.UseSystemPasswordChar = false;
                btnHienMK.Text = "👁"; // Hoặc đổi icon về con mắt mở
                hienMK = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtTenDN.Text = "";
            //Trả nút hiện mật khẩu về ban đầu và ẩn đi
            btnHienMK.Text = "🙈";
            btnHienMK.Visible = false ;



        }
    }
}
