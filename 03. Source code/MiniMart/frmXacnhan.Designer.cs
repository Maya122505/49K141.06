namespace WINMART123
{
    partial class frmXacNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXacNhan));
            this.bttxnco = new System.Windows.Forms.Button();
            this.bttxnkhong = new System.Windows.Forms.Button();
            this.thongbaoformclose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttxnco
            // 
            this.bttxnco.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttxnco.Location = new System.Drawing.Point(69, 84);
            this.bttxnco.Name = "bttxnco";
            this.bttxnco.Size = new System.Drawing.Size(91, 30);
            this.bttxnco.TabIndex = 0;
            this.bttxnco.Text = "Có";
            this.bttxnco.UseVisualStyleBackColor = true;
            // 
            // bttxnkhong
            // 
            this.bttxnkhong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttxnkhong.Location = new System.Drawing.Point(197, 84);
            this.bttxnkhong.Name = "bttxnkhong";
            this.bttxnkhong.Size = new System.Drawing.Size(91, 30);
            this.bttxnkhong.TabIndex = 1;
            this.bttxnkhong.Text = "Không";
            this.bttxnkhong.UseVisualStyleBackColor = true;
            // 
            // thongbaoformclose
            // 
            this.thongbaoformclose.AutoSize = true;
            this.thongbaoformclose.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongbaoformclose.Location = new System.Drawing.Point(47, 35);
            this.thongbaoformclose.Name = "thongbaoformclose";
            this.thongbaoformclose.Size = new System.Drawing.Size(288, 19);
            this.thongbaoformclose.TabIndex = 2;
            this.thongbaoformclose.Text = "Bạn có chắc muốn đóng form này không?";
            // 
            // frmXacNhan
            // 
            this.ClientSize = new System.Drawing.Size(379, 164);
            this.Controls.Add(this.thongbaoformclose);
            this.Controls.Add(this.bttxnkhong);
            this.Controls.Add(this.bttxnco);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXacNhan";
            this.Text = "Thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttxacnhanco;
        private System.Windows.Forms.Button bttxacnhankhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttxnco;
        private System.Windows.Forms.Button bttxnkhong;
        private System.Windows.Forms.Label thongbaoformclose;
    }
}