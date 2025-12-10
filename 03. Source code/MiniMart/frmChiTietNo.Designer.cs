namespace WINMART
{
    partial class frmChiTietNo : Form
    {
        //Thêm thuộc tính MaNo vào form CTN
        public string sMaNo { get; set; }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietNo));
            btnHuy = new Button();
            btnQuayLai = new Button();
            txtDaTT = new TextBox();
            labelSoTienDTT = new Label();
            txtChuaTT = new TextBox();
            txtMaNH = new TextBox();
            txtMaNo = new TextBox();
            labelMaNH = new Label();
            labelSoTienCTT = new Label();
            labelMaNo = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            dataGridViewCTN = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTN).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkCyan;
            btnHuy.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(879, 408);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(167, 72);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.DarkCyan;
            btnQuayLai.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(-344, 17);
            btnQuayLai.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(167, 72);
            btnQuayLai.TabIndex = 34;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // txtDaTT
            // 
            txtDaTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtDaTT.Location = new Point(1289, 295);
            txtDaTT.Margin = new Padding(3, 4, 3, 4);
            txtDaTT.Name = "txtDaTT";
            txtDaTT.Size = new Size(241, 42);
            txtDaTT.TabIndex = 33;
            // 
            // labelSoTienDTT
            // 
            labelSoTienDTT.AutoSize = true;
            labelSoTienDTT.BackColor = Color.LightSkyBlue;
            labelSoTienDTT.FlatStyle = FlatStyle.Flat;
            labelSoTienDTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelSoTienDTT.Location = new Point(1005, 309);
            labelSoTienDTT.Name = "labelSoTienDTT";
            labelSoTienDTT.Size = new Size(235, 35);
            labelSoTienDTT.TabIndex = 32;
            labelSoTienDTT.Text = "SỐ TIỀN ĐÃ TT";
            // 
            // txtChuaTT
            // 
            txtChuaTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtChuaTT.Location = new Point(1289, 205);
            txtChuaTT.Margin = new Padding(3, 4, 3, 4);
            txtChuaTT.Name = "txtChuaTT";
            txtChuaTT.Size = new Size(242, 42);
            txtChuaTT.TabIndex = 31;
            // 
            // txtMaNH
            // 
            txtMaNH.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtMaNH.Location = new Point(654, 305);
            txtMaNH.Margin = new Padding(3, 4, 3, 4);
            txtMaNH.Name = "txtMaNH";
            txtMaNH.Size = new Size(257, 42);
            txtMaNH.TabIndex = 30;
            // 
            // txtMaNo
            // 
            txtMaNo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtMaNo.Location = new Point(654, 205);
            txtMaNo.Margin = new Padding(3, 4, 3, 4);
            txtMaNo.Name = "txtMaNo";
            txtMaNo.Size = new Size(257, 42);
            txtMaNo.TabIndex = 29;
            // 
            // labelMaNH
            // 
            labelMaNH.AutoSize = true;
            labelMaNH.BackColor = Color.BlueViolet;
            labelMaNH.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelMaNH.Location = new Point(-330, 269);
            labelMaNH.Name = "labelMaNH";
            labelMaNH.Size = new Size(254, 35);
            labelMaNH.TabIndex = 28;
            labelMaNH.Text = "MÃ NHẬP HÀNG";
            // 
            // labelSoTienCTT
            // 
            labelSoTienCTT.AutoSize = true;
            labelSoTienCTT.BackColor = Color.LightSkyBlue;
            labelSoTienCTT.FlatStyle = FlatStyle.Popup;
            labelSoTienCTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelSoTienCTT.Location = new Point(1005, 212);
            labelSoTienCTT.Name = "labelSoTienCTT";
            labelSoTienCTT.Size = new Size(279, 35);
            labelSoTienCTT.TabIndex = 27;
            labelSoTienCTT.Text = "SỐ TIỀN CHƯA TT";
            // 
            // labelMaNo
            // 
            labelMaNo.AutoSize = true;
            labelMaNo.BackColor = Color.BlueViolet;
            labelMaNo.FlatStyle = FlatStyle.Popup;
            labelMaNo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelMaNo.Location = new Point(-330, 149);
            labelMaNo.Name = "labelMaNo";
            labelMaNo.Size = new Size(118, 35);
            labelMaNo.TabIndex = 26;
            labelMaNo.Text = "MÃ NỢ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(384, 33);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 72);
            button1.TabIndex = 38;
            button1.Text = "QUAY LẠI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnQuayLai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.Location = new Point(389, 307);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 37;
            label1.Text = "MÃ NHẬP HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.Location = new Point(389, 208);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 36;
            label2.Text = "MÃ NỢ";
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 999);
            panel1.TabIndex = 39;
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
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // dataGridViewCTN
            // 
            dataGridViewCTN.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCTN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCTN.BackgroundColor = Color.LightCyan;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCTN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCTN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCTN.Location = new Point(344, 499);
            dataGridViewCTN.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCTN.Name = "dataGridViewCTN";
            dataGridViewCTN.RowHeadersWidth = 51;
            dataGridViewCTN.Size = new Size(1343, 481);
            dataGridViewCTN.TabIndex = 40;
            dataGridViewCTN.CellClick += dataGridViewCTN_CellClick;
            // 
            // frmChiTietNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1688, 994);
            Controls.Add(dataGridViewCTN);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(btnQuayLai);
            Controls.Add(txtDaTT);
            Controls.Add(labelSoTienDTT);
            Controls.Add(txtChuaTT);
            Controls.Add(txtMaNH);
            Controls.Add(txtMaNo);
            Controls.Add(labelMaNH);
            Controls.Add(labelSoTienCTT);
            Controls.Add(labelMaNo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChiTietNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHI TIẾT NỢ";
            WindowState = FormWindowState.Maximized;
            FormClosing += CTN_FormClosing;
            Load += CTN_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Button btnQuayLai;
        private TextBox txtDaTT;
        private Label labelSoTienDTT;
        private TextBox txtChuaTT;
        private TextBox txtMaNH;
        private TextBox txtMaNo;
        private Label labelMaNH;
        private Label labelSoTienCTT;
        private Label labelMaNo;
        private Button button1;
        private Label label1;
        private Label label2;
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
        private DataGridView dataGridViewCTN;
    }
}