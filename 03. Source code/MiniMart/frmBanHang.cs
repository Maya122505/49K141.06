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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace btapR5
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        public SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False");
            return conn;
        }




        // Thực thi câu lệnh INSERT, UPDATE, DELETE, không trả về dữ liệu
        public void ThucThiNonQuery(string sql)
        {
            using (SqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi thực thi: " + ex.Message);
                }
            }
        }
        //thực thi query
        public DataTable ThucThiQuery(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 120;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
            return dt;
        }
        private void trangchu_Click(object sender, EventArgs e)
        {

        }

        private void khachhang_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private string LayMaHoaDonTuSQL()
        {
            string maMoi = "";
            using (SqlConnection con = Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.TaoMaHoaDon()", con);
                object result = cmd.ExecuteScalar();
                maMoi = result != null ? result.ToString() : "HD00001";
            }
            return maMoi;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string maHD = LayMaHoaDonTuSQL();       // Mã tự sinh
            string maKH = nhapmakh.Text.Trim();
            string PTTT = nhap_pttt.Text.Trim();
            // Mã khách hàng từ TextBox
            DateTime NgayThanhToan= dateTimePicker1.Value;     // Ngày lập từ DateTimePicker
            string ngayLapFormatted = NgayThanhToan.ToString("yyyy-MM-dd");
            string Diemsudung = nhapdsd.Text.Trim(); // Điểm sử dụng

            // Kiểm tra điểm hợp lệ
            if (!int.TryParse(Diemsudung, out int diemSuDung))
            {
                MessageBox.Show("Điểm sử dụng không hợp lệ!");
                return;
            }

            // Chuỗi truy vấn thêm vào bảng hóa đơn
            string sql = $"INSERT INTO BanHang (MaHD, MaKH,PTTT, NgayThanhToan, Diemsudung) " +
                         $"VALUES ('{maHD}', '{maKH}','{PTTT}' ,'{ngayLapFormatted}','{Diemsudung}')";

            // Thực thi và hiển thị thông báo
            this.ThucThiNonQuery(sql);
            MessageBox.Show("Thêm hóa đơn bán thành công!");
            LoadBanHang(); // Cập nhật lại danh sách
        }
        private void LoadBanHang()
        {
            string sql = "SELECT * FROM BanHang";
            dataGridView1.DataSource = ThucThiQuery(sql);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaHD = nhap_mahd.Text;
            if (string.IsNullOrWhiteSpace(MaHD))
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn để cập nhật.");
                return;
            }
            string PTTT = nhap_pttt.Text;
            string MaKH = nhapmakh.Text;
            string MaNV = nhapmanv.Text;
            DateTime NgayThanhToan = dateTimePicker1.Value;
            string ngayFormatted = NgayThanhToan.ToString("yyyy-MM-dd");

            int Diemsudung;
            if (!int.TryParse(nhapdsd.Text, out Diemsudung))
            {
                MessageBox.Show("Điểm sử dụng phải là số nguyên!");
                return;
            }

            string sql = $"UPDATE BanHang SET " +
                         $"PTTT = N'{PTTT}', MaKH = '{MaKH}', MaNV = '{MaNV}', " +
                         $"NgayThanhToan = '{ngayFormatted}', Diemsudung = {Diemsudung} " +
                         $"WHERE MaHD = '{MaHD}'";

            ThucThiNonQuery(sql);
            MessageBox.Show("Cập nhật thành công!");
            LoadBanHang();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string MaHD = nhap_mahd.Text.Trim();

            if (string.IsNullOrWhiteSpace(MaHD))
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn để tìm kiếm.");
                return;
            }

            string sql = $"SELECT * FROM BanHang WHERE MaHD = '{MaHD}'";
            DataTable dt = ThucThiQuery(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn với Mã Hóa Đơn đã nhập.");
                dataGridView1.DataSource = new DataTable();
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                object maHDObj = dataGridView1.CurrentRow.Cells["MaHD"].Value;

                if (maHDObj == null || string.IsNullOrWhiteSpace(maHDObj.ToString()))
                {
                    MessageBox.Show("Không tìm thấy Mã Hóa Đơn hợp lệ để in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maHD = dataGridView1.CurrentRow.Cells["MaHD"].Value.ToString();

                string sql = $"SELECT * FROM BanHang WHERE MaHD = '{maHD}'";
                DataTable dt = ThucThiQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string hoaDon = $"Mã HĐ: {row["MaHD"]}\n" +
                                    $"PTTT: {row["PTTT"]}\n" +
                                    $"Mã KH: {row["MaKH"]}\n" +
                                    $"Mã NV: {row["MaNV"]}\n" +
                                    $"NgayThanhToan {Convert.ToDateTime(row["NgayThanhToan"]).ToShortDateString()}\n" +
                                    $"Điểm sử dụng: {row["Diemsudung"]}";

                    MessageBox.Show(hoaDon, "Thông tin Hóa Đơn");
                }
            }
        }
        private void LoadData()
        {
            try
            {
                var dtBanHang = ThucThiQuery("SELECT TOP 100*FROM BanHang");
                dataGridView1.DataSource = dtBanHang;
                dataGridView1.AutoGenerateColumns = true;

                var dtCTHD = ThucThiQuery("SELECT TOP 100*FROM CTHD_Ban");
                dataGridView2.DataSource = dtCTHD;
                dataGridView2.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }

        }
        private void frmBanHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void nhapmahang_TextChanged(object sender, EventArgs e)
        {

        }

        private void them_cthd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập
            string MaHD = nhapmhd_cthd.Text.Trim();
            string MaHH = nhapmahang.Text.Trim();
            int SoLuong;

            // Kiểm tra dữ liệu đầu vào
            if ((string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(MaHH)||
                !int.TryParse(nhapsl.Text, out SoLuong)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            // Thêm vào CSDL
            string sql = $"INSERT INTO CTHD_Ban (MaHD,MaHH, SoLuong) " +
                         $"VALUES ('{MaHD}','{MaHH}', {SoLuong})";
            ThucThiNonQuery(sql);

            // Load lại dữ liệu lên DataGridView2
            var dtCTHD = ThucThiQuery("SELECT TOP 100 * FROM CTHD_Ban");
            dataGridView2.DataSource = dtCTHD;
            dataGridView2.AutoGenerateColumns = true;

            MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
        }

        private void sua_cthd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập
            string MaHD = nhapmhd_cthd.Text.Trim();
            string MaHH = nhapmahang.Text.Trim();
            int SoLuong;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(MaHH)||
                !int.TryParse(nhapsl.Text, out SoLuong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường!");
                return;
            }

            // Kiểm tra xem chi tiết hóa đơn có tồn tại không
            string sqlCheck = $"SELECT COUNT(*) FROM CTHD_Ban WHERE MaHD='{MaHD}' AND  MaHH = '{MaHH}'";
            DataTable dtCheck = ThucThiQuery(sqlCheck);
            if (dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) == 0)
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn với Mã hóa đơn và Mã hàng này!");
                return;
            }

            // Cập nhật vào CSDL
            string sql = $"UPDATE CTHD_Ban SET SoLuong = {SoLuong} WHERE maHD= '{MaHD}' AND MaHH = '{MaHH}'";
            ThucThiNonQuery(sql);

            // Load lại dữ liệu lên DataGridView2
            var dtCTHD = ThucThiQuery("SELECT TOP 100 * FROM CTHD_Ban");
            dataGridView2.DataSource = dtCTHD;
            dataGridView2.AutoGenerateColumns = true;

            MessageBox.Show("Sửa chi tiết hóa đơn thành công!");
        }

        private void xoa_cthd_Click(object sender, EventArgs e)
        {
            string MaHD = nhapmhd_cthd.Text.Trim();
            string MaHH = nhapmahang.Text.Trim();

            if (string.IsNullOrEmpty(MaHD)|| string.IsNullOrEmpty(MaHH))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn và Mã hàng hóa để xóa!");
                return;
            }

            // Xóa các chi tiết hóa đơn có mã hàng này
            string sql = $"DELETE FROM CTHD_Ban WHERE MaHD='{MaHD}' AND MaHH = '{MaHH}'";
            ThucThiNonQuery(sql);

            // Load lại dữ liệu lên DataGridView2
            var dtCTHD = ThucThiQuery("SELECT TOP 100 * FROM CTHD_Ban");
            dataGridView2.DataSource = dtCTHD;
            dataGridView2.AutoGenerateColumns = true;
            //if (dataGridView1.Columns.Contains("ColumnName"))
            //    dataGridView1.Columns["ColumnName"].Visible = false;

            MessageBox.Show("Đã xóa chi tiết hóa đơn theo mã hàng hóa!");
        }

        private void soluong_Click(object sender, EventArgs e)
        {

        }
    }
}