
namespace AI_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLenThucDon = new System.Windows.Forms.Button();
            this.btnDSMonAn = new System.Windows.Forms.Button();
            this.btnNguyenLieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AI_Project.Properties.Resources.kartun_chef_png_Transparent_Images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLenThucDon
            // 
            this.btnLenThucDon.FlatAppearance.BorderSize = 3;
            this.btnLenThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLenThucDon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenThucDon.ForeColor = System.Drawing.Color.White;
            this.btnLenThucDon.Location = new System.Drawing.Point(505, 98);
            this.btnLenThucDon.Name = "btnLenThucDon";
            this.btnLenThucDon.Size = new System.Drawing.Size(402, 69);
            this.btnLenThucDon.TabIndex = 1;
            this.btnLenThucDon.Text = "LÊN THỰC ĐƠN ";
            this.btnLenThucDon.UseVisualStyleBackColor = true;
            // 
            // btnDSMonAn
            // 
            this.btnDSMonAn.FlatAppearance.BorderSize = 3;
            this.btnDSMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSMonAn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMonAn.ForeColor = System.Drawing.Color.White;
            this.btnDSMonAn.Location = new System.Drawing.Point(505, 199);
            this.btnDSMonAn.Name = "btnDSMonAn";
            this.btnDSMonAn.Size = new System.Drawing.Size(402, 69);
            this.btnDSMonAn.TabIndex = 2;
            this.btnDSMonAn.Text = "DANH SÁCH MÓN ĂN";
            this.btnDSMonAn.UseVisualStyleBackColor = true;
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.FlatAppearance.BorderSize = 3;
            this.btnNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnNguyenLieu.Location = new System.Drawing.Point(505, 303);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Size = new System.Drawing.Size(402, 69);
            this.btnNguyenLieu.TabIndex = 3;
            this.btnNguyenLieu.Text = "NGUYÊN LIỆU";
            this.btnNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 3;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(505, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(402, 69);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(996, 577);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguyenLieu);
            this.Controls.Add(this.btnDSMonAn);
            this.Controls.Add(this.btnLenThucDon);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ỨNG DỤNG THỰC ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLenThucDon;
        private System.Windows.Forms.Button btnDSMonAn;
        private System.Windows.Forms.Button btnNguyenLieu;
        private System.Windows.Forms.Button btnThoat;
    }
}