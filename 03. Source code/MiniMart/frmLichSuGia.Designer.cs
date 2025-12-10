namespace WINMART123
{
    partial class frmLichSuGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuGia));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bttnmalsg = new TextBox();
            bttnmahang = new TextBox();
            dtbdgia = new DateTimePicker();
            dtktgia = new DateTimePicker();
            bttnlsggia = new TextBox();
            bttnthemgia = new Button();
            bttnsualsg = new Button();
            bttbxoagia = new Button();
            bttntkgia = new Button();
            cbloc = new ComboBox();
            lblSortStatus = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button1 = new Button();
            button8 = new Button();
            button2 = new Button();
            button7 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 99);
            label1.Name = "label1";
            label1.Size = new Size(230, 29);
            label1.TabIndex = 9;
            label1.Text = "MÃ LỊCH SỬ GIÁ: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 183);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 10;
            label2.Text = "LSG_GIÁ BÁN: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 263);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 11;
            label3.Text = "MÃ HÀNG HÓA: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1043, 103);
            label4.Name = "label4";
            label4.Size = new Size(269, 29);
            label4.TabIndex = 12;
            label4.Text = "NGÀY BẮT ĐẦU GIÁ: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1043, 183);
            label5.Name = "label5";
            label5.Size = new Size(286, 29);
            label5.TabIndex = 13;
            label5.Text = "NGÀY KẾT THÚC GIÁ: ";
            // 
            // bttnmalsg
            // 
            bttnmalsg.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnmalsg.Location = new Point(767, 96);
            bttnmalsg.Name = "bttnmalsg";
            bttnmalsg.Size = new Size(204, 36);
            bttnmalsg.TabIndex = 0;
            // 
            // bttnmahang
            // 
            bttnmahang.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnmahang.Location = new Point(767, 256);
            bttnmahang.Name = "bttnmahang";
            bttnmahang.Size = new Size(204, 36);
            bttnmahang.TabIndex = 2;
            // 
            // dtbdgia
            // 
            dtbdgia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtbdgia.Format = DateTimePickerFormat.Custom;
            dtbdgia.Location = new Point(1452, 97);
            dtbdgia.Name = "dtbdgia";
            dtbdgia.Size = new Size(149, 36);
            dtbdgia.TabIndex = 3;
            dtbdgia.Value = new DateTime(2025, 5, 28, 9, 37, 0, 0);
            dtbdgia.ValueChanged += dtbdgia_ValueChanged;
            // 
            // dtktgia
            // 
            dtktgia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtktgia.Format = DateTimePickerFormat.Custom;
            dtktgia.Location = new Point(1452, 177);
            dtktgia.Name = "dtktgia";
            dtktgia.Size = new Size(149, 36);
            dtktgia.TabIndex = 4;
            // 
            // bttnlsggia
            // 
            bttnlsggia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnlsggia.Location = new Point(767, 176);
            bttnlsggia.Name = "bttnlsggia";
            bttnlsggia.Size = new Size(204, 36);
            bttnlsggia.TabIndex = 14;
            // 
            // bttnthemgia
            // 
            bttnthemgia.BackColor = Color.DarkCyan;
            bttnthemgia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnthemgia.Location = new Point(460, 361);
            bttnthemgia.Name = "bttnthemgia";
            bttnthemgia.Size = new Size(101, 43);
            bttnthemgia.TabIndex = 5;
            bttnthemgia.Text = "THÊM";
            bttnthemgia.UseVisualStyleBackColor = false;
            bttnthemgia.Click += bttnthemgia_Click;
            // 
            // bttnsualsg
            // 
            bttnsualsg.BackColor = Color.DarkCyan;
            bttnsualsg.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnsualsg.Location = new Point(718, 361);
            bttnsualsg.Name = "bttnsualsg";
            bttnsualsg.Size = new Size(101, 43);
            bttnsualsg.TabIndex = 6;
            bttnsualsg.Text = "SỬA";
            bttnsualsg.UseVisualStyleBackColor = false;
            bttnsualsg.Click += bttnsualsg_Click;
            // 
            // bttbxoagia
            // 
            bttbxoagia.BackColor = Color.DarkCyan;
            bttbxoagia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttbxoagia.Location = new Point(983, 361);
            bttbxoagia.Name = "bttbxoagia";
            bttbxoagia.Size = new Size(101, 43);
            bttbxoagia.TabIndex = 7;
            bttbxoagia.Text = "XÓA";
            bttbxoagia.UseVisualStyleBackColor = false;
            bttbxoagia.Click += bttbxoagia_Click;
            // 
            // bttntkgia
            // 
            bttntkgia.BackColor = Color.DarkCyan;
            bttntkgia.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttntkgia.Location = new Point(1228, 361);
            bttntkgia.Name = "bttntkgia";
            bttntkgia.Size = new Size(118, 43);
            bttntkgia.TabIndex = 15;
            bttntkgia.Text = "TÌM KIẾM";
            bttntkgia.UseVisualStyleBackColor = false;
            bttntkgia.Click += bttntkgia_Click;
            // 
            // cbloc
            // 
            cbloc.BackColor = Color.DarkCyan;
            cbloc.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbloc.FormattingEnabled = true;
            cbloc.Location = new Point(1485, 361);
            cbloc.Name = "cbloc";
            cbloc.Size = new Size(101, 37);
            cbloc.TabIndex = 16;
            cbloc.Text = "LỌC";
            cbloc.Click += cbloc_Click;
            // 
            // lblSortStatus
            // 
            lblSortStatus.AutoSize = true;
            lblSortStatus.BackColor = Color.DarkCyan;
            lblSortStatus.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSortStatus.Location = new Point(1271, 283);
            lblSortStatus.Name = "lblSortStatus";
            lblSortStatus.Size = new Size(0, 29);
            lblSortStatus.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 451);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1141, 432);
            dataGridView1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 999);
            panel1.TabIndex = 20;
            // 
            // button10
            // 
            button10.BackColor = Color.SlateBlue;
            button10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(23, 675);
            button10.Name = "button10";
            button10.Size = new Size(266, 68);
            button10.TabIndex = 9;
            button10.Text = "NHÀ CUNG CẤP";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.SlateBlue;
            button9.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(23, 901);
            button9.Name = "button9";
            button9.Size = new Size(266, 68);
            button9.TabIndex = 8;
            button9.Text = "ĐĂNG XUẤT";
            button9.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 132);
            button1.Name = "button1";
            button1.Size = new Size(266, 68);
            button1.TabIndex = 0;
            button1.Text = "KHÁCH HÀNG ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.SlateBlue;
            button8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(23, 788);
            button8.Name = "button8";
            button8.Size = new Size(266, 68);
            button8.TabIndex = 7;
            button8.Text = "CÔNG NỢ ";
            button8.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(27, 28);
            button2.Name = "button2";
            button2.Size = new Size(266, 68);
            button2.TabIndex = 1;
            button2.Text = "TRANG CHỦ ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.SlateBlue;
            button7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(27, 561);
            button7.Name = "button7";
            button7.Size = new Size(266, 68);
            button7.TabIndex = 6;
            button7.Text = "NHÂN VIÊN ";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(27, 243);
            button3.Name = "button3";
            button3.Size = new Size(266, 68);
            button3.TabIndex = 2;
            button3.Text = "BÁN HÀNG ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SlateBlue;
            button6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(27, 459);
            button6.Name = "button6";
            button6.Size = new Size(266, 68);
            button6.TabIndex = 5;
            button6.Text = "LỊCH SỬ GIÁ";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(27, 349);
            button5.Name = "button5";
            button5.Size = new Size(266, 68);
            button5.TabIndex = 4;
            button5.Text = "NHẬP HÀNG ";
            button5.UseVisualStyleBackColor = false;
            // 
            // frmLichSuGia
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1688, 994);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(lblSortStatus);
            Controls.Add(cbloc);
            Controls.Add(bttntkgia);
            Controls.Add(bttbxoagia);
            Controls.Add(bttnsualsg);
            Controls.Add(bttnthemgia);
            Controls.Add(bttnlsggia);
            Controls.Add(dtktgia);
            Controls.Add(dtbdgia);
            Controls.Add(bttnmahang);
            Controls.Add(bttnmalsg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmLichSuGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LỊCH SỬ GIÁ";
            WindowState = FormWindowState.Maximized;
            Load += frmLichSuGia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bttnmalsg;
        private System.Windows.Forms.TextBox bttnmahang;
        private System.Windows.Forms.DateTimePicker dtbdgia;
        private System.Windows.Forms.DateTimePicker dtktgia;
        private System.Windows.Forms.TextBox bttnlsggia;
        private System.Windows.Forms.Button bttnthemgia;
        private System.Windows.Forms.Button bttnsualsg;
        private System.Windows.Forms.Button bttbxoagia;
        private System.Windows.Forms.Button bttntkgia;
        private System.Windows.Forms.ComboBox cbloc;
        private System.Windows.Forms.Label lblSortStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel panel1;
        private Button button10;
        private Button button9;
        private Button button1;
        private Button button8;
        private Button button2;
        private Button button7;
        private Button button3;
        private Button button6;
        private Button button5;
    }
}