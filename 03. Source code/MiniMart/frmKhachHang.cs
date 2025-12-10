using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace WINMART
{
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";

        public frmKhachHang()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmKhachHang));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 36);
            button1.Name = "button1";
            button1.Size = new Size(266, 68);
            button1.TabIndex = 0;
            button1.Text = "TRANG CHỦ ";
            button1.UseVisualStyleBackColor = false;
            /*button1.Click += button1_Click;*/
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(27, 125);
            button2.Name = "button2";
            button2.Size = new Size(266, 73);
            button2.TabIndex = 1;
            button2.Text = "KHÁCH HÀNG ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(27, 228);
            button3.Name = "button3";
            button3.Size = new Size(266, 73);
            button3.TabIndex = 2;
            button3.Text = "BÁN HÀNG ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(27, 336);
            button4.Name = "button4";
            button4.Size = new Size(266, 73);
            button4.TabIndex = 3;
            button4.Text = "NHẬP HÀNG ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(27, 454);
            button5.Name = "button5";
            button5.Size = new Size(266, 73);
            button5.TabIndex = 4;
            button5.Text = "LỊCH SỬ GIÁ ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SlateBlue;
            button6.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(27, 576);
            button6.Name = "button6";
            button6.Size = new Size(266, 73);
            button6.TabIndex = 5;
            button6.Text = "NHÂN VIÊN";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.SlateBlue;
            button7.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(27, 690);
            button7.Name = "button7";
            button7.Size = new Size(266, 73);
            button7.TabIndex = 6;
            button7.Text = "NHÀ CUNG CẤP ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SlateBlue;
            button8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(27, 805);
            button8.Name = "button8";
            button8.Size = new Size(266, 73);
            button8.TabIndex = 7;
            button8.Text = "CÔNG NỢ";
            button8.UseVisualStyleBackColor = false;
            /*button8.Click += button8_Click;*/
            // 
            // button9
            // 
            button9.BackColor = Color.SlateBlue;
            button9.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(27, 921);
            button9.Name = "button9";
            button9.Size = new Size(266, 73);
            button9.TabIndex = 8;
            button9.Text = "ĐĂNG XUẤT ";
            button9.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 999);
            panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 566);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1377, 433);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 95);
            label1.Name = "label1";
            label1.Size = new Size(293, 35);
            label1.TabIndex = 27;
            label1.Text = "MÃ KHÁCH HÀNG ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 197);
            label2.Name = "label2";
            label2.Size = new Size(260, 35);
            label2.TabIndex = 28;
            label2.Text = "ĐIỂM TÍCH LŨY ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(789, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 42);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(789, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 42);
            textBox2.TabIndex = 29;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkCyan;
            button10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(487, 417);
            button10.Name = "button10";
            button10.Size = new Size(152, 57);
            button10.TabIndex = 30;
            button10.Text = "THÊM ";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkCyan;
            button11.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(839, 417);
            button11.Name = "button11";
            button11.Size = new Size(152, 57);
            button11.TabIndex = 31;
            button11.Text = "SỬA ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkCyan;
            button12.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(1221, 417);
            button12.Name = "button12";
            button12.Size = new Size(152, 57);
            button12.TabIndex = 32;
            button12.Text = "TÌM KIẾM";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // frmKhachHang
            // 
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1688, 994);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHACHHANG ";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmKhachHang_FormClosing;
            Load += Form1_Load_1;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện ở đây
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmNCC ncc = new frmNCC();
            ncc.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadData(string sMaKH = null)
        {
            using (SqlConnection con = new(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery;
                    if (!string.IsNullOrEmpty(sMaKH))
                    {
                        // Lọc dữ liệu theo mã khách hàng nếu có
                        sQuery = "SELECT * FROM KhachHang WHERE makh = @MaKH";
                        using (SqlDataAdapter adapter = new(sQuery, con))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@MaKH", sMaKH);
                            DataSet ds = new();
                            adapter.Fill(ds, "KhachHang");
                            if (ds.Tables["KhachHang"]?.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables["KhachHang"];
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khách hàng.", "THÔNG BÁO",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                        }
                    }
                    else
                    {
                        // Hiển thị toàn bộ dữ liệu nếu không có mã khách hàng
                        sQuery = "SELECT * FROM KhachHang";
                        using (SqlDataAdapter adapter = new(sQuery, con))
                        {
                            DataSet ds = new();
                            adapter.Fill(ds, "KhachHang");
                            if (ds.Tables["KhachHang"]?.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables["KhachHang"];
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu khách hàng.", "THÔNG BÁO",
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

        private void Form1_Load_1(object sender, EventArgs e)

        {
            LoadData();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB");
                return;
            }

            string sMaKH = textBox1.Text.Trim();

            if (sMaKH.Length != 10 || !sMaKH.All(char.IsDigit))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Vui lòng nhập đúng 10 chữ số.");
                return;
            }

            // Kiểm tra mã khách hàng đã tồn tại
            string checkQuery = "SELECT COUNT(*) FROM khachhang WHERE makh = @makh";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@makh", sMaKH);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại! Vui lòng nhập mã khác.");
            }
            else
            {
                // Thêm khách hàng mới với diemtichluy = 0
                string sQuery = "INSERT INTO khachhang (makh, diemtichluy) VALUES (@makh, 0)";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@makh", sMaKH);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công (điểm tích lũy = 0)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong quá trình thêm mới!");
                }
            }

            con.Close();




        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sMaKH = textBox1.Text.Trim();

            if (!(sMaKH.Length == 10 && sMaKH.All(char.IsDigit)))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ hoặc không tồn tại.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int sdiemTichLuy))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    string sQuery = @"
                        IF EXISTS (SELECT 1 FROM khachhang WHERE makh = @makh)
                        BEGIN
                            UPDATE khachhang SET diemtichluy = @diemtichluy WHERE makh = @makh
                            SELECT 'Updated' AS Result
                        END
                        ELSE
                        BEGIN
                            INSERT INTO khachhang (makh, diemtichluy) VALUES (@makh, @diemtichluy)
                            SELECT 'Inserted' AS Result
                        END";

                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@makh", sMaKH);
                    cmd.Parameters.AddWithValue("@diemtichluy", sdiemTichLuy);

                    string result = (string)cmd.ExecuteScalar();

                    if (result == "Updated")
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        LoadData();
                    }
                    else if (result == "Inserted")
                    {
                        MessageBox.Show("Thêm mới thành công.");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm/cập nhật: " + ex.Message);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            string sMaKH = textBox1.Text.Trim();

            if (!(sMaKH.Length == 10 && sMaKH.All(char.IsDigit)))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Vui lòng nhập đúng 10 chữ số.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(sCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM khachhang WHERE makh = @MaKH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", sMaKH);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt; // Giả sử dataGridView1 là nơi hiển thị kết quả
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề cột
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Giả sử cột 0 là makh, cột 1 là diemtichluy
                textBox1.Text = row.Cells["makh"].Value?.ToString();
                textBox2.Text = row.Cells["diemtichluy"].Value?.ToString();
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {

            frmTrangChu tc = new frmTrangChu();
            tc.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCongNo congNo = new frmCongNo();
            congNo.Show();

        }
        */
        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {


            frmTrangChu tc = new frmTrangChu();
            this.Hide(); // Ẩn Form hiện tại (frmKhachHang)
            tc.ShowDialog(); // Hiển thị Form Trang Chủ dưới dạng dialog (chờ Form này đóng)
            this.Close();


        }
        }
}
