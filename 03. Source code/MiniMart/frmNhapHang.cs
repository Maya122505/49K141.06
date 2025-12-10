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
    public partial class frmNhapHang : Form
    {
        string sCon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        private DataTable dtLoHang;

        public frmNhapHang()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dtLoHang = new DataTable();
            dtLoHang.Columns.Add("MaLoHang", typeof(string));
            dtLoHang.Columns.Add("MaHH", typeof(string));
            dtLoHang.Columns.Add("SLNhap", typeof(int));
            dtLoHang.Columns.Add("GiaNhap", typeof(decimal));
            dtLoHang.Columns.Add("NgaySanXuat", typeof(DateTime));
            dtLoHang.Columns.Add("NgayHetHan", typeof(DateTime));
            dtLoHang.Columns.Add("MaNH", typeof(string));

        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Nạp danh sách Nhà Cung Cấp vào ComboBox
                    string sQueryNCC = "SELECT MaNCC, TenNCC FROM NhaCungCap";
                    SqlDataAdapter adapterNCC = new SqlDataAdapter(sQueryNCC, con);
                    DataTable dtNCC = new DataTable();
                    adapterNCC.Fill(dtNCC);
                    cbNCC.DataSource = dtNCC;
                    cbNCC.DisplayMember = "MaNCC"; // Hiển thị Mã Nhà Cung Cấp
                    cbNCC.ValueMember = "MaNCC";

                    // Nạp danh sách Nhân Viên vào ComboBox
                    string sQueryNV = "SELECT MaNV, TenNV FROM NhanVien";
                    SqlDataAdapter adapterNV = new SqlDataAdapter(sQueryNV, con);
                    DataTable dtNV = new DataTable();
                    adapterNV.Fill(dtNV);
                    cbNV.DataSource = dtNV;
                    cbNV.DisplayMember = "MaNV";
                    cbNV.ValueMember = "MaNV";

                    // Nạp danh sách Hàng Hóa vào ComboBox
                    string sQueryHH = "SELECT MaHH, TenHH FROM HangHoa";
                    SqlDataAdapter adapterHH = new SqlDataAdapter(sQueryHH, con);
                    DataTable dtHH = new DataTable();
                    adapterHH.Fill(dtHH);
                    if (dtHH.Rows.Count == 0)
                    {
                        MessageBox.Show("Bảng HangHoa hiện tại rỗng. Vui lòng thêm dữ liệu vào bảng HangHoa!");
                    }
                    cbMHH.DataSource = dtHH;
                    cbMHH.DisplayMember = "MaHH"; // Hiển thị Mã Hàng Hóa
                    cbMHH.ValueMember = "MaHH";

                    // Nạp dữ liệu từ bảng LoHang vào dataGridView2
                    string sQueryLoHang = "SELECT  TOP 100* FROM LoHang";
                    SqlDataAdapter adapterLoHang = new SqlDataAdapter(sQueryLoHang, con);
                    DataSet dsLoHang = new DataSet();
                    adapterLoHang.Fill(dsLoHang, "LoHang");
                    if (dsLoHang.Tables["LoHang"].Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng LoHang!");
                    }
                    else
                    {
                        dataGridView2.DataSource = dsLoHang.Tables["LoHang"];
                    }

                    // Nạp dữ liệu từ bảng NhapHang vào dataGridView1
                    string sQueryNhapHang = "SELECT TOP 100* FROM NhapHang";
                    SqlDataAdapter adapterNhapHang = new SqlDataAdapter(sQueryNhapHang, con);
                    DataSet dsNhapHang = new DataSet();
                    adapterNhapHang.Fill(dsNhapHang, "NhapHang");
                    if (dsNhapHang.Tables["NhapHang"].Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng NhapHang!");
                    }
                    else
                    {
                        dataGridView1.DataSource = dsNhapHang.Tables["NhapHang"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                }
            }
        }

        private void cbMHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMHH.SelectedIndex != -1) // Kiểm tra nếu có mục được chọn
            {
                DataRowView selectedRow = cbMHH.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    txtTHH.Text = selectedRow["TenHH"].ToString(); // Điền Tên Hàng Hóa
                }
            }
            else
            {
                txtTHH.Text = "";
            }
        }

        private string SinhMaNH()
        {
            string maMoi = "NH001";
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MAX(MaNH) FROM NhapHang WHERE MaNH LIKE 'NH%'";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        string maCu = result.ToString();
                        int so = int.Parse(maCu.Substring(2));
                        maMoi = "NH" + (so + 1).ToString("D3");
                    }
                }
                catch
                {
                    // Nếu có lỗi, trả về NH001
                }
            }
            return maMoi;
        }

        private string SinhMaLH()
        {
            string maMoi = "LH001";
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MAX(CAST(SUBSTRING(MaLoHang, 3, LEN(MaLoHang)-2) AS INT)) FROM LoHang WHERE MaLoHang LIKE 'LH%'";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    object result = cmd.ExecuteScalar();
                    int maxSo = 0;
                    if (result != DBNull.Value && result != null)
                    {
                        maxSo = Convert.ToInt32(result);
                    }

                    // Kiểm tra trùng với dtLoHang (DataTable chưa lưu)
                    foreach (DataRow row in dtLoHang.Rows)
                    {
                        string maLH = row["MaLoHang"].ToString();
                        if (maLH.StartsWith("LH"))
                        {
                            int so = int.Parse(maLH.Substring(2));
                            if (so > maxSo) maxSo = so;
                        }
                    }

                    maMoi = "LH" + (maxSo + 1).ToString("D3");
                }
                catch
                {
                    // Trả về LH001 nếu lỗi
                }
            }
            return maMoi;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            InitializeDataTable(); // Chỉ gọi 1 lần khi mở form
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InitializeDataTable(); // reset dtLoHang
            txtMNH.Text = SinhMaNH();
            cbNCC.SelectedIndex = -1;
            cbNV.SelectedIndex = -1;
            dtpNNhap.Value = DateTime.Now;

            // Reset các control nhập lô hàng
            txtMLH.Text = SinhMaLH();
            cbMHH.SelectedIndex = -1;
            txtTHH.Text = "";
            txtSL.Text = "";
            txtGiaNhap.Text = "";
            dtpNSX.Value = DateTime.Now;
            dtpNHH.Value = DateTime.Now;
        }

        private void btnLHM_Click(object sender, EventArgs e)
        {
            try
            {
                string maLoHang = txtMLH.Text.Trim();
                string maHH = cbMHH.SelectedValue?.ToString();
                string slText = txtSL.Text.Trim();
                string giaNhapText = txtGiaNhap.Text.Trim();

                if (string.IsNullOrEmpty(maLoHang) || string.IsNullOrEmpty(maHH))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã Lô Hàng, Mã Hàng Hóa!");
                    return;
                }

                if (!int.TryParse(slText, out int slNhap) || slNhap <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải là số nguyên dương.");
                    return;
                }

                if (!decimal.TryParse(giaNhapText, out decimal giaNhap) || giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập phải là số thập phân dương.");
                    return;
                }

                if (dtpNHH.Value <= dtpNSX.Value)
                {
                    MessageBox.Show("Ngày hết hạn phải lớn hơn ngày sản xuất.");
                    return;
                }

                // Thêm vào DataTable tạm
                DataRow row = dtLoHang.NewRow();
                row["MaLoHang"] = maLoHang;
                row["MaHH"] = maHH;
                row["SLNhap"] = slNhap;
                row["GiaNhap"] = giaNhap;
                row["NgaySanXuat"] = dtpNSX.Value;
                row["NgayHetHan"] = dtpNHH.Value;
                row["MaNH"] = txtMNH.Text.Trim();
                dtLoHang.Rows.Add(row);

                // Reset nhập lô hàng
                txtMLH.Text = SinhMaLH();
                cbMHH.SelectedIndex = -1;
                txtTHH.Text = "";
                txtSL.Text = "";
                txtGiaNhap.Text = "";
                dtpNSX.Value = DateTime.Now;
                dtpNHH.Value = DateTime.Now;

                MessageBox.Show("Đã thêm lô hàng vào danh sách tạm.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lô hàng: " + ex.Message);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtLoHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có lô hàng nào, không thể lưu phiếu nhập!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();

                    // Nếu có lô hàng thì mới lưu phiếu nhập
                    string sMaNH = txtMNH.Text.Trim();
                    string sMaNCC = cbNCC.SelectedValue?.ToString();
                    string sMaNV = cbNV.SelectedValue?.ToString();
                    DateTime ngayNhap = dtpNNhap.Value;

                    string sQueryNH = "INSERT INTO NhapHang (MaNH, MaNCC, MaNV, NgNhap) VALUES (@MaNH, @MaNCC, @MaNV, @NgayNhap)";
                    SqlCommand cmdNH = new SqlCommand(sQueryNH, con);
                    cmdNH.Parameters.AddWithValue("@MaNH", sMaNH);
                    cmdNH.Parameters.AddWithValue("@MaNCC", sMaNCC);
                    cmdNH.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmdNH.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    cmdNH.ExecuteNonQuery();

                    // Sau đó lưu lô hàng
                    foreach (DataRow row in dtLoHang.Rows)
                    {
                        string sMaLoHang = row["MaLoHang"].ToString();
                        string sMaHH = row["MaHH"].ToString();
                        int slNhap = Convert.ToInt32(row["SLNhap"]);
                        decimal giaNhap = Convert.ToDecimal(row["GiaNhap"]);
                        DateTime ngaySX = Convert.ToDateTime(row["NgaySanXuat"]);
                        DateTime ngayHH = Convert.ToDateTime(row["NgayHetHan"]);

                        string sQueryLH = "INSERT INTO LoHang (MaLoHang, MaNH, MaHH, SLNhap, GiaNhap, NgSanXuat, NgHetHan) " +
                                          "VALUES (@MaLoHang, @MaNH, @MaHH, @SLNhap, @GiaNhap, @NgaySanXuat, @NgayHetHan)";
                        SqlCommand cmdLH = new SqlCommand(sQueryLH, con);
                        cmdLH.Parameters.AddWithValue("@MaLoHang", sMaLoHang);
                        cmdLH.Parameters.AddWithValue("@MaNH", sMaNH);
                        cmdLH.Parameters.AddWithValue("@MaHH", sMaHH);
                        cmdLH.Parameters.AddWithValue("@SLNhap", slNhap);
                        cmdLH.Parameters.AddWithValue("@GiaNhap", giaNhap);
                        cmdLH.Parameters.AddWithValue("@NgaySanXuat", ngaySX);
                        cmdLH.Parameters.AddWithValue("@NgayHetHan", ngayHH);
                        cmdLH.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã lưu phiếu nhập và các lô hàng thành công!");
                btnThem_Click(sender, e); // Reset form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sMaNH = txtMNH.Text.Trim();
                    string sMaLH = txtMLH.Text.Trim(); // Thêm ô tìm kiếm cho mã lô hàng

                    string sQuery = "SELECT * FROM NhapHang WHERE 1=1";

                    if (!string.IsNullOrEmpty(sMaNH))
                        sQuery += " AND MaNH LIKE @MaNH";
                    if (!string.IsNullOrEmpty(sMaLH))
                        sQuery += " AND MaLoHang LIKE @MaLoHang"; // Tìm kiếm theo mã lô hàng

                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    if (!string.IsNullOrEmpty(sMaNH))
                        cmd.Parameters.AddWithValue("@MaNH", "%" + sMaNH + "%");
                    if (!string.IsNullOrEmpty(sMaLH))
                        cmd.Parameters.AddWithValue("@MaLoHang", "%" + sMaLH + "%"); // Gán giá trị cho mã lô hàng

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Cập nhật dataGridView2 để hiển thị các lô hàng tương ứng
                    if (dt.Rows.Count > 0)
                    {
                        string maNH = dt.Rows[0]["MaNH"].ToString(); // Lấy mã nhập hàng từ kết quả tìm kiếm
                        LoadLoHang(maNH); // Tải các lô hàng tương ứng
                    }
                    else
                    {
                        dataGridView2.DataSource = null; // Không có kết quả tìm kiếm
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình tìm kiếm: " + ex.Message);
                }
            }
        }

        // Phương thức để tải các lô hàng tương ứng với mã nhập hàng
        private void LoadLoHang(string maNH)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQueryLoHang = "SELECT * FROM LoHang WHERE MaNH = @MaNH";
                    SqlCommand cmdLoHang = new SqlCommand(sQueryLoHang, con);
                    cmdLoHang.Parameters.AddWithValue("@MaNH", maNH);
                    SqlDataAdapter adapterLoHang = new SqlDataAdapter(cmdLoHang);
                    DataTable dtLoHang = new DataTable();
                    adapterLoHang.Fill(dtLoHang);
                    dataGridView2.DataSource = dtLoHang; // Hiển thị các lô hàng tương ứng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải lô hàng: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    string sMaNH = txtMNH.Text.Trim();

                    // Cập nhật thông tin NhapHang
                    string sUpdateNH = "UPDATE NhapHang SET MaNCC=@MaNCC, MaNV=@MaNV, NgNhap=@NgNhap WHERE MaNH=@MaNH";
                    SqlCommand cmdNH = new SqlCommand(sUpdateNH, con);
                    cmdNH.Parameters.AddWithValue("@MaNCC", cbNCC.SelectedValue?.ToString());
                    cmdNH.Parameters.AddWithValue("@MaNV", cbNV.SelectedValue?.ToString());
                    cmdNH.Parameters.AddWithValue("@NgNhap", dtpNNhap.Value);
                    cmdNH.Parameters.AddWithValue("@MaNH", sMaNH);
                    cmdNH.ExecuteNonQuery();

                    // Cập nhật LoHang: nếu muốn chỉnh sửa, cần biết rõ các tiêu chí nào thay đổi
                    // Ở đây, giả sử không thay đổi LoHang, hoặc bạn có thể cập nhật từng LoHang

                    MessageBox.Show("Cập nhật thành công");
                    // Reload dữ liệu
                    frmNhapHang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình cập nhật: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();
                        string sMaNH = txtMNH.Text.Trim();

                        // Xóa các lô hàng liên quan
                        string sDeleteLo = "DELETE FROM LoHang WHERE MaNH = @MaNH";
                        SqlCommand cmdLo = new SqlCommand(sDeleteLo, con);
                        cmdLo.Parameters.AddWithValue("@MaNH", sMaNH);
                        cmdLo.ExecuteNonQuery();

                        // Xóa phiếu nhập
                        string sDeleteNH = "DELETE FROM NhapHang WHERE MaNH = @MaNH";
                        SqlCommand cmdNH = new SqlCommand(sDeleteNH, con);
                        cmdNH.Parameters.AddWithValue("@MaNH", sMaNH);
                        int rows = cmdNH.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            // Reload dữ liệu
                            frmNhapHang_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã phiếu nhập để xóa");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình xóa: " + ex.Message);
                    }
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex]; // Sửa lại để lấy từ dataGridView1

                txtMNH.Text = row.Cells["MaNH"].Value?.ToString() ?? "";
                cbNCC.SelectedValue = row.Cells["MaNCC"].Value?.ToString() ?? "";
                cbNV.SelectedValue = row.Cells["MaNV"].Value?.ToString() ?? "";
                // xử lý ngày nhập
                if (DateTime.TryParse(row.Cells["NgNhap"].Value?.ToString(), out DateTime ngayNhap))
                {
                    dtpNNhap.Value = ngayNhap;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex]; // Sửa lại để lấy từ dataGridView2

                txtMLH.Text = row.Cells["MaLoHang"].Value?.ToString() ?? "";
                txtMNH.Text = row.Cells["MaNH"].Value?.ToString() ?? "";
                cbMHH.SelectedValue = row.Cells["MaHH"].Value?.ToString() ?? "";
                txtSL.Text = row.Cells["SLNhap"].Value?.ToString() ?? "";
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString() ?? "";

                // Xử lý ngày sản xuất
                if (DateTime.TryParse(row.Cells["NgaySanXuat"].Value?.ToString(), out DateTime ngaySX))
                {
                    dtpNSX.Value = ngaySX;
                }

                // Ngày hết hạn
                if (DateTime.TryParse(row.Cells["NgayHetHan"].Value?.ToString(), out DateTime ngayHH))
                {
                    dtpNHH.Value = ngayHH;
                }
            }
        }
        
        
    }
}