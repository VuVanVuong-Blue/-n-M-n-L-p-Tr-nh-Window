namespace GIaoDienLuyenToan.Quản_Lý_Tài_Khoản
{
    partial class QuênMậtKhẩu
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
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnLayMK = new System.Windows.Forms.Button();
            this.lbLaymk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(324, 542);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(201, 31);
            this.btnQuaylai.TabIndex = 26;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnLayMK
            // 
            this.btnLayMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLayMK.ForeColor = System.Drawing.Color.Red;
            this.btnLayMK.Location = new System.Drawing.Point(324, 475);
            this.btnLayMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLayMK.Name = "btnLayMK";
            this.btnLayMK.Size = new System.Drawing.Size(201, 49);
            this.btnLayMK.TabIndex = 25;
            this.btnLayMK.Text = "Lấy lại mật khẩu";
            this.btnLayMK.UseVisualStyleBackColor = false;
            this.btnLayMK.Click += new System.EventHandler(this.btnLayMK_Click);
            // 
            // lbLaymk
            // 
            this.lbLaymk.AutoSize = true;
            this.lbLaymk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaymk.ForeColor = System.Drawing.Color.Blue;
            this.lbLaymk.Location = new System.Drawing.Point(130, 392);
            this.lbLaymk.Name = "lbLaymk";
            this.lbLaymk.Size = new System.Drawing.Size(194, 25);
            this.lbLaymk.TabIndex = 24;
            this.lbLaymk.Text = "Mật khẩu của bạn là:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(326, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(130, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email đăng ký:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(326, 333);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(325, 22);
            this.txtemail.TabIndex = 21;
            // 
            // QuênMậtKhẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 640);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnLayMK);
            this.Controls.Add(this.lbLaymk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Name = "QuênMậtKhẩu";
            this.Text = "QuênMậtKhẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnLayMK;
        private System.Windows.Forms.Label lbLaymk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
    }
}