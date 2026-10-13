namespace Lab06VLE
{
    partial class NhapLieu
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
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.lblSoDong = new System.Windows.Forms.Label();
            this.lblSoCot = new System.Windows.Forms.Label();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(292, 82);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(111, 26);
            this.txtSoDong.TabIndex = 0;
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(292, 124);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(111, 26);
            this.txtSoCot.TabIndex = 1;
            // 
            // lblSoDong
            // 
            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Location = new System.Drawing.Point(215, 88);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Size = new System.Drawing.Size(69, 20);
            this.lblSoDong.TabIndex = 2;
            this.lblSoDong.Text = "Số dòng";
            // 
            // lblSoCot
            // 
            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new System.Drawing.Point(215, 130);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Size = new System.Drawing.Size(55, 20);
            this.lblSoCot.TabIndex = 3;
            this.lblSoCot.Text = "Số cột";
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(442, 82);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(132, 68);
            this.btnKhoiTao.TabIndex = 4;
            this.btnKhoiTao.Text = "Khởi tạo forrm";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // NhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.lblSoDong);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Name = "NhapLieu";
            this.Text = "NhapLieu";
            this.Load += new System.EventHandler(this.NhapLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Label lblSoDong;
        private System.Windows.Forms.Label lblSoCot;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}