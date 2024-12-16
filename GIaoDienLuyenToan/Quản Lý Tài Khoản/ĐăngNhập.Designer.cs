namespace GIaoDienLuyenToan.Quản_Lý_Tài_Khoản
{
    partial class ĐăngNhập
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.linkLabelDangky = new System.Windows.Forms.LinkLabel();
            this.linkLabelQuenMK = new System.Windows.Forms.LinkLabel();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.DimGray;
            this.btnDangnhap.Location = new System.Drawing.Point(294, 498);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(212, 39);
            this.btnDangnhap.TabIndex = 13;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // linkLabelDangky
            // 
            this.linkLabelDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDangky.Location = new System.Drawing.Point(461, 418);
            this.linkLabelDangky.Name = "linkLabelDangky";
            this.linkLabelDangky.Size = new System.Drawing.Size(124, 30);
            this.linkLabelDangky.TabIndex = 12;
            this.linkLabelDangky.TabStop = true;
            this.linkLabelDangky.Text = "Đăng ký";
            this.linkLabelDangky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelDangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangky_LinkClicked);
            // 
            // linkLabelQuenMK
            // 
            this.linkLabelQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuenMK.Location = new System.Drawing.Point(196, 418);
            this.linkLabelQuenMK.Name = "linkLabelQuenMK";
            this.linkLabelQuenMK.Size = new System.Drawing.Size(223, 32);
            this.linkLabelQuenMK.TabIndex = 11;
            this.linkLabelQuenMK.TabStop = true;
            this.linkLabelQuenMK.Text = "Quên mật khẩu?";
            this.linkLabelQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuenMK_LinkClicked);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(294, 354);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(227, 22);
            this.txtmatkhau.TabIndex = 10;
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(294, 275);
            this.txttentaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(227, 22);
            this.txttentaikhoan.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(307, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ĐăngNhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.linkLabelDangky);
            this.Controls.Add(this.linkLabelQuenMK);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ĐăngNhập";
            this.Text = "ĐăngNhập";
            this.Load += new System.EventHandler(this.ĐăngNhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.LinkLabel linkLabelDangky;
        private System.Windows.Forms.LinkLabel linkLabelQuenMK;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}