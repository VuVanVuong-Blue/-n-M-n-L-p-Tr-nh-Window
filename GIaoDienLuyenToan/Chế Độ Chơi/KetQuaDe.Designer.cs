namespace GIaoDienLuyenToan.Chế_Độ_Chơi
{
    partial class KetQuaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KetQuaDe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKL = new System.Windows.Forms.TextBox();
            this.txtSai = new System.Windows.Forms.TextBox();
            this.txtDung = new System.Windows.Forms.TextBox();
            this.dgvBangKetQua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dạngcâuhỏi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKL);
            this.groupBox1.Controls.Add(this.txtSai);
            this.groupBox1.Controls.Add(this.txtDung);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(708, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Thành Tích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kỷ lục của bạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số câu sai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số câu đúng";
            // 
            // txtKL
            // 
            this.txtKL.Location = new System.Drawing.Point(135, 167);
            this.txtKL.Name = "txtKL";
            this.txtKL.Size = new System.Drawing.Size(178, 33);
            this.txtKL.TabIndex = 1;
            // 
            // txtSai
            // 
            this.txtSai.Location = new System.Drawing.Point(135, 108);
            this.txtSai.Name = "txtSai";
            this.txtSai.Size = new System.Drawing.Size(100, 33);
            this.txtSai.TabIndex = 1;
            // 
            // txtDung
            // 
            this.txtDung.Location = new System.Drawing.Point(135, 55);
            this.txtDung.Name = "txtDung";
            this.txtDung.Size = new System.Drawing.Size(100, 33);
            this.txtDung.TabIndex = 0;
            // 
            // dgvBangKetQua
            // 
            this.dgvBangKetQua.AllowUserToAddRows = false;
            this.dgvBangKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangKetQua.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBangKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dạngcâuhỏi,
            this.Column2,
            this.Column3});
            this.dgvBangKetQua.Location = new System.Drawing.Point(12, 132);
            this.dgvBangKetQua.Name = "dgvBangKetQua";
            this.dgvBangKetQua.RowHeadersWidth = 51;
            this.dgvBangKetQua.RowTemplate.Height = 24;
            this.dgvBangKetQua.Size = new System.Drawing.Size(694, 388);
            this.dgvBangKetQua.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1177, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = "KẾT QUẢ CỦA BẠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pExit
            // 
            this.pExit.Image = ((System.Drawing.Image)(resources.GetObject("pExit.Image")));
            this.pExit.Location = new System.Drawing.Point(968, 516);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(46, 34);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pExit.TabIndex = 12;
            this.pExit.TabStop = false;
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 6.50531F;
            this.Column3.HeaderText = "Đáp án đúng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 100.9813F;
            this.Column2.HeaderText = "Đáp án chọn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dạngcâuhỏi
            // 
            this.Dạngcâuhỏi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dạngcâuhỏi.FillWeight = 192.5134F;
            this.Dạngcâuhỏi.HeaderText = "Câu hỏi";
            this.Dạngcâuhỏi.MinimumWidth = 6;
            this.Dạngcâuhỏi.Name = "Dạngcâuhỏi";
            this.Dạngcâuhỏi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // KetQuaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 768);
            this.Controls.Add(this.pExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBangKetQua);
            this.Name = "KetQuaDe";
            this.Text = "KetQuaDe";
            this.Load += new System.EventHandler(this.KetQuaDe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKL;
        private System.Windows.Forms.TextBox txtSai;
        private System.Windows.Forms.TextBox txtDung;
        private System.Windows.Forms.DataGridView dgvBangKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dạngcâuhỏi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}