namespace OceanGate
{
    partial class LogControl
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
            this.btnShowLogs = new System.Windows.Forms.Button();
            this.dvLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowLogs
            // 
            this.btnShowLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnShowLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLogs.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowLogs.ForeColor = System.Drawing.Color.White;
            this.btnShowLogs.Location = new System.Drawing.Point(209, 475);
            this.btnShowLogs.Name = "btnShowLogs";
            this.btnShowLogs.Size = new System.Drawing.Size(148, 35);
            this.btnShowLogs.TabIndex = 12;
            this.btnShowLogs.Text = "Show Logs";
            this.btnShowLogs.UseVisualStyleBackColor = false;
            this.btnShowLogs.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // dvLogs
            // 
            this.dvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLogs.Location = new System.Drawing.Point(42, 20);
            this.dvLogs.Name = "dvLogs";
            this.dvLogs.RowHeadersWidth = 51;
            this.dvLogs.RowTemplate.Height = 24;
            this.dvLogs.Size = new System.Drawing.Size(695, 422);
            this.dvLogs.TabIndex = 13;
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvLogs);
            this.Controls.Add(this.btnShowLogs);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(831, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowLogs;
        private System.Windows.Forms.DataGridView dvLogs;
    }
}
