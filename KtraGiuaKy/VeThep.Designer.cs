namespace KtraGiuaKy
{
    partial class VeThep
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
            this.cmbCot = new System.Windows.Forms.ComboBox();
            this.txtAs = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKiemTra = new System.Windows.Forms.TextBox();
            this.cmbDuongKinh = new System.Windows.Forms.ComboBox();
            this.txtAsef = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLopBaoVe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCot
            // 
            this.cmbCot.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCot.FormattingEnabled = true;
            this.cmbCot.Location = new System.Drawing.Point(115, 122);
            this.cmbCot.Name = "cmbCot";
            this.cmbCot.Size = new System.Drawing.Size(308, 40);
            this.cmbCot.TabIndex = 0;
            this.cmbCot.SelectedIndexChanged += new System.EventHandler(this.cmbCot_SelectedIndexChanged);
            // 
            // txtAs
            // 
            this.txtAs.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAs.Location = new System.Drawing.Point(546, 124);
            this.txtAs.Name = "txtAs";
            this.txtAs.ReadOnly = true;
            this.txtAs.Size = new System.Drawing.Size(148, 39);
            this.txtAs.TabIndex = 1;
            this.txtAs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(110, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 32);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Cột";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "As,cal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "As,ef:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đường kính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKiemTra);
            this.groupBox1.Controls.Add(this.cmbDuongKinh);
            this.groupBox1.Controls.Add(this.txtAsef);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(115, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 241);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thép";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "=>";
            // 
            // txtKiemTra
            // 
            this.txtKiemTra.Location = new System.Drawing.Point(467, 160);
            this.txtKiemTra.Name = "txtKiemTra";
            this.txtKiemTra.ReadOnly = true;
            this.txtKiemTra.Size = new System.Drawing.Size(148, 39);
            this.txtKiemTra.TabIndex = 11;
            this.txtKiemTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDuongKinh
            // 
            this.cmbDuongKinh.FormattingEnabled = true;
            this.cmbDuongKinh.Items.AddRange(new object[] {
            "16",
            "18",
            "20",
            "22",
            "25",
            "28",
            "30"});
            this.cmbDuongKinh.Location = new System.Drawing.Point(253, 43);
            this.cmbDuongKinh.Name = "cmbDuongKinh";
            this.cmbDuongKinh.Size = new System.Drawing.Size(148, 40);
            this.cmbDuongKinh.TabIndex = 10;
            this.cmbDuongKinh.SelectedIndexChanged += new System.EventHandler(this.TinhToan);
            // 
            // txtAsef
            // 
            this.txtAsef.Location = new System.Drawing.Point(253, 160);
            this.txtAsef.Name = "txtAsef";
            this.txtAsef.ReadOnly = true;
            this.txtAsef.Size = new System.Drawing.Size(148, 39);
            this.txtAsef.TabIndex = 9;
            this.txtAsef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(253, 98);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(148, 39);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.TinhToan);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vẽ thép";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLopBaoVe
            // 
            this.txtLopBaoVe.Location = new System.Drawing.Point(275, 520);
            this.txtLopBaoVe.Name = "txtLopBaoVe";
            this.txtLopBaoVe.Size = new System.Drawing.Size(148, 31);
            this.txtLopBaoVe.TabIndex = 13;
            this.txtLopBaoVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VeThep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 584);
            this.Controls.Add(this.txtLopBaoVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtAs);
            this.Controls.Add(this.cmbCot);
            this.Name = "VeThep";
            this.Text = "VeThep";
            this.Load += new System.EventHandler(this.TinhToan);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCot;
        private System.Windows.Forms.TextBox txtAs;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAsef;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtKiemTra;
        private System.Windows.Forms.ComboBox cmbDuongKinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLopBaoVe;
    }
}