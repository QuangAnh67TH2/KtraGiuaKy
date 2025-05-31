namespace KtraGiuaKy
{
    partial class START
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
            this.btnopen_VatLieu = new System.Windows.Forms.Button();
            this.btnopen_Cot = new System.Windows.Forms.Button();
            this.btnopen_Solieu = new System.Windows.Forms.Button();
            this.btnVeThep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopen_VatLieu
            // 
            this.btnopen_VatLieu.Location = new System.Drawing.Point(146, 109);
            this.btnopen_VatLieu.Name = "btnopen_VatLieu";
            this.btnopen_VatLieu.Size = new System.Drawing.Size(236, 82);
            this.btnopen_VatLieu.TabIndex = 0;
            this.btnopen_VatLieu.Text = "CHỌN VẬT LIỆU";
            this.btnopen_VatLieu.UseVisualStyleBackColor = true;
            this.btnopen_VatLieu.Click += new System.EventHandler(this.btnopen_VatLieu_Click);
            // 
            // btnopen_Cot
            // 
            this.btnopen_Cot.Location = new System.Drawing.Point(146, 221);
            this.btnopen_Cot.Name = "btnopen_Cot";
            this.btnopen_Cot.Size = new System.Drawing.Size(236, 82);
            this.btnopen_Cot.TabIndex = 1;
            this.btnopen_Cot.Text = "LẤY THÔNG TIN CỘT";
            this.btnopen_Cot.UseVisualStyleBackColor = true;
            this.btnopen_Cot.Click += new System.EventHandler(this.btnopen_Cot_Click);
            // 
            // btnopen_Solieu
            // 
            this.btnopen_Solieu.Location = new System.Drawing.Point(146, 336);
            this.btnopen_Solieu.Name = "btnopen_Solieu";
            this.btnopen_Solieu.Size = new System.Drawing.Size(236, 82);
            this.btnopen_Solieu.TabIndex = 2;
            this.btnopen_Solieu.Text = "SỐ LIỆU TÍNH TOÁN";
            this.btnopen_Solieu.UseVisualStyleBackColor = true;
            this.btnopen_Solieu.Click += new System.EventHandler(this.btnopen_SoLieu_Click);
            // 
            // btnVeThep
            // 
            this.btnVeThep.Location = new System.Drawing.Point(627, 109);
            this.btnVeThep.Name = "btnVeThep";
            this.btnVeThep.Size = new System.Drawing.Size(236, 82);
            this.btnVeThep.TabIndex = 3;
            this.btnVeThep.Text = "CHỌN - VẼ THÉP";
            this.btnVeThep.UseVisualStyleBackColor = true;
            this.btnVeThep.Click += new System.EventHandler(this.btnVeThep_Click);
            // 
            // START
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 647);
            this.Controls.Add(this.btnVeThep);
            this.Controls.Add(this.btnopen_Solieu);
            this.Controls.Add(this.btnopen_Cot);
            this.Controls.Add(this.btnopen_VatLieu);
            this.Name = "START";
            this.Text = "START";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen_VatLieu;
        private System.Windows.Forms.Button btnopen_Cot;
        private System.Windows.Forms.Button btnopen_Solieu;
        private System.Windows.Forms.Button btnVeThep;
    }
}