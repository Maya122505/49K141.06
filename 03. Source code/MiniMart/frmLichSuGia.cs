using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINMART123
{
    public partial class frmLichSuGia : Form
    {
        string scon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmLichSuGia()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dtbdgia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmLichSuGia_Load(object sender, EventArgs e)
        {
            cbloc.Items.Add("Tăng dần");
            cbloc.Items.Add("Giảm dần");

            LoadData();
            dataGridView1.Columns["MaLSG"].HeaderText = "Mã lịch sử giá";
            dataGridView1.Columns["NgayBDGia"].HeaderText = "Ngày bắt đầu giá";
            dataGridView1.Columns["NgayKTGia"].HeaderText = "Ngày kết thúc giá";
            dataGridView1.Columns["LSG_GiaBan"].HeaderText = "LSG_Giá bán";
            dataGridView1.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
        }
        private void cbloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloc.SelectedItem != null)
            {
                lblSortStatus.Text = cbloc.SelectedItem.ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(scon))
                {
                    string sQuery = "SELECT MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia ORDER BY MaLSG";
                    if (cbloc.SelectedItem != null)
                    {
                        if (cbloc.SelectedItem.ToString() == "Tăng dần")
                        {
                            sQuery = "SELECT MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia ORDER BY MaLSG ASC";
                        }
                        else if (cbloc.SelectedItem.ToString() == "Giảm dần")
                        {
                            sQuery = "SELECT MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia ORDER BY MaLSG DESC";
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Cập nhật lưới
                    dataGridView1.DataSource = dt;

                    // Định dạng cột ngày
                    dataGridView1.Columns["NgayBDGia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dataGridView1.Columns["NgayKTGia"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    // Bắt buộc để cột hiện ra nếu không thiết kế thủ công
                    dataGridView1.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn CSDL: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateMaLSG()
        {
            string newMa = "LSG0000001";
            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();
                    string query = "SELECT TOP 1 MaLSG FROM LichSuGia ORDER BY MaLSG DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastMa = result.ToString();
                        int number = int.Parse(lastMa.Substring(3)) + 1;
                        newMa = "LSG" + number.ToString("D7"); // D7: đảm bảo 7 chữ số
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo mã LSG: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return newMa;
        }

        private void bttnthemgia_Click(object sender, EventArgs e)
        {
            TextBox bttnmahang = this.Controls["bttnmahang"] as TextBox;
            TextBox bttnlsggia = this.Controls["bttnlsggia"] as TextBox;
            DateTimePicker dtbdgia = this.Controls["dtbdgia"] as DateTimePicker;
            DateTimePicker dtktgia = this.Controls["dtktgia"] as DateTimePicker;

            // Kiểm tra xem các điều khiển có null không
            if (bttnmahang == null || bttnlsggia == null || dtbdgia == null || dtktgia == null)
            {
                MessageBox.Show("Không tìm thấy một số điều khiển trên form. Vui lòng kiểm tra lại mã nguồn.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra dữ liệu đầu vào
            string maHH = bttnmahang.Text.Trim();
            string giaBanText = bttnlsggia.Text.Trim();

            if (string.IsNullOrEmpty(maHH) || string.IsNullOrEmpty(giaBanText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin lịch sửa giá.", "Thông báo thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá bán là số thực và lớn hơn 0
            if (!decimal.TryParse(giaBanText, out decimal giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Vui lòng nhập lại giá bán.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayBDGia = dtbdgia.Value;
            DateTime ngayKTGia = dtktgia.Value;
            DateTime currentDate = new DateTime(2025, 5, 28, 14, 12, 0); // 02:12 PM +07, 28/05/2025

            // Kiểm tra ngày bắt đầu và ngày kết thúc
            if (ngayBDGia < currentDate || ngayKTGia < currentDate)
            {
                MessageBox.Show("Vui lòng nhập lại ngày bắt đầu và ngày kết thúc giá.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ngayKTGia < ngayBDGia)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra mã hàng hóa có tồn tại không
                    string checkMaHHQuery = "SELECT COUNT(*) FROM HangHoa WHERE MaHH = @MaHH";
                    SqlCommand checkMaHHCmd = new SqlCommand(checkMaHHQuery, con);
                    checkMaHHCmd.Parameters.AddWithValue("@MaHH", maHH);
                    int maHHCount = (int)checkMaHHCmd.ExecuteScalar();

                    if (maHHCount == 0)
                    {
                        MessageBox.Show("Mã hàng hóa không tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra xem có giá nào trong cùng khoảng thời gian cho mã hàng hóa này không
                    string checkOverlapQuery = "SELECT COUNT(*) FROM LichSuGia WHERE MaHH = @MaHH AND " +
                                              "((NgayBDGia <= @NgayBDGia AND NgayKTGia >= @NgayBDGia) OR " +
                                              "(NgayBDGia <= @NgayKTGia AND NgayKTGia >= @NgayKTGia) OR " +
                                              "(NgayBDGia >= @NgayBDGia AND NgayKTGia <= @NgayKTGia))";
                    SqlCommand checkOverlapCmd = new SqlCommand(checkOverlapQuery, con);
                    checkOverlapCmd.Parameters.AddWithValue("@MaHH", maHH);
                    checkOverlapCmd.Parameters.AddWithValue("@NgayBDGia", ngayBDGia);
                    checkOverlapCmd.Parameters.AddWithValue("@NgayKTGia", ngayKTGia);
                    int overlapCount = (int)checkOverlapCmd.ExecuteScalar();

                    if (overlapCount > 0)
                    {
                        MessageBox.Show("Giá của hàng hóa đã có sẵn. Vui lòng nhập lại giá!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo mã LSG tự động
                    string maLSG = GenerateMaLSG();

                    // Thêm dữ liệu vào bảng LichSuGia
                    string insertQuery = "INSERT INTO LichSuGia (MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH) " +
                                        "VALUES (@MaLSG, @NgayBDGia, @NgayKTGia, @GiaBan, @MaHH)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@MaLSG", maLSG);
                    cmd.Parameters.AddWithValue("@NgayBDGia", ngayBDGia);
                    cmd.Parameters.AddWithValue("@NgayKTGia", ngayKTGia);
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                    cmd.Parameters.AddWithValue("@MaHH", maHH);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm lịch sửa giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Gọi LoadData thay vì LoadPriceHistory để đồng bộ

                        // Xóa các ô nhập liệu
                        bttnmahang.Clear();
                        bttnlsggia.Clear();
                        dtbdgia.Value = currentDate;
                        dtktgia.Value = currentDate;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm lịch sửa giá. Vui lòng thử lại.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm lịch sửa giá: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttbxoagia_Click(object sender, EventArgs e)
        {
            TextBox bttnmaLSG = this.Controls["bttnmaLSG"] as TextBox; // Ô nhập Mã LSG
            TextBox bttnlsggia = this.Controls["bttnlsggia"] as TextBox; // Ô nhập Giá bán
            TextBox bttnmahang = this.Controls["bttnmahang"] as TextBox; // Ô nhập Mã hàng hóa

            // Kiểm tra xem các điều khiển có null không
            if (bttnmaLSG == null || bttnlsggia == null || bttnmahang == null)
            {
                MessageBox.Show("Không tìm thấy một số điều khiển trên form. Vui lòng kiểm tra lại mã nguồn.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra dữ liệu đầu vào
            string maLSG = bttnmaLSG.Text.Trim();
            string giaBanText = bttnlsggia.Text.Trim();
            string maHH = bttnmahang.Text.Trim();

            if (string.IsNullOrEmpty(maLSG) || string.IsNullOrEmpty(giaBanText) || string.IsNullOrEmpty(maHH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để xóa: Mã LSG, Giá bán và Mã hàng hóa.", "Thông báo thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá bán là số thực
            if (!decimal.TryParse(giaBanText, out decimal giaBan))
            {
                MessageBox.Show("Giá bán phải là một số thực.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra Mã LSG có tồn tại không, và kiểm tra Giá bán, Mã hàng hóa có khớp không
                    string checkRecordQuery = "SELECT NgayBDGia, LSG_GiaBan, MaHH FROM LichSuGia WHERE MaLSG = @MaLSG";
                    SqlCommand checkRecordCmd = new SqlCommand(checkRecordQuery, con);
                    checkRecordCmd.Parameters.AddWithValue("@MaLSG", maLSG);
                    SqlDataReader reader = checkRecordCmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Mã LSG không tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy thông tin từ bản ghi
                    DateTime ngayBDGia = Convert.ToDateTime(reader["NgayBDGia"]);
                    decimal dbGiaBan = Convert.ToDecimal(reader["LSG_GiaBan"]);
                    string dbMaHH = reader["MaHH"].ToString();
                    reader.Close();

                    // Kiểm tra Giá bán và Mã hàng hóa có khớp không
                    if (dbGiaBan != giaBan || dbMaHH != maHH)
                    {
                        MessageBox.Show("Giá bán hoặc Mã hàng hóa không khớp với bản ghi của Mã LSG này. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra ngày bắt đầu phải lớn hơn ngày hiện tại
                    DateTime currentDate = new DateTime(2025, 5, 28, 14, 35, 0); // 02:35 PM +07, 28/05/2025
                    if (ngayBDGia <= currentDate)
                    {
                        MessageBox.Show("Không thể xóa! Ngày bắt đầu giá của bản ghi này không lớn hơn ngày hiện tại (28/05/2025 02:35 PM +07).", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xóa bản ghi
                    string deleteQuery = "DELETE FROM LichSuGia WHERE MaLSG = @MaLSG";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@MaLSG", maLSG);

                    int rows = deleteCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa lịch sửa giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();

                        // Xóa các ô nhập liệu
                        bttnmaLSG.Clear();
                        bttnlsggia.Clear();
                        bttnmahang.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa lịch sửa giá. Vui lòng thử lại.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa lịch sửa giá: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttnsualsg_Click(object sender, EventArgs e)
        {
            TextBox bttnmaLSG = this.Controls["bttnmaLSG"] as TextBox; // Ô nhập Mã LSG
            TextBox bttnlsggia = this.Controls["bttnlsggia"] as TextBox; // Ô nhập Giá bán (không bắt buộc)
            TextBox bttnmahang = this.Controls["bttnmahang"] as TextBox; // Ô nhập Mã hàng hóa
            DateTimePicker dtbdgia = this.Controls["dtbdgia"] as DateTimePicker; // Ô nhập Ngày bắt đầu (không bắt buộc)
            DateTimePicker dtktgia = this.Controls["dtktgia"] as DateTimePicker; // Ô nhập Ngày kết thúc (không bắt buộc)

            // Kiểm tra xem các điều khiển có null không
            if (bttnmaLSG == null || bttnlsggia == null || bttnmahang == null || dtbdgia == null || dtktgia == null)
            {
                MessageBox.Show("Không tìm thấy một số điều khiển trên form. Vui lòng kiểm tra lại mã nguồn.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra dữ liệu đầu vào bắt buộc
            string maLSG = bttnmaLSG.Text.Trim();
            string maHH = bttnmahang.Text.Trim();

            if (string.IsNullOrEmpty(maLSG) || string.IsNullOrEmpty(maHH))
            {
                MessageBox.Show("Vui lòng nhập Mã LSG và Mã hàng hóa để sửa.", "Thông báo thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(scon))
            {
                try
                {
                    con.Open();

                    // Kiểm tra Mã LSG có tồn tại không và lấy thông tin hiện tại
                    string checkRecordQuery = "SELECT NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia WHERE MaLSG = @MaLSG";
                    SqlCommand checkRecordCmd = new SqlCommand(checkRecordQuery, con);
                    checkRecordCmd.Parameters.AddWithValue("@MaLSG", maLSG);
                    SqlDataReader reader = checkRecordCmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Mã LSG không tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy thông tin hiện tại của bản ghi
                    DateTime currentNgayBDGia = Convert.ToDateTime(reader["NgayBDGia"]);
                    DateTime currentNgayKTGia = Convert.ToDateTime(reader["NgayKTGia"]);
                    decimal currentGiaBan = Convert.ToDecimal(reader["LSG_GiaBan"]);
                    string currentMaHH = reader["MaHH"].ToString();
                    reader.Close();

                    // Kiểm tra ngày bắt đầu của bản ghi hiện tại phải lớn hơn ngày hiện tại
                    DateTime currentDate = new DateTime(2025, 5, 28, 16, 14, 0); // 04:14 PM +07, 28/05/2025
                    if (currentNgayBDGia <= currentDate)
                    {
                        MessageBox.Show("Không thể sửa! Ngày bắt đầu giá của bản ghi này không lớn hơn ngày hiện tại (28/05/2025 04:14 PM +07).", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra Mã hàng hóa có khớp không
                    if (currentMaHH != maHH)
                    {
                        // Kiểm tra Mã hàng hóa mới có tồn tại trong bảng HangHoa không
                        string checkMaHHQuery = "SELECT COUNT(*) FROM HangHoa WHERE MaHH = @MaHH";
                        SqlCommand checkMaHHCmd = new SqlCommand(checkMaHHQuery, con);
                        checkMaHHCmd.Parameters.AddWithValue("@MaHH", maHH);
                        int maHHCount = (int)checkMaHHCmd.ExecuteScalar();

                        if (maHHCount == 0)
                        {
                            MessageBox.Show("Mã hàng hóa không tồn tại trong hệ thống. Vui lòng kiểm tra lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Lấy giá trị mới (nếu có)
                    decimal? newGiaBan = null;
                    string giaBanText = bttnlsggia.Text.Trim();
                    if (!string.IsNullOrEmpty(giaBanText))
                    {
                        if (!decimal.TryParse(giaBanText, out decimal parsedGiaBan) || parsedGiaBan <= 0)
                        {
                            MessageBox.Show("Giá bán phải là một số thực lớn hơn 0.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newGiaBan = parsedGiaBan;
                    }

                    DateTime? newNgayBDGia = null;
                    if (dtbdgia.Value != currentDate) // Kiểm tra nếu người dùng đã thay đổi giá trị
                    {
                        newNgayBDGia = dtbdgia.Value;
                        if (newNgayBDGia < currentDate)
                        {
                            MessageBox.Show("Ngày bắt đầu mới phải lớn hơn hoặc bằng ngày hiện tại (28/05/2025 04:14 PM +07)!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DateTime? newNgayKTGia = null;
                    if (dtktgia.Value != currentDate) // Kiểm tra nếu người dùng đã thay đổi giá trị
                    {
                        newNgayKTGia = dtktgia.Value;
                        if (newNgayKTGia < currentDate)
                        {
                            MessageBox.Show("Ngày kết thúc mới phải lớn hơn hoặc bằng ngày hiện tại (28/05/2025 04:14 PM +07)!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Nếu có ngày mới, kiểm tra ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu
                    DateTime finalNgayBDGia = newNgayBDGia ?? currentNgayBDGia;
                    DateTime finalNgayKTGia = newNgayKTGia ?? currentNgayKTGia;
                    if (finalNgayKTGia < finalNgayBDGia)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra trùng lặp thời gian giá nếu có thay đổi ngày
                    if (newNgayBDGia.HasValue || newNgayKTGia.HasValue)
                    {
                        string checkOverlapQuery = "SELECT COUNT(*) FROM LichSuGia WHERE MaHH = @MaHH AND " +
                                                  "((NgayBDGia <= @NgayBDGia AND NgayKTGia >= @NgayBDGia) OR " +
                                                  "(NgayBDGia <= @NgayKTGia AND NgayKTGia >= @NgayKTGia) OR " +
                                                  "(NgayBDGia >= @NgayBDGia AND NgayKTGia <= @NgayKTGia)) " +
                                                  "AND MaLSG != @MaLSG";
                        SqlCommand checkOverlapCmd = new SqlCommand(checkOverlapQuery, con);
                        checkOverlapCmd.Parameters.AddWithValue("@MaHH", maHH);
                        checkOverlapCmd.Parameters.AddWithValue("@NgayBDGia", finalNgayBDGia);
                        checkOverlapCmd.Parameters.AddWithValue("@NgayKTGia", finalNgayKTGia);
                        checkOverlapCmd.Parameters.AddWithValue("@MaLSG", maLSG);
                        int overlapCount = (int)checkOverlapCmd.ExecuteScalar();

                        if (overlapCount > 0)
                        {
                            MessageBox.Show("Trong cùng một thời gian, một loại hàng hóa chỉ có một giá duy nhất!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Cập nhật bản ghi
                    string updateQuery = "UPDATE LichSuGia SET " +
                                        "NgayBDGia = @NgayBDGia, " +
                                        "NgayKTGia = @NgayKTGia, " +
                                        "LSG_GiaBan = @GiaBan, " +
                                        "MaHH = @MaHH " +
                                        "WHERE MaLSG = @MaLSG";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@MaLSG", maLSG);
                    updateCmd.Parameters.AddWithValue("@NgayBDGia", finalNgayBDGia);
                    updateCmd.Parameters.AddWithValue("@NgayKTGia", finalNgayKTGia);
                    updateCmd.Parameters.AddWithValue("@GiaBan", newGiaBan ?? currentGiaBan);
                    updateCmd.Parameters.AddWithValue("@MaHH", maHH);

                    int rows = updateCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Sửa lịch sửa giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();

                        // Xóa các ô nhập liệu
                        bttnmaLSG.Clear();
                        bttnlsggia.Clear();
                        bttnmahang.Clear();
                        dtbdgia.Value = currentDate;
                        dtktgia.Value = currentDate;
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa lịch sửa giá. Vui lòng thử lại.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi sửa lịch sửa giá: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttntkgia_Click(object sender, EventArgs e)
        {
            TextBox bttnmaLSG = this.Controls["bttnmaLSG"] as TextBox;
            TextBox bttnlsggia = this.Controls["bttnlsggia"] as TextBox;
            TextBox bttnmahang = this.Controls["bttnmahang"] as TextBox;
            DateTimePicker dtbdgia = this.Controls["dtbdgia"] as DateTimePicker;
            DateTimePicker dtktgia = this.Controls["dtktgia"] as DateTimePicker;

            // Kiểm tra xem các điều khiển có null không
            if (bttnmaLSG == null || bttnlsggia == null || bttnmahang == null || dtbdgia == null || dtktgia == null)
            {
                MessageBox.Show("Không tìm thấy một số điều khiển trên form. Vui lòng kiểm tra lại mã nguồn.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maLSG = bttnmaLSG.Text.Trim();
            string giaBanText = bttnlsggia.Text.Trim();
            string maHH = bttnmahang.Text.Trim();
            DateTime ngayBDGia = dtbdgia.Value;
            DateTime ngayKTGia = dtktgia.Value;
            DateTime currentDate = new DateTime(2025, 5, 28, 17, 46, 0); // 05:46 PM +07, 28/05/2025

            try
            {
                using (SqlConnection con = new SqlConnection(scon))
                {
                    con.Open();

                    string sQuery = "SELECT MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia WHERE 1=1";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(maLSG))
                    {
                        sQuery += " AND MaLSG = @MaLSG";
                        parameters.Add(new SqlParameter("@MaLSG", maLSG));
                    }

                    if (!string.IsNullOrEmpty(giaBanText))
                    {
                        if (decimal.TryParse(giaBanText, out decimal giaBan))
                        {
                            sQuery += " AND LSG_GiaBan = @GiaBan";
                            parameters.Add(new SqlParameter("@GiaBan", giaBan));
                        }
                        else
                        {
                            MessageBox.Show("Giá bán phải là một số thực.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(maHH))
                    {
                        sQuery += " AND MaHH = @MaHH";
                        parameters.Add(new SqlParameter("@MaHH", maHH));
                    }

                    if (dtbdgia.Value != dtbdgia.MinDate) // Kiểm tra nếu ngày bắt đầu được thay đổi
                    {
                        sQuery += " AND NgayBDGia >= @NgayBDGia";
                        parameters.Add(new SqlParameter("@NgayBDGia", ngayBDGia));
                    }

                    if (dtktgia.Value != dtktgia.MinDate) // Kiểm tra nếu ngày kết thúc được thay đổi
                    {
                        sQuery += " AND NgayKTGia <= @NgayKTGia";
                        parameters.Add(new SqlParameter("@NgayKTGia", ngayKTGia));
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bất kỳ lịch sử giá nào khớp với điều kiện nhập vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["NgayBDGia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataGridView1.Columns["NgayKTGia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.Refresh(); // Đảm bảo lưới được làm mới
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbloc_Click(object sender, EventArgs e)
        {
            TextBox bttnmahang = this.Controls["bttnmahang"] as TextBox;

            // Kiểm tra xem điều khiển có null không
            if (bttnmahang == null)
            {
                MessageBox.Show("Không tìm thấy điều khiển mã hàng hóa trên form. Vui lòng kiểm tra lại mã nguồn.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHH = bttnmahang.Text.Trim();
            DateTime currentDate = new DateTime(2025, 5, 28, 18, 3, 0); // 06:03 PM +07, 28/05/2025

            try
            {
                using (SqlConnection con = new SqlConnection(scon))
                {
                    con.Open();

                    string sQuery = "SELECT MaLSG, NgayBDGia, NgayKTGia, LSG_GiaBan, MaHH FROM LichSuGia WHERE 1=1";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    if (!string.IsNullOrEmpty(maHH))
                    {
                        sQuery += " AND MaHH = @MaHH";
                        parameters.Add(new SqlParameter("@MaHH", maHH));
                    }

                    // Thêm sắp xếp theo giá bán dựa trên lựa chọn trong ComboBox
                    if (cbloc.SelectedItem != null)
                    {
                        if (cbloc.SelectedItem.ToString() == "Tăng dần")
                        {
                            sQuery += " ORDER BY LSG_GiaBan ASC";
                        }
                        else if (cbloc.SelectedItem.ToString() == "Giảm dần")
                        {
                            sQuery += " ORDER BY LSG_GiaBan DESC";
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bất kỳ lịch sử giá nào khớp với mã hàng hóa nhập vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["NgayBDGia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataGridView1.Columns["NgayKTGia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.Refresh(); // Đảm bảo lưới được làm mới
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

