
namespace AI_Project
{
    partial class frmCongThucMon
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCongThucMon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThucMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(325, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "CÔNG THỨC MÓN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dgvCongThucMon
            // 
            this.dgvCongThucMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThucMon.Location = new System.Drawing.Point(12, 81);
            this.dgvCongThucMon.Name = "dgvCongThucMon";
            this.dgvCongThucMon.Size = new System.Drawing.Size(888, 419);
            this.dgvCongThucMon.TabIndex = 31;
            this.dgvCongThucMon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongThucMon_CellDoubleClick);
            // 
            // frmCongThucMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(912, 512);
            this.Controls.Add(this.dgvCongThucMon);
            this.Controls.Add(this.label3);
            this.Name = "frmCongThucMon";
            this.Text = "frmCongThucMon";
            this.Load += new System.EventHandler(this.frmCongThucMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThucMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCongThucMon;
    }
}