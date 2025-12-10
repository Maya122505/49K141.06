namespace WINMART
{
    partial class frmNCC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            panel1 = new Panel();
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtMaNCC = new TextBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            txtTenNCC = new TextBox();
            dataGridViewNCC = new DataGridView();
            btnHuy = new Button();
            btnHuytim = new Button();
            btnTimKiem = new Button();
            txtNhapThongTin = new TextBox();
            labelTimKiem = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNCC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnHangHoa);
            panel1.Controls.Add(btnCongNo);
            panel1.Controls.Add(btnNCC);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(btnLSG);
            panel1.Controls.Add(btnNhapHang);
            panel1.Controls.Add(btnBanHang);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnTrangChu);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 999);
            panel1.TabIndex = 20;
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
            btnHangHoa.Location = new Point(27, 406);
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
            btnNCC.BackColor = Color.White;
            btnNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNCC.Location = new Point(27, 685);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(266, 73);
            btnNCC.TabIndex = 2;
            btnNCC.Text = "NHÀ CUNG CẤP";
            btnNCC.UseVisualStyleBackColor = false;
            btnNCC.Click += btnNCC_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.SlateBlue;
            btnNhanVien.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNhanVien.Location = new Point(27, 594);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(525, 186);
            label3.Name = "label3";
            label3.Size = new Size(307, 35);
            label3.TabIndex = 24;
            label3.Text = "MÃ NHÀ CUNG CẤP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(525, 342);
            label1.Name = "label1";
            label1.Size = new Size(245, 35);
            label1.TabIndex = 23;
            label1.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(525, 263);
            label2.Name = "label2";
            label2.Size = new Size(319, 35);
            label2.TabIndex = 25;
            label2.Text = "TÊN NHÀ CUNG CẤP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(525, 409);
            label4.Name = "label4";
            label4.Size = new Size(141, 35);
            label4.TabIndex = 26;
            label4.Text = "ĐỊA CHỈ ";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNCC.Location = new Point(857, 179);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(631, 42);
            txtMaNCC.TabIndex = 27;
            // 
            // txtDC
            // 
            txtDC.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDC.Location = new Point(857, 406);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(631, 42);
            txtDC.TabIndex = 28;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(857, 339);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(631, 42);
            txtSDT.TabIndex = 29;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenNCC.Location = new Point(857, 260);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(631, 42);
            txtTenNCC.TabIndex = 30;
            // 
            // dataGridViewNCC
            // 
            dataGridViewNCC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNCC.BackgroundColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNCC.Location = new Point(318, 566);
            dataGridViewNCC.Name = "dataGridViewNCC";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewNCC.RowHeadersWidth = 51;
            dataGridViewNCC.Size = new Size(1547, 433);
            dataGridViewNCC.TabIndex = 27;
            dataGridViewNCC.CellClick += dataGridViewNCC_CellClick;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkCyan;
            btnHuy.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(1057, 487);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(152, 57);
            btnHuy.TabIndex = 33;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnHuytim
            // 
            btnHuytim.BackColor = Color.DarkCyan;
            btnHuytim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuytim.ForeColor = SystemColors.ActiveCaptionText;
            btnHuytim.Location = new Point(1722, 69);
            btnHuytim.Name = "btnHuytim";
            btnHuytim.Size = new Size(108, 60);
            btnHuytim.TabIndex = 37;
            btnHuytim.Text = "HỦY";
            btnHuytim.UseVisualStyleBackColor = false;
            btnHuytim.Visible = false;
            btnHuytim.Click += btnHuytim_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.DarkCyan;
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            btnTimKiem.Location = new Point(1567, 69);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 60);
            btnTimKiem.TabIndex = 36;
            btnTimKiem.Text = "TÌM";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Visible = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtNhapThongTin
            // 
            txtNhapThongTin.BackColor = SystemColors.GradientInactiveCaption;
            txtNhapThongTin.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNhapThongTin.Location = new Point(1567, 31);
            txtNhapThongTin.Name = "txtNhapThongTin";
            txtNhapThongTin.Size = new Size(263, 27);
            txtNhapThongTin.TabIndex = 35;
            txtNhapThongTin.Text = "Nhập mã hoặc tên nhà cung cấp...";
            txtNhapThongTin.Click += txtNhapThongTin_Click;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.BackColor = Color.LightSkyBlue;
            labelTimKiem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            labelTimKiem.Location = new Point(1381, 21);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(167, 35);
            labelTimKiem.TabIndex = 34;
            labelTimKiem.Text = "TÌM KIẾM";
            // 
            // frmNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1857, 994);
            Controls.Add(btnHuytim);
            Controls.Add(btnTimKiem);
            Controls.Add(txtNhapThongTin);
            Controls.Add(labelTimKiem);
            Controls.Add(btnHuy);
            Controls.Add(dataGridViewNCC);
            Controls.Add(txtTenNCC);
            Controls.Add(txtSDT);
            Controls.Add(txtDC);
            Controls.Add(txtMaNCC);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNCC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            Load += frmNCC_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNCC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtMaNCC;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtTenNCC;
        private DataGridView dataGridViewNCC;
        private Button btnHuy;
        private Button btnHuytim;
        private Button btnTimKiem;
        private TextBox txtNhapThongTin;
        private Label labelTimKiem;
    }
}