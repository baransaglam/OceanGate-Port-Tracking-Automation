namespace OceanGate
{
    partial class CaptchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.recaptchaBtn = new System.Windows.Forms.Button();
            this.piCaptcha = new System.Windows.Forms.PictureBox();
            this.speechBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speechBtn);
            this.groupBox1.Controls.Add(this.recaptchaBtn);
            this.groupBox1.Controls.Add(this.verifyBtn);
            this.groupBox1.Controls.Add(this.txtCaptcha);
            this.groupBox1.Controls.Add(this.piCaptcha);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "verify";
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCaptcha.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptcha.Location = new System.Drawing.Point(33, 62);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(189, 29);
            this.txtCaptcha.TabIndex = 1;
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verifyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.verifyBtn.Location = new System.Drawing.Point(33, 98);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(189, 36);
            this.verifyBtn.TabIndex = 2;
            this.verifyBtn.Text = "verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // recaptchaBtn
            // 
            this.recaptchaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recaptchaBtn.BackgroundImage")));
            this.recaptchaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recaptchaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recaptchaBtn.Location = new System.Drawing.Point(148, 22);
            this.recaptchaBtn.Name = "recaptchaBtn";
            this.recaptchaBtn.Size = new System.Drawing.Size(34, 34);
            this.recaptchaBtn.TabIndex = 3;
            this.recaptchaBtn.UseVisualStyleBackColor = true;
            this.recaptchaBtn.Click += new System.EventHandler(this.recaptchaBtn_Click);
            // 
            // piCaptcha
            // 
            this.piCaptcha.Location = new System.Drawing.Point(33, 22);
            this.piCaptcha.Name = "piCaptcha";
            this.piCaptcha.Size = new System.Drawing.Size(109, 34);
            this.piCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piCaptcha.TabIndex = 0;
            this.piCaptcha.TabStop = false;
            // 
            // speechBtn
            // 
            this.speechBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speechBtn.BackgroundImage")));
            this.speechBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speechBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speechBtn.Location = new System.Drawing.Point(188, 22);
            this.speechBtn.Name = "speechBtn";
            this.speechBtn.Size = new System.Drawing.Size(34, 34);
            this.speechBtn.TabIndex = 4;
            this.speechBtn.UseVisualStyleBackColor = true;
            this.speechBtn.Click += new System.EventHandler(this.speechBtn_Click);
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(346, 218);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox piCaptcha;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Button recaptchaBtn;
        private System.Windows.Forms.Button speechBtn;
    }
}