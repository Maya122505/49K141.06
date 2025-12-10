using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace WINMART
{
    public partial class frmTraNo : Form
    {
        public string sMaNo { get; set; }
        string sConnect = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=WINMART1TR;Integrated Security=True;Encrypt=False";
        public frmTraNo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmTraNo));
            labelMaNo = new Label();
            labelTenNCC = new Label();
            labelSoTienDaTra = new Label();
            txtMaNo = new TextBox();
            txtSoTienMuonTra = new TextBox();
            txtTenNCC = new TextBox();
            btnHuy = new Button();
            btnLamMoi = new Button();
            labelPTTT = new Label();
            comboBoxPTTT = new ComboBox();
            dataGridViewTraNo = new DataGridView();
            btnQuayLai = new Button();
            btnHuytim = new Button();
            btnTimKiem = new Button();
            txtNhapThongTin = new TextBox();
            labelTimKiem = new Label();
            btnTraNo = new Button();
            labelNgayTT = new Label();
            dateTimePickerNgayTT = new DateTimePicker();
            labelCheckMN = new Label();
            labelCheckSoTien = new Label();
            labelCheckPTTT = new Label();
            labelCheckNCC = new Label();
            panel3 = new Panel();
            btnDangXuat = new Button();
            btnHangHoa = new Button();
            btnCongNo = new Button();
            btnNCC = new Button();
            btnNhanVien = new Button();
            btnLichSuGia = new Button();
            btnNhapHang = new Button();
            btnBanHang = new Button();
            btnKhachHang = new Button();
            btnTrangChu = new Button();
            ((ISupportInitialize)dataGridViewTraNo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelMaNo
            // 
            labelMaNo.AutoSize = true;
            labelMaNo.BackColor = Color.LightSkyBlue;
            labelMaNo.FlatStyle = FlatStyle.Popup;
            labelMaNo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelMaNo.ForeColor = SystemColors.ActiveCaptionText;
            labelMaNo.Location = new Point(680, 152);
            labelMaNo.Name = "labelMaNo";
            labelMaNo.Size = new Size(118, 35);
            labelMaNo.TabIndex = 16;
            labelMaNo.Text = "MÃ NỢ";
            // 
            // labelTenNCC
            // 
            labelTenNCC.AutoSize = true;
            labelTenNCC.BackColor = Color.LightSkyBlue;
            labelTenNCC.FlatStyle = FlatStyle.Popup;
            labelTenNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelTenNCC.ForeColor = SystemColors.ActiveCaptionText;
            labelTenNCC.Location = new Point(680, 206);
            labelTenNCC.Name = "labelTenNCC";
            labelTenNCC.Size = new Size(319, 35);
            labelTenNCC.TabIndex = 17;
            labelTenNCC.Text = "TÊN NHÀ CUNG CẤP";
            // 
            // labelSoTienDaTra
            // 
            labelSoTienDaTra.AutoSize = true;
            labelSoTienDaTra.BackColor = Color.LightSkyBlue;
            labelSoTienDaTra.FlatStyle = FlatStyle.Popup;
            labelSoTienDaTra.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelSoTienDaTra.ForeColor = SystemColors.ActiveCaptionText;
            labelSoTienDaTra.Location = new Point(680, 263);
            labelSoTienDaTra.Name = "labelSoTienDaTra";
            labelSoTienDaTra.Size = new Size(258, 35);
            labelSoTienDaTra.TabIndex = 18;
            labelSoTienDaTra.Text = "SỐ TIỀN ĐÃ TRẢ";
            // 
            // txtMaNo
            // 
            txtMaNo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtMaNo.Location = new Point(1045, 152);
            txtMaNo.Margin = new Padding(3, 4, 3, 4);
            txtMaNo.Name = "txtMaNo";
            txtMaNo.Size = new Size(344, 42);
            txtMaNo.TabIndex = 20;
            txtMaNo.TextChanged += txtMaNo_TextChanged;
            // 
            // txtSoTienMuonTra
            // 
            txtSoTienMuonTra.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtSoTienMuonTra.Location = new Point(1045, 269);
            txtSoTienMuonTra.Margin = new Padding(3, 4, 3, 4);
            txtSoTienMuonTra.Name = "txtSoTienMuonTra";
            txtSoTienMuonTra.Size = new Size(502, 42);
            txtSoTienMuonTra.TabIndex = 21;
            txtSoTienMuonTra.TextChanged += txtSoTienMuonTra_TextChanged;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            txtTenNCC.Location = new Point(1045, 212);
            txtTenNCC.Margin = new Padding(3, 4, 3, 4);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(502, 42);
            txtTenNCC.TabIndex = 23;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkCyan;
            btnHuy.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = SystemColors.ActiveCaptionText;
            btnHuy.Location = new Point(1248, 435);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(146, 72);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkCyan;
            btnLamMoi.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(1031, 435);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(151, 72);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // labelPTTT
            // 
            labelPTTT.AutoSize = true;
            labelPTTT.BackColor = Color.LightSkyBlue;
            labelPTTT.FlatStyle = FlatStyle.Popup;
            labelPTTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelPTTT.ForeColor = SystemColors.ActiveCaptionText;
            labelPTTT.Location = new Point(680, 368);
            labelPTTT.Name = "labelPTTT";
            labelPTTT.Size = new Size(292, 35);
            labelPTTT.TabIndex = 26;
            labelPTTT.Text = "PHƯƠNG THỨC TT";
            // 
            // comboBoxPTTT
            // 
            comboBoxPTTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPTTT.FormattingEnabled = true;
            comboBoxPTTT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            comboBoxPTTT.Location = new Point(1045, 369);
            comboBoxPTTT.Name = "comboBoxPTTT";
            comboBoxPTTT.Size = new Size(344, 43);
            comboBoxPTTT.TabIndex = 27;
            // 
            // dataGridViewTraNo
            // 
            dataGridViewTraNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTraNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTraNo.BackgroundColor = Color.LightCyan;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTraNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTraNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTraNo.Location = new Point(318, 531);
            dataGridViewTraNo.Name = "dataGridViewTraNo";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTraNo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTraNo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewTraNo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTraNo.Size = new Size(1597, 476);
            dataGridViewTraNo.TabIndex = 28;
            dataGridViewTraNo.CellClick += dataGridViewTraNo_CellClick;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.DarkCyan;
            btnQuayLai.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = SystemColors.ActiveCaptionText;
            btnQuayLai.Location = new Point(353, 23);
            btnQuayLai.Margin = new Padding(3, 4, 3, 4);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(176, 70);
            btnQuayLai.TabIndex = 29;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnHuytim
            // 
            btnHuytim.BackColor = Color.DarkCyan;
            btnHuytim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuytim.ForeColor = SystemColors.ActiveCaptionText;
            btnHuytim.Location = new Point(1765, 71);
            btnHuytim.Name = "btnHuytim";
            btnHuytim.Size = new Size(108, 60);
            btnHuytim.TabIndex = 33;
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
            btnTimKiem.Location = new Point(1610, 71);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 60);
            btnTimKiem.TabIndex = 32;
            btnTimKiem.Text = "TÌM";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Visible = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtNhapThongTin
            // 
            txtNhapThongTin.BackColor = SystemColors.GradientInactiveCaption;
            txtNhapThongTin.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNhapThongTin.Location = new Point(1610, 33);
            txtNhapThongTin.Name = "txtNhapThongTin";
            txtNhapThongTin.Size = new Size(263, 27);
            txtNhapThongTin.TabIndex = 31;
            txtNhapThongTin.Text = "Nhập mã hoặc tên nhà cung cấp...";
            txtNhapThongTin.Click += txtNhapThongTin_Click;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.BackColor = Color.BlueViolet;
            labelTimKiem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            labelTimKiem.Location = new Point(1424, 23);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(167, 35);
            labelTimKiem.TabIndex = 30;
            labelTimKiem.Text = "TÌM KIẾM";
            // 
            // btnTraNo
            // 
            btnTraNo.BackColor = Color.DarkCyan;
            btnTraNo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraNo.ForeColor = SystemColors.ActiveCaptionText;
            btnTraNo.Location = new Point(802, 435);
            btnTraNo.Margin = new Padding(3, 4, 3, 4);
            btnTraNo.Name = "btnTraNo";
            btnTraNo.Size = new Size(174, 70);
            btnTraNo.TabIndex = 34;
            btnTraNo.Text = "XÁC NHẬN ĐÃ TRẢ";
            btnTraNo.UseVisualStyleBackColor = false;
            btnTraNo.Click += btnTraNo_Click;
            // 
            // labelNgayTT
            // 
            labelNgayTT.AutoSize = true;
            labelNgayTT.BackColor = Color.LightSkyBlue;
            labelNgayTT.FlatStyle = FlatStyle.Popup;
            labelNgayTT.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelNgayTT.ForeColor = SystemColors.ActiveCaptionText;
            labelNgayTT.Location = new Point(680, 316);
            labelNgayTT.Name = "labelNgayTT";
            labelNgayTT.Size = new Size(312, 35);
            labelNgayTT.TabIndex = 35;
            labelNgayTT.Text = "NGÀY THANH TOÁN";
            // 
            // dateTimePickerNgayTT
            // 
            dateTimePickerNgayTT.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerNgayTT.CustomFormat = "yyyy-dd-MM";
            dateTimePickerNgayTT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerNgayTT.Location = new Point(1045, 325);
            dateTimePickerNgayTT.Name = "dateTimePickerNgayTT";
            dateTimePickerNgayTT.Size = new Size(343, 30);
            dateTimePickerNgayTT.TabIndex = 36;
            dateTimePickerNgayTT.UseWaitCursor = true;
            // 
            // labelCheckMN
            // 
            labelCheckMN.AutoSize = true;
            labelCheckMN.BackColor = Color.White;
            labelCheckMN.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckMN.ForeColor = Color.Firebrick;
            labelCheckMN.Location = new Point(1371, 152);
            labelCheckMN.Name = "labelCheckMN";
            labelCheckMN.Size = new Size(20, 23);
            labelCheckMN.TabIndex = 37;
            labelCheckMN.Text = "*";
            // 
            // labelCheckSoTien
            // 
            labelCheckSoTien.AutoSize = true;
            labelCheckSoTien.BackColor = Color.White;
            labelCheckSoTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckSoTien.ForeColor = Color.Firebrick;
            labelCheckSoTien.Location = new Point(1527, 269);
            labelCheckSoTien.Name = "labelCheckSoTien";
            labelCheckSoTien.Size = new Size(20, 23);
            labelCheckSoTien.TabIndex = 42;
            labelCheckSoTien.Text = "*";
            // 
            // labelCheckPTTT
            // 
            labelCheckPTTT.AutoSize = true;
            labelCheckPTTT.BackColor = Color.White;
            labelCheckPTTT.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckPTTT.ForeColor = Color.Firebrick;
            labelCheckPTTT.Location = new Point(1353, 377);
            labelCheckPTTT.Name = "labelCheckPTTT";
            labelCheckPTTT.Size = new Size(20, 23);
            labelCheckPTTT.TabIndex = 44;
            labelCheckPTTT.Text = "*";
            // 
            // labelCheckNCC
            // 
            labelCheckNCC.AutoSize = true;
            labelCheckNCC.BackColor = Color.LightSkyBlue;
            labelCheckNCC.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckNCC.ForeColor = Color.White;
            labelCheckNCC.Location = new Point(804, 171);
            labelCheckNCC.Name = "labelCheckNCC";
            labelCheckNCC.Size = new Size(0, 23);
            labelCheckNCC.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(btnDangXuat);
            panel3.Controls.Add(btnHangHoa);
            panel3.Controls.Add(btnCongNo);
            panel3.Controls.Add(btnNCC);
            panel3.Controls.Add(btnNhanVien);
            panel3.Controls.Add(btnLichSuGia);
            panel3.Controls.Add(btnNhapHang);
            panel3.Controls.Add(btnBanHang);
            panel3.Controls.Add(btnKhachHang);
            panel3.Controls.Add(btnTrangChu);
            panel3.Location = new Point(1, -9);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 1016);
            panel3.TabIndex = 45;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.SlateBlue;
            btnDangXuat.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnDangXuat.ForeColor = SystemColors.ActiveCaptionText;
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
            btnHangHoa.ForeColor = SystemColors.ActiveCaptionText;
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
            btnCongNo.ForeColor = SystemColors.ActiveCaptionText;
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
            btnNCC.ForeColor = SystemColors.ActiveCaptionText;
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
            btnNhanVien.ForeColor = SystemColors.ActiveCaptionText;
            btnNhanVien.Location = new Point(27, 594);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(266, 73);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "NHÂN VIÊN";
            btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnLichSuGia
            // 
            btnLichSuGia.BackColor = Color.SlateBlue;
            btnLichSuGia.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnLichSuGia.ForeColor = SystemColors.ActiveCaptionText;
            btnLichSuGia.Location = new Point(27, 500);
            btnLichSuGia.Name = "btnLichSuGia";
            btnLichSuGia.Size = new Size(266, 73);
            btnLichSuGia.TabIndex = 4;
            btnLichSuGia.Text = "LỊCH SỬ GIÁ";
            btnLichSuGia.UseVisualStyleBackColor = false;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.SlateBlue;
            btnNhapHang.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNhapHang.ForeColor = SystemColors.ActiveCaptionText;
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
            btnBanHang.ForeColor = SystemColors.ActiveCaptionText;
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
            btnKhachHang.ForeColor = SystemColors.ActiveCaptionText;
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
            btnTrangChu.ForeColor = SystemColors.ActiveCaptionText;
            btnTrangChu.Location = new Point(27, 36);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(266, 68);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "TRANG CHỦ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // frmTraNo
            // 
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1915, 994);
            Controls.Add(panel3);
            Controls.Add(labelCheckPTTT);
            Controls.Add(labelCheckNCC);
            Controls.Add(labelCheckSoTien);
            Controls.Add(labelCheckMN);
            Controls.Add(dateTimePickerNgayTT);
            Controls.Add(labelNgayTT);
            Controls.Add(btnTraNo);
            Controls.Add(btnHuytim);
            Controls.Add(btnTimKiem);
            Controls.Add(txtNhapThongTin);
            Controls.Add(labelTimKiem);
            Controls.Add(btnQuayLai);
            Controls.Add(dataGridViewTraNo);
            Controls.Add(comboBoxPTTT);
            Controls.Add(labelPTTT);
            Controls.Add(btnLamMoi);
            Controls.Add(btnHuy);
            Controls.Add(txtTenNCC);
            Controls.Add(txtSoTienMuonTra);
            Controls.Add(txtMaNo);
            Controls.Add(labelSoTienDaTra);
            Controls.Add(labelTenNCC);
            Controls.Add(labelMaNo);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTraNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TRẢ NỢ";
            WindowState = FormWindowState.Maximized;
            Load += frmTraNo_Load;
            ((ISupportInitialize)dataGridViewTraNo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTenNCC;
        private Label labelSoTienDaTra;
        private TextBox txtMaNo;
        private TextBox txtSoTienMuonTra;
        private TextBox txtTenNCC;
        private Button btnHuy;
        private Button btnLamMoi;
        private Label labelPTTT;
        private ComboBox comboBoxPTTT;
        private DataGridView dataGridViewTraNo;
        private Button btnQuayLai;
        private Button btnHuytim;
        private Button btnTimKiem;
        private TextBox txtNhapThongTin;
        private Label labelTimKiem;
        private Button btnTraNo;
        private Label labelNgayTT;
        private DateTimePicker dateTimePickerNgayTT;
        private Label labelCheckMN;
        private Label labelCheckSoTien;
        private Label labelCheckPTTT;
        private Label labelCheckNCC;
        private Panel panel3;
        private Button btnDangXuat;
        private Button btnHangHoa;
        private Button btnCongNo;
        private Button btnNCC;
        private Button btnNhanVien;
        private Button btnLichSuGia;
        private Button btnNhapHang;
        private Button btnBanHang;
        private Button btnKhachHang;
        private Button btnTrangChu;
        private Label labelMaNo;

        private void frmTraNo_Load(object sender, EventArgs e)
        {
            //Mở kết nối database
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Tự động điền MaNo
            txtMaNo.Text = sMaNo;
            //Tự động điền tên NCC
            if (sMaNo != null)
            {
                //Nếu có giá trị MaNo thì gán tên NCC vào.
                string sQueryTenNCC = "select TenNCC \r\n" +
                                       "from NhaCungCap ncc join TongNo tn on ncc.MaNCC = tn.MaNCC\r\n" +
                                       "where MaNo = @MaNo ";
                SqlDataAdapter adapter = new SqlDataAdapter(sQueryTenNCC, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MaNo", sMaNo);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)      // Kiểm tra có dữ liệu hay không trước khi gán vào TextBox
                {
                    txtTenNCC.Text = dt.Rows[0]["TenNCC"].ToString();
                }
                else
                {
                    txtTenNCC.Text = "Không tìm thấy thông tin NCC";
                }
                //Hiển thông tin của NCC ở phần DataGridView
                string sQueryTTNCC = "SELECT NCC.MaNCC as 'Mã NCC', TenNCC as 'Tên NCC', NCC_DiaChi as \"Địa chỉ NCC\", NCC_SDT as \"Số điện thoại NCC\", MaNo as 'Mã nợ', Tongtienno as 'Số tiền còn nợ'\r\n" +
                                      "FROM NhaCungCap NCC JOIN TongNo TN ON NCC.MaNCC = TN.MaNCC" +
                                      " WHERE MaNo = @MaNo";

                SqlDataAdapter adapter2 = new SqlDataAdapter(sQueryTTNCC, con);
                adapter2.SelectCommand.Parameters.AddWithValue("@MaNo", sMaNo);

                DataSet ds = new DataSet();
                adapter2.Fill(ds, "NhaCungCap");

                dataGridViewTraNo.DataSource = ds.Tables["NhaCungCap"];
            }
            else
            {
                //Nếu không có sẵn MaNo thì ẩn đi các nút LÀM MỚI, HỦY, TRẢ NỢ
                btnTraNo.Visible = false;
                btnLamMoi.Visible = false;
                btnHuy.Visible = false;

                //Nếu không có sẵn MaNo thì xuất toàn bộ các thông tin trong bảng NhaCungCap
                string sQueryTTNCC = "SELECT NCC.MaNCC as 'Mã NCC', TenNCC as 'Tên NCC', NCC_DiaChi as \"Địa chỉ NCC\", NCC_SDT as \"Số điện thoại NCC\", MaNo as 'Mã nợ', Tongtienno as 'Số tiền còn nợ'\r\n" +
                                      "FROM NhaCungCap NCC JOIN TongNo TN ON NCC.MaNCC = TN.MaNCC";

                SqlDataAdapter adapter = new SqlDataAdapter(sQueryTTNCC, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "NhaCungCap");

                dataGridViewTraNo.DataSource = ds.Tables["NhaCungCap"];
            }

            con.Close();

            //Ẩn các nút Check
            labelCheckMN.Visible = false;
            labelCheckPTTT.Visible = false;
            labelCheckSoTien.Visible = false;

            //Không cho chỉnh sửa tên NCC
            txtTenNCC.Enabled = false;

        }
        private void txtSoTienMuonTra_TextChanged(object sender, EventArgs e)
        {
            string raw = txtSoTienMuonTra.Text.Replace(",", "");

            if (decimal.TryParse(raw, out decimal value))
            {
                // Định dạng lại với dấu phẩy
                txtSoTienMuonTra.Text = string.Format("{0:N0}", value);

                // Đặt con trỏ về cuối 
                txtSoTienMuonTra.SelectionStart = txtSoTienMuonTra.Text.Length;
            }

            // Kết nối lại sự kiện
            txtSoTienMuonTra.TextChanged += txtSoTienMuonTra_TextChanged;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();       //Khi bấm nút quay lại sẽ đóng form
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sQuery = "SELECT NCC.MaNCC as 'Mã NCC', TenNCC as 'Tên NCC', NCC_DiaChi as \"Địa chỉ NCC\", NCC_SDT as \"Số điện thoại NCC\", MaNo as 'Mã nợ', Tongtienno as 'Số tiền còn nợ'\r\n " +
                            "FROM NhaCungCap NCC JOIN TongNo TN ON NCC.MaNCC = TN.MaNCC\r\n " +
                            "WHERE MaNo = @textTimKiem OR TenNCC LIKE '%' + @textTimKiem +'%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            adapter.SelectCommand.Parameters.AddWithValue("@textTimKiem", txtNhapThongTin.Text);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "ThongTinCanTim");

            dataGridViewTraNo.DataSource = ds.Tables["ThongTinCanTim"];

            con.Close();
        }

        private void txtNhapThongTin_Click(object sender, EventArgs e)
        {
            //Khi click vào thì thành ô trắng để tìm kiếm
            txtNhapThongTin.Text = "";
            //Khi click vào thì nút tìm và hủy
            btnHuytim.Visible = true;
            btnTimKiem.Visible = true;
            //Ẩn các nút Check
            labelCheckMN.Visible = false;
            labelCheckPTTT.Visible = false;
            labelCheckSoTien.Visible = false;
        }

        private void dataGridViewTraNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi bấm vào hiện thông tin lên ô tìm kiếm
            txtMaNo.Text = dataGridViewTraNo.Rows[e.RowIndex].Cells["Mã nợ"].Value.ToString();
            txtTenNCC.Text = dataGridViewTraNo.Rows[e.RowIndex].Cells["Tên NCC"].Value.ToString();
            //Hiện nút XACNHANTRA, HUY, LAMMOI
            btnTraNo.Visible = true;
            btnLamMoi.Visible = true;
            btnHuy.Visible = true;
            //Ẩn các nút Check
            labelCheckMN.Visible = false;
            labelCheckPTTT.Visible = false;
            labelCheckSoTien.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Khi bấm vào nút HUY sẽ mất đi thông tin tên mục.
            txtMaNo.Text = "";
            txtSoTienMuonTra.Text = "";
            txtTenNCC.Text = "";
            comboBoxPTTT.Text = "";
            //Bảng datagridview được làm mới.
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sQueryTTNCC = "SELECT NCC.MaNCC as 'Mã NCC', TenNCC as 'Tên NCC', NCC_DiaChi as \"Địa chỉ NCC\", NCC_SDT as \"Số điện thoại NCC\", MaNo as 'Mã nợ', Tongtienno as 'Số tiền còn nợ'\r\n" +
                                 "FROM NhaCungCap NCC JOIN TongNo TN ON NCC.MaNCC = TN.MaNCC";

            SqlDataAdapter adapter = new SqlDataAdapter(sQueryTTNCC, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhaCungCap");

            dataGridViewTraNo.DataSource = ds.Tables["NhaCungCap"];
            //Ẩn các nút Check
            labelCheckMN.Visible = false;
            labelCheckPTTT.Visible = false;
            labelCheckSoTien.Visible = false;
        }

        private void btnHuytim_Click(object sender, EventArgs e)
        {
            //Thông tin trong ô tìm kiếm sẽ biến mất và các nút TIMKIEM và HUYTIMKIEM sẽ bị ẩn đi
            txtNhapThongTin.Text = "";
            btnTimKiem.Visible = false;
            btnHuytim.Visible = false;
            //Thông tin trong ô tìm kiếm sẽ quay lại như ban đầu
            txtNhapThongTin.Text = "Nhập mã hoặc tên nhà cung cấp...";
            //Ẩn các nút Check
            labelCheckMN.Visible = false;
            labelCheckPTTT.Enabled = false;
            labelCheckNCC.Enabled = false;
            labelCheckSoTien.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Khi click vào làm mới sẽ làm mới mục datagridview
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sQueryTTNCC = "SELECT NCC.MaNCC as 'Mã NCC', TenNCC as 'Tên NCC', NCC_DiaChi as \"Địa chỉ NCC\", NCC_SDT as \"Số điện thoại NCC\", MaNo as 'Mã nợ', Tongtienno as 'Số tiền còn nợ'\r\n" +
                                  "FROM NhaCungCap NCC JOIN TongNo TN ON NCC.MaNCC = TN.MaNCC";

            SqlDataAdapter adapter = new SqlDataAdapter(sQueryTTNCC, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhaCungCap");

            dataGridViewTraNo.DataSource = ds.Tables["NhaCungCap"];
        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            //Xác nhận lần 2
            DialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn thực hiện yêu cầu này",
                "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.No)
            {
                return;
            }

            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Lấy dữ liệu từ các Textbox
            string sMaNo = txtMaNo.Text;
            string sSoTien = txtSoTienMuonTra.Text;
            decimal dSoTien = 0;
            if (sSoTien != "")
            {
                dSoTien = decimal.Parse(sSoTien.Replace(",", ""));  // Xoá dấu phẩy nếu có
            }
            string sPTTT = comboBoxPTTT.Text;
            DateTime sNgayTT = dateTimePickerNgayTT.Value.Date;

            //Kiểm tra trước khi nhập dữ liệu
            string Check = "True";
            if (sMaNo == "")
            {
                labelCheckMN.Visible = true;
                Check = "Thiếu TT";
            }
            if (sPTTT == "")
            {
                labelCheckPTTT.Visible = true;
                Check = "Thiếu TT";
            }
            if (sSoTien == "")
            {
                labelCheckSoTien.Visible = true;
                Check = "Thiếu TT";
            }

            //Nếu thiếu thông tin thì dừng hoạt động
            if (Check == "Thiếu TT")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            //Thực hiện chạy proc
            SqlCommand cmd = new SqlCommand("spThanhtoanNo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NgThanhToan", sNgayTT);
            cmd.Parameters.AddWithValue("@SoTienTT", dSoTien);
            cmd.Parameters.AddWithValue("@PTTT", sPTTT);
            cmd.Parameters.AddWithValue("@MaNo", sMaNo);


            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Bit);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);
            bool Ketqua = false;

            //Thực hiện chạy dữ liệu, thông báo nếu gặp lỗi.
            try
            {
                cmd.ExecuteNonQuery();
                Ketqua = (bool)retParam.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Việc thực hiện yêu cầu gặp lỗi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }

            if (Ketqua == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi \nYêu cầu kiểm tra lại thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        //Nếu MaNo thay đổi thì tên NCC sẽ thay đổi theo, nếu không có thì để trống
        private void txtMaNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sConnect);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp lỗi khi truy cập dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string sMaNoChange = txtMaNo.Text;
            string sQueryTenNCC = "select TenNCC \r\n" +
                                   "from NhaCungCap ncc join TongNo tn on ncc.MaNCC = tn.MaNCC\r\n" +
                                   "where MaNo = @MaNo";
            SqlDataAdapter adapter = new SqlDataAdapter(sQueryTenNCC, con);
            adapter.SelectCommand.Parameters.AddWithValue("@MaNo", sMaNoChange);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)      // Kiểm tra có dữ liệu hay không trước khi gán vào TextBox
            {
                txtTenNCC.Text = dt.Rows[0]["TenNCC"].ToString();
            }
            else
            {
                txtTenNCC.Text = "";
            }
        }
    }
}

