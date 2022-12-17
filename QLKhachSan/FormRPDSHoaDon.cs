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
    public partial class FormRPDSHoaDon : Form
    {
        public FormRPDSHoaDon()
        {
            InitializeComponent();
        }

        private void btnReportHD_Click(object sender, EventArgs e)
        {
            QLKhachSanEntities context = new QLKhachSanEntities();
            var table = context.tblhoadon;
            RPDSHoaDon rphd = new RPDSHoaDon();
            rphd.SetDataSource(table.ToList());
            crystalReportViewer1.ReportSource = rphd;
        }

        private void FormRPDSHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
