
namespace AI_Project
{
    partial class frmLenThucDon
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtSoBua = new System.Windows.Forms.TextBox();
            this.txtSoCalo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9759F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(395, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LÊN THỰC ĐƠN";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(472, 188);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtSoNgay.TabIndex = 3;
            // 
            // txtSoBua
            // 
            this.txtSoBua.Location = new System.Drawing.Point(472, 246);
            this.txtSoBua.Name = "txtSoBua";
            this.txtSoBua.Size = new System.Drawing.Size(100, 20);
            this.txtSoBua.TabIndex = 4;
            // 
            // txtSoCalo
            // 
            this.txtSoCalo.Location = new System.Drawing.Point(472, 298);
            this.txtSoCalo.Name = "txtSoCalo";
            this.txtSoCalo.Size = new System.Drawing.Size(100, 20);
            this.txtSoCalo.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(485, 339);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // frmLenThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSoCalo);
            this.Controls.Add(this.txtSoBua);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmLenThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LÊN THỰC ĐƠN";
            this.Load += new System.EventHandler(this.frmLenThucDon_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtSoBua;
        private System.Windows.Forms.TextBox txtSoCalo;
        private System.Windows.Forms.Button btnStart;
    }
}