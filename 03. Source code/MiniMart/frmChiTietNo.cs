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

    public partial class frmChiTietNo : Form
    {
        string sConnect = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmChiTietNo()
        {
            InitializeComponent();
        }

        private void dataGridViewCTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNo.Text = dataGridViewCTN.Rows[e.RowIndex].Cells["Mã nợ"].Value.ToString();
            txtMaNH.Text = dataGridViewCTN.Rows[e.RowIndex].Cells["Mã nhập hàng"].Value.ToString();
            txtChuaTT.Text = dataGridViewCTN.Rows[e.RowIndex].Cells["Số tiền còn nợ"].Value.ToString();
            txtDaTT.Text = dataGridViewCTN.Rows[e.RowIndex].Cells["Số tiền đã trả"].Value.ToString();

            btnHuy.Visible = true; //Lúc chọn vào một dòng trong datagridview thì hiện nút hủy lên


            //Không cho phép sửa thông tin
            txtChuaTT.Enabled = false;
            txtDaTT.Enabled = false;
            txtMaNH.Enabled = false;
            txtMaNo.Enabled = false;
        }

        private void CTN_Load(object sender, EventArgs e)
        {
            //Lúc bật form lên ẩn đi các nút CHI TIẾT, TÌM, HỦY, TÌM THEO MA, HUYTIM
            btnHuy.Visible = false;

            //Hiển thị thông tin của những mã nhập hàng có mã nợ được chọn ở bảng TongNo
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (sMaNo != null)
            {
                string sQuery = "SELECT MaNH AS 'Mã nhập hàng', MaNo as 'Mã nợ', SoTienDaTra as 'Số tiền đã trả', SoTienConNo as 'Số tiền còn nợ'\r\n" +
                                "FROM CT_No where MaNo = @MaNo";

                SqlDataAdapter a = new SqlDataAdapter(sQuery, con);
                a.SelectCommand.Parameters.AddWithValue("@MaNo", sMaNo);

                DataSet ds = new DataSet();
                a.Fill(ds, "ChiTietNo");

                dataGridViewCTN.DataSource = ds.Tables["ChiTietNo"];
            }
            else if (sMaNo != null)
            {
                string sQuery = "SELECT MaNH AS 'Mã nhập hàng', MaNo as 'Mã nợ', SoTienDaTra as 'Số tiền đã trả', SoTienConNo as 'Số tiền còn nợ'\r\nFROM CT_No";
                SqlDataAdapter a = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                a.Fill(ds, "ChiTietNo");

                dataGridViewCTN.DataSource = ds.Tables["ChiTietNo"];
            }


            btnHuy.Visible = false; //Lúc vừa bật form lên thì ẩn đi nút Huy

            con.Close();

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();       //Khi bấm nút quay lại sẽ đóng form
        }

        private void CTN_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmCongNo frmTN = new frmCongNo();      //Trong lúc đóng form thì sẽ bật lại form TongNo
            frmTN.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNo.Text = "";
            txtMaNH.Text = "";
            txtChuaTT.Text = "";
            txtDaTT.Text = "";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmTrangChu frmTrangChu = new frmTrangChu();
            frmTrangChu.Show();
            this.Close();
        }
    }
}
