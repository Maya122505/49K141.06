using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINMART123;
using MyApp;
using btapR5;
using WINMART;

namespace WINMART
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            frmCongNo frmCongNo = new frmCongNo();

            frmCongNo.Show();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang KhachHang = new frmKhachHang();
            KhachHang.Show();

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.Show();
        }

        private void btnLSG_Click(object sender, EventArgs e)
        {
            frmLichSuGia lsg = new frmLichSuGia();
            lsg.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang nh = new frmNhapHang();
            nh.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang bh = new frmBanHang();
            bh.Show();
        }
    }
}
