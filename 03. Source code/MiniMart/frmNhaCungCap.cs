using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyApp
{
    public partial class frmNhaCungCap : Form
    {
        string sCon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sQuery = "select * from NhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Nhà Cung Cấp");
            dataGridView1.DataSource = ds.Tables["Nhà Cung Cấp"];
            con.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sMaNCC = txtMNCC.Text.Trim();
                    string sTenNCC = txtTNCC.Text.Trim();
                    string sDiaChi = txtDC.Text.Trim();
                    string sSDT = txtSDT.Text.Trim();
                    string sQuery = "INSERT INTO NhaCungCap (MaNCC, TenNCC, NCC_DiaChi, NCC_SDT) VALUES (@MaNCC, @TenNCC, @NCC_DiaChi, @NCC_SDT)";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@MaNCC", sMaNCC);
                    cmd.Parameters.AddWithValue("@TenNCC", sTenNCC);
                    cmd.Parameters.AddWithValue("@NCC_DiaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@NCC_SDT", sSDT);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    frmNhaCungCap_Load(sender, e); // Tải lại dữ liệu
                    txtMNCC.Clear();
                    txtTNCC.Clear();
                    txtDC.Clear();
                    txtSDT.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }
                string sMaNCC = txtMNCC.Text;
                string sQuery = "delete NhaCungCap where MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("MaNCC", sMaNCC);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    frmNhaCungCap_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNCC = txtMNCC.Text.Trim();
            string sTenNCC = txtTNCC.Text.Trim();
            string sDiaChi = txtDC.Text.Trim();
            string sSDT = txtSDT.Text.Trim();
            string sQuery = "update NhaCungCap set TenNCC = @TenNCC, NCC_DiaChi = @NCC_DiaChi, NCC_SDT = @NCC_SDT where MaNCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNCC", sMaNCC);
            cmd.Parameters.AddWithValue("@TenNCC", sTenNCC);
            cmd.Parameters.AddWithValue("@NCC_DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@NCC_SDT", sSDT);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                frmNhaCungCap_Load(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật");
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            txtTNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNCC"].Value.ToString();
            txtDC.Text = dataGridView1.Rows[e.RowIndex].Cells["NCC_DiaChi"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["NCC_SDT"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            string sMaNCC = txtMNCC.Text.Trim();
            string sTenNCC = txtTNCC.Text.Trim();
            string sDiaChi = txtDC.Text.Trim();
            string sSDT = txtSDT.Text.Trim();
            string sQuery = "SELECT * FROM NhaCungCap WHERE 1=1";
            if (!string.IsNullOrEmpty(sMaNCC))
                sQuery += " AND MaNCC LIKE @MaNCC";
            if (!string.IsNullOrEmpty(sTenNCC))
                sQuery += " AND TenNCC LIKE @TenNCC";
            if (!string.IsNullOrEmpty(sDiaChi))
                sQuery += " AND NCC_DiaChi LIKE @NCC_DiaChi";
            if (!string.IsNullOrEmpty(sSDT))
                sQuery += " AND NCC_SDT LIKE @NCC_SDT";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            if (!string.IsNullOrEmpty(sMaNCC))
                cmd.Parameters.AddWithValue("@MaNCC", "%" + sMaNCC + "%");
            if (!string.IsNullOrEmpty(sTenNCC))
                cmd.Parameters.AddWithValue("@TenNCC", "%" + sTenNCC + "%");
            if (!string.IsNullOrEmpty(sDiaChi))
                cmd.Parameters.AddWithValue("@NCC_DiaChi", "%" + sDiaChi + "%");
            if (!string.IsNullOrEmpty(sSDT))
                cmd.Parameters.AddWithValue("@NCC_SDT", "%" + sSDT + "%");

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "NhaCungCap");
                dataGridView1.DataSource = ds.Tables["NhaCungCap"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tìm kiếm");
            }
            con.Close();
        }
        private string SinhMaNhaCungCap()
        {
            string maMoi = "NCC001";
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MAX(MaNCC) FROM NhaCungCap WHERE MaNCC LIKE 'NCC%'";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        string maCu = result.ToString();
                        int so = int.Parse(maCu.Substring(3));
                        maMoi = "NCC" + (so + 1).ToString("D3");
                    }
                }
                catch
                {
                    // Nếu có lỗi, trả về NCC001
                }
            }
            return maMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMNCC.Text = SinhMaNhaCungCap();
            txtTNCC.Clear();
            txtDC.Clear();
            txtSDT.Clear();
            txtTNCC.Focus();
        }
    }
}
