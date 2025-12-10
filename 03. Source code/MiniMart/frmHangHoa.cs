using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WINMART123
{
    public partial class frmHangHoa : Form
    {
        string scon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmHangHoa()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Columns["MaHH"].HeaderText = "Mã hàng";
            dataGridView1.Columns["TenHH"].HeaderText = "Tên hàng";
            dataGridView1.Columns["DVT"].HeaderText = "Đơn vị tính";
            dataGridView1.Columns["TongSoLuongHangTon"].HeaderText = "Số lượng hàng tồn";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);

        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(scon))
                {
                    string sQuery = "SELECT * FROM HangHoa";
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Cập nhật lưới
                    dataGridView1.DataSource = dt;

                    // Bắt buộc để cột hiện ra nếu không thiết kế thủ công
                    dataGridView1.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn CSDL: " + ex.Message);
            }
        }



            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void frmHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private string GenerateMaHangHoa()
        {
            string newMa = "HH001";
            using (SqlConnection con = new SqlConnection(scon))
            {
                string query = "SELECT TOP 1 MaHH FROM HangHoa ORDER BY MaHH DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastMa = result.ToString(); // Ví dụ: HH012
                    int number = int.Parse(lastMa.Substring(2)) + 1;
                    newMa = "HH" + number.ToString("D3"); // D3: đảm bảo 3 chữ số
                }
            }
            return newMa;
        }

        private void bttthemhh_Click(object sender, EventArgs e)
        {
            string tenHH = txtTenhh.Text.Trim();
            string donViTinh = txtdvt.Text.Trim();
            string soLuongText = txtsoluonght.Text.Trim();

            if (string.IsNullOrEmpty(tenHH) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(soLuongText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa.", "Thông báo thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soLuongText, out int soLuongTon))
            {
                MessageBox.Show("Số lượng tồn phải là một số nguyên hợp lệ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra xem tên hàng hóa đã tồn tại hay chưa
                    string checkQuery = "SELECT COUNT(*) FROM HangHoa WHERE TenHH = @Ten";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@Ten", tenHH);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Hàng hóa này đã tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string maHH = GenerateMaHangHoa();

                    string insertQuery = "INSERT INTO HangHoa (MaHH, TenHH, DVT, TongSoLuongHangTon) VALUES (@Ma, @Ten, @DVT, @SL)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Ma", maHH);
                    cmd.Parameters.AddWithValue("@Ten", tenHH);
                    cmd.Parameters.AddWithValue("@DVT", donViTinh);
                    cmd.Parameters.AddWithValue("@SL", soLuongTon);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();

                        // Xóa các ô nhập
                        txtTenhh.Clear();
                        txtdvt.Clear();
                        txtsoluonght.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm hàng hóa. Vui lòng thử lại.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm hàng hóa: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void bttsua_Click_1(object sender, EventArgs e)
        {
            string maHH = txtMahh.Text.Trim(); // TextBox cho mã hàng hóa
            string tenHH = txtTenhh.Text.Trim();
            string donViTinh = txtdvt.Text.Trim();
            string soLuongText = txtsoluonght.Text.Trim();

            // Kiểm tra xem tất cả các trường có được nhập đầy đủ không
            if (string.IsNullOrEmpty(maHH) || string.IsNullOrEmpty(tenHH) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(soLuongText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa.", "Thông báo thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng tồn có phải là số nguyên không âm không
            if (!int.TryParse(soLuongText, out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn phải là một số nguyên không âm.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra mã hàng hóa có tồn tại không
                    string checkExistQuery = "SELECT COUNT(*) FROM HangHoa WHERE MaHH = @Ma";
                    SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, con);
                    checkExistCmd.Parameters.AddWithValue("@Ma", maHH);
                    int existCount = (int)checkExistCmd.ExecuteScalar();

                    if (existCount == 0)
                    {
                        MessageBox.Show("Mã hàng hóa không tồn tại. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra tên hàng hóa có trùng với hàng hóa khác không (trừ hàng hóa đang sửa)
                    string checkDuplicateQuery = "SELECT COUNT(*) FROM HangHoa WHERE TenHH = @Ten AND MaHH != @Ma";
                    SqlCommand checkDuplicateCmd = new SqlCommand(checkDuplicateQuery, con);
                    checkDuplicateCmd.Parameters.AddWithValue("@Ten", tenHH);
                    checkDuplicateCmd.Parameters.AddWithValue("@Ma", maHH);
                    int duplicateCount = (int)checkDuplicateCmd.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Tên hàng hóa đã tồn tại. Vui lòng nhập tên khác.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật thông tin hàng hóa
                    string updateQuery = "UPDATE HangHoa SET TenHH = @Ten, DVT = @DVT, TongSoLuongHangTon = @SL WHERE MaHH = @Ma";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@Ten", tenHH);
                    cmd.Parameters.AddWithValue("@DVT", donViTinh);
                    cmd.Parameters.AddWithValue("@SL", soLuongTon);
                    cmd.Parameters.AddWithValue("@Ma", maHH);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Sửa thông tin hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Tải lại dữ liệu để cập nhật giao diện

                        // Xóa các ô nhập liệu
                        txtMahh.Clear();
                        txtTenhh.Clear();
                        txtdvt.Clear();
                        txtsoluonght.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa thông tin hàng hóa. Vui lòng thử lại.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi sửa thông tin hàng hóa: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttxoahh_Click(object sender, EventArgs e)
        {
            string maHH = txtMahh.Text.Trim(); // Lấy mã hàng hóa từ TextBox
            string tenHH = txtTenhh.Text.Trim(); // Lấy tên hàng hóa từ TextBox

            // Kiểm tra điều kiện nhập: mã và tên không được để trống
            if (string.IsNullOrEmpty(maHH) || string.IsNullOrEmpty(tenHH))
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa và tên hàng hóa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra xem hàng hóa có tồn tại không
                    string checkQuery = "SELECT COUNT(*) FROM HangHoa WHERE MaHH = @MaHH AND TenHH = @TenHH";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@MaHH", maHH);
                    checkCmd.Parameters.AddWithValue("@TenHH", tenHH);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hàng hóa với mã và tên đã nhập.", "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thực hiện xóa hàng hóa
                    string deleteQuery = "DELETE FROM HangHoa WHERE MaHH = @MaHH AND TenHH = @TenHH";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@MaHH", maHH);
                    deleteCmd.Parameters.AddWithValue("@TenHH", tenHH);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Cập nhật lại giao diện (giả sử có hàm LoadData)
                    }
                    else
                    {
                        MessageBox.Show("Xóa hàng hóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btttimkiemhh_Click(object sender, EventArgs e)
        {
            string maHH = txtMahh.Text.Trim(); // Lấy và loại bỏ khoảng trắng thừa
            string tenHH = txtTenhh.Text.Trim();

            // Kiểm tra điều kiện nhập liệu
            if (string.IsNullOrEmpty(maHH) || string.IsNullOrEmpty(tenHH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã hàng hóa và tên hàng hóa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();
                    // Truy vấn tìm kiếm hàng hóa
                    string query = "SELECT * FROM HangHoa WHERE MaHH = @MaHH AND TenHH = @TenHH";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaHH", maHH);
                    cmd.Parameters.AddWithValue("@TenHH", tenHH);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Hiển thị dòng tìm kiếm trong DataGridView
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Xóa DataGridView và thông báo thất bại
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Không tìm thấy hàng hóa với mã và tên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMahh_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
