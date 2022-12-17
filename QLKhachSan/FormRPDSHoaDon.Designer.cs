
namespace QLKhachSan
{
    partial class FormRPDSHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRPDSHoaDon));
            this.btnReportHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportHD
            // 
            this.btnReportHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportHD.Location = new System.Drawing.Point(436, 23);
            this.btnReportHD.Name = "btnReportHD";
            this.btnReportHD.Size = new System.Drawing.Size(101, 39);
            this.btnReportHD.TabIndex = 1;
            this.btnReportHD.Text = "REPORT";
            this.btnReportHD.UseVisualStyleBackColor = true;
            this.btnReportHD.Click += new System.EventHandler(this.btnReportHD_Click);
            // 
            // FormRPDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 609);
            this.Controls.Add(this.btnReportHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRPDSHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Hóa Đơn";
            this.Load += new System.EventHandler(this.FormRPDSHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnReportHD;
    }
}