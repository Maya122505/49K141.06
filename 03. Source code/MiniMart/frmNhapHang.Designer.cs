namespace MyApp
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            label1 = new Label();
            txtMNH = new TextBox();
            label2 = new Label();
            btnSua = new Button();
            btnLuu = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbNV = new ComboBox();
            cbNCC = new ComboBox();
            dtpNNhap = new DateTimePicker();
            txtTHH = new TextBox();
            txtSL = new TextBox();
            txtGiaNhap = new TextBox();
            dtpNSX = new DateTimePicker();
            dtpNHH = new DateTimePicker();
            btnThem = new Button();
            btnTim = new Button();
            dataGridView2 = new DataGridView();
            btnXoa = new Button();
            btnLHM = new Button();
            label19 = new Label();
            txtMLH = new TextBox();
            cbMHH = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(498, 75);
            label1.Name = "label1";
            label1.Size = new Size(205, 35);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhập hàng";
            // 
            // txtMNH
            // 
            txtMNH.Location = new Point(739, 84);
            txtMNH.Margin = new Padding(3, 4, 3, 4);
            txtMNH.Name = "txtMNH";
            txtMNH.Size = new Size(186, 27);
            txtMNH.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(498, 139);
            label2.Name = "label2";
            label2.Size = new Size(194, 35);
            label2.TabIndex = 2;
            label2.Text = "Mã Nhân viên";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(958, 949);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(124, 42);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLuu.Location = new Point(1175, 949);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 42);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(498, 202);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(983, 186);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(1030, 81);
            label3.Name = "label3";
            label3.Size = new Size(239, 35);
            label3.TabIndex = 7;
            label3.Text = "Mã Nhà cung cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(1030, 139);
            label5.Name = "label5";
            label5.Size = new Size(152, 35);
            label5.TabIndex = 9;
            label5.Text = "Ngày nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(498, 511);
            label6.Name = "label6";
            label6.Size = new Size(188, 35);
            label6.TabIndex = 10;
            label6.Text = "Mã Hàng hóa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(498, 590);
            label7.Name = "label7";
            label7.Size = new Size(194, 35);
            label7.TabIndex = 11;
            label7.Text = "Tên Hàng hóa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(1054, 433);
            label8.Name = "label8";
            label8.Size = new Size(138, 35);
            label8.TabIndex = 12;
            label8.Text = "Giá Nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(1055, 508);
            label9.Name = "label9";
            label9.Size = new Size(198, 35);
            label9.TabIndex = 13;
            label9.Text = "Ngày Sản xuất";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(498, 661);
            label10.Name = "label10";
            label10.Size = new Size(129, 35);
            label10.TabIndex = 14;
            label10.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.Location = new Point(1055, 582);
            label11.Name = "label11";
            label11.Size = new Size(189, 35);
            label11.TabIndex = 15;
            label11.Text = "Ngày Hết hạn";
            // 
            // cbNV
            // 
            cbNV.FormattingEnabled = true;
            cbNV.Location = new Point(739, 146);
            cbNV.Margin = new Padding(3, 4, 3, 4);
            cbNV.Name = "cbNV";
            cbNV.Size = new Size(186, 28);
            cbNV.TabIndex = 1;
            // 
            // cbNCC
            // 
            cbNCC.FormattingEnabled = true;
            cbNCC.Location = new Point(1299, 88);
            cbNCC.Margin = new Padding(3, 4, 3, 4);
            cbNCC.Name = "cbNCC";
            cbNCC.Size = new Size(182, 28);
            cbNCC.TabIndex = 4;
            // 
            // dtpNNhap
            // 
            dtpNNhap.Location = new Point(1299, 135);
            dtpNNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNNhap.Name = "dtpNNhap";
            dtpNNhap.Size = new Size(182, 27);
            dtpNNhap.TabIndex = 3;
            // 
            // txtTHH
            // 
            txtTHH.Location = new Point(727, 590);
            txtTHH.Margin = new Padding(3, 4, 3, 4);
            txtTHH.Name = "txtTHH";
            txtTHH.Size = new Size(186, 27);
            txtTHH.TabIndex = 7;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(727, 661);
            txtSL.Margin = new Padding(3, 4, 3, 4);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(186, 27);
            txtSL.TabIndex = 8;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(1298, 433);
            txtGiaNhap.Margin = new Padding(3, 4, 3, 4);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(183, 27);
            txtGiaNhap.TabIndex = 9;
            // 
            // dtpNSX
            // 
            dtpNSX.Location = new Point(1298, 511);
            dtpNSX.Margin = new Padding(3, 4, 3, 4);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(183, 27);
            dtpNSX.TabIndex = 10;
            // 
            // dtpNHH
            // 
            dtpNHH.Location = new Point(1299, 582);
            dtpNHH.Margin = new Padding(3, 4, 3, 4);
            dtpNHH.Name = "dtpNHH";
            dtpNHH.Size = new Size(183, 27);
            dtpNHH.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.Location = new Point(498, 949);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 42);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTim.Location = new Point(727, 949);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(117, 42);
            btnTim.TabIndex = 13;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(498, 741);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(983, 166);
            dataGridView2.TabIndex = 28;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.Location = new Point(1363, 949);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 42);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLHM
            // 
            btnLHM.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLHM.Location = new Point(1229, 680);
            btnLHM.Margin = new Padding(3, 4, 3, 4);
            btnLHM.Name = "btnLHM";
            btnLHM.Size = new Size(252, 43);
            btnLHM.TabIndex = 29;
            btnLHM.Text = "Thêm Lô hàng mới";
            btnLHM.UseVisualStyleBackColor = true;
            btnLHM.Click += btnLHM_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label19.Location = new Point(498, 436);
            label19.Name = "label19";
            label19.Size = new Size(171, 35);
            label19.TabIndex = 30;
            label19.Text = "Mã Lô hàng";
            // 
            // txtMLH
            // 
            txtMLH.Location = new Point(727, 444);
            txtMLH.Margin = new Padding(3, 4, 3, 4);
            txtMLH.Name = "txtMLH";
            txtMLH.Size = new Size(186, 27);
            txtMLH.TabIndex = 31;
            // 
            // cbMHH
            // 
            cbMHH.FormattingEnabled = true;
            cbMHH.Location = new Point(727, 517);
            cbMHH.Margin = new Padding(3, 4, 3, 4);
            cbMHH.Name = "cbMHH";
            cbMHH.Size = new Size(186, 28);
            cbMHH.TabIndex = 32;
            cbMHH.SelectedIndexChanged += cbMHH_SelectedIndexChanged;
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
            panel3.TabIndex = 33;
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
            // frmNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1688, 1055);
            Controls.Add(panel3);
            Controls.Add(cbMHH);
            Controls.Add(txtMLH);
            Controls.Add(label19);
            Controls.Add(btnLHM);
            Controls.Add(btnXoa);
            Controls.Add(dataGridView2);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(dtpNHH);
            Controls.Add(dtpNSX);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtSL);
            Controls.Add(txtTHH);
            Controls.Add(dtpNNhap);
            Controls.Add(cbNCC);
            Controls.Add(cbNV);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(label2);
            Controls.Add(txtMNH);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "frmNhapHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhập hàng";
            Load += frmNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMNH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.DateTimePicker dtpNNhap;
        private System.Windows.Forms.TextBox txtTHH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.DateTimePicker dtpNHH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLHM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMLH;
        private System.Windows.Forms.ComboBox cbMHH;
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

