namespace WINMART
{
    partial class frmDANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDANGNHAP));
            panel2 = new Panel();
            labelTenDN = new Label();
            labelMK = new Label();
            txtTenDN = new TextBox();
            txtMK = new TextBox();
            btnDN = new Button();
            btnHuy = new Button();
            labelCheckMK = new Label();
            labelCheckTenDN = new Label();
            btnHienMK = new Button();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(509, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 265);
            panel2.TabIndex = 20;
            // 
            // labelTenDN
            // 
            labelTenDN.AutoSize = true;
            labelTenDN.BackColor = Color.LightSkyBlue;
            labelTenDN.FlatStyle = FlatStyle.Popup;
            labelTenDN.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelTenDN.ForeColor = SystemColors.ActiveCaptionText;
            labelTenDN.Location = new Point(600, 467);
            labelTenDN.Name = "labelTenDN";
            labelTenDN.Size = new Size(266, 35);
            labelTenDN.TabIndex = 17;
            labelTenDN.Text = "TÊN ĐĂNG NHẬP";
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.BackColor = Color.LightSkyBlue;
            labelMK.FlatStyle = FlatStyle.Popup;
            labelMK.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelMK.ForeColor = SystemColors.ActiveCaptionText;
            labelMK.Location = new Point(600, 539);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(181, 35);
            labelMK.TabIndex = 21;
            labelMK.Text = "MẬT KHẨU";
            // 
            // txtTenDN
            // 
            txtTenDN.Font = new Font("Times New Roman", 16.2F);
            txtTenDN.Location = new Point(936, 464);
            txtTenDN.Margin = new Padding(3, 4, 3, 4);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(344, 39);
            txtTenDN.TabIndex = 22;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Times New Roman", 16.2F);
            txtMK.Location = new Point(936, 532);
            txtMK.Margin = new Padding(3, 4, 3, 4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(344, 39);
            txtMK.TabIndex = 23;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // btnDN
            // 
            btnDN.BackColor = Color.DarkCyan;
            btnDN.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDN.ForeColor = SystemColors.ActiveCaptionText;
            btnDN.Location = new Point(727, 629);
            btnDN.Margin = new Padding(3, 4, 3, 4);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(186, 70);
            btnDN.TabIndex = 35;
            btnDN.Text = "ĐĂNG NHẬP";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkCyan;
            btnHuy.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = SystemColors.ActiveCaptionText;
            btnHuy.Location = new Point(1023, 629);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(174, 70);
            btnHuy.TabIndex = 36;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // labelCheckMK
            // 
            labelCheckMK.AutoSize = true;
            labelCheckMK.BackColor = Color.White;
            labelCheckMK.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckMK.ForeColor = Color.Firebrick;
            labelCheckMK.Location = new Point(1260, 532);
            labelCheckMK.Name = "labelCheckMK";
            labelCheckMK.Size = new Size(20, 23);
            labelCheckMK.TabIndex = 39;
            labelCheckMK.Text = "*";
            // 
            // labelCheckTenDN
            // 
            labelCheckTenDN.AutoSize = true;
            labelCheckTenDN.BackColor = Color.White;
            labelCheckTenDN.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCheckTenDN.ForeColor = Color.Firebrick;
            labelCheckTenDN.Location = new Point(1260, 464);
            labelCheckTenDN.Name = "labelCheckTenDN";
            labelCheckTenDN.Size = new Size(20, 23);
            labelCheckTenDN.TabIndex = 40;
            labelCheckTenDN.Text = "*";
            // 
            // btnHienMK
            // 
            btnHienMK.BackColor = SystemColors.ButtonFace;
            btnHienMK.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienMK.Location = new Point(1276, 529);
            btnHienMK.Name = "btnHienMK";
            btnHienMK.Size = new Size(55, 42);
            btnHienMK.TabIndex = 41;
            btnHienMK.Text = "🙈";
            btnHienMK.UseVisualStyleBackColor = false;
            btnHienMK.Click += btnHienMK_Click;
            // 
            // frmDANGNHAP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1857, 994);
            Controls.Add(btnHienMK);
            Controls.Add(labelCheckTenDN);
            Controls.Add(labelCheckMK);
            Controls.Add(btnHuy);
            Controls.Add(btnDN);
            Controls.Add(txtMK);
            Controls.Add(txtTenDN);
            Controls.Add(labelMK);
            Controls.Add(labelTenDN);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDANGNHAP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            WindowState = FormWindowState.Maximized;
            Load += frmDANGNHAP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label labelTenDN;
        private Label labelMK;
        private TextBox txtTenDN;
        private TextBox txtMK;
        private Button btnDN;
        private Button btnHuy;
        private Label labelCheckMK;
        private Label labelCheckTenDN;
        private Button btnHienMK;
    }
}