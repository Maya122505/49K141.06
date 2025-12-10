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
    public partial class NhanVien : Form
    {
        string sCon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public NhanVien()
        {
        

            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadData(string sMaNV = null)
        {
            using (SqlConnection con = new(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery;
                    if (!string.IsNullOrEmpty(sMaNV))
                    {
                        // Lọc dữ liệu theo mã khách hàng nếu có
                        sQuery = "SELECT * FROM NhanVien WHERE manv = @Manv";
                        using (SqlDataAdapter adapter = new(sQuery, con))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@Manv", sMaNV);
                            DataSet ds = new();
                            adapter.Fill(ds, "NhanVien");
                            if (ds.Tables["NhanVien"]?.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables["NhanVien"];
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy NhanVien.", "THÔNG BÁO",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                    else
                    {
                        // Hiển thị toàn bộ dữ liệu nếu không có mã khách hàng
                        sQuery = "SELECT * FROM Nhanvien";
                        using (SqlDataAdapter adapter = new(sQuery, con))
                        {
                            DataSet ds = new();
                            adapter.Fill(ds, "NhanVien");
                            if (ds.Tables["NhanVien"]?.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables["NhanVien"];
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu khách Nhân viên.", "THÔNG BÁO",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối DB: {ex.Message}", "LỖI",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GenerateMaNhanVien()
        {
            string newMa = "NV000001";
            using (SqlConnection con = new SqlConnection(sCon))
            {
                string query = "SELECT TOP 1 MaNV FROM NhanVien WHERE MaNV LIKE 'NV%' ORDER BY MaNV DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastMa = result.ToString().Trim(); // Ví dụ: NV015
                    if (lastMa.Length >= 3 && int.TryParse(lastMa.Substring(2), out int number))
                    {
                        number++;
                        newMa = "NV" + number.ToString("D6");
                    }
                }
            }
            return newMa;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            /* string sMaNV = textBox1.Text.Trim();

             // Giả sử sMaNV là một chuỗi đã được lấy từ đâu đó, ví dụ từ một TextBox.

             if (sMaNV.Length == 8 )
             {
                 MessageBox.Show("Mã nhân viên hợp lệ: " + sMaNV);
             }
             else
             {
                 MessageBox.Show("Mã nhân viên không hợp lệ! ");
                 return;
             }*/

            string tenNV = textBox2.Text.Trim();
            string chucVu = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(chucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(sCon);
            {
                try
                {
                    con.Open();

                    // Kiểm tra tên nhân viên đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE TenNV = @TenNV";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@TenNV", tenNV);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string maNV = GenerateMaNhanVien();

                    string insertQuery = "INSERT INTO NhanVien (MaNV, TenNV, ChucVu) VALUES (@MaNV, @TenNV, @Chucvu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Giả sử có hàm load dữ liệu nhân viên

                        // Xóa các ô nhập
                        textBox2.Clear();
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim(); // TextBox cho mã nhân viên
            string tenNV = textBox2.Text.Trim();
            string chucVu = comboBox1.SelectedItem?.ToString();

            // Kiểm tra thông tin đầy đủ
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(chucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra chức vụ hợp lệ
            if (chucVu != "Nhân Viên" && chucVu != "Quản Lý")
            {
                MessageBox.Show("Chức vụ không hợp lệ. Vui lòng chọn lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Kiểm tra mã nhân viên có tồn tại không
                string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @Ma";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Ma", maNV);
                int exist = (int)checkCmd.ExecuteScalar();

                if (exist == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trùng tên (trừ chính mã nhân viên đang sửa)
                string dupQuery = "SELECT COUNT(*) FROM NhanVien WHERE TenNV = @Ten AND MaNV != @Ma";
                SqlCommand dupCmd = new SqlCommand(dupQuery, con);
                dupCmd.Parameters.AddWithValue("@Ten", tenNV);
                dupCmd.Parameters.AddWithValue("@Ma", maNV);
                int dup = (int)dupCmd.ExecuteScalar();

                if (dup > 0)
                {
                    MessageBox.Show("Tên nhân viên đã tồn tại. Vui lòng nhập tên khác.", "Trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật nhân viên
                string updateQuery = "UPDATE NhanVien SET TenNV = @Ten, ChucVu = @ChucVu WHERE MaNV = @Ma";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Ten", tenNV);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                cmd.Parameters.AddWithValue("@Ma", maNV);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ;
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim(); // Lấy mã nhân viên từ TextBox

            // Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Không tìm thấy nhân viên với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề cột
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["manv"].Value?.ToString();
                comboBox1.Text = row.Cells["ChucVu"].Value?.ToString(); // hoặc "LoaiNV"*/
                textBox2.Text = row.Cells["tennv"].Value?.ToString();
            }
        }
    }
}

