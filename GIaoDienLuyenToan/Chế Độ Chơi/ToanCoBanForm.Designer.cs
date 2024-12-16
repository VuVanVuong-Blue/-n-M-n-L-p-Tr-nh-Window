namespace GIaoDienLuyenToan.Chế_Độ_Chơi
{
    partial class ToanCoBanForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToanCoBanForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(701, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(57, 142);
            this.ProgressBar.Maximum = 60;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(674, 27);
            this.ProgressBar.Step = 0;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 43;
            this.ProgressBar.Value = 60;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(33, 68);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(96, 36);
            this.lblTimer.TabIndex = 42;
            this.lblTimer.Text = "Time";
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOption4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.Location = new System.Drawing.Point(470, 554);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(122, 69);
            this.btnOption4.TabIndex = 41;
            this.btnOption4.Text = "button4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOption3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.Location = new System.Drawing.Point(142, 554);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(122, 69);
            this.btnOption3.TabIndex = 40;
            this.btnOption3.Text = "button3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOption2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.Location = new System.Drawing.Point(470, 406);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(122, 69);
            this.btnOption2.TabIndex = 39;
            this.btnOption2.Text = "button2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOption1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.Location = new System.Drawing.Point(142, 406);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(122, 69);
            this.btnOption1.TabIndex = 38;
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion.Location = new System.Drawing.Point(95, 263);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(560, 80);
            this.lblQuestion.TabIndex = 37;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(753, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(248, 33);
            this.lblResult.TabIndex = 44;
            this.lblResult.Text = "results";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(196, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(434, 22);
            this.lblWelcome.TabIndex = 46;
            // 
            // ToanCoBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 645);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblResult);
            this.Name = "ToanCoBanForm";
            this.Text = "ToanCoBanForm";
            this.Load += new System.EventHandler(this.ToanCoBanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox lblWelcome;
    }
}