namespace OceanGate
{
    partial class UserReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ListUsers = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(445, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = " ---  USER REPORT ---";
            // 
            // btn_ListUsers
            // 
            this.btn_ListUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListUsers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListUsers.ForeColor = System.Drawing.Color.White;
            this.btn_ListUsers.Location = new System.Drawing.Point(449, 534);
            this.btn_ListUsers.Name = "btn_ListUsers";
            this.btn_ListUsers.Size = new System.Drawing.Size(176, 46);
            this.btn_ListUsers.TabIndex = 13;
            this.btn_ListUsers.Text = "List";
            this.btn_ListUsers.UseVisualStyleBackColor = false;
            this.btn_ListUsers.Click += new System.EventHandler(this.btn_ListUsers_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(41, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 412);
            this.reportViewer1.TabIndex = 14;
            // 
            // UserReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_ListUsers);
            this.Controls.Add(this.label2);
            this.Name = "UserReportControl";
            this.Size = new System.Drawing.Size(1096, 713);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ListUsers;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
