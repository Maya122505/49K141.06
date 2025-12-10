using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace WINMART
{
    public partial class frmCongNo : Form
    {
        public string sConnect = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmCongNo()
        {
            InitializeComponent();
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            //Lúc bật form lên ẩn đi các nút CHI TIẾT, TÌM, HỦY, TÌM THEO MA, HUYTIM
            btnCTN.Visible = false;
            btnTimKiem.Visible = false;
            btnHuy.Visible = false;
            btnHuytim.Visible = false;
            btnTimKiem.Visible = false;
            //Fill dữ liệu vào datagridview
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sQuery = "SELECT MANO AS 'Mã nợ', Tongtienno AS 'Tổng tiền nợ', MaNCC AS 'Mã NCC'\r\nFROM TongNo";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "TongNo");

            dataGridViewTongNo.DataSource = ds.Tables["TongNo"];

            con.Close();
        }

        private void dataGridViewTongNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi bấm vào hiện thông tin lên ô tìm kiếm
            txtMaNo.Text = dataGridViewTongNo.Rows[e.RowIndex].Cells["Mã nợ"].Value.ToString();
            txtMaNCC.Text = dataGridViewTongNo.Rows[e.RowIndex].Cells["Mã NCC"].Value.ToString();
            txtTongTN.Text = dataGridViewTongNo.Rows[e.RowIndex].Cells["Tổng tiền nợ"].Value.ToString();
            //Không cho phép sửa thông tin.
            txtMaNo.Enabled = false;
            txtMaNCC.Enabled = false;
            txtTongTN.Enabled = false;
            //Điều chỉnh để khi bấm vào một dòng nhất định thì sẽ xuất hiện nút CHI TIẾT và TRẢ NỢ
            btnCTN.Visible = true;
            btnTN.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Khi bấm nút hủy thì các ô thông tin sẽ quay lại ban đầu
            txtMaNCC.Text = "";
            txtMaNo.Text = "";
            txtTongTN.Text = "";
            //Đồng thời biến mất đi các nút LƯU, CHI TIẾT, HỦY
            btnCTN.Visible = false;
            btnTN.Visible = false;
            btnHuy.Visible = false;
        }



        private void txtNhapMaNo_Click(object sender, EventArgs e)
        {
            //Khi click vào thì dòng chữ biến mất để nhập
            txtNhapMaNo.Text = "";
            //Hiển thị nút tìm và hủy
            btnTimKiem.Visible = true;
            btnHuytim.Visible = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sQuery = "SELECT MANO AS 'Mã nợ', Tongtienno AS 'Tổng tiền nợ', MaNCC AS 'Mã NCC'\r\n  " +
                            "FROM TONGNO WHERE MANO = @MANOCANTIM";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            adapter.SelectCommand.Parameters.AddWithValue("@MANOCANTIM", txtNhapMaNo.Text);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "MaNoCanTim");

            dataGridViewTongNo.DataSource = ds.Tables["MaNoCanTim"];

            con.Close();
        }

        private void btnHuytim_Click(object sender, EventArgs e)
        {
            //Khi bấm nút Huy thì ô sẽ quay lại ban đầu.
            txtNhapMaNo.Text = "Nhập mã nợ......";
            //Bảng datagirdview quay lại ban đầu
            //Lúc bật form lên ẩn đi các nút CHI TIẾT, TÌM, HỦY, TÌM THEO MA, HUYTIM

            //Fill dữ liệu vào datagridview
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sQuery = "SELECT MANO AS 'Mã nợ', Tongtienno AS 'Tổng tiền nợ', MaNCC AS 'Mã NCC'\r\nFROM TongNo";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "TongNo");

            dataGridViewTongNo.DataSource = ds.Tables["TongNo"];

            con.Close();
        }
        private void btnCTN_Click(object sender, EventArgs e)
        {
            frmChiTietNo frmCTN = new frmChiTietNo();
            frmCTN.sMaNo = txtMaNo.Text;   //Lấy giá trị MaNo từ from TongNo
            this.Hide();
            frmCTN.ShowDialog();
            this.Show();
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            frmTraNo frmTraNo = new frmTraNo();
            frmTraNo.Show();
            this.Close();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}

