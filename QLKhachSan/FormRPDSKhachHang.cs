using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormRPDSKhachHang : Form
    {
        public FormRPDSKhachHang()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            QLKhachSanEntities context = new QLKhachSanEntities();
            var table = context.tblkhachhang;
            RPDSKhachHang rpkh = new RPDSKhachHang();
            rpkh.SetDataSource(table.ToList());
            crystalReportViewer1.ReportSource = rpkh;

        }

        private void FormRPDSKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
