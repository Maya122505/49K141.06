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
    public partial class frmNCC : Form
    {
        // Chuyển chuỗi kết nối sang tệp cấu hình (app.config) nếu có thể
        private string sConnect = "Data Source=LAPTOP-3BNCC4CF;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";

        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            // Sử dụng 'using' để đảm bảo giải phóng tài nguyên
            using (SqlConnection con = new SqlConnection(sConnect))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MaNCC AS N'Mã NCC', TenNCC AS N'Tên NCC', NCC_SDT AS N'Số điện thoại', NCC_DiaChi AS N'Địa chỉ' FROM NhaCungCap";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con))
                    {
                        // Đặt thời gian chờ cho câu truy vấn
                        adapter.SelectCommand.CommandTimeout = 60;

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "NCC");

                        // Kiểm tra xem bảng có dữ liệu không
                        if (ds.Tables["NCC"] != null && ds.Tables["NCC"].Rows.Count > 0)
                        {
                            dataGridViewNCC.DataSource = ds.Tables["NCC"];
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu để hiển thị.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi truy cập dữ liệu: {ex.Message}", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Ẩn các nút không cần thiết
            btnHuy.Visible = false;
            btnHuytim.Visible = false;
            btnTimKiem.Visible = false;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Khi bấm nút HUY thì tất cả các ô thông tin biến mất trừ ô tìm kiếm
            txtMaNCC.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtTenNCC.Text = "";
        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đưa thông tin lên các ô
            txtMaNCC.Text = dataGridViewNCC.Rows[e.RowIndex].Cells["Mã NCC"].Value.ToString();
            txtDC.Text = dataGridViewNCC.Rows[e.RowIndex].Cells["Địa chỉ"].Value.ToString();
            txtSDT.Text = dataGridViewNCC.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
            txtTenNCC.Text = dataGridViewNCC.Rows[e.RowIndex].Cells["Tên NCC"].Value.ToString();
            //Hiện nút HUY
            btnHuy.Visible = true;
            //Không cho phép sửa thông tin
            txtMaNCC.Enabled = false;
            txtDC.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNCC.Enabled = false;
        }

        private void txtNhapThongTin_Click(object sender, EventArgs e)
        {
            //Khi click vào thì dòng chữ biến mất để nhập
            txtNhapThongTin.Text = "";
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

            string sQuery = "SELECT MaNCC AS N'Mã NCC', TenNCC as N'Tên NCC', NCC_SDT as 'Số điện thoại', NCC_DiaChi as N'Địa chỉ'\r\n " +
                            "FROM NhaCungCap \r\n " +
                            "WHERE MaNCC = @textTimKiem OR TenNCC LIKE '%' + @textTimKiem +'%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            adapter.SelectCommand.Parameters.AddWithValue("@textTimKiem", txtNhapThongTin.Text);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "ThongTinCanTim");

            dataGridViewNCC.DataSource = ds.Tables["ThongTinCanTim"];

            con.Close();

        }

        private void btnHuytim_Click(object sender, EventArgs e)
        {
            //Khi bấm nút Huy thì ô sẽ quay lại ban đầu.
            txtNhapThongTin.Text = "Nhập mã hoặc tên nhà cung cấp...";
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

            string sQuery = "SELECT MaNCC AS N'Mã NCC', TenNCC as N'Tên NCC', NCC_SDT as 'Số điện thoại', NCC_DiaChi as N'Địa chỉ'\r\nFROM NhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "NCC");

            dataGridViewNCC.DataSource = ds.Tables["NCC"];

            con.Close();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {

        }
    }
}
