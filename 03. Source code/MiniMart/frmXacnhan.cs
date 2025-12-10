using System;
using System.Windows.Forms;

namespace WINMART123
{
    public partial class frmXacNhan : Form
    {
        public bool XacNhan { get; private set; } = false;
        private Form frmHangHoa; // Tham chiếu đến form Hàng hóa

        public frmXacNhan(Form hangHoaForm)
        {
            InitializeComponent();
            frmHangHoa = hangHoaForm; // Lưu tham chiếu form Hàng hóa
        }

        private void bttxnco_Click(object sender, EventArgs e)
        {
            XacNhan = true;
            frmHangHoa?.Close(); // Đóng form Hàng hóa nếu nó tồn tại
            this.Close(); // Đóng form Xác nhận
        }

        private void bttxnkhong_Click(object sender, EventArgs e)
        {
            XacNhan = false;
            this.Close(); // Chỉ đóng form Xác nhận
        }
    }
}