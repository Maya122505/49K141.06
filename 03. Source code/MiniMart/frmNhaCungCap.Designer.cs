namespace MyApp
{
    partial class frmNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMNCC = new TextBox();
            txtTNCC = new TextBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnTim = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel3 = new Panel();
            btnDangXuat = new Button();
            btnHangHoa = new Button();
            btnCongNo = new Button();
            btnNCC = new Button();
            btnNhanVien = new Button();
            btnLSG = new Button();
            btnNhapHang = new Button();
            btnBanHang = new Button();
            btnKhachHang = new Button();
            btnTrangChu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(553, 127);
            label1.Name = "label1";
            label1.Size = new Size(239, 35);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(553, 199);
            label2.Name = "label2";
            label2.Size = new Size(245, 35);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(1177, 135);
            label3.Name = "label3";
            label3.Size = new Size(113, 35);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(1177, 202);
            label4.Name = "label4";
            label4.Size = new Size(180, 35);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // txtMNCC
            // 
            txtMNCC.Location = new Point(873, 135);
            txtMNCC.Margin = new Padding(3, 4, 3, 4);
            txtMNCC.Name = "txtMNCC";
            txtMNCC.Size = new Size(147, 27);
            txtMNCC.TabIndex = 4;
            // 
            // txtTNCC
            // 
            txtTNCC.Location = new Point(873, 208);
            txtTNCC.Margin = new Padding(3, 4, 3, 4);
            txtTNCC.Name = "txtTNCC";
            txtTNCC.Size = new Size(147, 27);
            txtTNCC.TabIndex = 5;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(1400, 144);
            txtDC.Margin = new Padding(3, 4, 3, 4);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(140, 27);
            txtDC.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(1400, 203);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(140, 27);
            txtSDT.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(556, 366);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(987, 361);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(556, 844);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 50);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTim.Location = new Point(775, 844);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(126, 50);
            btnTim.TabIndex = 10;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.Location = new Point(1197, 844);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(117, 50);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(1426, 844);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 50);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(991, 844);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 50);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(btnDangXuat);
            panel3.Controls.Add(btnHangHoa);
            panel3.Controls.Add(btnCongNo);
            panel3.Controls.Add(btnNCC);
            panel3.Controls.Add(btnNhanVien);
            panel3.Controls.Add(btnLSG);
            panel3.Controls.Add(btnNhapHang);
            panel3.Controls.Add(btnBanHang);
            panel3.Controls.Add(btnKhachHang);
            panel3.Controls.Add(btnTrangChu);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 999);
            panel3.TabIndex = 24;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.SlateBlue;
            btnDangXuat.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnDangXuat.Location = new Point(27, 885);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(266, 73);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnHangHoa
            // 
            btnHangHoa.BackColor = Color.SlateBlue;
            btnHangHoa.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnHangHoa.Location = new Point(27, 405);
            btnHangHoa.Name = "btnHangHoa";
            btnHangHoa.Size = new Size(266, 73);
            btnHangHoa.TabIndex = 5;
            btnHangHoa.Text = "HÀNG HÓA";
            btnHangHoa.UseVisualStyleBackColor = false;
            // 
            // btnCongNo
            // 
            btnCongNo.BackColor = Color.SlateBlue;
            btnCongNo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnCongNo.Location = new Point(27, 781);
            btnCongNo.Name = "btnCongNo";
            btnCongNo.Size = new Size(266, 73);
            btnCongNo.TabIndex = 6;
            btnCongNo.Text = "CÔNG NỢ";
            btnCongNo.UseVisualStyleBackColor = false;
            // 
            // btnNCC
            // 
            btnNCC.BackColor = Color.SlateBlue;
            btnNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNCC.Location = new Point(27, 685);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(266, 73);
            btnNCC.TabIndex = 2;
            btnNCC.Text = "NHÀ CUNG CẤP";
            btnNCC.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.SlateBlue;
            btnNhanVien.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNhanVien.Location = new Point(27, 595);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(266, 73);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "NHÂN VIÊN";
            btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnLSG
            // 
            btnLSG.BackColor = Color.SlateBlue;
            btnLSG.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnLSG.Location = new Point(27, 500);
            btnLSG.Name = "btnLSG";
            btnLSG.Size = new Size(266, 73);
            btnLSG.TabIndex = 4;
            btnLSG.Text = "LỊCH SỬ GIÁ";
            btnLSG.UseVisualStyleBackColor = false;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.SlateBlue;
            btnNhapHang.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNhapHang.Location = new Point(27, 311);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(266, 73);
            btnNhapHang.TabIndex = 6;
            btnNhapHang.Text = "NHẬP HÀNG";
            btnNhapHang.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.SlateBlue;
            btnBanHang.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnBanHang.Location = new Point(27, 211);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(266, 73);
            btnBanHang.TabIndex = 7;
            btnBanHang.Text = "BÁN HÀNG";
            btnBanHang.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.SlateBlue;
            btnKhachHang.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnKhachHang.Location = new Point(27, 123);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(266, 73);
            btnKhachHang.TabIndex = 8;
            btnKhachHang.Text = "KHÁCH HÀNG";
            btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.SlateBlue;
            btnTrangChu.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnTrangChu.Location = new Point(27, 36);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(266, 68);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "TRANG CHỦ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1688, 1055);
            Controls.Add(panel3);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtSDT);
            Controls.Add(txtDC);
            Controls.Add(txtTNCC);
            Controls.Add(txtMNCC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhà cung cấp";
            WindowState = FormWindowState.Maximized;
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMNCC;
        private System.Windows.Forms.TextBox txtTNCC;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private Panel panel3;
        private Button btnDangXuat;
        private Button btnHangHoa;
        private Button btnCongNo;
        private Button btnNCC;
        private Button btnNhanVien;
        private Button btnLSG;
        private Button btnNhapHang;
        private Button btnBanHang;
        private Button btnKhachHang;
        private Button btnTrangChu;
    }
}