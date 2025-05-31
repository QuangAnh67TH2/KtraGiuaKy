namespace KtraGiuaKy
{
    partial class LayThongTinCot
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.cmbCPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(368, 540);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(209, 74);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // cmbCPosition
            // 
            this.cmbCPosition.FormattingEnabled = true;
            this.cmbCPosition.Location = new System.Drawing.Point(209, 140);
            this.cmbCPosition.Name = "cmbCPosition";
            this.cmbCPosition.Size = new System.Drawing.Size(623, 40);
            this.cmbCPosition.TabIndex = 2;
            this.cmbCPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumns_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cột";
            // 
            // btnQuet
            // 
            this.btnQuet.Location = new System.Drawing.Point(402, 382);
            this.btnQuet.Name = "btnQuet";
            this.btnQuet.Size = new System.Drawing.Size(139, 104);
            this.btnQuet.TabIndex = 4;
            this.btnQuet.Text = "QUÉT";
            this.btnQuet.UseVisualStyleBackColor = true;
            this.btnQuet.Click += new System.EventHandler(this.btnQuet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtL);
            this.groupBox1.Controls.Add(this.txth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCPosition);
            this.groupBox1.Controls.Add(this.btnQuet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 660);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CỘT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "mm";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(209, 286);
            this.txtL.Name = "txtL";
            this.txtL.ReadOnly = true;
            this.txtL.Size = new System.Drawing.Size(181, 39);
            this.txtL.TabIndex = 12;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(587, 216);
            this.txth.Name = "txth";
            this.txth.ReadOnly = true;
            this.txth.Size = new System.Drawing.Size(181, 39);
            this.txth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(774, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "h=";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(209, 212);
            this.txtb.Name = "txtb";
            this.txtb.ReadOnly = true;
            this.txtb.Size = new System.Drawing.Size(181, 39);
            this.txtb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "mm;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "L=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "b=";
            // 
            // LayThongTinCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 749);
            this.Controls.Add(this.groupBox1);
            this.Name = "LayThongTinCot";
            this.Text = "LayThongTinCot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ComboBox cmbCPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtL;
        public System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}