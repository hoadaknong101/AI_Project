
namespace AI_Project
{
    partial class frmChiTietMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietMonAn));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblCalo = new System.Windows.Forms.Label();
            this.lblNhomMon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoiKhuyen = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblMon.Location = new System.Drawing.Point(53, 101);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(68, 24);
            this.lblMon.TabIndex = 1;
            this.lblMon.Text = "Món : ";
            // 
            // lblCalo
            // 
            this.lblCalo.AutoSize = true;
            this.lblCalo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblCalo.Location = new System.Drawing.Point(53, 173);
            this.lblCalo.Name = "lblCalo";
            this.lblCalo.Size = new System.Drawing.Size(139, 24);
            this.lblCalo.TabIndex = 2;
            this.lblCalo.Text = "Tổng số calo : ";
            // 
            // lblNhomMon
            // 
            this.lblNhomMon.AutoSize = true;
            this.lblNhomMon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomMon.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNhomMon.Location = new System.Drawing.Point(53, 137);
            this.lblNhomMon.Name = "lblNhomMon";
            this.lblNhomMon.Size = new System.Drawing.Size(115, 24);
            this.lblNhomMon.TabIndex = 3;
            this.lblNhomMon.Text = "Nhóm món:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(56, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mẹo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLoiKhuyen
            // 
            this.txtLoiKhuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiKhuyen.Location = new System.Drawing.Point(57, 249);
            this.txtLoiKhuyen.Name = "txtLoiKhuyen";
            this.txtLoiKhuyen.ReadOnly = true;
            this.txtLoiKhuyen.Size = new System.Drawing.Size(454, 162);
            this.txtLoiKhuyen.TabIndex = 6;
            this.txtLoiKhuyen.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChiTietMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(570, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLoiKhuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNhomMon);
            this.Controls.Add(this.lblCalo);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTietMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT MÓN ĂN";
            this.Load += new System.EventHandler(this.frmChiTietMonAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblCalo;
        private System.Windows.Forms.Label lblNhomMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLoiKhuyen;
        private System.Windows.Forms.Button button1;
    }
}